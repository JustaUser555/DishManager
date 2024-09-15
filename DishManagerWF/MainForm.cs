using DishManagerLibrary;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DishManagerWF
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonToSaveChanges_Click(object sender, EventArgs e)
        {
            //make a function that reads and writes to a file using the json extension
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
                }
            }
            else if (selectedTab != null && selectedTab == IngredientsTabPage)
            {
                if (CheckSelectedRow(IngredientsTabPage) == 1)
                {
                    DeleteIngredient();
                }
            }
        }

        private int CheckSelectedRow(object selectedTab)
        {
            Int32 selectedRowCount = 0;
            if (selectedTab == DishTabPage)
            {
                selectedRowCount = DataGridDishes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            } else if (selectedTab == IngredientsTabPage)
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
            DataGridIngredients.DataSource = Ingredient.IngredientList;
            DataGridIngredients.Refresh();
        }

        public void RefreshDishes()
        {
            DishView.InitializeDishList();
            DataGridDishes.DataSource = null;
            DataGridDishes.DataSource = DishView.DishList;
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
                try
                {
                    Dish dish = Dish.DishList[selectedRow];
                    if (dish != null)
                    {
                        return dish;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An internal error occured during the deletion process, the dish has probably not been deleted.", "Error");
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
    }
}