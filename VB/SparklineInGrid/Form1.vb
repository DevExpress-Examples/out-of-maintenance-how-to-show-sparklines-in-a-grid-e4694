Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Sparkline
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
' ...

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) _
    Handles MyBase.Load
        ' Fill a grid's data source.
        Me.CustomersPaymentTableAdapter.Fill(Me.ContactsDataSet.CustomersPayment)

        ' Create a Sparkline repository item, adjust it and add it to the grid's repository.
        Dim repositoryItemSparklineEdit1 As New RepositoryItemSparklineEdit()
        Dim sparklineView As SparklineViewBase = repositoryItemSparklineEdit1.View
        sparklineView.HighlightEndPoint = True
        sparklineView.HighlightMaxPoint = True
        sparklineView.HighlightMinPoint = True
        sparklineView.HighlightStartPoint = True
        Me.GridControl1.RepositoryItems.Add(repositoryItemSparklineEdit1)

        ' Create an unbound column, adjust it and add it to the grid view.
        Dim colPayments As New GridColumn()
        colPayments.Visible = True
        colPayments.Caption = "Payments"
        colPayments.UnboundType = UnboundColumnType.Object
        colPayments.ColumnEdit = repositoryItemSparklineEdit1
        colPayments.FieldName = "gridColumn1"
        colPayments.MaxWidth = 300
        colPayments.MinWidth = 50
        colPayments.Width = 255
        Me.GridView1.Columns.Add(colPayments)


        ' Expand all groups for better initial navigation.
        Me.GridView1.ExpandAllGroups()
    End Sub

    Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs) _
    Handles GridView1.CustomUnboundColumnData
        'Obtaining data for the sparkline editor.
        If e.IsGetData Then
            Dim values As New List(Of Double)()
            Dim row As DataRowView = CType(e.Row, DataRowView)

            values.Add(CDbl(row("January")))
            values.Add(CDbl(row("February")))
            values.Add(CDbl(row("March")))
            values.Add(CDbl(row("April")))
            values.Add(CDbl(row("May")))
            values.Add(CDbl(row("June")))
            values.Add(CDbl(row("July")))
            values.Add(CDbl(row("August")))
            values.Add(CDbl(row("September")))
            values.Add(CDbl(row("October")))
            values.Add(CDbl(row("November")))
            values.Add(CDbl(row("December")))

            e.Value = values
        End If
    End Sub


End Class