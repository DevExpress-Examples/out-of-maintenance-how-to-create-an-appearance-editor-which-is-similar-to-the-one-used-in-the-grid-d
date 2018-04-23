using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication3 {
    public partial class AppearancesEditor: DevExpress.XtraEditors.XtraForm {

        GridView view;
        public AppearancesEditor(GridView view) {
            InitializeComponent();
            this.view = view;

            checkEdit1.Checked = view.OptionsView.EnableAppearanceEvenRow;
            checkEdit2.Checked = view.OptionsView.EnableAppearanceOddRow;
            checkEdit3.Checked = view.OptionsSelection.EnableAppearanceFocusedRow;
            checkEdit4.Checked = view.OptionsSelection.EnableAppearanceFocusedCell;
            comboBoxEdit1.EditValue = view.PaintStyleName;

            propertyGridControl1.SelectedObject = view.Appearance;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            comboBoxEdit1.Properties.Items.AddRange(new object[] { "Default", "WindowsXP", "MixedXP",
            "Style3D", "UltraFlat", "Flat", "Office2003", "Web", "Skin"});

            CenterToScreen();
        }

        private void comboBoxEdit1_EditValueChanged(object sender, EventArgs e) {
            view.PaintStyleName = comboBoxEdit1.Text;
        }

        private void OnEnableAppearanceEvenRowChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            view.OptionsView.EnableAppearanceEvenRow = edit.Checked;
        }

        private void OnEnableAppearanceOddRowChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            view.OptionsView.EnableAppearanceOddRow = edit.Checked;
        }

        private void OnEnableAppearanceFocusedRowChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            view.OptionsSelection.EnableAppearanceFocusedRow = edit.Checked;
        }

        private void OnEnableAppearanceFocusedCellChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            view.OptionsSelection.EnableAppearanceFocusedCell= edit.Checked;
        }

        private void OnSaveButtonClick(object sender, EventArgs e) {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) 
                try {
                    view.Appearance.SaveLayoutToXml(saveFileDialog1.FileName);
                }
                catch { }
        }

        private void OnLoadButtonClick(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                try {
                    view.Appearance.RestoreLayoutFromXml(openFileDialog1.FileName);
                }
                catch { }
        }
    }
}