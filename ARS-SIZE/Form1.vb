Public Class Form1
    Dim oServer As BMC.ARSystem.Server

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Date.Now.Year > 2020 Or Date.Now.Month > 9 Then
            MsgBox("Trial Period Expired! Please contact the Developer.", vbExclamation, "Unregistered Version")
            Application.Exit()
        End If

        oServer = New BMC.ARSystem.Server

        txt_Server.Text = My.Settings.Server
        txt_Port.Text = My.Settings.Port
        txt_Username.Text = My.Settings.Username
    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        Dim alForms As ArrayList

        My.Settings.Server = txt_Server.Text
        My.Settings.Port = txt_Port.Text
        My.Settings.Username = txt_Username.Text
        My.Settings.Save()

        Try
            oServer.Login(txt_Server.Text, txt_Username.Text, txt_Password.Text, "", "de_DE", "UTF-8", txt_Port.Text)
            alForms = oServer.GetListForm()
            btn_Connect.Enabled = False
            btn_disconnect.Enabled = True
            btn_getSize.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_disconnect_Click(sender As Object, e As EventArgs) Handles btn_disconnect.Click
        oServer.Logout()
        btn_Connect.Enabled = True
        btn_disconnect.Enabled = False
        btn_getSize.Enabled = False
    End Sub

    Private Sub btn_getSize_Click(sender As Object, e As EventArgs) Handles btn_getSize.Click
        Dim alForms As ArrayList
        Dim lvItem As ListViewItem
        Dim xsql As DataTable
        Dim schemaid As Integer
        Dim iCount As Integer
        Dim csv As String
        alForms = oServer.GetListForm()
        alForms.Sort()
        iCount = 0
        My.Computer.FileSystem.WriteAllText("size.csv", "NAME;SCHEMAID;TYPE;COUNT;SIZE-T;SIZE-B" & vbCrLf, True)
        For Each sFormName As String In alForms
            iCount = iCount + 1
            Me.Text = "ARS-SIZE " & iCount & "/" & alForms.Count
            If sFormName.Substring(0, Math.Min(18, sFormName.Length)) <> "AR System Metadata" Then
                lvItem = New ListViewItem
                lvItem.Text = sFormName
                csv = sFormName

                xsql = oServer.GetListSQL("SELECT schemaid, schematype FROM arschema WHERE name = '" & sFormName & "'", 1)
                schemaid = xsql.Rows(0).Item(0)
                csv = csv & ";" & schemaid & ";" & xsql.Rows(0).Item(1)

                ' 1 = Regular / 2 = Join / 3 = View / 4 = Disp / 5 = Vendor / 6 = Placeholder
                If xsql.Rows(0).Item(1) = 1 Or xsql.Rows(0).Item(1) = 3 Then
                    Try
                        xsql = oServer.GetListSQL("SELECT count(*) FROM T" & schemaid, 1)
                        sFormName = xsql.Rows(0).Item(0).ToString
                        lvItem.SubItems.Add(sFormName)
                        csv = csv & ";" & sFormName
                    Catch ex As Exception
                        lvItem.SubItems.Add("---")
                        csv = csv & ";"
                    End Try

                    Try
                        xsql = oServer.GetListSQL("SELECT ROUND(SUM(bytes)/1024/1024/1024, 2) FROM (SELECT segment_name table_name, bytes FROM user_segments WHERE segment_name = 'T" & schemaid & "' AND segment_type IN ('TABLE', 'TABLE PARTITION', 'TABLE SUBPARTITION') UNION SELECT i.table_name, s.bytes FROM user_indexes i, user_segments s WHERE s.segment_name = i.index_name AND   s.segment_type IN ('INDEX', 'INDEX PARTITION', 'INDEX SUBPARTITION') AND i.table_name = 'T" & schemaid & "' UNION SELECT l.table_name, s.bytes FROM user_lobs l, user_segments s WHERE s.segment_name = l.segment_name AND   s.segment_type in ('LOBSEGMENT', 'LOB PARTITION', 'LOB SUBPARTITION') AND l.table_name = 'T" & schemaid & "' UNION SELECT l.table_name, s.bytes FROM user_lobs l, user_segments s WHERE s.segment_name = l.index_name AND   s.segment_type = 'LOBINDEX' AND l.table_name = 'T" & schemaid & "')", 1)
                        sFormName = xsql.Rows(0).Item(0).ToString
                        lvItem.SubItems.Add(sFormName)
                        csv = csv & ";" & sFormName
                    Catch ex As Exception
                        lvItem.SubItems.Add("---")
                        csv = csv & ";"
                    End Try

                    Try
                        xsql = oServer.GetListSQL("SELECT ROUND(SUM(bytes)/1024/1024/1024, 2) FROM (SELECT segment_name table_name, bytes FROM user_segments WHERE segment_name LIKE 'B" & schemaid & "C%' AND segment_type IN ('TABLE', 'TABLE PARTITION', 'TABLE SUBPARTITION') UNION SELECT i.table_name, s.bytes FROM user_indexes i, user_segments s WHERE s.segment_name = i.index_name AND   s.segment_type IN ('INDEX', 'INDEX PARTITION', 'INDEX SUBPARTITION') AND i.table_name LIKE 'B" & schemaid & "C%' UNION SELECT l.table_name, s.bytes FROM user_lobs l, user_segments s WHERE s.segment_name = l.segment_name AND   s.segment_type in ('LOBSEGMENT', 'LOB PARTITION', 'LOB SUBPARTITION') AND l.table_name LIKE 'B" & schemaid & "C%' UNION SELECT l.table_name, s.bytes FROM user_lobs l, user_segments s WHERE s.segment_name = l.index_name AND   s.segment_type = 'LOBINDEX' AND l.table_name LIKE 'B" & schemaid & "C%')", 1)
                        sFormName = xsql.Rows(0).Item(0).ToString
                        lvItem.SubItems.Add(sFormName)
                        csv = csv & ";" & sFormName
                    Catch ex As Exception
                        lvItem.SubItems.Add("---")
                        csv = csv & ";"
                    End Try


                Else
                    lvItem.SubItems.Add("---")
                    csv = csv & ";"
                    lvItem.SubItems.Add("---")
                    csv = csv & ";"
                    lvItem.SubItems.Add("---")
                    csv = csv & ";"
                End If

                lst_Forms.Items.Add(lvItem)
                My.Computer.FileSystem.WriteAllText("size.csv", csv & vbCrLf, True)

                ColumnHeader1.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                ColumnHeader2.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                ColumnHeader3.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                lst_Forms.Items(lst_Forms.Items.Count - 1).EnsureVisible()
            End If
            Application.DoEvents()
        Next
        MsgBox("Done!")
    End Sub
End Class
