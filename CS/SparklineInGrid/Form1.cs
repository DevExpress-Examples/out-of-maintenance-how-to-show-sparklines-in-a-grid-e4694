using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Sparkline;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace SparklineInGrid {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Fill a grid's data source.
            this.customersPaymentTableAdapter.Fill(this.contactsDataSet.CustomersPayment);

            // Create a Sparkline repository item, adjust it and add it to the grid's repository.
            RepositoryItemSparklineEdit repositoryItemSparklineEdit1 = new RepositoryItemSparklineEdit();
            LineSparklineView lineSparklineView1 = repositoryItemSparklineEdit1.View as LineSparklineView;
            lineSparklineView1.HighlightEndPoint = true;
            lineSparklineView1.HighlightMaxPoint = true;
            lineSparklineView1.HighlightMinPoint = true;
            lineSparklineView1.HighlightStartPoint = true;
            this.gridControl1.RepositoryItems.Add(repositoryItemSparklineEdit1);
            
            // Create an unbound column, adjust it and add it to the grid view.
            GridColumn colPayments = new GridColumn();
            colPayments.Visible = true;
            colPayments.Caption = "Payments";
            colPayments.UnboundType = UnboundColumnType.Object;
            colPayments.ColumnEdit = repositoryItemSparklineEdit1;
            colPayments.FieldName = "gridColumn1";
            colPayments.MaxWidth = 300;
            colPayments.MinWidth = 50;
            colPayments.Width = 255;
            this.gridView1.Columns.Add(colPayments);

            // Expand all groups for better initial navigation.
            this.gridView1.ExpandAllGroups();
        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            // Obtaining data for the sparkline editor.
            if (e.IsGetData) {
                List<double> values = new List<double>();
                DataRowView row = (DataRowView)e.Row;

                values.Add((double)row["January"]);
                values.Add((double)row["February"]);
                values.Add((double)row["March"]);
                values.Add((double)row["April"]);
                values.Add((double)row["May"]);
                values.Add((double)row["June"]);
                values.Add((double)row["July"]);
                values.Add((double)row["August"]);
                values.Add((double)row["September"]);
                values.Add((double)row["October"]);
                values.Add((double)row["November"]);
                values.Add((double)row["December"]);
                
                e.Value = values;
            }
        }

    }
}
