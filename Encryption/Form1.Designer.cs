namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonKey = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(383, 28);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(154, 35);
            this.buttonKey.TabIndex = 0;
            this.buttonKey.Text = "Use key";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 9);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(96, 16);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Введіть ключ:";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(383, 352);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(154, 33);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt File";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(15, 352);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(148, 33);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Decrypt File";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(12, 34);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(362, 22);
            this.textBoxKey.TabIndex = 7;
            this.textBoxKey.UseSystemPasswordChar = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(383, 85);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(153, 36);
            this.buttonChoose.TabIndex = 8;
            this.buttonChoose.Text = "Обрати файл";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 140);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(11, 16);
            this.labelPath.TabIndex = 9;
            this.labelPath.Text = "-";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 256);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(521, 23);
            this.progressBar.TabIndex = 10;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 220);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(11, 16);
            this.labelResult.TabIndex = 11;
            this.labelResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 397);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonKey);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelResult;
    }
}

