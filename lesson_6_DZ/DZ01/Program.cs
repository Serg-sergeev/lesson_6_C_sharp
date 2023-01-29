//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using InitClases;

int[] array = UserInput.GetSetOfNumbers();
UserInput.Print(array);
//UserInput.GetCountInputPositivNumbers(array);
Console.WriteLine($"Количество положительных чисел: {UserInput.GetCountInputPositivNumbers(false, UserInput.GetSetOfNumbers())}");
//UserInput.GetCountInputPositivNumbers(UserInput.GetSetOfNumbers())
