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
Dim Poupanca, Rentabilidade, QntMeses as Double
  Poupanca = Inputbox("Insira o valor a ser investido: ")
QntMeses = Inputbox("Insira a quantidade de meses para ver a previsão: ")
Rentabilidade = (Poupanca * 1.013) ^ (QntMeses)
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
	End If#FF0000
End Sub

Private Sub Exec25()
Dim hr_ini, min_ini, hr_fin, min_fin, HrDoJogo As Double
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
Dim Num1, Num2, Maior, Menor As Double
Num1 = InputBox("Insira o primeiro número:")
Num2 = InputBox("Insira o segundo número:")
    If Num1 = Num2 Then
		MsgBox("Os números são iguais!")
	End If
	If Num1 > Num2 Then
        Maior = Num1
        Menor = Num2
        Else
        Maior = Num2
        Menor = Num1
    End If
    If (0 = Maior Mod Menor) Then
        MsgBox (("O número ") & Maior & " é multiplo de " & Menor)
        Else
        MsgBox (("O número ") & Maior & " não é multiplo de " & Menor)
    End If
End Sub

Private Sub Exec27_Click()
Dim Voltas, Extensao, Tempo, VelMed as Double
Voltas = inputbox("Insira a quantidade de voltas:")
Extensao = inputbox("Insira a extensão do circuito em metros:")
Tempo = inputbox("Insira o tempo de duração em minutos:")
VelMed = ((Voltas * Extensao) / (Tempo*60))
Velmed = Round(VelMed, 2)
MsgBox("A sua velocidade média foi de: ") & VelMed & "m/s"
End Sub

Private Sub Exec28_Click()
Dim PrecoAt as Double
Dim	MedMensal as Integer
Dim NovoPreco as Double
MedMensal = inputbox("Insira a média de vendas mensais:")
PrecoAt = inputbox("Insira o preço atual:")
If MedMensal<500 and PrecoAt<30 Then
	NovoPreco = PrecoAt * 1.1
	Else
	If MedMensal < 1000 and PrecoAt >=30 and PrecoAt < 80 Then
		NovoPreco = PrecoAt * 1.15
		Else
		If MedMensal >= 1000 and PrecoAt >= 80 Then
			NovoPreco = PrecoAt * 0.95
			Else NovoPreco = PrecoAt
		End If
	End If
End If
MsgBox("O novo preço do produto será: ") & NovoPreco
End Sub

Private Sub Exec29_Click()
Dim Investimento, ValInvest, Rendimento As Double
Investimento = InputBox(("Insira o tipo do investimento:") & vbCrLf & ("1 = Poupança") & vbCrLf & ("2 = Renda Fixa"))
While Investimento > 2
    MsgBox ("Só é possível inserir 1 ou 2 (respectivamente Poupança e Renda Fixa)")
    Investimento = InputBox(("Insira o tipo do investimento: ") & vbCrLf & ("1 = Poupança") & vbCrLf & ("2 = Renda Fixa"))
Wend
ValInvest = InputBox("Insira qual o valor que pretende investir:")
While ValInvest < 0
    MsgBox ("Insira apenas valores positivos!")
    ValInvest = InputBox("Insira qual o valor que pretende investir:")
Wend
If Investimento = 1 Then
Rendimento = ValInvest * 1.03
    Else
    If Investimento = 2 Then
    Rendimento = ValInvest * 1.05
End If
End If
MsgBox ("O valor bruto na sua conta serà de: ") & Rendimento
End Sub

Private Sub Exec30_Click()

End Sub

Private Sub Exec31_Click()
Dim Nums, QuadradoNums, Incremento As Integer
Nums = 10
While Nums < 151
    QuadradoNums = Nums * Nums
    Incremento = Nums + 1
    Nums = Incremento
    MsgBox ("O quadrado de ") & (Incremento - 1) & (" é: ") & QuadradoNums
Wend
End Sub

Private Sub Exec32_Click()
Dim Num As Integer
Dim Fatorial As Integer
Num = InputBox("Insira o número: ")
Fatorial = Num
While Fatorial > 1
    Fatorial = Fatorial - 1
    Num = Fatorial * Num
Wend
MsgBox ("O fatorial do número é: ") & Num
End Sub

Private Sub Exe34_Click()
Dim Valor, Multiplicador, Resultado As Integer
Valor = InputBox("Insira o número desejado: ")
Multiplicador = -1
While Multiplicador < 10
    Multiplicador = Multiplicador + 1
    Resultado = Valor * Multiplicador
    MsgBox (Valor) & ("x") & (Multiplicador) & (" = ") & Resultado
    Wend
End Sub

Private Sub Exec35_Click()
Dim Num1 as Integer
Dim Num2 as Integer
Dim Maior as Integer
Dim Menor as Integer
Dim Somatoria As Integer
Num1 = InputBox("Insira o primeiro número:")
Num2 = InputBox("Insira o segundo número:")
Somatoria = 0
If Num1 < Num2 Then
    Maior = Num2
	Menor = Num1
    Else 
		Maior = Num1
		Menor = Num2
