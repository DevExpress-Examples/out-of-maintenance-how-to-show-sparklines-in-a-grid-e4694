namespace SparklineInGrid {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.customersPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataSet = new SparklineInGrid.Data.ContactsDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowAvr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customersPaymentTableAdapter = new SparklineInGrid.Data.ContactsDataSetTableAdapters.CustomersPaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.customersPaymentBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            
            this.gridControl1.Size = new System.Drawing.Size(838, 546);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // customersPaymentBindingSource
            // 
            this.customersPaymentBindingSource.DataMember = "CustomersPayment";
            this.customersPaymentBindingSource.DataSource = this.contactsDataSet;
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "ContactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCustomerName,
            this.colYear,
            this.colRowSum,
            this.colRowAvr});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colYear, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 77;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 171;
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 2;
            // 
            // colRowSum
            // 
            this.colRowSum.Caption = "Sum";
            this.colRowSum.DisplayFormat.FormatString = "c";
            this.colRowSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRowSum.FieldName = "RowSum";
            this.colRowSum.Name = "colRowSum";
            this.colRowSum.Visible = true;
            this.colRowSum.VisibleIndex = 2;
            this.colRowSum.Width = 120;
            // 
            // colRowAvr
            // 
            this.colRowAvr.Caption = "Average";
            this.colRowAvr.DisplayFormat.FormatString = "c";
            this.colRowAvr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRowAvr.FieldName = "RowAvr";
            this.colRowAvr.Name = "colRowAvr";
            this.colRowAvr.Visible = true;
            this.colRowAvr.VisibleIndex = 3;
            this.colRowAvr.Width = 113;
            // 
            // customersPaymentTableAdapter
            // 
            this.customersPaymentTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 546);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Data.ContactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource customersPaymentBindingSource;
        private Data.ContactsDataSetTableAdapters.CustomersPaymentTableAdapter customersPaymentTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRowSum;
        private DevExpress.XtraGrid.Columns.GridColumn colRowAvr;
    }
}

