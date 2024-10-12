namespace PracticalWorkCollections2OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Задания с использованием List\n\nЗАДАНИЕ 1: уникальные элементы списка\n\n");

        Console.WriteLine("Введите ряд целых чисел, разделяя их пробелами:");
        string numbersInput = Console.ReadLine();
        string[] numberInputArray = numbersInput.Split(' ');

        List<int> numberList = [];

        foreach (var numberString in numberInputArray)
        {
            int intNumber = Convert.ToInt32(numberString);
            numberList.Add(intNumber);
        }

        List<int> uniqueNumberList = numberList.Distinct().ToList();

        Console.WriteLine("Список уникальных чисел: ");
        foreach (var number in uniqueNumberList)
            Console.Write(number + " ");



        Console.WriteLine("\n\nЗАДАНИЕ 2: Сумма положительных чисел\n\n");

        Console.WriteLine("Введите ряд целых чисел, разделяя их пробелами:");
        string numbersInput1 = Console.ReadLine();
        string[] numberInputArray1 = numbersInput1.Split(' ');

        List<int> numberList1 = [];

        foreach (var numberString in numberInputArray1)
        {
            int intNumber = Convert.ToInt32(numberString);
            numberList1.Add(intNumber);
        }

        int sum = 0;

        foreach (var number in numberList1)
            if (number > 0)
                sum += number;
            
        Console.WriteLine("Сумма всех положительных чисел в списке: " + sum);


        Console.WriteLine("\n\nЗадания с использованием Dictionary:\n\nЗАДАНИЕ 1: подсчет слов\n\n");


        Console.WriteLine("Введите строки, разделяя их пробелами:");
        string words = Console.ReadLine();
        string[] wordsArray = words.Split(' ');

        Dictionary<string, int> stringCountDictionary = [];

        foreach (var word in wordsArray)
        {
            if (stringCountDictionary.ContainsKey(word))
                stringCountDictionary[word]++;
            else
                stringCountDictionary[word] = 1;
        }

        Console.WriteLine("\nКоличество вхождений каждого слова:");
        foreach (var entry in stringCountDictionary)
            Console.WriteLine($"{entry.Key}: {entry.Value}");


        
        Console.WriteLine("\n\nЗАДАНИЕ 2: хранение информации о студентах\n\n");

        Dictionary<string, List<int>> studentMarksDictionary = [];

        while (true)
        {
            Console.WriteLine("1. Добавить нового студента\n2. Добавить оценку студенту\n3. Вывести среднюю оценку для каждого студента\n4. Выйти из программы\n");

            byte choice = Convert.ToByte(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Введите имя нового студента: ");
                    string studentName = Console.ReadLine();

                    studentMarksDictionary.Add(studentName, []);

                    Console.Clear();

                    Console.WriteLine($"Студент {studentName} успешно добавлен!\n");
                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("Введите имя студента, которому необходимо поставить оценку: ");
                    studentName = Console.ReadLine();

                    if (studentMarksDictionary.ContainsKey(studentName))
                    {
                        Console.Write("Введите оценку: ");
                        int mark = Convert.ToInt32(Console.ReadLine());

                        studentMarksDictionary[studentName].Add(mark);
                        
                        Console.Clear();
                        Console.WriteLine($"Оценка {mark} успешно добавлена студенту {studentName}!\n");
                    }
                    else
                        Console.WriteLine($"Студент {studentName} не найден.\n");
                    break;

                case 3:
                    Console.Clear();

                    foreach (var student in studentMarksDictionary)
                    {
                        if (student.Value.Count > 0)
                        {
                            double average = student.Value.Average();

                            Console.WriteLine($"{student.Key}: {Math.Round(average, 2)}");
                        }
                        else
                            Console.WriteLine($"{student.Key}: Нет оценок.\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nДо свидания!");
                    return;

                default:
                    Console.WriteLine("Неверный выбор.\n");
                    break;
            }
        }
    }
}