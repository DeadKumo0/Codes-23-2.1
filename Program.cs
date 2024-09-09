using System;

class Program
{
    static void Main()
    {
        int[] intData = new int[15];
        double[] doubleData = new double[15];
        string[] stringData = new string[15];

        Console.WriteLine("Введите 15 целочисленных данных:");
        for (int i = 0; i < intData.Length; i++)
        {
            intData[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введите 15 данных с плавающей точностью:");
        for (int i = 0; i < doubleData.Length; i++)
        {
            doubleData[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Введите 15 строковых данных:");
        for (int i = 0; i < stringData.Length; i++)
        {
            stringData[i] = Console.ReadLine();
        }

        Console.WriteLine("Целочисленные данные:");
        foreach (int data in intData)
        {
            Console.WriteLine(data);
        }

        Console.WriteLine("Данные с плавающей точностью:");
        foreach (double data in doubleData)
        {
            Console.WriteLine(data);
        }

        Console.WriteLine("Строковые данные:");
        foreach (string data in stringData)
        {
            Console.WriteLine(data);
        }

        Console.WriteLine("Общие данные, которые нельзя будет сломать:");
        Console.WriteLine("Целочисленные данные: " + string.Join(", ", intData));
        Console.WriteLine("Данные с плавающей точностью: " + string.Join(", ", doubleData));
        Console.WriteLine("Строковые данные: " + string.Join(", ", stringData));

        Console.ReadLine();
    }
}
