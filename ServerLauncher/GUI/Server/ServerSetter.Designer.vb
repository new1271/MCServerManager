﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServerSetter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServerSetter))
        Me.SettingTabControl = New System.Windows.Forms.TabControl()
        Me.NormalTabPage = New System.Windows.Forms.TabPage()
        Me.TaskGroupBox = New System.Windows.Forms.GroupBox()
        Me.TaskListBox = New System.Windows.Forms.CheckedListBox()
        Me.TaskControlPanel = New System.Windows.Forms.Panel()
        Me.RemoveTaskButton = New System.Windows.Forms.Button()
        Me.EditTaskButton = New System.Windows.Forms.Button()
        Me.AddTaskButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MapPanel = New System.Windows.Forms.Panel()
        Me.UpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PluginManageButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AdvancedTabPage = New System.Windows.Forms.TabPage()
        Me.AdvancedPropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SettingTabControl.SuspendLayout()
        Me.NormalTabPage.SuspendLayout()
        Me.TaskGroupBox.SuspendLayout()
        Me.TaskControlPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.UpdateGroupBox.SuspendLayout()
        Me.AdvancedTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingTabControl
        '
        Me.SettingTabControl.Controls.Add(Me.NormalTabPage)
        Me.SettingTabControl.Controls.Add(Me.AdvancedTabPage)
        Me.SettingTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingTabControl.Location = New System.Drawing.Point(0, 0)
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        Me.SettingTabControl.Size = New System.Drawing.Size(584, 461)
        Me.SettingTabControl.TabIndex = 0
        '
        'NormalTabPage
        '
        Me.NormalTabPage.AutoScroll = True
        Me.NormalTabPage.Controls.Add(Me.TaskGroupBox)
        Me.NormalTabPage.Controls.Add(Me.GroupBox4)
        Me.NormalTabPage.Controls.Add(Me.UpdateGroupBox)
        Me.NormalTabPage.Controls.Add(Me.Button1)
        Me.NormalTabPage.Controls.Add(Me.PluginManageButton)
        Me.NormalTabPage.Controls.Add(Me.Button4)
        Me.NormalTabPage.Location = New System.Drawing.Point(4, 22)
        Me.NormalTabPage.Name = "NormalTabPage"
        Me.NormalTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.NormalTabPage.Size = New System.Drawing.Size(576, 435)
        Me.NormalTabPage.TabIndex = 0
        Me.NormalTabPage.Text = "一般"
        Me.NormalTabPage.UseVisualStyleBackColor = True
        '
        'TaskGroupBox
        '
        Me.TaskGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskGroupBox.Controls.Add(Me.TaskListBox)
        Me.TaskGroupBox.Controls.Add(Me.TaskControlPanel)
        Me.TaskGroupBox.Location = New System.Drawing.Point(3, 175)
        Me.TaskGroupBox.Name = "TaskGroupBox"
        Me.TaskGroupBox.Size = New System.Drawing.Size(565, 92)
        Me.TaskGroupBox.TabIndex = 53
        Me.TaskGroupBox.TabStop = False
        Me.TaskGroupBox.Text = "排定工作"
        '
        'TaskListBox
        '
        Me.TaskListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskListBox.CheckOnClick = True
        Me.TaskListBox.FormattingEnabled = True
        Me.TaskListBox.Location = New System.Drawing.Point(6, 14)
        Me.TaskListBox.Name = "TaskListBox"
        Me.TaskListBox.Size = New System.Drawing.Size(461, 72)
        Me.TaskListBox.TabIndex = 1
        '
        'TaskControlPanel
        '
        Me.TaskControlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskControlPanel.Controls.Add(Me.RemoveTaskButton)
        Me.TaskControlPanel.Controls.Add(Me.EditTaskButton)
        Me.TaskControlPanel.Controls.Add(Me.AddTaskButton)
        Me.TaskControlPanel.Location = New System.Drawing.Point(473, 14)
        Me.TaskControlPanel.Name = "TaskControlPanel"
        Me.TaskControlPanel.Size = New System.Drawing.Size(89, 72)
        Me.TaskControlPanel.TabIndex = 2
        '
        'RemoveTaskButton
        '
        Me.RemoveTaskButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RemoveTaskButton.Location = New System.Drawing.Point(0, 46)
        Me.RemoveTaskButton.Name = "RemoveTaskButton"
        Me.RemoveTaskButton.Size = New System.Drawing.Size(89, 23)
        Me.RemoveTaskButton.TabIndex = 2
        Me.RemoveTaskButton.Text = "移除工作..."
        Me.RemoveTaskButton.UseVisualStyleBackColor = True
        '
        'EditTaskButton
        '
        Me.EditTaskButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.EditTaskButton.Location = New System.Drawing.Point(0, 23)
        Me.EditTaskButton.Name = "EditTaskButton"
        Me.EditTaskButton.Size = New System.Drawing.Size(89, 23)
        Me.EditTaskButton.TabIndex = 1
        Me.EditTaskButton.Text = "修改工作..."
        Me.EditTaskButton.UseVisualStyleBackColor = True
        '
        'AddTaskButton
        '
        Me.AddTaskButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTaskButton.Location = New System.Drawing.Point(0, 0)
        Me.AddTaskButton.Name = "AddTaskButton"
        Me.AddTaskButton.Size = New System.Drawing.Size(89, 23)
        Me.AddTaskButton.TabIndex = 0
        Me.AddTaskButton.Text = "新增工作..."
        Me.AddTaskButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.MapPanel)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(565, 100)
        Me.GroupBox4.TabIndex = 52
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
        Me.MapPanel.Size = New System.Drawing.Size(552, 70)
        Me.MapPanel.TabIndex = 0
        '
        'UpdateGroupBox
        '
        Me.UpdateGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateGroupBox.Controls.Add(Me.Button2)
        Me.UpdateGroupBox.Controls.Add(Me.UpdateButton)
        Me.UpdateGroupBox.Controls.Add(Me.VersionLabel)
        Me.UpdateGroupBox.Location = New System.Drawing.Point(3, 6)
        Me.UpdateGroupBox.Name = "UpdateGroupBox"
        Me.UpdateGroupBox.Size = New System.Drawing.Size(565, 57)
        Me.UpdateGroupBox.TabIndex = 48
        Me.UpdateGroupBox.TabStop = False
        Me.UpdateGroupBox.Text = "軟體"
        '
        'UpdateButton
        '
        Me.UpdateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateButton.AutoSize = True
        Me.UpdateButton.Location = New System.Drawing.Point(513, 18)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(46, 29)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "更新"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(6, 18)
        Me.VersionLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(501, 29)
        Me.VersionLabel.TabIndex = 0
        Me.VersionLabel.Text = "<ServerVersionType>：<ServerVersionStatus>"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(3, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(565, 44)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "設定白名單"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PluginManageButton
        '
        Me.PluginManageButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PluginManageButton.Location = New System.Drawing.Point(3, 323)
        Me.PluginManageButton.Name = "PluginManageButton"
        Me.PluginManageButton.Size = New System.Drawing.Size(565, 44)
        Me.PluginManageButton.TabIndex = 50
        Me.PluginManageButton.Text = "管理插件"
        Me.PluginManageButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(3, 273)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(565, 44)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "選擇伺服器圖示"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AdvancedTabPage
        '
        Me.AdvancedTabPage.Controls.Add(Me.AdvancedPropertyGrid)
        Me.AdvancedTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AdvancedTabPage.Name = "AdvancedTabPage"
        Me.AdvancedTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvancedTabPage.Size = New System.Drawing.Size(576, 435)
        Me.AdvancedTabPage.TabIndex = 1
        Me.AdvancedTabPage.Text = "進階"
        Me.AdvancedTabPage.UseVisualStyleBackColor = True
        '
        'AdvancedPropertyGrid
        '
        Me.AdvancedPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvancedPropertyGrid.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AdvancedPropertyGrid.Location = New System.Drawing.Point(3, 3)
        Me.AdvancedPropertyGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.AdvancedPropertyGrid.Name = "AdvancedPropertyGrid"
        Me.AdvancedPropertyGrid.Size = New System.Drawing.Size(570, 429)
        Me.AdvancedPropertyGrid.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(444, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "檢查更新"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ServerSetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.SettingTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ServerSetter"
        Me.ShowIcon = False
        Me.Text = "伺服器設定"
        Me.SettingTabControl.ResumeLayout(False)
        Me.NormalTabPage.ResumeLayout(False)
        Me.TaskGroupBox.ResumeLayout(False)
        Me.TaskControlPanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.UpdateGroupBox.ResumeLayout(False)
        Me.UpdateGroupBox.PerformLayout()
        Me.AdvancedTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingTabControl As TabControl
    Friend WithEvents NormalTabPage As TabPage
    Friend WithEvents AdvancedTabPage As TabPage
    Friend WithEvents AdvancedPropertyGrid As PropertyGrid
    Friend WithEvents TaskGroupBox As GroupBox
    Friend WithEvents TaskListBox As CheckedListBox
    Friend WithEvents TaskControlPanel As Panel
    Friend WithEvents RemoveTaskButton As Button
    Friend WithEvents EditTaskButton As Button
    Friend WithEvents AddTaskButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MapPanel As Panel
    Friend WithEvents UpdateGroupBox As GroupBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PluginManageButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
End Class
