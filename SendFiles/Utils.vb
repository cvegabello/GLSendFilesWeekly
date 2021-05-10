
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Net
Imports Microsoft.Win32
Imports System.Net.Mail



Module Utils
    Public appName As String = "SendFiles"
    'cmbServer.Text = Utils.GetSetting(appName, "Server", "").ToString()
    Public Function GetSetting(ByVal APP_NAME As String, ByVal Keyname As String, Optional ByVal DefVal As String = "") As String
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Return Key.GetValue(Keyname, DefVal)


        Catch
            Return DefVal
        End Try
    End Function
    'Utils.SalvarSetting(appName, "Server", cmbServer.Text)
    Public Sub SalvarSetting(ByVal APP_NAME As String, ByVal Keyname As String, ByVal Value As String)
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Key.SetValue(Keyname, Value)
        Catch
            Return
        End Try
    End Sub

    'Utils.SalvarSettingEmail(appName, "eMailGood", txtEmailGoodGL.Text)
    Public Sub SalvarSettingEmail(ByVal APP_NAME As String, ByVal Keyname As String, ByVal Value As String)
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Key.SetValue(Keyname, Value)
        Catch
            Return
        End Try
    End Sub

    'txtEmailGoodGL.Text = Utils.GetSettingEmail(appName, "eMailGood", "").ToString()
    Public Function GetSettingEmail(ByVal APP_NAME As String, ByVal Keyname As String, Optional ByVal DefVal As String = "") As String
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Return Key.GetValue(Keyname, DefVal)

        Catch
            Return DefVal
        End Try

    End Function

    'Utils.SalvarSettingErrorsEmail(appName, "eMailBad", txtEmailBadGL.Text)
    Public Sub SalvarSettingErrorsEmail(ByVal APP_NAME As String, ByVal Keyname As String, ByVal Value As String)
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Key.SetValue(Keyname, Value)
        Catch
            Return
        End Try
    End Sub
    'txtEmailBadGL.Text = Utils.GetSettingErrorsEmail(appName, "eMailBad", "").ToString()

    Public Function GetSettingErrorsEmail(ByVal APP_NAME As String, ByVal Keyname As String, Optional ByVal DefVal As String = "") As String
        Dim Key As RegistryKey
        Try
            Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey(APP_NAME)
            Return Key.GetValue(Keyname, DefVal)

        Catch
            Return DefVal
        End Try

    End Function

   

    'Public Sub SalvarSettingEmailOnePlace(ByVal APP_NAME As String, ByVal Keyname As String, ByVal Value As String)
    '    Dim Key As RegistryKey
    '    Try
    '        Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey("eMailOnePlace")
    '        Key.SetValue(Keyname, Value)
    '    Catch
    '        Return
    '    End Try
    'End Sub
    'Public Function GetSettingEmailOnePlace(ByVal APP_NAME As String, ByVal Keyname As String, Optional ByVal DefVal As String = "") As String
    '    Dim Key As RegistryKey
    '    Try
    '        Key = Registry.CurrentUser.CreateSubKey("SOFTWARE").CreateSubKey("IGT").CreateSubKey("eMailOnePlace")
    '        Return Key.GetValue(Keyname, DefVal)

    '    Catch
    '        Return DefVal
    '    End Try

    'End Function




    Function returnFecha(ByVal toKnowCdc As Integer) As Date
        Dim initDate As Date
        initDate = "1/1/1986"

        Today = System.DateTime.Now
        returnFecha = initDate.AddDays(toKnowCdc)

        'returnFecha = (initDate + toKnowCdc) - 1

    End Function


    Function convertDateInt(ByVal toKnowDate As Date) As Integer
        Dim initDate As Date
        Dim diff1 As TimeSpan
        initDate = "1/1/1900"

        diff1 = toKnowDate.Subtract(initDate)
        convertDateInt = diff1.Days + 2

    End Function

    Function returnCDC(ByVal toKnowDate As Date) As Integer
        Dim initDate As Date
        Dim diff1 As TimeSpan
        initDate = "1/1/1986"

        diff1 = toKnowDate.Subtract(initDate)
        returnCDC = diff1.Days + 1

    End Function
    Function returnCDC_OTG(ByVal toKnowDate As Date) As Integer
        Dim initDate As Date
        Dim diff1 As TimeSpan
        initDate = "5/1/2013"

        diff1 = toKnowDate.Subtract(initDate)
        returnCDC_OTG = diff1.Days + 1

    End Function

    Function returnCDC_OP(ByVal toKnowDate As Date) As Integer
        'Dim initDate As Date
        ''Dim diff1 As TimeSpan
        'initDate = "5/1/2013"
        returnCDC_OP = returnCDC(toKnowDate) - 3652
        'diff1 = toKnowDate.Subtract(initDate)
        'returnCDC_OP = diff1.Days + 1

    End Function

    Function returnDayWeek(ByVal dayWeek As Integer) As String

        Select Case dayWeek
            Case 1
                returnDayWeek = "SUNDAY"

            Case 2
                returnDayWeek = "MONDAY"

            Case 3
                returnDayWeek = "TUESDAY"

            Case 4
                returnDayWeek = "WEDNESDAY"

            Case 5
                returnDayWeek = "THURSDAY"

            Case 6
                returnDayWeek = "FRIDAY"

            Case 7
                returnDayWeek = "SATURDAY"

            Case Else

                returnDayWeek = ""

        End Select

    End Function

    Function getInfoFileTbl(ByVal toKnowDate As Date) As DataTable


        Dim filesLocationTbl As New DataTable("FILES_LOCATION")
        Dim nuevaFila As DataRow
        Dim reader1 As StreamReader
        Dim strLine, strValue As String
        Dim substrings() As String

        'cdcInt = returnCDC(toKnowDate)
        filesLocationTbl = Utils.Despliegue

        strValue = ""
        Try
            reader1 = New StreamReader("listFilesExistTest.txt", Encoding.UTF7)
            strLine = ""

            Do While Not (strLine Is Nothing)
                strLine = reader1.ReadLine()
                If Not (strLine Is Nothing) Then
                    substrings = strLine.Split("|")
                    nuevaFila = filesLocationTbl.NewRow()
                    nuevaFila(0) = substrings(0)
                    nuevaFila(1) = substrings(1)
                    filesLocationTbl.Rows.Add(nuevaFila)
                End If
            Loop
            reader1.Close()

        Catch ex As Exception
            MsgBox("Error reading file. " & ex.Message, MsgBoxStyle.Information, "Error")

        End Try

        Return filesLocationTbl


    End Function

    Function Despliegue() As DataTable
        Dim fileName As New DataColumn
        Dim location As New DataColumn
        Dim exist As New DataColumn
        'Dim countDown As New DataColumn
        Dim checkFilesTbl As New DataTable("FILES_LOCATION")

        fileName.ColumnName = "FILE_NAME"
        fileName.DataType = System.Type.GetType("System.String")

        location.ColumnName = "LOCATION"
        location.DataType = System.Type.GetType("System.String")
        'location.MaxLength = 50

        exist.ColumnName = "NUM_DRAW2"
        exist.DataType = System.Type.GetType("System.String")
        'exist.MaxLength = 50


        checkFilesTbl.Columns.Add(fileName)
        checkFilesTbl.Columns.Add(location)
        checkFilesTbl.Columns.Add(exist)
        'drawsGamesTbl.Columns.Add(countDown)

        Despliegue = checkFilesTbl

    End Function

    Function sent_EmailWithOutAttach(ByVal smtpHostStr As String, ByVal toStr As String, ByVal subjectStr As String, ByVal bodyStr As String) As Integer
        Dim SMTPserver As New SmtpClient
        Dim mail As New MailMessage

        Try
            SMTPserver.Host = smtpHostStr
            'mail = New MailMessage
            mail.From = New MailAddress("do.not.reply@gtech-noreply.com")
            mail.To.Add(toStr) 'The Man you want to send the message to him
            mail.Subject = subjectStr
            mail.Body = bodyStr
            SMTPserver.Send(mail)
            Return 0



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1

        End Try


    End Function

    Function sent_Email(ByVal smtpHostStr As String, ByVal toStr As String, ByVal attachStr As String, ByVal subjectStr As String, ByVal bodyStr As String) As Integer
        Dim SMTPserver As New SmtpClient
        Dim mail As New MailMessage
        Dim oAttch As Attachment = New Attachment(attachStr)

        MessageBox.Show(attachStr)
        Try
            SMTPserver.Host = smtpHostStr
            'mail = New MailMessage
            mail.From = New MailAddress("do.not.reply@gtech-noreply.com")
            mail.To.Add(toStr) 'The Man you want to send the message to him
            mail.Subject = subjectStr
            mail.Body = bodyStr
            mail.Attachments.Add(oAttch)
            SMTPserver.Send(mail)
            oAttch.Dispose()
            Return 0
            'MessageBox.Show("Done!", "Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
            oAttch.Dispose()
            Return -1

        End Try


    End Function

    Function sent_EmailManyAttach(ByVal smtpHostStr As String, ByVal toStr As String, ByVal attachStr As String, ByVal subjectStr As String, ByVal bodyStr As String) As Integer

        Dim SMTPserver As New SmtpClient
        Dim mail As New MailMessage
        Dim subAttachments() As String
        Dim numAttachmentsInt As Integer
        'Dim oAttch As Attachment = New Attachment(attachStr)


        Try
            SMTPserver.Host = smtpHostStr
            'mail = New MailMessage
            mail.From = New MailAddress("do.not.reply@gtech-noreply.com")
            mail.To.Add(toStr) 'The Man you want to send the message to him
            mail.Subject = subjectStr
            mail.Body = bodyStr

            subAttachments = attachStr.Split("|")
            numAttachmentsInt = subAttachments.Length
            For i = 0 To numAttachmentsInt - 1
                mail.Attachments.Add(New Attachment(subAttachments(i)))
            Next
            SMTPserver.Send(mail)
            Return 0

        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1

        End Try

    End Function


    Function fileTransferFromCSVFile() As Integer

        Dim sftp As New Chilkat.SFtp
        Dim reader1 As StreamReader
        Dim strLine, fileNameStr, cdcOTGStr As String
        Dim monthStr, dayStr, yearStr, dateFileStr, serverStr, strPathRemoteFile, strPathFile As String
        Dim errMessageStr As String = ""
        Dim errCod, contadorInt, errCodeInt As Integer
        Dim substrings() As String
        Dim cdcStr As String
        Dim attachmentListFilesStr As String = ""
        Dim missingListFilesStr As String = ""
        Dim fecha As Date
        Dim entro As Boolean = False
        'Dim missingSubListFilesStr() As String
        Dim numMissingFilesInt As Integer = 0


        serverStr = Trim(Form1.cmbServer.Text)

        Select Case serverStr

            Case ""
                MsgBox("You must select a server", MsgBoxStyle.OkOnly, "Select a server")
                Exit Function


            Case "CAT_SFTP (10.162.33.216)"
                errCod = connectSFTP(sftp, "10.162.33.216", "22", "xfer", "Welcome1", errMessageStr)


            Case "DMZSFTP1 (10.1.6.184)"
                errCod = connectSFTP(sftp, "10.1.6.184", "22", "glxfer", "NYL3dger2018!", errMessageStr)

            Case "NYSFTP1 (10.1.5.182)"

                errCod = connectSFTP(sftp, "10.1.5.182", "22", "xfer", "Welcome1", errMessageStr)

            Case "DMZSFTP2 (10.2.6.185)"
                errCod = connectSFTP(sftp, "10.2.6.185", "22", "glxfer", "NYL3dger2018!", errMessageStr)

        End Select


        Select Case errCod

            Case 1
                MsgBox("Component expired")
                Return -1

            Case 2
                MsgBox("Connection Error ")
                Return -1

            Case 3
                MsgBox("Autentication error")
                Return -1

            Case 4
                MsgBox("Initialize error")
                Return -1

            Case 0


                Try
                    reader1 = New StreamReader("listFilesGLToTransfer.csv", Encoding.UTF7)
                    strLine = ""
                    contadorInt = 0


                    Do While Not (strLine Is Nothing)
                        strLine = reader1.ReadLine()

                        If Not (strLine Is Nothing) Then
                            substrings = strLine.Split(",")

                            If (substrings(0).Contains("*")) Then 'CDC IGT
                                cdcStr = Form1.cdcLbl.Text.PadLeft(5, "0")
                                fileNameStr = substrings(0).Replace("*", cdcStr)
                            ElseIf (substrings(0).Contains("%")) Then 'CDC IGT + 1
                                cdcStr = CStr(CInt(Form1.cdcLbl.Text) + 1)
                                cdcStr = cdcStr.PadLeft(5, "0")
                                fileNameStr = substrings(0).Replace("%", cdcStr)
                            ElseIf (substrings(0).Contains("<")) Then 'CDC IGT - 1
                                cdcStr = CStr(CInt(Form1.cdcLbl.Text) - 1)
                                cdcStr = cdcStr.PadLeft(5, "0")
                                fileNameStr = substrings(0).Replace("<", cdcStr)


                            ElseIf (substrings(0).Contains("$")) Then 'Current date format yymmdd, Format GL.

                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = Mid(CStr(fecha.Year), 3).PadLeft(2, "0")
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("$", dateFileStr)

                            ElseIf (substrings(0).Contains("(")) Then 'Current date format yyyymmdd

                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = CStr(fecha.Year)
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("(", dateFileStr)

                            ElseIf (substrings(0).Contains("-")) Then 'Yesterday format yymmdd, Format GL
                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                fecha = fecha.AddDays(-1)
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = Mid(CStr(fecha.Year), 3).PadLeft(2, "0")
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("-", dateFileStr)

                            ElseIf (substrings(0).Contains("^")) Then 'Tomorrow
                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                fecha = fecha.AddDays(1)
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = Mid(CStr(fecha.Year), 3).PadLeft(2, "0")
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("^", dateFileStr)

                            ElseIf (substrings(0).Contains("@")) Then 'CDC OTG
                                fecha = Form1.DateTimePicker1.Value
                                cdcOTGStr = CStr(returnCDC_OTG(fecha)).PadLeft(5, "0")
                                fileNameStr = substrings(0).Replace("@", cdcOTGStr)

                            ElseIf (substrings(0).Contains("?")) Then 'Previous CDC OTG
                                fecha = Form1.DateTimePicker1.Value
                                cdcOTGStr = CStr(returnCDC_OTG(fecha) - 1).PadLeft(5, "0")
                                fileNameStr = substrings(0).Replace("?", cdcOTGStr)


                            ElseIf (substrings(0).Contains("#")) Then 'Date yyyymmdd OTG
                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = CStr(fecha.Year)
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("#", dateFileStr)

                            ElseIf (substrings(0).Contains("!")) Then 'Date yesterday con formato yyyymmdd OTG
                                fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")
                                fecha = fecha.AddDays(-1)
                                monthStr = CStr(fecha.Month).PadLeft(2, "0")
                                dayStr = CStr(fecha.Day).PadLeft(2, "0")
                                yearStr = CStr(fecha.Year)
                                dateFileStr = yearStr + monthStr + dayStr
                                fileNameStr = substrings(0).Replace("!", dateFileStr)

                            Else
                                fileNameStr = substrings(0)

                            End If


                            strPathRemoteFile = substrings(1) & "/" & fileNameStr
                            strPathFile = substrings(2) & fileNameStr
                            fecha = Format(Form1.DateTimePicker1.Value, "MM/dd/yyyy")


                            'If substrings(3).ToUpper = "DAILY" Then
                            If substrings(3).ToUpper = returnDayWeek(Weekday(fecha)).ToUpper Then
                                If (sftp.FileExists(strPathRemoteFile, True) = 1) Then
                                    errCodeInt = downloadFileSFTP(sftp, strPathRemoteFile, strPathFile, errMessageStr)
                                    If errCodeInt <> 0 Then
                                        MsgBox("Download Files Problems")
                                        errCodeInt = -10
                                        Return errCodeInt
                                    End If
                                    If attachmentListFilesStr = "" Then
                                        attachmentListFilesStr = strPathFile
                                    Else
                                        attachmentListFilesStr = attachmentListFilesStr & "|" & strPathFile
                                    End If

                                Else
                                    entro = True
                                    If missingListFilesStr = "" Then
                                        missingListFilesStr = fileNameStr
                                    Else
                                        missingListFilesStr = missingListFilesStr & "," & fileNameStr
                                    End If

                                End If
                            End If
                        End If

                    Loop
                    reader1.Close()

                Catch ex As Exception
                    MsgBox("Error reading file. " & ex.Message, MsgBoxStyle.Information, "Error")
                    Return 2

                End Try
                sftp.Disconnect()

                'If entro Then
                '    errCodeInt = sent_EmailWithOutAttach("156.24.14.132", Trim(Form1.txtEmailBadGL.Text), "****Warning****  Daily GL Files Missing " & Now, "GL Files Missing: " & missingListFilesStr)
                '    If errCodeInt <> 0 Then
                '        MessageBox.Show("Daily GL Files Missing but the email cannot be sent!", "Error eMail Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        Return 1
                '    End If
                'Else
                '    If attachmentListFilesStr <> "" Then
                '        errCodeInt = sent_EmailManyAttach("156.24.14.132", Trim(Form1.txtEmailGoodGL.Text), attachmentListFilesStr, "Daily GL files transmitted -" & Now & "-", "Please see the files attached." & vbCr & vbCr & "The files were moved too, to " & Chr(34) & "\\NYAdmin\NY Accounting\GL" & Chr(34) & ", please verify.")
                '        If errCodeInt <> 0 Then
                '            MessageBox.Show("Daily GL Files were transmitted but the email cannot be sent!", "Error eMail Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '            Return 1
                '        End If
                '    End If
                'End If
                'Return 0

                If entro Then
                    errCodeInt = sent_EmailWithOutAttach("156.24.14.132", Trim(Form1.txtEmailBadGL.Text), "****Warning****  Weekly GL Files Missing " & Now, "GL Files Missing: " & missingListFilesStr & ". Verify if the files were copied from the DMZSFTP server '/home/glxfer/to_nygl' to the SFTP Server '/home/xfer/glxfer/to_nygl/transferred'")
                    If errCodeInt <> 0 Then
                        MessageBox.Show("Weekly GL Files Missing but the email cannot be sent!", "Error eMail Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return 1
                    End If
                Else
                    If attachmentListFilesStr <> "" Then
                        errCodeInt = sent_EmailManyAttach("156.24.14.132", Trim(Form1.txtEmailGoodGL.Text), attachmentListFilesStr, "Weekly GL files transmitted -" & Now & "-", "Please see the files attached." & vbCr & vbCr & "The files were moved too, to " & Chr(34) & "\\NYAdmin\NY Accounting\GL" & Chr(34) & ", please verify.")
                        If errCodeInt <> 0 Then
                            MessageBox.Show("Weekly GL Files were transmitted but the email cannot be sent!", "Error eMail Sent", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return 1
                        End If
                    End If
                End If
                Return 0
        End Select




    End Function

End Module
