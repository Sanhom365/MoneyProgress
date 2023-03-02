Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class frmSetting
	Dim i As Byte
	Dim diamond(4) As Panel
	Dim moveForm As Boolean
	Dim startX, startY As Single
	Dim x, y As Integer

	<DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
	Private Shared Function CreateRoundRectRgn(ByVal x1 As Integer, ByVal y1 As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByVal cx As Integer, ByVal cy As Integer) As IntPtr
	End Function

	<DllImport("user32.dll", EntryPoint:="SetWindowRgn")>
	Private Shared Function SetWindowRgn(ByVal hWnd As IntPtr, ByVal hRgn As IntPtr, ByVal bRedraw As Boolean) As Integer
	End Function

	Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Icon = My.Resources.Money
		Dim radius As Integer = 13 '设置圆角半径
		Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius)
		SetWindowRgn(Me.Handle, regionHandle, True)
		For i = 0 To diamond.Length - 1
			diamond(i) = New Panel
			diamond(i).Visible = False
			diamond(i).Name = "pnlBlock" & i.ToString
			diamond(i).Width = 9
			diamond(i).Height = 27
			tlpProgress.Controls.Add(diamond(i), 0, 0)
		Next
		diamond(0).BackColor = Color.Red
		diamond(1).BackColor = Color.Blue
		diamond(2).BackColor = Color.Green
		diamond(3).BackColor = Color.Orange
		diamond(4).BackColor = Color.Orange
		nudWorkingDays.Maximum = Date.DaysInMonth(Now.Year, Now.Month)
		'每月第一天重新设置工作天数
		If nowDay = 1 Then
			My.Settings.WorkingDays = calculate(nudWorkingDays.Maximum)
		End If
		ReadSettings()
		Timer1.Interval = My.Settings.Refresh * 1000
		Timer1.Start()
	End Sub

	' 在 Form 的 Paint 事件处理程序中添加以下代码
	Private Sub frmSetting_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
		' 创建一个 GraphicsPath 对象来定义 TableLayoutPanel 的圆角矩形
		Dim path As New GraphicsPath()
		Dim rect As New Rectangle(0, 0, tlpProgress.Width, tlpProgress.Height)
		Dim radius As Integer = 20
		path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
		path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
		path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
		path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
		path.CloseFigure()

		' 设置 TableLayoutPanel 的 Region 属性
		tlpProgress.Region = New Region(path)
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Timer1.Stop()
		frmMain.Timer1.Stop()
		Timer1.Interval = nudRefresh.Value * 1000
		frmMain.Timer1.Interval = Timer1.Interval
		My.Settings.Begin = Text2Time(nudHour1.Value.ToString, nudMinute1.Value.ToString)
		My.Settings.Finish = Text2Time(nudHour2.Value.ToString, nudMinute2.Value.ToString)
		My.Settings.NoonBreak = chkNoonBreak.Checked
		If chkNoonBreak.Checked Then
			My.Settings.NoonBegin = Text2Time(nudHour3.Value.ToString, nudMinute3.Value.ToString)
			My.Settings.NoonFinish = Text2Time(nudHour4.Value.ToString, nudMinute4.Value.ToString)
		End If
		My.Settings.WorkingDays = nudWorkingDays.Value
		My.Settings.Salary = CInt(mskSalary.Text)
		My.Settings.Refresh = nudRefresh.Value
		WorkingHours()
		Timer1.Start()
		frmMain.Timer1.Start()
		My.Settings.Save()
		Me.Hide()
	End Sub

	Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nudHour1.ValueChanged, nudHour2.ValueChanged, nudHour3.ValueChanged, nudHour4.ValueChanged, nudMinute1.ValueChanged, nudMinute2.ValueChanged, nudMinute3.ValueChanged, nudMinute4.ValueChanged
		If nudHour1.Value > nudHour2.Value Then
			chkNoonBreak.Checked = False
			chkNoonBreak.Enabled = False
		Else
			chkNoonBreak.Enabled = True
		End If
		If chkNoonBreak.Checked Then
			nudHour3.Minimum = nudHour1.Value + 1
			nudHour3.Maximum = nudHour2.Value - 1
			nudHour4.Minimum = nudHour1.Value + 1
			nudHour4.Maximum = nudHour2.Value - 1
		End If
		If nudHour3.Value = nudHour4.Value Then
			If sender.Name = "nudHour3" Then
				sender.value -= 1
			ElseIf sender.Name = "nudHour4" Then
				sender.value += 1
			End If
		End If
		setColor()
	End Sub

	Private Sub chkNoonBreak_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoonBreak.CheckedChanged
		nudHour3.Enabled = chkNoonBreak.Checked
		nudHour4.Enabled = chkNoonBreak.Checked
		nudMinute3.Enabled = chkNoonBreak.Checked
		nudMinute4.Enabled = chkNoonBreak.Checked
		lblHour3.Enabled = chkNoonBreak.Checked
		lblHour4.Enabled = chkNoonBreak.Checked
		lblMinute3.Enabled = chkNoonBreak.Checked
		lblMinute4.Enabled = chkNoonBreak.Checked
		lblNoonBegin.Enabled = chkNoonBreak.Checked
		lblNoonFinish.Enabled = chkNoonBreak.Checked
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Hide()
	End Sub

	Private Sub frmSetting_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
		moveForm = True
		Me.Cursor = Cursors.SizeAll
		startX = e.X
		startY = e.Y
	End Sub

	Private Sub frmSetting_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
		moveForm = False
		Me.Cursor = Cursors.Arrow
		x = Me.Left
		y = Me.Top
	End Sub

	Private Sub frmSetting_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
		If moveForm Then
			Dim moveX, moveY As Integer
			moveX = e.X - startX
			moveY = e.Y - startY
			Me.Left += moveX
			Me.Top += moveY
		End If
	End Sub

	Private Sub lblPage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPage.LinkClicked
		' 打开浏览器并访问链接的 URL
		Process.Start("https://github.com/Sanhom365/MoneyProgress")
	End Sub

	Private Sub lblIssues_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblIssues.LinkClicked
		' 打开浏览器并访问链接的 URL
		Process.Start("https://github.com/Sanhom365/MoneyProgress/issues")
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		WorkingHours()
	End Sub

	Private Sub ReadSettings()
		nudWorkingDays.Value = My.Settings.WorkingDays
		nudRefresh.Value = My.Settings.Refresh
		nudHour1.Value = Time2Text(My.Settings.Begin)(0)
		nudHour2.Value = Time2Text(My.Settings.Finish)(0)
		nudHour3.Value = Time2Text(My.Settings.NoonBegin)(0)
		nudHour4.Value = Time2Text(My.Settings.NoonFinish)(0)
		nudMinute1.Value = Time2Text(My.Settings.Begin)(1)
		nudMinute2.Value = Time2Text(My.Settings.Finish)(1)
		nudMinute3.Value = Time2Text(My.Settings.NoonBegin)(1)
		nudMinute4.Value = Time2Text(My.Settings.NoonFinish)(1)
		mskSalary.Text = My.Settings.Salary.ToString
		chkNoonBreak.Checked = My.Settings.NoonBreak
		WorkingHours()
	End Sub

	Private Sub WorkingHours()
		begin = Date.Parse(String.Format("{0}-{1}-{2} {3}:00", {Now.Year, Now.Month, Now.Day, My.Settings.Begin}))
		finish = Date.Parse(String.Format("{0}-{1}-{2} {3}:00", {Now.Year, Now.Month, Now.Day, My.Settings.Finish}))
		noonbegin = Date.Parse(String.Format("{0}-{1}-{2} {3}:00", {Now.Year, Now.Month, Now.Day, My.Settings.NoonBegin}))
		noonfinish = Date.Parse(String.Format("{0}-{1}-{2} {3}:00", {Now.Year, Now.Month, Now.Day, My.Settings.NoonFinish}))
		If nudHour1.Value > nudHour2.Value Then
			finish.AddDays(1)
		End If
		WorkingTimes = finish - begin
		If chkNoonBreak.Checked Then
			WorkingTimes -= (noonfinish - noonbegin)
		End If
		setColor()
		lblInfo.Text = String.Format("根据以上信息，一个月工作 {0} 天：{1}一天能赚 {2} 元，{3}一天工时 {4} 小时，{5}一秒钟能赚 {6} 元。", {nudWorkingDays.Value, vbCrLf, Int(CInt(mskSalary.Text) / nudWorkingDays.Value * 10000) / 10000, vbCrLf, WorkingTimes.TotalHours, vbCrLf, Int(CInt(mskSalary.Text) / nudWorkingDays.Value / WorkingTimes.TotalSeconds * 10000) / 10000})
	End Sub

	Public Sub setColor()
		If Me.InvokeRequired Then
			Me.Invoke(New Action(AddressOf setColor))
		Else
			' 在 UI 线程中设置小时的颜色
			For i = 1 To 24
				Select Case i
					Case nudHour1.Value
						tlpProgress.SetCellPosition(diamond(0), New TableLayoutPanelCellPosition(i - 1, 0))
						diamond(0).Location = New Point(1, 1)
						diamond(0).Visible = True
					Case nudHour2.Value
						tlpProgress.SetCellPosition(diamond(1), New TableLayoutPanelCellPosition(i - 1, 0))
						diamond(1).Location = New Point(1, 1)
						diamond(1).Visible = True
					Case Now.Hour
						tlpProgress.SetCellPosition(diamond(2), New TableLayoutPanelCellPosition(i - 1, 0))
						diamond(2).Location = New Point(1, 1)
						diamond(2).Visible = True
						diamond(2).BringToFront()
					Case nudHour3.Value
						If chkNoonBreak.Checked Then
							tlpProgress.SetCellPosition(diamond(3), New TableLayoutPanelCellPosition(i - 1, 0))
							diamond(3).Location = New Point(1, 1)
							diamond(3).Visible = True
						Else
							diamond(4).Visible = False
						End If
					Case nudHour4.Value
						If chkNoonBreak.Checked Then
							tlpProgress.SetCellPosition(diamond(4), New TableLayoutPanelCellPosition(i - 1, 0))
							diamond(4).Location = New Point(1, 1)
							diamond(4).Visible = True
						Else
							diamond(4).Visible = False
						End If
				End Select
			Next
		End If
	End Sub
End Class