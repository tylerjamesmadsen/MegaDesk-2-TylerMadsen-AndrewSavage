namespace MegaDesk
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
            this.surfaceMaterialSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialSearchLabel = new System.Windows.Forms.Label();
            this.viewAllQuotesDataGridView = new System.Windows.Forms.DataGridView();
            this.dateQuoteAddedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfDrawersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitViewAllQuotesButton
            // 
            this.exitViewAllQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitViewAllQuotesButton.Location = new System.Drawing.Point(807, 446);
            this.exitViewAllQuotesButton.Name = "exitViewAllQuotesButton";
            this.exitViewAllQuotesButton.Size = new System.Drawing.Size(150, 40);
            this.exitViewAllQuotesButton.TabIndex = 4;
            this.exitViewAllQuotesButton.Text = "Back";
            this.exitViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.exitViewAllQuotesButton.Click += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            // 
            // surfaceMaterialSelectionComboBox
            // 
            this.surfaceMaterialSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterialSelectionComboBox.DropDownWidth = 150;
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
            this.surfaceMaterialSelectionComboBox.Size = new System.Drawing.Size(150, 28);
            this.surfaceMaterialSelectionComboBox.TabIndex = 22;
            this.surfaceMaterialSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterialSelectionComboBox_SelectedIndexChanged);
            // 
            // surfaceMaterialSearchLabel
            // 
            this.surfaceMaterialSearchLabel.AutoSize = true;
            this.surfaceMaterialSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialSearchLabel.Location = new System.Drawing.Point(12, 18);
            this.surfaceMaterialSearchLabel.Name = "surfaceMaterialSearchLabel";
            this.surfaceMaterialSearchLabel.Size = new System.Drawing.Size(125, 20);
            this.surfaceMaterialSearchLabel.TabIndex = 23;
            this.surfaceMaterialSearchLabel.Text = "Surface Material";
            // 
            // viewAllQuotesDataGridView
            // 
            this.viewAllQuotesDataGridView.AllowUserToAddRows = false;
            this.viewAllQuotesDataGridView.AllowUserToDeleteRows = false;
            this.viewAllQuotesDataGridView.AllowUserToOrderColumns = true;
            this.viewAllQuotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateQuoteAddedColumn,
            this.customerName,
            this.widthColumn,
            this.depthColumn,
            this.numberOfDrawersColumn,
            this.surfaceMaterialColumn,
            this.shippingSpeedColumn,
            this.totalPriceColumn});
            this.viewAllQuotesDataGridView.Location = new System.Drawing.Point(12, 49);
            this.viewAllQuotesDataGridView.Name = "viewAllQuotesDataGridView";
            this.viewAllQuotesDataGridView.ReadOnly = true;
            this.viewAllQuotesDataGridView.Size = new System.Drawing.Size(945, 391);
            this.viewAllQuotesDataGridView.TabIndex = 5;
            // 
            // dateQuoteAddedColumn
            // 
            this.dateQuoteAddedColumn.DataPropertyName = "Date";
            this.dateQuoteAddedColumn.HeaderText = "Date";
            this.dateQuoteAddedColumn.Name = "dateQuoteAddedColumn";
            this.dateQuoteAddedColumn.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "Name";
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // widthColumn
            // 
            this.widthColumn.DataPropertyName = "Width";
            this.widthColumn.HeaderText = "Width";
            this.widthColumn.Name = "widthColumn";
            this.widthColumn.ReadOnly = true;
            // 
            // depthColumn
            // 
            this.depthColumn.DataPropertyName = "Depth";
            this.depthColumn.HeaderText = "Depth";
            this.depthColumn.Name = "depthColumn";
            this.depthColumn.ReadOnly = true;
            // 
            // numberOfDrawersColumn
            // 
            this.numberOfDrawersColumn.DataPropertyName = "NumDrawers";
            this.numberOfDrawersColumn.HeaderText = "Number of Drawers";
            this.numberOfDrawersColumn.Name = "numberOfDrawersColumn";
            this.numberOfDrawersColumn.ReadOnly = true;
            // 
            // surfaceMaterialColumn
            // 
            this.surfaceMaterialColumn.DataPropertyName = "SurfaceMaterial";
            this.surfaceMaterialColumn.HeaderText = "Surface Material";
            this.surfaceMaterialColumn.Name = "surfaceMaterialColumn";
            this.surfaceMaterialColumn.ReadOnly = true;
            // 
            // shippingSpeedColumn
            // 
            this.shippingSpeedColumn.DataPropertyName = "ShippingSpeed";
            this.shippingSpeedColumn.HeaderText = "Shipping Speed";
            this.shippingSpeedColumn.Name = "shippingSpeedColumn";
            this.shippingSpeedColumn.ReadOnly = true;
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.DataPropertyName = "TotalPrice";
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
            this.Controls.Add(this.surfaceMaterialSearchLabel);
            this.Controls.Add(this.viewAllQuotesDataGridView);
            this.Controls.Add(this.exitViewAllQuotesButton);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Deactivate += new System.EventHandler(this.exitViewAllQuotesButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitViewAllQuotesButton;
        private System.Windows.Forms.DataGridView viewAllQuotesDataGridView;
        private System.Windows.Forms.ComboBox surfaceMaterialSelectionComboBox;
        private System.Windows.Forms.Label surfaceMaterialSearchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateQuoteAddedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDrawersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceColumn;
    }
}