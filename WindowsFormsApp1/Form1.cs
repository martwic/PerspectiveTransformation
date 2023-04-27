using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TransformC;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //[DllImport(@"C:\Users\Dell\source\repos\WindowsFormsApp1\x64\JAAsm.dll")]
        //[DllImport(@"C:\Users\Dell\source\repos\WindowsFormsApp1\x64\Debug\JAAsm.dll")]
        [DllImport(@"C:\Users\Dell\source\repos\WindowsFormsApp1\x64\Release\JAAsm.dll")]
        static extern void MyProc1(byte[] pictureNew, int[] toChange, int size, int x);


        public Form1()
        {
            InitializeComponent();
            numericThread.Value = Environment.ProcessorCount;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            reset();
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images|*.png;*.bmp;*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);

                    this.Controls.Add(pictureBox1);

                    xA.Value = 0;
                    yA.Value = 0;
                    xB.Value = pictureBox1.Image.Width;
                    yB.Value = 0;
                    xC.Value = pictureBox1.Image.Width;
                    yC.Value = pictureBox1.Image.Height;
                    xD.Value = 0;
                    yD.Value = pictureBox1.Image.Height;

                    int sizeX = pictureBox1.Image.Width / 3;

                    xA.Minimum = -sizeX;
                    xA.Maximum = 0;
                    yA.Minimum = 0;
                    yA.Maximum = 0;

                    xB.Maximum = pictureBox1.Image.Width + sizeX;
                    xB.Minimum = pictureBox1.Image.Width;
                    yB.Maximum = 0;
                    yB.Minimum = 0;

                    xC.Maximum = pictureBox1.Image.Width + sizeX;
                    xC.Minimum = pictureBox1.Image.Width;
                    yC.Maximum = pictureBox1.Image.Height;
                    yC.Minimum = pictureBox1.Image.Height;

                    xD.Minimum = -sizeX;
                    xD.Maximum = 0;
                    yD.Maximum = pictureBox1.Image.Height;
                    yD.Minimum = pictureBox1.Image.Height;
                }
                dlg.Dispose();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox2.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Nothing to save", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericThread_ValueChanged(object sender, EventArgs e)
        {
            trackThread.Value = Convert.ToInt32(numericThread.Value);
            if (numericThread.Value > Environment.ProcessorCount)
            {
                System.Threading.ThreadPool.SetMaxThreads((int)numericThread.Value, (int)numericThread.Value);
            }
            else
            {
                System.Threading.ThreadPool.SetMaxThreads(Environment.ProcessorCount, (int)numericThread.Value);
            }

        }

        private void trackThread_Scroll(object sender, EventArgs e)
        {
            numericThread.Value = trackThread.Value;
        }

        private void buttonTransform_Click(object sender, EventArgs e)
        {

            Stopwatch stopWatch = new Stopwatch();

            if (pictureBox1.Image != null)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                int xOld = bmp.Width, yOld = bmp.Height;
                Color[,] pictureOld = new Color[xOld + 1, yOld];

                for (int j = 0; j < bmp.Height; j++)
                {
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        pictureOld[i, j] = bmp.GetPixel(i, j);
                    }
                }
                int Ax = (int)xA.Value, Ay = (int)yA.Value, By = (int)yB.Value, Dx = (int)xD.Value;
                int Bx = (int)xB.Value, Cx = (int)xC.Value, Cy = (int)yC.Value, Dy = (int)yD.Value;

                int x = (int)(Math.Max(Bx, Cx) - Math.Min(Ax, Dx));
                int y = yOld;



                Color[,] pictureNew = new Color[x + 1, y + 1];
                int xDissimilarity = -Math.Min(Ax, Dx);

                Ax += xDissimilarity; Bx += xDissimilarity; Cx += xDissimilarity; Dx += xDissimilarity;

                double BCfactor = factor(Bx, By, Cx, Cy);
                double BCyintercept = yintercept(Bx, By, Cx, Cy, BCfactor);

                double DAfactor = factor(Dx, Dy, Ax, Ay);
                double DAyintercept = yintercept(Dx, Dy, Ax, Ay, DAfactor);


                int A = Ax, B = Bx;
                List<int> toChange = new List<int>();

                for (int j = 0; j < yOld; j++)
                {
                    A = 0;
                    B = x;
                    if (Dx != Ax)
                    {
                        A = (int)Math.Floor((j - DAyintercept) / DAfactor);
                    }
                    if (Bx != Cx)
                    {
                        B = (int)Math.Ceiling((j - BCyintercept) / BCfactor);
                    }


                    int i1 = 0, i2 = 0;
                    int AB = B - A;
                    int ABratio = -1;
                    if (AB != xOld)
                    {
                        ABratio = (int)Math.Ceiling(((double)(AB) / (double)(AB - xOld))) - 1;
                        i1 = ABratio - 1;
                    }
                    for (int i = 0, ii = 1; i < x - 1; i++, ii++)
                    {
                        if (i >= A && i < B)
                        {
                            if (i1 == ABratio - 1 && i2 < AB - xOld)
                            {
                                i1 = 0;
                                i2++;
                                ii--;
                                if (i > 2 && i < (x - 1) * 3 && j > 0 && j < y - 1)
                                {
                                    //pictureNew[i, j] = pictureNew[i-1, j];
                                    toChange.Add(i);
                                    toChange.Add(j);
                                }

                            }
                            else
                            {
                                pictureNew[i, j] = pictureOld[ii, j];
                                i1++;
                            }
                        }
                        else
                        {
                            ii--;
                        }
                    }
                }
                Bitmap bmpNew = new Bitmap(x, y);
                Graphics imageNew = Graphics.FromImage(bmpNew);
                byte[] pictureNew1 = new byte[x * 3 * y];
                for (int i = 1, k = 0; i < x - 1; i++, k += 3)
                {
                    for (int j = 1; j < y - 1; j++)
                    {
                        pictureNew1[k + j * x * 3] = pictureNew[i, j].R;
                        pictureNew1[k + 1 + j * x * 3] = pictureNew[i, j].G;
                        pictureNew1[k + 2 + j * x * 3] = pictureNew[i, j].B;
                    }
                }

                int[] toChangeArray = toChange.ToArray();
                List<Task> tasks = new List<Task>();
                if (radioC.Checked)
                {
                    for (int i = 0; i < numericThread.Value; i++)
                    {
                        tasks.Add(new Task(()=>transformationC.pictureFinal(pictureNew1, toChangeArray, toChange.Count, x)));
                    }
                    stopWatch.Start();
                    Parallel.ForEach(tasks, i=>i.Start());
                    Task.WaitAll(tasks.ToArray());
                    stopWatch.Stop();
                    long s = stopWatch.ElapsedTicks / 10;
                    timerLabel.Text = s.ToString() + " microseconds";
                    stopWatch.Reset();
                    tasks.Clear();
                }
                else if (radioASM.Checked)
                {
                    for (int i = 0; i < numericThread.Value; i++)
                    {
                        tasks.Add(new Task(() => MyProc1(pictureNew1, toChangeArray, toChange.Count, x)));
                    }
                    stopWatch.Start();
                    Parallel.ForEach(tasks, i => i.Start());
                    Task.WaitAll(tasks.ToArray());
                    stopWatch.Stop();
                    long s = stopWatch.ElapsedTicks / 10;
                    timerLabel.Text = s.ToString() + " microseconds";
                    stopWatch.Reset();
                    tasks.Clear();
                }
                else
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\Dell\\OneDrive\\Pulpit\\Test1.txt", true, Encoding.ASCII);
                    int k = 1;
                    //sw.WriteLine("C#;");
                    while (k <= 64) {
                        //sw.WriteLine("Ilosc watkow:"+k+";");
                        for (int j = 0; j < 21; j++)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                tasks.Add(new Task(() => transformationC.pictureFinal(pictureNew1, toChangeArray, toChange.Count, x)));
                            }
                            Parallel.ForEach(tasks, i => i.Start());
                            stopWatch.Start();
                            Task.WaitAll(tasks.ToArray());
                            stopWatch.Stop();
                            long s = stopWatch.ElapsedTicks / 10;
                            timerLabel.Text = s.ToString() + " microseconds";
                            stopWatch.Reset();
                            sw.Write(s.ToString() + ";");
                            tasks.Clear();
                        }
                        k *= 2;
                        sw.WriteLine("");
                    }
                    k = 1;
                    //sw.WriteLine("ASM;");
                    while (k <= 64)
                    {
                        //sw.WriteLine("Ilosc watkow:" + k + ";");
                        for (int j = 0; j < 21; j++)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                tasks.Add(new Task(() => MyProc1(pictureNew1, toChangeArray, toChange.Count, x)));
                            }
                            Parallel.ForEach(tasks, i => i.Start());
                            stopWatch.Start();
                            Task.WaitAll(tasks.ToArray());
                            stopWatch.Stop();
                            long s = stopWatch.ElapsedTicks / 10;
                            timerLabel.Text = s.ToString() + " microseconds";
                            stopWatch.Reset();
                            sw.Write(s.ToString() + ";");
                            tasks.Clear();
                        }
                        k *= 2;
                        sw.WriteLine("");
                    }
                    sw.Close();
                }
                Color color;
                for (int i = 1, k = 0; i < x - 1; i++, k += 3)
                {
                    for (int j = 1; j < y - 1; j++)
                    {
                        color = Color.FromArgb(255, pictureNew1[k + j * x * 3], pictureNew1[k + 1 + j * x * 3], pictureNew1[k + 2 + j * x * 3]);
                        var brush = new SolidBrush(color);
                        imageNew.FillRectangle(brush, i, j, 1, 1);
                    }
                }
                pictureBox2.Image = bmpNew;
            }
            else
            {
                MessageBox.Show("Nothing to transform", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void xA_ValueChanged(object sender, EventArgs e) { }

        public int sectionLength(int Ax, int Ay, int Bx, int By)
        {
            return (int)Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By));
        }

        public double factor(int Ax, int Ay, int Bx, int By)
        {
            if (Ax == Bx)
            {
                return 0;
            }
            else
            {
                return (double)(Ay - By) / (Ax - Bx);
            }

        }

        public double yintercept(int Ax, int Ay, int Bx, int By, double factor)
        {
            return (Ay - factor * Ax);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            xA.Minimum = -10000;
            xA.Maximum = 0;

            xB.Maximum = 10000;
            xB.Minimum = 0;

            xC.Maximum = 10000;
            xC.Minimum = 0;

            xD.Minimum = -10000;
            xD.Maximum = 0;

            yA.Minimum = -10000;
            yA.Maximum = 10000;

            yB.Maximum = 10000;
            yB.Minimum = -10000;

            yC.Maximum = 10000;
            yC.Minimum = -10000;

            yD.Minimum = -10000;
            yD.Maximum = 10000;

            pictureBox1.Image = null;
            pictureBox2.Image = null;

            xA.Value = 0;
            xB.Value = 0;
            xC.Value = 0;
            xD.Value = 0;
            yA.Value = 0;
            yB.Value = 0;
            yC.Value = 0;
            yD.Value = 0;
        }
        

    }

}







