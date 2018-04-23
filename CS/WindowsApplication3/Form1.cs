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
            for(int i = 0;i < 5;i++) {
                dataSet11.Tables[0].Rows.Add(new object[] { i, i, i, imageList1.Images[i]});
            }
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
