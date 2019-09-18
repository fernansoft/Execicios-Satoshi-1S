Private Sub Exec1_Click()
Dim Lado, Area As Double
Lado = InputBox("Digite o lado")
Area = Lado * Lado
MsgBox ("A área é: ") & Area
End Sub

Private Sub Exec2_Click()
Dim Salario, Novo_salario As Double
Salario = InputBox("Digite o salário")
Novo_salario = Salario * 1.15
MsgBox ("O novo salário é: ") & Novo_salario
End Sub

Private Sub Exec3_Click()
Dim Base, Altura, Area As Double
Base = InputBox("Digite o valor da base: ")
Altura = InputBox("Digite o valor da altura")
Area = Base * Altura / 2
MsgBox ("A área é: ") & Area
End Sub

Private Sub Exec4_Click()
Dim Celsius As Integer
Dim Fahrenheit As Integer
Celsius = InputBox("Digite o valor em C°")
Fahrenheit = (9 * Celsius + 160) / 5
MsgBox ("Convertido fica: ") & Fahrenheit
End Sub

Private Sub Exec5_Click()
Dim A, B, C, Delta, X1, X2 As Double
A = InputBox("Insira o valor de A")
B = InputBox("Insira o valor de B")
C = InputBox("Insira o valor de C")
Delta = B ^ 2 - 4 * A * C
X1 = (-B + Sqr(Delta)) / 2 * A
X2 = (-B - Sqr(Delta)) / 2 * A 80
MsgBox ("As raízes são: ") & ("X1: ") & X1 & (" e X2: ") & X2
End Sub

Private Sub Exec6_Click()
Dim RecipienteX, RecipienteY, X, Y as Double
RecipienteX = inputbox("Insira o valor de X:")
RecipienteY = inputbox("Insira o valor de Y:")
X = RecipienteY
Y = RecipienteX
MsgBox("O novo valor de X é: ") & X & (" e Y é: ") & Y
End Sub

Private Sub Exec7_Click()
Dim Comprimento, Altura, Largura, Volume as Double
Comprimento = inputbox("Insira o valor do comprimento: ")
Largura = inputbox("Insira o valor da largura: ")
Altura = inputbox("Insira o valor da Altura: ")
Volume = (Largura * Comprimento) * Altura
MgsBox("O volume é: ") & Volume
End Sub

Private Sub Exec8_Click()
Dim Poupança, Rentabilidade, QntMeses as Double
Poupança = Inputbox("Insira o valor a ser investido: ")
QntMeses = Inputbox("Insira a quantidade de meses para ver a previsão: ")
Rentabilidade = (Poupança * 1,013) ^ (QntMeses)
MsgBox("O valor bruto a ser retirado é: ") & Rentabilidade
End Sub

Private Sub Exec9_Click()
Dim Num1, Num2 as Integer
Num1 = Inputbox("Insira o primeiro número:")
Num2 = Inoutbox("Insira o segundo número:")
MsgBox("A soma dos quadrados é: ") & ((Num1*Num1)+(Num2*Num2))
End Sub

Private Sub Exec10_Click()
Dim Valor1, Valor2 as Double
Valor1 = Inputbox("Insira o primeiro número:")
Valor2 = Inputbox("Insira o segundo número:")
MsgBox = ("A diferença é: ") & Valor1 - Valor2
End Sub

Private Sub Exec11_Click()
Dim Raio, Perimetro as Double
Raio = inputbox("Insira o valor do raio:")
MsgBox("O perímetro da circumferência é: ") & (2*3.14*Raio)
End Sub

Private Sub Exec12_Click()
Dim AnoNasc, AnoAtual as Double
AnoNasc = inputbox("Insira seu ano de nascimento:")
AnoAtual = inputbox("insira o ano atual:")
MsgBox("Sua idade atual é: ") & (AnoAtual - AnoNasc) & " anos"
MsgBox("Sua idade daqui à dezessete anos será de: ") & (AnoAtual-AnoNasc+17) & " anos"
End Sub

Private Sub Exec13_Click()
Dim QntAlimento as Double
QntAlimento = inputbox("Insira a quantidade, em kg, de alimento: ")
MsgBox(("O alimento irá durar: ") & (QntAlimento/0.05) & " dias")
End Sub

Private Sub Exec14_Click()
Dim Ang1, Ang2 as Integer
Ang1 = inputbox("Insira quantos graus tem o primeiro ângulo:")
Ang2 = inputbox("Insira quantos graus tem o segundo ângulo:")
MsgBox("O valor do terceiro ângulo, em graus, é: ") & (180-(Ang1+Ang2))
End Sub

