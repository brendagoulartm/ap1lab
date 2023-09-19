
do
{
    // Solicita o nome da pessoa ao usuário
    Console.WriteLine("Digite o nome da pessoa:");
    string nome = Console.ReadLine();

    // Solicita a idade da pessoa ao usuário
    Console.WriteLine("Digite a idade da pessoa:");
    int idade = int.Parse(Console.ReadLine());

    // Soliciae a altura da pessoa em metros ao usuário
    Console.WriteLine("Digite a altura da pessoa (em metros):");
    double altura = double.Parse(Console.ReadLine());

    // Solicita o peso da pessoa em quilogramas ao usuário
    Console.WriteLine("Digite o peso da pessoa (em quilogramas):");
    double peso = double.Parse(Console.ReadLine());

    // Calcúlo o IMC
    double imc = peso / (altura * altura);

    // Determinando a categoria de IMC
    string categoriaImc;
    if (imc < 18.5)
    {
        categoriaImc = "Abaixo do peso";
    }
    else if (imc < 24.9)
    {
        categoriaImc = "Normal";
    }
    else if (imc < 29.9)
    {
        categoriaImc = "Sobrepeso";
    }
    else
    {
        categoriaImc = "Obeso";
    }

    // Determinando a faixa etária
    string faixaEtaria;
    if (idade < 12)
    {
        faixaEtaria = "Criança";
    }
    else if (idade < 18)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade < 60)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    // Exibindo o relatório
    Console.WriteLine($"Relatório para {nome}:");
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {imc:F2} ({categoriaImc})");
    Console.WriteLine($"Faixa etária: {faixaEtaria}");

    // Perguntando ao usuário se deseja gerar um novo relatório
    Console.WriteLine("Deseja gerar um novo relatório para outra pessoa? (S/N)");
    string resposta = Console.ReadLine();
    
    // Se a resposta não for "s" (ou seja, se for diferente de "sim"), encerra o loop
    if (resposta.ToLower() != "s")
    {
        break;
    }

} while (true); // Continua pedindo informações até que o usuário decida sair

