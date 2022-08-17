class Program
    {
        static void Main(string[] args)
        {
            //SORU: a sayısının string biçimde ekrana nasıl basılır?

            int b = 0; 
            int a = 1234;
            Console.WriteLine(a.ToString()); 
            //Bu şekilde olduğunu hepimiz tahmin ediyorduk. Peki ya .ToString() metodunun altında neler yatıyor?

            //.ToString() methodunu gelin beraber yazalım.
            string[] x = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string s = "";
            byte ch = 0; 
            while (a > 0)
            {
                b = a - a / 10 * 10;
                //s = x[b] + s; //Console.WriteLine(x[b]);  BU STRING DİZİSİ İLE ÇÖZÜM YÖNTEMİ
                // 0 .. 9 
                // A 65 
                // B 66
                // 0
                ch = (byte)b;                              
                ch += (byte)'0';        //ASCII tabloyu kullanıp yapılan çözüm.
                s = (char)ch + s;
                a = a / 10;
            }
            Console.WriteLine(s);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            
            //String in Int a dönüşümü.
            string tt = "9897666";
            a = 0;
            b = 10;

            for (int i = 0; i < tt.Length; i++)
            {
                int g = tt[i] - (byte)'0';
                a = a*b + g;    
            }
            Console.WriteLine(a);
        }
    }