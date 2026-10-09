using System;
using System.Linq;
//int dayNumber = 5;
//
//switch (dayNumber) {
//    case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
//    default: Console.WriteLine("Будний"); break;
//}
//
//int score = 78;
//
//switch (score) {
//    case >= 0 and < 40:
//        Console.WriteLine("Неудовлетворительно");
//        break;
//    case >= 40 and < 60:
//        Console.WriteLine("Удовлетворительно");
//        break;
//    case >= 60 and < 80:
//        Console.WriteLine("Хорошо");
//        break;
//    case >= 80 and <= 100:
//        Console.WriteLine("Отлично");
//        break;
//    default:
//        Console.WriteLine("Некорректный балл");
//        break;
//}
//
//int temperature = 20;
//
//string category = temperature switch {
//    < 0 => "Мороз",
//    < 15 => "Прохладно",      
//    < 25 => "Комфортно",      
//    < 35 => "Жарко",          
//    _ => "Очень жарко"   
//};
//
//Console.WriteLine(category);
//
//string role = "teacher";
//
//string result = role switch {
//    "admin" => "Полный доступ",
//    "teacher" => "Доступ преподавателя",
//    not "admin" => "Ограниченный доступ"
//};
//
//Console.WriteLine(result);
//int age = 20;
//bool hasTicket = true;
//
//switch (age) {
//    case int a when a >= 18 && hasTicket:
//        Console.WriteLine("Вход разрешён");
//        break;
//    case >= 18:
//        Console.WriteLine("Нет билета");
//        break;
//    default:
//        Console.WriteLine("Возраст не подходит");
//        break;
//}
//
//int level = 2;
//
//switch (level) {
//    case 1:
//        Console.WriteLine("Начальный уровень");
//        break;
//    case 2:
//        Console.WriteLine("Средний уровень");
//        goto case 1;
//    case 3:
//        Console.WriteLine("Продвинутый уровень");
//        break;
//}

Console.WriteLine("Введите номер месяца");
int mec = int.Parse(Console.ReadLine());
switch(mec) {
    case 12 or 1 or 2:
        Console.WriteLine("Зима");
        break;
    case 3 or 4 or 5:
        Console.WriteLine("Весна");
        break;
    case 6 or 7 or 8:
        Console.WriteLine("Лето");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Неверное месяц");
        break;
};
int ag = int.Parse(Console.ReadLine());
switch(ag) {
    case <= 6:
        Console.WriteLine("Ребенок");
        break;
    case <= 17:
        Console.WriteLine("Подросток");
        break;
    case <= 64:
        Console.WriteLine("Взрослый");
        break;
    default:
        Console.WriteLine("Пенсионер");
        break;};

//У меня по какой то причине не работает код делаю задачи 1 и 5
// 1
int month = int.Parse(Console.ReadLine());
switch(month) {
    case 12 or 1 or 2:
        Console.WriteLine("Зима");
        break;
    case 3 or 4 or 5:
        Console.WriteLine("Весна");
        break;
    case 6 or 7 or 8:
        Console.WriteLine("Лето");
        break;
    case 9 or 10 or 11:
        Console.WriteLine("Осень");
        break;
    default:
        Console.WriteLine("Неверное месяц");
        break;
};
// 5
int tem = 20;

string categ = tem switch {
    < 0 => "Мороз",
    < 15 => "Прохладно",      
    < 25 => "Комфортно",      
    < 35 => "Жарко",          
    _ => "Очень жарко"   
};
Console.WriteLine(categ);
//***
int number = 42;

string kind = number switch {
    1 or 2 or 3 => "Маленькое число", 
    < 0 => "Отрицательное",
    >= 0 and <= 9 => "Однозначное",
    >= 10 and <= 99 => "Двузначное",
    _ => "Трёхзначное или больше"        
};

Console.WriteLine(kind);