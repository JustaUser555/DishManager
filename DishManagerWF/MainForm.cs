using DishManagerLibrary;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace DishManagerWF
{
    public partial class MainWindow : Form
    {
        private JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            Formatting = Formatting.Indented
        };

        private const string Folder = "DishManagerWF";

        private bool UnsavedChanges = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadData();
            RefreshDishes();
            RefreshIngredients();
        }

        private void ButtonToSaveChanges_Click(object sender, EventArgs e)
        {
            if (!SaveData())
            {
                MessageBox.Show("An Error occured while saving. The changes could not be saved.", "Error");
                return;
            }
            UnsavedChanges = false;
        }

        public void SetSaveChangesFlagTrue()
        {
            UnsavedChanges = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TabPage? selectedTab = tabControl.SelectedTab;
            if (selectedTab != null)
            {
                if (selectedTab == DishTabPage)
                {
                    DishAddForm dishAddForm = new DishAddForm(this);
                    dishAddForm.ShowDialog();
                }
                else if (selectedTab == IngredientsTabPage)
                {
                    IngredientAddForm ingredientAddForm = new IngredientAddForm(this);
                    ingredientAddForm.ShowDialog();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TabPage? selectedTab = tabControl.SelectedTab;
            if (selectedTab != null && selectedTab == DishTabPage)
            {
                if (CheckSelectedRow(DishTabPage) == 1)
                {
                    DeleteDish();
                    SetSaveChangesFlagTrue();
                }
            }
            else if (selectedTab != null && selectedTab == IngredientsTabPage)
            {
                if (CheckSelectedRow(IngredientsTabPage) == 1)
                {
                    DeleteIngredient();
                    SetSaveChangesFlagTrue();
                }
            }
        }

        private int CheckSelectedRow(object selectedTab)
        {
            Int32 selectedRowCount = 0;
            if (selectedTab == DishTabPage)
            {
                selectedRowCount = DataGridDishes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            }
            else if (selectedTab == IngredientsTabPage)
            {
                selectedRowCount = DataGridIngredients.Rows.GetRowCount(DataGridViewElementStates.Selected);
            }

            if (selectedRowCount <= 0)
            {
                MessageBox.Show("No rows selected!", "Error");
                return 0;
            }
            else if (selectedRowCount == 1)
            {
                return 1;
            }
            else
            {
                MessageBox.Show("Too many rows selected, you can select only one row at once.", "Error");
                return 0;
            }
        }

        private void DeleteDish()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this dish?", "Delete Dish", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Dish? dishToRemove = GetDish();
                if (dishToRemove != null)
                {
                    bool returnValue = Dish.RemoveDish(dishToRemove);
                    if (returnValue == false)
                    {
                        MessageBox.Show("An internal error occured during the deletion process, the dish has probably not been deleted.", "Error");
                    }
                    DishView.InitializeDishList();
                    RefreshDishes();
                }
            }
        }

        private void DeleteIngredient()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this ingredient? Note that this will remove the ingredient from all dishes that contain it.", "Delete Ingredient", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Ingredient? ingredientToRemove = GetIngredient();
                if (ingredientToRemove != null)
                {
                    DeleteDishDependencies(ingredientToRemove);
                    bool returnValue = Ingredient.RemoveIngredient(ingredientToRemove);
                    if (returnValue == false)
                    {
                        MessageBox.Show("An internal error occured during the deletion process, the ingredient has probably not been deleted.", "Error");
                    }
                    RefreshIngredients();
                    RefreshDishes();
                }
            }
        }

        private void DeleteDishDependencies(Ingredient ingredientToRemove)
        {
            foreach (Dish dish in Dish.DishList)
            {
                if (dish.Dependencies != null && dish.Dependencies.Contains(ingredientToRemove))
                {
                    dish.Dependencies.Remove(ingredientToRemove);
                    if (dish.Dependencies.Count == 0) dish.SetDependencies(null);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TabPage? selectedTab = tabControl.SelectedTab;
            if (selectedTab != null)
            {
                if (selectedTab == DishTabPage)
                {
                    RefreshDishes();
                }
                else if (selectedTab == IngredientsTabPage)
                {
                    RefreshIngredients();
                }
            }
        }

        public void RefreshIngredients()
        {
            DataGridIngredients.DataSource = null;
            if (Ingredient.IngredientList.Count > 0)
            {
                DataGridIngredients.DataSource = Ingredient.IngredientList;
            }
            DataGridIngredients.Refresh();
        }

        public void RefreshDishes()
        {
            DishView.InitializeDishList();
            DataGridDishes.DataSource = null;
            if (Dish.DishList.Count > 0)
            {
                DataGridDishes.DataSource = DishView.DishList;
            }
            DataGridDishes.Refresh();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            TabPage? selectedTab = tabControl.SelectedTab;
            if (selectedTab != null && selectedTab == DishTabPage)
            {
                if (CheckSelectedRow(DishTabPage) == 1)
                {
                    Dish? dish = GetDish();
                    if (dish != null)
                    {
                        ChangeDishForm changeDishForm = new ChangeDishForm(dish, this);
                        changeDishForm.ShowDialog();
                    }
                }
            }
            else if (selectedTab != null && selectedTab == IngredientsTabPage)
            {
                if (CheckSelectedRow(IngredientsTabPage) == 1)
                {
                    Ingredient? ingredient = GetIngredient();
                    if (ingredient != null)
                    {
                        ChangeIngredientForm changeIngredientForm = new ChangeIngredientForm(ingredient, this);
                        changeIngredientForm.ShowDialog();
                    }
                }
            }
        }

        private Dish? GetDish()
        {
            int selectedRow = DataGridDishes.SelectedRows[0].Index;
            object bindingElement = DataGridDishes.Rows[selectedRow].DataBoundItem;
            if (bindingElement != null)
            {
                DishView? dish = bindingElement as DishView;
                if (dish != null)
                {
                    for (int i = 0; i < DishView.DishList.Count; i++)
                    {
                        if (dish == DishView.DishList[i])
                        {
                            return Dish.DishList[i];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The data binding object could not be cast to the expected type.", "Error");
                }
            }
            else
            {
                MessageBox.Show("The DataBoundItem is null.", "Error");
            }
            return null;
        }

        private Ingredient? GetIngredient()
        {
            int selectedRow = DataGridIngredients.SelectedRows[0].Index;
            object bindingElement = DataGridIngredients.Rows[selectedRow].DataBoundItem;
            if (bindingElement != null)
            {
                Ingredient? ingredient = bindingElement as Ingredient;
                if (ingredient != null)
                {
                    return ingredient;
                }
                else
                {
                    MessageBox.Show("The data binding object could not be cast to the expected type.", "Error");
                }
            }
            else
            {
                MessageBox.Show("The DataBoundItem is null.", "Error");
            }
            return null;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string? name = SearchBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                RefreshDishes();
                RefreshIngredients();
                return;
            }
            TabPage? selectedTab = tabControl.SelectedTab;
            if (selectedTab != null)
            {
                if (selectedTab == DishTabPage)
                {
                    if(DishView.DishList.Count == 0) return;
                    List<DishView> dishList = SearchDish(name);
                    DataGridDishes_BindLocalList(dishList);

                }
                else if (selectedTab == IngredientsTabPage)
                {
                    if(Ingredient.IngredientList.Count == 0) return;
                    List<Ingredient> ingredientList = SearchIngredient(name);
                    DataGridIngredients_BindLocalList(ingredientList);
                }
            }
        }

        private List<Ingredient> SearchIngredient(string name)
        {
            List<Ingredient> ingredientList = new List<Ingredient>();
            foreach (Ingredient ingredient in Ingredient.IngredientList)
            {
                if (ingredient.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
                {
                    ingredientList.Add(ingredient);
                }
            }
            return ingredientList;
        }

        private List<DishView> SearchDish(string name)
        {
            List<DishView> dishList = new List<DishView>();
            foreach (DishView dish in DishView.DishList)
            {
                if (dish.Name != null && dish.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase))
                {
                    dishList.Add(dish);
                }
            }
            return dishList;
        }

        private void DataGridDishes_BindLocalList(List<DishView> list)
        {
            DataGridDishes.DataSource = null;
            DataGridDishes.DataSource = list;
            DataGridDishes.Refresh();
        }

        private void DataGridIngredients_BindLocalList(List<Ingredient> list)
        {
            DataGridIngredients.DataSource = null;
            DataGridIngredients.DataSource = list;
            DataGridIngredients.Refresh();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedChanges)
            {
                DialogResult result = MessageBox.Show("There are unsaved changes. Would you like to save before closing?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);


                switch(result)
                {
                    case DialogResult.Yes:
                        bool returnValue = SaveData();
                        if (!returnValue)
                        {
                            MessageBox.Show("An error occured while saving. The changes could not be saved.", "Error");
                            e.Cancel = true;
                        }
                        break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel = true; break;
                }
            }
        }

        private bool SaveData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specialFolder = Path.Combine(appDataPath, Folder);

            try
            {
                if (!Directory.Exists(specialFolder))
                {
                    Directory.CreateDirectory(specialFolder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error");
                return false;
            }

            CompleteData completeData = new CompleteData();
            string file = Path.Combine(specialFolder, "Data.json");
            string? data = SerializeJson(completeData);

            if(data == null)
            {
                return false;
            }

            try
            {
                File.WriteAllText(file, data);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Permission denied to write to file {file}: {ex.Message}", "Error");
                return false;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"File {file} is being used by another process: {ex.Message}", "Error");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error writing to file {file}: {ex.Message}", "Error");
                return false;
            }
            return true;
        }

        private CompleteData? LoadData()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specialFolder = Path.Combine(appDataPath, Folder);

            if (!Directory.Exists(specialFolder))
            {
                return null;
            }

            string file = Path.Combine(specialFolder, "Data.json");

            if (File.Exists(file))
            {
                try
                {
                    string jsonData = File.ReadAllText(file);
                    return DeserializeJson<CompleteData>(jsonData);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Permission denied to read file {file}: {ex.Message}", "Error");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"File {file} is being used by another process: {ex.Message}", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error");
                }
            }
            return null;
        }

        private string? SerializeJson<T>(T data)
        {
            try
            {
                string serializedObject = JsonConvert.SerializeObject(data, JsonSettings);
                return serializedObject;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return null;
            }
        }

        private T? DeserializeJson<T>(string json)
        {
            try
            {
                var objects = JsonConvert.DeserializeObject<T>(json, JsonSettings);
                return objects;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return default;
            }
        }
    }
}