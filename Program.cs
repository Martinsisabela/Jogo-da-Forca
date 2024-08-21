using System;

class Forca
{
    static void Main()
    {
        string palavraSecreta = "PROGRAMACAO"; // Palavra a ser adivinhada
        string palavraOculta = new string('_', palavraSecreta.Length);
        string letrasErradas = "";
        int tentativasRestantes = 6;
        bool palavraAdivinhada = false;

        Console.WriteLine("Bem-vindo ao Jogo da Forca!");
        
        while (tentativasRestantes > 0 && !palavraAdivinhada)
        {
            Console.Clear();
            Console.WriteLine("Palavra: " + palavraOculta);
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
            Console.WriteLine("Letras erradas: " + letrasErradas);
            Console.Write("Digite uma letra: ");
            char letra = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (palavraSecreta.Contains(letra))
            {
                // Atualiza a palavra oculta com a letra correta
                char[] palavraOcultaArray = palavraOculta.ToCharArray();
                for (int i = 0; i < palavraSecreta.Length; i++)
                {
                    if (palavraSecreta[i] == letra)
                    {
                        palavraOcultaArray[i] = letra;
                    }
                }
                palavraOculta = new string(palavraOcultaArray);
                
                // Verifica se a palavra foi adivinhada
                if (!palavraOculta.Contains('_'))
                {
                    palavraAdivinhada = true;
                }
            }
            else
            {
                // Adiciona a letra errada e decrementa tentativas restantes
                if (!letrasErradas.Contains(letra))
                {
                    letrasErradas += letra + " ";
                    tentativasRestantes--;
                }
            }
        }

        // Exibe o resultado
        Console.Clear();
        if (palavraAdivinhada)
        {
            Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavraSecreta);
        }
        else
        {
            Console.WriteLine("Game Over! A palavra era: " + palavraSecreta);
        }
    }
}
