using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Create
    {
        const int knight_code = 99;
        public static  int[,] make_empty_board() 
        {
            int[,] mat = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    mat[i,j] = 0;

            return mat;
        }
        




        private static int[,] deep_copy_mat(int[,] mat) {
            int[,] a = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    a[i, j] = mat[i, j];
           return a;
        }



        private static void put_knight(int[,] mat) {
            int[,] a;
            Thread t;
            Queue<Thread> queue=new Queue<Thread>();
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {

                    a = deep_copy_mat(mat);
                    a[i, j] = knight_code;
                    Data b = new Data(a, 1, i, j);
                   //b.try_run();
                    
                    Thread newThread = new Thread(b.try_run);
                    queue.Enqueue(newThread);
                    
                }
            for (int i = 0; i < queue.Count; i++)
            {
                t= queue.Dequeue();
                t.Start();
                queue.Enqueue(t);
            }
            for (int i = 0; i < queue.Count; i++)
            {
                t = queue.Dequeue();
                t.Join();
                queue.Enqueue(t);
            }


        }

        

        
        

            public static void start() {
                //print("hello")
                int[,] a = make_empty_board();
                // print_mat(a)
                put_knight(a);
                //print("end of program")
            }
        }
    


   }

