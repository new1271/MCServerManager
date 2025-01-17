﻿Imports System.ComponentModel
Imports System.Threading

Public Class ForgeModExplorer
    Dim engine As CharcoalEngine
    Dim spongeThread As Thread
    Friend _server As Server
    Friend index As Integer
    Friend isStart As Boolean = True
    Friend isError As Boolean = False


    Sub New(index As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.index = index
        Me._server = GlobalModule.Manager.ServerEntityList(index)
        engine = New CharcoalEngine(index)
    End Sub

    Private Sub BukkitForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreatedForm.Add(Me)
        ShowInTaskbar = MiniState = 0

        AddHandler engine.DownloadProgressChanged, Sub(obj, args)
                                                       ToolStripProgressBar1.Value = args.ProgressPercentage
                                                   End Sub
        GoHome()
    End Sub
    Sub GoHome()

    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        isStart = False
        isError = False
        Try
            engine.LoadPage("https://www.curseforge.com/minecraft/mc-mods", CharcoalEngine.RenderPageType.CurseForge_ModListPage, CharcoalEnginePanel)
        Catch ex As Exception
            isError = True
            CharcoalEnginePanel.Refresh()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        isStart = False
        If spongeThread IsNot Nothing AndAlso spongeThread.IsAlive Then
            spongeThread.Abort()
        End If
        spongeThread = New Thread(Sub()
                                      BeginInvoke(Sub() CharcoalEnginePanel.Controls.Clear())
                                      Dim sponge As New SpongeForgeProvider
                                      sponge.Initallise()
                                      Dim versions = sponge.GetSpongeForgeVersionsOnBranch(_server.ServerVersion, _server.Server2ndVersion.Split(".").Last)
                                      Dim versionListBox As New ListView With {.View = View.List, .Dock = DockStyle.Fill}
                                      BeginInvoke(Sub() CharcoalEnginePanel.Controls.Add(versionListBox))
                                      For Each version In versions
                                          Dim spongeVer As Version = version.SpongeVersion
                                          BeginInvoke(Sub() versionListBox.Items.Add(spongeVer.Major & "." & spongeVer.Minor & "." & spongeVer.Build & " " & version.SpongeVersionType.ToString.ToUpper & " " & version.Build))
                                      Next
                                      AddHandler versionListBox.ItemActivate, Sub()
                                                                                  Dim filename As String
                                                                                  If IsUnixLikeSystem Then
                                                                                      filename = IO.Path.Combine(_server.ServerPath, "mods/spongeforge-" & versions(versionListBox.SelectedIndices(0)).OriginalString & ".jar")
                                                                                  Else
                                                                                      filename = IO.Path.Combine(_server.ServerPath, "mods\spongeforge-" & versions(versionListBox.SelectedIndices(0)).OriginalString & ".jar")
                                                                                  End If
                                                                                  My.Computer.Network.DownloadFile(versions(versionListBox.SelectedIndices(0)).GetDownloadUrl, filename, "", "", True, 100, True)
                                                                                  For Each forgeMod In _server.ServerMods
                                                                                      If forgeMod.Name = "SpongeForge" Then
                                                                                          IO.File.Delete(forgeMod.Path)
                                                                                          _server.ServerMods.Remove(forgeMod)
                                                                                      End If
                                                                                  Next
                                                                                  _server.ServerMods.Add(New Server.ServerMod("SpongeForge", filename, versions(versionListBox.SelectedIndices(0)).OriginalString, Now, IO.File.GetLastWriteTime(filename)))
                                                                              End Sub
                                  End Sub)
        spongeThread.IsBackground = True
        spongeThread.Start()
    End Sub
    Private Sub CharcoalEnginePanel_Paint(sender As Object, e As PaintEventArgs) Handles CharcoalEnginePanel.Paint
        If isStart Then
            Try
                Dim g As Graphics = e.Graphics
                g.Clear(Color.LightGray)
                g.DrawString("請點選上方模組來源來瀏覽模組", New Font(SystemFonts.IconTitleFont.FontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel), New SolidBrush(Color.DimGray), New RectangleF(CharcoalEnginePanel.Location, CharcoalEnginePanel.Size), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                g.Dispose()
            Catch ex As Exception

            End Try
        ElseIf isError Then
            Try
                Dim g As Graphics = e.Graphics
                g.Clear(Color.LightGray)
                g.DrawString("加載時發生錯誤", New Font(SystemFonts.IconTitleFont.FontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel), New SolidBrush(Color.DimGray), New RectangleF(CharcoalEnginePanel.Location, CharcoalEnginePanel.Size), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                g.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CharcoalEnginePanel_Resize(sender As Object, e As EventArgs) Handles CharcoalEnginePanel.Resize
        If isStart OrElse isError Then CharcoalEnginePanel.Refresh()
    End Sub

    Private Sub ForgeModExplorer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CreatedForm.Remove(Me)

    End Sub
End Class