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
        private MainWindow MainForm;

        private Dish dish;
        public ChangeDishForm(Dish dish, MainWindow mainForm)
        {
            InitializeComponent();
            this.dish = dish;
            MainForm = mainForm;
            LoadData();
        }

        private void LoadData()
        {
            NameTextBox.Text = dish.Name;
            RecipeTextBox.Text = dish.Recipe;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            dish.Name = NameTextBox.Text;
            dish.Recipe = RecipeTextBox.Text;
            MainForm.RefreshDishes();
            this.Close();
        }
    }
}
