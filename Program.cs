//int[] nums = new int[4];
//int[] nums2 = new int[] {1,2,3,4,5};
//int[] nums3 = new int[] {1,2,3,4,5};
//int[] nums4 = new[] {1,2,3,4,5};
//int[] nums5 = {1,2,3,4,5};
//int[] nums6 = [1,2,3,4,5];
//int[] numbers = [1, 2, 3, 4, 5];
//Console.WriteLine(numbers[3]);
//var n = numbers[0];
//Console.WriteLine(n);
//numbers[1] = 505;
//Console.WriteLine(numbers[1]);
//int[] numbers = [1, 2, 3, 4, 5];
//Console.WriteLine(numbers[6]);
//int[] numbers = [1, 2, 3, 4, 5];
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers.Length-1);
//Console.WriteLine(numbers.Length-2);
//Console.WriteLine(numbers.Length-3);
//Console.WriteLine(numbers[^1]);
//Console.WriteLine(numbers[^2]);
//Console.WriteLine(numbers[^3]);
//int[] numbers = [1, 2, 3, 4, 5];
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = numbers[i] * 2;
//    Console.WriteLine(numbers[i]);
//}
//int i = 0;
//while (i < numbers.Length)
//{
//    Console.WriteLine(numbers[i]);
//    i++;
//}

//int[] nums1 = [0, 1, 2, 3, 4, 5];
//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
//object[] student = ["иван", "игорь", 4, 4.6, 'с'];
//student[4] = 4;
//dynamic[] student2 = ["иван", "игорь", 4, 4.6, 'с'];
//student[4] = 4;
//Console.WriteLine(student[4].GetType());
//Console.WriteLine(student2[4].GetType());
//int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 42, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int result = 0;
//foreach (int number in numbers)
//{
//    if (number > 0)
//        { result++; }
//}
//Console.WriteLine($"Число элементов больше нуля: {result}");
//for (int number = 0; number < numbers.Length; number++)
//{
//    if (numbers[number] > 0)
//    {
//        result++;
//    }
//}

//Console.WriteLine($"Число элементов больше нуля: {result}");
//int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 42, 56, -34, 12, 45, -102, 76, -45, 96, -4, -3, 5, 76, -6, -8, 2, 0, 5, -9];
//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i}\t");
//}
//int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
//int temp;
//for (int i = 0;i < nums.Length; i++)
//{
//    for (int j = i+1;j < nums.Length; j++)
//    {
//        if (nums[j] < nums[i])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}
//List<string> people = [];
//List<string> student = new List<string>() {"иван", "игорь", "александр"};
//List<string> student = ["иван", "игорь", "александр"];
//var yourStudent = new List<string>(student);
//List<string> student = new List<string>(10);
//List<string> student = new(10);
//List<string> student = ["билли", "игорь", "степан"];
//string firstStudent = student[0];
//Console.WriteLine(firstStudent);
//student[0] = "богдан";
//Console.WriteLine(student[0]);
//List<string> student = ["билли", "игорь", "степан"];
//Console.WriteLine(student.Count);
//List<string> student = ["билли", "игорь", "степан"];
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
//List<string> student = ["билли", "игорь", "степан"];
//student.Add("van");
//student.AddRange(["Антон","денис"]);
//student.Insert(1, "кирилл");
//student.InsertRange(1, ["Mike", "Kate"]);
//student.Insert(7, "михаил");
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
//var people = new List<string>() { "евгений", "майк", "катя", "том", "боб", "сэм", "алиса" };
//people.RemoveAt(1);
//people.Remove("том");
//people.RemoveRange(1,2);
//people.Clear();

//дз
//1
//string[] predmeti = ["sword", "shield", "potion", "sword", "potion", "potion"];
//Console.WriteLine($"Список предметов:");
//foreach (string i in predmeti)
//    Console.WriteLine($"{i}");
//2
//int[] numbers = [ 10, 20, 15, 30, 25 ];
//int total = 0;
//foreach (int n in numbers)
//{
//    total += n;
//}
//Console.WriteLine($"общее количество очков: {total} ");
//3
//int[] numbers = [1, 3, 7, 2, 5 ];
//int max = numbers[0];
//foreach (int number in numbers)
//{
//    if (number > max)
//    {
//        max = number;
//    }
//}
//Console.WriteLine($"максимальный элемент: {max}");
//4
//int[] numbers = [1, 2, 3, 4, 5 ];
//int even = 0;
//int odd = 0;
//foreach (int n in numbers)
//{
//    if (n % 2 == 0)
//    {
//        even++;
//    }
//    else
//    {
//        odd++;
//    }
//}
//Console.WriteLine($"четных:{even}, нечетных:{odd}");
//5
//int[] times = [120, 95, 110, 105, 100 ];
//int fast = times[0];
//for (int i = 1; i < times.Length; i++)
//{
//    if (times[i] < fast)
//    {
//        fast = times[i];
//    }
//}
//Console.WriteLine($"самое быстрое время:{fast} сек");
//6
//string[] results = ["win", "loss", "win", "win", "loss" ];
//int win = 0;
//int loss = 0;
//foreach (string i in results)
//{
//    if (i == "win")
//    {
//        win ++; 
//    }
//    else if (i  == "loss")
//    {
//        loss ++;
//    }
//}
//Console.WriteLine($"{win} победы и {loss} поражения");
//7
//int[] scores = [15, 20, 25, 30, 10];
//int total = 0;
//for (int i = 0; i < scores.Length; i++)
//{
//    total += scores[i];
//}
//double res = (double)total  / scores.Length;
//Console.WriteLine($"среднее количество очков:{res}");
//8
//List<string> inventar =  ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
//for (int i = 0; i < inventar.Count; i++)
//{
//    if (inventar[i] == "Ласточка")
//    {
//        inventar[i] = "Кошка";
//    }
//    Console.WriteLine($"новый инвентарь: {inventar[i]}");
//}
//9
//List<string> companions =["Garrus", "Tali", "Mordin", "Grunt", "Jack" ];
//List<string> roles = ["Лидер команды", "Техник", "Биотик", "Солдат", "Поддержка" ];
//for (int i = 0; i < companions.Count; i++)
//{
//    Console.WriteLine($"{roles[i]}: {companions[i]}");
//}