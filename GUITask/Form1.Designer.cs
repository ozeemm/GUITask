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
            button1 = new Button();
            timeResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // timeStartInput
            // 
            timeStartInput.Location = new Point(230, 25);
            timeStartInput.Name = "timeStartInput";
            timeStartInput.Size = new Size(69, 27);
            timeStartInput.TabIndex = 0;
            timeStartInput.TextChanged += OnTrainInputDataChanged;
            // 
            // timeEndInput
            // 
            timeEndInput.Location = new Point(230, 58);
            timeEndInput.Name = "timeEndInput";
            timeEndInput.Size = new Size(69, 27);
            timeEndInput.TabIndex = 1;
            timeEndInput.TextChanged += OnTrainInputDataChanged;
            // 
            // timeInput
            // 
            timeInput.Location = new Point(230, 91);
            timeInput.Name = "timeInput";
            timeInput.Size = new Size(69, 27);
            timeInput.TabIndex = 2;
            timeInput.TextChanged += OnTrainInputDataChanged;
            // 
            // button1
            // 
            button1.Location = new Point(174, 157);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 6;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timeResult
            // 
            timeResult.AutoSize = true;
            timeResult.Location = new Point(24, 121);
            timeResult.Name = "timeResult";
            timeResult.Size = new Size(0, 20);
            timeResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 26);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 3;
            label1.Text = "Время прибытия поезда:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 56);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 4;
            label2.Text = "Время отбытия поезда:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 92);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 5;
            label3.Text = "Время прибытия пассажира:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 193);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "DELETE ME";
            // 
            // Train
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 384);
            Controls.Add(timeResult);
            Controls.Add(button1);
            Controls.Add(timeInput);
            Controls.Add(timeEndInput);
            Controls.Add(timeStartInput);
            Controls.Add(groupBox1);
            Name = "Train";
            Text = "Train";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox timeStartInput;
        private TextBox timeEndInput;
        private TextBox timeInput;
        private Button button1;
        private Label timeResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
    }
}
