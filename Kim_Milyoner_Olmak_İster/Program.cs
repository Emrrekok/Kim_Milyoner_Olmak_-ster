using System.ComponentModel.Design;

int DoğruSayısı = 0;
Console.WriteLine("Bilgi yarışmamıza Hoşgeldiniz");

Console.WriteLine();
Console.WriteLine("1) Suyun kimyasal formülü nedir?");
Console.WriteLine();
Console.WriteLine("      A) H2O    B) NaCl");
Console.WriteLine("Cevap:");
string cevap1 = Console.ReadLine().ToLower();

if (cevap1 == "a")
{
    Console.WriteLine("Tebrikler Cevabınız Doğru. ");
    DoğruSayısı++;
}
else
{
    Console.WriteLine("Cevabınız Yanlış !!");
}
Console.WriteLine(" 2) Mona Lisa tablosunu kim yapmıştır?");
Console.WriteLine();
Console.WriteLine("A) Pablo Picasso   B)Leonardo da Vinci");
Console.WriteLine("Cevap:");
string cevap2 = Console.ReadLine().ToLower();
if (cevap2 == "b")
{
    Console.WriteLine("Tebrikler Cevabınız Doğru. ");
    DoğruSayısı++;
}
else
{
    Console.WriteLine("Cevabınız Yanlış !!");
}

if(DoğruSayısı == 1)
{
    Console.WriteLine("3) Eiffel Kulesi hangi ülkededir?");
    Console.WriteLine();
    Console.WriteLine("A) Japonya      B)Fransa");
    Console.WriteLine("Cevap:");
    string cevap3 = Console.ReadLine().ToLower(); 

 if (cevap3 == "b")
 {
    Console.WriteLine("Tebrikler Cevabınız Doğru. ");
    DoğruSayısı++;
 }
 else
 {
    Console.WriteLine("Cevabınız Yanlış !!");
    Console.WriteLine("KATILDIĞINIZ İÇİN TEŞEKKÜR EDERİZ BÜYÜK ÖDÜLÜ KAZANAMADINIZ.  :(  ");
    }
}
else if (DoğruSayısı == 0)
{
    Console.WriteLine("KATILDIĞINIZ İÇİN TEŞEKKÜR EDERİZ BÜYÜK ÖDÜLÜ KAZANAMADINIZ.  :(  ");

}

if ( DoğruSayısı >= 2)
 {
    Console.WriteLine("TEBRİKLER BÜYÜK ÖDÜLÜ KAZANDINIZ !! 10.000.000.000.000 TL ");
 }
