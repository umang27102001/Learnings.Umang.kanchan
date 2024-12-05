namespace Arrays
{
    internal class Arrays
    {
        public void Print()
        {
            int[,] arr = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Jagged()
        {
            int[][] arr = new int[4][];
            for(int i = 0; i < 4; i++)
            {
                arr[i] = new int[i+1];
                for(int j = 0;j <= i; j++)
                {
                    arr[i][j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0;i< 4; i++)
            {
                for(int j=0;j<= i; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                    Console.WriteLine();
            }
        }
    }
}
