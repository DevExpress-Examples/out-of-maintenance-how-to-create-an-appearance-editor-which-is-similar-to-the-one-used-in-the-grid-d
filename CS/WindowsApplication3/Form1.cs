using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            DataTable table = new DataTable();
            table.Columns.Add(gridView1.Columns[0].FieldName, typeof(int));
            table.Columns.Add(gridView1.Columns[1].FieldName, typeof(string));
            table.Columns.Add(gridView1.Columns[2].FieldName, typeof(string));
            table.Columns.Add(gridView1.Columns[3].FieldName, typeof(Image));
            table.Columns.Add(gridView1.Columns[4].FieldName, typeof(DateTime));
            table.Columns.Add(gridView1.Columns[5].FieldName, typeof(bool));
            for (int i = 0;i < 5;i++) {
                table.Rows.Add(new object[] { i, i, i, imageList1.Images[i], DateTime.Now });
            }
            gridControl1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
        }

        private void OnItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AppearancesEditor editor = new AppearancesEditor(gridView1);
            editor.ShowDialog();
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(e.Button == MouseButtons.Right && hitInfo.InRow)
                popupMenu1.ShowPopup(MousePosition);
        }
    }
}
