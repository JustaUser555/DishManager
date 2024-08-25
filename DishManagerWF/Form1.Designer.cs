namespace DishManagerWF
{
    partial class MainWindow
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
            tabControl = new TabControl();
            DishTabPage = new TabPage();
            DataGridDishes = new DataGridView();
            DishNameColumn = new DataGridViewTextBoxColumn();
            DishRecipeColumn = new DataGridViewTextBoxColumn();
            DishIngredientsColumn = new DataGridViewTextBoxColumn();
            dishViewBindingSource = new BindingSource(components);
            IngredientsTabPage = new TabPage();
            DataGridIngredients = new DataGridView();
            IngredientsNameColumn = new DataGridViewTextBoxColumn();
            ingredientBindingSource = new BindingSource(components);
            ButtonToSaveChanges = new Button();
            tabControl.SuspendLayout();
            DishTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishViewBindingSource).BeginInit();
            IngredientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(DishTabPage);
            tabControl.Controls.Add(IngredientsTabPage);
            tabControl.Location = new Point(0, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 409);
            tabControl.TabIndex = 0;
            // 
            // DishTabPage
            // 
            DishTabPage.Controls.Add(DataGridDishes);
            DishTabPage.Location = new Point(4, 24);
            DishTabPage.Name = "DishTabPage";
            DishTabPage.Padding = new Padding(3);
            DishTabPage.Size = new Size(792, 381);
            DishTabPage.TabIndex = 0;
            DishTabPage.Text = "Dishes";
            DishTabPage.UseVisualStyleBackColor = true;
            // 
            // DataGridDishes
            // 
            DataGridDishes.AllowUserToAddRows = false;
            DataGridDishes.AllowUserToDeleteRows = false;
            DataGridDishes.AutoGenerateColumns = false;
            DataGridDishes.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            DataGridDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridDishes.Columns.AddRange(new DataGridViewColumn[] { DishNameColumn, DishRecipeColumn, DishIngredientsColumn });
            DataGridDishes.DataSource = dishViewBindingSource;
            DataGridDishes.Dock = DockStyle.Fill;
            DataGridDishes.Location = new Point(3, 3);
            DataGridDishes.Name = "DataGridDishes";
            DataGridDishes.Size = new Size(786, 375);
            DataGridDishes.TabIndex = 0;
            // 
            // DishNameColumn
            // 
            DishNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishNameColumn.DataPropertyName = "Name";
            DishNameColumn.HeaderText = "Name";
            DishNameColumn.Name = "DishNameColumn";
            // 
            // DishRecipeColumn
            // 
            DishRecipeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishRecipeColumn.DataPropertyName = "Recipe";
            DishRecipeColumn.HeaderText = "Recipe";
            DishRecipeColumn.Name = "DishRecipeColumn";
            // 
            // DishIngredientsColumn
            // 
            DishIngredientsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishIngredientsColumn.DataPropertyName = "IngredientsAsString";
            DishIngredientsColumn.HeaderText = "IngredientsAsString";
            DishIngredientsColumn.Name = "DishIngredientsColumn";
            // 
            // dishViewBindingSource
            // 
            dishViewBindingSource.DataSource = typeof(DishManagerLibrary.DishView);
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
            // DataGridIngredients
            // 
            DataGridIngredients.AutoGenerateColumns = false;
            DataGridIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridIngredients.Columns.AddRange(new DataGridViewColumn[] { IngredientsNameColumn });
            DataGridIngredients.DataSource = ingredientBindingSource;
            DataGridIngredients.Dock = DockStyle.Fill;
            DataGridIngredients.Location = new Point(3, 3);
            DataGridIngredients.Name = "DataGridIngredients";
            DataGridIngredients.Size = new Size(786, 375);
            DataGridIngredients.TabIndex = 0;
            // 
            // IngredientsNameColumn
            // 
            IngredientsNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IngredientsNameColumn.DataPropertyName = "Name";
            IngredientsNameColumn.HeaderText = "Name";
            IngredientsNameColumn.Name = "IngredientsNameColumn";
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // ButtonToSaveChanges
            // 
            ButtonToSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonToSaveChanges.Location = new Point(713, 418);
            ButtonToSaveChanges.Name = "ButtonToSaveChanges";
            ButtonToSaveChanges.Size = new Size(75, 23);
            ButtonToSaveChanges.TabIndex = 1;
            ButtonToSaveChanges.Text = "Save";
            ButtonToSaveChanges.UseVisualStyleBackColor = true;
            ButtonToSaveChanges.Click += ButtonToSaveChanges_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonToSaveChanges);
            Controls.Add(tabControl);
            Name = "MainWindow";
            Text = "DishManager";
            tabControl.ResumeLayout(false);
            DishTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishViewBindingSource).EndInit();
            IngredientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage DishTabPage;
        private TabPage IngredientsTabPage;
        private DataGridView DataGridDishes;
        private DataGridViewTextBoxColumn DishNameColumn;
        private DataGridViewTextBoxColumn DishRecipeColumn;
        private DataGridViewTextBoxColumn DishIngredientsColumn;
        private BindingSource dishViewBindingSource;
        private DataGridView DataGridIngredients;
        private DataGridViewTextBoxColumn IngredientsNameColumn;
        private BindingSource ingredientBindingSource;
        private Button ButtonToSaveChanges;
    }
}
