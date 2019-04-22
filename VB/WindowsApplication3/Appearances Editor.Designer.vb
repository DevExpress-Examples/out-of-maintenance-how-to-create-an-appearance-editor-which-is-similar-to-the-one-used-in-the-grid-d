Namespace WindowsApplication3
	Partial Public Class AppearancesEditor
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
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.propertyDescriptionControl1 = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.checkEdit4 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit3 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.Size = New System.Drawing.Size(347, 438)
			Me.propertyGridControl1.TabIndex = 0
			' 
			' propertyDescriptionControl1
			' 
			Me.propertyDescriptionControl1.Location = New System.Drawing.Point(12, 454)
			Me.propertyDescriptionControl1.Name = "propertyDescriptionControl1"
			Me.propertyDescriptionControl1.PropertyGrid = Me.propertyGridControl1
			Me.propertyDescriptionControl1.Size = New System.Drawing.Size(347, 102)
			Me.propertyDescriptionControl1.TabIndex = 1
			Me.propertyDescriptionControl1.TabStop = False
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.simpleButton2)
			Me.layoutControl1.Controls.Add(Me.simpleButton1)
			Me.layoutControl1.Controls.Add(Me.checkEdit4)
			Me.layoutControl1.Controls.Add(Me.checkEdit3)
			Me.layoutControl1.Controls.Add(Me.checkEdit2)
			Me.layoutControl1.Controls.Add(Me.checkEdit1)
			Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
			Me.layoutControl1.Controls.Add(Me.propertyDescriptionControl1)
			Me.layoutControl1.Controls.Add(Me.propertyGridControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(584, 568)
			Me.layoutControl1.TabIndex = 2
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(363, 533)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(209, 23)
			Me.simpleButton2.StyleController = Me.layoutControl1
			Me.simpleButton2.TabIndex = 11
			Me.simpleButton2.Text = "Load Appearances"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton2.Click += new System.EventHandler(this.OnLoadButtonClick);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(363, 506)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(209, 23)
			Me.simpleButton1.StyleController = Me.layoutControl1
			Me.simpleButton1.TabIndex = 10
			Me.simpleButton1.Text = "Save Appearances"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.OnSaveButtonClick);
			' 
			' checkEdit4
			' 
			Me.checkEdit4.Location = New System.Drawing.Point(363, 113)
			Me.checkEdit4.Name = "checkEdit4"
			Me.checkEdit4.Properties.Caption = "Enable Appearacne FocusedCell"
			Me.checkEdit4.Size = New System.Drawing.Size(209, 21)
			Me.checkEdit4.StyleController = Me.layoutControl1
			Me.checkEdit4.TabIndex = 9
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.checkEdit4.CheckedChanged += new System.EventHandler(this.OnEnableAppearanceFocusedCellChanged);
			' 
			' checkEdit3
			' 
			Me.checkEdit3.Location = New System.Drawing.Point(363, 88)
			Me.checkEdit3.Name = "checkEdit3"
			Me.checkEdit3.Properties.Caption = "Enable Appearance FocusedRow"
			Me.checkEdit3.Size = New System.Drawing.Size(209, 21)
			Me.checkEdit3.StyleController = Me.layoutControl1
			Me.checkEdit3.TabIndex = 8
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.checkEdit3.CheckedChanged += new System.EventHandler(this.OnEnableAppearanceFocusedRowChanged);
			' 
			' checkEdit2
			' 
			Me.checkEdit2.Location = New System.Drawing.Point(363, 63)
			Me.checkEdit2.Name = "checkEdit2"
			Me.checkEdit2.Properties.Caption = "Enable Appearance Odd Row"
			Me.checkEdit2.Size = New System.Drawing.Size(209, 21)
			Me.checkEdit2.StyleController = Me.layoutControl1
			Me.checkEdit2.TabIndex = 7
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.checkEdit2.CheckedChanged += new System.EventHandler(this.OnEnableAppearanceOddRowChanged);
			' 
			' checkEdit1
			' 
			Me.checkEdit1.Location = New System.Drawing.Point(363, 38)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Enable Appearance Even Row"
			Me.checkEdit1.Size = New System.Drawing.Size(209, 21)
			Me.checkEdit1.StyleController = Me.layoutControl1
			Me.checkEdit1.TabIndex = 6
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.checkEdit1.CheckedChanged += new System.EventHandler(this.OnEnableAppearanceEvenRowChanged);
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Location = New System.Drawing.Point(423, 12)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(149, 22)
			Me.comboBoxEdit1.StyleController = Me.layoutControl1
			Me.comboBoxEdit1.TabIndex = 5
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.comboBoxEdit1.EditValueChanged += new System.EventHandler(this.comboBoxEdit1_EditValueChanged);
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Root"
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(584, 568)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.propertyGridControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.MinSize = New System.Drawing.Size(104, 24)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(351, 442)
			Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.propertyDescriptionControl1
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 442)
			Me.layoutControlItem2.MinSize = New System.Drawing.Size(104, 24)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(351, 106)
			Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.comboBoxEdit1
			Me.layoutControlItem4.CustomizationFormText = "PaintStyle"
			Me.layoutControlItem4.Location = New System.Drawing.Point(351, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(213, 26)
			Me.layoutControlItem4.Text = "PaintStyle"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(56, 16)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.checkEdit1
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(351, 26)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(213, 25)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.checkEdit2
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(351, 51)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(213, 25)
			Me.layoutControlItem6.Text = "layoutControlItem6"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.checkEdit3
			Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
			Me.layoutControlItem7.Location = New System.Drawing.Point(351, 76)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(213, 25)
			Me.layoutControlItem7.Text = "layoutControlItem7"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem7.TextToControlDistance = 0
			Me.layoutControlItem7.TextVisible = False
			' 
			' layoutControlItem8
			' 
			Me.layoutControlItem8.Control = Me.checkEdit4
			Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
			Me.layoutControlItem8.Location = New System.Drawing.Point(351, 101)
			Me.layoutControlItem8.Name = "layoutControlItem8"
			Me.layoutControlItem8.Size = New System.Drawing.Size(213, 25)
			Me.layoutControlItem8.Text = "layoutControlItem8"
			Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem8.TextToControlDistance = 0
			Me.layoutControlItem8.TextVisible = False
			' 
			' layoutControlItem9
			' 
			Me.layoutControlItem9.Control = Me.simpleButton1
			Me.layoutControlItem9.CustomizationFormText = "layoutControlItem9"
			Me.layoutControlItem9.Location = New System.Drawing.Point(351, 494)
			Me.layoutControlItem9.Name = "layoutControlItem9"
			Me.layoutControlItem9.Size = New System.Drawing.Size(213, 27)
			Me.layoutControlItem9.Text = "layoutControlItem9"
			Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem9.TextToControlDistance = 0
			Me.layoutControlItem9.TextVisible = False
			' 
			' layoutControlItem10
			' 
			Me.layoutControlItem10.Control = Me.simpleButton2
			Me.layoutControlItem10.CustomizationFormText = "layoutControlItem10"
			Me.layoutControlItem10.Location = New System.Drawing.Point(351, 521)
			Me.layoutControlItem10.Name = "layoutControlItem10"
			Me.layoutControlItem10.Size = New System.Drawing.Size(213, 27)
			Me.layoutControlItem10.Text = "layoutControlItem10"
			Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem10.TextToControlDistance = 0
			Me.layoutControlItem10.TextVisible = False
			' 
			' emptySpaceItem1
			' 
			Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
			Me.emptySpaceItem1.Location = New System.Drawing.Point(351, 126)
			Me.emptySpaceItem1.Name = "emptySpaceItem1"
			Me.emptySpaceItem1.Size = New System.Drawing.Size(213, 368)
			Me.emptySpaceItem1.Text = "emptySpaceItem1"
			Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.FileName = "openFileDialog1"
			Me.openFileDialog1.Filter = "XML files|*.xml"
			Me.openFileDialog1.InitialDirectory = "C:\"
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.Filter = "XML files|*.xml"
			Me.saveFileDialog1.InitialDirectory = "C:\"
			' 
			' AppearancesEditor
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(584, 568)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "AppearancesEditor"
			Me.Text = "Appearances_Editor"
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.checkEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private propertyDescriptionControl1 As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents checkEdit4 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit3 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
		Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	End Class
End Namespace