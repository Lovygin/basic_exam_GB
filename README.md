## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм решения:
1. Программа предлагает задать с клавиатуры длину массива, с которым будет производится дальнейшая работа.
    - ввод
2. Проверка на достаточность длины массива: 
    - Если массив меньше либо равен 3-м элементам, то прогрпмма выводит сообщение о том что данный массив будет слишком короткий для работы;
    - Создает массив и нулевым количесвом элементов (null_array[0]);
    - Работы программы останавливается.
Если длина будущего массива достаточная, то:
3. Программа создает массив строк с заданной ранее длинной (long_array[0]);
4. Программа предлагает ввести с клавиатуры каждый элемент массива по порядку
    - ввод;
    - вывод масива в одну строку для визуализации;
Логика укорочения массива:
5. Создается новый массив строк длиной 3 элемента (short_array[0]);
6. создается новый рандомный экземпляр (random);
7. Начинается цикл, в котором новый массив (short_array[0])заполняется рандомными элентами из перичного массива (long_array[0]) и выводтся на экран в одну строку.
8. Конец.
