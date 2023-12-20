using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Araba_Kontrol
{
    public partial class Form1 : Form
    {
        string[] portlistesi; //bilgisayara bağlanacak portlar listelenecek
        bool baglantıdurumu = false; //bağlantının aktif olup olmadığı denetlenecek
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxKontrol.Enabled = false;
            portlistele();
        }
        void portlistele()
        {
            comboBox1.Items.Clear(); //listelenen elemalar tekrar listelenmesi için silinid
            portlistesi = SerialPort.GetPortNames(); //aktif alınan port listesi değiskenetanımlanıyor
            foreach (string portadi in portlistesi)
            {
                comboBox1.Items.Add(portadi); //dizi her deöndüğünde sıfırıncı elemandan başlayarak portadi na ekliyor.
                if (portlistesi[0] != null)
                {
                    comboBox1.SelectedItem = portlistesi[0]; // ilk elemanı comboboxda gösterilmesi sağlanıyor
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            portlistele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(baglantıdurumu == false)
            {
                serialPort1.PortName = comboBox1.GetItemText(comboBox1.SelectedItem); //combobox da şeçili item serial porta atanır
                serialPort1.BaudRate = 9600; //bağlantı hızı
                serialPort1.Open();
                comboBox1.Enabled = false; //bağlantı yapıldığı için seçime gerek yok
                button2.Enabled = false;
                baglantıdurumu = true;
                button1.Text = "Bağlantıyı Kes";
                groupBoxKontrol.Enabled = true;
                 //groupBoxBluetooth.Enabled = false;
                button1.Enabled = false;
                label2.Text = "Bağlandı";
            }
            else
            {
                serialPort1.Close();
                baglantıdurumu = false;
                button1.Text = "Bağlan";
                comboBox1.Enabled = true;
                button2.Enabled = true;
                groupBoxKontrol.Enabled = false;
                label2.Text = "Bağlantı Yok";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Up)
            {
                pictUp.BackColor = Color.LimeGreen;
                serialPort1.Write("1");
            }
            else if (e.KeyCode==Keys.Down)
            {
                pictDown.BackColor = Color.LimeGreen;
                serialPort1.Write("2");
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictRight.BackColor = Color.LimeGreen;
                serialPort1.Write("4");
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictLeft.BackColor = Color.LimeGreen;
                serialPort1.Write("3");
            }
            else
            {
                pictUp.BackColor = Color.DarkCyan;
                pictDown.BackColor = Color.DarkCyan;
                pictLeft.BackColor = Color.DarkCyan;
                pictRight.BackColor = Color.DarkCyan;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                pictUp.BackColor = Color.DarkCyan;
                serialPort1.Write("6");
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictDown.BackColor = Color.DarkCyan;
                serialPort1.Write("6");
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictRight.BackColor = Color.DarkCyan;
                serialPort1.Write("6");
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictLeft.BackColor = Color.DarkCyan;
                serialPort1.Write("6");
            }
          
        }

       
    }
}
