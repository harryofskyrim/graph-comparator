using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*TO FIX
- Диаграмма ахрхитектуры: "Пользовательский ввод"
- Алгоритм проверки корректности ввода в документе проектирования - переписать
- Добавить ФТ про промежуточные результаты
- Ссылка на алгоритмы в проекте подсистем
- Сообщения об ошибках*/

namespace tppo_graphs
{
    class IncMatrix_for_return_value
    {
        int[][] m;
        int e;
        public IncMatrix_for_return_value(int[][] g, int vertices, int edjes)
        {
            g = new int[vertices][];
            for (int i = 0; i < vertices; i++)
            {
                m[i] = new int[edjes];
                g[i].CopyTo(this.m[i], 0);
            }
            e = edjes;
        }
    }

    class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        /* Функция метяет метсами значения двух целых чисел.
         * Параметры:
         *  ref int x, ref int y - два значения, которые нужно поменять местами
         * Ничего не возвращает, изменённые значения передаются в вызывающий метод
         * по ссылке.
         */
        public void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        /* Функция метяет метсами значения двух массивов целых чисел.
         * Параметры:
         *  ref int[] x, ref int[] y - два массива, которые нужно поменять местами
         * Ничего не возвращает, изменённые значения передаются в вызывающий метод
         * по ссылке.
         */
        public void swap(ref int[] x, ref int[] y, int n)
        {
            int[] z = new int[n];
            x.CopyTo(z, 0);
            y.CopyTo(x, 0);
            z.CopyTo(y, 0);
        }

        static Graph[] gr = new Graph[2];

        /* Функция создаёт матрицу смежности графа, описанного
         * в передаваемой матрице инцидентности.
         * Параметры:
         *  int[][] g - матрица инцидентности графа;
         *  int v - количество вершин в графе;
         *  int e - количество рёбер в графе.
         *  Возвращает двухмерный массив (матрицу смежности).
         **/
        public static int[][] inctoadj(int[][] g, int v, int e) 
        {
            int[][] ng = new int[v][];
            for (int i = 0; i < v; i++)
                ng[i] = new int[e];
            int e_start = 0, e_end = 0;
            for (int j = 0; j < e; j++)
            {
                e_end = -1;
                for (int i = 0; i < v; i++)
                {
                    if (e_end < 0 && g[i][j] == 1)
                        e_end = i;
                    else if (g[i][j] != 0)
                        e_start = i;
                }
                ng[e_start][e_end] = 1;
            }
            return ng;
        }

        /* Функция создаёт матрицу инцидентности графа, описанного
         * в передаваемой матрице смежности.
         * Параметры:
         *  int[][] g - матрица смежности графа;
         *  int v - количество вершин в графе;
         *  Возвращает класс IncMatrix_for_return_value, который
         *  представляет из себя пару: двухмерный массив (матрицу
         *  инцидентности) и целое число (количество рёбер).
         **/
        public static IncMatrix_for_return_value adjtoinc(int[][] g, int v)
        {
            int e = 0;
            bool flag = false;
            for (int i = 0; i < v; i++)
                for (int j = i+1; j < v; j++)
                    if(g[i][j] != g[j][i])
                    {
                        flag = true;
                        break;
                    }
            
            for (int i = 0; i < v; i++)
                for (int j = flag ? 0 : i+1; j < v; j++)
                        if(g[i][j] == 1)
                        {
                            e++;
                        }
            int[][] ng = new int[v][];
            for (int i = 0; i < v; i++)
                ng[i] = new int[e];
            
            e = 0;
            for (int i = 0; i < v; i++)
                for (int j = flag ? 0 : i+1; j < v; j++)
                        if(g[i][j] == 1)
                        {
                            ng[i][e] = flag ? -1 : 1;
                            ng[j][e] = 1;
                            e++;
                        }

            IncMatrix_for_return_value res = new IncMatrix_for_return_value(ng, v, e);
            return res;
        }


        /* Функция совершает обход графа в ширину из заданной
         * вершины и возвращает расстояния от неё до всех вершин
         * Параметры:
         *  int v - вершина,из которой начинается обход;
         *  Graph a - граф, по которому совершается обход.
         * Возвращает массив целых чисел, в iй ячейке которого
         * хранится количество вершин в графе на расстоянии i
         * от данной вершины.
         **/
        int[] iso_bfs (int v, Graph a)
        {
            int[] was = new int[a.v];
            int[] res = new int[a.v];
            for (int i = 0; i < v; i++)
                was[i] = -1;
            Array.Clear(res, 0, a.v);

            Queue<int> q = new Queue<int>();
            q.Enqueue(v);

            was[v] = 0;

            while (q.Count > 0)
            {
                v = q.Dequeue();
                for (int i = 0; i < v; i++)
                {
                    if (a.m[v][i] == 1 && was[i] < 0)
                    {
                        was[i] = Math.Min(was[i], was[v] + 1);
                        res[was[i]]++;
                        q.Enqueue(i);
                    }
                }
            }
            return res;
        }

