using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string ProcessName = "";

        private void button1_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = true;
            radioButtonOnCal.Visible = true;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = true;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;

        }

        private void buttonWordOn_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = true;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = true;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = true;
        }

        private void buttonNotepadOn_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = true;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = true;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = true;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
        }

        private void buttonPaintOn_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = true;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = true;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = true;
            buttonPrWord.Visible = false;
        }

        private void buttonExcelOn_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = true;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = true;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = true;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            string[] A = { "calculator", "word", "notepad", "paint", "excel" };
            string[] B = { "Пам'ять", "Час запуску", "Приорітет", "Потоки" };

            ShowInfo(A, B, allData);
            allData.Visible = true;
            buttonMoreInfo.Text = "Оновити подробиці";

        }

        private void buttonChangePr_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = true;
            buttonExcelOn.Visible = true;
            buttonCalculatorOn.Visible = true;
            buttonNotepadOn.Visible = true;
            buttonPaintOn.Visible = true;
            buttonWordOn.Visible = true;
            radioButtonHigh.Visible = false;
            radioButtonIdle.Visible = false;
            radioButtonNormal.Visible = false;
            radioButtonRealTime.Visible = false;
            
            buttonChangePr.Visible = false;
            nameLabel.Text = "Доступні програми";

            var check = ProcessExists(ProcessName);
            if (check == true)
            {
                Process proc = Process.GetProcessesByName(ProcessName)[0];
                if (radioButtonIdle.Checked == true)
                {
                    proc.PriorityClass = ProcessPriorityClass.Idle;
                }
                else if (radioButtonNormal.Checked == true)
                {
                    proc.PriorityClass = ProcessPriorityClass.Normal;
                }
                else if (radioButtonHigh.Checked == true)
                {
                    proc.PriorityClass = ProcessPriorityClass.High;
                }
                else if (radioButtonRealTime.Checked == true)
                {
                    proc.PriorityClass = ProcessPriorityClass.RealTime;
                }
            }
            else
            {
                MessageBox.Show("Змінити приорітет неможливо, процес не створено");
            }
            
        }

        private void buttonPrCal_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = false;
            buttonExcelOn.Visible = false;
            buttonCalculatorOn.Visible = false;
            buttonNotepadOn.Visible = false;
            buttonPaintOn.Visible = false;
            buttonWordOn.Visible = false;
            buttonChangePr.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonIdle.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonRealTime.Visible = true;
            nameLabel.Text = "Зміна прироітету";
            ProcessName = "calculator";
        }

        private void buttonPrWord_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = false;
            buttonExcelOn.Visible = false;
            buttonCalculatorOn.Visible = false;
            buttonNotepadOn.Visible = false;
            buttonPaintOn.Visible = false;
            buttonWordOn.Visible = false;
            buttonChangePr.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonIdle.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonRealTime.Visible = true;
            nameLabel.Text = "Зміна прироітету";
            ProcessName = "winword";
        }

        private void buttonPrNotepad_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = false;
            buttonExcelOn.Visible = false;
            buttonCalculatorOn.Visible = false;
            buttonNotepadOn.Visible = false;
            buttonPaintOn.Visible = false;
            buttonWordOn.Visible = false;
            buttonChangePr.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonIdle.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonRealTime.Visible = true;
            nameLabel.Text = "Зміна прироітету";
            ProcessName = "Notepad";
        }

        private void buttonPrPaint_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = false;
            buttonExcelOn.Visible = false;
            buttonCalculatorOn.Visible = false;
            buttonNotepadOn.Visible = false;
            buttonPaintOn.Visible = false;
            buttonWordOn.Visible = false;
            buttonChangePr.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonIdle.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonRealTime.Visible = true;
            nameLabel.Text = "Зміна прироітету";
            ProcessName = "mspaint";
        }

        private void buttonPrExcel_Click(object sender, EventArgs e)
        {
            radioButtonOffCal.Visible = false;
            radioButtonOnCal.Visible = false;
            radioButtonOffExcel.Visible = false;
            radioButtonOffNotepad.Visible = false;
            radioButtonOffPaint.Visible = false;
            radioButtonOffWord.Visible = false;
            radioButtonOnExcel.Visible = false;
            radioButtonOnNotepad.Visible = false;
            radioButtonOnPaint.Visible = false;
            radioButtonOnWord.Visible = false;
            buttonPrCal.Visible = false;
            buttonPrExcel.Visible = false;
            buttonPrNotepad.Visible = false;
            buttonPrPaint.Visible = false;
            buttonPrWord.Visible = false;
            allData.Visible = false;
            buttonMoreInfo.Visible = false;
            buttonExcelOn.Visible = false;
            buttonCalculatorOn.Visible = false;
            buttonNotepadOn.Visible = false;
            buttonPaintOn.Visible = false;
            buttonWordOn.Visible = false;
            buttonChangePr.Visible = true;
            radioButtonHigh.Visible = true;
            radioButtonIdle.Visible = true;
            radioButtonNormal.Visible = true;
            radioButtonRealTime.Visible = true;
            nameLabel.Text = "Зміна прироітету";
            ProcessName = "excel";
        }

        private void radioButtonOnCal_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void radioButtonOnNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void radioButtonOnWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void radioButtonOnPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void radioButtonOnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void radioButtonOffCal_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("calculator"))
            {
                proc.Kill();
            }
        }

        private void radioButtonOffWord_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("winword"))
            {
                proc.Kill();
            }
        }

        private void radioButtonOffNotepad_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("Notepad"))
            {
                proc.Kill();
            }
        }

        private void radioButtonOffPaint_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("mspaint"))
            {
                proc.Kill();
            }
        }

        private void radioButtonOffExcel_Click(object sender, EventArgs e)
        {
            foreach (Process proc in Process.GetProcessesByName("excel"))
            {
                proc.Kill();
            }
        }

        public static void ShowInfo(string[] A, string[] B, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = B.Length;
            dataGridView.RowCount = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = A[i].ToString();
            }
            for (int i = 0; i < B.Length; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = B[i].ToString();
            }


            var proc1 = "calculator";
            var check1 =  ProcessExists(proc1);
            if (check1 == true)
            {
                Process procOne = Process.GetProcessesByName("calculator")[0];
                ProcessThreadCollection processThreads = procOne.Threads;
                dataGridView[0, 0].Value = procOne.PagedMemorySize64;
                dataGridView[1, 0].Value = procOne.StartTime;
                foreach (ProcessThread thread in processThreads)
                {
                    dataGridView[2, 0].Value = thread.CurrentPriority;
                }
                int count = Process.GetProcessesByName("calculator")[0].Threads.Count;
                dataGridView[3, 0].Value = count;

            }
            else
            {
                dataGridView[0, 0].Value = "0";
                dataGridView[1, 0].Value = "0";
                dataGridView[2, 0].Value = "0";
                dataGridView[3, 0].Value = "0";
            }

            var proc2 = "winword";
            var check2 = ProcessExists(proc2);
            if (check2 == true)
            {
                Process proc = Process.GetProcessesByName("winword")[0];
                ProcessThreadCollection processThreads = proc.Threads;
                dataGridView[0, 1].Value = proc.PagedMemorySize64;
                dataGridView[1, 1].Value = proc.StartTime;
                foreach (ProcessThread thread in processThreads)
                {
                    dataGridView[2, 1].Value = thread.CurrentPriority;
                }
                int count = Process.GetProcessesByName("winword")[0].Threads.Count;
                dataGridView[3, 1].Value = count;

            }
            else
            {
                dataGridView[0, 1].Value = "0";
                dataGridView[1, 1].Value = "0";
                dataGridView[2, 1].Value = "0";
                dataGridView[3, 1].Value = "0";
            }

            var proc3 = "Notepad";
            var check3 = ProcessExists(proc3);
            if (check3 == true)
            {
                Process proc = Process.GetProcessesByName("Notepad")[0];
                ProcessThreadCollection processThreads = proc.Threads;
                dataGridView[0, 2].Value = proc.PagedMemorySize64;
                dataGridView[1, 2].Value = proc.StartTime;
                foreach (ProcessThread thread in processThreads)
                {
                    dataGridView[2, 2].Value = thread.CurrentPriority;
                }
                int count = Process.GetProcessesByName("Notepad")[0].Threads.Count;
                dataGridView[3, 2].Value = count;

            }
            else
            {
                dataGridView[0, 2].Value = "0";
                dataGridView[1, 2].Value = "0";
                dataGridView[2, 2].Value = "0";
                dataGridView[3, 2].Value = "0";
            }
            var proc4 = "mspaint";
            var check4 = ProcessExists(proc4);
            if (check4 == true)
            {
                Process proc = Process.GetProcessesByName("mspaint")[0];
                ProcessThreadCollection processThreads = proc.Threads;
                dataGridView[0, 3].Value = proc.PagedMemorySize64;
                dataGridView[1, 3].Value = proc.StartTime;
                foreach (ProcessThread thread in processThreads)
                {
                    dataGridView[2, 3].Value = thread.CurrentPriority;
                }
                int count = Process.GetProcessesByName("mspaint")[0].Threads.Count;
                dataGridView[3, 3].Value = count;

            }
            else
            {
                dataGridView[0, 3].Value = "0";
                dataGridView[1, 3].Value = "0";
                dataGridView[2, 3].Value = "0";
                dataGridView[3, 3].Value = "0";
            }
            var proc5 = "excel";
            var check5 = ProcessExists(proc5);
            if (check5 == true)
            {
                Process proc = Process.GetProcessesByName("excel")[0];
                ProcessThreadCollection processThreads = proc.Threads;
                dataGridView[0, 4].Value = proc.PagedMemorySize64;
                dataGridView[1, 4].Value = proc.StartTime;
                foreach (ProcessThread thread in processThreads)
                {
                    dataGridView[2, 4].Value = thread.CurrentPriority;
                }
                int count = Process.GetProcessesByName("excel")[0].Threads.Count;
                dataGridView[3, 4].Value = count;

            }
            else
            {
                dataGridView[0, 4].Value = "0";
                dataGridView[1, 4].Value = "0";
                dataGridView[2, 4].Value = "0";
                dataGridView[3, 4].Value = "0";
            }
        }
        public static bool ProcessExists(string pName)
        {
            Process[] pList = Process.GetProcessesByName(pName);
            if (pList.Length > 0) 
            { 
             return true;
            }
            

            return false;
        }

        }
    }

