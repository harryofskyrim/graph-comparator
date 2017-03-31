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

        static void isomorph(Graph grph) {}
        static void metrics(Graph grph) {}
        static void distance(Graph grph) {}

        static bool isTree(Graph grph) { return true; }

        static bool isAllowedChar(char c, Form1 myform)
        {
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r' || (c >= '0' && c <= '9'))
                return true;
            return false;
        }

        public static int isCorrect(string matrix, string vertices, string edges, int method, Form1 myform)
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
            int n = -1;
            for (int pos = 0; pos < m.Length; pos++)
            {
                if (!isAllowedChar(m[pos], myform))
                {
                    return 1; //лишние символы во вводе
                }
                else
                {
                    //debug
                    //char c = m[pos];
                    //myform.input_label.Text += Convert.ToString((int)c) + " ";

                    if (m[pos] >= '0' && m[pos] <= '9')
                    {
                        if (n < 0)
                            n = 0;
                        n = n * 10 + Convert.ToInt32(m[pos]);
                    }
                    else if (n >= 0)
                    {
                        if (j == e)
                        {
                            j = 0;
                            i++;
                        }
                        if(i==v)
                            return 3; //неправильное количество столбцов или строк
                        g[i][j] = n;
                        n = -1;
                        j++;
                    }
                    else if (m[pos] == '\r' && j < e)
                        return 2; //ввод не является правильной матрицей
                }
            }
            if (!(i == v-1 && j == e) && !(i == v && j == 0))
                return 2; //ввод не является правильной матрицей

            Graph a = new Graph(g, v);

            isomorph(a);
            metrics(a);
            distance(a);
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
