## Quater 1 Final Task

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Допущения:

0. Размер исходного массива определяется случайным образом, в интервале [1;9]
1. Исходный массив заполняется путем ввода пользователем с клавиатуры, поочередно каждый элемент массива. 
2. Пользователь адекватный, не будет вводить супер длинные наборы символов, которые могут превышать тип или станут неудобными для отображения; 
3. В случае ввода пустых значений - они отображаются также через запятую в исходном и результирующем массивах. 

## Подзадачи:
0. Блок-схема для решения главной задачи (пункт 3).
1. Метод по созданию и заполнению исходного массива. 
2. Метод для подсчета удовлетворяющих условию элементов(число символов меньше или равно трем) для включения в новый массив.
3. Главная задача: метод по созданию  и заполнению нового массива. 
Блок-схема также доступна [по ссылке](https://github.com/DariaPoklonskaia/Q1FinalTask/blob/main/MainTaskScheme.drawio.png) или в папке проекта ![paint](/Q1FinalTask/MainTaskScheme.drawio.png). 
4. Метод для печати массивов. 
5. Проверка, что размер результирующего массива не равен нулю, иначе - соответствующее сообщение на выдаче, вместо пустой строки.
6. Генерация случайного числа в интервале [1;9]  для определения размера исходного массива. 

