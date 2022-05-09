using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Threading;
using ThreadTimer = System.Threading.Timer;

namespace SerialScreen_ver1
{
    public class AutoSelect
    {
        private readonly string deviceID_;
        private readonly MySerialPort sp_;
        private readonly ToolStripLabel label_;
        private readonly Queue<string> name_ = ComPort.List();
        private readonly ThreadTimer timerAck_; // when waiting MCU responce

        public ComSelectForm ComSelectForm;
        public string selectedCOM;
        public bool COM_selecting = false;
        public Form1 MainForm;
        

        public AutoSelect(string id, MySerialPort sp,Form1 mainform)
        //(string id, MySerialPort sp, ToolStripLabel label)
        {
            deviceID_ = id;
            sp_ = sp;
            //label_ = label;
            //timerAck_ = new ThreadTimer(new TimerCallback(AckTimeout)); //AckTimeout is called regulary
            MainForm = mainform;

            ComPortCheck();
        }

        public void ResetQueueCOM()
        {
            name_.Clear();
            name_.Enqueue(selectedCOM);
        }

        public void StopTimer() => timerAck_.Change(-1, 0); // 1 argument: waiting time (ms, -1 means never called), 2 argument: period time. if value is 2, AckTimeout is called every 2 ms.

        public void ComPortCheck()
        {
            if (name_.Count == 0)
            {
               // MessageBox.Show("stm32が接続されていません。"); ;
            }
            //"ST"と名前のつくデバイスが２つ以上接続されているとき。
            //新しいフォームを生成して、選択できるようにする。
            if(name_.Count > 1)
            {
                COM_selecting = true;
                ComSelectForm = new ComSelectForm(name_,sp_,MainForm);
                ComSelectForm.Show();
            }
            
            else
            {
                //timerAck_.Change(100, 0);
                sp_.Open(name_.Dequeue());
                // if (sp_.Open(name_.Dequeue()))
                //  sp_.SendTo(deviceID_);
                MessageBox.Show("connected");
            }
        }

        private void AckTimeout(object state)
        {
            if (sp_.SrPort.IsOpen) sp_.SrPort.Close();
            Thread.Sleep(50);
            ComPortCheck();
        }
    }
}
