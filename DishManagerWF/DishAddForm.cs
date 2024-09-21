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

        public List<Ingredient>? Ingredients;

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
                if(Dish.CreateDish(name, recipe, Ingredients) == false)
                {
                    MessageBox.Show("Name not allowed, already taken.", "Error");
                    return;
                }
                DishView.InitializeDishList();
                MainForm.RefreshDishes();
                this.Close();
            }
        }

        private void AddIngredientToDish_Click(object sender, EventArgs e)
        {
            IngredientToDishAddForm form = new IngredientToDishAddForm(this);
            form.ShowDialog();
        }
    }
}
