Module Functions

#Region "Currency Formatting and Restriction"

    Public Sub ChangeSign(ByVal mtxt As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Subtract = True Or e.KeyCode = Keys.OemMinus = True Then
            If Not mtxt.Text = "" Then
                mtxt.Text = CDbl(mtxt.Text) * -1
                If CDbl(mtxt.Text) > 0 Then
                    mtxt.SelectionStart = 0
                Else
                    mtxt.SelectionStart = 1
                End If
            End If
        End If
    End Sub 'KeyDown

    Public Sub CurrencyCheckPeriod(ByVal mtxt As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If mtxt.Text.Contains(".") = True Then
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        ElseIf mtxt.Text.Contains(".") = False And mtxt.Text.Length <= 0 Then
            e.Handled = OnlyNumeric(Asc(e.KeyChar))
        Else
            e.Handled = OnlyNumericWithPeriod(Asc(e.KeyChar))
        End If
    End Sub 'KeyPress

    Public Sub RestrictCurrency(ByVal mtxt As TextBox, ByVal e As System.EventArgs)
        If mtxt.Text.StartsWith("-") = False And mtxt.Text.Contains("-") = True Then
            mtxt.Text = mtxt.Text.Remove(0, 1)
        ElseIf mtxt.Text = "" Then
            mtxt.Text = 0
        End If
    End Sub 'TextChanged

#End Region

    Public Sub SelectTopItem(ByVal lstvw As ListView)
        lstvw.Focus()
        lstvw.TopItem.Selected = True
        lstvw.Items(0).Selected = True
        lstvw.Items(0).Focused = True
    End Sub

    Public Sub NextControlSelect(ByVal frm As Form, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter = True Then
            frm.SelectNextControl(frm.ActiveControl, True, True, True, True)
        ElseIf e.KeyCode = Keys.Escape = True Then
            frm.SelectNextControl(frm.ActiveControl, False, True, True, True)
        End If
        'url:http://www.fryan0911.com/2009/02/vbnet-use-enter-key-to-move-focus-to.html
    End Sub

#Region "Character Handling"

    Public Function OnlyNumericWithPeriod(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Or Key = 46 Then
            OnlyNumericWithPeriod = False
        Else
            OnlyNumericWithPeriod = True
        End If
        'e.Handled = OnlyNumericWithPeriodMinus(Asc(e.KeyChar))
    End Function

    Public Function OnlyCharacter(ByVal key As String) As Boolean
        If (key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or key = 8 Or key = 32 Then
            OnlyCharacter = False

        Else
            OnlyCharacter = True
            'MsgBox("enter only characters")
        End If
        'e.Handled = OnlyCharacter(Asc(e.KeyChar))
    End Function

    Public Function OnlyPeriod(ByVal key As String) As Boolean
        If (Keys.KeyCode = 45) Then
            OnlyPeriod = False
        Else
            OnlyPeriod = True
            'MsgBox("enter only characters")
        End If
        'e.Handled = OnlyPeriod(Asc(e.KeyChar))
    End Function

    Public Function SpecChar(ByVal key As String) As Boolean
        If (key >= 65 And key <= 90) Or (key >= 97 And key <= 122) Or key = 8 Or key = 32 Or key = 45 Or key = 44 Or key = 47 Or (key >= 39 And key <= 41) Then
            SpecChar = False
        Else
            SpecChar = True
            'MsgBox("enter only characters")
        End If
        'e.Handled = SpecChar(Asc(e.KeyChar))
    End Function

    Public Function OnlyNumeric(ByVal Key As String) As Boolean
        If (Key >= 48 And Key <= 57) Or Key = 8 Then
            OnlyNumeric = False
        Else
            OnlyNumeric = True
        End If
        'e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Function

    Public Function NoCharacter(ByVal Key As String) As Boolean
        'If (Key >= 48 And Key <= 57) Or Key = 8 Then
        'NoCharacter = False
        'Else
        NoCharacter = True
        'End If
        'e.Handled = NoCharacter(Asc(e.KeyChar))
    End Function

    Public Function CSQ(ByVal str)
        If IsDBNull(str) Then str = ""
        CSQ = Replace(str, "'", "''")

        'Function CSQ(byVal str)
        'If IsNull(str) Then str = ""
        'CSQ = Replace(str, "'", "''")
        'End Function

        'myvar = "Bob's Diner"

        'Sql = "INSERT INTO tablename (myvar, myvar2) VALUES ('" & CSQ(myvar) & "','" & CSQ(myvar2) & "')"
        'rs = Conn.Execute(Sql)

    End Function

#End Region

End Module
