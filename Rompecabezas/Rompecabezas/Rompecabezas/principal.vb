Public Class principal
    Dim ALEATORIO As Integer
    Dim X1, X2, X3, X4, X5, X6, X7, X8, X9 As Integer
    Dim Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9 As Integer
    Dim Z1, Z2, Z3, Z4, Z5, Z6, Z7, Z8, Z9 As Integer
    Dim TEMP_X, TEMP_Y As Integer
    Dim alto As Int64
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True

        '--------------------------BOTON 1-----------------------------

        Randomize()
        ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
        Select Case ALEATORIO
            Case 1
                Button1.Location = New Point(12, 12)
                X1 = 12
                Y1 = 12
                Z1 = 1
            Case 2
                Button1.Location = New Point(138, 12)
                X1 = 138
                Y1 = 12
                Z1 = 2
            Case 3
                Button1.Location = New Point(264, 12)
                X1 = 264
                Y1 = 12
                Z1 = 3
            Case 4
                Button1.Location = New Point(12, 138)
                X1 = 12
                Y1 = 138
                Z1 = 4
            Case 5
                Button1.Location = New Point(138, 138)
                X1 = 138
                Y1 = 138
                Z1 = 5
            Case 6
                Button1.Location = New Point(264, 138)
                X1 = 264
                Y1 = 138
                Z1 = 6
            Case 7
                Button1.Location = New Point(12, 264)
                X1 = 12
                Y1 = 264
                Z1 = 7
            Case 8
                Button1.Location = New Point(138, 264)
                X1 = 138
                Y1 = 264
                Z1 = 8
            Case 9
                Button1.Location = New Point(264, 264)
                X1 = 264
                Y1 = 264
                Z1 = 9
        End Select

        Z2 = Z1
        '-----------------BOTON 2-----------------------

        While Z2 = Z1
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button2.Location = New Point(12, 12)
                    X2 = 12
                    Y2 = 12
                    Z2 = 1
                Case 2
                    Button2.Location = New Point(138, 12)
                    X2 = 138
                    Y2 = 12
                    Z2 = 2
                Case 3
                    Button2.Location = New Point(264, 12)
                    X2 = 264
                    Y2 = 12
                    Z2 = 3
                Case 4
                    Button2.Location = New Point(12, 138)
                    X2 = 12
                    Y2 = 138
                    Z2 = 4
                Case 5
                    Button2.Location = New Point(138, 138)
                    X2 = 138
                    Y2 = 138
                    Z2 = 5
                Case 6
                    Button2.Location = New Point(264, 138)
                    X2 = 264
                    Y2 = 138
                    Z2 = 6
                Case 7
                    Button2.Location = New Point(12, 264)
                    X2 = 12
                    Y2 = 264
                    Z2 = 7
                Case 8
                    Button2.Location = New Point(138, 264)
                    X2 = 138
                    Y2 = 264
                    Z2 = 8
                Case 9
                    Button2.Location = New Point(264, 264)
                    X2 = 264
                    Y2 = 264
                    Z2 = 9
            End Select
        End While

        '----------------BOTON 3------------------
        Z3 = Z1

        While Z3 = Z1 Or Z3 = Z2
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button3.Location = New Point(12, 12)
                    X3 = 12
                    Y3 = 12
                    Z3 = 1
                Case 2
                    Button3.Location = New Point(138, 12)
                    X3 = 138
                    Y3 = 12
                    Z3 = 2
                Case 3
                    Button3.Location = New Point(264, 12)
                    X3 = 264
                    Y3 = 12
                    Z3 = 3
                Case 4
                    Button3.Location = New Point(12, 138)
                    X3 = 12
                    Y3 = 138
                    Z3 = 4
                Case 5
                    Button3.Location = New Point(138, 138)
                    X3 = 138
                    Y3 = 138
                    Z3 = 5
                Case 6
                    Button3.Location = New Point(264, 138)
                    X3 = 264
                    Y3 = 138
                    Z3 = 6
                Case 7
                    Button3.Location = New Point(12, 264)
                    X3 = 12
                    Y3 = 264
                    Z3 = 7
                Case 8
                    Button3.Location = New Point(138, 264)
                    X3 = 138
                    Y3 = 264
                    Z3 = 8
                Case 9
                    Button3.Location = New Point(264, 264)
                    X3 = 264
                    Y3 = 264
                    Z3 = 9
            End Select
        End While
        '----------------BOTON 4------------------
        Z4 = Z1

        While Z4 = Z1 Or Z4 = Z2 Or Z4 = Z3
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button4.Location = New Point(12, 12)
                    X4 = 12
                    Y4 = 12
                    Z4 = 1
                Case 2
                    Button4.Location = New Point(138, 12)
                    X4 = 138
                    Y4 = 12
                    Z4 = 2
                Case 3
                    Button4.Location = New Point(264, 12)
                    X4 = 264
                    Y4 = 12
                    Z4 = 3
                Case 4
                    Button4.Location = New Point(12, 138)
                    X4 = 12
                    Y4 = 138
                    Z4 = 4
                Case 5
                    Button4.Location = New Point(138, 138)
                    X4 = 138
                    Y4 = 138
                    Z4 = 5
                Case 6
                    Button4.Location = New Point(264, 138)
                    X4 = 264
                    Y4 = 138
                    Z4 = 6
                Case 7
                    Button4.Location = New Point(12, 264)
                    X4 = 12
                    Y4 = 264
                    Z4 = 7
                Case 8
                    Button4.Location = New Point(138, 264)
                    X4 = 138
                    Y4 = 264
                    Z4 = 8
                Case 9
                    Button4.Location = New Point(264, 264)
                    X4 = 264
                    Y4 = 264
                    Z4 = 9
            End Select
        End While

        '----------------BOTON 5------------------
        Z5 = Z1

        While Z5 = Z1 Or Z5 = Z2 Or Z5 = Z3 Or Z5 = Z4
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button5.Location = New Point(12, 12)
                    X5 = 12
                    Y5 = 12
                    Z5 = 1
                Case 2
                    Button5.Location = New Point(138, 12)
                    X5 = 138
                    Y5 = 12
                    Z5 = 2
                Case 3
                    Button5.Location = New Point(264, 12)
                    X5 = 264
                    Y5 = 12
                    Z5 = 3
                Case 4
                    Button5.Location = New Point(12, 138)
                    X5 = 12
                    Y5 = 138
                    Z5 = 4
                Case 5
                    Button5.Location = New Point(138, 138)
                    X5 = 138
                    Y5 = 138
                    Z5 = 5
                Case 6
                    Button5.Location = New Point(264, 138)
                    X5 = 264
                    Y5 = 138
                    Z5 = 6
                Case 7
                    Button5.Location = New Point(12, 264)
                    X5 = 12
                    Y5 = 264
                    Z5 = 7
                Case 8
                    Button5.Location = New Point(138, 264)
                    X5 = 138
                    Y5 = 264
                    Z5 = 8
                Case 9
                    Button5.Location = New Point(264, 264)
                    X5 = 264
                    Y5 = 264
                    Z5 = 9
            End Select
        End While

        '----------------BOTON 6------------------
        Z6 = Z1

        While Z6 = Z1 Or Z6 = Z2 Or Z6 = Z3 Or Z6 = Z4 Or Z6 = Z5
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button6.Location = New Point(12, 12)
                    X6 = 12
                    Y6 = 12
                    Z6 = 1
                Case 2
                    Button6.Location = New Point(138, 12)
                    X6 = 138
                    Y6 = 12
                    Z6 = 2
                Case 3
                    Button6.Location = New Point(264, 12)
                    X6 = 264
                    Y6 = 12
                    Z6 = 3
                Case 4
                    Button6.Location = New Point(12, 138)
                    X6 = 12
                    Y6 = 138
                    Z6 = 4
                Case 5
                    Button6.Location = New Point(138, 138)
                    X6 = 138
                    Y6 = 138
                    Z6 = 5
                Case 6
                    Button6.Location = New Point(264, 138)
                    X6 = 264
                    Y6 = 138
                    Z6 = 6
                Case 7
                    Button6.Location = New Point(12, 264)
                    X6 = 12
                    Y6 = 264
                    Z6 = 7
                Case 8
                    Button6.Location = New Point(138, 264)
                    X6 = 138
                    Y6 = 264
                    Z6 = 8
                Case 9
                    Button6.Location = New Point(264, 264)
                    X6 = 264
                    Y6 = 264
                    Z6 = 9
            End Select
        End While

        '----------------BOTON 7------------------
        Z7 = Z1

        While Z7 = Z1 Or Z7 = Z2 Or Z7 = Z3 Or Z7 = Z4 Or Z7 = Z5 Or Z7 = Z6
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button7.Location = New Point(12, 12)
                    X7 = 12
                    Y7 = 12
                    Z7 = 1
                Case 2
                    Button7.Location = New Point(138, 12)
                    X7 = 138
                    Y7 = 12
                    Z7 = 2
                Case 3
                    Button7.Location = New Point(264, 12)
                    X7 = 264
                    Y7 = 12
                    Z7 = 3
                Case 4
                    Button7.Location = New Point(12, 138)
                    X7 = 12
                    Y7 = 138
                    Z7 = 4
                Case 5
                    Button7.Location = New Point(138, 138)
                    X7 = 138
                    Y7 = 138
                    Z7 = 5
                Case 6
                    Button7.Location = New Point(264, 138)
                    X7 = 264
                    Y7 = 138
                    Z7 = 6
                Case 7
                    Button7.Location = New Point(12, 264)
                    X7 = 12
                    Y7 = 264
                    Z7 = 7
                Case 8
                    Button7.Location = New Point(138, 264)
                    X7 = 138
                    Y7 = 264
                    Z7 = 8
                Case 9
                    Button7.Location = New Point(264, 264)
                    X7 = 264
                    Y7 = 264
                    Z7 = 9
            End Select
        End While

        '----------------BOTON 8------------------
        Z8 = Z1

        While Z8 = Z1 Or Z8 = Z2 Or Z8 = Z3 Or Z8 = Z4 Or Z8 = Z5 Or Z8 = Z6 Or Z8 = Z7
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Select Case ALEATORIO
                Case 1
                    Button8.Location = New Point(12, 12)
                    X8 = 12
                    Y8 = 12
                    Z8 = 1
                Case 2
                    Button8.Location = New Point(138, 12)
                    X8 = 138
                    Y8 = 12
                    Z8 = 2
                Case 3
                    Button8.Location = New Point(264, 12)
                    X8 = 264
                    Y8 = 12
                    Z8 = 3
                Case 4
                    Button8.Location = New Point(12, 138)
                    X8 = 12
                    Y8 = 138
                    Z8 = 4
                Case 5
                    Button8.Location = New Point(138, 138)
                    X8 = 138
                    Y8 = 138
                    Z8 = 5
                Case 6
                    Button8.Location = New Point(264, 138)
                    X8 = 264
                    Y8 = 138
                    Z8 = 6
                Case 7
                    Button8.Location = New Point(12, 264)
                    X8 = 12
                    Y8 = 264
                    Z8 = 7
                Case 8
                    Button8.Location = New Point(138, 264)
                    X8 = 138
                    Y8 = 264
                    Z8 = 8
                Case 9
                    Button8.Location = New Point(264, 264)
                    X8 = 264
                    Y8 = 264
                    Z8 = 9
            End Select
        End While

        '---PARA SABER LA COLOCACION DEL ESPACIO VACIO----------

        Z9 = Z1
        While Z9 = Z1 Or Z9 = Z2 Or Z9 = Z3 Or Z9 = Z4 Or Z9 = Z5 Or Z9 = Z6 Or Z9 = Z7 Or Z9 = Z8
            Randomize()
            ALEATORIO = Int((9 - 1 + 1) * Rnd() + 1)
            Z9 = ALEATORIO
            Select Case ALEATORIO
                Case 1
                    X9 = 12
                    Y9 = 12
                    Z9 = 1
                Case 2
                    X9 = 138
                    Y9 = 12
                    Z9 = 2
                Case 3
                    X9 = 264
                    Y9 = 12
                    Z9 = 3
                Case 4

                    X9 = 12
                    Y9 = 138
                    Z9 = 4
                Case 5

                    X9 = 138
                    Y9 = 138
                    Z9 = 5
                Case 6

                    X9 = 264
                    Y9 = 138
                    Z9 = 6
                Case 7

                    X9 = 12
                    Y9 = 264
                    Z9 = 7
                Case 8

                    X9 = 138
                    Y9 = 264
                    Z9 = 8
                Case 9

                    X9 = 264
                    Y9 = 264
                    Z9 = 9
            End Select
        End While
    End Sub

    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Location = New Point(12, 12)
        Button2.Location = New Point(138, 12)
        Button3.Location = New Point(264, 12)
        Button4.Location = New Point(12, 138)
        Button5.Location = New Point(138, 138)
        Button6.Location = New Point(264, 138)
        Button7.Location = New Point(12, 264)
        Button8.Location = New Point(138, 264)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        alto = 1
        If Button1.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button1.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button1.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button1.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X1
                TEMP_Y = Y1
                X1 = X9
                Y1 = Y9
                Button1.Location = New Point(X1, Y1)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        alto = 1
        If Button2.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button2.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button2.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button2.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X2
                TEMP_Y = Y2
                X2 = X9
                Y2 = Y9
                Button2.Location = New Point(X2, Y2)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

    End Sub


    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        alto = 1
        If Button3.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button3.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button3.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button3.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X3
                TEMP_Y = Y3
                X3 = X9
                Y3 = Y9
                Button3.Location = New Point(X3, Y3)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If


    End Sub

    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        alto = 1
        If Button4.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button4.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button4.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button4.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X4
                TEMP_Y = Y4
                X4 = X9
                Y4 = Y9
                Button4.Location = New Point(X4, Y4)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

    End Sub

    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        alto = 1
        If Button5.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button5.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button5.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button5.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X5
                TEMP_Y = Y5
                X5 = X9
                Y5 = Y9
                Button5.Location = New Point(X5, Y5)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If



    End Sub

    Public Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        alto = 1
        If Button6.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button6.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button6.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button6.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X6
                TEMP_Y = Y6
                X6 = X9
                Y6 = Y9
                Button6.Location = New Point(X6, Y6)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If


    End Sub

    Public Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        alto = 1
        If Button7.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button7.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button7.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button7.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X7
                TEMP_Y = Y7
                X7 = X9
                Y7 = Y9
                Button7.Location = New Point(X7, Y7)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If


    End Sub

    Public Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        alto = 1
        If Button8.Location = New Point(12, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button8.Location = New Point(138, 12) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(264, 12) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 264 And Y9 = 138) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(12, 138) And alto = 1 Then
            If (X9 = 12 And Y9 = 12) Or (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(138, 138) And alto = 1 Then
            If (X9 = 138 And Y9 = 12) Or (X9 = 12 And Y9 = 138) Or (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If

        If Button8.Location = New Point(264, 138) And alto = 1 Then
            If (X9 = 264 And Y9 = 12) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(12, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(138, 264) And alto = 1 Then
            If (X9 = 12 And Y9 = 264) Or (X9 = 138 And Y9 = 138) Or (X9 = 264 And Y9 = 264) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If
        If Button8.Location = New Point(264, 264) And alto = 1 Then
            If (X9 = 264 And Y9 = 138) Or (X9 = 138 And Y9 = 264) Then
                TEMP_X = X8
                TEMP_Y = Y8
                X8 = X9
                Y8 = Y9
                Button8.Location = New Point(X8, Y8)
                X9 = TEMP_X
                Y9 = TEMP_Y
                alto = 2
            End If
        End If


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Secundario.Show()
        Me.Visible = False
    End Sub

End Class
