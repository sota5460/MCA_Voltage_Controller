using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialScreen_ver1
{
    public partial class ComSelectForm : Form
    {

        public Queue <string> com_list { get; set; }
       
        public MySerialPort sp2_ { get; set; }

        public Form1 MainForm;

        public ComSelectForm(Queue<string> coms,MySerialPort sp2,Form1 mainform)
        {
            InitializeComponent();
            this.com_list = coms;
            this.sp2_ = sp2;
            this.MainForm = mainform;
            
           
        }



        private void ComSelectForm_Load(object sender, EventArgs e)
        {
            foreach(string com in com_list)
            {
                comboBox_com.Items.Add(com);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {

            if(comboBox_com.SelectedItem == null)
            {
                MessageBox.Show("Select COM port");
                return;
            }

            sp2_.Open(comboBox_com.SelectedItem.ToString());

            MessageBox.Show("Connected");
            MainForm.Enabled = true;
            MainForm.WhenSerialOpen();

            this.Close();

        }

        private void ComSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Enabled = true;
        }
    }
}
