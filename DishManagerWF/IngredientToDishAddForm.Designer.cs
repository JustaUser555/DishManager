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
            ingredientBindingSource = new BindingSource(components);
            SaveChangesButton = new Button();
            ingredientBindingSource1 = new BindingSource(components);
            SplitContainer = new SplitContainer();
            ContainedIngredientsDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ingredientBindingSource3 = new BindingSource(components);
            AllIngredientsDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientBindingSource2 = new BindingSource(components);
            ContainedIngredientsLabel = new Label();
            AllIngredients = new Label();
            AddButton = new Button();
            DeleteButton = new Button();
            AllIngredientsSearchBox = new TextBox();
            ContainedIngredientsSearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContainedIngredientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllIngredientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(671, 415);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(117, 23);
            SaveChangesButton.TabIndex = 1;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // ingredientBindingSource1
            // 
            ingredientBindingSource1.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // SplitContainer
            // 
            SplitContainer.Location = new Point(12, 32);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(ContainedIngredientsDataGridView);
            SplitContainer.Panel1.RightToLeft = RightToLeft.No;
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(AllIngredientsDataGridView);
            SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            SplitContainer.Size = new Size(776, 377);
            SplitContainer.SplitterDistance = 386;
            SplitContainer.TabIndex = 2;
            // 
            // ContainedIngredientsDataGridView
            // 
            ContainedIngredientsDataGridView.AutoGenerateColumns = false;
            ContainedIngredientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContainedIngredientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1 });
            ContainedIngredientsDataGridView.DataSource = ingredientBindingSource3;
            ContainedIngredientsDataGridView.Dock = DockStyle.Fill;
            ContainedIngredientsDataGridView.Location = new Point(0, 0);
            ContainedIngredientsDataGridView.Name = "ContainedIngredientsDataGridView";
            ContainedIngredientsDataGridView.Size = new Size(386, 377);
            ContainedIngredientsDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ingredientBindingSource3
            // 
            ingredientBindingSource3.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // AllIngredientsDataGridView
            // 
            AllIngredientsDataGridView.AutoGenerateColumns = false;
            AllIngredientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllIngredientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            AllIngredientsDataGridView.DataSource = ingredientBindingSource2;
            AllIngredientsDataGridView.Dock = DockStyle.Fill;
            AllIngredientsDataGridView.Location = new Point(0, 0);
            AllIngredientsDataGridView.Name = "AllIngredientsDataGridView";
            AllIngredientsDataGridView.ReadOnly = true;
            AllIngredientsDataGridView.Size = new Size(386, 377);
            AllIngredientsDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientBindingSource2
            // 
            ingredientBindingSource2.DataSource = typeof(DishManagerLibrary.Ingredient);
            // 
            // ContainedIngredientsLabel
            // 
            ContainedIngredientsLabel.AutoSize = true;
            ContainedIngredientsLabel.Location = new Point(12, 9);
            ContainedIngredientsLabel.Name = "ContainedIngredientsLabel";
            ContainedIngredientsLabel.Size = new Size(124, 15);
            ContainedIngredientsLabel.TabIndex = 3;
            ContainedIngredientsLabel.Text = "Contained Ingredients";
            // 
            // AllIngredients
            // 
            AllIngredients.AutoSize = true;
            AllIngredients.Location = new Point(402, 9);
            AllIngredients.Name = "AllIngredients";
            AllIngredients.Size = new Size(83, 15);
            AllIngredients.TabIndex = 4;
            AllIngredients.Text = "All Ingredients";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(323, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 5;
            AddButton.Text = "<--";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(404, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "-->";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AllIngredientsSearchBox
            // 
            AllIngredientsSearchBox.Location = new Point(627, 6);
            AllIngredientsSearchBox.Name = "AllIngredientsSearchBox";
            AllIngredientsSearchBox.Size = new Size(161, 23);
            AllIngredientsSearchBox.TabIndex = 7;
            AllIngredientsSearchBox.TextChanged += AllIngredientsSearchBox_TextChanged;
            // 
            // ContainedIngredientsSearchBox
            // 
            ContainedIngredientsSearchBox.Location = new Point(237, 6);
            ContainedIngredientsSearchBox.Name = "ContainedIngredientsSearchBox";
            ContainedIngredientsSearchBox.Size = new Size(161, 23);
            ContainedIngredientsSearchBox.TabIndex = 8;
            ContainedIngredientsSearchBox.TextChanged += ContainedIngredientsSearchBox_TextChanged;
            // 
            // IngredientToDishAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ContainedIngredientsSearchBox);
            Controls.Add(AllIngredientsSearchBox);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(AllIngredients);
            Controls.Add(ContainedIngredientsLabel);
            Controls.Add(SplitContainer);
            Controls.Add(SaveChangesButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngredientToDishAddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Ingredient To Dish";
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource1).EndInit();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContainedIngredientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllIngredientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource ingredientBindingSource;
        private Button SaveChangesButton;
        private BindingSource ingredientBindingSource1;
        private SplitContainer SplitContainer;
        private DataGridView ContainedIngredientsDataGridView;
        private DataGridView AllIngredientsDataGridView;
        private Label ContainedIngredientsLabel;
        private Label AllIngredients;
        private Button AddButton;
        private Button DeleteButton;
        private BindingSource ingredientBindingSource3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource ingredientBindingSource2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private TextBox AllIngredientsSearchBox;
        private TextBox ContainedIngredientsSearchBox;
    }
}