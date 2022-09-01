using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static int[,] matrix = {{1,2,3}, {4,5,6}, {7,8,9}};


        static void Main(string[] args)
        {
            // Declaring an ArrayList with an undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList with an defined amount of object(100)
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(13);

            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);



            // // Jagged array is an array within an array
            // int[][] jaggedArray = new int[3][];
            // // Array with 5 vaues  Console.WriteLine(sum);
            // jaggedArray[0] = new int [5];
            // // Array with 3 values
            // jaggedArray[1] = new int [3];
            // // Array with 2 entries
            // jaggedArray[2] = new int [2];

            // jaggedArray[0] = new int [] {2,3,5,7,11};
            // jaggedArray[1] = new int [] {1,2,3};
            // jaggedArray[2] = new int [] {13,21};

            // // Alternative
            // int[][] jaggedArray2 = new int[][]
            // {
            //     new int [] {2,3,5,7,11},
            //     new int [] {1,2,3},
            //     new int [] {13,21}
            // };
            // // Console.WriteLine(jaggedArray2[0][2]);

            // for (int i = 0; i < jaggedArray2.Length; i++)
            // {
            //     Console.WriteLine($"Element {i}");
            //     for (int j = 0; j < jaggedArray2[i].Length; j++)
            //     {
            //         Console.WriteLine(jaggedArray2[i][j]);
            //     }
            // }



            // foreach (int item in matrix)
            // {
            //     Console.WriteLine(item + " ");
            // }

            // System.Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            // for (int row = 0; row < matrix.GetLength(0); row++)
            // {
            //     // Console.WriteLine(row);
            //     for (int col = 0; col < matrix.GetLength(1); col++)
            //     {
            //         // matrix[row,col] = 0;
            //         Console.WriteLine(matrix[row,col]);
            //     }
            // }
            
            // // Ways of initializing an array
            // // This is an integer array, we created space for 5 values(int[5])
            // // 1.
            // int[] grades = new int[5];
            // grades[0] = 20;
            // grades[1] = 15;
            // grades[2] = 12;
            // grades[3] = 9;
            // grades[4] = 7;

            // // Assign value to an array
            // Console.WriteLine("Please enter your grade");
            // grades[0] = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine($"School scores {grades[0]}, {grades[1]}");

            // // 2.
            // int[] gradesOfStuA = {20, 15, 12, 9, 7};
            // // 3.
            // int[] gradesOfStuB = new int[] {24, 5, 10, 4, 1, 22};

            // Console.WriteLine(gradesOfStuA.Length);
            // Console.WriteLine(gradesOfStuB.Length);
            

            // For each loop
            // Number of elements to be stored
            // int[] nums = new int[10];
            // for(int i = 0; i < 10; i++)
            // {
            //     // assign the values respectively
            //     nums[i] = i+10;
            // }

            // for(int j = 0; j < nums.Length; j++)
            // {
            //     Console.WriteLine($"Elements {j} = {nums[j]}");
            // }

            // int counter = 0;
            // foreach(int k in nums)
            // {
            //     Console.WriteLine($"Elements {counter} = {k}");
            //     counter++;
            // }

            // // 2D Arrays
            // // Declare 2D array
            // string[,] matrix; 
            
            // // Declare 3D array
            // string[,,] threeD;


            // int[,] array2D = new int[,]
            // {
            //     {1,2,3},
            //     {4,5,6},
            //     {7,8,9}
            // };

            // // Console.WriteLine($"Access {array2D[1,1]} RxC");
            // // Console.WriteLine($"Access {array2D[2,0]} RxC");

            // string[,,] array3D = new string[,,]
            // {
            //     {
            //         // Postion 0 of 3D array
            //         {"000", "001"},
            //         {"010", "011"},
            //         {"Hi there", "what's up"}
            //     },
            //     {
            //         // Position 1 of 3D array
            //         {"100", "101"},
            //         {"110", "111"},
            //         {"Another one", "Last entry"}
            //     }
            // };

            // // Console.WriteLine($"Access {array3D[1,1,0]} Position, RxC");
            // // Console.WriteLine($"Access {array3D[0,2,0]}");

            // string[,] array2Dstring = new string[3,2]
            // {
            //     {"one", "two"},
            //     {"three", "four"},
            //     {"five", "six"}
            // };

            // array2Dstring[1,1] = "chiken";
            // // System.Console.WriteLine(array2Dstring[1,1]);

            // // Check the dimensions of an array
            // int dimensions = array2Dstring.Rank;
            // System.Console.WriteLine(dimensions);

            // int[,] array2Dnew = {{1,2}, {3,4}};

        }
    }
}