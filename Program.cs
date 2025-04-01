/*
Exercício Churrasco
Faça um programa que calcule a quantidade de itens necessários para um churrasco a partir da quantidade de adultos (que consomem e que não consomem bebidas alcoólicas) e de crianças.

Estime cerveja e refrigerantes de acordo com a indicação de consumo dos adultos. Estime refrigerante para todas as crianças. Estime água para todos.

Exemplo:

--- Churrasco ---

Adultos (que consomem bebidas alcoólicas).......: 5
Adultos (que não consomem bebidas alcoólicas)...: 3
Crianças........................................: 6

Carne.............: 4,4kg
Acompanhamentos...: 2,8kg
Cerveja...........: 10,0l
Refrigerante......: 4,5l
Água..............: 5,6l


*/

double carneAdulto = 400;
double carneCrianca = 200;
double cerveja = 2;
double acompanhamentosAdulto = 200;
double acompanhamentosCrianca = 200;
double refrigeranteAdulto = 500;
double refrigeranteCrianca = 500;
double aguaAdulto = 400;
double aguaCrianca = 400;

Console.WriteLine("Digite o número de adultos que consomem bebidas alcoólicas");
int qtdAdultoAlcool = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de adultos que não consomem bebidas alcoólicas");
int qtdAdulto = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de crianças");
int qtdCrianca = int.Parse(Console.ReadLine());




double qtdTotalCarne = (((qtdAdulto + qtdAdultoAlcool) * carneAdulto) + (qtdCrianca * carneCrianca)) / 1000;
double qtdTotalAcompanhamento = (((qtdAdulto + qtdAdultoAlcool) * acompanhamentosAdulto) + (qtdCrianca * acompanhamentosCrianca)) / 1000;
double qtdTotalCerveja = (qtdAdultoAlcool * cerveja);
double qtdTotalRefrigerante = ((qtdAdulto * refrigeranteAdulto) + (qtdCrianca * refrigeranteCrianca)) / 1000;
double qtdTotalAgua = (((qtdAdulto + qtdAdultoAlcool) * aguaAdulto) + (qtdCrianca * aguaCrianca)) / 1000;



Console.WriteLine("Segue os requerimentos para o churrasco:");

Console.WriteLine($"Carne:{qtdTotalCarne.ToString("F1")}kg");
Console.WriteLine($"Acompanhamentos:{qtdTotalAcompanhamento.ToString("F1")}kg");
Console.WriteLine($"Cerveja:{qtdTotalCerveja.ToString("F1")}l");
Console.WriteLine($"Refrigerante:{qtdTotalRefrigerante.ToString("F1")}l");
Console.WriteLine($"Agua:{qtdTotalAgua.ToString("F1")}l");
