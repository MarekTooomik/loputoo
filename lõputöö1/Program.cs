using NumbritePyramid;
using NimedeSkipSortFilter;
namespace lõputöö1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Sisesta tekst:");
                string sisend = Console.ReadLine();

                //txt faili asukoht 
                string failitee = @"C:\Users\opilane\Desktop\output.txt";

                StreamWriter fail = null;
                try
                {
                    fail = new StreamWriter(failitee);
                    fail.WriteLine(sisend);
                    Console.WriteLine("txt fail on tehtud!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Tekkis probleem: " + ex.Message);
                }
                finally
                {
                    if (fail != null)
                    {
                        fail.Close();
                    }
                }

                Console.ReadKey();
            }

            Class1 class1 = new Class1();
            class1.NumbritePyramid();

            Class2 class2 = new Class2();
            class2.NimedeSkipSortFilter();
        }
    }

}