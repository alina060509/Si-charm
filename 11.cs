

using System.Text;
namespace _2_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int el = 5;
                int[] A = new int[el];
                int row = 3, col = 4;
                double[,] B = new double[row, col];

                Console.WriteLine($"Введите {el} чисел: ");
                for (int i = 0; i < el; i++)
                {
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }

                Random rand = new Random();
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                        B[i, j] = rand.Next(100);

                Console.Write("Массив A: ");
                for (int i = 0; i < el; i++)
                {
                    Console.Write(A[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Массив В:");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int minA = A[0];
                int maxA = A[0];
                for (int i = 0; i < el; i++)
                {
                    if (A[i] < minA) minA = A[i];
                    if (A[i] > maxA) maxA = A[i];
                }
                Console.WriteLine($"Минимальный элемент массива А: {minA}. Максимальный элемент массива А: {maxA}");

                double maxB = B[0, 0];
                double minB = B[0, 0];
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (B[j, i] < minB) minB = B[j, i];
                        if (B[j, i] > maxB) maxB = B[j, i];
                    }
                }
                Console.WriteLine($"Минимальный элемент массива B: {minB}. Максимальный элемент массива B: {maxB}");
                int sumA = 0;
                double sumB = 0;
                foreach (int item in A)
                {
                    sumA += item;
                }

                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                        sumB += B[i, j];

                Console.WriteLine($"Сумма чисел массива А: {sumA}.\nСумма чисел массива В: {sumB}.\nОбщая сумма: {sumA + sumB}");

                int multA = 1;
                double multB = 1;
                foreach (int item in A)
                {
                    multA *= item;
                }

                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                        multB *= B[i, j];

                Console.WriteLine($"Произведение чисел массива А: {multA}.\nПроизведение чисел массива В: {multB}.\nОбщее произведение: {multA * multB}");

                int evenSum = 0;
                for (int i = 0; i < el; i++)
                {
                    if (i % 2 == 0)
                        evenSum += A[i];
                }
                Console.WriteLine("Сумма четных элементов массива A: " + evenSum);

                double sumCol = 0;
                for (int i = 0; i < col; i++)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            sumCol += B[j, i];
                        }
                    }
                }
                Console.WriteLine("Сумма нечетных столбцов массива В: " + sumCol);

                Console.ReadKey();
            }
        }
    }
}

namespace _2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            Console.WriteLine("Дан массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМассив переведен в одномерный:");
            int[] oneDimArr = new int[25];
            int z = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    oneDimArr[z] = arr[i, j];
                    z++;
                }

            foreach (int item in oneDimArr)
            {
                Console.Write(item + " ");
            }
            int min = oneDimArr[0];
            int max = oneDimArr[0];

            for (int i = 0; i < 10; i++)
            {
                if (oneDimArr[i] < min)
                    min = oneDimArr[i];
                if (oneDimArr[i] > max)
                    max = oneDimArr[i];
            }

            Console.WriteLine("\n\nМаксимальное значение " + max);
            Console.WriteLine("Минимальное значение " + min);

            int indexMin;
            int indexMax;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min == oneDimArr[i])
                {
                    indexMin = i;
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (max == oneDimArr[i])
                {
                    indexMax = i;
                    break;
                }
            }
            int sum = 0;
            if (indexMin < indexMax)
            {

                for (int i = indexMin; i <= indexMax; i++)
                    sum = sum + oneDimArr[i];
            }
            else
            {
                for (int i = indexMax; i <= indexMin; i++)
                    sum = sum + oneDimArr[i];
            }
            Console.WriteLine("min = {0}, max={1}, sum={2} ", min, max, sum);
            Console.ReadLine();
        }
    }
}


namespace _2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetArr = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            Console.Write("Введите фразу: ");
            string phrase = Console.ReadLine();

            char[] phraseArr = phrase.ToCharArray();
            char[] finalArr = phraseArr;
            char[] finalArr2 = phraseArr;

            for (var k = 0; k < phraseArr.Length; k++)
            {
                var ch = phraseArr[k];
                for (int i = 0; i < alphabetArr.Length; i++)
                    if (ch == alphabetArr[i])
                    {                
                        int n = i + 3;
                        if (n > 33)
                        {
                            n = n % 33;
                        }

                        finalArr[k] = alphabetArr[n];
                    }
                    if (ch == ' ') 
                    {
                        finalArr[k] = ' ';
                    }
                }
            }
            Console.WriteLine("Шифрую:");
            foreach (char item in finalArr)
            {
                Console.Write(item); 
            }
            for (var q = 0; q < phraseArr.Length; q++)
            {
                var chr = phraseArr[q];
                for (int r = 0; r < alphabetArr.Length; r++) 
                {                                      
                    if (chr == alphabetArr[r]) 
                    {                   
                        int m = r - 3;
                        if (m < 0)
                        {
                            m = 33 + m;
                        }

                        finalArr2[q] = alphabetArr[m];
                    }
                    if (chr == ' ') 
                    {
                        finalArr2[q] = ' ';
                    }
                }
            }

            Console.WriteLine("\nДешифрую:");
            foreach (char item in finalArr2)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}

namespace _2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[5, 5];
            int[,] arr2 = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr1[i, j] = rand.Next(20);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr2[i, j] = rand.Next(20);
            Console.WriteLine("Массив 1:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМассив 2:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nУмножим первый массив на два:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((arr1[i, j] * 2) + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма первого и второго массивов:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((arr1[i, j] + arr2[i, j]) + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Произведение:");
            int[,] arr3 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


namespace _2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");

            string[] arrayOfString = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0, num1 = 0;
            bool plus = true;
            for (int i = 0; i < arrayOfString.Length; i++)
            {
                if (double.TryParse(arrayOfString[i], out num1))
                {
                    if (plus)
                        result = result + num1;
                    else
                        result = result - num1;
                }
                else
                {
                    if (arrayOfString[i] == "+")
                        plus = true;
                    else
                        plus = false;
                }
            }
            Console.WriteLine(result);
        }
    }
}


namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "today is a good day for walking. i will try to walk near the sea.";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}


namespace _2_7
{
    class Program
    {
        static void Main()
    {
        string[] forbiddenWords = { "die" };
        Dictionary<string, int> statistics = new Dictionary<string, int>();
        Console.WriteLine("ВВЕДИТЕ ТЕКСТ:");
        string inputText = Console.ReadLine();
        string[] words = inputText.Split(new char[] { ' ', ',', '.', ':', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (Array.IndexOf(forbiddenWords, words[i]) != -1)
            {
                words[i] = new string('*', words[i].Length);
                if (statistics.ContainsKey(words[i]))
                {
                    statistics[words[i]]++;
                }
                else
                {
                    statistics.Add(words[i], 1);
                }
            }
        }
        Console.WriteLine(string.Join(" ", words));
        Console.WriteLine("\nStatistics:");
        foreach (var pair in statistics)
        {
            Console.WriteLine($"{pair.Value} ЗАМЕНА СЛОВА {pair.Key}");
        }
    }
}