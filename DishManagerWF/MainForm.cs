using DishManagerLibrary;
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
            if (selectedTab != null)
            {
                if (selectedTab == DishTabPage)
                {
                    Int32 selectedRowCount = DataGridDishes.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("No rows selected!", "Error");
                    }
                    else if (selectedRowCount == 1)
                    {
                        int selectedRow = DataGridDishes.SelectedRows[0].Index;
                        object bindingElement = DataGridDishes.Rows[selectedRow].DataBoundItem;
                        if (bindingElement != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this dish?", "Delete Dish", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                try
                                {
                                    Dish dishToRemove = Dish.DishList[selectedRow];
                                    if (dishToRemove != null) {
                                        bool returnValue = Dish.RemoveDish(dishToRemove);
                                        if (returnValue == false)
                                        {
                                            MessageBox.Show("An internal error occured during the deletion process, the dish has probably not been deleted.", "Error");
                                        }
                                        DishView.InitializeDishList();
                                        RefreshDishes();
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("An internal error occured during the deletion process, the dish has probably not been deleted.", "Error");
                                }
                            }
                        } else
                        {
                            MessageBox.Show("The DataBoundItem is null.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too many rows selected, you can select only one row at once.", "Error");
                    }
                }
                else if (selectedTab == IngredientsTabPage)
                {
                    Int32 selectedRowCount = DataGridIngredients.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("No rows selected!", "Error");
                    }
                    else if (selectedRowCount == 1)
                    {
                        int selectedRow = DataGridIngredients.SelectedRows[0].Index;
                        object bindingElement = DataGridIngredients.Rows[selectedRow].DataBoundItem;
                        if (bindingElement != null)
                        {
                            Ingredient? ingredientToRemove = bindingElement as Ingredient;
                            if (ingredientToRemove != null)
                            {
                                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this ingredient? Note that this will remove the ingredient from all dishes that contain it.", "Delete Ingredient", MessageBoxButtons.YesNo);
                                if(dialogResult == DialogResult.Yes)
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
                            else
                            {
                                MessageBox.Show("The data binding object could not be cast to the expected type.", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The DataBoundItem is null.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too many rows selected, you can select only one row at once.", "Error");
                    }
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
    }
}