﻿string s = "книжка суп хокей курс натхнення"; // Створюємо рядок, що містить кілька слів, розділених пробілами

string[] a = s.Split(' '); // Розбиваємо рядок на окремі слова, використовуючи пробіл як роздільник, і зберігаємо їх у масив рядків

// Сортуємо масив слів за довжиною кожного слова (від найкоротшого до найдовшого)
Array.Sort(a, (x, y) => x.Length.CompareTo(y.Length));

// Використовуємо Array.Sort з лямбда-функцією для порівняння довжини слів: порівнюємо довжину кожного слова та сортуємо їх у порядку від найкоротшого до найдовшого.

// Проходимо через всі елементи масиву
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]); // Виводимо кожне слово на екран у відсортованому порядку
}

// Цикл for проходить по кожному елементу масиву, і ми виводимо кожне слово на консоль.

Console.ReadKey(); // Чекаємо на натискання будь-якої клавіші перед завершенням програми
