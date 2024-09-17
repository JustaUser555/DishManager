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

        private Dish dish;

        public IngredientToDishChangeForm(Dish dish, MainWindow mainForm)
        {
            InitializeComponent();
            this.dish = dish;
            MainForm = mainForm;
            FillAllIngredientsGrid();
            FillContainedIngredientsGrid();
        }

        private void FillContainedIngredientsGrid()
        {
            ContainedIngredientsDataGridView.DataSource = null;
            ContainedIngredientsDataGridView.DataSource = dish.Dependencies;
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

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
