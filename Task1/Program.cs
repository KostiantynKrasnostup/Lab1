﻿string s = "Dfg + t5-rr7y; aasd * ss34; rt"; // Створюємо рядок, що містить букви, цифри та спеціальні символи

int count = 0; // Ініціалізуємо змінну для підрахунку кількостей пар однакових букв

// Запускаємо цикл, щоб перевірити кожен символ рядка, крім останнього
for (int i = 0; i < s.Length - 1; i++)
{
    // Перевіряємо, чи є поточний символ літерою (а не цифрою або спецсимволом)
    if (char.IsLetter(s[i]) && s[i] == s[i + 1])
    {
        count++; // Якщо поточна літера дорівнює наступній, збільшуємо лічильник
    }
}

// Виводимо значення лічильника на консоль, яке показує кількість пар однакових букв
Console.WriteLine(count);

// Чекаємо, поки користувач натисне будь-яку клавішу, щоб програма не закрилася відразу
Console.ReadKey();