Private Sub Exec15_Click()
Dim Cateto1, Carteto2, Hipotenusa as Double
Cateto1 = inputbox("Insira o valor de um dos catetos: ")
Cateto2 = inputbox("Insira o valor do segundo cateto: ")
Hipotenusa = ((Cateto1*Cateto1)+(Cateto2*Cateto2))
MsgBox("O valor da hipotenusa é: ") & "Raiz quadrada de "& Hipotenusa
End Sub

Private Sub Exec16_Click()
Dim HrsTrab, Valphr, Desconto, Dependentes, SalBrut, SalLiq, ValReceber as Double
HrsTrab = InputBox("Insira as horas trabalhadas:")
Valphr = InputBox("Insira o valor por hora:")
SalBrut = HrsTrab * Valphr
Desconto = inputbox("Insira o percentual de desconto:")
Dependentes = inputbox("Insira a quantidade de dependentes:")*100
SalLiq = SalBrut - Desconto + Dependentes
MsgBox("O salário a receber é: ") & SalLiq
End Sub

Private Sub Exec17_Click()
Dim TmpPercurso, VelMed, Deslocamento, Litros as Double
TmpPercurso = inputbox("Insira o tempo total de percurso:")
VelMed = inputbox("Insira a velocidade média da viagem:")
Deslocamento = TmpPercurso * VelMed
Litros = Deslocamento/12
MsgBox("A quantidade de litros de gasolina consumidos foi de: ") & Litros
End Sub

Private Sub Exec18_Click()
Dim Valor1, Valor2 as Integer
Valor1 = inputbox("Insira o primeiro valor: ")
Valor2 = inputbox("Insira o segundo valor: ")
If Valor1 < Valor2 Then
	MsgBox("O resultado é: ") & Valor2 - Valor1
Else MsgBox("O resultado é: ") & Valor1 - Valor2
EndIf
End Sub

Private Sub Exec19_Click()
Dim Valor1, Valor2 as Double
Valor1 = ("Insira o primeiro valor: ")
Valor2 = ("Insira o segundo valor: ")
If Valor1 < Valor2 Then
	MsgBox("O maior valor é: ") & Valor2
Else MsgBox("O maior valor é: ") & Valor1
EndIf
End Sub

Private Sub Exec20_Click()
Dim A, B, C, Delta, X1, X2 As Double
A = InputBox("Insira o valor de A")
B = InputBox("Insira o valor de B")
C = InputBox("Insira o valor de C")
Delta = B ^ 2 - 4 * A * C
X1 = (-B + Sqr(Delta)) / 2 * A
X2 = (-B - Sqr(Delta)) / 2 * A
	If Delta < 0 Then
		MsgBox ("Essa equação não possuí raízes reais!")
		Else
			If Delta = 0 Then
			MsgBox ("Essa equação possuí raízes reais iguais, sendo elas: ") & vbcrlf & ("X1: ") & X1 & vbcrlf & ("X2: ") & X2
				Else
				MsgBox ("Essa Equação possui duas raízes reais diferentes, sendo elas: ") & vbcrlf & ("X1: ") & X1 & vbcrlf & ("X2: ") & X2
			End If
	End If
End Sub

Private Sub Exec21_Click()
Dim B1 as Double
Dim B2 as Double
Dim B3 as Double
Dim B4 as Double
Dim Media As Double
B1 = InputBox("Insira sua nota referente ao primeiro bimestre:")
B2 = InputBox("Insira sua nota referente ao segundo bimestre:")
B3 = InputBox("Insira sua nota referente ao terceiro bimestre:")
B4 = InputBox("Insira sua nota referente ao quarto bimestre:")
Media = ((B1 + B2 + B3 + B4) / 4)
    If Media >= 6 Then
        MsgBox ("APROVADO")
        Else
            If Media >= 3 Then
            MsgBox ("EXAME")
                Else
                MsgBox ("RETIDO")
            End If
    End If
End Sub

Private Sub Exec22_Click()
Dim Val1
Dim Val2
Val1 = InputBox("Insira o primeiro valor:")
Val2 = InputBox("Insira o segundo valor:")
While Val2 = Val1
MsgBox ("Não é possível inserir valores iguais!")
InputBox ("Insira o segundo valor:")
Wend
If Val2 > Val1 Then
MsgBox ("Os apresentando em ordem crescente, fica:") & vbCrLf & Val1 & vbCrLf & Val2
Else
MsgBox ("Os apresentando em ordem crescente, fica:") & vbCrLf & Val2 & vbCrLf & Val1
End If
End Sub


