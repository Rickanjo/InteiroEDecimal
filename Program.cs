// Solicite que o usuário digite um valor real. Exiba separadamente os valores dos componentes inteiro e decimal do número digitado.

double valorReal;
int ComponenteInt;
double ComponenteDec;

Console.WriteLine("--- Separação de Componentes Inteiro e Decimal ---\n");

// Usuario digitar
Console.Write("Digite um valor real: "); 
valorReal = Convert.ToDouble(Console.ReadLine());

// extrair ComponenteInt
ComponenteInt = (int)valorReal;

// extrair ComponenteDec
ComponenteDec = valorReal - ComponenteInt;

// resultado
Console.WriteLine($"\n Valor Digitado: {valorReal}");
Console.WriteLine($"Componente Inteiro: {ComponenteInt}");
Console.WriteLine($"Componente Decimal: {ComponenteDec}");


