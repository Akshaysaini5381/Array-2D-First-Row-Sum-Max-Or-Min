using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2D_First_Row_Sum__Max_Or_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Base Array Size : ");
             int Row = int.Parse(Console.ReadLine());
             Console.Write("Enter The Child  Array Size :");
             int Col = int.Parse(Console.ReadLine());
         
            int[,] arr = new int[Row, Col];
                 
             int ptr;
             int ctr;
             ctr=0;
             while (ctr<Row)
             {
                  ptr = 0;
                 while (ptr<Col)
                 {
                     Console.Write("Enter The Value {0} :- ",(ctr+1));
                     arr[ctr, ptr] = int.Parse(Console.ReadLine());
                     ptr++;
                 }
                 ctr++;
                 Console.WriteLine();
             }

             int ctr1 = 0;
             int ptr1;
             while (ctr1<Row)
             {

                 ptr1 = 0;
                 while (ptr1<Col)
                 {
                     Console.Write(" "+arr[ctr1,ptr1]);
                     ptr1++;
                 }
                 ctr1++;
                 Console.WriteLine();
             }

            Console.WriteLine();
             for (int i = 0; i < Row; i++)
             {
                int Rsum = 0;
                 for (int j = 0; j < Col; j++)
                 {
                     Rsum = Rsum + arr[i, j];
                 }
                Console.WriteLine("Sum Of Row "+(i+1)+" Element :"+Rsum);
             }
            Console.WriteLine();
        //  Row minimum number start 
            int min;
            int min1;
            int min2;
            min = arr[0, 0];
            min1 = arr[1, 0];
            min2= arr[2, 0];
            int max = 0;
            int max1 = 0;
            int max2 = 0;
            for (int i = 0; i <Row; i++)
            {
                if (min > arr[0,i])
                {
                    min = arr[0, i];
                }
                if (min1>arr[1,i])
                {
                    min1 = arr[1, i];
                }
                if (min2 > arr[2, i])
                {
                    min2 = arr[2, i];
                }
                // Row maximum number start 
                if (max < arr[0, i])
                {
                    max = arr[0, i];
                }
                if (max1 < arr[1, i])
                {
                    max1 = arr[1, i];
                }
                if (max2 < arr[2, i])
                {
                    max2 = arr[2, i];
                }
            }

            Console.WriteLine("Minimum  number:" + min);
            Console.WriteLine("Minimum  number:" + min1);
            Console.WriteLine("Minimum  number:" + min2);

            Console.WriteLine();
            Console.WriteLine("maximum number :"+max);
            Console.WriteLine("maximum number :" + max1);
            Console.WriteLine("maximum number :" + max2);


            // column sum 
            Console.WriteLine();
            for (int i = 0; i < Row; i++)
            {
                int sum = 0;
                for (int j = 0; j < Col; j++)
                {
                    sum = sum + arr[j, i];
                }
                Console.WriteLine("Sum Of column " + (i + 1) + " Element :" + sum);

            }
            Console.WriteLine();
    
            // Columam manimam start
            int Cmin;
            int Cmin1;
            int Cmin2;
            Cmin = arr[0, 0];
            Cmin1 = arr[0, 1];
            Cmin2 = arr[0, 2];
            int Cmax = 0;
            int Cmax1 = 0;
            int Cmax2 = 0;
            for (int i = 0; i < Col; i++)
            {
                if (Cmin > arr[i, 0])
                {
                    Cmin = arr[i, 0];
                }
                if (Cmin1 > arr[i, 1])
                {
                    Cmin1 = arr[i, 1];
                }
                if (Cmin2 > arr[i, 2])
                {
                    Cmin2 = arr[i, 2];
                }
                // Column maximam start
                if (Cmax < arr[i, 0])
                {
                    Cmax = arr[i, 0];
                }
                if (Cmax1 < arr[i, 1])
                {
                    Cmax1 = arr[i, 1];
                }
                if (Cmax2 < arr[i, 2])
                {
                    Cmax2 = arr[i, 2];
                }
            }


            Console.WriteLine("Minimum  number:" + Cmin);
            Console.WriteLine("Minimum  number:" + Cmin1);
            Console.WriteLine("Minimum  number:" + Cmin2);
            Console.WriteLine();
            Console.WriteLine("maximum number :" + Cmax);
            Console.WriteLine("maximum number :" + Cmax1);
            Console.WriteLine("maximum number :" + Cmax2);

            Console.ReadLine();
        }
    }
        }
    

