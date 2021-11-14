using System;
using System.Collections.Generic;

/*TODO
  9 büyüklüğündeki bir listeyi 1'den 9'a kadar tekrar etmeyecek şekilde random olarak dolduran ve kaç kere random kodunun çağrıldığını
  output'a yazan kodu yazınız. Bu sorunun cevabında beklenen; random fonksiyonun minimum seviyede çağırılmasıdır.
  Random fonksiyonun çağırım adedine göre puanlama yapılacaktır.

  Varsayımlar ve kurallar:
  •İndise eklenen bir rakam tekrar edemez.
  •Eklenecek rakam hardcode olarak eklenemez.

  Örnek 1:  5,2,3,8,1,4,6,9,7 Random fonksiyonu 24 kere çalışmıştır.
  Örnek 2:  4,1,3,2,7,9,5,6,8 Random fonksiyonu 86 kere çalışmıştır.
*/

namespace ProblemBir
{
    class Program
    {
        static int RandomFunctionCallCount = 0;
        static Random randomNumber = new Random();
        static List<int> NumberList = new List<int>(9);
        static void Main(string[] args)
        {
            for (int i = 0; i < NumberList.Capacity; i++)
            {
                AddNumberToList();
            }

            foreach (int number in NumberList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine($"\r\nBu işlem için Random fonksiyonu {RandomFunctionCallCount} kez çağırılmıştır.");
            Console.ReadLine();
        }
        static void AddNumberToList()
        {
            int RandomNumber = GetRandomNumber();
            if (NumberList.Contains(RandomNumber) == false)
            {
                NumberList.Add(RandomNumber);
            }
            else
            {
                AddNumberToList();
            }
        }

        static int GetRandomNumber()
        {
            try
            {
                RandomFunctionCallCount++;
                return randomNumber.Next(1, 10);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
