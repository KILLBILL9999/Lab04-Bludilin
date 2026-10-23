// int age = 20;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");


// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешён");
// } else {
//     Console.WriteLine("Доступ запрещён");
//     Console.WriteLine($"Ждать осталось: {18 - age} лет");
// }

// int age = 14;
// if (age < 13) {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else if (age >= 60) {
//     Console.WriteLine("Пенсионер");
// } else {
//     Console.WriteLine("Взрослый");
// }


// int age = 16;
// double height = 1.55;
// bool hasAdult = false; 
// if ((age >= 14 && height >= 1.5) || (height < 1.5 && hasAdult)) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }


// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// string result = (number % 2 == 0) ? "Чётное" : "Нечётное";
// Console.WriteLine(result);


// Console.Write("Введите оценку (2-5): ");
// int grade = int.Parse(Console.ReadLine()!);

// string result;
// switch (grade) {
//     case 5:
//         result = "Отлично";
//         break;
//     case 4:
//         result = "Хорошо";
//         break;
//     case 3:
//         result = "Удовлетворительно";
//         break;
//     case 2:
//         result = "Неудовлетворительно";
//         break;
//     default:
//         result = "Неверная оценка";
//         break;
// }

// Console.WriteLine(result);

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №



// Console.Write("Введите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine()!);

// string season;

// switch (month)
// {
//     case 12:
//     case 1:
//     case 2:
//         season = "Зима";
//         break;
//     case 3:
//     case 4:
//     case 5:
//         season = "Весна";
//         break;
//     case 6:
//     case 7:
//     case 8:
//         season = "Лето";
//         break;
//     case 9:
//     case 10:
//     case 11:
//         season = "Осень";
//         break;
//     default:
//         season = "Неверный номер месяца";
//         break;
// }

// Console.WriteLine($"Время года: {season}");



// Console.Write("Первый игрок (К/Н/Б): ");
// char player1 = Console.ReadLine()![0].ToUpper();
// Console.Write("Второй игрок (К/Н/Б): ");
// char player2 = Console.ReadLine()![0].ToUpper();
// string result;
// if (!IsValidInput(player1) || !IsValidInput(player2))
// {
//     result = "Ошибка ввода";
// }
// else if (player1 == player2)
// {
//     result = "Ничья";
// }
// else if (
//     (player1 == 'К' && player2 == 'Н') ||
//     (player1 == 'Н' && player2 == 'Б') ||
//     (player1 == 'Б' && player2 == 'К')
// )
// {
//     result = "Победил первый игрок";
// }
// else
// {
//     result = "Победил второй игрок";
// }
// Console.WriteLine(result);
// bool IsValidInput(char input)
// {
//     return input == 'К' || input == 'Н' || input == 'Б';
// }
