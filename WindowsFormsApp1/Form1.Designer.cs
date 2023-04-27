
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yD = new System.Windows.Forms.NumericUpDown();
            this.xD = new System.Windows.Forms.NumericUpDown();
            this.yC = new System.Windows.Forms.NumericUpDown();
            this.xC = new System.Windows.Forms.NumericUpDown();
            this.yB = new System.Windows.Forms.NumericUpDown();
            this.xB = new System.Windows.Forms.NumericUpDown();
            this.yA = new System.Windows.Forms.NumericUpDown();
            this.xA = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackThread = new System.Windows.Forms.TrackBar();
            this.numericThread = new System.Windows.Forms.NumericUpDown();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioASM = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioTest = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThread)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 420);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 20);
            this.label17.TabIndex = 69;
            this.label17.Text = "Number of threads:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(625, 538);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 20);
            this.label16.TabIndex = 68;
            this.label16.Text = "y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(625, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 20);
            this.label15.TabIndex = 67;
            this.label15.Text = "x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(458, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 538);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 64;
            this.label12.Text = "y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 538);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "x";
            // 
            // yD
            // 
            this.yD.Location = new System.Drawing.Point(537, 532);
            this.yD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yD.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yD.Name = "yD";
            this.yD.Size = new System.Drawing.Size(81, 26);
            this.yD.TabIndex = 60;
            // 
            // xD
            // 
            this.xD.Location = new System.Drawing.Point(537, 507);
            this.xD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xD.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xD.Name = "xD";
            this.xD.Size = new System.Drawing.Size(81, 26);
            this.xD.TabIndex = 59;
            // 
            // yC
            // 
            this.yC.Location = new System.Drawing.Point(359, 536);
            this.yC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.yC.Name = "yC";
            this.yC.Size = new System.Drawing.Size(85, 26);
            this.yC.TabIndex = 58;
            // 
            // xC
            // 
            this.xC.Location = new System.Drawing.Point(359, 507);
            this.xC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xC.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xC.Name = "xC";
            this.xC.Size = new System.Drawing.Size(85, 26);
            this.xC.TabIndex = 57;
            // 
            // yB
            // 
            this.yB.Location = new System.Drawing.Point(213, 532);
            this.yB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yB.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yB.Name = "yB";
            this.yB.Size = new System.Drawing.Size(78, 26);
            this.yB.TabIndex = 56;
            // 
            // xB
            // 
            this.xB.Location = new System.Drawing.Point(213, 505);
            this.xB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xB.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xB.Name = "xB";
            this.xB.Size = new System.Drawing.Size(78, 26);
            this.xB.TabIndex = 55;
            // 
            // yA
            // 
            this.yA.Location = new System.Drawing.Point(61, 532);
            this.yA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yA.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.yA.Name = "yA";
            this.yA.Size = new System.Drawing.Size(81, 26);
            this.yA.TabIndex = 54;
            // 
            // xA
            // 
            this.xA.Location = new System.Drawing.Point(61, 507);
            this.xA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xA.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.xA.Name = "xA";
            this.xA.Size = new System.Drawing.Size(81, 26);
            this.xA.TabIndex = 53;
            this.xA.ValueChanged += new System.EventHandler(this.xA_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(499, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(327, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(176, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(888, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "A";
            // 
            // trackThread
            // 
            this.trackThread.Location = new System.Drawing.Point(181, 432);
            this.trackThread.Maximum = 64;
            this.trackThread.Minimum = 1;
            this.trackThread.Name = "trackThread";
            this.trackThread.Size = new System.Drawing.Size(528, 69);
            this.trackThread.TabIndex = 44;
            this.trackThread.Value = 1;
            this.trackThread.Scroll += new System.EventHandler(this.trackThread_Scroll);
            // 
            // numericThread
            // 
            this.numericThread.Location = new System.Drawing.Point(44, 443);
            this.numericThread.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThread.Name = "numericThread";
            this.numericThread.Size = new System.Drawing.Size(120, 26);
            this.numericThread.TabIndex = 43;
            this.numericThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericThread.ValueChanged += new System.EventHandler(this.numericThread_ValueChanged);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(732, 494);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(176, 53);
            this.buttonTransform.TabIndex = 42;
            this.buttonTransform.Text = "Transform";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 25);
            this.toolStripStatusLabel1.Text = "time";
            // 
            // radioASM
            // 
            this.radioASM.AutoSize = true;
            this.radioASM.Location = new System.Drawing.Point(791, 455);
            this.radioASM.Name = "radioASM";
            this.radioASM.Size = new System.Drawing.Size(69, 24);
            this.radioASM.TabIndex = 41;
            this.radioASM.TabStop = true;
            this.radioASM.Text = "ASM";
            this.radioASM.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Checked = true;
            this.radioC.Location = new System.Drawing.Point(722, 455);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(54, 24);
            this.radioC.TabIndex = 40;
            this.radioC.TabStop = true;
            this.radioC.Text = "C#";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(612, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(187, 55);
            this.buttonSave.TabIndex = 39;
            this.buttonSave.Text = "Save File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(130, 352);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(187, 56);
            this.buttonOpen.TabIndex = 38;
            this.buttonOpen.Text = "Open File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.timerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 32);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(56, 25);
            this.timerLabel.Text = "00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(479, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 322);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // radioTest
            // 
            this.radioTest.AutoSize = true;
            this.radioTest.Location = new System.Drawing.Point(866, 455);
            this.radioTest.Name = "radioTest";
            this.radioTest.Size = new System.Drawing.Size(61, 24);
            this.radioTest.TabIndex = 70;
            this.radioTest.TabStop = true;
            this.radioTest.Text = "test";
            this.radioTest.UseVisualStyleBackColor = true;
            this.radioTest.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(732, 554);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(176, 56);
            this.clearButton.TabIndex = 71;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 645);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.radioTest);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yD);
            this.Controls.Add(this.xD);
            this.Controls.Add(this.yC);
            this.Controls.Add(this.xC);
            this.Controls.Add(this.yB);
            this.Controls.Add(this.xB);
            this.Controls.Add(this.yA);
            this.Controls.Add(this.xA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackThread);
            this.Controls.Add(this.numericThread);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.radioASM);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThread)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown yD;
        private System.Windows.Forms.NumericUpDown xD;
        private System.Windows.Forms.NumericUpDown yC;
        private System.Windows.Forms.NumericUpDown xC;
        private System.Windows.Forms.NumericUpDown yB;
        private System.Windows.Forms.NumericUpDown xB;
        private System.Windows.Forms.NumericUpDown yA;
        private System.Windows.Forms.NumericUpDown xA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackThread;
        private System.Windows.Forms.NumericUpDown numericThread;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton radioASM;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioTest;
        private System.Windows.Forms.ToolStripStatusLabel timerLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

