﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerCreateDialog
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerCreateDialog))
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VersionTypeBox = New GroupedComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MapPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VersionBox = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IPAddressComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IPStyleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PortBox = New System.Windows.Forms.NumericUpDown()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.將連接埠設成預設值ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerDirBrowseBtn = New System.Windows.Forms.Button()
        Me.ServerDirBox = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.AdvancedPropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PortBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(469, 314)
        Me.TabControl1.Style = MetroFramework.MetroColorStyle.Green
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.ServerDirBrowseBtn)
        Me.TabPage1.Controls.Add(Me.ServerDirBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.HorizontalScrollbarBarColor = True
        Me.TabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage1.HorizontalScrollbarSize = 10
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(461, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "伺服器"
        Me.TabPage1.UseVisualStyleBackColor = True
        Me.TabPage1.VerticalScrollbarBarColor = True
        Me.TabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage1.VerticalScrollbarSize = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.VersionTypeBox)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.VersionBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 150)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "遊戲"
        '
        'VersionTypeBox
        '
        Me.VersionTypeBox.DataSource = Nothing
        Me.VersionTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VersionTypeBox.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.VersionTypeBox.FormattingEnabled = True
        Me.VersionTypeBox.Location = New System.Drawing.Point(83, 15)
        Me.VersionTypeBox.Name = "VersionTypeBox"
        Me.VersionTypeBox.Size = New System.Drawing.Size(144, 24)
        Me.VersionTypeBox.TabIndex = 45
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.MapPanel)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(427, 100)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "地圖"
        '
        'MapPanel
        '
        Me.MapPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapPanel.Location = New System.Drawing.Point(6, 21)
        Me.MapPanel.Name = "MapPanel"
        Me.MapPanel.Size = New System.Drawing.Size(414, 70)
        Me.MapPanel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "伺服器軟體："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VersionBox
        '
        Me.VersionBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VersionBox.Font = New System.Drawing.Font("微軟正黑體", 9.0!)
        Me.VersionBox.FormattingEnabled = True
        Me.VersionBox.Location = New System.Drawing.Point(300, 15)
        Me.VersionBox.Name = "VersionBox"
        Me.VersionBox.Size = New System.Drawing.Size(133, 24)
        Me.VersionBox.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "軟體版本："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.IPAddressComboBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.IPStyleComboBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PortBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(439, 75)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "連線"
        '
        'IPAddressComboBox
        '
        Me.IPAddressComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IPAddressComboBox.FormattingEnabled = True
        Me.IPAddressComboBox.Location = New System.Drawing.Point(62, 44)
        Me.IPAddressComboBox.Name = "IPAddressComboBox"
        Me.IPAddressComboBox.Size = New System.Drawing.Size(371, 24)
        Me.IPAddressComboBox.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "IP 位址："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IPStyleComboBox
        '
        Me.IPStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IPStyleComboBox.FormattingEnabled = True
        Me.IPStyleComboBox.Items.AddRange(New Object() {"浮動 IP", "綁定內部IP", "自訂綁定IP"})
        Me.IPStyleComboBox.Location = New System.Drawing.Point(62, 17)
        Me.IPStyleComboBox.Name = "IPStyleComboBox"
        Me.IPStyleComboBox.Size = New System.Drawing.Size(229, 24)
        Me.IPStyleComboBox.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "IP 模式："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PortBox
        '
        Me.PortBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PortBox.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.ServerManager.My.MySettings.Default, "CreateServerDialog_PortBoxValue", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PortBox.Location = New System.Drawing.Point(353, 16)
        Me.PortBox.Maximum = New Decimal(New Integer() {65534, 0, 0, 0})
        Me.PortBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(80, 23)
        Me.PortBox.TabIndex = 42
        Me.PortBox.Value = Global.ServerManager.My.MySettings.Default.CreateServerDialog_PortBoxValue
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.將連接埠設成預設值ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 26)
        '
        '將連接埠設成預設值ToolStripMenuItem
        '
        Me.將連接埠設成預設值ToolStripMenuItem.Name = "將連接埠設成預設值ToolStripMenuItem"
        Me.將連接埠設成預設值ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.將連接埠設成預設值ToolStripMenuItem.Text = "將連接埠設成預設值"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "連接埠："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ServerDirBrowseBtn
        '
        Me.ServerDirBrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerDirBrowseBtn.Location = New System.Drawing.Point(402, 5)
        Me.ServerDirBrowseBtn.Name = "ServerDirBrowseBtn"
        Me.ServerDirBrowseBtn.Size = New System.Drawing.Size(51, 23)
        Me.ServerDirBrowseBtn.TabIndex = 39
        Me.ServerDirBrowseBtn.Text = "瀏覽..."
        Me.ServerDirBrowseBtn.UseVisualStyleBackColor = True
        '
        'ServerDirBox
        '
        Me.ServerDirBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ServerDirBox.CustomButton.Image = Nothing
        Me.ServerDirBox.CustomButton.Location = New System.Drawing.Point(286, 2)
        Me.ServerDirBox.CustomButton.Name = ""
        Me.ServerDirBox.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.ServerDirBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ServerDirBox.CustomButton.TabIndex = 1
        Me.ServerDirBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ServerDirBox.CustomButton.UseSelectable = True
        Me.ServerDirBox.CustomButton.Visible = False
        Me.ServerDirBox.Lines = New String(-1) {}
        Me.ServerDirBox.Location = New System.Drawing.Point(90, 6)
        Me.ServerDirBox.MaxLength = 32767
        Me.ServerDirBox.Name = "ServerDirBox"
        Me.ServerDirBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ServerDirBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ServerDirBox.SelectedText = ""
        Me.ServerDirBox.SelectionLength = 0
        Me.ServerDirBox.SelectionStart = 0
        Me.ServerDirBox.ShortcutsEnabled = True
        Me.ServerDirBox.Size = New System.Drawing.Size(306, 22)
        Me.ServerDirBox.TabIndex = 38
        Me.ServerDirBox.UseSelectable = True
        Me.ServerDirBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ServerDirBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "伺服器路徑："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AdvancedPropertyGrid)
        Me.TabPage2.HorizontalScrollbarBarColor = True
        Me.TabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.TabPage2.HorizontalScrollbarSize = 10
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(461, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "進階設定"
        Me.TabPage2.UseVisualStyleBackColor = True
        Me.TabPage2.VerticalScrollbarBarColor = True
        Me.TabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.TabPage2.VerticalScrollbarSize = 10
        '
        'AdvancedPropertyGrid
        '
        Me.AdvancedPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvancedPropertyGrid.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AdvancedPropertyGrid.Location = New System.Drawing.Point(3, 3)
        Me.AdvancedPropertyGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.AdvancedPropertyGrid.Name = "AdvancedPropertyGrid"
        Me.AdvancedPropertyGrid.Size = New System.Drawing.Size(455, 268)
        Me.AdvancedPropertyGrid.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(475, 355)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.CreateButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 29)
        Me.Panel1.TabIndex = 0
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateButton.Location = New System.Drawing.Point(391, 3)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 0
        Me.CreateButton.Text = "建立"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        '
        'ServerCreateDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(515, 405)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DisplayHeader = False
        Me.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ServerCreateDialog"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "建立伺服器"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PortBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VersionBox As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PortBox As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ServerDirBrowseBtn As Button
    Friend WithEvents ServerDirBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MapPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CreateButton As Button
    Friend WithEvents AdvancedPropertyGrid As PropertyGrid
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 將連接埠設成預設值ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionTypeBox As GroupedComboBox
    Friend WithEvents IPAddressComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IPStyleComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
End Class
