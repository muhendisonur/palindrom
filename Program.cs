using queue;

string kelime;
char yiginCikarilan;
char kuyrukCikarilan;
int kelimeUzunluk;

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
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Queue");
Console.WriteLine("------------------------------------");
kuyruk.Print();
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < kelimeUzunluk-1; i++) //kuyruk son eleman yok gösteriyor yani 5 harfli bir kelimenin son işlemi sıkıntı olduğu için 4 harfli bir kelime gibi ele alıyoruz hata çıkmasın diye yoksa burası -1 olmaması lazım
{
    kuyrukCikarilan = kuyruk.Dequeue();
    yiginCikarilan = yigin.Pop();

    Console.WriteLine("Kuyruk çıkarılan: " + kuyrukCikarilan + "\nYigin çıkarılan: " + yiginCikarilan + "\n");
}


