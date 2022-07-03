using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace Encryption
{
    
    public partial class Form1 : Form
    {
        readonly CspParameters _cspp = new CspParameters();
        RSACryptoServiceProvider _rsa;
        Stopwatch stopWatch = new Stopwatch();

        const string EncrFolder = @"c:\Users\Beebo\Desktop\Secur\Encrypt\";
        const string DecrFolder = @"c:\Users\Beebo\Desktop\Secur\Decrypt\";
        const string SrcFolder = @"c:\Users\Beebo\Desktop\Secur\docs\";

        const string PubKeyFile = @"C:\Users\Beebo\Desktop\Secur\keyfile.txt";

        const string KeyName = "Key01";

        bool encryped = false;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }
        
        
        private void InitializeBackgroundWorker()
        {
            backgroundWorker.DoWork +=
                new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker_RunWorkerCompleted);
            backgroundWorker.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker_ProgressChanged);
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                labelResult.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                labelResult.Text = "Error: " + e.Error.Message;
            }
            else
            {
              TimeSpan ts = stopWatch.Elapsed;
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
             labelResult.Text = "Done!\n" + "RunTime " + elapsedTime;
                if (_rsa != null)
                    MessageBox.Show($"Початковий розмір файлу - {filelengthStart},\nкінцевий розмір файлу - {filelengthEnd},\nшлях - {fName},\nвитрачений час - {elapsedTime}\n");
            }
        }
        private void backgroundWorker_ProgressChanged(object sender,
        ProgressChangedEventArgs e)
        {
        this.progressBar.Value = e.ProgressPercentage;
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        labelResult.Text = (e.ProgressPercentage.ToString() + "%\n" + elapsedTime);
        }
        
        private void backgroundWorker_DoWork(object sender,
          DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
            }
            else
            {
                worker.ReportProgress(0);
                stopWatch.Reset();
                stopWatch.Start();
              
                if (encryped == false)
                {
                    if (_rsa is null)
                    {
                        MessageBox.Show("Key not set.");
                    }
                    else
                    {
             
                                if (fName != null)
                                {
                                    EncryptFile(new FileInfo(fName));
                          
                                }
                         
                    }
                }
                else if (encryped == true)
                {
                    if (_rsa is null)
                    {
                        MessageBox.Show("Key not set.");
                    }
                    else
                    {
                                if (fName != null)
                                {
                                    DecryptFile(new FileInfo(fName));
                                }
                    }
                    }
                stopWatch.Stop();
                worker.ReportProgress(100);
            }
        }
        private void buttonCreateAsmKeys_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text;
            if (key.Equals(KeyName))
            {
                _cspp.KeyContainerName = KeyName;
                _rsa = new RSACryptoServiceProvider(_cspp)
                {
                    PersistKeyInCsp = true
                };

                labelKey.Text =  $"Ключ: {_cspp.KeyContainerName} - Введено";
            }
            else if (key.Equals(KeyName) != true)
            {
                _rsa = null;

                labelKey.Text = "Введіть правильний ключ:";
            } 
           

        
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                encryped = false;
                backgroundWorker.RunWorkerAsync();
            }
           
        }
        long filelengthEnd;
        private void EncryptFile(FileInfo file)
        {
         
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();
   
            byte[] keyEncrypted = _rsa.Encrypt(aes.Key, false);

            int lKey = keyEncrypted.Length;
            byte[] LenK = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            byte[] LenIV = BitConverter.GetBytes(lIV);

            string outFile =
                Path.Combine(EncrFolder, Path.ChangeExtension(file.Name, ".enc"));

            using (var outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(aes.IV, 0, lIV);

               
                using (var outStreamEncrypted =
                    new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (var inFs = new FileStream(file.FullName, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        } while (count > 0);
                    }
                    outStreamEncrypted.FlushFinalBlock();
                }
                Name = outFile;
                filelengthEnd = new FileInfo(Name).Length;
            }
        }
        private void buttonDecryptFile_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                encryped = true;
                backgroundWorker.RunWorkerAsync();
            }
        }
        
        private void DecryptFile(FileInfo file)
        {
            
            Aes aes = Aes.Create();

     
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

           
            string outFile =
                Path.ChangeExtension(file.FullName.Replace("Encrypt", "Decrypt"), ".txt");

      
            using (var inFs = new FileStream(file.FullName, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

          
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

             
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

      
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);

                Directory.CreateDirectory(DecrFolder);
             
                byte[] KeyDecrypted = _rsa.Decrypt(KeyEncrypted, false);

        
                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                using (var outFs = new FileStream(outFile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (var outStreamDecrypted =
                        new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        } while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                    }
                }
                Name = outFile;
                filelengthEnd = new FileInfo(Name).Length;
            }
        }
        string fName = "";
        long filelengthStart;

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _encryptOpenFileDialog = new OpenFileDialog())
            {

                _encryptOpenFileDialog.InitialDirectory = SrcFolder;
                if (_encryptOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fName = _encryptOpenFileDialog.FileName;
                    filelengthStart = new FileInfo(fName).Length;
                    labelPath.Text = fName;
                }
            }
        }

      
    }
}
