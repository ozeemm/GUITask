namespace GUITask
{
    partial class Train
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            timeStartInput = new TextBox();
            timeEndInput = new TextBox();
            timeInput = new TextBox();
            SolveButton1 = new Button();
            SolveButton2 = new Button();
            timeResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TaskButton1 = new Button();
            TaskButton2 = new Button();
            ClearButton1 = new Button();
            ClearButton2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            squaresAnswer = new Label();
            squaresListLabel = new Label();
            bInput = new TextBox();
            aInput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // timeStartInput
            // 
            timeStartInput.Location = new Point(242, 19);
            timeStartInput.Name = "timeStartInput";
            timeStartInput.Size = new Size(69, 27);
            timeStartInput.TabIndex = 0;
            timeStartInput.TextChanged += OnTrainInputDataChanged;
            // 
            // timeEndInput
            // 
            timeEndInput.Location = new Point(242, 52);
            timeEndInput.Name = "timeEndInput";
            timeEndInput.Size = new Size(69, 27);
            timeEndInput.TabIndex = 1;
            timeEndInput.TextChanged += OnTrainInputDataChanged;
            // 
            // timeInput
            // 
            timeInput.Location = new Point(242, 85);
            timeInput.Name = "timeInput";
            timeInput.Size = new Size(69, 27);
            timeInput.TabIndex = 2;
            timeInput.TextChanged += OnTrainInputDataChanged;
            // 
            // SolveButton1
            // 
            SolveButton1.Location = new Point(207, 127);
            SolveButton1.Name = "SolveButton1";
            SolveButton1.Size = new Size(104, 29);
            SolveButton1.TabIndex = 6;
            SolveButton1.Text = "Рассчитать";
            SolveButton1.UseVisualStyleBackColor = true;
            SolveButton1.Click += SolveButton1_Click;
            // 
            // SolveButton2
            // 
            SolveButton2.Location = new Point(207, 112);
            SolveButton2.Name = "SolveButton2";
            SolveButton2.Size = new Size(104, 29);
            SolveButton2.TabIndex = 6;
            SolveButton2.Text = "Рассчитать";
            SolveButton2.UseVisualStyleBackColor = true;
            SolveButton2.Click += SolveButton2_Click;
            // 
            // timeResult
            // 
            timeResult.AutoSize = true;
            timeResult.Location = new Point(36, 174);
            timeResult.Name = "timeResult";
            timeResult.Size = new Size(0, 20);
            timeResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 3;
            label1.Text = "Время прибытия поезда:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 4;
            label2.Text = "Время отбытия поезда:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 88);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 5;
            label3.Text = "Время прибытия пассажира:";
            // 
            // TaskButton1
            // 
            TaskButton1.Location = new Point(36, 127);
            TaskButton1.Name = "TaskButton1";
            TaskButton1.Size = new Size(76, 29);
            TaskButton1.TabIndex = 10;
            TaskButton1.Text = "Задача";
            TaskButton1.UseVisualStyleBackColor = true;
            TaskButton1.Click += TaskButton1_Click;
            // 
            // TaskButton2
            // 
            TaskButton2.Location = new Point(36, 112);
            TaskButton2.Name = "TaskButton2";
            TaskButton2.Size = new Size(76, 29);
            TaskButton2.TabIndex = 10;
            TaskButton2.Text = "Задача";
            TaskButton2.UseVisualStyleBackColor = true;
            TaskButton2.Click += TaskButton2_Click;
            // 
            // ClearButton1
            // 
            ClearButton1.Location = new Point(118, 127);
            ClearButton1.Name = "ClearButton1";
            ClearButton1.Size = new Size(83, 29);
            ClearButton1.TabIndex = 9;
            ClearButton1.Text = "Очистить";
            ClearButton1.UseVisualStyleBackColor = true;
            ClearButton1.Click += ClearButton1_Click;
            // 
            // ClearButton2
            // 
            ClearButton2.Location = new Point(118, 112);
            ClearButton2.Name = "ClearButton2";
            ClearButton2.Size = new Size(83, 29);
            ClearButton2.TabIndex = 9;
            ClearButton2.Text = "Очистить";
            ClearButton2.UseVisualStyleBackColor = true;
            ClearButton2.Click += ClearButton2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(545, 371);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(timeInput);
            tabPage1.Controls.Add(TaskButton1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(timeResult);
            tabPage1.Controls.Add(timeStartInput);
            tabPage1.Controls.Add(SolveButton1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(timeEndInput);
            tabPage1.Controls.Add(ClearButton1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(537, 338);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Прибытие поезда";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(squaresAnswer);
            tabPage2.Controls.Add(squaresListLabel);
            tabPage2.Controls.Add(bInput);
            tabPage2.Controls.Add(aInput);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(SolveButton2);
            tabPage2.Controls.Add(TaskButton2);
            tabPage2.Controls.Add(ClearButton2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(537, 338);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Прямоугольник и квадраты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // squaresAnswer
            // 
            squaresAnswer.AutoSize = true;
            squaresAnswer.Location = new Point(36, 159);
            squaresAnswer.Name = "squaresAnswer";
            squaresAnswer.Size = new Size(0, 20);
            squaresAnswer.TabIndex = 12;
            // 
            // squaresListLabel
            // 
            squaresListLabel.AutoSize = true;
            squaresListLabel.Location = new Point(327, 16);
            squaresListLabel.Name = "squaresListLabel";
            squaresListLabel.Size = new Size(0, 20);
            squaresListLabel.TabIndex = 11;
            // 
            // bInput
            // 
            bInput.Location = new Point(133, 64);
            bInput.Name = "bInput";
            bInput.Size = new Size(125, 27);
            bInput.TabIndex = 3;
            bInput.TextChanged += OnSquaresInputDataChanged;
            // 
            // aInput
            // 
            aInput.Location = new Point(133, 30);
            aInput.Name = "aInput";
            aInput.Size = new Size(125, 27);
            aInput.TabIndex = 2;
            aInput.TextChanged += OnSquaresInputDataChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 71);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 1;
            label5.Text = "b (ширина):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 33);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 0;
            label4.Text = "a (длина):";
            // 
            // Train
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 292);
            Controls.Add(tabControl1);
            Name = "Train";
            Text = "GUI";
            FormClosed += Train_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox timeStartInput;
        private TextBox timeEndInput;
        private TextBox timeInput;
        private Button SolveButton1;
        private Button SolveButton2;
        private Label timeResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button TaskButton1;
        private Button TaskButton2;
        private Button ClearButton1;
        private Button ClearButton2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TextBox bInput;
        private TextBox aInput;
        private Label label5;
        private Label label4;
        private Label squaresListLabel;
        private Label squaresAnswer;
    }
}