        /* Функция считает вершинный инвариант графа
         * Параметры: Graph a - данный граф
         * Возвращает массив, в iй ячейке которого хранится
         * массив целых чисел, в jй ячейке которого хранится
         * количество вершин в графе на расстоянии j от вершины i.
         **/
        int[][] iso_inv(Graph a)
        {
            int[][] res = new int[a.v][];
            for (int i = 0; i < a.v; i++)
                res[i] = iso_bfs(i, a);
            return res;
        }

        /* Функция проверяет массив соответствий f на противоречия.
         * Параметры:
         *  int k - вершина из графа 1
         *  int j - вершина из графа 2
         *  int[] f - массив соответсвий вершин графов 1 и 2
         * Возвращает true, если для каждого ребра графа 1 [i][k]
         * существует ребро графа 2 [f[i]][j], иначе возвращает false.
         **/
        bool iso_canMatch(int k, int j, int[] f)
        {
            for (int i = 0; i < gr[0].v; i++)
            {
                if (gr[0].m[i][k] == 0 || gr[1].m[f[i]][j] == 0)
                    return false;
            }
            return true;
        }

        /* Функция переупорядочивает вершины в данном графе по возрастанию значений
         * массива im, меняя при этом ещё и матрицу инварианта графа.
         * Параметры:
         *  ref Graph a - данный граф
         *  ref int[][] inv - инвариант данного графа
         *  ref int[] im - значения, по которым будут упоряочиваться вершины графа
         *  int l - левая граница сортировки
         *  int r - правая граница сортировки
         *  Ничего не возвращает, изменённые значения передаются в вызывающий метод
         *  по ссылке.
         */
        void iso_reorder_sort(ref Graph a, ref int[][] inv, ref int[] im, int l, int r)
        {
            Random random = new Random();
            int x = im[l + random.Next(0, r - l)];
	        int i=l, j=r;
	        while(i<=j)
	        {
		        while(im[i]<x)
			        i++;
		        while(im[j]>x)
			        j--;
		        if(i<=j)
		        {
                    swap(ref im[i], ref im[j]);
                    swap(ref a.m[i], ref a.m[j], a.v);
                    swap(ref inv[i], ref inv[j], a.v);
			        i++;
			        j--;
		        }
	        }
	        if(l<j)
                iso_reorder_sort(ref a, ref inv, ref im, l, j);
	        if(i<r)
                iso_reorder_sort(ref a, ref inv, ref im, i, r);
        }

        /* Функция перенумерует вершины графа по инвариантной множественности.
         * Параметры:
         *  ref Graph a - данный граф
         *  ref int[][] inv - инвариант данного графа
         * Ничего не возвращает, изменённые значения Graph a и int[][] inv
         * передаются в вызывающий метод по ссылке.
         */
        void iso_reorder(ref Graph a, ref int[][] inv)
        {
            int[] im = new int[a.v];
            Array.Clear(im, 0, a.v);
            for(int i = 0; i < a.v; i++)
            {
                int[] im1 = new int[a.v];
                Array.Clear(im1, 0, a.v);
                for (int j = 0; j < a.v; j++)
                    im1[inv[i][j]]++;

                for (int j = 0; j < a.v; j++)
                    if (im1[j] > 1)
                        im[i] += im1[j];
            }

            iso_reorder_sort(ref a, ref inv, ref im, 0, a.v-1);
        }

        public static void isomorph()
        {

        }
        
        
        public static void metrics() { }
        public static void distance() { }

        /* Функция проверяет, является ли данный символ
         * одним из тех, которые ожидаются при вводе матрицы.
         * Параметры: char c - проверяемый символ.
         * Если символ принадлежит множетсву ожидаемых символов
         * при вводе матрицы, возвращает true, иначе false.
         **/
        static bool isAllowedChar(char c)
        {
            if (c == ' ' || c == '\t' || c == '\n' || c == '\r' || c == '0' || c == '1' || c == '-')
                return true;
            return false;
        }

