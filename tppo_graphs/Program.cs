using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tppo_graphs
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        static Graph[] gr = new Graph[2];

        public static void isomorph() {}
        public static void metrics() { }
        public static void distance() { }

        static bool isTree(Graph grph) { return true; }

        static bool isAllowedChar(char c)
        {
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r' || c == '0' || c == '1' || c == '-')
                return true;
            return false;
        }

        public static int isCorrect(string matrix, string vertices, string edges, int method, int number, Form1 myform)
        {
            if (method < 0)
                return 7; //не выбран метод ввода
            int v=1, e=1;
            if (!int.TryParse(vertices, out v))
                return 5; //не выбрано количество вершин
            if (method == 1 && !int.TryParse(edges, out e))
                return 6; //не выбрано количество рёбер
            if (matrix == "")
                return 4; //не введена матрица
            string m = matrix + " ";
            if (method == 0)
                e = v;

            int[][] g = new int[v][];
            int i;
            for (i = 0; i < v; i++)
                g[i] = new int[e];
            int j = 0;
            i = 0;
            int n = -2; // заведомо некорректное значение
            int sign = 1;

            myform.input_label.Text = Convert.ToString(v) + " " + Convert.ToString(e) + " ";
            for (int pos = 0; pos < m.Length; pos++)
            {
                if (!isAllowedChar(m[pos]))
                {
                    return 1; //лишние символы во вводе
                }
                else
                {
                    //debug
                    //char c = m[pos];
                    //myform.input_label.Text += Convert.ToString((int)c) + " ";

                    if (m[pos] == '-')
                    {
                        myform.input_label.Text += "-";
                        if (method == 0 || sign == -1)
                            return 2; //ввод не является правильной матрицей
                        sign = -1;
                    }
                    else if (m[pos] == '0' || m[pos] == '1')
                    {
                        if (n < -1)
                        {
                            //n = sign * (Convert.ToInt32(m[pos]) - Convert.ToInt32('0'));
                            if (n == 0 && sign == -1)
                                return 2; //ввод не является правильной матрицей
                        }
                        else
                            return 2; //ввод не является правильной матрицей
                        sign = 1;
                        //myform.input_label.Text += "n";
                    }
                    else if (n >= -method) //если м.с. то 0, если м.и. то -1
                    {
                        //myform.input_label.Text += "w";
                        if (j == e)
                        {
                            j = 0;
                            i++;
                        }
                        if (i == v)
                            return 3; //неправильное количество столбцов или строк
                        g[i][j] = n;
                        n = -2;
                        j++;
                    }
                    else if (m[pos] == '\r' && j < e)
                        return 2; //ввод не является правильной матрицей

                    //myform.input_label.Text += Convert.ToString(i) + " " + Convert.ToString(j) + " " + Convert.ToString(n) + "  ";

                }
            }
            //myform.input_label.Text = Convert.ToString(i) + " " + Convert.ToString(j) + " " + Convert.ToString(v) + " " + Convert.ToString(e);
            if (!(i == v-1 && j == e) && !(i == v && j == 0))
                return 2; //ввод не является правильной матрицей

            Graph a = new Graph(g, v);
            gr[number - 1] = a;
            return 0;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
