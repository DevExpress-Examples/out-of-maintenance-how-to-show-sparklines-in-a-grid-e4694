<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CustomersPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New ContactsDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowSum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRowAvr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CustomersPaymentTableAdapter = New ContactsDataSetTableAdapters.CustomersPaymentTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CustomersPaymentBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(989, 518)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CustomersPaymentBindingSource
        '
        Me.CustomersPaymentBindingSource.DataMember = "CustomersPayment"
        Me.CustomersPaymentBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCustomerName, Me.colRowSum, Me.colRowAvr, Me.colYear})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colYear, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 94
        '
        'colCustomerName
        '
        Me.colCustomerName.FieldName = "Customer Name"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.OptionsColumn.ReadOnly = True
        Me.colCustomerName.Visible = True
        Me.colCustomerName.VisibleIndex = 1
        Me.colCustomerName.Width = 160
        '
        'colRowSum
        '
        Me.colRowSum.Caption = "Sum"
        Me.colRowSum.DisplayFormat.FormatString = "c"
        Me.colRowSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRowSum.FieldName = "RowSum"
        Me.colRowSum.Name = "colRowSum"
        Me.colRowSum.OptionsColumn.ReadOnly = True
        Me.colRowSum.Visible = True
        Me.colRowSum.VisibleIndex = 2
        Me.colRowSum.Width = 133
        '
        'colRowAvr
        '
        Me.colRowAvr.Caption = "Average"
        Me.colRowAvr.DisplayFormat.FormatString = "c"
        Me.colRowAvr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRowAvr.FieldName = "RowAvr"
        Me.colRowAvr.Name = "colRowAvr"
        Me.colRowAvr.OptionsColumn.ReadOnly = True
        Me.colRowAvr.Visible = True
        Me.colRowAvr.VisibleIndex = 3
        Me.colRowAvr.Width = 159
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 4
        '
        'CustomersPaymentTableAdapter
        '
        Me.CustomersPaymentTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 518)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContactsDataSet As ContactsDataSet
    Friend WithEvents CustomersPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersPaymentTableAdapter As ContactsDataSetTableAdapters.CustomersPaymentTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowSum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRowAvr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
End Class
