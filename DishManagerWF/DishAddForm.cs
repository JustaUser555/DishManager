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
    public partial class DishAddForm : Form
    {
        private MainWindow MainForm;

        public List<Ingredient>? Ingredients { get; private set; } = null;

        public DishAddForm(MainWindow form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string recipe = RecipeTextBox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    Dish dish = new Dish(name, recipe, Ingredients);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
                
                MainForm.RefreshDishes();
                MainForm.SetSaveChangesFlagTrue();
                this.Close();
            }
        }

        public void SetIngredients(List<Ingredient>? ingredientList)
        {
            if (ingredientList != null)
            {
                if (ingredientList.Count == 0) Ingredients = null;
                else Ingredients = ingredientList.ToList();
            }
            else
            {
                Ingredients = null;
            }
        }

        private void AddIngredientToDish_Click(object sender, EventArgs e)
        {
            IngredientToDishAddForm form = new IngredientToDishAddForm(this, MainForm);
            form.ShowDialog();
        }
    }
}
