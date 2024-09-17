namespace DishManagerWF
{
    partial class IngredientAddForm
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(93, 24);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(279, 23);
            NameTextBox.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(274, 67);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add Ingredient";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // IngredientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 102);
            Controls.Add(AddButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "IngredientAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IngredientAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Button AddButton;
    }
}