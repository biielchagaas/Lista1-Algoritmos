using static System.Console;
class Lista
{
    static void Main(string[] args)
    {
        /*
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
        double idadeAnos = Convert.ToDouble(Console.ReadLine());
        double dias = idadeAnos * 365.25;
        double horas = dias * 24;
        double minutos = horas * 60;
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
        Console.Write("Informe o consumo do veículo (km por litro): ");
        double consumo = double.Parse(Console.ReadLine());

        Console.Write("Informe a distância da viagem (em km): ");
        double distancia = double.Parse(Console.ReadLine());

        Console.Write("Informe quantos litros há no tanque atualmente: ");
        double litrosNoTanque = double.Parse(Console.ReadLine());

        double litrosNecessarios = distancia / consumo;
        double autonomia = consumo * litrosNoTanque;

        Console.WriteLine($"\nLitros necessários para a viagem: {litrosNecessarios:F2} L");
        Console.WriteLine($"Autonomia com o combustível atual: {autonomia:F2} km");

        if (litrosNecessarios <= litrosNoTanque)
        {
            Console.WriteLine("O combustível é suficiente para a viagem!");
        }
        else
        {
            Console.WriteLine("Atenção: será necessário reabastecer durante a viagem.");
        }

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

        Console.WriteLine("Fim da lista!!! Clique em qualquer tecla para fechar!!!");*/
        /*
        int valor1, valor2, soma;

        WriteLine("Digite o primeiro valor: ");
        valor1 = Convert.ToInt32(ReadLine());
        WriteLine("Digite o segundo valor: ");
        valor2 = Convert.ToInt32(ReadLine());

        soma = valor1 + valor2;

        if (soma > 10)
        {
            WriteLine(soma);
        }*/
        /*
        Write("Digite seu nome: ");
        string nome = ReadLine();
        Console.Write("Digite sua data de nascimento: ");
        DateTime dataNasc = Convert.ToDateTime(ReadLine());

        int calc = 0;
        int anoNasc = dataNasc.Year;
        int anoAtual = DateTime.Now.Year;
        bool festa = false;

        calc = anoAtual - anoNasc;

        if (calc < 18)
        {
            festa = true;
        }

        if (festa)
        {
            WriteLine($"{nome}, você pode entrar na festa!\nSeja bem vindo!");
        }*/
        /*
        Write("'M' para homem!\n'F' para mulher!\nDigite aqui: ");
        char sexo = Convert.ToChar(ReadLine().ToUpper());
        if (sexo == 'M')
        {
            WriteLine("\nSexo masculino!");
        }
        else
        {
            WriteLine("\nSexo feminino!");
        }
        */
        /*
        Write("Digite um número: ");
        int numero = Convert.ToInt32(ReadLine());
        Write("Digite outro número: ");
        int numero2 = Convert.ToInt32(ReadLine());
        int soma = numero + numero2;

        if (soma >= 10)
        {
            soma = soma - 5;
        }
        else
        {
            soma = soma + 7;
        }

        WriteLine($"\nO resultado é: {soma}");
        */
        /*
        Write("Digite o valor do produto: ");
        double valorProduto = Convert.ToDouble(ReadLine());
        Write("Digite a quantidade a ser comprada: ");
        int quantidade = Convert.ToInt32(ReadLine());
        double subTotal = valorProduto * quantidade;

        if (quantidade > 20)
        {
            subTotal = subTotal * 0.9;
        }
        else
        {
            subTotal = subTotal * 0.95;
        }

        WriteLine($"\nO valor total da compra é: R$ {subTotal:C2}");
        */
        /*
        Write("Digite um número: ");
        int numero = Convert.ToInt32(ReadLine());
        Write("Digite outro número: ");
        int numero2 = Convert.ToInt32(ReadLine());

        if (numero >= numero2)
        {
            if (numero > numero2)
            {
                WriteLine($"{numero} é maior que {numero2}!");
            }
            else
            {
                WriteLine("Os dois números são iguais!");
            }
        }
        else
        {
            WriteLine($"{numero} não é maior que {numero2}!");
        }
        */
        /*
        Write("Digite um número: ");
        int numero = Convert.ToInt32(ReadLine());
        if (numero >= 10 && numero <= 50)
        {
            WriteLine("Número Digitado é Válido");
        }
        else
        {
            WriteLine("Número Fora da Faixa");
        }*/
        /*
        Write("Digite sua idade: ");
        int idade = Convert.ToInt32(ReadLine());
        Write("Digite sua altura: ");
        double altura = Convert.ToDouble(ReadLine());

        if (idade >= 18 && altura >= 1.70)
        {
            WriteLine("Apto!");
        }
        else
        {
            WriteLine("Inapto!");
        }*/
        /*
        Write("Digite o seu sexo: ");
        string sexo = ReadLine().ToUpper();

        if (sexo == "MASCULINO" || sexo == "FEMININO")
        {
            WriteLine("Sexo Válido");
        }
        else
        {
            WriteLine("Sexo Inválido");
        }*/
        /*
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Alterar");
        Console.WriteLine("3 - Excluir");
        Write("Escolha uma opção: ");
        int opcao = Convert.ToInt32(ReadLine());

        if (opcao == 1 || opcao == 2 || opcao == 3)
        {
            Write("Opção Válida");
        }
        else
        {
            Write("Opção Inválida");
        }*/

        int CONTA = 999;
        int SENHA = 456;
        double SALDO = 100;

        inicio:

        Write("Informe o número da conta: ");
        int contaInformada = Convert.ToInt32(ReadLine());

        Write("Informe a senha: ");
        int senhaInformada = Convert.ToInt32(ReadLine());

        if (contaInformada != CONTA)
        {
            Clear();
            WriteLine("Erro: Conta inválida.");
            goto inicio;
        }
        else if (senhaInformada != SENHA)
        {
            Clear();
            WriteLine("Erro: Senha incorreta.");
            goto inicio;
        }
        else
        {
            meio:
            Write("Informe o valor a ser sacado: ");
            double valorSaque = Convert.ToDouble(ReadLine());

            if (valorSaque > SALDO)
            {
                Clear();
                WriteLine("Erro: Saldo insuficiente.");
                goto meio;
            }
            else
            {
                SALDO -= valorSaque;
                WriteLine($"Saque realizado com sucesso! Saldo atual: R$ {SALDO:C2}");
            }
        }
        WriteLine("Fim do programa! Pressione qualquer tecla para sair...");
        ReadKey();
    }
}