Private Sub Exec23_Click()
Dim Val1 as Double
Dim Val2 as Double
Dim Val3 as Double
Dim Val4 as Double
Val1 = InputBox("Insira o primeiro valor:")
Val2 = InputBox(("Insira o segundo valor:") & vbCrLf & ("Maior que o primeiro"))
	While Val2 <= Val1
		MsgBox("Insira um valor maior que o primeiro")
		Val2 = InputBox(("Insira o segundo valor:") & vbCrLf & ("Maior que o primeiro"))
	Wend
Val3 = InputBox(("Insira o terceiro valor:") & vbCrLf & ("Maior que o segundo"))
	While Val3 <= Val2
		MsgBox("Insira um valor maior que o segundo")
		Val3 = (InputBox("Insira o terceiro valor:") & vbCrLf & ("Maior que o segundo"))
	Wend
Val4 = InputBox("Insira o quarto valor:")
If Val4 > Val3 Then
	MsgBox("Os valores em ordem crescente ficam:") & vbCrLf & Val1 & vbCrLf & Val2 & vbCrLf & Val3 & vbCrLf & Val4
	Else
	If Val4 > Val2 Then
		MsgBox("Os valores em ordem crescente ficam:") & vbCrLf & Val1 & vbCrLf & Val2 & vbCrLf & Val4 & vbCrLf & Val3	
		Else
		If Val4 > Val1 Then
			MsgBox("Os valores em ordem crescente ficam:") & vbCrLf & Val1 & vbCrLf & Val4 & vbCrLf & Val2 & vbCrLf & Val3
			Else
				MsgBox("Os valores em ordem crescente ficam:") & vbCrLf & Val4 & vbCrLf & Val1 & vbCrLf & Val2 & vbCrLf & Val3
		End If
	End If
End If	
End Sub

Private Sub Exec24_Click()
Dim Valor as Double
Valor = inputbox("Insira o valor:")
	If (((Valor / 2) - (Valor \ 2)) = 0) and (((Valor / 3) - (Valor \ 3)) = 0) Then
			MsgBox("O número é divisível por dois e por três!")
		Else	
		If (((Valor / 2) - (Valor \ 2)) = 0) Then
			MsgBox("O número é divisível por dois!")
			Else
			If (((Valor / 3) - (Valor \ 3)) = 0) Then
				MsgBox("O número é divisível por três!")
				Else
				MsgBox("O valor não é divisível nem por três e nem por dois!")
			End If
		End If
	End If
End Sub

Private Sub Exec25()
Dim hr_ini, min_ini, hr_fin, min_fin, HrDoJogo, Duração As Double
    hr_ini = InputBox("Horário de início! Insira a hora no formato 24h: ")
        While hr_ini > 23
            MsgBox ("Por favor, insira apenas valores positivos menores que 24!")
            hr_ini = InputBox("Horário de início! Insira a hora no formato 24h: ")
        Wend
    min_ini = InputBox("Horário de início! Insira os minutos: ")
    hr_ini = ((hr_ini * 60) + min_ini)
    hr_fin = (InputBox("Horário do fim! Insira a hora no formato 24h: "))
        While hr_fin > 23
            MsgBox ("Por favor, insira apenas valores positivos menores que 24!")
            hr_fin = InputBox("Horário de fim! Insira a hora no formato 24h: ")
        Wend
    min_fin = InputBox("Horário de fim! Insira os minutos: ")
    hr_fin = ((hr_fin * 60) + min_fin)
        If hr_fin < hr_ini Then
            HrDoJogo = hr_fin + 1440 - hr_ini
            Else: HrDoJogo = hr_fin - hr_ini
        End If
    MsgBox ("O jogo durou: ") & (HrDoJogo \ 60) & "h e " & (((HrDoJogo / 60) - (HrDoJogo \ 60)) * 60) & "m"
End Sub

Private Sub Exec26_Click()
Dim Num1, Num2, Maior, Menor as Double
Num1 = inputbox("Insira o primeiro número:")
Num2 = inputbox("Insira o segundo número:")
	If Num1<Num2 Then
		Maior = Num2 and Menor = Num1
		Else Maior = Num1 and Menor = Num2
	End If
	If Maior\Menor == Maior/Menor Then
		MsgBox("O número ") & Maior & "é múltiplo de " & Menor
		Else MsgBox("O número ") & Maior & "não é múltiplo de " & Menor
	End If
End Sub

Private Sub Exec27_Click()

End Sub

Private Sub Exec28_Click()

End Sub

Private Sub Exec29_Click()

End Sub

Private Sub Exec30_Click()

End Sub
