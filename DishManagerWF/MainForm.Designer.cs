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
            AddButton = new Button();
            DeleteButton = new Button();
            RefreshButton = new Button();
            ChangeButton = new Button();
            SearchBox = new TextBox();
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
            DishNameColumn.ReadOnly = true;
            // 
            // DishRecipeColumn
            // 
            DishRecipeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishRecipeColumn.DataPropertyName = "Recipe";
            DishRecipeColumn.HeaderText = "Recipe";
            DishRecipeColumn.Name = "DishRecipeColumn";
            DishRecipeColumn.ReadOnly = true;
            // 
            // DishIngredientsColumn
            // 
            DishIngredientsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DishIngredientsColumn.DataPropertyName = "IngredientsAsString";
            DishIngredientsColumn.HeaderText = "Ingredients";
            DishIngredientsColumn.Name = "DishIngredientsColumn";
            DishIngredientsColumn.ReadOnly = true;
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
            IngredientsNameColumn.ReadOnly = true;
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
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(12, 418);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.Location = new Point(93, 418);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RefreshButton.Location = new Point(255, 418);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(75, 23);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ChangeButton.Location = new Point(174, 418);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(75, 23);
            ChangeButton.TabIndex = 5;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = SystemColors.Window;
            SearchBox.Location = new Point(336, 419);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(200, 23);
            SearchBox.TabIndex = 1;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBox);
            Controls.Add(ChangeButton);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(ButtonToSaveChanges);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DishManager";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            tabControl.ResumeLayout(false);
            DishTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishViewBindingSource).EndInit();
            IngredientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage DishTabPage;
        private TabPage IngredientsTabPage;
        private DataGridView DataGridDishes;
        private BindingSource dishViewBindingSource;
        private DataGridView DataGridIngredients;
        private DataGridViewTextBoxColumn IngredientsNameColumn;
        private BindingSource ingredientBindingSource;
        private Button ButtonToSaveChanges;
        private Button AddButton;
        private Button DeleteButton;
        private Button RefreshButton;
        private Button ChangeButton;
        private DataGridViewTextBoxColumn DishNameColumn;
        private DataGridViewTextBoxColumn DishRecipeColumn;
        private DataGridViewTextBoxColumn DishIngredientsColumn;
        private TextBox SearchBox;
    }
}
