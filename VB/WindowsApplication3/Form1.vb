Imports Microsoft.VisualBasic
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
			For i As Integer = 0 To 4
				dataSet11.Tables(0).Rows.Add(New Object() { i, i, i, imageList1.Images(i)})
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
