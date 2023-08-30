using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quizName = @"
  ▄▄▄▄    ██▓ ██▓     ██▓     ██▓ ▒█████   ███▄    █  ▄▄▄       ██▓ ██▀███  ▓█████ 
▓█████▄ ▓██▒▓██▒    ▓██▒    ▓██▒▒██▒  ██▒ ██ ▀█   █ ▒████▄    ▓██▒▓██ ▒ ██▒▓█   ▀ 
▒██▒ ▄██▒██▒▒██░    ▒██░    ▒██▒▒██░  ██▒▓██  ▀█ ██▒▒██  ▀█▄  ▒██▒▓██ ░▄█ ▒▒███   
▒██░█▀  ░██░▒██░    ▒██░    ░██░▒██   ██░▓██▒  ▐▌██▒░██▄▄▄▄██ ░██░▒██▀▀█▄  ▒▓█  ▄ 
░▓█  ▀█▓░██░░██████▒░██████▒░██░░ ████▓▒░▒██░   ▓██░ ▓█   ▓██▒░██░░██▓ ▒██▒░▒████▒
░▒▓███▀▒░▓  ░ ▒░▓  ░░ ▒░▓  ░░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒  ▒▒   ▓▒█░░▓  ░ ▒▓ ░▒▓░░░ ▒░ ░
▒░▒   ░  ▒ ░░ ░ ▒  ░░ ░ ▒  ░ ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░  ▒   ▒▒ ░ ▒ ░  ░▒ ░ ▒░ ░ ░  ░
 ░    ░  ▒ ░  ░ ░     ░ ░    ▒ ░░ ░ ░ ▒     ░   ░ ░   ░   ▒    ▒ ░  ░░   ░    ░   
 ░       ░      ░  ░    ░  ░ ░      ░ ░           ░       ░  ░ ░     ░        ░  ░
      ░                                                                           
                                                                 
";
            int dogruCavablar = 0;
            int yanlisCavablar = 0;
            string[] questArray = new string[10] { "Azerbaycan'ın başkenti hangi şehirdir?", "Azerbaycan Cumhuriyeti'nin kurucusu kimdir?", "Azerbaycan'ın milli kahramanı olarak bilinen Kurtuluş Savaşı lideri", "Azerbaycan'ın en eski şehri hangisidir?", "Azerbaycan'ın milli dansı hangisidir?", "Azerbaycan'ın en yüksek dağı hangisidir?", "Azerbaycan'ın doğal gaz rezervlerinin büyük bir kısmı hangi bölgesinde bulunur?", "Azerbaycan'ın milli bayramı hangi tarihte kutlanır?", "Azerbaycan'da bulunan ünlü tarihi eserlerden biri olan 'Ateshgah Tapınağı' hangi şehirde yer almaktadır?", "Azerbaycan'ın komşularından biri olan Ermenistan ile hangi konuda çatışmalar yaşanmıştır?" };
            string[,] answerArray = new string[10, 3] { { "Bakü", "Gence", "Nahçıvan" }, { "Haydar Aliyev", "İlham Aliyev", "Mammad Amin Rasulzade" },
                { "Nizami Gencevi", "Heydar Aliyev", "Uzeyir Hacıbeyov" }, { "Şeki", "Bakü", "Gandja" }, { "Lezginka", "Semeni", "Mugam" },
                { "Şahdağ", "Bazardüzü", "Göygöl Dağı" }, { "Şeki", "Naxçıvan", "Abşeron" },
                { "28 Mayıs", "18 Ekim", "26 Aralık" }, { "Bakü", "Şamaxı", "Şeki" }, { "Dağlık Karabağ", "Naxçıvan", "Gence" } };
            string[] correctsArray = new string[10] { "Bakü", "Mammad Amin Rasulzade", "Heydar Aliyev", "Şeki", "Lezginka", "Şahdağ", "Abşeron", "28 Mayıs", "Bakü", "Dağlık Karabağ" };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(quizName);
            Console.ResetColor();
            Random random = new Random();
            for (int i = 0; i < questArray.Length; i++)
            {
                int j = random.Next(0, 3); 

                Console.WriteLine($"{i + 1}. {questArray[i]}");
                Console.WriteLine("A) " + answerArray[i, j]);
                Console.WriteLine("B) " + answerArray[i, (j + 1) % 3]); 
                Console.WriteLine("C) " + answerArray[i, (j + 2) % 3]);
                Console.WriteLine();


                Console.Write("Dogru cavabi daxil edin : ");
                string cevap = Console.ReadLine();
                if (cevap.ToUpper() == correctsArray[i].ToUpper())
                {
                    dogruCavablar++;
                  
                }
                else if (cevap.ToUpper() != correctsArray[i].ToUpper())
                {
                    yanlisCavablar++;
                   
                }
                else if (dogruCavablar < 0)
                {
                    dogruCavablar = 0;
                }
            }
            Console.WriteLine("\n=============================");
            Console.WriteLine("\nQuiz tamamlandi!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Toplam doğru cevap sayi: " + dogruCavablar);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Toplam yanlis cevap sayi: " + yanlisCavablar);
            Console.ResetColor();
            if (dogruCavablar > yanlisCavablar)
            {
                Console.WriteLine("Toplam bal: " + (dogruCavablar - yanlisCavablar)*10);
            }
            else if (dogruCavablar == 0)
            {
                Console.WriteLine("Toplam bal: 0");
            }
            else if (yanlisCavablar > dogruCavablar)
            {
                Console.WriteLine("Toplam bal: " + (yanlisCavablar - dogruCavablar) * 10);
            }
            else
            {
                Console.WriteLine("Toplam bal: 0");
            }
            Console.WriteLine("\n=============================");
        }
    }
}