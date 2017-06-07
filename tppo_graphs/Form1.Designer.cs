namespace tppo_graphs
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.analyze_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enter_matrix_label2 = new System.Windows.Forms.Label();
            this.textBox_matrix2 = new System.Windows.Forms.TextBox();
            this.enter_ed_label2 = new System.Windows.Forms.Label();
            this.enter_ve_label2 = new System.Windows.Forms.Label();
            this.textBox_edges2 = new System.Windows.Forms.TextBox();
            this.textBox_vertices2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enter_matrix_label1 = new System.Windows.Forms.Label();
            this.textBox_matrix1 = new System.Windows.Forms.TextBox();
            this.enter_ed_label1 = new System.Windows.Forms.Label();
            this.enter_ve_label1 = new System.Windows.Forms.Label();
            this.textBox_edges1 = new System.Windows.Forms.TextBox();
            this.textBox_vertices1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.input_label = new System.Windows.Forms.Label();
            this.advanced_view_checkBox = new System.Windows.Forms.CheckBox();
            this.output_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.isomorph_tabPage = new System.Windows.Forms.TabPage();
            this.isomorph_textBox = new System.Windows.Forms.TextBox();
            this.metrics_tabPage = new System.Windows.Forms.TabPage();
            this.metrics_textBox = new System.Windows.Forms.TextBox();
            this.distance_tabPage = new System.Windows.Forms.TabPage();
            this.distance_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.isomorph_tabPage.SuspendLayout();
            this.metrics_tabPage.SuspendLayout();
            this.distance_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.analyze_button);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.input_label);
            this.splitContainer1.Panel1MinSize = 330;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.advanced_view_checkBox);
            this.splitContainer1.Panel2.Controls.Add(this.output_label);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(434, 621);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.SplitterIncrement = 10;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // analyze_button
            // 
            this.analyze_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyze_button.Location = new System.Drawing.Point(174, 294);
            this.analyze_button.Name = "analyze_button";
            this.analyze_button.Size = new System.Drawing.Size(87, 32);
            this.analyze_button.TabIndex = 10;
            this.analyze_button.Text = "Анализ";
            this.analyze_button.UseVisualStyleBackColor = true;
            this.analyze_button.Click += new System.EventHandler(this.analyze_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enter_matrix_label2);
            this.groupBox2.Controls.Add(this.textBox_matrix2);
            this.groupBox2.Controls.Add(this.enter_ed_label2);
            this.groupBox2.Controls.Add(this.enter_ve_label2);
            this.groupBox2.Controls.Add(this.textBox_edges2);
            this.groupBox2.Controls.Add(this.textBox_vertices2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(223, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 263);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Граф 2";
            // 
            // enter_matrix_label2
            // 
            this.enter_matrix_label2.AutoSize = true;
            this.enter_matrix_label2.Location = new System.Drawing.Point(6, 128);
            this.enter_matrix_label2.Name = "enter_matrix_label2";
            this.enter_matrix_label2.Size = new System.Drawing.Size(88, 13);
            this.enter_matrix_label2.TabIndex = 4;
            this.enter_matrix_label2.Text = "Матрица графа:";
            // 
            // textBox_matrix2
            // 
            this.textBox_matrix2.AcceptsReturn = true;
            this.textBox_matrix2.AcceptsTab = true;
            this.textBox_matrix2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_matrix2.Location = new System.Drawing.Point(7, 144);
            this.textBox_matrix2.Multiline = true;
            this.textBox_matrix2.Name = "textBox_matrix2";
            this.textBox_matrix2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_matrix2.Size = new System.Drawing.Size(187, 112);
            this.textBox_matrix2.TabIndex = 3;
            this.textBox_matrix2.WordWrap = false;
            // 
            // enter_ed_label2
            // 
            this.enter_ed_label2.AutoSize = true;
            this.enter_ed_label2.Location = new System.Drawing.Point(6, 89);
            this.enter_ed_label2.Name = "enter_ed_label2";
            this.enter_ed_label2.Size = new System.Drawing.Size(145, 13);
            this.enter_ed_label2.TabIndex = 2;
            this.enter_ed_label2.Text = "Количество рёбер в графе:";
            // 
            // enter_ve_label2
            // 
            this.enter_ve_label2.AutoSize = true;
            this.enter_ve_label2.Location = new System.Drawing.Point(6, 50);
            this.enter_ve_label2.Name = "enter_ve_label2";
            this.enter_ve_label2.Size = new System.Drawing.Size(153, 13);
            this.enter_ve_label2.TabIndex = 2;
            this.enter_ve_label2.Text = "Количество вершин в графе:";
            // 
            // textBox_edges2
            // 
            this.textBox_edges2.Location = new System.Drawing.Point(7, 105);
            this.textBox_edges2.Name = "textBox_edges2";
            this.textBox_edges2.Size = new System.Drawing.Size(41, 20);
            this.textBox_edges2.TabIndex = 1;
            // 
            // textBox_vertices2
            // 
            this.textBox_vertices2.Location = new System.Drawing.Point(7, 66);
            this.textBox_vertices2.Name = "textBox_vertices2";
            this.textBox_vertices2.Size = new System.Drawing.Size(41, 20);
            this.textBox_vertices2.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Матрица смежности",
            "Матрица инцидентности"});
            this.comboBox2.Location = new System.Drawing.Point(7, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Метод ввода графа...";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enter_matrix_label1);
            this.groupBox1.Controls.Add(this.textBox_matrix1);
            this.groupBox1.Controls.Add(this.enter_ed_label1);
            this.groupBox1.Controls.Add(this.enter_ve_label1);
            this.groupBox1.Controls.Add(this.textBox_edges1);
            this.groupBox1.Controls.Add(this.textBox_vertices1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Граф 1";
            // 
            // enter_matrix_label1
            // 
            this.enter_matrix_label1.AutoSize = true;
            this.enter_matrix_label1.Location = new System.Drawing.Point(6, 128);
            this.enter_matrix_label1.Name = "enter_matrix_label1";
            this.enter_matrix_label1.Size = new System.Drawing.Size(88, 13);
            this.enter_matrix_label1.TabIndex = 4;
            this.enter_matrix_label1.Text = "Матрица графа:";
            // 
            // textBox_matrix1
            // 
            this.textBox_matrix1.AcceptsReturn = true;
            this.textBox_matrix1.AcceptsTab = true;
            this.textBox_matrix1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_matrix1.Location = new System.Drawing.Point(7, 144);
            this.textBox_matrix1.Multiline = true;
            this.textBox_matrix1.Name = "textBox_matrix1";
            this.textBox_matrix1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_matrix1.Size = new System.Drawing.Size(187, 112);
            this.textBox_matrix1.TabIndex = 3;
            this.textBox_matrix1.WordWrap = false;
            // 
            // enter_ed_label1
            // 
            this.enter_ed_label1.AutoSize = true;
            this.enter_ed_label1.Location = new System.Drawing.Point(6, 89);
            this.enter_ed_label1.Name = "enter_ed_label1";
            this.enter_ed_label1.Size = new System.Drawing.Size(145, 13);
            this.enter_ed_label1.TabIndex = 2;
            this.enter_ed_label1.Text = "Количество рёбер в графе:";
            // 
            // enter_ve_label1
            // 
            this.enter_ve_label1.AutoSize = true;
            this.enter_ve_label1.Location = new System.Drawing.Point(6, 50);
            this.enter_ve_label1.Name = "enter_ve_label1";
            this.enter_ve_label1.Size = new System.Drawing.Size(153, 13);
            this.enter_ve_label1.TabIndex = 2;
            this.enter_ve_label1.Text = "Количество вершин в графе:";
            // 
            // textBox_edges1
            // 
            this.textBox_edges1.Location = new System.Drawing.Point(9, 105);
            this.textBox_edges1.Name = "textBox_edges1";
            this.textBox_edges1.Size = new System.Drawing.Size(41, 20);
            this.textBox_edges1.TabIndex = 1;
            // 
            // textBox_vertices1
            // 
            this.textBox_vertices1.Location = new System.Drawing.Point(9, 66);
            this.textBox_vertices1.Name = "textBox_vertices1";
            this.textBox_vertices1.Size = new System.Drawing.Size(41, 20);
            this.textBox_vertices1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Матрица смежности",
            "Матрица инцидентности"});
            this.comboBox1.Location = new System.Drawing.Point(7, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Метод ввода графа...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_label.Location = new System.Drawing.Point(170, 9);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(93, 16);
            this.input_label.TabIndex = 7;
            this.input_label.Text = "Ввод графов";
            // 
            // advanced_view_checkBox
            // 
            this.advanced_view_checkBox.AutoSize = true;
            this.advanced_view_checkBox.Location = new System.Drawing.Point(5, 23);
            this.advanced_view_checkBox.Name = "advanced_view_checkBox";
            this.advanced_view_checkBox.Size = new System.Drawing.Size(299, 17);
            this.advanced_view_checkBox.TabIndex = 2;
            this.advanced_view_checkBox.Text = "Показывать промежуточные результаты вычислений";
            this.advanced_view_checkBox.UseVisualStyleBackColor = true;
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_label.Location = new System.Drawing.Point(146, 4);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(146, 16);
            this.output_label.TabIndex = 1;
            this.output_label.Text = "Результаты анализа";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.isomorph_tabPage);
            this.tabControl1.Controls.Add(this.metrics_tabPage);
            this.tabControl1.Controls.Add(this.distance_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // isomorph_tabPage
            // 
            this.isomorph_tabPage.Controls.Add(this.isomorph_textBox);
            this.isomorph_tabPage.Location = new System.Drawing.Point(4, 22);
            this.isomorph_tabPage.Name = "isomorph_tabPage";
            this.isomorph_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.isomorph_tabPage.Size = new System.Drawing.Size(425, 217);
            this.isomorph_tabPage.TabIndex = 0;
            this.isomorph_tabPage.Text = "Изоморфизм графов";
            this.isomorph_tabPage.UseVisualStyleBackColor = true;
            // 
            // isomorph_textBox
            // 
            this.isomorph_textBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isomorph_textBox.Location = new System.Drawing.Point(8, 6);
            this.isomorph_textBox.Multiline = true;
            this.isomorph_textBox.Name = "isomorph_textBox";
            this.isomorph_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.isomorph_textBox.Size = new System.Drawing.Size(409, 205);
            this.isomorph_textBox.TabIndex = 1;
            // 
            // metrics_tabPage
            // 
            this.metrics_tabPage.Controls.Add(this.metrics_textBox);
            this.metrics_tabPage.Location = new System.Drawing.Point(4, 22);
            this.metrics_tabPage.Name = "metrics_tabPage";
            this.metrics_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.metrics_tabPage.Size = new System.Drawing.Size(425, 217);
            this.metrics_tabPage.TabIndex = 1;
            this.metrics_tabPage.Text = "Метрики";
            this.metrics_tabPage.UseVisualStyleBackColor = true;
            // 
            // metrics_textBox
            // 
            this.metrics_textBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metrics_textBox.Location = new System.Drawing.Point(8, 6);
            this.metrics_textBox.Multiline = true;
            this.metrics_textBox.Name = "metrics_textBox";
            this.metrics_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.metrics_textBox.Size = new System.Drawing.Size(409, 228);
            this.metrics_textBox.TabIndex = 2;
            // 
            // distance_tabPage
            // 
            this.distance_tabPage.Controls.Add(this.distance_textBox);
            this.distance_tabPage.Location = new System.Drawing.Point(4, 22);
            this.distance_tabPage.Name = "distance_tabPage";
            this.distance_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.distance_tabPage.Size = new System.Drawing.Size(425, 217);
            this.distance_tabPage.TabIndex = 2;
            this.distance_tabPage.Text = "Расстояние между деревьями";
            this.distance_tabPage.UseVisualStyleBackColor = true;
            // 
            // distance_textBox
            // 
            this.distance_textBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance_textBox.Location = new System.Drawing.Point(8, 6);
            this.distance_textBox.Multiline = true;
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.distance_textBox.Size = new System.Drawing.Size(409, 228);
            this.distance_textBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 621);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 660);
            this.MinimumSize = new System.Drawing.Size(450, 660);
            this.Name = "Form1";
            this.Text = "Graph Comparator: Анализ пар графов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.isomorph_tabPage.ResumeLayout(false);
            this.isomorph_tabPage.PerformLayout();
            this.metrics_tabPage.ResumeLayout(false);
            this.metrics_tabPage.PerformLayout();
            this.distance_tabPage.ResumeLayout(false);
            this.distance_tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage isomorph_tabPage;
        private System.Windows.Forms.TabPage metrics_tabPage;
        private System.Windows.Forms.TabPage distance_tabPage;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label enter_matrix_label2;
        private System.Windows.Forms.TextBox textBox_matrix2;
        private System.Windows.Forms.Label enter_ve_label2;
        private System.Windows.Forms.TextBox textBox_vertices2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label enter_matrix_label1;
        private System.Windows.Forms.TextBox textBox_matrix1;
        private System.Windows.Forms.Label enter_ve_label1;
        private System.Windows.Forms.TextBox textBox_vertices1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button analyze_button;
        private System.Windows.Forms.Label enter_ed_label2;
        private System.Windows.Forms.TextBox textBox_edges2;
        private System.Windows.Forms.Label enter_ed_label1;
        private System.Windows.Forms.TextBox textBox_edges1;
        public System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox isomorph_textBox;
        private System.Windows.Forms.TextBox metrics_textBox;
        private System.Windows.Forms.TextBox distance_textBox;
        private System.Windows.Forms.CheckBox advanced_view_checkBox;
    }
}

