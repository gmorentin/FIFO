using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        //Queue<Proceso> miFifo = new Queue<Proceso>();
        ColaQueue miFifo = new ColaQueue();
        Random alea = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            int cpa = 0;
            int ccu = 0;
            for(int i = 0; i <= 200; i++)
            {
                if (alea.Next(1, 100) <= 25)
                {
                    Proceso nuevo = new Proceso(alea.Next(4, 14));
                    miFifo.Enqueue(nuevo);
                    txtProcesos.Text += i + "Proceso: " + alea+Environment.NewLine;
                }
                if (miFifo.Peek() != null)//count tiene que ser mayor a 0
                {
                    miFifo.Peek().tiempo--;
                    if (miFifo.Peek().tiempo == 0)
                    {
                        cpa++;
                        miFifo.Dequeue();
                    }
                }
                else
                    ccu++;
                txtProcesos.Text += cpa+Environment.NewLine;
                txtProcesos.Text += ccu + Environment.NewLine;
            }
        }

    }
}
