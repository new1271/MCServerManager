﻿Imports System.ComponentModel
Imports System.Threading.Tasks

Public Class SolutionCreateHelper
    Dim _host As BungeeCordHost
    Public Sub New(host As BungeeCordHost)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        _host = host
    End Sub

    Private Sub BungeeCordCreateHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreatedForm.Add(Me)
        ShowInTaskbar = MiniState = 0
        Task.Run(Sub()
                     If My.Computer.FileSystem.DirectoryExists(_host.BungeePath) = False Then
                         My.Computer.FileSystem.CreateDirectory(_host.BungeePath)
                     End If
                     BeginInvoke(Sub() StatusLabel.Text = "狀態：" & "正在建立設定及資訊檔案...")
                     If IsNothing(_host.BungeeOptions) Then
                         _host.BungeeOptions = BungeeCordOptions.CreateOptionsWithDefaultSetting(IO.Path.Combine(_host.BungeePath, "config.yml"))
                     End If
                     _host.SaveSolution()
                     BeginInvoke(Sub()
                                     ProgressBar.Value = 20
                                     StatusLabel.Text = "狀態：" & "下載" & _host.BungeeType.ToString & " 主程式..."
                                 End Sub)
                     Dim client = BungeeCordUpdater.DownloadUpdateAsync(_host, _host.BungeeType)
                     If client IsNot Nothing Then
                         AddHandler client.DownloadProgressChanged, Sub(obj, args)
                                                                        BeginInvoke(Sub() ProgressBar.Value = 20 + args.ProgressPercentage * 0.8)
                                                                    End Sub
                         AddHandler client.DownloadFileCompleted, Sub()
                                                                      BeginInvoke(Sub()
                                                                                      ProgressBar.Value = 100
                                                                                      StatusLabel.Text = "狀態：" & "完成!"
                                                                                      GlobalModule.Manager.AddBungeeSolution(_host.BungeePath)
                                                                                      Close()
                                                                                  End Sub)
                                                                  End Sub
                     Else
                         MsgBox("無法下載" & _host.BungeeType.ToString & "!",, Application.ProductName)
                         ProgressBar.Value = 100
                         StatusLabel.Text = "狀態：" & "失敗!"
                         Close()
                     End If
                 End Sub)
    End Sub

    Private Sub SolutionCreateHelper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CreatedForm.Remove(Me)

    End Sub
End Class