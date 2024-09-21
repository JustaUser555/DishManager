namespace DishManagerWF
{
    partial class IngredientToDishChangeForm
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
            SplitContainer = new SplitContainer();
            ContainedIngredientsDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingredientBindingSource = new BindingSource(components);
            AllIngredientsDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            DeleteButton = new Button();
            SaveChangesButton = new Button();
            ContainedIngredientsLabel = new Label();
            AllIngredientsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContainedIngredientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllIngredientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SplitContainer
            // 
            SplitContainer.Location = new Point(12, 30);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(ContainedIngredientsDataGridView);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(AllIngredientsDataGridView);
            SplitContainer.Size = new Size(776, 377);
            SplitContainer.SplitterDistance = 386;
            SplitContainer.TabIndex = 0;
            // 
            // ContainedIngredientsDataGridView
            // 
            ContainedIngredientsDataGridView.AutoGenerateColumns = false;
            ContainedIngredientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ContainedIngredientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            ContainedIngredientsDataGridView.DataSource = ingredientBindingSource;
            ContainedIngredientsDataGridView.Dock = DockStyle.Fill;
            ContainedIngredientsDataGridView.Location = new Point(0, 0);
            ContainedIngredientsDataGridView.Name = "ContainedIngredientsDataGridView";
            ContainedIngredientsDataGridView.Size = new Size(386, 377);
            ContainedIngredientsDataGridView.TabIndex = 0;
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
            // AllIngredientsDataGridView
            // 
            AllIngredientsDataGridView.AutoGenerateColumns = false;
            AllIngredientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllIngredientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1 });
            AllIngredientsDataGridView.DataSource = ingredientBindingSource;
            AllIngredientsDataGridView.Dock = DockStyle.Fill;
            AllIngredientsDataGridView.Location = new Point(0, 0);
            AllIngredientsDataGridView.Name = "AllIngredientsDataGridView";
            AllIngredientsDataGridView.Size = new Size(386, 377);
            AllIngredientsDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(324, 415);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "<--";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(405, 415);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "-->";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(680, 415);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(108, 23);
            SaveChangesButton.TabIndex = 3;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // ContainedIngredientsLabel
            // 
            ContainedIngredientsLabel.AutoSize = true;
            ContainedIngredientsLabel.Location = new Point(12, 9);
            ContainedIngredientsLabel.Name = "ContainedIngredientsLabel";
            ContainedIngredientsLabel.Size = new Size(124, 15);
            ContainedIngredientsLabel.TabIndex = 4;
            ContainedIngredientsLabel.Text = "Contained Ingredients";
            // 
            // AllIngredientsLabel
            // 
            AllIngredientsLabel.AutoSize = true;
            AllIngredientsLabel.Location = new Point(403, 9);
            AllIngredientsLabel.Name = "AllIngredientsLabel";
            AllIngredientsLabel.Size = new Size(83, 15);
            AllIngredientsLabel.TabIndex = 5;
            AllIngredientsLabel.Text = "All Ingredients";
            // 
            // IngredientToDishChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllIngredientsLabel);
            Controls.Add(ContainedIngredientsLabel);
            Controls.Add(SaveChangesButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(SplitContainer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IngredientToDishChangeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Ingredients Of Dish";
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContainedIngredientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllIngredientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer SplitContainer;
        private DataGridView ContainedIngredientsDataGridView;
        private DataGridView AllIngredientsDataGridView;
        private Button AddButton;
        private Button DeleteButton;
        private Button SaveChangesButton;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource ingredientBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private Label ContainedIngredientsLabel;
        private Label AllIngredientsLabel;
    }
}