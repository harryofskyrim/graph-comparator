using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tppo_graphs
{
    class Graph
    {
        int v; //количество строк
        int[][] m; //матрица смежности графа

        public Graph(int[][] g, int vertices)
        {
            this.m = new int[vertices][];
            for (int i = 0; i < v; i++)
            {
                m[i] = new int[vertices];
                g[i].CopyTo(this.m[i], 0);
            }
            v = vertices;
        }

        /* Проверка графа на соответсвие определениию дерева
         * (отсутствие циклов и связность).
         * Не принимает параметров.
         * Если граф является деревом - возвращает true,
         * иначе false.
         **/
        static bool isTree() { return true; }
    }
}
