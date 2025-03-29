   
         // NomeCompleto - Exercício 1 da Lista 2

        Console.Write("Por favor, digite seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.Write("Agora digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"\nNome completo: {nome} {sobrenome}");
        Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");