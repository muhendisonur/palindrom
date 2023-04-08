using queue;

void space(int spaceValPara)
{
    for (int i = 0; i < spaceValPara; i++)
    {
        Console.WriteLine("");
    }
}

string kelime;
char yiginCikarilan;
char kuyrukCikarilan;
int kelimeUzunluk;
bool polindrom = false;
string devamMi = "e";

while (true)
{
    if (devamMi == "h")
        break;

    space(1);
    Console.WriteLine("Kelimeyi girin: ");
    kelime = Console.ReadLine();
    kelimeUzunluk = kelime.Length;

    MyQueue kuyruk = new MyQueue(kelimeUzunluk);
    MyStack yigin = new MyStack(kelimeUzunluk);

    //kelimeleri harflere bölerek veri yapılarının içerisine aktarıyoruz.
    for (int i = 0; i < kelimeUzunluk; i++)
    {
        kuyruk.Enqueue(kelime[i]);
        yigin.Push(kelime[i]);
    }

    Console.WriteLine("Stack");
    Console.WriteLine("------------------------------------");
    yigin.Print();
    space(2);

    Console.WriteLine("Queue");
    Console.WriteLine("------------------------------------");
    kuyruk.Print();
    space(2);

    for (int i = 0; i < kelimeUzunluk; i++)
    {
        kuyrukCikarilan = kuyruk.Dequeue();
        yiginCikarilan = yigin.Pop();

        if (kuyrukCikarilan != yiginCikarilan)
        {
            polindrom = false;
        }
        else
        {
            polindrom = true;
        }
    }

    if (polindrom)
        Console.WriteLine("Kelime polindromdur!");
    else
        Console.WriteLine("Kelime polindromdur DEĞİLDİR!");

    Console.WriteLine("Tekrar denemek ister misiniz?(e/h): ");
    devamMi = Console.ReadLine();
}



