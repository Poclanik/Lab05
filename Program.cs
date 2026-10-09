//int dayNumber = 6;
//
//switch (dayNumber)
//{
//    case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//    default: Console.WriteLine("Будний"); break;
//}
//
//int score = 78;
//switch (score = 78)
//{
//    case >= 0 and <= 39:
//        Console.WriteLine("Неудовлетворительно");
//        break;
//    case >= 40 and < 59:
//        Console.WriteLine("Удовлетворительно");
//        break;
//    case >= 60 and < 79:
//        Console.WriteLine("Хорошо");
//        break;
//    case >= 80 and <= 100;
//        Console.WriteLine("Отлично");
//        break;
//    default:
//        Console.WriteLine("Некорректный балл");
//        break;
//}

//int score = 16;
//
//string result = score switch
//{
//    < 0 => "Мороз",
//    <= 14 => "Прохладно",
//    <= 24 => "Комфортно",
//    <= 34 => "Жарко",
//    _ => "Очень жарко"
//};
//Console.WriteLine(result);

//string role = "teacher";
//
//string result = role switch
//{   
//    "teacher" => "Доступ преподавателя",
//    "admin" => "Полный доступ",
//    not "admin" => "Ограниченный доступ"
//};
//Console.WriteLine(result);

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case <= 18:
        Console.WriteLine("")
}