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

        private List<Ingredient>? Ingredients;

        private Dish dish;

        public IngredientToDishChangeForm(Dish dish, MainWindow mainForm, ChangeDishForm callerForm)
        {
            InitializeComponent();
            this.dish = dish;
            MainForm = mainForm;
            CallerForm = callerForm;
            Ingredients = (CallerForm.NewIngredients != null) ? CallerForm.NewIngredients.ToList() : null;
            BindDataGridView(ContainedIngredientsDataGridView, Ingredients);
            BindDataGridView(AllIngredientsDataGridView, Ingredient.IngredientList);
        }

        private void BindDataGridView(DataGridView dataGridView, List<Ingredient>? ingredients)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ingredients;
            dataGridView.Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<Ingredient>? ingredients = GetIngredientList(AllIngredientsDataGridView);
            if (ingredients != null && ingredients.Count > 0)
            {
                if (Ingredients != null)
                {
                    foreach (Ingredient ingredient in ingredients)
                    {
                        if (AddIngredient(ingredient) == false)
                        {
                            MessageBox.Show("Ingredient(s) cannot be added. No duplicates allowed.", "Error");
                        }
                    }
                    Ingredients.Sort((x, y) => String.Compare(x.Name, y.Name));
                }
                else
                {
                    Ingredients = ingredients.ToList();
                    Ingredients.Sort((x, y) => String.Compare(x.Name, y.Name));
                }
                BindDataGridView(ContainedIngredientsDataGridView, Ingredients);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<Ingredient>? ingredients = GetIngredientList(ContainedIngredientsDataGridView);
            if (ingredients != null && ingredients.Count > 0)
            {
                if (Ingredients != null)
                {
                    foreach (Ingredient ingredient in ingredients)
                    {
                        Ingredients.Remove(ingredient);
                    }
                    BindDataGridView(ContainedIngredientsDataGridView, Ingredients);
                }
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            CallerForm.SetNewIngredients(Ingredients);
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

        private bool AddIngredient(Ingredient ingredient)
        {
            if (Ingredients == null || Ingredients.Any(ingredientInList => String.Compare(ingredientInList.Name, ingredient.Name) == 0))
            {
                return false;
            }
            Ingredients.Add(ingredient);
            return true;
        }

        private void ContainedIngredientsSearchBox_TextChanged(object sender, EventArgs e)
        {
            string? name = ContainedIngredientsSearchBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                BindDataGridView(ContainedIngredientsDataGridView, Ingredients);
                return;
            }
            if (Ingredients == null) return;
            List<Ingredient> temp = new List<Ingredient>();
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.Name == name)
                {
                    temp.Add(ingredient);
                    break;
                }
            }
            BindDataGridView(ContainedIngredientsDataGridView, temp);
        }
        
        private void AllIngredientsSearchBox_TextChanged(object sender, EventArgs e)
        {
            string? name = AllIngredientsSearchBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                BindDataGridView(AllIngredientsDataGridView, Ingredient.IngredientList);
                return;
            }
            List<Ingredient> temp = new List<Ingredient>();
            foreach (Ingredient ingredient in Ingredient.IngredientList)
            {
                if (ingredient.Name == name)
                {
                    temp.Add(ingredient);
                    break;
                }
            }
            BindDataGridView(AllIngredientsDataGridView, temp);
        }
    }
}
