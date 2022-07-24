using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha29()
            {//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            int size=8;
            int[] array=new int[size];
            Random random=new Random();
            for (int i=0;i< array.Length;i++)
            {
             array[i]=random.Next(-10,11);
            }
             Console.WriteLine();
             Console.WriteLine("Массив:");  
             for (int i=0;i<array.Length;i++)
             {
                Console.Write(array[i]+"\t");
             } 
             Console.WriteLine();

             for(int i=array.Length;i>0;i++)
             {
                for(int j=0;j<i;j++)
                {
                 if(array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j]=array[j + 1];
                        array[j + 1]=temp;
                    }
                }
             }
             Console.WriteLine();
             Console.WriteLine("Массив по модулю:");  
             for (int i=0;i<array.Length;i++)
             {
                Console.Write(array[i]+"\t");
             } 
             Console.WriteLine();

            }
        
            Zadacha29();
        }
        
     }
    
}