        /* Функция проверяет пользовательский ввод графа
         * на корректность.
         * Параметры:
         *  string matrix - текст из поля ввода матрицы графа;
         *  string vertices - текст из поля ввода количества вершин графа;
         *  string edges - текст из поля ввода количества рёбер графа;
         *  int method - индекс метода ввода (0 - матрица смежности, 1 - инцидентности)
         *  int number - номер графа (1 - первый граф, 2 - второй граф)
         *  Form1 myform - ссылка на объект формы для доступа к её элементам (для дебага)
         * Возвращает коды ошибок:
         *  Form1.IC_OK = 0 - нет ошибок;
         *  Form1.IC_EXTRA_SYMBOLS = 1 - лишние символы во вводе;
         *  Form1.IC_NOT_A_MATRIX = 2 - ввод не является правильной матрицей;
         *  Form1.IC_WRONG_NUMBER_OF_V_OR_E = 3 - неправильное количество столбцов или строк;
         *  Form1.IC_MATRIX_ABSENT = 4 - не введена матрица;
         *  Form1.IC_WRONG_INPUT_VERTICES = 5 - не выбрано количество вершин;
         *  Form1.IC_WRONG_INPUT_EDGES = 6 - не выбрано количество рёбер;
         *  Form1.IC_INPUT_METHOD_NOT_CHOSEN = 7 - не выбран метод ввода;
         *  Form1.IC_INC_WRONG_FORMAT = 8 - одно ребро соединяет больше двух вершин в матрице инцидентности;
         * **/
        public static int isCorrect(string matrix, string vertices, string edges, int method, int number, Form1 myform)
        {
            if (method < 0)
                return Form1.IC_INPUT_METHOD_NOT_CHOSEN; //не выбран метод ввода
            int v=1, e=1;
            if (!int.TryParse(vertices, out v) || v < 0)
                return Form1.IC_WRONG_INPUT_VERTICES; //не выбрано количество вершин
            if (method == 1 && (!int.TryParse(edges, out e) || e < 0))
                return Form1.IC_WRONG_INPUT_EDGES; //не выбрано количество рёбер
            int[][] g = new int[v][];
            if (method == 1 && e == 0) //если вводится "пустая" матрица инцидентности графа без рёбер
            {
                for (int i = 0; i < v; i++)
                {
                    g[i] = new int[v];
                    for (int j = 0; j < v; j++)
                        g[i][j] = 0;
                }
            }
            else
            {
                if (matrix == "")
                    return Form1.IC_MATRIX_ABSENT; //не введена матрица
                string m = matrix + " ";
                if (method == 0)
                    e = v;

                int i;
                for (i = 0; i < v; i++)
                    g[i] = new int[e];
                int j = 0;
                i = 0;
                int n = -2; // заведомо некорректное значение
                int sign = 1;

                //myform.input_label.Text = Convert.ToString(v) + " " + Convert.ToString(e) + " ";
                for (int pos = 0; pos < m.Length; pos++)
                {
                    if (!isAllowedChar(m[pos]))
                    {
                        return Form1.IC_EXTRA_SYMBOLS; //лишние символы во вводе
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
                            {
                                //myform.input_label.Text += "NAM1";
                                return Form1.IC_NOT_A_MATRIX; //ввод не является правильной матрицей
                            }
                            sign = -1;
                        }
                        else if (m[pos] == '0' || m[pos] == '1')
                        {
                            if (n < -1)
                            {
                                n = sign * (Convert.ToInt32(m[pos]) - Convert.ToInt32('0'));
                                if (n == 0 && sign == -1)
                                {
                                    //myform.input_label.Text += "NAM2";
                                    return Form1.IC_NOT_A_MATRIX; //ввод не является правильной матрицей
                                }
                            }
                            else
                            {
                                //myform.input_label.Text += "NAM3";
                                return Form1.IC_NOT_A_MATRIX; //ввод не является правильной матрицей
                            }
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
                                return Form1.IC_WRONG_NUMBER_OF_V_OR_E; //неправильное количество столбцов или строк
                            g[i][j] = n;
                            n = -2;
                            j++;
                        }
                        else if (m[pos] == '\r' && j < e)
                        {
                            //myform.input_label.Text += "NAM4";
                            return Form1.IC_NOT_A_MATRIX; //ввод не является правильной матрицей
                        }

                        //myform.input_label.Text += Convert.ToString(i) + " " + Convert.ToString(j) + " " + Convert.ToString(n) + "  ";

                    }
                }
                //myform.input_label.Text = Convert.ToString(i) + " " + Convert.ToString(j) + " " + Convert.ToString(v) + " " + Convert.ToString(e);
                if (!(i == v - 1 && j == e) && !(i == v && j == 0))
                {
                    //myform.input_label.Text += "NAM5";
                    return Form1.IC_NOT_A_MATRIX; //ввод не является правильной матрицей
                }

                if (method == 2)
                {
                    int cnt;
                    for (j = 0; j < e; j++)
                    {
                        cnt = 0;
                        for (i = 0; i < v && cnt <= 2; i++)
                            if (g[j][i] != 0)
                                cnt++;
                        if (cnt > 2)
                            return Form1.IС_INC_WRONG_FORMAT;
                    }

                    g = inctoadj(g, v, e);
                }
            }

            Graph a = new Graph(g, v);
            gr[number - 1] = a;
            return Form1.IC_OK; //успешное завершение
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
