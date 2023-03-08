string frase;

bool EhVogal(char letra) 
{
    letra = char.ToLower(letra);
    char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'ã', 'õ', 'ê', 'ô' };

    for (int i = 0; i < vogais.Length; i++)
        if(vogais[i] == letra )
            return true;

    return false; 
}

int ContarVogais(string frase)
{
    int totalVogais = 0;

    for (int i = 0; i < frase.Length; i++)
        if (EhVogal(frase[i]))
            totalVogais++;

    return totalVogais;
}

int ContarConsoantes(string frase)
{
    int totalConsoante = frase.Length;

    for (int i = 0; i < frase.Length; i++)
        if (!char.IsLetter(frase[i]))
            totalConsoante--;

    return totalConsoante - ContarVogais(frase);
}

string AltenarCapitalizacao(string frase)
{
    char[] aux = frase.ToUpper().ToCharArray();
    for (int i = 0; i < frase.Length; i++)
        if (i % 2 != 0)
            aux[i] = frase[i];

    return new string(aux);
}

string EspelhaString(string frase)
{
    char[] chars = frase.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

Console.Write("Digite algo: ");
frase = Console.ReadLine();

Console.WriteLine($"A string possui {frase.Length} caracteres");

Console.WriteLine($"A string possui {ContarVogais(frase)} vogais");

Console.WriteLine($"A string possui {ContarConsoantes(frase)} consoantes");

Console.WriteLine($"Letras alternadas: {AltenarCapitalizacao(frase)}");

Console.WriteLine($"Espelhamento da string = {frase} | {EspelhaString(frase)}");