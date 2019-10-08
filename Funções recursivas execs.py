#Exemplo
num = int(input('insira um número positivo desejado:'))
def ffat(n):
  if (n==1):
    return n  
  else:
    f = (n * ffat(n-1))
  return f
print ('valor fatorial', ffat(num))

#Exercicio_01
num = int(input('insira um número positivo:'))
while num < 0:
  print('insira apenas valores positivos!')
  num = int(input('insira um número positivo'))
def fsum(n):
  if (n >= 100):
    return n
  else:
    s = (n + fsum(n + 1))
    return s
print('A soma dos valores até 100 é:', fsum(num))

#Exercicio_02
num = int(input('insira o enésimo número: '))
def fsumsub(n):
  if n < 1:
    return n
  else:
    s = (n + fsumsub(n - 1))
    return s
print('O resultado é:', fsumsub(num))

#Exercicio_03
num = int(input('digite o enésimo número: '))
def fsumfrac(n):
  den = 1
  if den >= n:
    return n
  else:
    s = (1 / n + fsumfrac(1/(n + 1)))
    den = den + 1
    return s
print('o resultado é: ', fsumfrac(num))
    
