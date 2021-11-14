﻿namespace Scan
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewFileButton = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstListOfScanner = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstListOfScanner);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.NewFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 153);
            this.panel1.TabIndex = 0;
            // 
            // NewFileButton
            // 
            this.NewFileButton.BackgroundImage = global::Scan.Properties.Resources.NewFile;
            this.NewFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewFileButton.Location = new System.Drawing.Point(12, 28);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(117, 112);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewFileButton_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Scan.Properties.Resources.OpenFile;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(454, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 112);
            this.panel3.TabIndex = 1;
            // 
            // lstListOfScanner
            // 
            this.lstListOfScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListOfScanner.FormattingEnabled = true;
            this.lstListOfScanner.ItemHeight = 20;
            this.lstListOfScanner.Location = new System.Drawing.Point(136, 28);
            this.lstListOfScanner.Margin = new System.Windows.Forms.Padding(4);
            this.lstListOfScanner.Name = "lstListOfScanner";
            this.lstListOfScanner.Size = new System.Drawing.Size(295, 104);
            this.lstListOfScanner.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 153);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel NewFileButton;
        private System.Windows.Forms.ListBox lstListOfScanner;
    }
}

