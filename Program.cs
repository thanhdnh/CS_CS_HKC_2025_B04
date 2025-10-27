internal class Program
{
    private static void Main(string[] args)
    {
        //int[] a;
        //a = new int[5] { 2, 3, 5, 7, 1 };
        //a = new int[] { 2, 3, 5, 7, 1 };

        int num = 10;
        int[] b = new int[num];
        Random r = new Random();
        for (int i = 0; i < b.Length; i++)
            b[i] = r.Next(0, 10);

        for (int i = 0; i < b.Length; i++)
            Console.Write(b[i] + " ");

        Console.WriteLine();

        //Tính tổng các phần tử trong mảng
        int sum = 0;
        foreach(int x in b)
            sum += x;
        Console.WriteLine("Sum: " + sum);

        foreach (int x in b)
            Console.Write(x + " ");

        //Đếm số phần tử chẵn trong mảng
        int count = 0;
        for(int i=0; i<b.Length; i++)
            if (b[i] % 2 == 0)
                count++;
        Console.WriteLine("\nCount of even numbers: " + count);
    }
}