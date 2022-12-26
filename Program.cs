/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
 по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] Create2DArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows, cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(min, max+1);          
    }
    return array;
}
void ShowArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
      }
}
void SortingOfArray(int [,] array){
    int maxpos, temp;
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1)-1; j++){
            for(int k=j+1; k<array.GetLength(1); k++){
                maxpos=j;
                if (array[i,k]>array[i,maxpos]){
                maxpos=k;
                temp=array[i,j];
                array[i,j]=array[i,maxpos];
                array[i,maxpos]=temp;
                }
            }
        }       
    }
}
Console.Write("Введите число строк массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элементов: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элементов: ");
int max= Convert.ToInt32(Console.ReadLine());
int [,] array= Create2DArray(m,n,min,max);
Console.WriteLine("Исходный массив:"); 
ShowArray(array);
Console.WriteLine("Отсортированный массив:");
SortingOfArray(array);
ShowArray(array);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] Create2DArray(int rows, int cols, int min, int max){
    int [,] array = new int [rows, cols];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(min, max+1);          
    }
    return array;
}
void ShowArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        int sumrow=0;
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
            sumrow=sumrow+array[i,j];}
            Console.Write(" "+sumrow);
        Console.WriteLine();
      
    }  
}
void MinSumOfRow(int [,] array){
    int minsum=0, sumrow=0, imin=0;           
        for(int j=0; j<array.GetLength(1); j++){
            minsum=minsum+array[0,j];}
           
        for(int i=0; i<array.GetLength(0); i++){
            sumrow=0;       
        for(int j=0; j<array.GetLength(1); j++)
            sumrow=sumrow+array[i,j];
            if (sumrow<=minsum){
                minsum=sumrow;
                imin=i;
            }                
                    
        }
            Console.WriteLine(imin+" "+"("+minsum+")");  
}       
Console.Write("Введите число строк массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элементов: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элементов: ");
int max= Convert.ToInt32(Console.ReadLine());
int [,] array= Create2DArray(m,n,min,max);
Console.WriteLine("Массив:"); 
ShowArray(array);
Console.WriteLine("Строк(-а/и) массива с мин суммой () элементов:");
MinSumOfRow(array);


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
 int[,] GetArrayFromUser(string name)
    {
        Console.Write("Количество строк матрицы {0}: ", name);
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столбцов матрицы {0}: ", name);
        int m = Convert.ToInt32(Console.ReadLine());

        int [,] array = new int[n, m];
        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0}[{1},{2}] = ", name, i, j);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return array;
    }
    int[,] ArrayMultiply(int[,] array1, int[,] array2){ 
        if (array1.GetLength(1) != array2.GetLength(0))
            Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы");
        
        int [,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++){
            for (int j = 0; j < array2.GetLength(1); j++){
                array3[i, j] = 0;
                    for (var k = 0; k < array1.GetLength(1); k++)
                        array3[i, j] += array1[i, k] * array2[k, j];               
            }
        }
        return array3;
    }

void ShowArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j].ToString().PadLeft(4));
        Console.WriteLine();
    }
}

        Console.WriteLine("Программа для умножения матриц");

        int [,] arrayA = GetArrayFromUser("A");
        int [,] arrayB = GetArrayFromUser("B");

        Console.WriteLine("Матрица A:");
        ShowArray(arrayA);

        Console.WriteLine("Матрица B:");
        ShowArray(arrayB);

        int [,] arrayC = ArrayMultiply(arrayA, arrayB);
        Console.WriteLine("Произведение матриц:");
        ShowArray(arrayC);

        Console.ReadLine();



/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] Create3DArray(int rows, int cols, int pages, int min, int max){
    int [,,] array = new int [rows, cols, pages];
    for(int i=0; i<rows; i++){
        for(int j=0; j<cols; j++)
            for(int k=0; k<pages; k++)
            array[i,j,k]=new Random().Next(min, max+1);          
    }
    return array;
}
void ShowArray(int [,,] array){
    for(int k=0; k<array.GetLength(2); k++)
        for(int i=0; i<array.GetLength(0); i++){
            for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j,k] + "("+i+","+j+","+k+")"+" ");
        Console.WriteLine();
      }
}
Console.Write("Введите число строк (rows) массива: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов (сolumns) массива: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число листов (pages) массива: ");
int l= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min элементов: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max элементов: ");
int max= Convert.ToInt32(Console.ReadLine());
int [,,] array= Create3DArray(m,n,l,min,max);
Console.WriteLine("Массив:"); 
ShowArray(array);

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int [,] Create2DArray(int N){
    int [,] array = new int [N, N];
    for (int ik = 0; ik < N; ik++){     
        for (int jk = 0; jk < N; jk++){
            int i = ik + 1;     
            int j = jk + 1;    
            int switcher =  (j-i+N)/N;
            int Ic = Math.Abs(i-N/2-1)+(i-1)/(N/2)*((N-1)%2);
            int Jc = Math.Abs(j-N/2-1)+(j-1)/(N/2)*((N-1)%2);
            int Ring = N/2-(Math.Abs(Ic-Jc)+Ic+Jc)/2;
            int Xs = i-Ring+j-Ring-1;    
            int Coef= 4*Ring*(N-Ring);
            array[ik,jk] =  Coef+switcher*Xs+Math.Abs(switcher - 1)*(4*(N-2*Ring)-2-Xs);
            }
        }

    return array;
}   

void ShowArray(int [,] array){
    string fmt = "00.##";
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j].ToString(fmt) + " ");
        Console.WriteLine(); 
    }  
}
Console.Write("Введите размер квадратного массива: ");
int N= Convert.ToInt32(Console.ReadLine());
int [,] array= Create2DArray(N);
Console.WriteLine("Массив:"); 
ShowArray(array);


