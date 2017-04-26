using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tppo_graphs
{
    public partial class Form1 : Form
    {
        int splitter_to_analyze_button;
        int splitter_to_groupBoxes;
        int splitter_to_textBoxes;
        int splitter_to_tabControl;
        int splitter_to_tabPages;
        int splitter_to_tabTextBoxes;

        // коды ошибок, возвращаемых isCorrect():                
        public const int IC_OK = 0; //do further analysis
        public const int IC_EXTRA_SYMBOLS = 1; //лишние символы во вводе
        public const int IC_NOT_A_MATRIX = 2; //ввод не является правильной матрицей
        public const int IC_WRONG_NUMBER_OF_V_OR_E = 3; //неправильное количество столбцов или строк
        public const int IC_MATRIX_ABSENT = 4; //не введена матрица
        public const int IC_WRONG_INPUT_VERTICES = 5; //не выбрано количество вершин
        public const int IC_WRONG_INPUT_EDGES = 6; //не выбрано количество рёбер
        public const int IC_INPUT_METHOD_NOT_CHOSEN = 7; //не выбран метод ввода
        public const int IС_INC_WRONG_FORMAT = 8; //одно ребро соединяет больше двух вершин в матрице инцидентности

        public Form1()
        {
            InitializeComponent();
            splitter_to_analyze_button = splitContainer1.SplitterDistance - analyze_button.Location.Y;
            splitter_to_groupBoxes = splitContainer1.SplitterDistance - groupBox1.Size.Height;
            splitter_to_textBoxes = splitContainer1.SplitterDistance - textBox_matrix1.Size.Height;
            //splitter_to_tabControl = splitContainer1.SplitterDistance + tabControl1.Size.Height;
            //splitter_to_tabPages = splitContainer1.SplitterDistance + isomorph_tabPage.Size.Height;
            //splitter_to_tabTextBoxes = splitContainer1.SplitterDistance + isomorph_textBox.Size.Height;
        }

        /* Функция делает поле ввода количества рёбер графа 1 видимым,
         * если у графа 1 выбран метод ввода "Матрица инцидентности",
         * и скрывает поле ввода количества рёбер, если у графа 1
         * выбран метод ввода "Матрица смежности".
         * Параметры:
         *  object sender, eventArgs e - параметры функции по умолчанию
         * **/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                enter_ed_label1.Visible = false;
                textBox_edges1.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1) {
                enter_ed_label1.Visible = true;
                textBox_edges1.Visible = true;
            }

        }

        /* Функция делает поле ввода количества рёбер графа 2 видимым,
         * если у графа 2 выбран метод ввода "Матрица инцидентности",
         * и скрывает поле ввода количества рёбер, если у графа 2
         * выбран метод ввода "Матрица смежности".
         * Параметры:
         *  object sender, eventArgs e - параметры функции по умолчанию
         * **/
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) {
                enter_ed_label2.Visible = false;
                textBox_edges2.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 1) {
                enter_ed_label2.Visible = true;
                textBox_edges2.Visible = true;
            }
        }

        /* Функция вызывает проверку ввода графов на корректность;
         * в случае ошибок ввода выводит сообщение об ошибке,
         * в случае, если проверка на корректность ввода пройдена - 
         * вызывает функции анализа пар графов.
         * Параметры:
         *  object sender, eventArgs e - параметры функции по умолчанию
         * **/
        private void analyze_button_Click(object sender, EventArgs e)
        {
            bool check1 = false, check2 = false;

            // checking whether the first graph input is correct
            switch (Program.isCorrect(textBox_matrix1.Text, textBox_vertices1.Text, textBox_edges1.Text, comboBox1.SelectedIndex, 1, this))
            {
                case IC_OK:
                    {
                        //do further analysis
                        check1 = true;
                        break;
                    }
                case IC_EXTRA_SYMBOLS:
                    {
                        //лишние символы во вводе
                        MessageBox.Show("В поле ввода матрицы для графа 1 замечены лишние символы.\nВ поле ввода можно вводить только пробельные символы, символ минуса и цифры 0 и 1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_NOT_A_MATRIX:
                    {
                        //ввод не является правильной матрицей
                        MessageBox.Show("Ввод в поле ввода матрицы для графа 1 не является правильной матрицей.\nПравильная матрица должна состоять из заданного количества строк, разделённых переводами строк, и содержать в каждой строке заданное количество целых чисел, разделённых пробелами.\nЕсли выбран метод ввода матрицей смежности, числами должны быть 0 или 1; если методом ввода выбрана матрица инцидентности - 0, 1 и -1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_WRONG_NUMBER_OF_V_OR_E:
                    {
                        //неправильное количество столбцов или строк
                        MessageBox.Show("Ввод в поле ввода матрицы для графа 1 предусматривает иное количество столбцов или строк, чем заданное.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_MATRIX_ABSENT:
                    {
                        //не введена матрица
                        MessageBox.Show("Отсутствует ввод в поле ввода матрицы для графа 1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_WRONG_INPUT_VERTICES:
                    {
                        //не выбрано количество вершин
                        MessageBox.Show("Отсуствует ввод в поле ввода количества вершин для графа 1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_WRONG_INPUT_EDGES:
                    {
                        //не выбрано количество рёбер
                        MessageBox.Show("Отсуствует ввод в поле ввода количества рёбер для графа 1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IC_INPUT_METHOD_NOT_CHOSEN:
                    {
                        //не выбран метод ввода
                        MessageBox.Show("Не выбран тип вводимой матрицы для графа 1.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
                case IС_INC_WRONG_FORMAT:
                    {
                        //одно ребро соединяет больше двух вершин в матрице инцидентности
                        MessageBox.Show("Матрица графа 1 некорректна. В каждом столбце матрицы инцидентности должно быть ровно два числа на некоторых строках i и j. Это либо 1 на i и 1 на j, если описывается ребро неориентированного графа между вершинами i и j, либо это -1 на i и 1 на j, если описывается дуга ориентированного графа из i в j.", "Ошибка ввода", MessageBoxButtons.OK);
                        break;
                    }
            }

            if (check1)
            {
                // checking whether the second graph input is correct
                switch (Program.isCorrect(textBox_matrix2.Text, textBox_vertices2.Text, textBox_edges2.Text, comboBox2.SelectedIndex, 2, this))
                {
                    case IC_OK:
                        {
                            //do further analysis
                            check2 = true;
                            break;
                        }
                    case IC_EXTRA_SYMBOLS:
                        {
                            //лишние символы во вводе
                            MessageBox.Show("В поле ввода матрицы для графа 2 замечены лишние символы.\nВ поле ввода можно вводить только пробельные символы, символ минуса и цифры 0 и 1.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_NOT_A_MATRIX:
                        {
                            //ввод не является правильной матрицей
                            MessageBox.Show("Ввод в поле ввода матрицы для графа 2 не является правильной матрицей.\nПравильная матрица должна состоять из заданного количества строк, разделённых переводами строк, и содержать в каждой строке заданное количество целых чисел, разделённых пробелами.\nЕсли выбран метод ввода матрицей смежности, числами должны быть 0 или 1; если методом ввода выбрана матрица инцидентности - 0, 1 и -1.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_WRONG_NUMBER_OF_V_OR_E:
                        {
                            //неправильное количество столбцов или строк
                            MessageBox.Show("Ввод в поле ввода матрицы для графа 2 предусматривает иное количество столбцов или строк, чем заданное.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_MATRIX_ABSENT:
                        {
                            //не введена матрица
                            MessageBox.Show("Отсутствует ввод в поле ввода матрицы для графа 2.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_WRONG_INPUT_VERTICES:
                        {
                            //не выбрано количество вершин
                            MessageBox.Show("Отсуствует ввод в поле ввода количества вершин для графа 2.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_WRONG_INPUT_EDGES:
                        {
                            //не выбрано количество рёбер
                            MessageBox.Show("Отсуствует ввод в поле ввода количества рёбер для графа 2.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IC_INPUT_METHOD_NOT_CHOSEN:
                        {
                            //не выбран метод ввода
                            MessageBox.Show("Не выбран тип вводимой матрицы для графа 2.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                    case IС_INC_WRONG_FORMAT:
                        {
                            //одно ребро соединяет больше двух вершин в матрице инцидентности
                            MessageBox.Show("Матрица графа 2 некорректна. В каждом столбце матрицы инцидентности должно быть ровно два числа на некоторых строках i и j. Это либо 1 на i и 1 на j, если описывается ребро неориентированного графа между вершинами i и j, либо это -1 на i и 1 на j, если описывается дуга ориентированного графа из i в j.", "Ошибка ввода", MessageBoxButtons.OK);
                            break;
                        }
                }

                if (check2)
                {
                    Program.isomorph();
                    Program.metrics();
                    Program.distance();
                }
            }
        }

        /* Функция, меняющая размер или положение элементов
         * формы в завиисимости от положения разделителя.
         *  object sender, SplitterEventArgs e - параметры функции по умолчанию
         * **/
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int splitter = splitContainer1.SplitterDistance;

            this.analyze_button.Location = new Point(this.analyze_button.Location.X, splitter - splitter_to_analyze_button);
            this.groupBox1.Size = new Size(this.groupBox1.Size.Width, splitter - splitter_to_groupBoxes);
            this.groupBox2.Size = new Size(this.groupBox2.Size.Width, splitter - splitter_to_groupBoxes);
            this.textBox_matrix1.Size = new Size(this.textBox_matrix1.Size.Width, splitter - splitter_to_textBoxes);
            this.textBox_matrix2.Size = new Size(this.textBox_matrix2.Size.Width, splitter - splitter_to_textBoxes);

            //this.tabControl1.Size = new Size(this.tabControl1.Size.Width, splitter - splitter_to_tabControl);
            //this.isomorph_tabPage.Size = new Size(this.isomorph_tabPage.Size.Width, splitter_to_tabPages - splitter);
            //this.metrics_tabPage.Size = new Size(this.isomorph_tabPage.Size.Width, splitter_to_tabPages - splitter);
            //this.distance_tabPage.Size = new Size(this.isomorph_tabPage.Size.Width, splitter_to_tabPages - splitter);
            //this.isomorph_textBox.Size = new Size(this.isomorph_textBox.Size.Width, splitter_to_textBoxes - splitter);
            //this.metrics_textBox.Size = new Size(this.isomorph_textBox.Size.Width, splitter_to_textBoxes - splitter);
            //this.distance_textBox.Size = new Size(this.isomorph_textBox.Size.Width, splitter_to_textBoxes - splitter);

            //input_label.Text = Convert.ToString(tabControl1.Size.Height);
        }
    }
}
