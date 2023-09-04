using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;
// Instancia da classe pessoa
Pessoa p = new Pessoa();
Calculadora c = new Calculadora();
c.Subtrair(2, 2);
p.Apresentar();

List<string> pessoaList = new List<string>();
pessoaList.Add("Tandy");
pessoaList.Add("Helio");
pessoaList.Add("Aldilane");
pessoaList.Add("Taty");

int cont = 1;
foreach (string value in pessoaList)
{
    Console.WriteLine($"posição:{cont} - valor:{value}");
    cont++;
}
Console.WriteLine("\n");
pessoaList.Remove("Tandy");
int cont1 = 1;
foreach (string value in pessoaList)
{
    Console.WriteLine($"posição:{cont1} - valor:{value}");
    cont1++;
}
Console.WriteLine("\n");
pessoaList.Add("Tandinho");
int cont2 = 1;
foreach (string value in pessoaList)
{
    Console.WriteLine($"posição:{cont2} - valor:{value}");
    cont2++;
}


// int[] number = new int[] { 40, 3, 95, 4, 70, };

// Array.Resize(ref number, number.Length * 2);

// int[] number2 = new int[14];
// Array.Copy(number, number2, number.Length);

// for (int contador = 0; contador < number.Length; contador++)
// {
//     Console.WriteLine($"Exibir numeros, posição:{contador} - valor:{number[contador]}");
// }

// int contadorForeach = 1;
// foreach(int value in number2)
// {
//     Console.WriteLine($"Posição:{contadorForeach} - valor:{value}");
//     contadorForeach++;
// }

// Atribui o nome e idade para pessoa
// p.Nome = "Tandy";
// p.Idade = 20;
// p.Apresentar();

// Calculadora c = new Calculadora();
// c.Somar(10, 2);

// c.Subtrair(10, 5);

// p.CadastrarNoERPXYZDaEmpresa();



// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo a lista com o FOR:");
// for (int contador = 0; contador < listaString.Count; contador ++)
// {
//     Console.WriteLine($"Posição N°{contador} - {listaString[contador]}");
// }

// Console.WriteLine("\nPercorrendo a lista com o FOREACH:");
// int contadorForeach = 0;
// foreach (string value in listaString)
// {
//     Console.WriteLine($"Posição N°{contadorForeach} - {value}");
//     contadorForeach++;

// int[] nameArrayInteiros = new int[3];

// nameArrayInteiros[0] = 72;
// nameArrayInteiros[1] = 64;
// nameArrayInteiros[2] = 50;

// int [] arrayInteiroDobrado = new int[nameArrayInteiros.Length * 2];
// Array.Copy(nameArrayInteiros, arrayInteiroDobrado,nameArrayInteiros.Length);

// for (int contador = 0; contador < arrayInteiroDobrado.Length; contador++)
// {
//     Console.WriteLine($"Posicao N{contador} - {arrayInteiroDobrado[contador]}");
// }

// int[] array1 = new int[]{11,9,15,5};
// // array1[0] = 10;
// // array1[1] = 32;
// // array1[2] = 75;

// // Array.Resize(ref array1, array1.Length + 2);
// int [] array1Copy = new int[array1.Length * 2];
// Array.Copy(array1, array1Copy, array1.Length);

// for (int contador = 0; contador < array1Copy.Length; contador++)
// {
//     Console.WriteLine($"Posição number {contador} - {array1Copy[contador]}");
// }

// int contador = 0;
// foreach (int value in array1)
//     {
//         Console.WriteLine($"Posicao Number {contador} - {value}");
//         contador++;
//     }

// for(int contador = 0; contador < array1.Length; contador++)
//     {
//         Console.WriteLine($"Posição number: {contador} - {array1[contador]}");
//     }
// Array.Resize(ref nameArrayInteiros, nameArrayInteiros.Length *2);

// Console.WriteLine("Percorrendo o Array com o for:");
// for(int contador = 0; contador < nameArrayInteiros.Length; contador++)
    
// {
//     Console.WriteLine($"Posicao N {contador} - {nameArrayInteiros[contador]}");
// }


// Console.WriteLine("\nPercorrendo um Array com foreach:");
// int contadorForeach = 0;
// foreach(int valor in nameArrayInteiros)
// {
//     Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
//     contadorForeach++;
// }





























// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Tandy";
// pessoa1.Idade = 27;
// pessoa1.Apresentar();










// string opcao;
// bool exibirrMenu = true;

// while (exibirrMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opcao: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro do Cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca do Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirrMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opcao Invalida");
//             break;
//     }
// }

// Console.WriteLine("O programa se Encerrou");

// int soma = 0, number = 0;

// do
// {
//     Console.WriteLine("Digitee um numero(0 para parar)");
//     number = Convert.ToInt32(Console.ReadLine());

//     soma += number;
// } while(number != 0);

// Console.WriteLine($"Total da soma dos numeros digitados e:{soma}");




// int number = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador} Execucao: {number} x {contador} = {number * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }



// int number = 5;
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{number} x {contador} = {number * contador}");
// }

// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// numeroIncremento = numeroIncremento + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento + "\n");

// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento = numeroDecremento - 1;
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);


// Calculadora cal = new Calculadora();

// cal.Seno(30);
// cal.Coseno(30);
// cal.Tangente(30);

// cal.Potencia(4, 3);

// calculadora.Somar(11, 32);
// calculadora.Subtrair(23, 25);
// calculadora.Multiplicar(15, 5);
// calculadora.Dividir(25, 5);





// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Pedalar");
// }
// else
//     {
//         Console.WriteLine("ficar em casa");
//     }






// bool presencaMinima = true;
// double media = 5.5;



// if (presencaMinima && media >= 7)
// {
//     Console.WriteLine("Aluno Aprovado");
// }
// else
// {
//     Console.WriteLine("Aluno Reprovado");
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada nao liberada");
// }



// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
//     {
//         Console.WriteLine("Vogal");
//     }
//     else
//     {
//         Console.WriteLine("Nao e uma Vogal");
//     }

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }  
// else if (letra == "i")
// {
//     Console.WriteLine("vogal");
// }  
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }  
// else if (letra == "u")
// {
//     Console.WriteLine("vogal");
// }  
// else
// {
//     Console.WriteLine("Nao e uma vogal");
// }    

// int quantidadeEmEstoque = 3;

// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// Console.WriteLine($"Possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
//     {
//         Console.WriteLine("Venda Invalida");
//     }
// else if (possivelVenda)
//     {
//         Console.WriteLine("Venda realizada");
//     }
// else
//     { 
//     Console.WriteLine("Desculpe. Nao temos a quantidade desejada em estoque.");
//     }



// string a = "15-";

// int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);



// int inteiro = 5;

// string a = inteiro.ToString();

// Console.WriteLine(a);

// int a = Convert.ToInt32("5");
// int a = int.Parse("6");

// Console.WriteLine(a);

// int a = 11;
// int b = 22;

// int c = a + b;
// // c = c + 5;
// c /= 3;
// Console.WriteLine(c);

// // DateTime dataAtual = DateTime.Now;
// // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// // Pessoa pessoa1 = new Pessoa();
// // pessoa1.Name = "Tandy";
// // pessoa1.Idade = 27;
// // pessoa1.Apresentar();

