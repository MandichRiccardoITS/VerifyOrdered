using System.ComponentModel;

namespace VerifyOrdered
{
    internal class Program
    {
        public static bool IsOrdered(int[] array, bool descending)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                if (descending)
                {
                    if (array[i] < array[i + 1])
                    {
                        return false;
                    }
                }
                else
                {
                    if (array[i] > array[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static int[] Add(int[] oldArray, int line)
        {
            int[] newArray = new int[oldArray.Length + 1];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }
            newArray[newArray.Length - 1] = line;
            return newArray;
        }
        static void Main(string[] args)
        {
            int line;
            int[] array = new int[0];
            bool popolating = true;
            do
            {
                try
                {
                    line = Int32.Parse(Input.GetString($"inserisci il {array.Length + 1}° numero (se non riconosco un numero termino il programma):"));
                    array = Add(array, line);
                }catch(FormatException)
                {
                    Console.WriteLine("input non riconosciuto, smetto di aggiungere valori all'array");
                    popolating = false;
                }
            } while (popolating);
            Console.WriteLine($"l'array è ordinato in modo crescente: {IsOrdered(array, false)}");
        }
    }
}
