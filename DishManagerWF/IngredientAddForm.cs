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
    public partial class IngredientAddForm : Form
    {
        private MainWindow MainForm;
        public IngredientAddForm(MainWindow form)
        {
            InitializeComponent();
            this.MainForm = form;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (!string.IsNullOrEmpty(name)) { 
                Ingredient newIngredient = new Ingredient(name);
                MainForm.RefreshIngredients();
                this.Close();
            }
        }
    }
}
