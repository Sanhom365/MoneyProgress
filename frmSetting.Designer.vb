<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
		Me.btnExit = New System.Windows.Forms.Button()
		Me.picIcon = New System.Windows.Forms.PictureBox()
		Me.pnlIcon = New System.Windows.Forms.Panel()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblContent = New System.Windows.Forms.Label()
		Me.tlpProgress = New System.Windows.Forms.TableLayoutPanel()
		Me.lblBegin = New System.Windows.Forms.Label()
		Me.nudHour1 = New System.Windows.Forms.NumericUpDown()
		Me.lblHour1 = New System.Windows.Forms.Label()
		Me.nudMinute1 = New System.Windows.Forms.NumericUpDown()
		Me.lblMinute1 = New System.Windows.Forms.Label()
		Me.lblMinute2 = New System.Windows.Forms.Label()
		Me.nudMinute2 = New System.Windows.Forms.NumericUpDown()
		Me.nudHour2 = New System.Windows.Forms.NumericUpDown()
		Me.lblHour2 = New System.Windows.Forms.Label()
		Me.lblFinish = New System.Windows.Forms.Label()
		Me.chkNoonBreak = New System.Windows.Forms.CheckBox()
		Me.lblMinute4 = New System.Windows.Forms.Label()
		Me.nudMinute4 = New System.Windows.Forms.NumericUpDown()
		Me.nudHour4 = New System.Windows.Forms.NumericUpDown()
		Me.lblHour4 = New System.Windows.Forms.Label()
		Me.lblNoonFinish = New System.Windows.Forms.Label()
		Me.lblMinute3 = New System.Windows.Forms.Label()
		Me.nudMinute3 = New System.Windows.Forms.NumericUpDown()
		Me.nudHour3 = New System.Windows.Forms.NumericUpDown()
		Me.lblHour3 = New System.Windows.Forms.Label()
		Me.lblNoonBegin = New System.Windows.Forms.Label()
		Me.lblSalary = New System.Windows.Forms.Label()
		Me.mskSalary = New System.Windows.Forms.MaskedTextBox()
		Me.lblWorkingDays = New System.Windows.Forms.Label()
		Me.nudWorkingDays = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.nudRefresh = New System.Windows.Forms.NumericUpDown()
		Me.lblRefresh = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblInfo = New System.Windows.Forms.Label()
		Me.lblPage = New System.Windows.Forms.LinkLabel()
		Me.lblIssues = New System.Windows.Forms.LinkLabel()
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlIcon.SuspendLayout()
		CType(Me.nudHour1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinute1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinute2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudHour2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinute4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudHour4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudMinute3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudHour3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudWorkingDays, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.BackColor = System.Drawing.Color.Transparent
		Me.btnExit.BackgroundImage = Global.MoneyProgress.My.Resources.Resources.x
		Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExit.Location = New System.Drawing.Point(605, 12)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(23, 23)
		Me.btnExit.TabIndex = 0
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'picIcon
		'
		Me.picIcon.BackColor = System.Drawing.Color.Transparent
		Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.picIcon.Image = Global.MoneyProgress.My.Resources.Resources.icon
		Me.picIcon.Location = New System.Drawing.Point(12, 12)
		Me.picIcon.Name = "picIcon"
		Me.picIcon.Size = New System.Drawing.Size(41, 41)
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picIcon.TabIndex = 1
		Me.picIcon.TabStop = False
		'
		'pnlIcon
		'
		Me.pnlIcon.BackColor = System.Drawing.Color.Transparent
		Me.pnlIcon.BackgroundImage = Global.MoneyProgress.My.Resources.Resources.money1
		Me.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pnlIcon.Controls.Add(Me.picIcon)
		Me.pnlIcon.Location = New System.Drawing.Point(288, 35)
		Me.pnlIcon.Name = "pnlIcon"
		Me.pnlIcon.Size = New System.Drawing.Size(64, 64)
		Me.pnlIcon.TabIndex = 1
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.Gold
		Me.lblTitle.Location = New System.Drawing.Point(275, 111)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(90, 22)
		Me.lblTitle.TabIndex = 2
		Me.lblTitle.Text = "搞钱进度条"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblContent
		'
		Me.lblContent.AutoSize = True
		Me.lblContent.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblContent.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblContent.Location = New System.Drawing.Point(162, 137)
		Me.lblContent.Name = "lblContent"
		Me.lblContent.Size = New System.Drawing.Size(317, 19)
		Me.lblContent.TabIndex = 3
		Me.lblContent.Text = "每天没事看看自己赚到的钱，心情会不会好一点呢"
		Me.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tlpProgress
		'
		Me.tlpProgress.BackColor = System.Drawing.Color.WhiteSmoke
		Me.tlpProgress.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
		Me.tlpProgress.ColumnCount = 24
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
		Me.tlpProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
		Me.tlpProgress.Cursor = System.Windows.Forms.Cursors.AppStarting
		Me.tlpProgress.Location = New System.Drawing.Point(152, 165)
		Me.tlpProgress.Name = "tlpProgress"
		Me.tlpProgress.RowCount = 1
		Me.tlpProgress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.tlpProgress.Size = New System.Drawing.Size(336, 31)
		Me.tlpProgress.TabIndex = 4
		'
		'lblBegin
		'
		Me.lblBegin.AutoSize = True
		Me.lblBegin.BackColor = System.Drawing.Color.Transparent
		Me.lblBegin.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblBegin.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblBegin.Location = New System.Drawing.Point(126, 209)
		Me.lblBegin.Name = "lblBegin"
		Me.lblBegin.Size = New System.Drawing.Size(56, 17)
		Me.lblBegin.TabIndex = 5
		Me.lblBegin.Text = "开工时间"
		Me.lblBegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudHour1
		'
		Me.nudHour1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudHour1.Location = New System.Drawing.Point(189, 208)
		Me.nudHour1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.nudHour1.Name = "nudHour1"
		Me.nudHour1.Size = New System.Drawing.Size(39, 21)
		Me.nudHour1.TabIndex = 6
		Me.nudHour1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblHour1
		'
		Me.lblHour1.AutoSize = True
		Me.lblHour1.BackColor = System.Drawing.Color.Transparent
		Me.lblHour1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblHour1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblHour1.Location = New System.Drawing.Point(230, 209)
		Me.lblHour1.Name = "lblHour1"
		Me.lblHour1.Size = New System.Drawing.Size(20, 17)
		Me.lblHour1.TabIndex = 7
		Me.lblHour1.Text = "时"
		Me.lblHour1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudMinute1
		'
		Me.nudMinute1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudMinute1.Location = New System.Drawing.Point(250, 208)
		Me.nudMinute1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.nudMinute1.Name = "nudMinute1"
		Me.nudMinute1.Size = New System.Drawing.Size(39, 21)
		Me.nudMinute1.TabIndex = 8
		Me.nudMinute1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblMinute1
		'
		Me.lblMinute1.AutoSize = True
		Me.lblMinute1.BackColor = System.Drawing.Color.Transparent
		Me.lblMinute1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblMinute1.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMinute1.Location = New System.Drawing.Point(291, 209)
		Me.lblMinute1.Name = "lblMinute1"
		Me.lblMinute1.Size = New System.Drawing.Size(20, 17)
		Me.lblMinute1.TabIndex = 9
		Me.lblMinute1.Text = "分"
		Me.lblMinute1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMinute2
		'
		Me.lblMinute2.AutoSize = True
		Me.lblMinute2.BackColor = System.Drawing.Color.Transparent
		Me.lblMinute2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblMinute2.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMinute2.Location = New System.Drawing.Point(495, 209)
		Me.lblMinute2.Name = "lblMinute2"
		Me.lblMinute2.Size = New System.Drawing.Size(20, 17)
		Me.lblMinute2.TabIndex = 14
		Me.lblMinute2.Text = "分"
		Me.lblMinute2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudMinute2
		'
		Me.nudMinute2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudMinute2.Location = New System.Drawing.Point(454, 208)
		Me.nudMinute2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.nudMinute2.Name = "nudMinute2"
		Me.nudMinute2.Size = New System.Drawing.Size(39, 21)
		Me.nudMinute2.TabIndex = 13
		Me.nudMinute2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'nudHour2
		'
		Me.nudHour2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudHour2.Location = New System.Drawing.Point(393, 208)
		Me.nudHour2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.nudHour2.Name = "nudHour2"
		Me.nudHour2.Size = New System.Drawing.Size(39, 21)
		Me.nudHour2.TabIndex = 11
		Me.nudHour2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblHour2
		'
		Me.lblHour2.AutoSize = True
		Me.lblHour2.BackColor = System.Drawing.Color.Transparent
		Me.lblHour2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblHour2.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblHour2.Location = New System.Drawing.Point(434, 209)
		Me.lblHour2.Name = "lblHour2"
		Me.lblHour2.Size = New System.Drawing.Size(20, 17)
		Me.lblHour2.TabIndex = 12
		Me.lblHour2.Text = "时"
		Me.lblHour2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblFinish
		'
		Me.lblFinish.AutoSize = True
		Me.lblFinish.BackColor = System.Drawing.Color.Transparent
		Me.lblFinish.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblFinish.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblFinish.Location = New System.Drawing.Point(330, 209)
		Me.lblFinish.Name = "lblFinish"
		Me.lblFinish.Size = New System.Drawing.Size(56, 17)
		Me.lblFinish.TabIndex = 10
		Me.lblFinish.Text = "收工时间"
		Me.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'chkNoonBreak
		'
		Me.chkNoonBreak.AutoSize = True
		Me.chkNoonBreak.BackColor = System.Drawing.Color.Transparent
		Me.chkNoonBreak.Checked = True
		Me.chkNoonBreak.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkNoonBreak.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.chkNoonBreak.Location = New System.Drawing.Point(129, 235)
		Me.chkNoonBreak.Name = "chkNoonBreak"
		Me.chkNoonBreak.Size = New System.Drawing.Size(84, 16)
		Me.chkNoonBreak.TabIndex = 15
		Me.chkNoonBreak.Text = "是否有午休"
		Me.chkNoonBreak.UseVisualStyleBackColor = False
		'
		'lblMinute4
		'
		Me.lblMinute4.AutoSize = True
		Me.lblMinute4.BackColor = System.Drawing.Color.Transparent
		Me.lblMinute4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblMinute4.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMinute4.Location = New System.Drawing.Point(495, 254)
		Me.lblMinute4.Name = "lblMinute4"
		Me.lblMinute4.Size = New System.Drawing.Size(20, 17)
		Me.lblMinute4.TabIndex = 25
		Me.lblMinute4.Text = "分"
		Me.lblMinute4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudMinute4
		'
		Me.nudMinute4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudMinute4.Location = New System.Drawing.Point(454, 253)
		Me.nudMinute4.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.nudMinute4.Name = "nudMinute4"
		Me.nudMinute4.Size = New System.Drawing.Size(39, 21)
		Me.nudMinute4.TabIndex = 24
		Me.nudMinute4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'nudHour4
		'
		Me.nudHour4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudHour4.Location = New System.Drawing.Point(393, 253)
		Me.nudHour4.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.nudHour4.Name = "nudHour4"
		Me.nudHour4.Size = New System.Drawing.Size(39, 21)
		Me.nudHour4.TabIndex = 22
		Me.nudHour4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblHour4
		'
		Me.lblHour4.AutoSize = True
		Me.lblHour4.BackColor = System.Drawing.Color.Transparent
		Me.lblHour4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblHour4.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblHour4.Location = New System.Drawing.Point(434, 254)
		Me.lblHour4.Name = "lblHour4"
		Me.lblHour4.Size = New System.Drawing.Size(20, 17)
		Me.lblHour4.TabIndex = 23
		Me.lblHour4.Text = "时"
		Me.lblHour4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblNoonFinish
		'
		Me.lblNoonFinish.AutoSize = True
		Me.lblNoonFinish.BackColor = System.Drawing.Color.Transparent
		Me.lblNoonFinish.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblNoonFinish.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblNoonFinish.Location = New System.Drawing.Point(330, 254)
		Me.lblNoonFinish.Name = "lblNoonFinish"
		Me.lblNoonFinish.Size = New System.Drawing.Size(56, 17)
		Me.lblNoonFinish.TabIndex = 21
		Me.lblNoonFinish.Text = "午休结束"
		Me.lblNoonFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblMinute3
		'
		Me.lblMinute3.AutoSize = True
		Me.lblMinute3.BackColor = System.Drawing.Color.Transparent
		Me.lblMinute3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblMinute3.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblMinute3.Location = New System.Drawing.Point(291, 254)
		Me.lblMinute3.Name = "lblMinute3"
		Me.lblMinute3.Size = New System.Drawing.Size(20, 17)
		Me.lblMinute3.TabIndex = 20
		Me.lblMinute3.Text = "分"
		Me.lblMinute3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudMinute3
		'
		Me.nudMinute3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudMinute3.Location = New System.Drawing.Point(250, 253)
		Me.nudMinute3.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
		Me.nudMinute3.Name = "nudMinute3"
		Me.nudMinute3.Size = New System.Drawing.Size(39, 21)
		Me.nudMinute3.TabIndex = 19
		Me.nudMinute3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'nudHour3
		'
		Me.nudHour3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudHour3.Location = New System.Drawing.Point(189, 253)
		Me.nudHour3.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.nudHour3.Name = "nudHour3"
		Me.nudHour3.Size = New System.Drawing.Size(39, 21)
		Me.nudHour3.TabIndex = 17
		Me.nudHour3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblHour3
		'
		Me.lblHour3.AutoSize = True
		Me.lblHour3.BackColor = System.Drawing.Color.Transparent
		Me.lblHour3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblHour3.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblHour3.Location = New System.Drawing.Point(230, 254)
		Me.lblHour3.Name = "lblHour3"
		Me.lblHour3.Size = New System.Drawing.Size(20, 17)
		Me.lblHour3.TabIndex = 18
		Me.lblHour3.Text = "时"
		Me.lblHour3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblNoonBegin
		'
		Me.lblNoonBegin.AutoSize = True
		Me.lblNoonBegin.BackColor = System.Drawing.Color.Transparent
		Me.lblNoonBegin.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblNoonBegin.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblNoonBegin.Location = New System.Drawing.Point(126, 254)
		Me.lblNoonBegin.Name = "lblNoonBegin"
		Me.lblNoonBegin.Size = New System.Drawing.Size(56, 17)
		Me.lblNoonBegin.TabIndex = 16
		Me.lblNoonBegin.Text = "午休始于"
		Me.lblNoonBegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblSalary
		'
		Me.lblSalary.AutoSize = True
		Me.lblSalary.BackColor = System.Drawing.Color.Transparent
		Me.lblSalary.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblSalary.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblSalary.Location = New System.Drawing.Point(150, 280)
		Me.lblSalary.Name = "lblSalary"
		Me.lblSalary.Size = New System.Drawing.Size(32, 17)
		Me.lblSalary.TabIndex = 26
		Me.lblSalary.Text = "月薪"
		Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'mskSalary
		'
		Me.mskSalary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mskSalary.Location = New System.Drawing.Point(189, 280)
		Me.mskSalary.Mask = "999999"
		Me.mskSalary.Name = "mskSalary"
		Me.mskSalary.Size = New System.Drawing.Size(100, 21)
		Me.mskSalary.TabIndex = 27
		Me.mskSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.mskSalary.ValidatingType = GetType(Integer)
		'
		'lblWorkingDays
		'
		Me.lblWorkingDays.AutoSize = True
		Me.lblWorkingDays.BackColor = System.Drawing.Color.Transparent
		Me.lblWorkingDays.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblWorkingDays.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblWorkingDays.Location = New System.Drawing.Point(330, 280)
		Me.lblWorkingDays.Name = "lblWorkingDays"
		Me.lblWorkingDays.Size = New System.Drawing.Size(56, 17)
		Me.lblWorkingDays.TabIndex = 28
		Me.lblWorkingDays.Text = "本月工作"
		Me.lblWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudWorkingDays
		'
		Me.nudWorkingDays.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudWorkingDays.Location = New System.Drawing.Point(393, 279)
		Me.nudWorkingDays.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
		Me.nudWorkingDays.Name = "nudWorkingDays"
		Me.nudWorkingDays.Size = New System.Drawing.Size(39, 21)
		Me.nudWorkingDays.TabIndex = 29
		Me.nudWorkingDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.Label3.Location = New System.Drawing.Point(434, 280)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(20, 17)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "天"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnSave
		'
		Me.btnSave.BackColor = System.Drawing.Color.Transparent
		Me.btnSave.BackgroundImage = Global.MoneyProgress.My.Resources.Resources.button
		Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSave.FlatAppearance.BorderSize = 0
		Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.btnSave.Location = New System.Drawing.Point(220, 322)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(200, 31)
		Me.btnSave.TabIndex = 31
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'nudRefresh
		'
		Me.nudRefresh.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nudRefresh.Location = New System.Drawing.Point(589, 447)
		Me.nudRefresh.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
		Me.nudRefresh.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nudRefresh.Name = "nudRefresh"
		Me.nudRefresh.Size = New System.Drawing.Size(39, 21)
		Me.nudRefresh.TabIndex = 32
		Me.nudRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.nudRefresh.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'lblRefresh
		'
		Me.lblRefresh.AutoSize = True
		Me.lblRefresh.BackColor = System.Drawing.Color.Transparent
		Me.lblRefresh.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblRefresh.Location = New System.Drawing.Point(491, 448)
		Me.lblRefresh.Name = "lblRefresh"
		Me.lblRefresh.Size = New System.Drawing.Size(92, 17)
		Me.lblRefresh.TabIndex = 33
		Me.lblRefresh.Text = "刷新间隔（秒）"
		Me.lblRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Timer1
		'
		'
		'lblInfo
		'
		Me.lblInfo.AutoSize = True
		Me.lblInfo.BackColor = System.Drawing.Color.Transparent
		Me.lblInfo.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblInfo.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.lblInfo.Location = New System.Drawing.Point(12, 397)
		Me.lblInfo.Name = "lblInfo"
		Me.lblInfo.Size = New System.Drawing.Size(199, 68)
		Me.lblInfo.TabIndex = 34
		Me.lblInfo.Text = "根据以上信息，一个月工作 {0} 天：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "一天能赚 {1} 元，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "一天工时 {2} 小时，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "一秒钟能赚 {3} 元。"
		'
		'lblPage
		'
		Me.lblPage.AutoSize = True
		Me.lblPage.BackColor = System.Drawing.Color.Transparent
		Me.lblPage.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblPage.Location = New System.Drawing.Point(13, 12)
		Me.lblPage.Name = "lblPage"
		Me.lblPage.Size = New System.Drawing.Size(86, 17)
		Me.lblPage.TabIndex = 35
		Me.lblPage.TabStop = True
		Me.lblPage.Text = "Github 仓库页"
		Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblIssues
		'
		Me.lblIssues.AutoSize = True
		Me.lblIssues.BackColor = System.Drawing.Color.Transparent
		Me.lblIssues.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
		Me.lblIssues.Location = New System.Drawing.Point(13, 35)
		Me.lblIssues.Name = "lblIssues"
		Me.lblIssues.Size = New System.Drawing.Size(56, 17)
		Me.lblIssues.TabIndex = 36
		Me.lblIssues.TabStop = True
		Me.lblIssues.Text = "问题反馈"
		Me.lblIssues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'frmSetting
		'
		Me.AcceptButton = Me.btnSave
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.CancelButton = Me.btnExit
		Me.ClientSize = New System.Drawing.Size(640, 480)
		Me.Controls.Add(Me.lblIssues)
		Me.Controls.Add(Me.lblPage)
		Me.Controls.Add(Me.lblInfo)
		Me.Controls.Add(Me.tlpProgress)
		Me.Controls.Add(Me.lblRefresh)
		Me.Controls.Add(Me.nudRefresh)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.nudWorkingDays)
		Me.Controls.Add(Me.lblWorkingDays)
		Me.Controls.Add(Me.mskSalary)
		Me.Controls.Add(Me.lblSalary)
		Me.Controls.Add(Me.lblMinute4)
		Me.Controls.Add(Me.nudMinute4)
		Me.Controls.Add(Me.nudHour4)
		Me.Controls.Add(Me.lblHour4)
		Me.Controls.Add(Me.lblNoonFinish)
		Me.Controls.Add(Me.lblMinute3)
		Me.Controls.Add(Me.nudMinute3)
		Me.Controls.Add(Me.nudHour3)
		Me.Controls.Add(Me.lblHour3)
		Me.Controls.Add(Me.lblNoonBegin)
		Me.Controls.Add(Me.chkNoonBreak)
		Me.Controls.Add(Me.lblMinute2)
		Me.Controls.Add(Me.nudMinute2)
		Me.Controls.Add(Me.nudHour2)
		Me.Controls.Add(Me.lblHour2)
		Me.Controls.Add(Me.lblFinish)
		Me.Controls.Add(Me.lblMinute1)
		Me.Controls.Add(Me.nudMinute1)
		Me.Controls.Add(Me.nudHour1)
		Me.Controls.Add(Me.lblHour1)
		Me.Controls.Add(Me.lblBegin)
		Me.Controls.Add(Me.lblContent)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.pnlIcon)
		Me.Controls.Add(Me.btnExit)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmSetting"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "搞钱进度条"
		CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlIcon.ResumeLayout(False)
		CType(Me.nudHour1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudMinute1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudMinute2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudHour2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudMinute4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudHour4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudMinute3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudHour3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudWorkingDays, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudRefresh, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnExit As Button
	Friend WithEvents picIcon As PictureBox
	Friend WithEvents pnlIcon As Panel
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblContent As Label
	Friend WithEvents tlpProgress As TableLayoutPanel
	Friend WithEvents lblBegin As Label
	Friend WithEvents nudHour1 As NumericUpDown
	Friend WithEvents lblHour1 As Label
	Friend WithEvents nudMinute1 As NumericUpDown
	Friend WithEvents lblMinute1 As Label
	Friend WithEvents lblMinute2 As Label
	Friend WithEvents nudMinute2 As NumericUpDown
	Friend WithEvents nudHour2 As NumericUpDown
	Friend WithEvents lblHour2 As Label
	Friend WithEvents lblFinish As Label
	Friend WithEvents chkNoonBreak As CheckBox
	Friend WithEvents lblMinute4 As Label
	Friend WithEvents nudMinute4 As NumericUpDown
	Friend WithEvents nudHour4 As NumericUpDown
	Friend WithEvents lblHour4 As Label
	Friend WithEvents lblNoonFinish As Label
	Friend WithEvents lblMinute3 As Label
	Friend WithEvents nudMinute3 As NumericUpDown
	Friend WithEvents nudHour3 As NumericUpDown
	Friend WithEvents lblHour3 As Label
	Friend WithEvents lblNoonBegin As Label
	Friend WithEvents lblSalary As Label
	Friend WithEvents mskSalary As MaskedTextBox
	Friend WithEvents lblWorkingDays As Label
	Friend WithEvents nudWorkingDays As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents nudRefresh As NumericUpDown
	Friend WithEvents lblRefresh As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents lblInfo As Label
	Friend WithEvents lblPage As LinkLabel
	Friend WithEvents lblIssues As LinkLabel
End Class
