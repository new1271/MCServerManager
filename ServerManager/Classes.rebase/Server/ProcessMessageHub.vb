﻿Imports System.Threading

Public Class ProcessMessageHub
    Dim formatedMessages As New List(Of MinecraftProcessMessage)()
    Dim originalMessages As String ' 視情況，可能會變超大
    Dim threadHub As New Dictionary(Of Integer, Thread) '處理序列，儲存未完成的序列，並指示其依照指定的順序輸出格式化後的訊息至列表
    Dim currentProcessedID As ULong = 0 'ID 計數器
    ''' <summary>
    ''' 加入一封訊息至非同步訊息處理序列
    ''' </summary>
    ''' <param name="processLog"></param>
    Sub AddMessage(processLog As String)

    End Sub
End Class
Class MinecraftProcessMessage
    Enum ProcessMessageType
        Info
        Warning
        [Error]
        Notify
        Debug
        Trace
    End Enum
    Enum EventMessageType
        None
        PlayerLogin
        PlayerLogout
        PlayerConnected
        PlayerLostConnected
        PlayerInputCommand
    End Enum
    Public Property MessageType As ProcessMessageType
    Public Property BungeeCordMessageType As String
    Public Property MessageTypeForEvents As EventMessageType
    Public Property AddtionalMessage As New Dictionary(Of String, String)()
    Public Property Time As Date
    Public Property Message As String
    Public Property Thread As String
    Public Function ServerMessageTypeString() As String
        Select Case MessageType
            Case ProcessMessageType.Info
                Return "訊息"
            Case ProcessMessageType.Warning
                Return "警告"
            Case ProcessMessageType.Error
                Return "錯誤"
            Case ProcessMessageType.Notify
                Return "通知"
            Case ProcessMessageType.Debug
                Return "偵錯"
            Case ProcessMessageType.Trace
                Return "程式碼追朔"
        End Select
    End Function
End Class

