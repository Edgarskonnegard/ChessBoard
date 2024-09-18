/*  -------------------------------
 *  Inlämning 2, 22 September SUT24
 *  Edgar Skönnegård
 *  -------------------------------
 */
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Allows the uses of the pictures for the squares.
            Console.WriteLine("Ange mängden rader och kolumner i ditt schackbräde:");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    if ((i + j) % 2 == 0) // Checks if the index is even to get the chess pattern.
                    {
                        Console.Write("□ "); 
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }

                Console.WriteLine(); // Skips to the next row in the console.

            }

        }
    }
}
