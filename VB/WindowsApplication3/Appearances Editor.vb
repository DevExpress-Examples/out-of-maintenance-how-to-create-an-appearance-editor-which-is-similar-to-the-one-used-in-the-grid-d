Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication3
	Partial Public Class AppearancesEditor
		Inherits DevExpress.XtraEditors.XtraForm

		Private view As GridView
		Public Sub New(ByVal view As GridView)
			InitializeComponent()
			Me.view = view

			checkEdit1.Checked = view.OptionsView.EnableAppearanceEvenRow
			checkEdit2.Checked = view.OptionsView.EnableAppearanceOddRow
			checkEdit3.Checked = view.OptionsSelection.EnableAppearanceFocusedRow
			checkEdit4.Checked = view.OptionsSelection.EnableAppearanceFocusedCell
			comboBoxEdit1.EditValue = view.PaintStyleName

			propertyGridControl1.SelectedObject = view.Appearance
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			comboBoxEdit1.Properties.Items.AddRange(New Object() { "Default", "WindowsXP", "MixedXP", "Style3D", "UltraFlat", "Flat", "Office2003", "Web", "Skin"})

			CenterToScreen()
		End Sub

		Private Sub comboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.EditValueChanged
			view.PaintStyleName = comboBoxEdit1.Text
		End Sub

		Private Sub OnEnableAppearanceEvenRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			view.OptionsView.EnableAppearanceEvenRow = edit.Checked
		End Sub

		Private Sub OnEnableAppearanceOddRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit2.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			view.OptionsView.EnableAppearanceOddRow = edit.Checked
		End Sub

		Private Sub OnEnableAppearanceFocusedRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit3.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			view.OptionsSelection.EnableAppearanceFocusedRow = edit.Checked
		End Sub

		Private Sub OnEnableAppearanceFocusedCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit4.CheckedChanged
			Dim edit As CheckEdit = TryCast(sender, CheckEdit)
			view.OptionsSelection.EnableAppearanceFocusedCell= edit.Checked
		End Sub

		Private Sub OnSaveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			If saveFileDialog1.ShowDialog() = DialogResult.OK Then
				Try
					view.Appearance.SaveLayoutToXml(saveFileDialog1.FileName)
				Catch
				End Try
			End If
		End Sub

		Private Sub OnLoadButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			If openFileDialog1.ShowDialog() = DialogResult.OK Then
				Try
					view.Appearance.RestoreLayoutFromXml(openFileDialog1.FileName)
				Catch
				End Try
			End If
		End Sub
	End Class
End Namespace