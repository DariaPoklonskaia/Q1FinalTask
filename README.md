# Итоговая задача первой четверти

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Допущения:

0. Размер исходного массива определяется случайным образом, в интервале [1;9]
1. Исходный массив заполняется путем ввода пользователем с клавиатуры, поочередно каждый элемент массива. 
2. Пользователь адекватный, не будет вводить супер длинные наборы символов, которые могут превышать тип или станут неудобными для отображения; 
3. Допускается ввод пустых строк, они отображаются через запятую в исходном массиве и включаются в результирующий, так как удовлетворяют условию меньше или равно трем символам. 
4. Выдача результатов выполнена при помощи консоли.

## Подзадачи:
0. Блок-схема для решения главной задачи (пункт 3).
1. Метод по созданию и заполнению исходного массива. 
2. Метод для подсчета удовлетворяющих условию элементов(число символов меньше или равно трем) для включения в новый массив.
3. Главная задача: метод по созданию  и заполнению нового массива. 
Блок-схема также доступна [по ссылке](https://github.com/DariaPoklonskaia/Q1FinalTask/blob/main/MainTaskScheme.drawio.png) или в папке проекта ![paint](MainTaskScheme.drawio.png) 
4. Метод вывода исходного и результирующего массива. 
5. Генерация случайного числа в интервале [1;9]  для определения размера исходного массива. 
6. Проверка, что размер результирующего массива не равен нулю, иначе - соответствующее сообщение на выдаче, вместо пустой строки.

