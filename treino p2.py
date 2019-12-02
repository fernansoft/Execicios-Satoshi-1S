# Exec 1 P2
linha = []
matriz = []
from random import randint
def exec1geral():
	def carregarmatriz(matriz, linha):
		for x in range(30):
			for y in range(30):
				if y == x:
					linha.append(2**y)
				else:
					linha.append(randint(1, 100))
			matriz.append(linha)
			linha = []
	carregarmatriz(matriz, linha)
	def somadivisiveis(b):
		# somar divisiveis por 3 e 5
		guardasoma = 0
		for x in range(30):
			for y in range(30):
				if b[x][y] % 3 == 0:
					guardasoma += b[x][y]
				elif b[x][y] % 5 == 0:
					guardasoma += b[x][y]
		print('O valor da soma de todos os valores divisíveis por 3 e por 5 é: ', guardasoma)
	somadivisiveis(matriz)
exec1geral()
matrizordenada = matriz[:]
aux = 0
# Exec 2
def fclassificarcrescente(matrizordenada, aux, matriz):
	for k in range(900):
		for x in range(30):
			for y in range(30):
				if x < 29 and y < 29:
					if matrizordenada[x][y] > matrizordenada[x][y+1]:
						aux = matrizordenada[x][y]
						matrizordenada[x][y] = matrizordenada[x][y+1]
						matrizordenada[x][y+1] = aux
					if matrizordenada[x][29] > matrizordenada[x+1][0]:
						aux = matrizordenada[x][29]
						matrizordenada[x][29] = matrizordenada[x+1][0]
						matrizordenada[x+1][0] = aux
				else:
					if y < 29:
						if matrizordenada[x][y] > matrizordenada[x][y+1]:
							aux = matrizordenada[x][y]
							matrizordenada[x][y] = matrizordenada[x][y+1]
							matrizordenada[x][y+1] = aux
	print(matrizordenada[0:][0:])
fclassificarcrescente(matrizordenada, aux, matriz)
