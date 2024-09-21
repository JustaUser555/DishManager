namespace DishManagerWF
{
    partial class IngredientToDishAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AddIngredientDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientBindingSource = new BindingSource(components);
            AddIngredientButton = new Button();
            ingredientBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)AddIngredientDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // AddIngredientDataGridView
            // 
            AddIngredientDataGridView.AllowUserToAddRows = false;
            AddIngredientDataGridView.AllowUserToDeleteRows = false;
            AddIngredientDataGridView.AutoGenerateColumns = false;
            AddIngredientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddIngredientDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            AddIngredientDataGridView.DataSource = ingredientBindingSource;
            AddIngredientDataGridView.Dock = DockStyle.Top;
            AddIngredientDataGridView.Location = new Point(0, 0);
            AddIngredientDataGridView.Name = "AddIngredientDataGridView";
            AddIngredientDataGridView.ReadOnly = true;
            AddIngredientDataGridView.Size = new Size(519, 270);
            AddIngredientDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // AddIngredientButton
            // 
            AddIngredientButton.Location = new Point(390, 276);
            AddIngredientButton.Name = "AddIngredientButton";
            AddIngredientButton.Size = new Size(117, 23);
            AddIngredientButton.TabIndex = 1;
            AddIngredientButton.Text = "Add Ingredient";
            AddIngredientButton.UseVisualStyleBackColor = true;
            AddIngredientButton.Click += AddIngredientButton_Click;
            // 
            // ingredientBindingSource1
            // 
            ingredientBindingSource1.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // IngredientToDishAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 311);
            Controls.Add(AddIngredientButton);
            Controls.Add(AddIngredientDataGridView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngredientToDishAddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Ingredient To Dish";
            ((System.ComponentModel.ISupportInitialize)AddIngredientDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AddIngredientDataGridView;
        private BindingSource ingredientBindingSource;
        private Button AddIngredientButton;
        private BindingSource ingredientBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}