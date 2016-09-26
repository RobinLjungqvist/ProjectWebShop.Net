namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webbshopDataSet = new WindowsFormsApplication1.WebbshopDataSet();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTableAdapter = new WindowsFormsApplication1.WebbshopDataSetTableAdapters.tblProductTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.sizeIDDataGridViewTextBoxColumn,
            this.colorIDDataGridViewTextBoxColumn,
            this.brandIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.pictureIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 431);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // webbshopDataSet
            // 
            this.webbshopDataSet.DataSetName = "WebbshopDataSet";
            this.webbshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.webbshopDataSet;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // sizeIDDataGridViewTextBoxColumn
            // 
            this.sizeIDDataGridViewTextBoxColumn.DataPropertyName = "SizeID";
            this.sizeIDDataGridViewTextBoxColumn.HeaderText = "SizeID";
            this.sizeIDDataGridViewTextBoxColumn.Name = "sizeIDDataGridViewTextBoxColumn";
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            // 
            // brandIDDataGridViewTextBoxColumn
            // 
            this.brandIDDataGridViewTextBoxColumn.DataPropertyName = "BrandID";
            this.brandIDDataGridViewTextBoxColumn.HeaderText = "BrandID";
            this.brandIDDataGridViewTextBoxColumn.Name = "brandIDDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // pictureIDDataGridViewTextBoxColumn
            // 
            this.pictureIDDataGridViewTextBoxColumn.DataPropertyName = "PictureID";
            this.pictureIDDataGridViewTextBoxColumn.HeaderText = "PictureID";
            this.pictureIDDataGridViewTextBoxColumn.Name = "pictureIDDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 555);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webbshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private WebbshopDataSet webbshopDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private WebbshopDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureIDDataGridViewTextBoxColumn;
    }
}

