﻿Imports System.Threading.Tasks

Public Class ServerStatus
    Public Event DeleteServer(NoUI As Boolean)
    Dim _Server As ServerBase
    Public Property ServerBase As ServerBase
        Get
            Return _Server
        End Get
        Friend Set(value As ServerBase)
            Dim serverGCLayer As Integer = GC.GetGeneration(_Server)
            _Server = Nothing
            GC.Collect(serverGCLayer)
            _Server = value
        End Set
    End Property
    Protected console As ServerConsole
    Protected setter As ServerSetter
    Public Event ServerLoaded()
    Sub New(ByRef server As ServerBase)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        _Server = server
        AddHandler _Server.Initallised, AddressOf UpdateComponentOnFirstRun
        GlobalModule.Manager.ServerEntityList.Add(_Server)
    End Sub
    Sub New(serverDir As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        _Server = ServerMaker.GetServer(serverDir)
        AddHandler _Server.Initallised, AddressOf UpdateComponentOnFirstRun
        GlobalModule.Manager.ServerEntityList.Add(_Server)
    End Sub
    Friend Sub LoadStatus()
        AddHandler _Server.ServerInfoUpdated, AddressOf UpdateComponent
        AddHandler _Server.ServerIconUpdated, Sub() ServerIcon.Image = ServerBase.ServerIcon
        AddHandler _Server.ServerDownloadStart, Sub() SetVersionLabel(True)
        AddHandler _Server.ServerDownloading, Sub(progress) SetVersionLabel(True, progress)
        AddHandler _Server.ServerDownloadEnd, Sub() SetVersionLabel()
        AddHandler GlobalModule.Manager.CheckRequirement, AddressOf CheckRequirement
        System.Threading.Tasks.Task.Run(Sub()
                                            If InvokeRequired Then
                                                BeginInvoke(Sub()
                                                                ServerName.Text = ServerBase.ServerPathName
                                                                ServerIcon.Image = ServerBase.ServerIcon
                                                                SettingButton.Enabled = False
                                                                RunButton.Enabled = False
                                                                SetVersionLabel()
                                                                ServerRunStatus.Text = "正在加載伺服器..."
                                                                If TypeOf ServerBase.GetServerProperties Is JavaServerOptions Then
                                                                    VersionTypeLabel.Text = "Java 版"
                                                                ElseIf ServerBase.GetServerProperties IsNot Nothing Then
                                                                    VersionTypeLabel.Text = "基岩版"
                                                                Else
                                                                    VersionTypeLabel.Text = ""
                                                                End If
                                                            End Sub)
                                            Else
                                                ServerName.Text = ServerBase.ServerPathName
                                                    ServerIcon.Image = ServerBase.ServerIcon
                                                    SettingButton.Enabled = False
                                                    RunButton.Enabled = False
                                                    SetVersionLabel()
                                                    ServerRunStatus.Text = "正在加載伺服器..."
                                                If TypeOf ServerBase.GetServerProperties Is JavaServerOptions Then
                                                    VersionTypeLabel.Text = "Java 版"
                                                ElseIf ServerBase.GetServerProperties IsNot Nothing Then
                                                    VersionTypeLabel.Text = "基岩版"
                                                Else
                                                    VersionTypeLabel.Text = ""
                                                End If
                                            End If
                                        End Sub)
    End Sub
    Private Sub UpdateComponentOnFirstRun()
        BeginInvokeIfRequired(Me, Sub()
                                      SettingButton.Enabled = True
                                      RunButton.Enabled = True
                                      UpdateComponent()
                                      RaiseEvent ServerLoaded()
                                      RemoveHandler _Server.Initallised, AddressOf UpdateComponentOnFirstRun
                                  End Sub)
    End Sub
    Protected Overridable Sub UpdateComponent()
        BeginInvokeIfRequired(Me, New Action(Sub()

                                                 ServerIcon.Image = ServerBase.ServerIcon

                                                 ServerName.Text = ServerBase.ServerPathName
                                                 If ServerBase.IsRunning Then
                                                     ServerRunStatus.Text = "啟動狀態：已啟動"
                                                     SettingButton.Enabled = False
                                                     RunButton.Image = My.Resources.Stop32
                                                     ToolTip1.SetToolTip(RunButton, "停止伺服器")
                                                 ElseIf isnothing(console) = False AndAlso console.isDisposed = False Then
                                                     ServerRunStatus.Text = "啟動狀態：未啟動(主控台運作中)"
                                                     SettingButton.Enabled = True
                                                     ToolTip1.SetToolTip(RunButton, "重新啟動伺服器")
                                                     RunButton.Image = My.Resources.Run32
                                                 Else
                                                     ServerRunStatus.Text = "啟動狀態：未啟動"
                                                     SettingButton.Enabled = True
                                                     ToolTip1.SetToolTip(RunButton, "啟動伺服器")
                                                     RunButton.Image = My.Resources.Run32
                                                 End If
                                                 CheckRequirement()
                                                 SetVersionLabel()
                                                 If TypeOf ServerBase.GetServerProperties Is JavaServerOptions Then
                                                     VersionTypeLabel.Text = "Java 版"
                                                 ElseIf ServerBase.GetServerProperties IsNot Nothing Then
                                                     VersionTypeLabel.Text = "基岩版"
                                                 End If
                                                 If GlobalModule.Manager.CanUPnP Then
                                                     Try
                                                         If GlobalModule.Manager.ip.Contains(ServerBase.GetServerProperties.GetValue("server-ip")) OrElse ServerBase.GetServerProperties.GetValue("server-ip") = "" Then
                                                             UPnPStatusLabel.Text = "支援 UPnP"
                                                         Else
                                                             UPnPStatusLabel.Text = ""
                                                         End If
                                                     Catch ex As Exception
                                                     End Try
                                                 End If

                                                 Update()
                                             End Sub))
    End Sub
    Friend Overloads Sub SetVersionLabel(Optional updating As Boolean = False, Optional updatingPercent As Integer = 0)
        ServerVersion.Text = ServerBase.GetSoftwareVersionString
        If updating Then
            ServerVersion.Text &= " [更新進度：" & updatingPercent & " %]"
        End If
    End Sub
    Friend Overloads Sub SetVersionLabel(addtionText As String)
        ServerVersion.Text = ServerBase.GetSoftwareVersionString
        If addtionText <> "" Then
            ServerVersion.Text &= " " & addtionText
        End If
    End Sub
    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        If IO.Directory.Exists(ServerBase.ServerPath) = False Then
            MsgBox("伺服器資料夾消失了...",, Application.ProductName)
        Else
            If IsNothing(setter) Then
                setter = New ServerSetter(ServerBase)
            Else
                If setter.IsDisposed Then
                    setter = New ServerSetter(ServerBase)
                End If
            End If
            setter.Show()
        End If
    End Sub
    Protected isOverrides As Boolean
    Protected Overridable Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        If isOverrides = False Then
            If IO.Directory.Exists(ServerBase.ServerPath) = False Then
                MsgBox("伺服器資料夾消失了...",, Application.ProductName)
            Else
                Dim filename As String = ServerBase.GetServerFileName
                If String.IsNullOrEmpty(filename) = False AndAlso
                    String.IsNullOrWhiteSpace(filename) = False AndAlso
                    IO.File.Exists(filename) = False Then
                    Select Case MsgBox("找不到伺服器軟體，是否重新下載？", MsgBoxStyle.YesNo, Application.ProductName)
                        Case MsgBoxResult.Yes
                            ServerBase.DownloadAndInstallServer(ServerBase.ServerVersion)
                        Case MsgBoxResult.No
                            Exit Sub
                    End Select
                End If
                If ServerBase.BeforeRunServer = False Then Exit Sub
                Select Case ServerBase.IsRunning
                    Case True
                        If ServerBase.ProcessID <> 0 Then
                            Try
                                Dim process As Process = Process.GetProcessById(ServerBase.ProcessID)
                                Dim thread As New Threading.Thread(Sub()
                                                                       If process IsNot Nothing Then
                                                                           If process.HasExited = False Then
                                                                               Try
                                                                                   If console IsNot Nothing AndAlso console.IsDisposed = False Then
                                                                                       console.InputToConsole("stop")
                                                                                   Else
                                                                                       process.StandardInput.WriteLine("stop")
                                                                                   End If
                                                                                   Dim dog As New Watchdog(process)
                                                                                   dog.Run()
                                                                               Catch ex As Exception
                                                                               End Try
                                                                               process.WaitForExit()
                                                                               ServerBase.ProcessID = 0
                                                                           End If
                                                                           ServerBase.IsRunning = False
                                                                       End If
                                                                   End Sub)
                                thread.IsBackground = True
                                thread.Start()
                            Catch ex As Exception
                                ServerBase.IsRunning = False
                            End Try
                        End If
                    Case False
                        If IsNothing(console) = False AndAlso console.IsDisposed = False Then
                            console.Run()
                        Else
                            If IsNothing(setter) = False AndAlso setter.IsDisposed = False Then
                                MsgBox("請先關閉伺服器設定視窗!",, Application.ProductName)
                            Else
                                If IsNothing(console) Then
                                    console = New ServerConsole(ServerBase)
                                    AddHandler console.FormClosed, Sub() Call UpdateComponent()
                                Else
                                    If console.IsDisposed Then
                                        console = New ServerConsole(ServerBase)
                                        AddHandler console.FormClosed, Sub() Call UpdateComponent()
                                    End If
                                End If
                                If console.Visible = False Then
                                    FindForm.Invoke(Sub() console.Show())
                                End If
                            End If
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        CloseServer()
        RaiseEvent DeleteServer(False)
    End Sub
    Sub CloseServer()
        GlobalModule.Manager.ServerEntityList.Remove(ServerBase)
        If IsNothing(console) Then
        Else
            If console.IsDisposed Then
            Else
                console.Close()
            End If
        End If
        If IsNothing(setter) Then
        Else
            If setter.IsDisposed Then
            Else
                setter.Close()
            End If
        End If
        Try
            ServerBase.SaveServer()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ShowDirButton_Click(sender As Object, e As EventArgs) Handles ShowDirButton.Click
        If IO.Directory.Exists(ServerBase.ServerPath) = False Then
            MsgBox("伺服器資料夾消失了...",, Application.ProductName)
        Else
            Process.Start(ServerBase.ServerPath)
        End If
    End Sub

    Friend Overridable Sub CheckRequirement()
        If isOverrides = False Then
            BeginInvokeIfRequired(Me, Sub()
                                          RunButton.Enabled = ServerBase.BeforeRunServer
                                      End Sub)
        End If
    End Sub

    Private Sub ServerStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckRequirement()
    End Sub
End Class
