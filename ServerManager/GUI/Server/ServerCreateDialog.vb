﻿Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ServerCreateDialog
    Dim mapChooser As CreateMap
    Friend server As Server = Server.CreateServer
    Friend serverOptions As IServerOptions
    Dim ipType As ServerIPType = ServerIPType.Default

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        IPBox.Text = ""
        IPBox.ReadOnly = True
        ipType = ServerIPType.Float
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        IPBox.Text = GlobalModule.Manager.ip(0)
        IPBox.ReadOnly = True
        ipType = ServerIPType.Default
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        IPBox.ReadOnly = False
        ipType = ServerIPType.Custom
    End Sub


    Private Sub Version_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VersionBox.SelectedIndexChanged, VersionTypeBox.SelectedIndexChanged
        MapPanel.Enabled = (VersionBox.SelectedIndex <> -1 And VersionTypeBox.SelectedIndex <> -1 And ServerDirBox.Text.Trim <> "")
        If sender Is VersionBox Then
            Select Case server.ServerVersionType
                Case Server.EServerVersionType.Forge
                    server.SetVersion(VersionBox.Text, ForgeVersionDict(New Version(VersionBox.Text)).ToString)
                Case Server.EServerVersionType.SpongeVanilla
                    Dim v = SpongeVanillaVersionList(VersionBox.Text)
                    server.SetVersion(VersionBox.Text, v.SpongeVersion.Major & "." & v.SpongeVersion.Minor & "." & v.SpongeVersion.Build, v.Build, v.SpongeVersionType)
                Case Server.EServerVersionType.Paper
                    server.SetVersion(VersionBox.Text)
                Case Server.EServerVersionType.Akarin
                    If VersionBox.Text = "最新建置版本" Then
                        server.SetVersion("master")
                    Else
                        Dim splitedStrings = VersionBox.Text.Split(".")
                        If splitedStrings.Last() = "x" Then
                            server.SetVersion(String.Format("{0}.{1}", splitedStrings(0), splitedStrings(1)))
                        Else
                            server.SetVersion(String.Format("{0}.{1}.{2}", splitedStrings(0), splitedStrings(1), splitedStrings(2)))
                        End If
                    End If
                Case Server.EServerVersionType.Nukkit
                    server.SetVersion("1.0", NukkitVersion)
                Case Server.EServerVersionType.VanillaBedrock
                    server.SetVersion(VanillaBedrockVersion.ToString)
                Case Server.EServerVersionType.Vanilla
                    Dim preReleaseRegex1 As New Regex("[0-9A-Za-z]{1,2}.[0-9A-Za-z]{1,2}[.]*[0-9]*-[Pp]{1}re[0-9]{1,2}")
                    Dim preReleaseRegex2 As New Regex("[0-9A-Za-z]{1,2}.[0-9A-Za-z]{1,2}[.]*[0-9]* [Pp]{1}re-[Rr]{1}elease [0-9]{1,2}")
                    Dim snapshotRegex As New Regex("[0-9]{2}w[0-9]{2}[a-z]{1}")
                    If Version.TryParse(VersionBox.Text, Nothing) Then
                        server.SetVersion(VersionBox.Text)
                    ElseIf preReleaseRegex1.IsMatch(VersionBox.Text) Then
                        If preReleaseRegex1.Match(VersionBox.Text).Value.Contains("1.RV") Then
                            server.SetVersion("1.9.9999", preReleaseRegex1.Match(VersionBox.Text).Value)
                        Else
                            server.SetVersion(New Regex("[0-9]{1,2}.[0-9]{1,2}[.]*[0-9]*").Match(VersionBox.Text).Value, preReleaseRegex1.Match(VersionBox.Text).Value)
                        End If
                    ElseIf preReleaseRegex2.IsMatch(VersionBox.Text) Then
                        If preReleaseRegex2.Match(VersionBox.Text).Value.Contains("1.RV") Then
                            server.SetVersion("1.9.9999", preReleaseRegex2.Match(VersionBox.Text).Value)
                        Else
                            server.SetVersion(New Regex("[0-9]{1,2}.[0-9]{1,2}[.]*[0-9]*").Match(VersionBox.Text).Value, preReleaseRegex2.Match(VersionBox.Text).Value)
                        End If
                    ElseIf snapshotRegex.IsMatch(VersionBox.Text) Then
                        server.SetVersion("snapshot", snapshotRegex.Match(VersionBox.Text).Value)
                    Else
                        If VersionBox.Text <> "" Then
                            MsgBox("非法版本!",, Application.ProductName)
                            VersionBox.SelectedIndex = -1
                        End If

                    End If
                Case Else
                    server.SetVersion(VersionBox.Text)
            End Select
        End If
        Static _typeSelectedIndex As Integer = -1
        If sender Is VersionTypeBox Then
            VersionBox.Items.Clear()
            VersionBox.Enabled = True
            Select Case VersionTypeBox.SelectedIndex
                Case 0
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Vanilla)
                    For Each item In VanillaVersionDict.Keys
                        Dim preReleaseRegex1 As New Regex("[0-9A-Za-z]{1,2}.[0-9A-Za-z]{1,2}[.]*[0-9]*-[Pp]{1}re[0-9]{1,2}")
                        Dim preReleaseRegex2 As New Regex("[0-9A-Za-z]{1,2}.[0-9A-Za-z]{1,2}[.]*[0-9]* [Pp]{1}re-[Rr]{1}elease [0-9]{1,2}")
                        Dim snapshotRegex As New Regex("[0-9]{2}w[0-9]{2}[a-z]{1}")
                        If preReleaseRegex1.IsMatch(item) OrElse
                                preReleaseRegex2.IsMatch(item) OrElse
                            snapshotRegex.IsMatch(item) Then
                            If My.Settings.ShowSnapshot Then VersionBox.Items.Add(item)
                        Else
                            VersionBox.Items.Add(item)
                        End If
                    Next
                Case 1
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Forge)
                    Dim keys = ForgeVersionDict.Keys.ToList
                    keys.Sort()
                    keys.Reverse()
                    For Each version In keys
                        VersionBox.Items.Add(version.ToString)
                    Next
                Case 2
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Spigot)
                    VersionBox.Items.AddRange(SpigotVersionDict.Keys.ToArray)
                Case 3
                    If IsUnixLikeSystem Then
                        server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Spigot_Git)
                        VersionBox.Items.AddRange(SpigotGitVersionList.ToArray)
                    Else
                        If String.IsNullOrEmpty(GitBashPath) AndAlso IO.File.Exists(GitBashPath) Then
                            server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Spigot_Git)
                            VersionBox.Items.AddRange(SpigotGitVersionList.ToArray)
                        Else
                            MsgBox("尚未指定Git Bash的位址!", MsgBoxStyle.OkOnly, Application.ProductName)
                            VersionTypeBox.SelectedIndex = _typeSelectedIndex
                            Exit Sub
                        End If
                    End If
                Case 4
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.CraftBukkit)
                    VersionBox.Items.AddRange(CraftBukkitVersionDict.Keys.ToArray)
                Case 5
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Paper)
                    Dim keys = PaperVersionDict.Keys.ToList
                    keys.Sort()
                    keys.Reverse()
                    For Each version In keys
                        VersionBox.Items.Add(version.ToString)
                    Next
                Case 6
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Akarin)
                    For Each item In AkarinVersionList
                        Dim buildVer As String = item.Build.ToString
                        If buildVer = "-1" Then
                            buildVer = "x"
                        End If
                        If item.Major = 100 And item.Minor = 100 Then
                            VersionBox.Items.Add("最新建置版本")
                        Else
                            VersionBox.Items.Add(String.Format("{0}.{1}.{2}", item.Major, item.Minor, buildVer))
                        End If
                    Next
                Case 7
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.SpongeVanilla)
                    Dim l = SpongeVanillaVersionList.Keys.ToList
                    l.Reverse()
                    VersionBox.Items.AddRange(l.ToArray)
                Case 8
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Cauldron)
                    VersionBox.Items.AddRange({"1.7.10", "1.7.2", "1.6.4", "1.5.2"})
                Case 9
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Thermos)
                    VersionBox.Items.Add("1.7.10")
                    VersionBox.SelectedIndex = 0
                    VersionBox.Enabled = False
                Case 10
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Contigo)
                    VersionBox.Items.Add("1.7.10")
                    VersionBox.SelectedIndex = 0
                    VersionBox.Enabled = False
                Case 11
                    server.SetVersionType(Server.EServerType.Java, Server.EServerVersionType.Kettle)
                    VersionBox.Items.AddRange(KettleVersionDict.Keys.ToArray)
                Case 12
                    If Environment.OSVersion.Version.Major < 10 OrElse IsUnixLikeSystem Then
                        server.SetVersionType(Server.EServerType.Bedrock, Server.EServerVersionType.Nukkit)
                        VersionBox.Items.Add(String.Format("最新版 ({0})", NukkitVersion))
                    Else
                        server.SetVersionType(Server.EServerType.Bedrock, Server.EServerVersionType.VanillaBedrock)
                        VersionBox.Items.Add(String.Format("最新版 ({0})", VanillaBedrockVersion.ToString))
                    End If
                Case 13
                    server.SetVersionType(Server.EServerType.Bedrock, Server.EServerVersionType.Nukkit)
                    VersionBox.Items.Add(String.Format("最新版 ({0})", NukkitVersion))
                Case 14
                    server.SetVersionType(Server.EServerType.Custom, Server.EServerVersionType.Custom)
                    VersionBox.Items.Add("(無)")
                    VersionBox.SelectedIndex = 0
                    VersionBox.Enabled = False
                Case Else
                    MsgBox("非法操作!")
                    server.SetVersionType(Server.EServerType.Error, Server.EServerVersionType.Error)
                    VersionTypeBox.SelectedIndex = _typeSelectedIndex
                    Exit Sub
            End Select
            _typeSelectedIndex = VersionTypeBox.SelectedIndex
        End If

    End Sub

    Private Sub ServerDirBox_TextChanged(sender As Object, e As EventArgs) Handles ServerDirBox.TextChanged
        MapPanel.Enabled = (VersionBox.SelectedIndex <> -1 And VersionTypeBox.SelectedIndex <> -1 And ServerDirBox.Text.Trim <> "")
    End Sub
    Structure a
        Public Group As String
        Public Value As Integer
        Public Display As String
    End Structure
    Private Sub ServerCreateDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim groupedItems = {New a With {.Group = "Java 版",
    .Value = 0,
    .Display = "原版"
}, New a With {
    .Group = "Java 版",
    .Value = 1,
    .Display = "Forge"
}, New a With {
    .Group = "Java 版",
    .Value = 2,
    .Display = "Spigot"
}, New a With {
    .Group = "Java 版",
    .Value = 3,
    .Display = "Spigot (手動建置)"
}, New a With {
    .Group = "Java 版",
    .Value = 4,
    .Display = "CraftBukkit"
}, New a With {
    .Group = "Java 版",
    .Value = 5,
    .Display = "Paper"
}, New a With {
    .Group = "Java 版",
    .Value = 6,
    .Display = "Akarin"
}, New a With {
    .Group = "Java 版",
    .Value = 7,
    .Display = "SpongeVanilla"
}, New a With {
    .Group = "Java 版",
    .Value = 8,
    .Display = "MCPC/Cauldron"
}, New a With {
    .Group = "Java 版",
    .Value = 9,
    .Display = "Thermos"
}, New a With {
    .Group = "Java 版",
    .Value = 10,
    .Display = "Contigo"
}, New a With {
    .Group = "Java 版",
    .Value = 11,
    .Display = "Kettle"
}, New a With {
    .Group = "基岩版",
    .Value = 12,
    .Display = "原版"
}, New a With {
    .Group = "基岩版",
    .Value = 13,
    .Display = "Nukkit"
}}
        GroupedComboBox1.GroupMember = "Group"
        GroupedComboBox1.ValueMember = "Value"
        GroupedComboBox1.DisplayMember = "Display"
        GroupedComboBox1.SortComparer = New Comparer(Of a)(groupedItems.ToList)
        GroupedComboBox1.DataSource = groupedItems
        MapPanel.Enabled = (VersionBox.SelectedIndex <> -1 And VersionTypeBox.SelectedIndex <> -1 And ServerDirBox.Text.Trim <> "")
        MapPanel.Controls.Add(New MapView(server) With {.Dock = DockStyle.Fill})
        If IsUnixLikeSystem Then
            VersionTypeBox.Items.RemoveAt(12)
        Else
            If Environment.OSVersion.Version.Major < 10 Then VersionTypeBox.Items.RemoveAt(12)
        End If
    End Sub
    Class Comparer
        Implements IComparer
        Dim s As List(Of a)
        Sub New(source As List(Of a))
            s = source
        End Sub
        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Return s.IndexOf(x) < s.IndexOf(y)
        End Function
    End Class
    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If ServerDirBox.Text.Trim <> "" Then
            If (ipType <> ServerIPType.Custom) OrElse
            (ipType = ServerIPType.Custom AndAlso
            (IPBox.Text.Trim <> "" AndAlso IsNumeric(IPBox.Text.Replace(".", "")))) Then
                If VersionTypeBox.SelectedIndex <> -1 And VersionBox.SelectedIndex <> -1 Then
                    Dim mapView As MapView = MapPanel.Controls(0)
                    If mapView.MapNameLabel.Text <> "" Then
                        server.SetPath(ServerDirBox.Text)
                        If serverOptions Is Nothing Then
                            Select Case server.ServerType
                                Case Server.EServerType.Java
                                    serverOptions = New JavaServerOptions
                                    serverOptions.InputOption(server.ServerOptions)
                                Case Server.EServerType.Bedrock
                                    serverOptions = New NukkitServerOptions
                                    serverOptions.InputOption(server.ServerOptions)
                                Case Server.EServerType.Custom
                                    serverOptions = New JavaServerOptions
                                    serverOptions.InputOption(server.ServerOptions)
                            End Select
                        End If
                        server.ServerOptions = serverOptions.OutputOption
                        Select Case ipType
                            Case ServerIPType.Float
                                Select Case server.ServerType
                                    Case Server.EServerType.Java
                                        server.ServerOptions("server-ip") = ""
                                    Case Server.EServerType.Bedrock
                                        server.ServerOptions("server-ip") = "0.0.0.0"
                                End Select
                            Case ServerIPType.Default
                                server.ServerOptions("server-ip") = GlobalModule.Manager.ip(0)
                            Case ServerIPType.Custom
                                server.ServerOptions("server-ip") = IPBox.Text
                        End Select
                        If server.ServerVersionType = Server.EServerVersionType.Forge AndAlso My.Settings.CustomForgeVersion Then
                            Dim chooser As New ForgeBranchChooser(server, ServerDirBox.Text)
                            chooser.Show()
                            Close()
                        ElseIf server.ServerVersionType = Server.EServerVersionType.Custom Then
                            Dim dialog As New OpenFileDialog()
                            dialog.Title = "選擇伺服器軟體"
                            dialog.Filter = "Java 程式(*.jar)|*.jar"
                            If dialog.ShowDialog = DialogResult.OK AndAlso IO.File.Exists(dialog.FileName) Then
                                server.CustomServerRunFile = dialog.FileName
                                server.SaveServer()
                                BeginInvokeIfRequired(GlobalModule.Manager, Sub() GlobalModule.Manager.AddServer(server.ServerPath))
                                Close()
                            End If
                        Else
                            Dim helper As New ServerCreateHelper(server, ServerDirBox.Text)
                            helper.Show()
                            Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PortBox_ValueChanged(sender As Object, e As EventArgs) Handles PortBox.ValueChanged
        Try
            serverOptions.SetValue("server-port", PortBox.Value)
        Catch ex As NullReferenceException
            If server.ServerOptions.ContainsKey("server-port") Then
                server.ServerOptions("server-port") = PortBox.Value
            Else
                server.ServerOptions.Add("server-port", PortBox.Value)
            End If
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        On Error Resume Next
        Select Case TabControl1.SelectedIndex
            Case 0
                server.ServerOptions = serverOptions.OutputOption
                AdvancedPropertyGrid.SelectedObject = Nothing
            Case 1
                Select Case server.ServerType
                    Case Server.EServerType.Java
                        serverOptions = New JavaServerOptions
                        serverOptions.InputOption(server.ServerOptions)
                        AdvancedPropertyGrid.SelectedObject = serverOptions
                    Case Server.EServerType.Bedrock
                        serverOptions = New NukkitServerOptions
                        serverOptions.InputOption(server.ServerOptions)
                        AdvancedPropertyGrid.SelectedObject = serverOptions
                End Select
        End Select
    End Sub

    Private Sub ServerDirBrowseBtn_Click(sender As Object, e As EventArgs) Handles ServerDirBrowseBtn.Click
        Static dir As New FolderBrowserDialog
        dir = New FolderBrowserDialog
        dir.ShowNewFolderButton = True
        dir.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        dir.Description = "選擇建立伺服器的資料夾位置"
        If dir.ShowDialog = DialogResult.OK Then
            ServerDirBox.Text = dir.SelectedPath
        End If
    End Sub


    Private Sub 將連接埠設成預設值ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 將連接埠設成預設值ToolStripMenuItem.Click
        Select Case VersionTypeBox.SelectedIndex
            Case 0 To 9
                PortBox.Value = 25565
            Case 10 To 11
                PortBox.Value = 19132
        End Select
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
Enum ServerIPType
    Float
    [Default]
    Custom
End Enum
