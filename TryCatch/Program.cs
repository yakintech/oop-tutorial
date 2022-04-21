using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int x = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
            }
            catch(OverflowException overflowEx)
            {
                Console.WriteLine("Büyük bir sayı girdin");

            }
            catch (Exception ex) // Hata olduğunda catch bloğuna düşecektir!
            {
                Console.WriteLine("Bir hata meydana geldi!!");
            }
            


            Console.Read();



        }
    }
}
