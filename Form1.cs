using SignalSolt.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    c1 c1 = new c1(i);
                }
            });
            Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    c1 c1 = new c1(i);
                }
            });


            SignalSoltRegister.AddSolt("測溫電錶結束", (k, v)=>
            {


            SignalSoltRegister.Signal("測溫電錶", new SignalSoltItem()
            {
            });

            SignalSoltRegister.Signal("測阻電錶", new SignalSoltItem()
            {
            });
            });

            SignalSoltRegister.AddSolt("測阻電錶結束", (l, v)=>
            {
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignalSoltRegister.Signal("測溫電錶", new SignalSoltItem()
            {
            });
        }
    }

    class c1
    {
        public int i = -1;
        public c1(int i)
        {
            this.i = i;
            SignalSoltRegister.AddSolt("1122", (k, o) =>
            {
                Console.WriteLine(1);
            }, i.ToString());
        }
    }
}
