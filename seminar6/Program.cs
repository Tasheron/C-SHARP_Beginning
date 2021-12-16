// Написать функцию для вывода любого двумерного целочисленного массива в консоль в табличном виде.
/* void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
} */

/* int[,] array = {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 0}};

printArray(array); */

// Дан двумерный целочисленный массив X = { {1, 3, 7, 4, 5}, {9, 4, 5, 1, 2} }. Заменить в нем все элементы, меньшие 5 числом 111.
/* int[,] Array = {{1, 3, 7, 4, 5}, {9, 4, 5, 1, 2 }};

void printArray(int[,] Array) {
    for (int row = 0; row < Array.GetLength(0); row++) {
        for (int col = 0; col < Array.GetLength(1); col++) {
            if (Array[row, col] < 5) Array[row, col] = 111;
            Console.Write(Array[row, col] + " ");
        }
        Console.WriteLine();
    }
}

printArray(Array); */

// Дан целочисленный двумерный массив А = {{-1, 2, -3}, {4, -5, 3}}. Напечатать индексы его отрицательных элементов.
/* int[,] array = {{-1, 2, -3}, {4, -5, 3}};

for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i,j] < 0) Console.WriteLine(i + "," + j);
    }
} */

//Создать квадратный двумерный целочисленный массив (количество строк и столбцов одинаковое),
//и с помощью цикла(-ов) заполнить его диагональные элементы единицами (можно только одну из диагоналей, если обе сложно).
/* int[,] array = {{0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}};
for (int i = 0; i < array.GetLength(0); i++) {
    array[i, i] = 1;
    array[i, array.GetLength(0) - 1 - i] = 1;
}

printArray(array); */

// Написать функцию, формирующую строковую последовательность целых чисел от 1 до number.
