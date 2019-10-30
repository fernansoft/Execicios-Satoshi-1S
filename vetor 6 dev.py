vet = []
vetsorted = []
maior = 0
menor = 0
for i in range(10):
	vet.append(int(input('Insira o {}° número do vetor: '.format(i+1))))
	if i == 1:
	  menor = vet[i]
	elif vet[i] < menor:
	  menor = vet[i]
for sort in range(len(vet)):
	vetsorted.append(menor)
	for verif in range(len(vet)):
		if ((menor + 1) == (vet[verif])):
			menor = vet[verif]
		else:
			menor += 1
