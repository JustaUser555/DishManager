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
    public partial class ChangeDishForm : Form
    {
        public List<Ingredient>? NewIngredients { get; private set; } = null;

        private MainWindow MainForm;

        private Dish dish;

        public ChangeDishForm(Dish dish, MainWindow mainForm)
        {
            InitializeComponent();
            this.dish = dish;
            NewIngredients = (dish.Dependencies != null) ? dish.Dependencies.ToList() : null;
            MainForm = mainForm;
            LoadData();
        }

        public void SetNewIngredients(List<Ingredient>? ingredientList)
        {
            if (ingredientList != null)
            {
                if (ingredientList.Count == 0) NewIngredients = null;
                else NewIngredients = ingredientList.ToList();
            }
            else
            {
                NewIngredients = null;
            }
        }

        private void LoadData()
        {
            NameTextBox.Text = dish.Name;
            RecipeTextBox.Text = dish.Recipe;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if(dish.SetName(NameTextBox.Text) == false)
            {
                MessageBox.Show("Name not allowed, already taken.", "Error");
                return;
            } 
            dish.Recipe = RecipeTextBox.Text;
            if (dish.SetDependencies(NewIngredients) == false)
            {
                MessageBox.Show("Ingredient(s) cannot be added. No duplicates allowed.", "Error");
                return;
            }
            MainForm.RefreshDishes();
            MainForm.SetSaveChangesFlagTrue();
            this.Close();
        }

        private void ChangeIngredientToDish_Click(object sender, EventArgs e)
        {
            IngredientToDishChangeForm ingredientToDishChangeForm = new IngredientToDishChangeForm(dish, MainForm, this);
            ingredientToDishChangeForm.ShowDialog();
        }

    }
}
