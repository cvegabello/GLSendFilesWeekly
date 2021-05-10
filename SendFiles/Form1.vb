Imports System.Threading
Imports System.Text
Imports System.IO
Imports System.Net.Mail


'Imports Microsoft.Office.Interop.Excel


Public Class Form1

    Private Sub okBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okBtn.Click



        Me.okBtn.Enabled = False
        Me.cancelBtn.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        fileTransferFromCSVFile()
        MsgBox("THE GL Files have been transfered successfully.", MsgBoxStyle.Information, "GL Files")

        Me.Cursor = Cursors.Default

        Me.okBtn.Enabled = True
        Me.cancelBtn.Enabled = True

    End Sub

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dateSelected As Date
        Dim cdcInt As Integer

        DateTimePicker1.Value = Now
        dateSelected = DateTimePicker1.Value
        cdcInt = returnCDC(dateSelected)
        cdcLbl.Text = cdcInt

        cmbServer.Text = Utils.GetSetting(appName, "Server", "").ToString()
        txtEmailGoodGL.Text = Utils.GetSettingEmail(appName, "eMailGood", "").ToString()
        txtEmailBadGL.Text = Utils.GetSettingErrorsEmail(appName, "eMailBad", "").ToString()

        ProgressBar1.Maximum = 100
        okBtn.Visible = False
        cancelBtn.Visible = False
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim errCodeInt As Integer = 0
        Dim errMessageStr As String = ""
        Static count As Integer = 0
        count = count + 10
        If count <= 100 Then
            ProgressBar1.Value = count
        Else
            Timer1.Enabled = False

            stopBtn.Visible = False
            ProgressBar1.Visible = False

            okBtn.Visible = False
            cancelBtn.Visible = False

            errCodeInt = fileTransferFromCSVFile()

            Me.Dispose()





        End If

    End Sub

    Private Sub stopBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopBtn.Click
        Timer1.Enabled = False
        stopBtn.Visible = False
        ProgressBar1.Visible = False
        
        okBtn.Visible = True
        cancelBtn.Visible = True
    End Sub

    'Function sent_Email(ByVal smtpHostStr As String, ByVal toStr As String, ByVal attachStr As String, ByVal subjectStr As String, ByVal bodyStr As String) As Integer

    '    Dim SMTPserver As New SmtpClient
    '    Dim mail As New MailMessage
    '    'Dim oAttch As Attachment = New Attachment(attachStr)


    '    Try
    '        SMTPserver.Host = smtpHostStr
    '        'mail = New MailMessage
    '        mail.From = New MailAddress("do.not.reply@gtech-noreply.com")
    '        mail.To.Add(toStr) 'The Man you want to send the message to him
    '        mail.Subject = subjectStr
    '        mail.Body = bodyStr
    '        mail.Attachments.Add(New Attachment("C:\SharedDocuments\Templates\listFilesCheckDayOps.csv"))
    '        mail.Attachments.Add(New Attachment("C:\SharedDocuments\Templates\listFilesCheckDayOps.csv"))
    '        SMTPserver.Send(mail)
    '        Return 0
    '        'MessageBox.Show("Done!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '    Catch ex As Exception
    '        Return -1

    '    End Try

    'End Function
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateSelected As Date
        Dim cdcInt As Integer

        dateSelected = DateTimePicker1.Value
        cdcInt = returnCDC(dateSelected)
        cdcLbl.Text = cdcInt
    End Sub

    Private Sub cmbServer_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbServer.DropDown
        btnAccept.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Utils.SalvarSetting(appName, "Server", cmbServer.Text)
        Utils.SalvarSettingEmail(appName, "eMailGood", txtEmailGoodGL.Text)
        Utils.SalvarSettingErrorsEmail(appName, "eMailBad", txtEmailBadGL.Text)
        Me.btnAccept.Enabled = False

        okBtn.Enabled = True
    End Sub


    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    sent_Email("156.24.14.132", "carlos.vegabello@igt.com", "", "OnePlace files transmitted ", "Please see the file attached." & vbCr & vbCr & "OPS, please save this")
    'End Sub

    Private Sub txtEmailBadGL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailBadGL.TextChanged
        btnAccept.Enabled = True
        okBtn.Enabled = False
    End Sub

    Private Sub txtEmailGoodGL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmailGoodGL.TextChanged
        btnAccept.Enabled = True
        okBtn.Enabled = False
    End Sub
End Class
