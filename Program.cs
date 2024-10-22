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

            for (int i = 2; i < Math.Sqrt(A.Length - 1); i++)
            {
                if (A[i] == true)
                {
                    for (int j = 2; j < A.Length - 1; j++, j*=i)
                    {
                        A[j] = false;
                    }
                }
            }

            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] == true)
                {
                    Console.WriteLine(i + ": True");
                }
                else
                {
                    Console.WriteLine(i + ": False");
                }
            }
        }
    }
}
