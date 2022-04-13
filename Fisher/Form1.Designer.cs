namespace Fisher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_Capital = new System.Windows.Forms.Label();
            this.checkBox_Controller = new System.Windows.Forms.CheckBox();
            this.textBox_CrewSize = new System.Windows.Forms.TextBox();
            this.textBox_KSaving = new System.Windows.Forms.TextBox();
            this.label_Income = new System.Windows.Forms.Label();
            this.label_Consumption = new System.Windows.Forms.Label();
            this.label_Fish = new System.Windows.Forms.Label();
            this.label_KReproduction = new System.Windows.Forms.Label();
            this.label_MarketPrice = new System.Windows.Forms.Label();
            this.textBox_ShipLife = new System.Windows.Forms.TextBox();
            this.label_ShipProduction = new System.Windows.Forms.Label();
            this.textBox_ShipPrice = new System.Windows.Forms.TextBox();
            this.label_ShipPrice = new System.Windows.Forms.Label();
            this.textBox_ShipProduction = new System.Windows.Forms.TextBox();
            this.label_ShipLife = new System.Windows.Forms.Label();
            this.textBox_KReproduction = new System.Windows.Forms.TextBox();
            this.label_Salary = new System.Windows.Forms.Label();
            this.textBox_KInvestment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_CrewSize = new System.Windows.Forms.Label();
            this.textBox_MarketPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Salary = new System.Windows.Forms.TextBox();
            this.label_Delta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_ComputeStep = new System.Windows.Forms.Button();
            this.label_MyMoney = new System.Windows.Forms.Label();
            this.label_Fleet = new System.Windows.Forms.Label();
            this.label_Crew = new System.Windows.Forms.Label();
            this.chart_Fish = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Capital = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_Fleet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.chart_PersonalGain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_ChangePrice = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Capital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fleet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PersonalGain)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Capital
            // 
            this.label_Capital.AutoSize = true;
            this.label_Capital.BackColor = System.Drawing.Color.Transparent;
            this.label_Capital.Location = new System.Drawing.Point(206, 9);
            this.label_Capital.Name = "label_Capital";
            this.label_Capital.Size = new System.Drawing.Size(149, 24);
            this.label_Capital.TabIndex = 0;
            this.label_Capital.Text = "Капитал:  10000";
            // 
            // checkBox_Controller
            // 
            this.checkBox_Controller.AutoSize = true;
            this.checkBox_Controller.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Controller.Location = new System.Drawing.Point(3, 25);
            this.checkBox_Controller.Name = "checkBox_Controller";
            this.checkBox_Controller.Size = new System.Drawing.Size(137, 28);
            this.checkBox_Controller.TabIndex = 0;
            this.checkBox_Controller.Text = "Регулятор";
            this.checkBox_Controller.UseVisualStyleBackColor = true;
            // 
            // textBox_CrewSize
            // 
            this.textBox_CrewSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_CrewSize.Location = new System.Drawing.Point(3, 367);
            this.textBox_CrewSize.Name = "textBox_CrewSize";
            this.textBox_CrewSize.Size = new System.Drawing.Size(208, 29);
            this.textBox_CrewSize.TabIndex = 4;
            this.textBox_CrewSize.Text = "30";
            // 
            // textBox_KSaving
            // 
            this.textBox_KSaving.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_KSaving.Location = new System.Drawing.Point(3, 130);
            this.textBox_KSaving.Name = "textBox_KSaving";
            this.textBox_KSaving.Size = new System.Drawing.Size(137, 29);
            this.textBox_KSaving.TabIndex = 2;
            this.textBox_KSaving.Text = "0,2";
            // 
            // label_Income
            // 
            this.label_Income.AutoSize = true;
            this.label_Income.BackColor = System.Drawing.Color.Transparent;
            this.label_Income.Location = new System.Drawing.Point(206, 140);
            this.label_Income.Name = "label_Income";
            this.label_Income.Size = new System.Drawing.Size(108, 24);
            this.label_Income.TabIndex = 3;
            this.label_Income.Text = "Доход: 200";
            // 
            // label_Consumption
            // 
            this.label_Consumption.AutoSize = true;
            this.label_Consumption.BackColor = System.Drawing.Color.Transparent;
            this.label_Consumption.Location = new System.Drawing.Point(206, 165);
            this.label_Consumption.Name = "label_Consumption";
            this.label_Consumption.Size = new System.Drawing.Size(115, 24);
            this.label_Consumption.TabIndex = 4;
            this.label_Consumption.Text = "Расход: 150";
            // 
            // label_Fish
            // 
            this.label_Fish.AutoSize = true;
            this.label_Fish.BackColor = System.Drawing.Color.Transparent;
            this.label_Fish.Location = new System.Drawing.Point(12, 9);
            this.label_Fish.Name = "label_Fish";
            this.label_Fish.Size = new System.Drawing.Size(96, 24);
            this.label_Fish.TabIndex = 5;
            this.label_Fish.Text = "Рыба: 500";
            // 
            // label_KReproduction
            // 
            this.label_KReproduction.AutoSize = true;
            this.label_KReproduction.BackColor = System.Drawing.Color.Transparent;
            this.label_KReproduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_KReproduction.Location = new System.Drawing.Point(3, 25);
            this.label_KReproduction.Name = "label_KReproduction";
            this.label_KReproduction.Size = new System.Drawing.Size(142, 24);
            this.label_KReproduction.TabIndex = 3;
            this.label_KReproduction.Text = "k репродукции";
            // 
            // label_MarketPrice
            // 
            this.label_MarketPrice.AutoSize = true;
            this.label_MarketPrice.BackColor = System.Drawing.Color.Transparent;
            this.label_MarketPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_MarketPrice.Location = new System.Drawing.Point(3, 78);
            this.label_MarketPrice.Name = "label_MarketPrice";
            this.label_MarketPrice.Size = new System.Drawing.Size(146, 24);
            this.label_MarketPrice.TabIndex = 7;
            this.label_MarketPrice.Text = "Рыночная цена";
            // 
            // textBox_ShipLife
            // 
            this.textBox_ShipLife.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_ShipLife.Location = new System.Drawing.Point(3, 261);
            this.textBox_ShipLife.Name = "textBox_ShipLife";
            this.textBox_ShipLife.Size = new System.Drawing.Size(208, 29);
            this.textBox_ShipLife.TabIndex = 6;
            this.textBox_ShipLife.Text = "30";
            // 
            // label_ShipProduction
            // 
            this.label_ShipProduction.AutoSize = true;
            this.label_ShipProduction.BackColor = System.Drawing.Color.Transparent;
            this.label_ShipProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ShipProduction.Location = new System.Drawing.Point(3, 131);
            this.label_ShipProduction.Name = "label_ShipProduction";
            this.label_ShipProduction.Size = new System.Drawing.Size(213, 24);
            this.label_ShipProduction.TabIndex = 7;
            this.label_ShipProduction.Text = "Добыча одним судном";
            // 
            // textBox_ShipPrice
            // 
            this.textBox_ShipPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_ShipPrice.Location = new System.Drawing.Point(3, 208);
            this.textBox_ShipPrice.Name = "textBox_ShipPrice";
            this.textBox_ShipPrice.Size = new System.Drawing.Size(208, 29);
            this.textBox_ShipPrice.TabIndex = 6;
            this.textBox_ShipPrice.Text = "1000";
            // 
            // label_ShipPrice
            // 
            this.label_ShipPrice.AutoSize = true;
            this.label_ShipPrice.BackColor = System.Drawing.Color.Transparent;
            this.label_ShipPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ShipPrice.Location = new System.Drawing.Point(3, 184);
            this.label_ShipPrice.Name = "label_ShipPrice";
            this.label_ShipPrice.Size = new System.Drawing.Size(167, 24);
            this.label_ShipPrice.TabIndex = 7;
            this.label_ShipPrice.Text = "Стоимость судна";
            // 
            // textBox_ShipProduction
            // 
            this.textBox_ShipProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_ShipProduction.Location = new System.Drawing.Point(3, 155);
            this.textBox_ShipProduction.Name = "textBox_ShipProduction";
            this.textBox_ShipProduction.Size = new System.Drawing.Size(208, 29);
            this.textBox_ShipProduction.TabIndex = 6;
            this.textBox_ShipProduction.Text = "10";
            // 
            // label_ShipLife
            // 
            this.label_ShipLife.AutoSize = true;
            this.label_ShipLife.BackColor = System.Drawing.Color.Transparent;
            this.label_ShipLife.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ShipLife.Location = new System.Drawing.Point(3, 237);
            this.label_ShipLife.Name = "label_ShipLife";
            this.label_ShipLife.Size = new System.Drawing.Size(183, 24);
            this.label_ShipLife.TabIndex = 7;
            this.label_ShipLife.Text = "Срок службы судна";
            // 
            // textBox_KReproduction
            // 
            this.textBox_KReproduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_KReproduction.Location = new System.Drawing.Point(3, 49);
            this.textBox_KReproduction.Name = "textBox_KReproduction";
            this.textBox_KReproduction.Size = new System.Drawing.Size(208, 29);
            this.textBox_KReproduction.TabIndex = 6;
            this.textBox_KReproduction.Text = "1,1";
            // 
            // label_Salary
            // 
            this.label_Salary.AutoSize = true;
            this.label_Salary.BackColor = System.Drawing.Color.Transparent;
            this.label_Salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Salary.Location = new System.Drawing.Point(3, 290);
            this.label_Salary.Name = "label_Salary";
            this.label_Salary.Size = new System.Drawing.Size(95, 24);
            this.label_Salary.TabIndex = 7;
            this.label_Salary.Text = "Зарплата";
            // 
            // textBox_KInvestment
            // 
            this.textBox_KInvestment.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_KInvestment.Location = new System.Drawing.Point(3, 77);
            this.textBox_KInvestment.Name = "textBox_KInvestment";
            this.textBox_KInvestment.Size = new System.Drawing.Size(137, 29);
            this.textBox_KInvestment.TabIndex = 1;
            this.textBox_KInvestment.Text = "0,2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "k инвестиций";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "k сохранения";
            // 
            // label_CrewSize
            // 
            this.label_CrewSize.AutoSize = true;
            this.label_CrewSize.BackColor = System.Drawing.Color.Transparent;
            this.label_CrewSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CrewSize.Location = new System.Drawing.Point(3, 343);
            this.label_CrewSize.Name = "label_CrewSize";
            this.label_CrewSize.Size = new System.Drawing.Size(157, 24);
            this.label_CrewSize.TabIndex = 9;
            this.label_CrewSize.Text = "Размер экипажа";
            // 
            // textBox_MarketPrice
            // 
            this.textBox_MarketPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_MarketPrice.Location = new System.Drawing.Point(3, 102);
            this.textBox_MarketPrice.Name = "textBox_MarketPrice";
            this.textBox_MarketPrice.Size = new System.Drawing.Size(208, 29);
            this.textBox_MarketPrice.TabIndex = 8;
            this.textBox_MarketPrice.Text = "25";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox_CrewSize);
            this.groupBox1.Controls.Add(this.label_CrewSize);
            this.groupBox1.Controls.Add(this.textBox_Salary);
            this.groupBox1.Controls.Add(this.label_Salary);
            this.groupBox1.Controls.Add(this.textBox_ShipLife);
            this.groupBox1.Controls.Add(this.label_ShipLife);
            this.groupBox1.Controls.Add(this.textBox_ShipPrice);
            this.groupBox1.Controls.Add(this.label_ShipPrice);
            this.groupBox1.Controls.Add(this.textBox_ShipProduction);
            this.groupBox1.Controls.Add(this.label_ShipProduction);
            this.groupBox1.Controls.Add(this.textBox_MarketPrice);
            this.groupBox1.Controls.Add(this.label_MarketPrice);
            this.groupBox1.Controls.Add(this.textBox_KReproduction);
            this.groupBox1.Controls.Add(this.label_KReproduction);
            this.groupBox1.Location = new System.Drawing.Point(468, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 407);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // textBox_Salary
            // 
            this.textBox_Salary.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Salary.Location = new System.Drawing.Point(3, 314);
            this.textBox_Salary.Name = "textBox_Salary";
            this.textBox_Salary.Size = new System.Drawing.Size(208, 29);
            this.textBox_Salary.TabIndex = 8;
            this.textBox_Salary.Text = "1";
            // 
            // label_Delta
            // 
            this.label_Delta.AutoSize = true;
            this.label_Delta.BackColor = System.Drawing.Color.Transparent;
            this.label_Delta.Location = new System.Drawing.Point(206, 189);
            this.label_Delta.Name = "label_Delta";
            this.label_Delta.Size = new System.Drawing.Size(115, 24);
            this.label_Delta.TabIndex = 4;
            this.label_Delta.Text = "Разница: 50";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button_ComputeStep);
            this.groupBox2.Controls.Add(this.textBox_KSaving);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_KInvestment);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.checkBox_Controller);
            this.groupBox2.Location = new System.Drawing.Point(16, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 225);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button_ComputeStep
            // 
            this.button_ComputeStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ComputeStep.Location = new System.Drawing.Point(3, 159);
            this.button_ComputeStep.Name = "button_ComputeStep";
            this.button_ComputeStep.Size = new System.Drawing.Size(137, 59);
            this.button_ComputeStep.TabIndex = 12;
            this.button_ComputeStep.Text = "Расчет";
            this.button_ComputeStep.UseVisualStyleBackColor = true;
            this.button_ComputeStep.Click += new System.EventHandler(this.Count_Click);
            // 
            // label_MyMoney
            // 
            this.label_MyMoney.AutoSize = true;
            this.label_MyMoney.BackColor = System.Drawing.Color.Transparent;
            this.label_MyMoney.Location = new System.Drawing.Point(206, 33);
            this.label_MyMoney.Name = "label_MyMoney";
            this.label_MyMoney.Size = new System.Drawing.Size(138, 24);
            this.label_MyMoney.TabIndex = 0;
            this.label_MyMoney.Text = "Заработано: 0";
            // 
            // label_Fleet
            // 
            this.label_Fleet.AutoSize = true;
            this.label_Fleet.BackColor = System.Drawing.Color.Transparent;
            this.label_Fleet.Location = new System.Drawing.Point(206, 339);
            this.label_Fleet.Name = "label_Fleet";
            this.label_Fleet.Size = new System.Drawing.Size(77, 24);
            this.label_Fleet.TabIndex = 4;
            this.label_Fleet.Text = "Флот: 1";
            // 
            // label_Crew
            // 
            this.label_Crew.AutoSize = true;
            this.label_Crew.BackColor = System.Drawing.Color.Transparent;
            this.label_Crew.Location = new System.Drawing.Point(206, 364);
            this.label_Crew.Name = "label_Crew";
            this.label_Crew.Size = new System.Drawing.Size(108, 24);
            this.label_Crew.TabIndex = 4;
            this.label_Crew.Text = "Экипаж: 30";
            // 
            // chart_Fish
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_Fish.ChartAreas.Add(chartArea5);
            this.chart_Fish.Location = new System.Drawing.Point(713, 34);
            this.chart_Fish.Name = "chart_Fish";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Fish";
            this.chart_Fish.Series.Add(series5);
            this.chart_Fish.Size = new System.Drawing.Size(440, 117);
            this.chart_Fish.TabIndex = 12;
            // 
            // chart_Capital
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_Capital.ChartAreas.Add(chartArea6);
            this.chart_Capital.Location = new System.Drawing.Point(713, 183);
            this.chart_Capital.Name = "chart_Capital";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Капитал";
            series6.YValuesPerPoint = 2;
            this.chart_Capital.Series.Add(series6);
            this.chart_Capital.Size = new System.Drawing.Size(440, 117);
            this.chart_Capital.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(709, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Рыба";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(709, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Капитал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(709, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Флот";
            // 
            // chart_Fleet
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_Fleet.ChartAreas.Add(chartArea7);
            this.chart_Fleet.Location = new System.Drawing.Point(713, 339);
            this.chart_Fleet.Name = "chart_Fleet";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Капитал";
            series7.YValuesPerPoint = 2;
            this.chart_Fleet.Series.Add(series7);
            this.chart_Fleet.Size = new System.Drawing.Size(440, 117);
            this.chart_Fleet.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(709, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Личный заработок";
            // 
            // chart_PersonalGain
            // 
            chartArea8.Name = "ChartArea1";
            this.chart_PersonalGain.ChartAreas.Add(chartArea8);
            this.chart_PersonalGain.Location = new System.Drawing.Point(713, 490);
            this.chart_PersonalGain.Name = "chart_PersonalGain";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Капитал";
            series8.YValuesPerPoint = 2;
            this.chart_PersonalGain.Series.Add(series8);
            this.chart_PersonalGain.Size = new System.Drawing.Size(440, 117);
            this.chart_PersonalGain.TabIndex = 12;
            // 
            // checkBox_ChangePrice
            // 
            this.checkBox_ChangePrice.AutoSize = true;
            this.checkBox_ChangePrice.Location = new System.Drawing.Point(19, 459);
            this.checkBox_ChangePrice.Name = "checkBox_ChangePrice";
            this.checkBox_ChangePrice.Size = new System.Drawing.Size(281, 28);
            this.checkBox_ChangePrice.TabIndex = 13;
            this.checkBox_ChangePrice.Text = "Случайное изменение цены";
            this.checkBox_ChangePrice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1163, 621);
            this.Controls.Add(this.checkBox_ChangePrice);
            this.Controls.Add(this.chart_PersonalGain);
            this.Controls.Add(this.chart_Fleet);
            this.Controls.Add(this.chart_Capital);
            this.Controls.Add(this.chart_Fish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Fish);
            this.Controls.Add(this.label_Crew);
            this.Controls.Add(this.label_Fleet);
            this.Controls.Add(this.label_Delta);
            this.Controls.Add(this.label_Consumption);
            this.Controls.Add(this.label_Income);
            this.Controls.Add(this.label_MyMoney);
            this.Controls.Add(this.label_Capital);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Fishing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Capital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fleet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PersonalGain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Capital;
        private System.Windows.Forms.CheckBox checkBox_Controller;
        private System.Windows.Forms.TextBox textBox_CrewSize;
        private System.Windows.Forms.TextBox textBox_KSaving;
        private System.Windows.Forms.Label label_Income;
        private System.Windows.Forms.Label label_Consumption;
        private System.Windows.Forms.Label label_Fish;
        private System.Windows.Forms.Label label_KReproduction;
        private System.Windows.Forms.Label label_MarketPrice;
        private System.Windows.Forms.TextBox textBox_ShipLife;
        private System.Windows.Forms.Label label_ShipProduction;
        private System.Windows.Forms.TextBox textBox_ShipPrice;
        private System.Windows.Forms.Label label_ShipPrice;
        private System.Windows.Forms.TextBox textBox_ShipProduction;
        private System.Windows.Forms.Label label_ShipLife;
        private System.Windows.Forms.TextBox textBox_KReproduction;
        private System.Windows.Forms.Label label_Salary;
        private System.Windows.Forms.TextBox textBox_KInvestment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_CrewSize;
        private System.Windows.Forms.TextBox textBox_MarketPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Salary;
        private System.Windows.Forms.Label label_Delta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ComputeStep;
        private System.Windows.Forms.Label label_MyMoney;
        private System.Windows.Forms.Label label_Fleet;
        private System.Windows.Forms.Label label_Crew;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fish;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Capital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fleet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PersonalGain;
        private System.Windows.Forms.CheckBox checkBox_ChangePrice;
    }
}

