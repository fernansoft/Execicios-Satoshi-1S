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
def fsaquedecrescente(b):
	if len(b) < 6:
		print('O caixa não possuí notas carregadas no momento! Favor carregar as notas.')
		return fcarregarnotas(b)
	valorsaque = int(input('insira o valor a ser sacado: '))
	for z in range(6):
		while valorsaque > 103 or valorsaque == 100:
			valorsaque -= 100
			n50 += 1
	while valorsaque > 53 or valorsaque == 50:
		valorsaque -= - 50
		n50 = n50 + 1
	while valorsaque > 23 or valorsaque == 20:
		valorsaque = valorsaque - 20
		n20 = n20 + 1
	while valorsaque > 13 or valorsaque == 10:
		valorsaque = valorsaque - 10
		n10 = n10 + 1
	if valorsaque == 11 or valorsaque == 13:
		valorsaque = valorsaque - 5
		n05 = n05 + 1
	if valorsaque == 6 or valorsaque == 8:
		while valorsaque >= 2:
			valorsaque = valorsaque - 2
			n02 = n02 + 1
	else:
		while valorsaque >= 5:
			valorsaque = valorsaque - 5
			n05 = n05 + 1
		while valorsaque >= 2:
			valorsaque = valorsaque - 2
			n02 = n02 + 1
	print('as notas a serem sacadas são:\n {} notas de R$50,00\n {} notas de R$20,00\n {} notas de R$10,00\n {} notas de R$05,00\n {} notas de R$02,00'.format(n50, n20, n10, n05, n02))
def fcodigodobanco(c):
#A função fcodigodobanco coleta o código do banco que o cliente tem conta.
	c = int(input('Qual o banco na qual deseja fazer o saque, digite de acordo com o código de cada um:\n1 - Banco do Brasil\n2 - Santander\n3 - Itaú\n4 - Caixa\n>>> '))
	# Limitar input do usuário para apenas os códigos dos bancos
	while c != 1 and c != 2 and c != 3 and c != 4:
		print('Banco não cadastrado! Favor digitar apenas um dos citados no menu de seleção.')
		c = int(input('Qual o banco na qual deseja fazer o saque, digite de acordo com o código de cada um:\n1 - Banco do Brasil\n2 - Santander\n3 - Itaú\n4 - Caixa\n>>> '))
def fescolhanumeronotas(d):
	# a função fescolhanumeronotas coleta informações sobre o cliente querer sacar garantindo uma nota de 20 ou duas de 10
	d = int(input('Você gostaria de garantir o saque de uma nota de R$20,00 ou duas de R$10,00?\nSe sim, escolha o código referente a opçao desejada:\n1 - Uma nota de R$20,00\n2 - Duas notas de R$10,00\n3 - Sacar sem preferência de nota\n4 - voltar para o menu'))
	while d != 1 and d != 2 and d != 3 and d != 4:
		print('Ops, opção inexistente! Favor inserir uma das opções!')
		d = int(input('Você gostaria de garantir o saque de uma nota de R$20,00 ou duas de R$10,00?\nSe sim, escolha o código referente a opção desejada:\n1 - Uma nota de R$20,00\n2 - Duas notas de R$10,00\n3 - Sacar sem preferência de nota\n4 - voltar para o menu'))
	if d == 1:
			
# 1.3. Dar a opção para o cliente escolher o valor e a quantidade de notas. P. ex.: 1 x 20, 2 x 10 
# 1.2. Solicitar que o cliente faça a retirada de valores obedecendo ao critério do maior para o menor. 
# 1.4. Caso não tenha o valor da maior cédula, disponibilizar a próxima. 
# 1.5. Se o valor a ser solicitado for maior que o saldo total do caixa, enviar a mensagem “EXCEDEU O LIMITE DO CAIXA”. 
# 1.6. Solicitar até 100 retiradas ou até não haver mais notas. 
# 1.8. No final, exibir a estatística, separada por bancos, com: 
# 1.8.1. O maior e o menor valor sacado; 1.8.2. A média dos saques; 1.8.3. Valor total dos saques; 1.8.4. Valor das sobras dos caixas.

# Cada linha da matriz será representada por um banco, 1 Banco do Brasil, 2 Santander, 3 Itaú e 4 Caixa
# for linha in range(4):
# 	# cada coluna representará um dado estatístico de cada banco!
# 	for coluna in range(5)