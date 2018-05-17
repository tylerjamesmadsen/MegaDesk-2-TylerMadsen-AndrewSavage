﻿namespace MegaDesk
{
    partial class MainMenu
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
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.openViewQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(200, 50);
            this.openAddQuoteButton.TabIndex = 0;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // openViewQuotesButton
            // 
            this.openViewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openViewQuotesButton.Location = new System.Drawing.Point(12, 68);
            this.openViewQuotesButton.Name = "openViewQuotesButton";
            this.openViewQuotesButton.Size = new System.Drawing.Size(200, 50);
            this.openViewQuotesButton.TabIndex = 1;
            this.openViewQuotesButton.Text = "View Quotes";
            this.openViewQuotesButton.UseVisualStyleBackColor = true;
            this.openViewQuotesButton.Click += new System.EventHandler(this.openViewQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.megadesk;
            this.pictureBox1.Location = new System.Drawing.Point(218, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButton.Location = new System.Drawing.Point(12, 124);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(200, 50);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.openViewQuotesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 241);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openViewQuotesButton);
            this.Controls.Add(this.openAddQuoteButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 280);
            this.MinimumSize = new System.Drawing.Size(420, 280);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAddQuoteButton;
        private System.Windows.Forms.Button openViewQuotesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchQuotesButton;
    }
}

