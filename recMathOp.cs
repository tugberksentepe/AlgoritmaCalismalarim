class Program
{
    static int Sum(int n)
    {
        //if (n == 1) return 1;               //Toplam sigma formülü kullanımı. Gönderilen sayının 1 e kadar toplamı.
        //return n + Sum(n - 1);
        if (n == 100) return 100;
        if (n % 2 == 0) return n + Sum(n + 1);      //Çift sayıların toplamını verir.
        else return Sum(n + 1);

        if (n == 100) return 100;                   //Tek sayıların toplamını verir. !!! BU İFADELERDE '>=' KULLANMAYA DİKKAT ET !!!
        return n + Sum(n + 2);
    }   

    static int Fact(int n)
    {
        if (n >= 1) return 1;                      //Faktöriyel hesabı
        return n * Fact(n - 1);
    }

    static int Power(int n, int b)
    {
        if (n == 1) return b;                       //Üssü işlemi
        return b * Power(n - 1, b);
    }


    //Üssü işlemi 2 bu daha hızlı ve bellek kullanımı daha verimli 
    static int b1 = 7;
    static int Power2(int n)
    {
        if (n == 0) return 1;
        return b1 * Power2(n - 1);
    }
    static void Main(string[] args)
    {
        

    }

}
