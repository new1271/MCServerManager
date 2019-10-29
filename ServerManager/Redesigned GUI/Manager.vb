﻿Imports SharpDX.Direct3D11
Imports SharpDX.DXGI
Imports Device = SharpDX.Direct3D11.Device
Public Class Manager
    Dim winQuery As Management.ObjectQuery = New Management.ObjectQuery("SELECT * FROM CIM_OperatingSystem")
    Dim searcher As New Management.ManagementObjectSearcher(winQuery)
    Dim tabs As MetroFramework.Controls.MetroPanel()
#Region "DirectX Variants"
    Dim d As Device
    Dim sc As SwapChain
    Dim target As Texture2D
    Dim targetView As RenderTargetView
#End Region
    Public Sub New()

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        tabs = {OverviewPanel, ServerPanel, ModpackServerPanel}
        Dim scd As New SwapChainDescription() With {
        .BufferCount = 1,
        .Flags = SwapChainFlags.None,
        .IsWindowed = True,
        .ModeDescription = New ModeDescription(ClientSize.Width, ClientSize.Height, New Rational(60, 1), Format.R8G8B8A8_UNorm),
        .OutputHandle = Handle,
        .SampleDescription = New SampleDescription(1, 0),
        .SwapEffect = SwapEffect.Discard,
        .Usage = Usage.RenderTargetOutput
        }
        Device.CreateWithSwapChain(SharpDX.Direct3D.DriverType.Hardware, DeviceCreationFlags.None, scd, d, sc)
        target = Texture2D.FromSwapChain(Of Texture2D)(sc, 0)
        targetView = New RenderTargetView(d, target)
        d.ImmediateContext.OutputMerger.SetRenderTargets(targetView)
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Try
            Dim CPUvalue As Integer = CPUPerformanceCounter.NextValue
            CPUCircularBar.Value = CPUvalue
            CPUCircularBar.Text = CPUvalue
            Select Case CPUvalue
                Case 100
                    CPUCircularBar.SubscriptMargin = New Padding(-32, 10, 0, 0)
                Case 10 To 99
                    CPUCircularBar.SubscriptMargin = New Padding(-22, 10, 0, 0)
                Case 0 To 9
                    CPUCircularBar.SubscriptMargin = New Padding(-12, 10, 0, 0)
            End Select
        Catch ex As Exception

        End Try
        For Each item In searcher.Get()
            Try
                Dim RAMvalue As Integer = 100 - item("FreePhysicalMemory") / item("TotalVisibleMemorySize") * 100
                RAMCircularBar.Value = RAMvalue
                RAMCircularBar.Text = RAMvalue
                Select Case RAMvalue
                    Case 100
                        RAMCircularBar.SubscriptMargin = New Padding(-30, 10, 0, 0)
                    Case 10 To 99
                        RAMCircularBar.SubscriptMargin = New Padding(-20, 10, 0, 0)
                    Case 0 To 9
                        RAMCircularBar.SubscriptMargin = New Padding(-10, 10, 0, 0)
                End Select
            Catch ex As Exception
                Continue For
            End Try
            Try
                Dim VirtualRAMvalue As Integer = 100 - item("FreeVirtualMemory") / item("TotalVirtualMemorySize") * 100
                VRAMCircularBar.Value = VirtualRAMvalue
                VRAMCircularBar.Text = VirtualRAMvalue
                Select Case VirtualRAMvalue
                    Case 100
                        VRAMCircularBar.SubscriptMargin = New Padding(-30, 10, 0, 0)
                    Case 10 To 99
                        VRAMCircularBar.SubscriptMargin = New Padding(-20, 10, 0, 0)
                    Case 0 To 9
                        VRAMCircularBar.SubscriptMargin = New Padding(-10, 10, 0, 0)
                End Select
            Catch ex As Exception
                Continue For
            End Try
            Exit For
        Next
        Try
            Dim category As New PerformanceCounterCategory("Network Interface")
            Dim names As String() = category.GetInstanceNames()
            Dim totalValue As Double = 0
            For Each name As String In names
                totalValue += getNetworkUtilization(name)
            Next
            Dim networkValue As Integer = totalValue / names.Count
            NetworkCircularBar.Value = networkValue
            NetworkCircularBar.Text = networkValue
            Select Case networkValue
                Case 100
                    NetworkCircularBar.SubscriptMargin = New Padding(-32, 10, 0, 0)
                Case 10 To 99
                    NetworkCircularBar.SubscriptMargin = New Padding(-22, 10, 0, 0)
                Case 0 To 9
                    NetworkCircularBar.SubscriptMargin = New Padding(-12, 10, 0, 0)
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Public Function getNetworkUtilization(networkCard As String) As Double
        Dim bandwidthCounter As New PerformanceCounter("Network Interface", "Current Bandwidth", networkCard)
        bandwidthCounter.NextValue()
        Dim bandwidth As Single = bandwidthCounter.NextValue()
        Dim dataSentCounter As New PerformanceCounter("Network Interface", "Bytes Sent/sec", networkCard)
        Dim dataReceivedCounter As New PerformanceCounter("Network Interface", "Bytes Received/sec", networkCard)
        Dim sendSum As Single = 0
        Dim receiveSum As Single = 0
        For i As Integer = 1 To 10
            sendSum += dataSentCounter.NextValue()
            receiveSum += dataReceivedCounter.NextValue()
        Next
        Dim utilization As Double = (8 * (sendSum + receiveSum)) / (bandwidth * 10) * 100
        Return utilization
    End Function
    Friend Overloads Sub AddServer(status As ServerStatus)
        If ServerList.Contains(status._server.ServerPath) = False Then
            With status
                .Width = ServerListLayout.Width - ServerListLayout.Padding.Left - ServerListLayout.Padding.Right - 6
            End With
            ServerListLayout.Controls.Add(status)
            ServerList.Add(status._server.ServerPath)
        End If
    End Sub
    Friend Overloads Sub AddServer(path As String)
        Try
            Dim status As New ServerStatus(path)
            With status
                .Width = ServerListLayout.Width - ServerListLayout.Padding.Left - ServerListLayout.Padding.Right - 6
            End With
            ServerListLayout.Controls.Add(status)
            If ServerList.Contains(path) = False Then ServerList.Add(path)
        Catch ex As NullReferenceException
            ServerList.Remove(path)
        End Try
    End Sub
    Private Sub NewManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        CPUPerformanceCounter.NextValue()
        For Each software In ServerMaker.SoftwareDictionary
            Try
                Dim item As New ListViewItem(software.Value.ReadableName)
                LoadingProgressView.Items.Add(item)
                If VersionListLoader.HasVersionListFunction(software.Value.ClassType) Then
                    item.SubItems.Add("載入中...")
                    Threading.Tasks.Task.Run(Sub()
                                                 Try
                                                     VersionListLoader.LoadVersionList(software.Value.ClassType)
                                                     BeginInvokeIfRequired(LoadingProgressView, Sub() item.SubItems(1).Text = "載入完成")
                                                 Catch ex As Exception
                                                     BeginInvokeIfRequired(LoadingProgressView, Sub() item.SubItems(1).Text = "載入錯誤")
                                                 End Try
                                             End Sub)
                Else
                    item.SubItems.Add("無需載入")
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub ToolTip1_Draw(sender As Object, e As DrawToolTipEventArgs) Handles ToolTip1.Draw
        e.DrawBorder()
        e.DrawBackground()
        e.Graphics.DrawRectangle(New Pen(Color.FromArgb(100, 100, 100)), e.Bounds)
        e.DrawText()
    End Sub
    Dim MoveAnimationDictionary As New Dictionary(Of Control, (Label, MetroFramework.Animation.MoveAnimation, Boolean))



    Private Sub MenuButtons_MouseEnter(sender As Object, e As EventArgs) Handles RadioButton1.MouseEnter, RadioButton2.MouseEnter, RadioButton3.MouseEnter
        If MoveAnimationDictionary.ContainsKey(sender) = False Then
            Dim label As New Label
            label.BackColor = Color.FromArgb(0, 197, 99)
            label.Font = New System.Drawing.Font("微軟正黑體", 11.0!, FontStyle.Bold)
            label.Text = sender.Tag
            label.Size = New Size(3 + TextRenderer.MeasureText(label.Text, label.Font).Width, sender.Height)
            label.Location = New Point(-20 - label.Size.Width, sender.Top + ControlPanel.Top)
            label.ForeColor = System.Drawing.Color.White
            label.TextAlign = ContentAlignment.MiddleLeft
            Controls.Add(label)
            label.BringToFront()
            ControlPanel.BringToFront()
            Dim ani As New MetroFramework.Animation.MoveAnimation()
            MoveAnimationDictionary.Add(sender, (label, ani, True))
            ani.Start(label, New Point(sender.Left + sender.Width, sender.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
        Else
            Dim item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
            If item.Item3 = False Then
                item.Item2.Cancel()
                item.Item3 = True
                item.Item2.Start(item.Item1, New Point(sender.Left + sender.Width, sender.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
                MoveAnimationDictionary(sender) = item
            End If
        End If
    End Sub

    Private Sub MenuButtons_MouseLeave(sender As Object, e As EventArgs) Handles RadioButton1.MouseLeave, RadioButton2.MouseLeave, RadioButton3.MouseLeave
        If MoveAnimationDictionary.ContainsKey(sender) Then
            Dim item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
            If item.Item3 Then
                item.Item2.Cancel()
                item.Item3 = False
                item.Item2.Start(item.Item1, New Point(-20 - item.Item1.Size.Width, sender.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
                MoveAnimationDictionary(sender) = item
                AddHandler item.Item2.AnimationCompleted, Sub()
                                                              If MoveAnimationDictionary.ContainsKey(sender) Then
                                                                  Dim _item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
                                                                  If _item.Item3 = False Then
                                                                      MoveAnimationDictionary.Remove(sender)
                                                                  End If
                                                              End If
                                                          End Sub
            End If
        End If
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If MoveAnimationDictionary.ContainsKey(sender) = False Then
            Dim label As New Label
            label.BackColor = Color.FromArgb(0, 197, 99)
            label.Font = New System.Drawing.Font("微軟正黑體", 11.0!, FontStyle.Bold)
            label.Text = sender.Tag
            label.Size = New Size(3 + TextRenderer.MeasureText(label.Text, label.Font).Width, sender.Parent.Height)
            label.Location = New Point(-20 - label.Size.Width, sender.Parent.Top + ControlPanel.Top)
            label.ForeColor = System.Drawing.Color.White
            label.TextAlign = ContentAlignment.MiddleLeft
            Controls.Add(label)
            label.BringToFront()
            ControlPanel.BringToFront()
            Dim ani As New MetroFramework.Animation.MoveAnimation()
            MoveAnimationDictionary.Add(sender, (label, ani, True))
            ani.Start(label, New Point(sender.Parent.Left + sender.Parent.Width, sender.Parent.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
        Else
            Dim item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
            If item.Item3 = False Then
                item.Item2.Cancel()
                item.Item3 = True
                item.Item2.Start(item.Item1, New Point(sender.Parent.Left + sender.Parent.Width, sender.Parent.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
                MoveAnimationDictionary(sender) = item
            End If
        End If
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        If MoveAnimationDictionary.ContainsKey(sender) Then
            Dim item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
            If item.Item3 Then
                item.Item2.Cancel()
                item.Item3 = False
                item.Item2.Start(item.Item1, New Point(-20 - item.Item1.Size.Width, sender.Parent.Top + ControlPanel.Top), MetroFramework.Animation.TransitionType.Linear, 20)
                MoveAnimationDictionary(sender) = item
                AddHandler item.Item2.AnimationCompleted, Sub()
                                                              If MoveAnimationDictionary.ContainsKey(sender) Then
                                                                  Dim _item As (Label, MetroFramework.Animation.MoveAnimation, Boolean) = MoveAnimationDictionary(sender)
                                                                  If _item.Item3 = False Then
                                                                      MoveAnimationDictionary.Remove(sender)
                                                                  End If
                                                              End If
                                                          End Sub
            End If
        End If
    End Sub
    Private Sub ChangePanel(index As Integer)
        Threading.Tasks.Task.Run(Sub()
                                     Do Until tabs IsNot Nothing
                                     Loop
                                     For i As Integer = 0 To tabs.Count - 1
                                         Dim _index = i
                                         If _index = index Then
                                             BeginInvokeIfRequired(tabs(_index), Sub()
                                                                                     tabs(_index).Visible = True
                                                                                 End Sub)
                                         Else
                                             BeginInvokeIfRequired(tabs(_index), Sub()
                                                                                     tabs(_index).Visible = False
                                                                                 End Sub)
                                         End If
                                     Next
                                 End Sub)
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then ChangePanel(0)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then ChangePanel(1)
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then ChangePanel(2)
    End Sub

    Private Sub AddServerButton_Click(sender As Object, e As EventArgs) Handles AddServerButton.Click
        Dim dialog As New CreateServerDialog(Me)
        dialog.Show()
    End Sub

    Private Sub JoinServerButton_Click(sender As Object, e As EventArgs) Handles JoinServerButton.Click
        Dim fileDialog As New OpenFileDialog()
        fileDialog.Filter = "伺服器資訊清單 (server.info)|server.info"
        fileDialog.Title = "加入伺服器"
        If fileDialog.ShowDialog() = DialogResult.OK Then
            AddServer(New IO.FileInfo(fileDialog.FileName).DirectoryName)
        End If
    End Sub

    Private Sub Manager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetInternalIPAddresses()
        Dim arr = ServerList.ToArray
        For Each item In arr
            AddServer(item)
        Next
    End Sub
    Sub GetInternalIPAddresses()
        If GlobalModule.IPList IsNot Nothing Then Erase GlobalModule.IPList
        Dim ipList As New List(Of String)()
        For Each address In Net.Dns.GetHostByName(Net.Dns.GetHostName).AddressList
            If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork OrElse
               (address.AddressFamily = Net.Sockets.AddressFamily.InterNetworkV6 AndAlso address.IsIPv6LinkLocal) Then
                ipList.Add(address.ToString)
            End If
        Next
        GlobalModule.IPList = ipList.ToArray()
    End Sub

    Private Sub Manager_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Y < 25 OrElse e.X = Width - Margin.Right Then
            WinAPI.MoveForm(Handle)
        End If
    End Sub

    Private Sub ServerListLayout_Resize(sender As Object, e As EventArgs) Handles ServerListLayout.Resize
        For Each control In ServerListLayout.Controls
            With control
                .Width = ServerListLayout.Width - ServerListLayout.Padding.Left - ServerListLayout.Padding.Right - 6
            End With
        Next
    End Sub

    Private Sub Manager_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        d.ImmediateContext.ClearRenderTargetView(targetView, New SharpDX.Mathematics.Interop.RawColor4(255, 255, 255, 0))
        sc.Present(0, PresentFlags.None)
    End Sub

    Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        d.Dispose()
        sc.Dispose()
        target.Dispose()
        targetView.Dispose()
    End Sub
End Class