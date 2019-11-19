# CAIXA ELETRÔNICO
# 1. Criar um menu de opções:
# Menu Principal
menu= 0
menu = int(input('Escolha uma opção para prosseguir:\n1 - Carregar notas\n2 - Retirar notas\n3 - Estatísticas\n9 - Fim\n>>>'))
while 1 != menu and 2 != menu and 3 != menu and 9 != menu:
	print('Não existe essa opção, favor selecionar uma das citadas no menu!')
	menu = int(input('Escolha uma opção para prosseguir:\n1 - Carregar notas\n2 - Retirar notas\n3 - Estatísticas\n9 - Fim\n>>> '))
# 1.1.	Carregar a quantidade de notas em uma área da memória com 6 ocorrências.
def fcarregarnotas(a):
	print(menu)
	a = []
	a.append(int(input('Insira a quantidade de notas de R$100,00: ')))
	a.append(int(input('Insira a quantidade de notas de R$50,00: ')))
	a.append(int(input('Insira a quantidade de notas de R$20,00: ')))
	a.append(int(input('Insira a quantidade de notas de R$10,00: ')))
	a.append(int(input('Insira a quantidade de notas de R$05,00: ')))
	a.append(int(input('Insira a quantidade de notas de R$02,00: ')))
	# a[1] = notas de R$100,00
	# a[2] = notas de R$50,00
	# a[3] = notas de R$20,00
	# a[4] = notas de R$10,00
	# a[5] = notas de R$05,00
	# a[6] = notas de R$02,00
	print('Pronto! Agora o caixa tem:\n{} notas de R$100,00\n{} notas de R$50,00\n{} notas de R$20,00\n{} notas de R$10,00\n{} notas de R$05,00\n{} notas de R$02,00'.format(a[0], a[1], a[2], a[3], a[4], a[5]))
