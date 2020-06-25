using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasklKlavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        globalKeyboardHook gkh = new globalKeyboardHook();
        private void Form1_Load(object sender, EventArgs e)
        {
            //добавляем какие будут горячие клавиши
            gkh.HookedKeys.Add(Keys.Q);
            gkh.HookedKeys.Add(Keys.W);
            gkh.HookedKeys.Add(Keys.E);
            gkh.HookedKeys.Add(Keys.R);
            gkh.HookedKeys.Add(Keys.T);
            gkh.HookedKeys.Add(Keys.Y);
            gkh.HookedKeys.Add(Keys.U);
            gkh.HookedKeys.Add(Keys.I);
            gkh.HookedKeys.Add(Keys.O);
            gkh.HookedKeys.Add(Keys.P);
            gkh.HookedKeys.Add(Keys.Oem4);
            gkh.HookedKeys.Add(Keys.Oem6);
            gkh.HookedKeys.Add(Keys.A);
            gkh.HookedKeys.Add(Keys.S);
            gkh.HookedKeys.Add(Keys.D);
            gkh.HookedKeys.Add(Keys.F);
            gkh.HookedKeys.Add(Keys.G);
            gkh.HookedKeys.Add(Keys.H);
            gkh.HookedKeys.Add(Keys.J);
            gkh.HookedKeys.Add(Keys.K);
            gkh.HookedKeys.Add(Keys.L);
            gkh.HookedKeys.Add(Keys.Oem1);
            gkh.HookedKeys.Add(Keys.Oem7);
            gkh.HookedKeys.Add(Keys.Z);
            gkh.HookedKeys.Add(Keys.X);
            gkh.HookedKeys.Add(Keys.C);
            gkh.HookedKeys.Add(Keys.V);
            gkh.HookedKeys.Add(Keys.B);
            gkh.HookedKeys.Add(Keys.N);
            gkh.HookedKeys.Add(Keys.M);
            gkh.HookedKeys.Add(Keys.Oemcomma);
            gkh.HookedKeys.Add(Keys.OemPeriod);
            gkh.HookedKeys.Add(Keys.Oem2);
            gkh.HookedKeys.Add(Keys.Space);
            //
            // и т.п.
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }
            
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                //Если в буфере обмен содержится текст
                if (Clipboard.ContainsText() == true)
                {
                    //Извлекаем (точнее копируем) его и сохраняем в переменную
                    string someText = Clipboard.GetText();

                    //Выводим показываем сообщение с текстом, скопированным из буфера обмена
                    MessageBox.Show(this, someText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }



        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { 
                notifyIcon1.Visible = false; 
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //notifyIcon1.Visible = true;
            //this.Hide();
        }
    }
}
