﻿namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.exitViewAllQuotesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surfaceMaterialSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateQuoteAddedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDrawersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitViewAllQuotesButton
            // 
            this.exitViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitViewAllQuotesButton.Location = new System.Drawing.Point(713, 446);
            this.exitViewAllQuotesButton.Name = "exitViewAllQuotesButton";
            this.exitViewAllQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitViewAllQuotesButton.TabIndex = 4;
            this.exitViewAllQuotesButton.Text = "Back";
            this.exitViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.exitViewAllQuotesButton.Click += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateQuoteAddedColumn,
            this.customerName,
            this.width,
            this.depthColumn,
            this.numberOfDrawersColumn,
            this.surfaceMaterialColumn,
            this.shippingSpeedColumn,
            this.shippingPriceColumn,
            this.totalPriceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(945, 391);
            this.dataGridView1.TabIndex = 5;
            // 
            // surfaceMaterialSelectionComboBox
            // 
            this.surfaceMaterialSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialSelectionComboBox.FormattingEnabled = true;
            this.surfaceMaterialSelectionComboBox.Items.AddRange(new object[] {
            "*All Materials*",
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialSelectionComboBox.Location = new System.Drawing.Point(143, 12);
            this.surfaceMaterialSelectionComboBox.Name = "surfaceMaterialSelectionComboBox";
            this.surfaceMaterialSelectionComboBox.Size = new System.Drawing.Size(113, 28);
            this.surfaceMaterialSelectionComboBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Surface Material";
            // 
            // dateQuoteAddedColumn
            // 
            this.dateQuoteAddedColumn.HeaderText = "Date";
            this.dateQuoteAddedColumn.Name = "dateQuoteAddedColumn";
            this.dateQuoteAddedColumn.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.Name = "width";
            this.width.ReadOnly = true;
            // 
            // depthColumn
            // 
            this.depthColumn.HeaderText = "Depth";
            this.depthColumn.Name = "depthColumn";
            this.depthColumn.ReadOnly = true;
            // 
            // numberOfDrawersColumn
            // 
            this.numberOfDrawersColumn.HeaderText = "Number of Drawers";
            this.numberOfDrawersColumn.Name = "numberOfDrawersColumn";
            this.numberOfDrawersColumn.ReadOnly = true;
            // 
            // surfaceMaterialColumn
            // 
            this.surfaceMaterialColumn.HeaderText = "Surface Material";
            this.surfaceMaterialColumn.Name = "surfaceMaterialColumn";
            this.surfaceMaterialColumn.ReadOnly = true;
            // 
            // shippingSpeedColumn
            // 
            this.shippingSpeedColumn.HeaderText = "Shipping Speed";
            this.shippingSpeedColumn.Name = "shippingSpeedColumn";
            this.shippingSpeedColumn.ReadOnly = true;
            // 
            // shippingPriceColumn
            // 
            this.shippingPriceColumn.HeaderText = "Shipping Price";
            this.shippingPriceColumn.Name = "shippingPriceColumn";
            this.shippingPriceColumn.ReadOnly = true;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.HeaderText = "Total Price";
            this.totalPriceColumn.Name = "totalPriceColumn";
            this.totalPriceColumn.ReadOnly = true;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 496);
            this.Controls.Add(this.surfaceMaterialSelectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Deactivate += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitViewAllQuotesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox surfaceMaterialSelectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateQuoteAddedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDrawersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceColumn;
    }
}