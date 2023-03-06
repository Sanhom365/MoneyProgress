<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form 重写 Dispose，以清理组件列表。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.NotifyIconMain = New System.Windows.Forms.NotifyIcon(Me.components)
		Me.cmsNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.lblLoaf = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.lblToday = New System.Windows.Forms.Label()
		Me.lblPercent = New System.Windows.Forms.Label()
		Me.lblContent = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblInspirational = New System.Windows.Forms.Label()
		Me.cmsNotify.SuspendLayout()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'NotifyIconMain
		'
		Me.NotifyIconMain.ContextMenuStrip = Me.cmsNotify
		Me.NotifyIconMain.Text = "💰 您今日已赚 "
		Me.NotifyIconMain.Visible = True
		'
		'cmsNotify
		'
		Me.cmsNotify.BackgroundImage = Global.MoneyProgress.My.Resources.Resources.money1
		Me.cmsNotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.cmsNotify.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.cmsNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ToolStripMenuItem3})
		Me.cmsNotify.Name = "cmsNotify"
		Me.cmsNotify.Size = New System.Drawing.Size(141, 82)
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 24)
		Me.ToolStripMenuItem1.Text = "显示/隐藏"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(140, 24)
		Me.ToolStripMenuItem2.Text = "设置"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(140, 24)
		Me.ToolStripMenuItem3.Text = "退出"
		'
		'picIcon
		'
		Me.picIcon.Image = Global.MoneyProgress.My.Resources.Resources.icon
		Me.picIcon.Location = New System.Drawing.Point(25, 12)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(48, 48)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 1
		Me.picIcon.TabStop = False
		'
		'lblLoaf
		'
		Me.lblLoaf.AutoSize = True
		Me.lblLoaf.BackColor = System.Drawing.Color.Transparent
		Me.lblLoaf.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblLoaf.ForeColor = System.Drawing.Color.White
		Me.lblLoaf.Location = New System.Drawing.Point(12, 63)
		Me.lblLoaf.Name = "lblLoaf"
		Me.lblLoaf.Size = New System.Drawing.Size(74, 21)
		Me.lblLoaf.TabIndex = 2
		Me.lblLoaf.Text = "一起赚钱"
		Me.lblLoaf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(123, 38)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(328, 23)
		Me.ProgressBar1.TabIndex = 3
		'
		'lblToday
		'
		Me.lblToday.AutoSize = True
		Me.lblToday.BackColor = System.Drawing.Color.Transparent
		Me.lblToday.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblToday.ForeColor = System.Drawing.Color.White
		Me.lblToday.Location = New System.Drawing.Point(119, 15)
		Me.lblToday.Name = "lblToday"
		Me.lblToday.Size = New System.Drawing.Size(65, 20)
		Me.lblToday.TabIndex = 4
		Me.lblToday.Text = "今日进度"
		Me.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblPercent
		'
		Me.lblPercent.BackColor = System.Drawing.Color.Transparent
		Me.lblPercent.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPercent.ForeColor = System.Drawing.Color.White
		Me.lblPercent.Location = New System.Drawing.Point(316, 16)
		Me.lblPercent.Name = "lblPercent"
		Me.lblPercent.Size = New System.Drawing.Size(131, 20)
		Me.lblPercent.TabIndex = 5
		Me.lblPercent.Text = "0%"
		Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblContent
		'
		Me.lblContent.AutoSize = True
		Me.lblContent.BackColor = System.Drawing.Color.Transparent
		Me.lblContent.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblContent.ForeColor = System.Drawing.Color.Gold
		Me.lblContent.Location = New System.Drawing.Point(119, 64)
		Me.lblContent.Name = "lblContent"
		Me.lblContent.Size = New System.Drawing.Size(0, 20)
		Me.lblContent.TabIndex = 6
		Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Timer1
		'
		'
		'lblInspirational
		'
		Me.lblInspirational.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblInspirational.BackColor = System.Drawing.Color.Transparent
		Me.lblInspirational.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblInspirational.ForeColor = System.Drawing.Color.Orange
		Me.lblInspirational.Location = New System.Drawing.Point(12, 84)
		Me.lblInspirational.Name = "lblInspirational"
		Me.lblInspirational.Size = New System.Drawing.Size(476, 54)
		Me.lblInspirational.TabIndex = 7
		Me.lblInspirational.Text = "一起赚钱"
		Me.lblInspirational.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DimGray
		Me.ClientSize = New System.Drawing.Size(500, 139)
		Me.Controls.Add(Me.lblInspirational)
		Me.Controls.Add(Me.lblContent)
		Me.Controls.Add(Me.lblPercent)
		Me.Controls.Add(Me.lblToday)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.lblLoaf)
		Me.Controls.Add(Me.picIcon)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Location = New System.Drawing.Point(300, -5)
		Me.Name = "frmMain"
		Me.Opacity = 0.79R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "钱条"
		Me.TopMost = True
		Me.cmsNotify.ResumeLayout(False)
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents NotifyIconMain As NotifyIcon
	Friend WithEvents cmsNotify As ContextMenuStrip
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents lblLoaf As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents lblToday As Label
	Friend WithEvents lblPercent As Label
	Friend WithEvents lblContent As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblInspirational As Label
End Class
