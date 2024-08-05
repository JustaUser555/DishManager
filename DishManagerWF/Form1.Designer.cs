namespace DishManagerWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            DishTabPage = new TabPage();
            IngredientsTabPage = new TabPage();
            DataGridDishes = new DataGridView();
            dishViewBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientsAsStringDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataGridIngredients = new DataGridView();
            ingredientBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ButtonToSaveChanges = new Button();
            tabControl1.SuspendLayout();
            DishTabPage.SuspendLayout();
            IngredientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(DishTabPage);
            tabControl1.Controls.Add(IngredientsTabPage);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 409);
            tabControl1.TabIndex = 0;
            // 
            // DishTabPage
            // 
            DishTabPage.Controls.Add(DataGridDishes);
            DishTabPage.Location = new Point(4, 24);
            DishTabPage.Name = "DishTabPage";
            DishTabPage.Padding = new Padding(3);
            DishTabPage.Size = new Size(792, 422);
            DishTabPage.TabIndex = 0;
            DishTabPage.Text = "Dishes";
            DishTabPage.UseVisualStyleBackColor = true;
            // 
            // IngredientsTabPage
            // 
            IngredientsTabPage.Controls.Add(DataGridIngredients);
            IngredientsTabPage.Location = new Point(4, 24);
            IngredientsTabPage.Name = "IngredientsTabPage";
            IngredientsTabPage.Padding = new Padding(3);
            IngredientsTabPage.Size = new Size(792, 381);
            IngredientsTabPage.TabIndex = 1;
            IngredientsTabPage.Text = "Ingredients";
            IngredientsTabPage.UseVisualStyleBackColor = true;
            // 
            // DataGridDishes
            // 
            DataGridDishes.AllowUserToAddRows = false;
            DataGridDishes.AllowUserToDeleteRows = false;
            DataGridDishes.AutoGenerateColumns = false;
            DataGridDishes.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            DataGridDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDishes.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, recipeDataGridViewTextBoxColumn, ingredientsAsStringDataGridViewTextBoxColumn });
            DataGridDishes.DataSource = dishViewBindingSource;
            DataGridDishes.Dock = DockStyle.Fill;
            DataGridDishes.Location = new Point(3, 3);
            DataGridDishes.Name = "DataGridDishes";
            DataGridDishes.Size = new Size(786, 416);
            DataGridDishes.TabIndex = 0;
            // 
            // dishViewBindingSource
            // 
            dishViewBindingSource.DataSource = typeof(DishManagerLibrary.DishView);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // recipeDataGridViewTextBoxColumn
            // 
            recipeDataGridViewTextBoxColumn.DataPropertyName = "Recipe";
            recipeDataGridViewTextBoxColumn.HeaderText = "Recipe";
            recipeDataGridViewTextBoxColumn.Name = "recipeDataGridViewTextBoxColumn";
            recipeDataGridViewTextBoxColumn.Width = 249;
            // 
            // ingredientsAsStringDataGridViewTextBoxColumn
            // 
            ingredientsAsStringDataGridViewTextBoxColumn.DataPropertyName = "IngredientsAsString";
            ingredientsAsStringDataGridViewTextBoxColumn.HeaderText = "IngredientsAsString";
            ingredientsAsStringDataGridViewTextBoxColumn.Name = "ingredientsAsStringDataGridViewTextBoxColumn";
            ingredientsAsStringDataGridViewTextBoxColumn.Width = 250;
            // 
            // DataGridIngredients
            // 
            DataGridIngredients.AutoGenerateColumns = false;
            DataGridIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridIngredients.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1 });
            DataGridIngredients.DataSource = ingredientBindingSource;
            DataGridIngredients.Dock = DockStyle.Fill;
            DataGridIngredients.Location = new Point(3, 3);
            DataGridIngredients.Name = "DataGridIngredients";
            DataGridIngredients.Size = new Size(786, 375);
            DataGridIngredients.TabIndex = 0;
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // ButtonToSaveChanges
            // 
            ButtonToSaveChanges.Location = new Point(713, 418);
            ButtonToSaveChanges.Name = "ButtonToSaveChanges";
            ButtonToSaveChanges.Size = new Size(75, 23);
            ButtonToSaveChanges.TabIndex = 1;
            ButtonToSaveChanges.Text = "Save";
            ButtonToSaveChanges.UseVisualStyleBackColor = true;
            ButtonToSaveChanges.Click += ButtonToSaveChanges_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonToSaveChanges);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            DishTabPage.ResumeLayout(false);
            IngredientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage DishTabPage;
        private TabPage IngredientsTabPage;
        private DataGridView DataGridDishes;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingredientsAsStringDataGridViewTextBoxColumn;
        private BindingSource dishViewBindingSource;
        private DataGridView DataGridIngredients;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private BindingSource ingredientBindingSource;
        private Button ButtonToSaveChanges;
    }
}
