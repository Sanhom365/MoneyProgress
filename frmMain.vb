Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class frmMain
    Dim x As Integer = My.Settings.x
    Dim moveForm As Boolean = False ' 鼠标移动时是否移动窗口
    Dim startX As Single

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="SetWindowRgn")>
    Private Shared Function SetWindowRgn(ByVal hWnd As IntPtr, ByVal hRgn As IntPtr, ByVal bRedraw As Boolean) As Integer
    End Function

    Public Sub changeText()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf changeText))
        Else
            Dim nowtime As Date = Now
            Dim percent As Double = 0
            Select Case nowtime
                Case < begin
                    percent = 0
                Case > finish
                    percent = 1
                Case Else
                    percent = (nowtime - begin).Ticks / WorkingTimes.Ticks
                    If frmSetting.chkNoonBreak.Checked Then
                        If nowtime > noonbegin AndAlso nowtime < noonfinish Then
                            percent = (noonbegin - begin).Ticks / WorkingTimes.Ticks
                        ElseIf nowtime > noonfinish Then
                            percent = ((noonbegin - begin).Ticks + (nowtime - noonfinish).Ticks) / WorkingTimes.Ticks
                        End If
                    End If
            End Select
            ProgressBar1.Value = percent * 100
            lblPercent.Text = ProgressBar1.Value.ToString & "%"
            Select Case percent
                Case 0
                    NotifyIconMain.Text = "今日上班时间未到，请先准备准备。"
                    lblContent.Text = "今日预计赚取 "
                Case 1
                    NotifyIconMain.Text = "今日已下班，可以愉快地回家啦！"
                    lblContent.Text = "今日已赚取 "
                Case Else
                    NotifyIconMain.Text = String.Format("今日已赚取 {0} 元", percent * My.Settings.Salary / My.Settings.WorkingDays)
                    lblContent.Text = "今日预计赚取 "
            End Select
            lblContent.Text = lblContent.Text & My.Settings.Salary / My.Settings.WorkingDays & " 元，" & NotifyIconMain.Text.Replace("今日", "")
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.Icon = My.Resources.Money
        NotifyIconMain.Icon = Me.Icon
        Dim radius As Integer = 13 '设置圆角半径
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius)
        SetWindowRgn(Me.Handle, regionHandle, True)
        changeText()
        Timer1.Interval = My.Settings.Refresh * 1000
        Timer1.Start()
        Me.Location = New Point(x, -97)
        frmSetting.Show()
        frmSetting.Hide()
        Me.Hide()
    End Sub

    ' 在 Form 的 Paint 事件处理程序中添加以下代码
    Private Sub frmSetting_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' 创建一个 GraphicsPath 对象来定义 ProgressBar 的圆角矩形
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, ProgressBar1.Width, ProgressBar1.Height)
        Dim radius As Integer = 20
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' 设置 ProgressBar 的 Region 属性
        ProgressBar1.Region = New Region(path)
    End Sub

    Private Sub NotifyIconMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIconMain.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If Me.Visible Then
                Me.Hide()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub NotifyIconMain_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIconMain.MouseClick
        If e.Button = MouseButtons.Right Then
            cmsNotify.Show(Cursor.Position)
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        NotifyIconMain.Visible = False
        NotifyIconMain.Dispose()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Me.Visible Then
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If Not frmSetting.Visible Then
            frmSetting.Show()
        End If
    End Sub

    Private Sub frmMain_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.Top = -5
    End Sub

    Private Sub frmMain_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        For i As Byte = 0 To 9
            Threading.Thread.Sleep(200)
            Application.DoEvents()
        Next
        Me.Top = -96
    End Sub

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblToday.MouseDown, lblPercent.MouseDown, lblLoaf.MouseDown, lblContent.MouseDown
        moveForm = True
        Me.Cursor = Cursors.SizeAll
        startX = e.X
    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, lblToday.MouseDown, lblPercent.MouseDown, lblLoaf.MouseDown, lblContent.MouseDown
        moveForm = False
        Me.Cursor = Cursors.Arrow
        x = Me.Left
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, lblToday.MouseDown, lblPercent.MouseDown, lblLoaf.MouseDown, lblContent.MouseDown
        If moveForm Then
            Dim moveX As Integer
            moveX = e.X - startX
            Me.Left += moveX
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        changeText()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        My.Settings.x = x
        My.Settings.Save()
        NotifyIconMain.Visible = False
        NotifyIconMain.Dispose()
        Me.Close()
        Application.Exit()
    End Sub

End Class
