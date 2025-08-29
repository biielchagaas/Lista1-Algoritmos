using System;
class Lista
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 1: \n");

        //Ex 1
        Console.WriteLine("Informe o número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"O quadrado de {num} é: {Math.Pow(num, 2)}.\n");

        Console.WriteLine("Exercício 2: \n");

        //Ex 2
        Console.WriteLine("Informe o valor pago: ");
        double valorPago = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor do produto: ");
        double valorProduto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"O troco é: {valorPago - valorProduto}.\n");

        Console.WriteLine("Exercício 3: \n");

        //Ex 3
        Console.WriteLine("Informe o valor de A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A soma de A + B é: {A + B}.");
        Console.WriteLine($"A subtração de A - B é: {A - B}.");
        Console.WriteLine($"A multiplicação de A * B é: {A * B}.\n");

        Console.WriteLine("Exercício 4: \n");

        //Ex 4
        Console.WriteLine("Informe a largura do terreno: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a comprimento do terreno: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"A área do terreno é: {largura * comprimento}m².\n");

        Console.WriteLine("Exercício 5: \n");

        //Ex 5
        Console.WriteLine("Informe sua idade em anos: ");
        int idadeAnos = Convert.ToInt32(Console.ReadLine());
        int dias = idadeAnos * 365;
        int horas = dias * 24;
        int minutos = horas * 60;
        Console.WriteLine($"Você viveu aproximadamente {dias} dias, {horas} horas e {minutos} minutos.\n");

        Console.WriteLine("Exercício 6: \n");

        //Ex 6
        Console.WriteLine("Informe o valor da prestação: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a taxa de juros (em %): ");
        double taxa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o número de dias em atraso: ");
        int diasAtraso = Convert.ToInt32(Console.ReadLine());

        double prestacao = valor + (valor / 100 * taxa / 30 * diasAtraso);
        Console.WriteLine($"O valor da prestação em atraso é: {prestacao}.\n");

        Console.WriteLine("Exercício 7: \n");

        //Ex 7
        Console.WriteLine("Informe o valor de A: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor de B: ");
        B = Convert.ToInt32(Console.ReadLine());

        int temp = A;
        A = B;
        B = temp;

        Console.WriteLine($"Valores trocados: A = {A}, B = {B}.\n");

        Console.WriteLine("Exercício 8: \n");

        //Ex 8
        Console.WriteLine("Informe quantos quilômetros o veículo faz com 1 litro de gasolina: ");
        double kmPorLitro = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a distância da viagem em quilômetros: ");
        double distanciaViagem = Convert.ToDouble(Console.ReadLine());

        double litrosGastara = distanciaViagem / kmPorLitro;
        Console.WriteLine($"O veículo gastará aproximadamente {litrosGastara} litros de gasolina na viagem.");

        double autonomia = kmPorLitro * 50;
        Console.WriteLine($"A autonomia do veículo é de aproximadamente {autonomia} quilômetros sem reabastecer.\n");

        Console.WriteLine("Exercício 9: \n");

        //Ex 9
        Console.WriteLine("Informe a quantidade de pães franceses vendidos: ");
        int quantidadePao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de broas vendidas: ");
        int quantidadeBroa = Convert.ToInt32(Console.ReadLine());

        double precoPao = 0.12;
        double precoBroa = 1.50;

        double totalArrecadado = (quantidadePao * precoPao) + (quantidadeBroa * precoBroa);

        double valorPoupanca = totalArrecadado * 0.10;

        Console.WriteLine($"Total arrecadado: R$ {totalArrecadado:C2}");
        Console.WriteLine($"Valor a ser guardado na poupança: R$ {valorPoupanca:C2}.\n");

        Console.WriteLine("Exercício 10: \n");

        //Ex 10
        Console.WriteLine("Informe a quantidade de camisetas pequenas: ");
        int quantidadePequena = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de camisetas médias: ");
        int quantidadeMedia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de camisetas grandes: ");
        int quantidadeGrande = Convert.ToInt32(Console.ReadLine());

        double precoPequena = 10.00;
        double precoMedia = 12.00;
        double precoGrande = 15.00;

        totalArrecadado = (quantidadePequena * precoPequena) + (quantidadeMedia * precoMedia) + (quantidadeGrande * precoGrande);

        Console.WriteLine($"Total arrecadado: R$ {totalArrecadado:C2}.");

        Console.WriteLine("Fim da lista!!! Clique em qualquer tecla para fechar!!!");

        Console.ReadKey();
    }
}