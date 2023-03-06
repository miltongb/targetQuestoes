int questao;
Console.WriteLine("Digite um numero de 1 a 5 para a resposta de cada questao");
questao =int.Parse(Console.ReadLine());
switch (questao)
{
    case 1:
        questao1();

        break; 

    case 2:
        questao2();

        break;
    case 3:
        questao3();
        break;

    case 4:
            questao4();
        break;

     case 5:
        questao5();
        break;

    default:
        Console.WriteLine("Número inválido");

        break;
}


static void questao1() {
    int INDICE = 13, SOMA = 0, K = 0;

    while (K < INDICE)
    {

        K = K + 1;
            
        SOMA = SOMA + K;

    }
    Console.WriteLine((SOMA));

    }

static void questao2()
{

    int[] fibonacci = new int[144]; // Escolhi um array de 144 por ser o 11o termo da sequencia
    fibonacci[0] = 0;
    fibonacci[1] = 1;

    int num = 34; // numero escolhido, podendo ser alterado para outro até 144


    bool pertence = false;

    for (var i = 2; i < num; i++)
    {
        fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
    }

    for (var j = 0; j < fibonacci.Length; j++)
    {
        if (fibonacci[j] == num)
        {
            pertence = true;
        }
    }


    Console.WriteLine(fibonacci);
    Console.WriteLine(pertence == true ? "Número informado pertence a sequencia " : "Número informado não pertence a sequencia");


}

static void questao3()
{


    Console.WriteLine("A) 9 \n B) 128 \n C) 49 \n D) 100 \n E) 13 \n F) 200\n  ");
    //a) 1, 3, 5, 7, 9
    //b) 2, 4, 8, 16, 32, 64, 128
    //c) 0, 1, 4, 9, 16, 25, 36, 49
    //d) 4, 16, 36, 64, 100
    //e) 1, 1, 2, 3, 5, 8, 13
    //f) 2,10, 12, 16, 17, 18, 19, 200

}

static void questao4()
{

    Console.WriteLine("No momento exato do cruzamento estariam ambos na mesma distancia de ribeirao, porem milesimos de segundos após, o caminhao estará mais proximo de ribeirao \n " +
        "porque como é mais lento, e teve a pausa do pedágio, o carro por ser muito mais rapido ja esta bem mais a frente trajeto de destino dele, do que o trajeto do caminhao");
}

static void questao5()
{

    string inverter = "Target";
    char[] caracteres = inverter.ToCharArray();
    int tamanho = caracteres.Length;

    for (int i = 0; i < tamanho / 2; i++)
    {
        char temp = caracteres[i];
        caracteres[i] = caracteres[tamanho - 1 - i];
        caracteres[tamanho - 1 - i] = temp;
    }

    string invertido = new string(caracteres);
    Console.WriteLine(invertido);

}
