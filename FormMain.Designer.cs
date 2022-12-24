using System.Windows.Forms;

namespace neural_networks_kubsu
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelPrediction1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.fitBtn = new System.Windows.Forms.Button();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.epochsUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.learningRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.inertiaUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDigit = new System.Windows.Forms.Label();
            this.labelPrediction2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recognizeBtn = new System.Windows.Forms.Button();
            this.labelLoss = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epochsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inertiaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Silver;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button0.Location = new System.Drawing.Point(22, 58);
            this.button0.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 73);
            this.button0.TabIndex = 0;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(94, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 73);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(165, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 73);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(165, 136);
            this.button5.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 73);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(94, 136);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 73);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(22, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 73);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(94, 291);
            this.button10.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 73);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(165, 213);
            this.button8.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 73);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(94, 213);
            this.button7.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 73);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(22, 213);
            this.button6.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 73);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelPrediction1
            // 
            this.labelPrediction1.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrediction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrediction1.Location = new System.Drawing.Point(440, 261);
            this.labelPrediction1.Name = "labelPrediction1";
            this.labelPrediction1.Size = new System.Drawing.Size(151, 103);
            this.labelPrediction1.TabIndex = 12;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Silver;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(165, 368);
            this.button14.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 73);
            this.button14.TabIndex = 14;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(22, 370);
            this.button12.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 73);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // fitBtn
            // 
            this.fitBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.fitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fitBtn.Location = new System.Drawing.Point(440, 159);
            this.fitBtn.Name = "fitBtn";
            this.fitBtn.Size = new System.Drawing.Size(304, 43);
            this.fitBtn.TabIndex = 16;
            this.fitBtn.Text = "ОБУЧИТЬ";
            this.fitBtn.UseVisualStyleBackColor = false;
            this.fitBtn.Click += new System.EventHandler(this.fitBtn_Click);
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.randomizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomizeBtn.Location = new System.Drawing.Point(638, 209);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(106, 43);
            this.randomizeBtn.TabIndex = 17;
            this.randomizeBtn.Text = "Случайная инициализация";
            this.randomizeBtn.UseVisualStyleBackColor = false;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportBtn.Location = new System.Drawing.Point(536, 209);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(96, 43);
            this.exportBtn.TabIndex = 21;
            this.exportBtn.Text = "СОХРАНИТЬ";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importBtn.Location = new System.Drawing.Point(440, 209);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(91, 43);
            this.importBtn.TabIndex = 22;
            this.importBtn.Text = "ЗАГРУЗИТЬ";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // epochsUpDown
            // 
            this.epochsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epochsUpDown.Location = new System.Drawing.Point(638, 57);
            this.epochsUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.epochsUpDown.Name = "epochsUpDown";
            this.epochsUpDown.Size = new System.Drawing.Size(106, 27);
            this.epochsUpDown.TabIndex = 24;
            this.epochsUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML file (*.xml)|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML file (*.xml)|*.xml";
            // 
            // learningRateUpDown
            // 
            this.learningRateUpDown.DecimalPlaces = 5;
            this.learningRateUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningRateUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.learningRateUpDown.Location = new System.Drawing.Point(638, 93);
            this.learningRateUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningRateUpDown.Name = "learningRateUpDown";
            this.learningRateUpDown.Size = new System.Drawing.Size(106, 27);
            this.learningRateUpDown.TabIndex = 25;
            this.learningRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // inertiaUpDown
            // 
            this.inertiaUpDown.DecimalPlaces = 2;
            this.inertiaUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inertiaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inertiaUpDown.Location = new System.Drawing.Point(638, 128);
            this.inertiaUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inertiaUpDown.Name = "inertiaUpDown";
            this.inertiaUpDown.Size = new System.Drawing.Size(106, 27);
            this.inertiaUpDown.TabIndex = 26;
            this.inertiaUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Кол-во эпох:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Скорость обучения:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Инерция:";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(165, 291);
            this.button11.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 73);
            this.button11.TabIndex = 11;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(94, 370);
            this.button13.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 73);
            this.button13.TabIndex = 13;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(22, 291);
            this.button9.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 73);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(544, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Обучение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(160, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Распознавание";
            // 
            // labelDigit
            // 
            this.labelDigit.Font = new System.Drawing.Font("Freestyle Script", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigit.Location = new System.Drawing.Point(251, 203);
            this.labelDigit.Name = "labelDigit";
            this.labelDigit.Size = new System.Drawing.Size(143, 240);
            this.labelDigit.TabIndex = 32;
            this.labelDigit.Text = "0";
            this.labelDigit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrediction2
            // 
            this.labelPrediction2.BackColor = System.Drawing.SystemColors.Control;
            this.labelPrediction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrediction2.Location = new System.Drawing.Point(590, 261);
            this.labelPrediction2.Name = "labelPrediction2";
            this.labelPrediction2.Size = new System.Drawing.Size(154, 103);
            this.labelPrediction2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 67);
            this.label6.TabIndex = 34;
            this.label6.Text = "Вы ввели цифру:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recognizeBtn
            // 
            this.recognizeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.recognizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recognizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recognizeBtn.Location = new System.Drawing.Point(251, 58);
            this.recognizeBtn.Name = "recognizeBtn";
            this.recognizeBtn.Size = new System.Drawing.Size(143, 73);
            this.recognizeBtn.TabIndex = 35;
            this.recognizeBtn.Text = "РАСПОЗНАТЬ";
            this.recognizeBtn.UseVisualStyleBackColor = false;
            this.recognizeBtn.Click += new System.EventHandler(this.recognizeBtn_Click);
            // 
            // labelLoss
            // 
            this.labelLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoss.Location = new System.Drawing.Point(573, 417);
            this.labelLoss.Name = "labelLoss";
            this.labelLoss.Size = new System.Drawing.Size(171, 26);
            this.labelLoss.TabIndex = 37;
            this.labelLoss.Text = "Ошибка:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(509, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Тестирование";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testBtn.Location = new System.Drawing.Point(439, 417);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(128, 26);
            this.testBtn.TabIndex = 39;
            this.testBtn.Text = "ТЕСТ";
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::neural_networks_kubsu.Properties.Resources.digits2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 480);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelLoss);
            this.Controls.Add(this.recognizeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelPrediction2);
            this.Controls.Add(this.labelDigit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inertiaUpDown);
            this.Controls.Add(this.learningRateUpDown);
            this.Controls.Add(this.epochsUpDown);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.fitBtn);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.labelPrediction1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormMain";
            this.Text = "Распознавание цифр";
            ((System.ComponentModel.ISupportInitialize)(this.epochsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inertiaUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown learningRateUpDown;
        private System.Windows.Forms.NumericUpDown inertiaUpDown;

        private System.Windows.Forms.Label labelPrediction1;
        
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.NumericUpDown epochsUpDown;

        private System.Windows.Forms.Button fitBtn;

        private System.Windows.Forms.Button importBtn;

        private System.Windows.Forms.Button randomizeBtn;

        private System.Windows.Forms.Button exportBtn;
        
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;

        #endregion

        private Label label4;
        private Label label5;
        private Label labelDigit;
        private Label labelPrediction2;
        private Label label6;
        private Button recognizeBtn;
        public Label labelLoss;
        private Label label7;
        private Button testBtn;
    }
}