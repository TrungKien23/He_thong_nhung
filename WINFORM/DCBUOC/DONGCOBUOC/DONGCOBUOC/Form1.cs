using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DONGCOBUOC
{
    public partial class Form1 : Form
    {
        int intlen, toccdo, xungg = 0;
        int tocdo = 0, chedo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chedo = 1;
            if (tocdo > 10)
            {
                tocdo = tocdo - 10;
            }
            else
            {
                tocdo = 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("A");
                serialPort1.Write(caitd.Text);
                serialPort1.Write("#");
                chedo = 0;
                tocdo = int.Parse(caitd.Text.ToString());
                hientocdo.Text = caitd.Text;
            }
            else
            {
                MessageBox.Show("Chưa kết nối cổng COM", "Thông báo");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void tangxung_Click(object sender, EventArgs e)
        {

        }

        private void giamxung_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                comboBox1.Items.Clear();
                for (int i = 0; i < intlen; i++)
                {
                    comboBox1.Items.Add(ports[i]);
                }
            }
        }

        private void ngatketnoi_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            ketnoi.Enabled = true;
            ngatketnoi.Enabled = false;
        }

        private void ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strPortName = SerialPort.GetPortNames();
                if (strPortName.Length < 1)
                {
                    MessageBox.Show("Máy tính của bạn không có cổng COM!", "Thông báo");
                    return;
                }

                serialPort1.PortName = comboBox1.Text;
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.Open();
                    ketnoi.Enabled = false;
                    ngatketnoi.Enabled = true;
                }
                else
                    MessageBox.Show("Cổng COM đã được sử dụng", "Thông báo!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại cổng COM!", "Thông báo");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chedo == 1)
            {
                caitd.Text = tocdo.ToString();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tocdo < 100)
            {
                tocdo = tocdo + 10;
            }
            else
            {
                tocdo = 10;
            }
            chedo = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
