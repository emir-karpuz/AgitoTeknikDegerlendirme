using System;
using System.Collections.Generic;

/*TODO
  Belli bir formata göre hazırlanmış aşağıdaki string'den standard outputta aşağıdaki çıktıyı üreten bir kod yazılmasını bekliyoruz.

  Varsayımlar ve kurallar:
  •Verilen string'de her harf 2 defa kullanılır ve aynı 2 harf arasında kalan harfler child harflerdir.
  •Verilen stringin daima düzgün formatta verildiğini kabul ediyoruz. String formatını kontrol edilmesine gerek yok.
  •Standart outputta ağaç yapısını gösterecek şekilde bir çıktı bekliyoruz.
  •Verilen string sonsuz derinlikte bir ağaç olabilir.

  Örnek 1:  Input:  abccbdeeda
            Output:
                    a
                    -b
                    --c
                    -d
                    --e

  Örnek 2:  Input:  abccddbeea
            Output:
                    a
                    -b
                    --c
                    --d
                    -e
*/

namespace ProblemIki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ağaç yapısına çevrilmek istenen giriş dizisini doğru formatta giriniz: ");
            
            string InputString = Console.ReadLine();   
            char[] InputCharArray = InputString.ToCharArray();
            Stack<char> stack = new Stack<char>();
            List<string> ResultList = new List<string>();
            
            foreach (char character in InputCharArray)
            {
                if (stack.Contains(character))
                {
                    stack.Pop();
                    ResultList.Add(CharacterRank(stack.Count, character));
                }
                else
                {
                    stack.Push(character);
                    //Console.WriteLine(character + " eklendi.");
                }
            }
            ResultList.Reverse();
            foreach (string item in ResultList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static string CharacterRank(int Count, char Character)
        {
            string characterConvertResult = string.Empty;
            for (int i = 0; i < Count; i++)
            {
                characterConvertResult += "-"; 
            }
            return characterConvertResult + Character;
        }

    }
}
