using DishManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishManagerWF
{
    public partial class IngredientToDishChangeForm : Form
    {
        private MainWindow MainForm;

        private ChangeDishForm CallerForm;

        private List<Ingredient>? NewIngredients;

        private Dish dish;

        public IngredientToDishChangeForm(Dish dish, MainWindow mainForm, ChangeDishForm callerForm)
        {
            InitializeComponent();
            this.dish = dish;
            MainForm = mainForm;
            CallerForm = callerForm;
            NewIngredients = dish.Dependencies;
            FillAllIngredientsGrid();
            FillContainedIngredientsGrid();
        }

        private void FillContainedIngredientsGrid()
        {
            ContainedIngredientsDataGridView.DataSource = null;
            ContainedIngredientsDataGridView.DataSource = NewIngredients;
            ContainedIngredientsDataGridView.Refresh();
        }

        private void FillAllIngredientsGrid()
        {
            AllIngredientsDataGridView.DataSource = null;
            AllIngredientsDataGridView.DataSource = Ingredient.IngredientList;
            ContainedIngredientsDataGridView.Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<Ingredient>? ingredients = GetIngredientList(AllIngredientsDataGridView);
            if (ingredients != null && ingredients.Count > 0)
            {
                if (NewIngredients != null)
                {
                    foreach (Ingredient ingredient in ingredients)
                    {
                        NewIngredients.Add(ingredient);
                    }
                    NewIngredients.Sort((x, y) => String.Compare(x.Name, y.Name));
                } else
                {
                    NewIngredients = ingredients;
                }
                FillContainedIngredientsGrid();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<Ingredient>? ingredients = GetIngredientList(ContainedIngredientsDataGridView);
            if (ingredients != null && ingredients.Count > 0)
            {
                if (NewIngredients != null)
                {
                    foreach (Ingredient ingredient in ingredients)
                    {
                        NewIngredients.Remove(ingredient);
                    }
                    FillContainedIngredientsGrid();
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            CallerForm.SetNewIngredients(NewIngredients);
            this.Close();
        }

        private Ingredient? GetIngredient(int selectedRow, DataGridView dataGridView)
        {
            object bindingElement = dataGridView.Rows[selectedRow].DataBoundItem;
            if (bindingElement != null)
            {
                return bindingElement as Ingredient;
            }
            return null;
        }

        private List<Ingredient>? GetIngredientList(DataGridView dataGridView)
        {
            bool giveErrorMessage = false;
            Int32 selectedRowCount = dataGridView.SelectedRows.Count;

            if (selectedRowCount <= 0)
            {
                MessageBox.Show("No rows selected!", "Error");
                return null;
            }

            List<Ingredient> ingredientList = new List<Ingredient>();

            for (int i = 0; i < selectedRowCount; i++)
            {
                int selectedRow = dataGridView.SelectedRows[i].Index;
                Ingredient? ingredient = GetIngredient(selectedRow, dataGridView);
                if (ingredient != null)
                {
                    ingredientList.Add(ingredient);
                }
                else
                {
                    giveErrorMessage = true;
                }
            }

            if (giveErrorMessage)
            {
                MessageBox.Show("An unknown error occurred.", "Error");
            }

            return ingredientList;
        }
    }
}
