Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim tipoUva, tipoVino As String
        Dim litrosVino As Integer
        Dim presion As String
        Dim temperatura As String


        tipoUva = cbxTipoUva.Text
        tipoVino = cbxTipoVino.Text

        litrosVino = Val(txtCantidadVino.Text)

        If Len(cbxTipoUva.Text) = 0 Then
            MessageBox.Show("Seleccione un tipo de uva")
            Return
        End If

        If Len(cbxTipoVino.Text) = 0 Then
            MessageBox.Show("Seleccione un tipo de vino")
            Return
        End If

        If Len(txtCantidadVino.Text) = 0 Then
            MessageBox.Show("Ingrese la cantidad de litros a elaborar")
            Return
        End If




        If rbPresion1.Checked Then
            presion = "2.5 Kg/cm2"
        ElseIf rbPresion2.Checked Then
            presion = "3 Kg/cm2"
        ElseIf rbPresion3.Checked Then
            presion = "3.5 Kg/cm2"
        Else
            MessageBox.Show("Seleccion un nivel de presión")
            Return
        End If

        If rdTemperatura1.Checked Then
            temperatura = "18°C"
        ElseIf rdTemperatura2.Checked Then
            temperatura = "25°C"
        ElseIf rdTemperatura3.Checked Then
            temperatura = "30°C"
        Else
            MessageBox.Show("Seleccion una temperatura de fermentación")
            Return
        End If



        cslProceso.Text = ""

        agregarLineaProceso("Iniciando proceso")
        agregarLineaProceso("")
        agregarLineaProceso("Tipo uva: " + tipoUva)
        agregarLineaProceso("Tipo vino: " + tipoVino)
        agregarLineaProceso("Litros a producir: " + litrosVino.ToString())


        agregarLineaProceso("")
        agregarLineaProceso("")
        agregarLineaProceso("----------")
        agregarLineaProceso("Primera etapa")
        agregarLineaProceso("----------")
        agregarLineaProceso("")
        cosecharUva(tipoUva, litrosVino)



        agregarLineaProceso("")
        agregarLineaProceso("")
        agregarLineaProceso("----------")
        agregarLineaProceso("Segunda etapa")
        agregarLineaProceso("----------")
        agregarLineaProceso("")






        For i = 1 To litrosVino
            agregarLineaProceso("Usando prensa a " + presion + " para aplastamiento de la uva para el litro #" + i.ToString())
            agregarLineaProceso("")
        Next i

        agregarLineaProceso("")
        agregarLineaProceso("Proceso de prensado terminado")

        agregarLineaProceso("")
        agregarLineaProceso("")
        agregarLineaProceso("----------")
        agregarLineaProceso("Tercera etapa")
        agregarLineaProceso("----------")


        For i = 1 To litrosVino
            agregarLineaProceso("Fermentando uva a " + temperatura + " para el litro #" + i.ToString())
            agregarLineaProceso("")
        Next i

        agregarLineaProceso("Fermentación terminada")
        agregarLineaProceso("")
        agregarLineaProceso("")

        agregarLineaProceso("Proceso terminado")




    End Sub

    Private Sub agregarLineaProceso(linea As String)
        cslProceso.AppendText(linea & Environment.NewLine)
    End Sub

    Private Sub cosecharUva(tipoUva As String, litrosVino As Integer)

        Dim dias As Integer
        dias = randomNumber(litrosVino, litrosVino + 10)

        If tipoUva = "Cabernet Sauvignon" Or tipoUva = "Carignan" Or tipoUva = "Carménère" Or tipoUva = "Garnacha" Then
            agregarLineaProceso("Las uvas se tienen que importar del extranjero, se han demorado un par de días más, total días: " + (dias + 2).ToString())
        Else
            agregarLineaProceso("Importación nacional, las uvas han tardado: " + dias.ToString() + " en ser cosechadas")
        End If
    End Sub




    Private Function randomNumber(min As Integer, max As Integer) As Integer
        Return Int((max - min + 1) * Rnd() + min)
    End Function

End Class
