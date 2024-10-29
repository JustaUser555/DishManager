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
    public partial class ChangeIngredientForm : Form
    {
        private Ingredient ingredient;

        private MainWindow MainForm;

        public ChangeIngredientForm(Ingredient ingredient, MainWindow mainForm)
        {
            InitializeComponent();
            this.ingredient = ingredient;
            MainForm = mainForm;
            LoadData(ingredient);
        }

        private void LoadData(Ingredient ingredient)
        {
            NameTextBox.Text = ingredient.Name;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if(ingredient.SetName(NameTextBox.Text) == false)
            {
                MessageBox.Show("Name not allowed, already taken.", "Error");
                return;
            }
            MainForm.RefreshIngredients();
            MainForm.RefreshDishes();
            this.Close();
        }
    }
}
