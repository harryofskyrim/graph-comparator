﻿using System;

namespace tppo_graphs
{
    class Graph
    {
        public int v; //количество строк
        public int[][] m; //матрица смежности графа

        public Graph(int[][] g, int vertices)
        {
            m = new int[vertices][];
            v = vertices;
            for (int i = 0; i < v; i++)
            {
                m[i] = new int[vertices];
                g[i].CopyTo(m[i], 0);
            }
        }

        public Graph(Graph a)
        {
            m = new int[a.v][];
            v = a.v;
            for (int i = 0; i < v; i++)
            {
                m[i] = new int[a.v];
                a.m[i].CopyTo(m[i], 0);
            }
        }

        /* Обход графа в глубину с проверкой на наличие циклов.
         * Параметры:
         *  int[] was - массив посещённых вершин;
         *  int vertex - рассматриваемая вершина;
         *  int prev - родительская вершина в дереве обхода.
         * Возвращает false, если находит цикл в графе,
         * иначе возвращает true.
         * **/
        bool dfs(int[] was, int vertex, int prev) 
        {
            was[vertex] = 1;
            for (var i = 0; i < v; i++)
            {
                if (m[vertex][i] == 1 && was[i] == 1 && i != prev)
                {
                    return false;
                }

                if (m[vertex][i] != 1 || was[i] != 0) continue;

                if(!dfs(was, i, vertex))
                {
                    return false;
                }
            }
            return true;
        }

        /* Проверка графа на соответсвие определениию дерева
         * (отсутствие циклов и связность).
         * Не принимает параметров.
         * Если граф является деревом - возвращает true,
         * иначе false.
         **/
        public bool IsTree()
        {
            int[] was = new int[v];
            Array.Clear(was, 0, v);
            if (!dfs(was, 0, 0))
                return false;
            for (int i = 0; i < v; i++)
                if (was[i] == 0)
                    return false;
            return true;
        }
    }
}
