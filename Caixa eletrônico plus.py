# CAIXA ELETRÔNICO
# 1. Criar um menu de opções:
# Menu Principal:
#   1 – Carregar Notas
#   2 – Retirar Notas
#   3 – Estatística
#   9 – Fim
menu= 0
menu = int(input('Escolha uma opção para prosseguir:\n1 - Carregar notas\n2 - Retirar notas\n3 - Estatísticas\n9 - Fim\n>>>'))
while 1 != menu and 2 != menu and 3 != menu and 9 != menu:
	print('Não existe essa opção, favor selecionar uma das citadas no menu!')
	menu = int(input('Escolha uma opção para prosseguir:\n1 - Carregar notas\n2 - Retirar notas\n3 - Estatísticas\n9 - Fim\n>>>'))
