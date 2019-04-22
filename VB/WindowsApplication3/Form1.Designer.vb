Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.jpg")
			Me.imageList1.Images.SetKeyName(1, "2.jpg")
			Me.imageList1.Images.SetKeyName(2, "3.jpg")
			Me.imageList1.Images.SetKeyName(3, "4.jpg")
			Me.imageList1.Images.SetKeyName(4, "5.jpg")
			Me.imageList1.Images.SetKeyName(5, "6.jpg")
			Me.imageList1.Images.SetKeyName(6, "7.jpg")
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.gridControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(2)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(858, 421)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.Red
			Me.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.Blue
			Me.gridView1.Appearance.FixedLine.Options.UseBackColor = True
			Me.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.Blue
			Me.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(255)))), (CInt((CByte(192)))))
			Me.gridView1.Appearance.GroupPanel.Options.UseBackColor = True
			Me.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.Navy
			Me.gridView1.Appearance.HorzLine.Options.UseBackColor = True
			Me.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(255)))))
			Me.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(192)))), (CInt((CByte(255)))))
			Me.gridView1.Appearance.Row.Options.UseBackColor = True
			Me.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.Navy
			Me.gridView1.Appearance.VertLine.Options.UseBackColor = True
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colImage, Me.colDate, Me.colCheck})
			Me.gridView1.DetailHeight = 284
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.MinWidth = 15
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			Me.colCustomerID.Width = 56
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.MinWidth = 15
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			Me.colFirstName.Width = 56
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.MinWidth = 15
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			Me.colLastName.Width = 56
			' 
			' colImage
			' 
			Me.colImage.FieldName = "Image"
			Me.colImage.MinWidth = 15
			Me.colImage.Name = "colImage"
			Me.colImage.Visible = True
			Me.colImage.VisibleIndex = 3
			Me.colImage.Width = 56
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.MinWidth = 15
			Me.colDate.Name = "colDate"
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 4
			Me.colDate.Width = 56
			' 
			' colCheck
			' 
			Me.colCheck.FieldName = "Check"
			Me.colCheck.MinWidth = 15
			Me.colCheck.Name = "colCheck"
			Me.colCheck.Visible = True
			Me.colCheck.VisibleIndex = 5
			Me.colCheck.Width = 56
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1})
			Me.barManager1.MaxItemId = 1
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(2)
			Me.barDockControlTop.Size = New System.Drawing.Size(858, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 421)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(2)
			Me.barDockControlBottom.Size = New System.Drawing.Size(858, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(2)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(858, 0)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(2)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Show Appearances Editor"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnItemClick);
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(858, 421)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private imageList1 As System.Windows.Forms.ImageList
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colImage As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCheck As DevExpress.XtraGrid.Columns.GridColumn
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
	End Class
End Namespace

