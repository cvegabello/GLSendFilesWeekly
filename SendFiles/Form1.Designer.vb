<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtEmailGoodGL = New System.Windows.Forms.RichTextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.okBtn = New System.Windows.Forms.Button
        Me.cancelBtn = New System.Windows.Forms.Button
        Me.stopBtn = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.dateTxt = New System.Windows.Forms.Label
        Me.cdcLbl = New System.Windows.Forms.Label
        Me.cmbServer = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAccept = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtEmailBadGL = New System.Windows.Forms.RichTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmailGoodGL
        '
        Me.txtEmailGoodGL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailGoodGL.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailGoodGL.ForeColor = System.Drawing.Color.Navy
        Me.txtEmailGoodGL.Location = New System.Drawing.Point(17, 21)
        Me.txtEmailGoodGL.Name = "txtEmailGoodGL"
        Me.txtEmailGoodGL.Size = New System.Drawing.Size(621, 81)
        Me.txtEmailGoodGL.TabIndex = 8
        Me.txtEmailGoodGL.Text = ""
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 374)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(652, 11)
        Me.ProgressBar1.TabIndex = 9
        '
        'okBtn
        '
        Me.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okBtn.Image = CType(resources.GetObject("okBtn.Image"), System.Drawing.Image)
        Me.okBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.okBtn.Location = New System.Drawing.Point(199, 391)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(84, 46)
        Me.okBtn.TabIndex = 17
        Me.okBtn.Text = "&OK"
        Me.okBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.Image = CType(resources.GetObject("cancelBtn.Image"), System.Drawing.Image)
        Me.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelBtn.Location = New System.Drawing.Point(457, 391)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(84, 46)
        Me.cancelBtn.TabIndex = 18
        Me.cancelBtn.Text = "&Exit"
        Me.cancelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'stopBtn
        '
        Me.stopBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopBtn.Location = New System.Drawing.Point(12, 391)
        Me.stopBtn.Name = "stopBtn"
        Me.stopBtn.Size = New System.Drawing.Size(652, 46)
        Me.stopBtn.TabIndex = 19
        Me.stopBtn.Text = "Stop"
        Me.stopBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(594, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Oct/31/2019"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.dateTxt)
        Me.GroupBox1.Controls.Add(Me.cdcLbl)
        Me.GroupBox1.Controls.Add(Me.cmbServer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 57)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'dateTxt
        '
        Me.dateTxt.AutoSize = True
        Me.dateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTxt.ForeColor = System.Drawing.Color.DarkGreen
        Me.dateTxt.Location = New System.Drawing.Point(77, 23)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(0, 31)
        Me.dateTxt.TabIndex = 8
        '
        'cdcLbl
        '
        Me.cdcLbl.AutoSize = True
        Me.cdcLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdcLbl.ForeColor = System.Drawing.Color.DarkGreen
        Me.cdcLbl.Location = New System.Drawing.Point(317, 25)
        Me.cdcLbl.Name = "cdcLbl"
        Me.cdcLbl.Size = New System.Drawing.Size(31, 13)
        Me.cdcLbl.TabIndex = 7
        Me.cdcLbl.Text = "8226"
        '
        'cmbServer
        '
        Me.cmbServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Items.AddRange(New Object() {"DMZSFTP1 (10.1.6.184)", "DMZSFTP2 (10.2.6.185)", "NYSFTP1 (10.1.5.182)", "CAT_SFTP (10.162.33.15)"})
        Me.cmbServer.Location = New System.Drawing.Point(445, 17)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(194, 21)
        Me.cmbServer.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(385, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SERVER:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(281, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CDC:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DATE:"
        '
        'btnAccept
        '
        Me.btnAccept.Enabled = False
        Me.btnAccept.Image = Global.SendFiles.My.Resources.Resources.button_ok
        Me.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccept.Location = New System.Drawing.Point(258, 322)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(127, 25)
        Me.btnAccept.TabIndex = 10
        Me.btnAccept.Text = "Accept changes"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEmailBadGL)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(652, 119)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recipients when fail"
        '
        'txtEmailBadGL
        '
        Me.txtEmailBadGL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailBadGL.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailBadGL.ForeColor = System.Drawing.Color.Navy
        Me.txtEmailBadGL.Location = New System.Drawing.Point(18, 25)
        Me.txtEmailBadGL.Name = "txtEmailBadGL"
        Me.txtEmailBadGL.Size = New System.Drawing.Size(621, 81)
        Me.txtEmailBadGL.TabIndex = 9
        Me.txtEmailBadGL.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEmailGoodGL)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(652, 116)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recipients Successfully"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.stopBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly GL Files Send"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEmailGoodGL As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents stopBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateTxt As System.Windows.Forms.Label
    Friend WithEvents cdcLbl As System.Windows.Forms.Label
    Friend WithEvents cmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmailBadGL As System.Windows.Forms.RichTextBox

End Class
