using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Data
    {
        private Object thisLock = new Object();
        public static Queue<string> answers;
        const int knight_code = 99;
        public int[,] mat;
        public int num;
        public int i;
        public int j;

        public Data(int[,] mat,int num,int i,int j)
        {
            this.mat = mat; 
            this.num = num;
            this.i = i;
            this.j = j;
        }

        void check_mat(int[,] mat)
        {
            bool flag = true;
            for (int i = 0; i < 8; i++)
                for (int j = 0;j < 8; j++)
                    if (mat[i, j] == 0)
                        flag = false;
            if (flag)
                print_mat(mat);
            //print(":) we cover all 64 squares \n")

        }

        private void print_mat(int[,] mat)
        {

            lock (thisLock)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(mat[i, j] + "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }

        }
        private int[,] deep_copy_mat(int[,] mat)
        {
            int[,] a = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    a[i, j] = mat[i, j];
            return a;
        }
        public void try_run()
        {
           
            //# i,j=find_knight(mat)
            mat[i, j] = num;
            int[,] move;
            /*
            if (num >= 63)
            {
                Console.Write("");
                print_mat(mat);
            }
            */
            if (num == 64)
            {
                check_mat(mat);

                return;
            }

            if(i+1>=0 && j+2>=0 && i + 1 <=7 && j + 2 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i + 1, j + 2] == 0)
                {

                    move[i + 1, j + 2] = knight_code;
                    (new Data(move, num + 1, i + 1, j + 2)).try_run();
                }
            }


            if (i + 1 >= 0 && j - 2 >= 0 && i + 1 <= 7 && j - 2 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i + 1, j - 2] == 0)
                {
                    move[i + 1, j - 2] = knight_code;
                    (new Data(move, num + 1, i + 1, j - 2)).try_run();
                }
            }


            if (i - 1 >= 0 && j + 2 >= 0 && i - 1 <= 7 && j + 2 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i - 1, j + 2] == 0)
                {
                    move[i - 1, j + 2] = knight_code;
                    (new Data(move, num + 1, i - 1, j + 2)).try_run();
                }
            }


            if (i - 1 >= 0 && j - 2 >= 0 && i - 1 <= 7 && j - 2 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i - 1, j - 2] == 0)
                {
                    move[i - 1, j - 2] = knight_code;
                    (new Data(move, num + 1, i - 1, j - 2)).try_run();
                }
            }


            if (i + 2 >= 0 && j + 1 >= 0 && i + 2 <= 7 && j + 1 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i + 2, j + 1] == 0)
                {
                    move[i + 2, j + 1] = knight_code;
                    (new Data(move, num + 1, i + 2, j + 1)).try_run();
                }
            }


            if (i + 2 >= 0 && j - 1 >= 0 && i + 2 <= 7 && j - 1 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i + 2, j - 1] == 0)
                {
                    move[i + 2, j - 1] = knight_code;
                    (new Data(move, num + 1, i + 2, j -1)).try_run();
                }
            }


            if (i - 2 >= 0 && j + 1 >= 0 && i - 2 <= 7 && j + 1 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i - 2, j + 1] == 0)
                {
                    move[i - 2, j + 1] = knight_code;
                    (new Data(move, num + 1, i -2, j + 1)).try_run();
                }
            }


            if (i - 2 >= 0 && j - 1 >= 0 && i - 2 <= 7 && j - 1 <= 7)
            {
                move = deep_copy_mat(mat);
                if (move[i - 2, j - 1] == 0)
                {
                    move[i - 2, j - 1] = knight_code;
                    (new Data(move, num + 1, i -2, j -1)).try_run();
                }
            }
            
        }
    }
}
