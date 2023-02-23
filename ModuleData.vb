Imports System.Threading

Module ModuleData
	Public nowDay As Byte = Now.Day
	Public WorkingTimes As TimeSpan
	Public begin, finish, noonbegin, noonfinish As Date

	''' <summary>
	''' 时分分离
	''' </summary>
	''' <param name="timeStr">时:分</param>
	''' <returns>时、分的数组字符串组</returns>
	''' <remarks></remarks>
	Public Function Time2Text(timeStr As String) As String()
		Return timeStr.Split(":")
	End Function

	''' <summary>
	''' 时分连接
	''' </summary>
	''' <param name="timeHour">时</param>
	''' <param name="timeMinute">分</param>
	''' <returns>时:分</returns>
	''' <remarks></remarks>
	Public Function Text2Time(timeHour As String, timeMinute As String) As String
		Return timeHour & ":" & timeMinute
	End Function

	''' <summary>
	''' 计算当月工作天数
	''' </summary>
	''' <param name="max">当月天数</param>
	''' <returns>工作天数</returns>
	''' <remarks></remarks>
	Public Function calculate(max As Byte) As Byte
		' 计算工作日天数
		Dim workdays As Byte = 0
		For day As Byte = 1 To max
			Dim dateValue As New Date(Now.Year, Now.Month, day)
			If dateValue.DayOfWeek <> DayOfWeek.Saturday AndAlso dateValue.DayOfWeek <> DayOfWeek.Sunday Then
				workdays += 1
			End If
		Next
		Return workdays
	End Function

	'Public Sub GetHour()
	'	Do While True
	'		Thread.Sleep(My.Settings.Refresh * 1000)
	'		Application.DoEvents()
	'		frmMain.changeText()
	'		If ready Then
	'			frmSetting.setColor()
	'		End If
	'	Loop
	'End Sub
End Module