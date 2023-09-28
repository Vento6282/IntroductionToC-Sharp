Console.Clear();

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.
// bool IsPalindrome(int number)
// {
//       if(number > 9999 && number < 100000)
//       {
//         if (((number % 100) + (number / 1000)) % 11 == 0)
//           return true;
//         return false;
//       }
//       else
//       {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }
// }
// Console.WriteLine("Введите пятизначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number);
// Console.WriteLine(IsPalindrome(number));