namespace SitoEratostenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //n = 100
            bool[] A = new bool [101];

            for (int i = 2; i < A.Length; i++)
            {
                A[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(A.Length - 1); i++)
            {
                if (A[i] == true)
                {
                    for (int j = 2; j*i <= A.Length - 1; j++)
                    {
                        A[j*i] = false;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze [2," + (A.Length - 1) + "]:");
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] == true)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("");
        }
    }
}
