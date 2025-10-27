using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] a;
        //a = new int[5] { 2, 3, 5, 7, 1 };
        //a = new int[] { 2, 3, 5, 7, 1 };

        /*
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

        //Sao chép mảng
        int[] ar = new int[b.Length];
        for (int i = 0; i < b.Length; i++)
            ar[i] = b[i];
        */
        //Cách 1: Đếm số phần tử xuất hiện
        int[] input = new int[] { 3, 9, 3, 3, 9, 1, 5 };
        /*int[] freq = new int[input.Length];
        for (int i = 0; i < input.Length; i++){
            freq[i] = 0;
            for (int j = 0; j < input.Length; j++){
                if (input[i] == input[j])
                    freq[i]++;
            }
        }
        foreach(int x in input)
            Console.Write(x + " ");
        Console.WriteLine();
        foreach (int x in freq)
            Console.Write(x + " ");
        */
        //Cách 2:
        //Stage 1: Sắp xếp
        /*int[] sorted = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
            sorted[i] = input[i];
        for (int i = 0; i < sorted.Length - 1; i++)
            for (int j = i + 1; j < sorted.Length; j++)
                if (sorted[i] > sorted[j])
                {
                    int temp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = temp;
                }
        int flag = 0;
        for (int i = 0; i < sorted.Length-1; i++)
            if (sorted[i + 1] != sorted[i])
                flag++;
        int[] frq = new int[flag+1];
        int[] unique = new int[flag + 1];
        //Stage 2: Đếm tần số
        flag = 0;
        int index = 0;
        for (int i = 0; i < sorted.Length-1; i++)
        {
            if (sorted[i + 1] != sorted[i])
            {
                unique[index] = sorted[i];
                frq[index] = (i + 1) - flag;
                flag = i + 1;
                index++;
            }
            if (i+1 == sorted.Length - 1)
            {
                unique[index] = sorted[sorted.Length - 1];
                frq[index] = sorted.Length - flag;
            }
        }
        foreach (int x in unique)
            Console.Write(x + " ");
        Console.WriteLine();
        foreach (int x in frq)
            Console.Write(x + " ");
        */

        //Xác định số lớn nhất, nhỏ nhất trong mảng
        /*
        int max, min;
        max = min = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] > max)
                max = input[i];
            if (input[i] < min)
                min = input[i];
        }
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        */
        int[] even, odd;
        int counteven = 0, countodd = 0;
        foreach (int x in input)
            if (x % 2 == 0)
                counteven++;
            else
                countodd++;
        even = new int[counteven];
        odd = new int[countodd];
        counteven = countodd = 0;
        foreach (int x in input)
            if (x % 2 == 0)
                even[counteven++] = x;
            else
                odd[countodd++] = x;
    }
}