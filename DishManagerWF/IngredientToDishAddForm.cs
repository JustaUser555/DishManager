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
    public partial class IngredientToDishAddForm : Form
    {
        private DishAddForm parentForm;

        public IngredientToDishAddForm(DishAddForm form)
        {
            InitializeComponent();
            parentForm = form;
            AddIngredientDataGridView.DataSource = null;
            AddIngredientDataGridView.DataSource = Ingredient.IngredientList;
            AddIngredientDataGridView.Refresh();
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = AddIngredientDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount >= 1)
            {
                List<Ingredient> ingredientsInDish = new List<Ingredient>();

                for (int i = 0; i < selectedRowCount; i++) {
                    int selectedRow = AddIngredientDataGridView.SelectedRows[i].Index;
                    Ingredient? ingredientToAdd = AddIngredientDataGridView.Rows[selectedRow].DataBoundItem as Ingredient;
                    if (ingredientToAdd != null) {
                        ingredientsInDish.Add(ingredientToAdd);
                    }
                    else
                    {
                        MessageBox.Show("The data binding object is either null or could not be cast to the expected type.");
                    }
                }
                ingredientsInDish.Sort((x, y) => String.Compare(x.Name, y.Name));
                parentForm.Ingredients = ingredientsInDish;
            }
            this.Close();
        }
    }
}
