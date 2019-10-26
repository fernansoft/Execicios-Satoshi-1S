#Lote 1.3
#Vetores e Matrizes
#1. Criar e coletar um vetor [50] inteiro. Calcular e exibir:
#a. A média dos valores entre 10 e 200;
#b. A soma dos números ímpares.
vet1 = []
somadamedia = 0
contadormedia = 0
somadosimpares = 0
for i in range(50):
  vet1.append(int(input('digite o {}° número: '.format(i+1))))
  if vet1[i] > 10 and vet1[i] < 200:
  	somadamedia += vet1[i]
  	contadormedia += 1
  if 0 != vet1[i] % 2:
  	somadosimpares += vet1[i]
print('a) A média dos valores entre 10 e 200 é: {}'.format(somadamedia/contadormedia))
print('b) A soma dos números ímpares é: {}'.format(somadosimpares))


#2. Criar e coletar um vetor [100] inteiro e exibir:
#a. O maior e o menor valor;
#b. A média dos valores.
vet2 = []
maior = 0
menor = 0
somadamedia = 0
for i in range (100):
  vet2.append(int(input('Insira o {}° número: '.format(i + 1))))
  if i == 0:
      menor = vet2[i]
  if vet2 [i] > maior:
    maior = vet2[i]
  elif vet2[i] < menor:
    menor = vet2 [i]
  somadamedia += vet2[i]
print('O maior valor é {} e o menor valor é {};\nA média dos valores inseridos é {}'.format(maior, menor, somadamedia/len(vet2)))


#3. Criar e coletar valores inteiros nos vetores VT1[3] e VT2[3]. Concatenar esses valores em um 3º vetor (VT3[6]) e mostrar os seus dados. P. ex:
#VT1| 1| 2| 3| |VT2| 4| 5| 6| |VT3| 1| 2| 3| 4| 5| 6
vet1 = []
vet2 = []
vet3 = []
for i in range (3):
  vet1.append(int(input('Insira o {}° número da primeira sequência: '.format(i+1))))
for i in range (3):
  vet2.append(int(input('Insira o {}° número da segunda sequência: '.format(i+1))))
for i in range (6):
  if i < 3:
    vet3.append(vet1[i])
  elif i > 2:
    r = i - 3
    vet3.append(vet2[r])
print(vet3[0:])


#4. Criar e coletar em um vetor [30] real, calcular e exibir:
#a. A média do grupo;
#b. A quantidade de notas acima do média;
#c. As posições dos valores abaixo da média do grupo.
vet = []
vetposicoesabaixodamedia = []
somadamedia = 0
contadormedia = 0
contadoracimadamedia = 0
#receber os valores do vetor e calcular a média
for i in range (5):
  vet.append(int(input('Insira o {}° número: '.format(i+1))))
  somadamedia += vet[i]
  contadormedia += 1
media = somadamedia / contadormedia
#calcular quantos estão abaixo da média
for i in range (5):
  if vet[i] > media:
    contadoracimadamedia += 1
  elif vet[i] < media:
    vetposicoesabaixodamedia.append(i)
print('A média do grupo é: {}\nSendo {} dessas notas acima da média\nCom as seguintes posições sendo com notas abaixo da média:\n{}'.format(media, contadoracimadamedia, vetposicoesabaixodamedia[0:]))


#5. Criar e coletar em um vetor [20] inteiro. Calcule e exiba, segundo:
#10
#∑ (A[1] – A[21–1])
#i = 1"""
vet = []



6. Criar e coletar em um vetor [20] com números aleatórios. Classificar este vetor 
em ordem crescente e mostre os dados.
7. A partir do exercício 6 (vetor classificado) solicitar um valor qualquer e 
verificar a sua existência no vetor (utilizar pesquisa binária).
8. Criar e carregar uma matriz [4][3] inteiro com quantidade de produtos 
vendidos em 4 semanas. Calcular e exibir:
a. A quantidade de cada produto vendido no mês;
b. A quantidade de produtos vendidos por semana;
c. O total de produtos vendidos no mês.
