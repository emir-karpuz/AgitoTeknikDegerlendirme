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
            Console.WriteLine("Lütfen giriş dizisini doğru formatta giriniz.");
            Console.Write("Input: ");
            
            string InputString = Console.ReadLine();   
            char[] InputCharArray = InputString.ToCharArray();
            List<char> CharacterTreeList = new List<char>();

            Console.WriteLine("Output: ");

            foreach (char Character in InputCharArray)
            {
                if (CharacterTreeList.Contains(Character) == false)
                {
                    CharacterTreeList.Add(Character);
                    Console.WriteLine(GetCharacterWithTreeLevel(CharacterTreeList.Count, Character));
                }
                else
                {
                    CharacterTreeList.Remove(Character);
                }
            }
            Console.ReadLine();
        }

        static string GetCharacterWithTreeLevel(int CharacterCount, char Character)
        {
            string TreeLevel = string.Empty;
            for (int i = 0; i < CharacterCount - 1; i++)
            {
                TreeLevel += "-"; 
            }
            return TreeLevel + Character;
        }
    }
}
