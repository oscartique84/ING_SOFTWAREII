'contiene la clase Form1, funcion de inicio de juego, funciones que permite realizar comparaciones  

Public Class Form1
    'formulario que contiene 9 cuadros de imagen, los cuales se desplazan segun movimientos realizados por los 
    'usuarios y con condiciones especificas las cuales estan dadas en las funciones de cada duadro de imagen 
    'para asi poder organizar la imagen como se tiene el mostrario.

    Private Sub InicioJuego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'funcion que se ejecuta cuando se da clic en el bonton iniciar, organiza las imagenes en los cuadros de imagenes y organiza
        'los colores de fondo de las los cuadros de imagenes para poder comparar y desplazar.
        PictureBox1.Image = ImageList1.Images(6)
        PictureBox2.Image = ImageList1.Images(1)
        PictureBox3.Image = ImageList1.Images(5)
        PictureBox4.Image = ImageList1.Images(2)
        PictureBox6.Image = ImageList1.Images(3)
        PictureBox5.Image = ImageList1.Images(7)
        PictureBox7.Image = ImageList1.Images(8)
        PictureBox8.Image = ImageList1.Images(4)
        PictureBox9.Image = ImageList1.Images(0)

        PictureBox1.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox4.BackColor = Color.White
        PictureBox6.BackColor = Color.White
        PictureBox5.BackColor = Color.White
        PictureBox7.BackColor = Color.White
        PictureBox8.BackColor = Color.White
        PictureBox9.BackColor = Color.Black
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.  
        If PictureBox9.BackColor = Color.Black Then
            PictureBox9.Image = PictureBox8.Image
            PictureBox9.BackColor = Color.White
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.Black
        End If
        If PictureBox7.BackColor = Color.Black Then
            PictureBox7.Image = PictureBox8.Image
            PictureBox7.BackColor = Color.White
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.Black
        End If
        If PictureBox5.BackColor = Color.Black Then
            PictureBox5.Image = PictureBox8.Image
            PictureBox5.BackColor = Color.White
            PictureBox8.Image = ImageList1.Images(0)
            PictureBox8.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox6.BackColor = Color.Black Then
            PictureBox6.Image = PictureBox9.Image
            PictureBox6.BackColor = Color.White
            PictureBox9.Image = ImageList1.Images(0)
            PictureBox9.BackColor = Color.Black
        End If
        If PictureBox8.BackColor = Color.Black Then
            PictureBox8.Image = PictureBox9.Image
            PictureBox8.BackColor = Color.White
            PictureBox9.Image = ImageList1.Images(0)
            PictureBox9.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox4.BackColor = Color.Black Then
            PictureBox4.Image = PictureBox7.Image
            PictureBox4.BackColor = Color.White
            PictureBox7.Image = ImageList1.Images(0)
            PictureBox7.BackColor = Color.Black
        End If
        If PictureBox8.BackColor = Color.Black Then
            PictureBox8.Image = PictureBox7.Image
            PictureBox8.BackColor = Color.White
            PictureBox7.Image = ImageList1.Images(0)
            PictureBox7.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox1.BackColor = Color.Black Then
            PictureBox1.Image = PictureBox4.Image
            PictureBox1.BackColor = Color.White
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.Black
        End If
        If PictureBox5.BackColor = Color.Black Then
            PictureBox5.Image = PictureBox4.Image
            PictureBox5.BackColor = Color.White
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.Black
        End If
        If PictureBox7.BackColor = Color.Black Then
            PictureBox7.Image = PictureBox4.Image
            PictureBox7.BackColor = Color.White
            PictureBox4.Image = ImageList1.Images(0)
            PictureBox4.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox2.BackColor = Color.Black Then
            PictureBox2.Image = PictureBox5.Image
            PictureBox2.BackColor = Color.White
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.Black
        End If
        If PictureBox4.BackColor = Color.Black Then
            PictureBox4.Image = PictureBox5.Image
            PictureBox4.BackColor = Color.White
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.Black
        End If
        If PictureBox8.BackColor = Color.Black Then
            PictureBox8.Image = PictureBox5.Image
            PictureBox8.BackColor = Color.White
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.Black
        End If
        If PictureBox6.BackColor = Color.Black Then
            PictureBox6.Image = PictureBox5.Image
            PictureBox6.BackColor = Color.White
            PictureBox5.Image = ImageList1.Images(0)
            PictureBox5.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox3.BackColor = Color.Black Then
            PictureBox3.Image = PictureBox6.Image
            PictureBox3.BackColor = Color.White
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.Black
        End If
        If PictureBox9.BackColor = Color.Black Then
            PictureBox9.Image = PictureBox6.Image
            PictureBox9.BackColor = Color.White
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.Black
        End If
        If PictureBox5.BackColor = Color.Black Then
            PictureBox5.Image = PictureBox6.Image
            PictureBox5.BackColor = Color.White
            PictureBox6.Image = ImageList1.Images(0)
            PictureBox6.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox2.BackColor = Color.Black Then
            PictureBox2.Image = PictureBox3.Image
            PictureBox2.BackColor = Color.White
            PictureBox3.Image = ImageList1.Images(0)
            PictureBox3.BackColor = Color.Black
        End If
        If PictureBox6.BackColor = Color.Black Then
            PictureBox6.Image = PictureBox3.Image
            PictureBox6.BackColor = Color.White
            PictureBox3.Image = ImageList1.Images(0)
            PictureBox3.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox1.BackColor = Color.Black Then
            PictureBox1.Image = PictureBox2.Image
            PictureBox1.BackColor = Color.White
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.Black
        End If
        If PictureBox3.BackColor = Color.Black Then
            PictureBox3.Image = PictureBox2.Image
            PictureBox3.BackColor = Color.White
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.Black
        End If
        If PictureBox5.BackColor = Color.Black Then
            PictureBox5.Image = PictureBox2.Image
            PictureBox5.BackColor = Color.White
            PictureBox2.Image = ImageList1.Images(0)
            PictureBox2.BackColor = Color.Black
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Funcion que se ejecuta al hacer clic en el PictureBox8, los codicionales permiten realizar una comparacion entre los 
        'colores de fondo de los PictureBox y al cumplir esta condicion es asignado la imagen del antesesor.
        If PictureBox2.BackColor = Color.Black Then
            PictureBox2.Image = PictureBox1.Image
            PictureBox2.BackColor = Color.White
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox1.BackColor = Color.Black
        End If
        If PictureBox4.BackColor = Color.Black Then
            PictureBox4.Image = PictureBox1.Image
            PictureBox4.BackColor = Color.White
            PictureBox1.Image = ImageList1.Images(0)
            PictureBox1.BackColor = Color.Black
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Carga el formulario y presenta las imagenes originales y las que se van a mover asi poder dar inicio al juego.
        PictureBox1.Image = ImageList1.Images(1)
        PictureBox2.Image = ImageList1.Images(2)
        PictureBox3.Image = ImageList1.Images(3)
        PictureBox4.Image = ImageList1.Images(4)
        PictureBox6.Image = ImageList1.Images(5)
        PictureBox5.Image = ImageList1.Images(6)
        PictureBox7.Image = ImageList1.Images(7)
        PictureBox8.Image = ImageList1.Images(8)
        PictureBox9.Image = ImageList1.Images(0)
    End Sub
    'Codigo realizado por
    'JOHNNY RIVEROS
    'JUAN MARTINEZ
    'OSCAR TIQUE
    'FECHA REALIZACION 10-04-2015
    'VERSION 001
End Class
