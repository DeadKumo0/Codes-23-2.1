using System;

class Program
{
    static void Main()
    {
        int[] intData = new int[3];
        double[] doubleData = new double[3];
        string[] stringData = new string[3];
        byte[] byteData = new byte[3];
        short[] shortData = new short[3];
        long[] longData = new long[3];
        float[] floatData = new float[3];
        Char[] charData = new Char[3];
        Console.WriteLine("Введите 3 int:");
        for (int i = 0; i < intData.Length; i++)
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите int еще раз:");
            }
            intData[i] = userInput;
        }

        Console.WriteLine("Введите 3 double:");
        for (int i = 0; i < doubleData.Length; i++)
        {
            double userInput;
            while (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите double еще раз:");
            }
            doubleData[i] = userInput;
        }

        Console.WriteLine("Введите 3 string:");
        for (int i = 0; i < stringData.Length; i++)
        {
            stringData[i] = Console.ReadLine();
        }

        Console.WriteLine("Введите 3 byte:");
        for (int i = 0; i < byteData.Length; i++)
        {
            byte userInput;
            while (!byte.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите byte еще раз:");
            }
            byteData[i] = userInput;
        }

        Console.WriteLine("Введите 3 short:");
        for (int i = 0; i < shortData.Length; i++)
        {
            short userInput;
            while (!short.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите short еще раз:");
            }
            shortData[i] = userInput;
        }

        Console.WriteLine("Введите 3 long:");
        for (int i = 0; i < longData.Length; i++)
        {
            long userInput;
            while (!long.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите long еще раз:");
            }
            longData[i] = userInput;
        }

        Console.WriteLine("Введите 3 float:");
        for (int i = 0; i < floatData.Length; i++)
        {
            float userInput;
            while (!float.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите float еще раз:");
            }
            floatData[i] = userInput;
        }

        Console.WriteLine("Введите 3 char:");
        for (int i = 0; i < charData.Length; i++)
        {
            char userInput;
            while (!char.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Недопустимые данные. Введите char еще раз:");
            }
            charData[i] = userInput;
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


        Console.WriteLine("byte:");
        foreach (int data in byteData)
        {
            Console.WriteLine(data);
        }


        Console.WriteLine("short:");
        foreach (int data in shortData)
        {
            Console.WriteLine(data);
        }


        Console.WriteLine("long:");
        foreach (int data in longData)
        {
            Console.WriteLine(data);
        }


        Console.WriteLine("float:");
        foreach (int data in floatData)
        {
            Console.WriteLine(data);
        }


        Console.WriteLine("char:");
        foreach (int data in charData)
        {
            Console.WriteLine(data);
        }



        Console.WriteLine("Общие данные, которые нельзя будет сломать:");
        Console.WriteLine("int: " + string.Join(", ", intData));
        Console.WriteLine("double: " + string.Join(", ", doubleData));
        Console.WriteLine("string: " + string.Join(", ", stringData));
        Console.WriteLine("byte: " + string.Join(", ", byteData));
        Console.WriteLine("short: " + string.Join(", ", shortData));
        Console.WriteLine("long: " + string.Join(", ", longData));
        Console.WriteLine("float: " + string.Join(", ", floatData));
        Console.WriteLine("char: " + string.Join(", ", charData));
    }
}

