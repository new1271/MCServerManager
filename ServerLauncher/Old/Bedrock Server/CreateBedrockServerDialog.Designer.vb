﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateBedrockServerDialog
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PortBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerDirBrowseBtn = New System.Windows.Forms.Button()
        Me.ServerDirBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChooseDirectoryDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IPBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.VersionBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LevelTypeBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LevelSeedBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LevelNameBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GeneratorSettingBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ServerTypeBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ServerOption = New System.Windows.Forms.GroupBox()
        Me.ServerOptionBox = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PortBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ServerOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(339, 394)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "確定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'PortBox
        '
        Me.PortBox.Location = New System.Drawing.Point(92, 32)
        Me.PortBox.Maximum = New Decimal(New Integer() {65534, 0, 0, 0})
        Me.PortBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(120, 22)
        Me.PortBox.TabIndex = 42
        Me.PortBox.Value = New Decimal(New Integer() {25565, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "連接埠："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ServerDirBrowseBtn
        '
        Me.ServerDirBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerDirBrowseBtn.Location = New System.Drawing.Point(434, 4)
        Me.ServerDirBrowseBtn.Name = "ServerDirBrowseBtn"
        Me.ServerDirBrowseBtn.Size = New System.Drawing.Size(51, 23)
        Me.ServerDirBrowseBtn.TabIndex = 40
        Me.ServerDirBrowseBtn.Text = "瀏覽..."
        Me.ServerDirBrowseBtn.UseVisualStyleBackColor = True
        '
        'ServerDirBox
        '
        Me.ServerDirBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerDirBox.Location = New System.Drawing.Point(92, 4)
        Me.ServerDirBox.Name = "ServerDirBox"
        Me.ServerDirBox.Size = New System.Drawing.Size(336, 22)
        Me.ServerDirBox.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "伺服器路徑："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IPBox)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 71)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP 選項"
        '
        'IPBox
        '
        Me.IPBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IPBox.Location = New System.Drawing.Point(64, 38)
        Me.IPBox.Name = "IPBox"
        Me.IPBox.ReadOnly = True
        Me.IPBox.Size = New System.Drawing.Size(397, 22)
        Me.IPBox.TabIndex = 34
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 16)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.Text = "自訂："
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "預設"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'VersionBox
        '
        Me.VersionBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VersionBox.FormattingEnabled = True
        Me.VersionBox.Items.AddRange(New Object() {"(最新版)"})
        Me.VersionBox.Location = New System.Drawing.Point(229, 132)
        Me.VersionBox.Name = "VersionBox"
        Me.VersionBox.Size = New System.Drawing.Size(81, 20)
        Me.VersionBox.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 136)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "版本："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LevelTypeBox
        '
        Me.LevelTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelTypeBox.FormattingEnabled = True
        Me.LevelTypeBox.Items.AddRange(New Object() {"預設", "超平坦", "超大生態系", "巨大化世界", "自訂(配合生成器設置)"})
        Me.LevelTypeBox.Location = New System.Drawing.Point(378, 132)
        Me.LevelTypeBox.Name = "LevelTypeBox"
        Me.LevelTypeBox.Size = New System.Drawing.Size(107, 20)
        Me.LevelTypeBox.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 136)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "地圖類型："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LevelSeedBox
        '
        Me.LevelSeedBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LevelSeedBox.Location = New System.Drawing.Point(247, 158)
        Me.LevelSeedBox.Name = "LevelSeedBox"
        Me.LevelSeedBox.Size = New System.Drawing.Size(238, 22)
        Me.LevelSeedBox.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(179, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "世界種子："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LevelNameBox
        '
        Me.LevelNameBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LevelNameBox.Location = New System.Drawing.Point(92, 158)
        Me.LevelNameBox.Name = "LevelNameBox"
        Me.LevelNameBox.Size = New System.Drawing.Size(82, 22)
        Me.LevelNameBox.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 163)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "世界名稱："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GeneratorSettingBox
        '
        Me.GeneratorSettingBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneratorSettingBox.Location = New System.Drawing.Point(92, 186)
        Me.GeneratorSettingBox.Name = "GeneratorSettingBox"
        Me.GeneratorSettingBox.Size = New System.Drawing.Size(393, 22)
        Me.GeneratorSettingBox.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "生成器設置："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ServerTypeBox
        '
        Me.ServerTypeBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ServerTypeBox.FormattingEnabled = True
        Me.ServerTypeBox.Items.AddRange(New Object() {"Nukkit"})
        Me.ServerTypeBox.Location = New System.Drawing.Point(92, 132)
        Me.ServerTypeBox.Name = "ServerTypeBox"
        Me.ServerTypeBox.Size = New System.Drawing.Size(91, 20)
        Me.ServerTypeBox.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "伺服器類型："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ServerOption
        '
        Me.ServerOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerOption.Controls.Add(Me.ServerOptionBox)
        Me.ServerOption.Location = New System.Drawing.Point(14, 214)
        Me.ServerOption.Name = "ServerOption"
        Me.ServerOption.Size = New System.Drawing.Size(471, 174)
        Me.ServerOption.TabIndex = 56
        Me.ServerOption.TabStop = False
        Me.ServerOption.Text = "伺服器設定"
        '
        'ServerOptionBox
        '
        Me.ServerOptionBox.AutoScroll = True
        Me.ServerOptionBox.AutoSize = True
        Me.ServerOptionBox.ColumnCount = 2
        Me.ServerOptionBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.ServerOptionBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ServerOptionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServerOptionBox.Location = New System.Drawing.Point(3, 18)
        Me.ServerOptionBox.Name = "ServerOptionBox"
        Me.ServerOptionBox.RowCount = 21
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ServerOptionBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ServerOptionBox.Size = New System.Drawing.Size(465, 153)
        Me.ServerOptionBox.TabIndex = 3
        '
        'CreateBedrockServerDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(497, 433)
        Me.Controls.Add(Me.ServerOption)
        Me.Controls.Add(Me.VersionBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LevelTypeBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LevelSeedBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LevelNameBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GeneratorSettingBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ServerTypeBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ServerDirBrowseBtn)
        Me.Controls.Add(Me.ServerDirBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateBedrockServerDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "建立基岩版伺服器"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PortBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ServerOption.ResumeLayout(False)
        Me.ServerOption.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PortBox As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerDirBrowseBtn As Button
    Friend WithEvents ServerDirBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChooseDirectoryDialog As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IPBox As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents VersionBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LevelTypeBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LevelSeedBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LevelNameBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GeneratorSettingBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ServerTypeBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ServerOption As GroupBox
    Friend WithEvents ServerOptionBox As TableLayoutPanel
End Class
