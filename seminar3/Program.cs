// Task 1
/*void print(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        Console.WriteLine();
    }
}

int[] array = {1, 2, 3, 4, 5};

arr(array); */

// Task 2
/* int[] array = { 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 };
for(int i = 0; i<array.Length; i++){
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++){
    if(array[i]==1){
        array[i] = 0;
    }else{
        array[i] = 1;
    }

    Console.Write(array[i] + " ");
} */

// Task 3
/* int[] array = new int[5];

for(int i = 0; i < array.Length; i++){
    array[i] = i + 1;
    Console.Write(array[i] + " ");
} */

// Task 4
/* int[] array = { 1, 5, 3, 2, 11, 4, 5, 2, 4, 8, 9, 1 };
for(int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++){
    if(array[i] < 6){
        array[i] *= 2;
    }
    Console.Write(array[i] + " ");
} */

// Task 5
/* int[] array(int len, int initialValue)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = initialValue;
    }
    return arr;
}

int[] result = array(10,9);
print(result); */

// Task 6
/* int[] first = {1, 2, 3, 4, 5, 16};
int min = first[0];
int max = first[0];
for( int i = 0; i < first.Length; i++){
    if ( first[i] < min) {
        min = first[i];
    }
    if ( first[i] > max) {
        max = first[i];
    }
}
Console.WriteLine(min + "\n" + max); */

// Task 7
bool check(int[] array){
    int sum_left = 0;
    int sum_right = 0;
    for(int i = 0; i < array.Length; i++){
        sum_left += array[i];
        for(int j = i+1; j < array.Length; j++){
            sum_right += array[j];
        }
        if(sum_left == sum_right){
            return true;
        }
        sum_right = 0;
    }
    return false;
}

int[] arr = {1, 2, 3, 6};
bool rez = check(arr);
Console.WriteLine(rez);