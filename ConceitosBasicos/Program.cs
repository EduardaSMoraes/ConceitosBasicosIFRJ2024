// cire um programa para calcular o IMC de uma pessoa e informar o status de acordo com o IMC calculado

int opcao;

do
{
    Console.WriteLine("Informe o que deseja fazer");
    Console.WriteLine("(1) Calcular IMC");
    Console.WriteLine("(2) Jogo de Adivinhação");
    Console.WriteLine("(0) Encerrar");
    opcao=Convert.ToInt32(Console.ReadLine());
    if (opcao == 1);
    CalcularIMC();

} while (opcao != 0);
Console.WriteLine("Obrigada por sua participação");
Console.WriteLine("Programa Finalizado");

static void CalcularIMC()
{
    Console.WriteLine("Informe seu peso: ");
    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe sua altura: ");
    float altura = float.Parse(Console.ReadLine());

    float imc = peso / (altura * altura);

    Console.WriteLine($"Para o peso {peso} e a {altura} o imc calculado foi {imc:f1}");

    string status = string.Empty;
    if (imc <= 16.9)
        status = "Muito abaixo do peso";
    else if (imc <= 18.4)
        status = "Abaixo do peso";
    else if (imc <= 24.9)
        status = "Normal";
    else if (imc <= 29.9)
        status = "Acima do peso :/";
    else if (imc <= 34.9)
        status = "Obesidade Grau I";
    else if (imc <= 40)
        status = "Obesidade Grau II";
    else
        status = "Obesidade Grau III";
    Console.WriteLine($"para o IMC {imc} a classificação é {status}");
}