﻿Imports System.Threading

Public Class ModPackServer
    Enum ModPackType
        [Error]
        FeedTheBeast
    End Enum
    Public Event Initallised()
    Public Event ServerInfoUpdated()
    Public Event ServerIconUpdated()
    Public ReadOnly Property IsInitallised As Boolean = False
    Public ReadOnly Property PackName As String
    Public ReadOnly Property PackVersion As String
    Public ReadOnly Property PackType As ModPackType
    Public ReadOnly Property ServerPath As String
    Public ReadOnly Property ServerPathName As String
    Public Property ServerOptions As New Dictionary(Of String, String)
    Public ReadOnly Property ServerIcon As Image = New Bitmap(64, 64)
    Sub SetPackInfo(name As String, Version As String, Type As ModPackType)
        _PackName = name
        _PackVersion = Version
        _PackType = Type
    End Sub
    Sub SetPath(dir As String)
        _ServerPath = dir
    End Sub
    Private Sub New()
    End Sub
    Private Sub New(serverPath As String)
        _ServerPath = serverPath
    End Sub
    Shared Function CreateServer() As ModPackServer
        Return New ModPackServer
    End Function
    Shared Function GetServer(path As String) As ModPackServer
        If path <> "" Then
            Dim server As New ModPackServer(path)
            server._ServerPath = path
            If My.Computer.FileSystem.FileExists(IO.Path.Combine(path, "server.info")) Then
                Using reader As New IO.StreamReader(New IO.FileStream(IO.Path.Combine(path, "server.info"), IO.FileMode.Open, IO.FileAccess.Read), System.Text.Encoding.UTF8)
                    Do Until reader.EndOfStream
                        Dim infoText As String = reader.ReadLine
                        Dim info = infoText.Split("=", 2, StringSplitOptions.None)
                        If info.Length >= 2 Then
                            Select Case info(0)
                                Case "pack-version"
                                    server._PackVersion = info(1)
                                Case "pack-type"
                                    Select Case info(1).ToLower
                                        Case "feedthebeast"
                                            server._PackType = ModPackType.FeedTheBeast
                                        Case Else
                                            server._PackType = ModPackType.Error
                                    End Select
                                Case "pack-name"
                                    server._PackName = info(1)
                            End Select
                        End If
                    Loop
                End Using
            End If
            If My.Computer.FileSystem.FileExists(IO.Path.Combine(path, "server-icon.png")) Then
                server._ServerIcon = Image.FromFile(IO.Path.Combine(path, "server-icon.png"))
            Else
                server._ServerIcon = My.Resources.ServerDefaultIcon
            End If
            server._ServerPathName = New IO.DirectoryInfo(path).Name
            Return server
        Else
            Return Nothing
        End If
    End Function
    Friend Sub Initallise()
        Dim mainThread As New Thread(Sub()
                                         Try
                                             Dim serverOptions As New Dictionary(Of String, String)
                                             If My.Computer.FileSystem.FileExists(IO.Path.Combine(ServerPath, "server.properties")) Then
                                                 Using reader As New IO.StreamReader(New IO.FileStream(IO.Path.Combine(ServerPath, "server.properties"), IO.FileMode.Open, IO.FileAccess.Read), System.Text.Encoding.UTF8)
                                                     Dim optionDict As New Dictionary(Of Integer, Boolean)
                                                     Do Until reader.EndOfStream
                                                         Try
                                                             Dim optionText As String = reader.ReadLine
                                                             If optionText.StartsWith("#") = False Then
                                                                 Dim options = optionText.Split("=", 2, StringSplitOptions.None)
                                                                 If options.Count = 2 Then
                                                                     serverOptions.Add(options(0), options(1))
                                                                 ElseIf options.Count = 1 Then
                                                                     If options(0).Trim(" ") <> "" Then serverOptions.Add(options(0), "")
                                                                 ElseIf options.Count = 0 Then
                                                                 Else
                                                                 End If
                                                             End If
                                                         Catch ex As Exception
                                                             Continue Do
                                                         End Try
                                                     Loop
                                                 End Using
                                             End If
                                             _ServerOptions = serverOptions
                                         Catch fileException As IO.FileNotFoundException
                                         End Try
                                         _IsInitallised = True
                                         RaiseEvent Initallised()
                                     End Sub)
        mainThread.IsBackground = True
        mainThread.Start()
    End Sub

End Class