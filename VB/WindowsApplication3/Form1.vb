Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			Dim table As New DataTable()
			table.Columns.Add(gridView1.Columns(0).FieldName, GetType(Integer))
			table.Columns.Add(gridView1.Columns(1).FieldName, GetType(String))
			table.Columns.Add(gridView1.Columns(2).FieldName, GetType(String))
			table.Columns.Add(gridView1.Columns(3).FieldName, GetType(Image))
			table.Columns.Add(gridView1.Columns(4).FieldName, GetType(DateTime))
			table.Columns.Add(gridView1.Columns(5).FieldName, GetType(Boolean))
			For i As Integer = 0 To 4
				table.Rows.Add(New Object() { i, i, i, imageList1.Images(i), DateTime.Now })
			Next i
			gridControl1.DataSource = table
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			InitData()
		End Sub

		Private Sub OnItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			Dim editor As New AppearancesEditor(gridView1)
			editor.ShowDialog()
		End Sub

		Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseDown
			Dim view As GridView = TryCast(sender, GridView)
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.Location)
			If e.Button = MouseButtons.Right AndAlso hitInfo.InRow Then
				popupMenu1.ShowPopup(MousePosition)
			End If
		End Sub
	End Class
End Namespace
