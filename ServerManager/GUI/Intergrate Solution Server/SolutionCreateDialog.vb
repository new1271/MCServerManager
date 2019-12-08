﻿Public Class SolutionCreateDialog
    Private Sub SolutionDirBrowseBtn_Click(sender As Object, e As EventArgs) Handles SolutionDirBrowseBtn.Click
        Static dir As New FolderBrowserDialog
        dir = New FolderBrowserDialog
        dir.ShowNewFolderButton = True
        dir.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        dir.Description = "選擇建立方案的資料夾位置"
        If dir.ShowDialog = DialogResult.OK Then
            SolutionDirBox.Text = dir.SelectedPath
        End If
    End Sub

    Private Sub BungeeCordCreateDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Items.Add("BungeeCord #" & BungeeCordUpdater.GetLatestVersionNumber(BungeeCordType.BungeeCord))
        ComboBox1.Items.Add("Waterfall #" & BungeeCordUpdater.GetLatestVersionNumber(BungeeCordType.Waterfall))
        ComboBox1.Items.Add("Travertine #" & BungeeCordUpdater.GetLatestVersionNumber(BungeeCordType.Travertine))
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        If SolutionDirBox.Text.Trim <> "" AndAlso ComboBox1.SelectedIndex > -1 Then
            Dim _host As BungeeCordHost = BungeeCordHost.GetEmptyBungeeCordHost(SolutionDirBox.Text)
            _host.SetVersion(BungeeCordUpdater.GetLatestVersionNumber(ComboBox1.SelectedIndex + 2), ComboBox1.SelectedIndex + 2)
            Dim u As New SolutionCreateHelper(_host)
            u.ShowDialog(Owner)
            Close()
        End If
    End Sub

    Private Sub SolutionDirBox_TextChanged(sender As Object, e As EventArgs) Handles SolutionDirBox.TextChanged

    End Sub


End Class