namespace DishManagerWF
{
    partial class ChangeIngredientForm
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
            SaveChangesButton = new Button();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            SuspendLayout();
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(274, 67);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(98, 23);
            SaveChangesButton.TabIndex = 10;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(93, 24);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(279, 23);
            NameTextBox.TabIndex = 9;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 27);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Name";
            // 
            // ChangeIngredientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 102);
            Controls.Add(SaveChangesButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeIngredientForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change Ingredient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveChangesButton;
        private TextBox NameTextBox;
        private Label NameLabel;
    }
}