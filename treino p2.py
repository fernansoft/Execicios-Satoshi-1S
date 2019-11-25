# Exec 1 P2
from random import randint
def exec1geral():
	linha = []
	matriz = []
	def carregarmatriz(matriz, linha):
		for x in range(300):
			for y in range(300):
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
		for x in range(300):
			for y in range(300):
				if b[x][y] % 3 == 0:
					guardasoma += b[x][y]
				elif b[x][y] % 5 == 0:
					guardasoma += b[x][y]
		print('O valor da soma de todos os valores divisíveis por 3 e por 5 é: ', guardasoma)
	somadivisiveis(matriz)
exec1geral()

# Exec 2
