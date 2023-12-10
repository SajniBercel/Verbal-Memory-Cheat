namespace VerbalMemory
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            LoadWebPage = new Button();
            Solve = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Exit = new Button();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            Stop = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // LoadWebPage
            // 
            LoadWebPage.Location = new Point(52, 12);
            LoadWebPage.Name = "LoadWebPage";
            LoadWebPage.Size = new Size(75, 23);
            LoadWebPage.TabIndex = 0;
            LoadWebPage.Text = "Load";
            LoadWebPage.UseVisualStyleBackColor = true;
            LoadWebPage.Click += LoadWebPage_Click;
            // 
            // Solve
            // 
            Solve.Location = new Point(52, 87);
            Solve.Name = "Solve";
            Solve.Size = new Size(75, 23);
            Solve.TabIndex = 1;
            Solve.Text = "Solve";
            Solve.UseVisualStyleBackColor = true;
            Solve.Click += Solve_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Exit
            // 
            Exit.Location = new Point(52, 145);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(93, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "SetTimer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(52, 116);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 5;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(180, 177);
            Controls.Add(Stop);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(Exit);
            Controls.Add(Solve);
            Controls.Add(LoadWebPage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoadWebPage;
        private Button Solve;
        private System.Windows.Forms.Timer timer1;
        private Button Exit;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button Stop;
    }
}