// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// // При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// // Создаем функцию для создания массива строк

// string[] CreateArray(int size){
//     string[] array = new string[size];
//     for(int i=0; i <size; i++){
//         Console.Write($"Введите элемент с индексом {i}: ");
//         array[i] = Convert.ToString(Console.ReadLine());
//     }
//     return array;
// }

// // Создаем функцию для отображения полученного ранее массива

// void ShowArray(string[] array){
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//         // Console.Write(array[i] + "\t");
//     }
// }

// // Создаем функцию, которая проверяет принимает два массива, проверяет условие и выдает нужный массив строк

// string[] ReturnNeedArray(string[] array, string[] array2)
// {
//     int count =0;
//     for(int i=0; i<array.Length; i++){
//     int l = array[i].Length;   
// 	    if(l <= 3)
// 	{
//         array2[count] = array[i];
//         count++;
//     }
// }

// return array2;
// }

// // Вычисление 

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// string[] array = (CreateArray(size));
// string[] array2 = new string[array.Length];
// Console.WriteLine("");
// Console.Write("Вводный массив: ");
// ShowArray(array);
// Console.WriteLine();
// ReturnNeedArray(array,array2);
// Console.Write("Итоговый массив: ");
// ShowArray(array2);

// //Отображение результата на экране 