End If
If Menor Mod 2 <> 0 Then
    Menor = Menor
    Else
    If Menor Mod 2 = 0 Then
        Menor = Menor + 1
    End If
End If
While Menor <= Maior
	Somatoria = Somatoria + Menor
	Menor = Menor + 2
Wend
MsgBox ("A somatória dos números ímpares entre o maior e o menor é: ") & Somatoria
End Sub

Private Sub Exe36_Click()
Dim N As Double
Dim Den As Double
Dim Frac As Double
Dim Fat As Double
Dim FatR As Double
Dim GuarDen As Double
Dim GuarSeq As Double
Dim SomSeq As Double
N = InputBox("Insira o enésimo número:")
Den = 1
Fat = 1
FatR = 1
While Den <= N
    FatR = Fat
    While Fat > 1
        Fat = Fat - 1
        FatR = Fat * FatR
    Wend
    GuarSeq = 1 / FatR
    SomSeq = SomSeq + GuarSeq
    Den = Den + 1
    Fat = Den
Wend
MsgBox ("O resultado é: ") & SomSeq
End Sub

Private Sub Exec37_Click()
Dim N, NMU, NMD, ValSoma, LimN As Double
LimN = InputBox("Insira o enésimo número da sequência:")
N = 1
NMU = 0
NMD = 1
While N <= LimN
    ValSoma = NMU + NMD
    MsgBox ("Para N = " & N & " temos: " & NMD & " + " & NMU & " = " & ValSoma)
    N = N + 1
    NMD = NMU
    NMU = ValSoma
Wend
End Sub

Private Sub Exec38_Click()
Dim Maior As Double
Dim Menor As Double
Dim Contador As Integer
Dim UserInput As Double
Contador = 1
While Contador <= 100
    UserInput = inputbox(("Insira o ") & Contador & ("° número:"))
    While UserInput < 0
        MsgBox("Insira apenas números positivos!")
        UserInput = inputbox(("Insira o ") & Contador & ("° número:"))
    Wend
    Contador = Contador + 1
    If Menor = 0 Then
        Menor = UserInput
        Maior = UserInput
            Else
            If UserInput < Menor Then
                Menor = UserInput
                Else
                If UserInput > Maior Then
                    Maior  = UserInput
                End If
            End If
    End If
Wend
MsgBox(("Maior: ") & Maior & vbCrLf & ("Menor: ") & Menor)
End Sub

Private Sub Exec39_Click()
Dim Casa, Qnt, QntMU As Integer 
Dim GuarMult As Double
Casa = 1
Qnt = 1
QntMU = 1
While Casa <= 64
    If Casa = 1 Then
        MsgBox (("Para a casa ") & Casa & (" temos 1 grão"))
        Casa = Casa + 1
    End If
    GuarMult = Qnt * 2
    Qnt = GuarMult
    MsgBox (("Para a casa ") & Casa & (" temos ") & GuarMult & (" grãos"))
    Casa = Casa + 1
Wend
End Sub

Private Sub Exec40_Click()
Dim Num1 As Integer
Dim Num2 As Integer
Dim Menor As Integer
Dim Maior As Integer
Dim Divisores As Integer
Dim Cont As Double
Num1 = inputbox("Insira o primeiro número:")
Num2 = inputbox("Insira o segundo número:")
Divisores = 0
Cont = 1
If Num1 < Num2 Then
    Menor = Num1
    Maior = Num2
    Else
        Menor = Num2
        Maior = Num1
End If
While Menor <= Maior
    While Cont <= Menor
        If 0 = Menor Mod Cont Then
            Divisores = Divisores + 1
        End If
        Cont = Cont + 1    
    Wend
    If Divisores = 2 Then
        MsgBox(("O número ") & Menor & (" é primo!"))
    End If
    Menor = Menor + 1
    Cont = 1
    Divisores = 0
Wend
End Sub

Private Sub Exec41_Click()
Dim D1 As Integer
Dim D2 As Integer
Dim Soma As Integer
D1 = 1
D2 = 1
While D2 <= 6
    While D1 <= 6
            Soma = D1 + D2       
        If Soma = 7 Then
            MsgBox (("A soma de ") & D2 & ("+") & D1 & (" = ") & Soma)
        End If
        D1 = D1 + 1
    Wend
    D2 = D2 + 1
    D1 = 1
Wend
End Sub

Private Sub Exec42_Click()
Dim N1 As Double
Dim N2 As Double
Dim Soma As Double
Dim Div As Double
N1 = 1
N2 = 1
While N1 <= 50
    Div = N1 / N2
    Soma = Soma + Div
    MsgBox (("O ") & N1 & ("° termo, sendo: ") & N1 & ("/") & N2 & (" = ") & Soma)
    N1 = N1 + 1
    N2 = N2 + 2
Wend
End Sub

Private Sub Exec43_Click()
Dim 
End Sub