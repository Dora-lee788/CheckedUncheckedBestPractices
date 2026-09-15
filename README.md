Задание «Контрольная точка №8 — checked/unchecked и лучшие практики»

Вариант 1. Калькулятор сумм
Метод int SumChecked(int[] numbers) — суммирует массив через checked, перехватывает OverflowException и возвращает int.MaxValue с выводом предупреждения вместо падения программы.
Возьмите готовый фрагмент: try { return int.Parse(input); } catch (Exception) { return 0; }. 
Перепишите его через int.TryParse, без try/catch.

Результаты и проверочные ключи

Вызов                                                Ожидаемый результат
SumChecked(new[] { 1, 2, 3 })                        6
SumChecked(new[] { int.MaxValue, 1 })                предупреждение в лог, возвращает int.MaxValue
int.TryParse("42", out var n) после рефакторинга     n == 42, без исключений
int.TryParse("abc", out var n) после рефакторинга    возвращает 0, без исключений
