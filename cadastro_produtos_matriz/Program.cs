//criando variaveis

string[,] produtos = new string[5, 5];
string pergunta = "";

int l = 0;
int c = 0;

//
//

for  (l = 0; l<= 4; l++)
{
    for (c = 0; c <= 4; c++)

    {
        if (c == 0)
        {
            pergunta = "Informe o codigo do produto:";
        }
        if (c == 1)
        {
            pergunta = "Informe a descrição do produto:";
        }
        if (c == 2)
        {
            pergunta = "Informe o tipo do produto:";
        }
        if (c == 3)
        {
            pergunta = "Informe a cor do produto:";
        }
        if (c == 4)
        {
            pergunta = "Informe o preço do produto:";
        }
        Console.WriteLine(pergunta);
        produtos[l, c] = Console.ReadLine();
    }

    



}