namespace DishManagerWF
{
    partial class ChangeDishForm
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
            ChangeIngredientToDish = new Button();
            SaveChangesButton = new Button();
            AddLabel = new Label();
            IngredientLabel = new Label();
            RecipeLabel = new Label();
            NameLabel = new Label();
            RecipeTextBox = new TextBox();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // ChangeIngredientToDish
            // 
            ChangeIngredientToDish.Location = new Point(121, 207);
            ChangeIngredientToDish.Name = "ChangeIngredientToDish";
            ChangeIngredientToDish.Size = new Size(143, 23);
            ChangeIngredientToDish.TabIndex = 23;
            ChangeIngredientToDish.Text = "Change Ingredients";
            ChangeIngredientToDish.UseVisualStyleBackColor = true;
            ChangeIngredientToDish.Click += ChangeIngredientToDish_Click;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(402, 276);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(105, 23);
            SaveChangesButton.TabIndex = 22;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Location = new Point(147, 22);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(0, 15);
            AddLabel.TabIndex = 21;
            // 
            // IngredientLabel
            // 
            IngredientLabel.AutoSize = true;
            IngredientLabel.Location = new Point(12, 207);
            IngredientLabel.Name = "IngredientLabel";
            IngredientLabel.Size = new Size(66, 15);
            IngredientLabel.TabIndex = 20;
            IngredientLabel.Text = "Ingredients";
            // 
            // RecipeLabel
            // 
            RecipeLabel.AutoSize = true;
            RecipeLabel.Location = new Point(12, 80);
            RecipeLabel.Name = "RecipeLabel";
            RecipeLabel.Size = new Size(42, 15);
            RecipeLabel.TabIndex = 19;
            RecipeLabel.Text = "Recipe";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 32);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 18;
            NameLabel.Text = "Name";
            // 
            // RecipeTextBox
            // 
            RecipeTextBox.Location = new Point(121, 80);
            RecipeTextBox.Multiline = true;
            RecipeTextBox.Name = "RecipeTextBox";
            RecipeTextBox.Size = new Size(386, 99);
            RecipeTextBox.TabIndex = 17;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(121, 32);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(386, 23);
            NameTextBox.TabIndex = 16;
            // 
            // ChangeDishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 311);
            Controls.Add(ChangeIngredientToDish);
            Controls.Add(SaveChangesButton);
            Controls.Add(AddLabel);
            Controls.Add(IngredientLabel);
            Controls.Add(RecipeLabel);
            Controls.Add(NameLabel);
            Controls.Add(RecipeTextBox);
            Controls.Add(NameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeDishForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Dish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangeIngredientToDish;
        private Button SaveChangesButton;
        private Label AddLabel;
        private Label IngredientLabel;
        private Label RecipeLabel;
        private Label NameLabel;
        private TextBox RecipeTextBox;
        private TextBox NameTextBox;
    }
}