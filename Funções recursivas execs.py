#Exemplo
num = int(input('insira um número positivo desejado:'))
def ffat(n):
  if (n==1):
    return n
  else:
    f = (n * ffat(n-1))
  return f
print ('valor fatorial', ffat(num))

#serie01
num = int(input('insira um número positivo:'))
while num < 0:
  print('insira apenas valores positivos!')
  num = int(input('insira um número positivo'))
def fs01(n):
  if (n >= 100):
    return n
  else:
    s = (n + fs01(n + 1))
    return s
print('A soma dos valores até 100 é:', fs01(num))

#serie02
num = int(input('insira o enésimo número: '))
def fs02(n):
  if (n < 1):
    return n
  else:
    s = (n + fs02(n - 1))
    return s
print('O resultado é:', fs02(num))

#serie03
num = float(input('digite o enésimo número: '))
def fs03(n):
  if (n <= 1):
    return n
  else:
    s = ((n ** (-1)) + fs03(n-1))
    return s
print('o resultado é: ', fs03(num))

#serie04
def fs04(n, denominador):
  if (n < 1):
    return (n/denominador)
  else:
    return ((n/denominador) + fs04(n - 1, denominador + 1))
    
n1 = float(input('insira o numero: '))
denominador = 1
print(fs04(n1, denominador))

#serie05
def ffat(n):
  if n == 1:
    return n
  else:
    return (n * ffat(n - 1))
def fless (n):
  if n < 1:
    return n
  else:
    return (ffat(n) + fless(n - 1))
num = int(input('Insira o enésimo termo da sequência: '))
print ('O resultado é: ', fless(num))
