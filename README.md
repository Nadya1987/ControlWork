Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


*Описание решения:*
 - алгоритм принимает на вход массив размером SIZE;
 - вводим элементы массива строк (*string*) с клавиатуры;
 - создаем цикл, с условием, что длина массива из строк (i элемента) меньше либо равна 3 символа;
 - eсли условие выполняется, то присваиваем i элемент начального массива i элементу массива для печати;
 - в цикле таким образом проходим по каждому элементу массива, в котором сверяем длину строк;
 - выводим на экран получившийся массив!