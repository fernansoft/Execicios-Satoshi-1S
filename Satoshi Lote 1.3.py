#1_A e B)
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

#2_A e B)
vet2 = []
maior = 0
menor = 0
somadamedia = 0
for i in range (5):
  vet2.append(int(input('Insira o {}° número: '.format(i + 1))))
  if i == 0:
      menor = vet2[i]
  if vet2 [i] > maior:
    maior = vet2[i]
  elif vet2[i] < menor:
    menor = vet2 [i]
  somadamedia += vet2[i]
print('O maior valor é {} e o menor valor é {};\nA média dos valores inseridos é {}'.format(maior, menor, somadamedia/len(vet2)))