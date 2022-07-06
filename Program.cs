
using System;


namespace Sort
{
   class Program
    {
         static void Main(string[] args)
        {
            
            int free;
            List<int> array = new List<int>();
            Console.WriteLine("Enter  array of integers\nEnter one number at a time separating them by entering\nTo start sorting, press 0 ");
            for (int NumI=1;  NumI!=0;)
            {
                try
                {
                    NumI = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Enter integer DIGITAL without space");
                }
                array.Add(NumI);
            }
            for(int i = 0; i < array.Count(); i++)
            {
                for(int j = 0; j < array.Count()-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        free = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = free;
                        for ( int n = j; n >0; n--)
                        {
                            if (array[n] < array[n - 1])
                            {
                                free = array[n];
                                array[n] = array[n - 1];
                                array[n - 1] = free;
                            }
                        }
                    }
                }
            }
           for(int i = 1; i < array.Count(); i++)
            {
                Console.Write(array[i]+" ");
            }

        }
      
    }
}