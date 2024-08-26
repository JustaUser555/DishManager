using DishManagerLibrary;
using System.Windows.Forms;

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
                        MessageBox.Show("No rows selected!");
                    }
                    else if (selectedRowCount == 1)
                    {
                        int selectedRow = DataGridDishes.SelectedRows[0].Index;
                        object bindingElement = DataGridDishes.Rows[selectedRow].DataBoundItem;
                        if (bindingElement != null)
                        {
                            Dish? dishToRemove = bindingElement as Dish;
                            if (dishToRemove != null)
                            {
                                bool returnValue = Dish.RemoveDish(dishToRemove);
                                if(returnValue == true)
                                {
                                    MessageBox.Show("The dish has been succesfully deleted.");    
                                }
                                else
                                {
                                    MessageBox.Show("An internal error occured during the deletion process, the dish has probably not been deleted.");
                                }
                                RefreshDishes();
                            }
                            else
                            {
                                MessageBox.Show("The data binding object could not be cast to the expected type.");
                            }
                        } else
                        {
                            MessageBox.Show("The DataBoundItem is null.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too many rows selected, you can select only one row at once.");
                    }
                }
                else if (selectedTab == IngredientsTabPage)
                {
                    Int32 selectedRowCount = DataGridIngredients.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount <= 0)
                    {
                        MessageBox.Show("No rows selected!");
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
                                bool returnValue = Ingredient.RemoveIngredient(ingredientToRemove);
                                if (returnValue == true)
                                {
                                    MessageBox.Show("The ingredient has been succesfully deleted.");
                                }
                                else
                                {
                                    MessageBox.Show("An internal error occured during the deletion process, the ingredient has probably not been deleted.");
                                }
                                RefreshIngredients();
                            }
                            else
                            {
                                MessageBox.Show("The data binding object could not be cast to the expected type.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The DataBoundItem is null.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Too many rows selected, you can select only one at once.");
                    }
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
            DataGridDishes.DataSource = null;
            DataGridDishes.DataSource = Dish.DishList;
            DataGridDishes.Refresh();
        }
    }
}