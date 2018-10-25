namespace Course2_Task1_Queue
{
    partial class TheForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SurnameListBox = new System.Windows.Forms.ListBox();
            this.FileChooseButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.InsertTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurnameListBox
            // 
            this.SurnameListBox.FormattingEnabled = true;
            this.SurnameListBox.ItemHeight = 16;
            this.SurnameListBox.Location = new System.Drawing.Point(195, 43);
            this.SurnameListBox.Name = "SurnameListBox";
            this.SurnameListBox.Size = new System.Drawing.Size(269, 372);
            this.SurnameListBox.TabIndex = 0;
            // 
            // FileChooseButton
            // 
            this.FileChooseButton.Location = new System.Drawing.Point(23, 64);
            this.FileChooseButton.Name = "FileChooseButton";
            this.FileChooseButton.Size = new System.Drawing.Size(137, 60);
            this.FileChooseButton.TabIndex = 1;
            this.FileChooseButton.Text = "Choose the file";
            this.FileChooseButton.UseVisualStyleBackColor = true;
            this.FileChooseButton.Click += new System.EventHandler(this.FileChooseButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(23, 168);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(137, 60);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // InsertTextBox
            // 
            this.InsertTextBox.Location = new System.Drawing.Point(24, 140);
            this.InsertTextBox.Name = "InsertTextBox";
            this.InsertTextBox.Size = new System.Drawing.Size(136, 22);
            this.InsertTextBox.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "input";
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(23, 257);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(137, 60);
            this.SaveFileButton.TabIndex = 5;
            this.SaveFileButton.Text = "Save to the file";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(24, 340);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(137, 60);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear queue";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 456);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.InsertTextBox);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.FileChooseButton);
            this.Controls.Add(this.SurnameListBox);
            this.Name = "TheForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SurnameListBox;
        private System.Windows.Forms.Button FileChooseButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox InsertTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

