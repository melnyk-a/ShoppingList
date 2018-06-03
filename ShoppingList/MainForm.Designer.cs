namespace ShoppingList
{
    partial class MainForm
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
            this.shoppingListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addItemTextBox = new System.Windows.Forms.TextBox();
            this.downButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingListCheckedListBox
            // 
            this.shoppingListCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingListCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shoppingListCheckedListBox.FormattingEnabled = true;
            this.shoppingListCheckedListBox.Location = new System.Drawing.Point(13, 13);
            this.shoppingListCheckedListBox.Name = "shoppingListCheckedListBox";
            this.shoppingListCheckedListBox.Size = new System.Drawing.Size(340, 319);
            this.shoppingListCheckedListBox.TabIndex = 0;
            this.shoppingListCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ShoppingListCheckedListBox_SelectedIndexChanged);
            // 
            // addItemTextBox
            // 
            this.addItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItemTextBox.Location = new System.Drawing.Point(13, 345);
            this.addItemTextBox.Name = "addItemTextBox";
            this.addItemTextBox.Size = new System.Drawing.Size(136, 26);
            this.addItemTextBox.TabIndex = 1;
            this.addItemTextBox.TextChanged += new System.EventHandler(this.AddItemTextBox_TextChanged);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.Enabled = false;
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downButton.Location = new System.Drawing.Point(266, 381);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(87, 31);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(13, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(247, 31);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(155, 343);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 31);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Enabled = false;
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upButton.Location = new System.Drawing.Point(266, 343);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(87, 31);
            this.upButton.TabIndex = 8;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 424);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.addItemTextBox);
            this.Controls.Add(this.shoppingListCheckedListBox);
            this.MinimumSize = new System.Drawing.Size(350, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox shoppingListCheckedListBox;
        private System.Windows.Forms.TextBox addItemTextBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button upButton;
    }
}

