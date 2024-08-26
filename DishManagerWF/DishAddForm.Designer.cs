namespace DishManagerWF
{
    partial class DishAddForm
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
            NameTextBox = new TextBox();
            RecipeTextBox = new TextBox();
            NameLabel = new Label();
            RecipeLabel = new Label();
            IngredientLabel = new Label();
            AddLabel = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(121, 32);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(386, 23);
            NameTextBox.TabIndex = 0;
            // 
            // RecipeTextBox
            // 
            RecipeTextBox.Location = new Point(121, 80);
            RecipeTextBox.Multiline = true;
            RecipeTextBox.Name = "RecipeTextBox";
            RecipeTextBox.Size = new Size(386, 99);
            RecipeTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 32);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // RecipeLabel
            // 
            RecipeLabel.AutoSize = true;
            RecipeLabel.Location = new Point(12, 80);
            RecipeLabel.Name = "RecipeLabel";
            RecipeLabel.Size = new Size(42, 15);
            RecipeLabel.TabIndex = 3;
            RecipeLabel.Text = "Recipe";
            // 
            // IngredientLabel
            // 
            IngredientLabel.AutoSize = true;
            IngredientLabel.Location = new Point(12, 207);
            IngredientLabel.Name = "IngredientLabel";
            IngredientLabel.Size = new Size(66, 15);
            IngredientLabel.TabIndex = 4;
            IngredientLabel.Text = "Ingredients";
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Location = new Point(147, 22);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(0, 15);
            AddLabel.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(432, 276);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add Dish";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DishAddForm
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 311);
            Controls.Add(AddButton);
            Controls.Add(AddLabel);
            Controls.Add(IngredientLabel);
            Controls.Add(RecipeLabel);
            Controls.Add(NameLabel);
            Controls.Add(RecipeTextBox);
            Controls.Add(NameTextBox);
            Name = "DishAddForm";
            Text = "Add Dish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox RecipeTextBox;
        private Label NameLabel;
        private Label RecipeLabel;
        private Label IngredientLabel;
        private Label AddLabel;
        private Button AddButton;
    }
}