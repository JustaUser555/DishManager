namespace DishManagerWinForms
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
            TabPageDishes = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ShowIngredients = new DataGridView();
            ShowDishes = new DataGridView();
            TabPageDishes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowDishes).BeginInit();
            SuspendLayout();
            // 
            // TabPageDishes
            // 
            TabPageDishes.Controls.Add(tabPage1);
            TabPageDishes.Controls.Add(tabPage2);
            TabPageDishes.Location = new Point(12, 12);
            TabPageDishes.Name = "TabPageDishes";
            TabPageDishes.SelectedIndex = 0;
            TabPageDishes.Size = new Size(776, 426);
            TabPageDishes.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ShowDishes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ShowIngredients);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ShowIngredients
            // 
            ShowIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowIngredients.Dock = DockStyle.Fill;
            ShowIngredients.Location = new Point(3, 3);
            ShowIngredients.Name = "ShowIngredients";
            ShowIngredients.Size = new Size(762, 392);
            ShowIngredients.TabIndex = 0;
            // 
            // ShowDishes
            // 
            ShowDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowDishes.Dock = DockStyle.Fill;
            ShowDishes.Location = new Point(3, 3);
            ShowDishes.Name = "ShowDishes";
            ShowDishes.Size = new Size(762, 392);
            ShowDishes.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabPageDishes);
            Name = "Form1";
            Text = "DishManager";
            TabPageDishes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShowIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowDishes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl TabPageDishes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView ShowIngredients;
        private DataGridView ShowDishes;
    }
}
