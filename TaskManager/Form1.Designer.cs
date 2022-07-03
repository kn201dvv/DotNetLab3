namespace TaskManager
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonCalculatorOn = new System.Windows.Forms.Button();
            this.buttonWordOn = new System.Windows.Forms.Button();
            this.buttonNotepadOn = new System.Windows.Forms.Button();
            this.buttonPaintOn = new System.Windows.Forms.Button();
            this.buttonExcelOn = new System.Windows.Forms.Button();
            this.buttonPrCal = new System.Windows.Forms.Button();
            this.buttonPrWord = new System.Windows.Forms.Button();
            this.buttonPrNotepad = new System.Windows.Forms.Button();
            this.buttonPrPaint = new System.Windows.Forms.Button();
            this.buttonPrExcel = new System.Windows.Forms.Button();
            this.buttonMoreInfo = new System.Windows.Forms.Button();
            this.allData = new System.Windows.Forms.DataGridView();
            this.buttonChangePr = new System.Windows.Forms.Button();
            this.radioButtonOnCal = new System.Windows.Forms.Button();
            this.radioButtonOffCal = new System.Windows.Forms.Button();
            this.radioButtonOnWord = new System.Windows.Forms.Button();
            this.radioButtonOnNotepad = new System.Windows.Forms.Button();
            this.radioButtonOnPaint = new System.Windows.Forms.Button();
            this.radioButtonOnExcel = new System.Windows.Forms.Button();
            this.radioButtonOffWord = new System.Windows.Forms.Button();
            this.radioButtonOffNotepad = new System.Windows.Forms.Button();
            this.radioButtonOffPaint = new System.Windows.Forms.Button();
            this.radioButtonOffExcel = new System.Windows.Forms.Button();
            this.radioButtonIdle = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonRealTime = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(241, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(267, 33);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Доступні програми";
            // 
            // buttonCalculatorOn
            // 
            this.buttonCalculatorOn.Location = new System.Drawing.Point(51, 74);
            this.buttonCalculatorOn.Name = "buttonCalculatorOn";
            this.buttonCalculatorOn.Size = new System.Drawing.Size(149, 40);
            this.buttonCalculatorOn.TabIndex = 1;
            this.buttonCalculatorOn.Text = "Калькулятор";
            this.buttonCalculatorOn.UseVisualStyleBackColor = true;
            this.buttonCalculatorOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWordOn
            // 
            this.buttonWordOn.Location = new System.Drawing.Point(51, 120);
            this.buttonWordOn.Name = "buttonWordOn";
            this.buttonWordOn.Size = new System.Drawing.Size(149, 40);
            this.buttonWordOn.TabIndex = 2;
            this.buttonWordOn.Text = "Microsoft Word";
            this.buttonWordOn.UseVisualStyleBackColor = true;
            this.buttonWordOn.Click += new System.EventHandler(this.buttonWordOn_Click);
            // 
            // buttonNotepadOn
            // 
            this.buttonNotepadOn.Location = new System.Drawing.Point(51, 166);
            this.buttonNotepadOn.Name = "buttonNotepadOn";
            this.buttonNotepadOn.Size = new System.Drawing.Size(149, 42);
            this.buttonNotepadOn.TabIndex = 3;
            this.buttonNotepadOn.Text = "Notepad";
            this.buttonNotepadOn.UseVisualStyleBackColor = true;
            this.buttonNotepadOn.Click += new System.EventHandler(this.buttonNotepadOn_Click);
            // 
            // buttonPaintOn
            // 
            this.buttonPaintOn.Location = new System.Drawing.Point(51, 214);
            this.buttonPaintOn.Name = "buttonPaintOn";
            this.buttonPaintOn.Size = new System.Drawing.Size(149, 41);
            this.buttonPaintOn.TabIndex = 4;
            this.buttonPaintOn.Text = "Paint";
            this.buttonPaintOn.UseVisualStyleBackColor = true;
            this.buttonPaintOn.Click += new System.EventHandler(this.buttonPaintOn_Click);
            // 
            // buttonExcelOn
            // 
            this.buttonExcelOn.Location = new System.Drawing.Point(51, 261);
            this.buttonExcelOn.Name = "buttonExcelOn";
            this.buttonExcelOn.Size = new System.Drawing.Size(149, 40);
            this.buttonExcelOn.TabIndex = 5;
            this.buttonExcelOn.Text = "Excel";
            this.buttonExcelOn.UseVisualStyleBackColor = true;
            this.buttonExcelOn.Click += new System.EventHandler(this.buttonExcelOn_Click);
            // 
            // buttonPrCal
            // 
            this.buttonPrCal.Location = new System.Drawing.Point(483, 74);
            this.buttonPrCal.Name = "buttonPrCal";
            this.buttonPrCal.Size = new System.Drawing.Size(97, 40);
            this.buttonPrCal.TabIndex = 16;
            this.buttonPrCal.Text = "Приорітет";
            this.buttonPrCal.UseVisualStyleBackColor = true;
            this.buttonPrCal.Visible = false;
            this.buttonPrCal.Click += new System.EventHandler(this.buttonPrCal_Click);
            // 
            // buttonPrWord
            // 
            this.buttonPrWord.Location = new System.Drawing.Point(483, 120);
            this.buttonPrWord.Name = "buttonPrWord";
            this.buttonPrWord.Size = new System.Drawing.Size(97, 40);
            this.buttonPrWord.TabIndex = 17;
            this.buttonPrWord.Text = "Приорітет";
            this.buttonPrWord.UseVisualStyleBackColor = true;
            this.buttonPrWord.Visible = false;
            this.buttonPrWord.Click += new System.EventHandler(this.buttonPrWord_Click);
            // 
            // buttonPrNotepad
            // 
            this.buttonPrNotepad.Location = new System.Drawing.Point(483, 168);
            this.buttonPrNotepad.Name = "buttonPrNotepad";
            this.buttonPrNotepad.Size = new System.Drawing.Size(97, 40);
            this.buttonPrNotepad.TabIndex = 18;
            this.buttonPrNotepad.Text = "Приорітет";
            this.buttonPrNotepad.UseVisualStyleBackColor = true;
            this.buttonPrNotepad.Visible = false;
            this.buttonPrNotepad.Click += new System.EventHandler(this.buttonPrNotepad_Click);
            // 
            // buttonPrPaint
            // 
            this.buttonPrPaint.Location = new System.Drawing.Point(483, 214);
            this.buttonPrPaint.Name = "buttonPrPaint";
            this.buttonPrPaint.Size = new System.Drawing.Size(97, 41);
            this.buttonPrPaint.TabIndex = 19;
            this.buttonPrPaint.Text = "Приорітет";
            this.buttonPrPaint.UseVisualStyleBackColor = true;
            this.buttonPrPaint.Visible = false;
            this.buttonPrPaint.Click += new System.EventHandler(this.buttonPrPaint_Click);
            // 
            // buttonPrExcel
            // 
            this.buttonPrExcel.Location = new System.Drawing.Point(483, 261);
            this.buttonPrExcel.Name = "buttonPrExcel";
            this.buttonPrExcel.Size = new System.Drawing.Size(97, 40);
            this.buttonPrExcel.TabIndex = 20;
            this.buttonPrExcel.Text = "Приорітет";
            this.buttonPrExcel.UseVisualStyleBackColor = true;
            this.buttonPrExcel.Visible = false;
            this.buttonPrExcel.Click += new System.EventHandler(this.buttonPrExcel_Click);
            // 
            // buttonMoreInfo
            // 
            this.buttonMoreInfo.Location = new System.Drawing.Point(566, 553);
            this.buttonMoreInfo.Name = "buttonMoreInfo";
            this.buttonMoreInfo.Size = new System.Drawing.Size(157, 52);
            this.buttonMoreInfo.TabIndex = 21;
            this.buttonMoreInfo.Text = "Подробиці";
            this.buttonMoreInfo.UseVisualStyleBackColor = true;
            this.buttonMoreInfo.Click += new System.EventHandler(this.buttonMoreInfo_Click);
            // 
            // allData
            // 
            this.allData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allData.Location = new System.Drawing.Point(51, 336);
            this.allData.Name = "allData";
            this.allData.RowHeadersWidth = 90;
            this.allData.RowTemplate.Height = 24;
            this.allData.Size = new System.Drawing.Size(672, 174);
            this.allData.TabIndex = 22;
            this.allData.Visible = false;
            // 
            // buttonChangePr
            // 
            this.buttonChangePr.Location = new System.Drawing.Point(314, 261);
            this.buttonChangePr.Name = "buttonChangePr";
            this.buttonChangePr.Size = new System.Drawing.Size(96, 41);
            this.buttonChangePr.TabIndex = 24;
            this.buttonChangePr.Text = "Змінити";
            this.buttonChangePr.UseVisualStyleBackColor = true;
            this.buttonChangePr.Visible = false;
            this.buttonChangePr.Click += new System.EventHandler(this.buttonChangePr_Click);
            // 
            // radioButtonOnCal
            // 
            this.radioButtonOnCal.Location = new System.Drawing.Point(247, 74);
            this.radioButtonOnCal.Name = "radioButtonOnCal";
            this.radioButtonOnCal.Size = new System.Drawing.Size(47, 35);
            this.radioButtonOnCal.TabIndex = 25;
            this.radioButtonOnCal.Text = "on";
            this.radioButtonOnCal.UseVisualStyleBackColor = true;
            this.radioButtonOnCal.Visible = false;
            this.radioButtonOnCal.Click += new System.EventHandler(this.radioButtonOnCal_Click);
            // 
            // radioButtonOffCal
            // 
            this.radioButtonOffCal.Location = new System.Drawing.Point(363, 74);
            this.radioButtonOffCal.Name = "radioButtonOffCal";
            this.radioButtonOffCal.Size = new System.Drawing.Size(54, 35);
            this.radioButtonOffCal.TabIndex = 26;
            this.radioButtonOffCal.Text = "off";
            this.radioButtonOffCal.UseVisualStyleBackColor = true;
            this.radioButtonOffCal.Visible = false;
            this.radioButtonOffCal.Click += new System.EventHandler(this.radioButtonOffCal_Click);
            // 
            // radioButtonOnWord
            // 
            this.radioButtonOnWord.Location = new System.Drawing.Point(247, 120);
            this.radioButtonOnWord.Name = "radioButtonOnWord";
            this.radioButtonOnWord.Size = new System.Drawing.Size(47, 35);
            this.radioButtonOnWord.TabIndex = 27;
            this.radioButtonOnWord.Text = "on";
            this.radioButtonOnWord.UseVisualStyleBackColor = true;
            this.radioButtonOnWord.Visible = false;
            this.radioButtonOnWord.Click += new System.EventHandler(this.radioButtonOnWord_Click);
            // 
            // radioButtonOnNotepad
            // 
            this.radioButtonOnNotepad.Location = new System.Drawing.Point(247, 166);
            this.radioButtonOnNotepad.Name = "radioButtonOnNotepad";
            this.radioButtonOnNotepad.Size = new System.Drawing.Size(47, 35);
            this.radioButtonOnNotepad.TabIndex = 28;
            this.radioButtonOnNotepad.Text = "on";
            this.radioButtonOnNotepad.UseVisualStyleBackColor = true;
            this.radioButtonOnNotepad.Visible = false;
            this.radioButtonOnNotepad.Click += new System.EventHandler(this.radioButtonOnNotepad_Click);
            // 
            // radioButtonOnPaint
            // 
            this.radioButtonOnPaint.Location = new System.Drawing.Point(247, 217);
            this.radioButtonOnPaint.Name = "radioButtonOnPaint";
            this.radioButtonOnPaint.Size = new System.Drawing.Size(47, 35);
            this.radioButtonOnPaint.TabIndex = 29;
            this.radioButtonOnPaint.Text = "on";
            this.radioButtonOnPaint.UseVisualStyleBackColor = true;
            this.radioButtonOnPaint.Visible = false;
            this.radioButtonOnPaint.Click += new System.EventHandler(this.radioButtonOnPaint_Click);
            // 
            // radioButtonOnExcel
            // 
            this.radioButtonOnExcel.Location = new System.Drawing.Point(247, 261);
            this.radioButtonOnExcel.Name = "radioButtonOnExcel";
            this.radioButtonOnExcel.Size = new System.Drawing.Size(47, 35);
            this.radioButtonOnExcel.TabIndex = 30;
            this.radioButtonOnExcel.Text = "on";
            this.radioButtonOnExcel.UseVisualStyleBackColor = true;
            this.radioButtonOnExcel.Visible = false;
            this.radioButtonOnExcel.Click += new System.EventHandler(this.radioButtonOnExcel_Click);
            // 
            // radioButtonOffWord
            // 
            this.radioButtonOffWord.Location = new System.Drawing.Point(363, 120);
            this.radioButtonOffWord.Name = "radioButtonOffWord";
            this.radioButtonOffWord.Size = new System.Drawing.Size(54, 35);
            this.radioButtonOffWord.TabIndex = 31;
            this.radioButtonOffWord.Text = "off";
            this.radioButtonOffWord.UseVisualStyleBackColor = true;
            this.radioButtonOffWord.Visible = false;
            this.radioButtonOffWord.Click += new System.EventHandler(this.radioButtonOffWord_Click);
            // 
            // radioButtonOffNotepad
            // 
            this.radioButtonOffNotepad.Location = new System.Drawing.Point(363, 166);
            this.radioButtonOffNotepad.Name = "radioButtonOffNotepad";
            this.radioButtonOffNotepad.Size = new System.Drawing.Size(54, 35);
            this.radioButtonOffNotepad.TabIndex = 32;
            this.radioButtonOffNotepad.Text = "off";
            this.radioButtonOffNotepad.UseVisualStyleBackColor = true;
            this.radioButtonOffNotepad.Visible = false;
            this.radioButtonOffNotepad.Click += new System.EventHandler(this.radioButtonOffNotepad_Click);
            // 
            // radioButtonOffPaint
            // 
            this.radioButtonOffPaint.Location = new System.Drawing.Point(363, 217);
            this.radioButtonOffPaint.Name = "radioButtonOffPaint";
            this.radioButtonOffPaint.Size = new System.Drawing.Size(54, 35);
            this.radioButtonOffPaint.TabIndex = 33;
            this.radioButtonOffPaint.Text = "off";
            this.radioButtonOffPaint.UseVisualStyleBackColor = true;
            this.radioButtonOffPaint.Visible = false;
            this.radioButtonOffPaint.Click += new System.EventHandler(this.radioButtonOffPaint_Click);
            // 
            // radioButtonOffExcel
            // 
            this.radioButtonOffExcel.Location = new System.Drawing.Point(363, 261);
            this.radioButtonOffExcel.Name = "radioButtonOffExcel";
            this.radioButtonOffExcel.Size = new System.Drawing.Size(54, 35);
            this.radioButtonOffExcel.TabIndex = 34;
            this.radioButtonOffExcel.Text = "off";
            this.radioButtonOffExcel.UseVisualStyleBackColor = true;
            this.radioButtonOffExcel.Visible = false;
            this.radioButtonOffExcel.Click += new System.EventHandler(this.radioButtonOffExcel_Click);
            // 
            // radioButtonIdle
            // 
            this.radioButtonIdle.AutoSize = true;
            this.radioButtonIdle.Checked = true;
            this.radioButtonIdle.Location = new System.Drawing.Point(314, 81);
            this.radioButtonIdle.Name = "radioButtonIdle";
            this.radioButtonIdle.Size = new System.Drawing.Size(50, 20);
            this.radioButtonIdle.TabIndex = 35;
            this.radioButtonIdle.TabStop = true;
            this.radioButtonIdle.Text = "Idle";
            this.radioButtonIdle.UseVisualStyleBackColor = true;
            this.radioButtonIdle.Visible = false;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(314, 127);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(72, 20);
            this.radioButtonNormal.TabIndex = 36;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.Visible = false;
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(314, 173);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(56, 20);
            this.radioButtonHigh.TabIndex = 37;
            this.radioButtonHigh.Text = "High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            this.radioButtonHigh.Visible = false;
            // 
            // radioButtonRealTime
            // 
            this.radioButtonRealTime.AutoSize = true;
            this.radioButtonRealTime.Location = new System.Drawing.Point(314, 217);
            this.radioButtonRealTime.Name = "radioButtonRealTime";
            this.radioButtonRealTime.Size = new System.Drawing.Size(88, 20);
            this.radioButtonRealTime.TabIndex = 38;
            this.radioButtonRealTime.Text = "RealTime";
            this.radioButtonRealTime.UseVisualStyleBackColor = true;
            this.radioButtonRealTime.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 628);
            this.Controls.Add(this.radioButtonRealTime);
            this.Controls.Add(this.radioButtonHigh);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.radioButtonIdle);
            this.Controls.Add(this.radioButtonOffExcel);
            this.Controls.Add(this.radioButtonOffPaint);
            this.Controls.Add(this.radioButtonOffNotepad);
            this.Controls.Add(this.radioButtonOffWord);
            this.Controls.Add(this.radioButtonOnExcel);
            this.Controls.Add(this.radioButtonOnPaint);
            this.Controls.Add(this.radioButtonOnNotepad);
            this.Controls.Add(this.radioButtonOnWord);
            this.Controls.Add(this.radioButtonOffCal);
            this.Controls.Add(this.radioButtonOnCal);
            this.Controls.Add(this.buttonChangePr);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.buttonMoreInfo);
            this.Controls.Add(this.buttonPrExcel);
            this.Controls.Add(this.buttonPrPaint);
            this.Controls.Add(this.buttonPrNotepad);
            this.Controls.Add(this.buttonPrWord);
            this.Controls.Add(this.buttonPrCal);
            this.Controls.Add(this.buttonExcelOn);
            this.Controls.Add(this.buttonPaintOn);
            this.Controls.Add(this.buttonNotepadOn);
            this.Controls.Add(this.buttonWordOn);
            this.Controls.Add(this.buttonCalculatorOn);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button buttonCalculatorOn;
        private System.Windows.Forms.Button buttonWordOn;
        private System.Windows.Forms.Button buttonNotepadOn;
        private System.Windows.Forms.Button buttonPaintOn;
        private System.Windows.Forms.Button buttonExcelOn;
        private System.Windows.Forms.Button buttonPrCal;
        private System.Windows.Forms.Button buttonPrWord;
        private System.Windows.Forms.Button buttonPrNotepad;
        private System.Windows.Forms.Button buttonPrPaint;
        private System.Windows.Forms.Button buttonPrExcel;
        private System.Windows.Forms.Button buttonMoreInfo;
        private System.Windows.Forms.DataGridView allData;
        private System.Windows.Forms.Button buttonChangePr;
        private System.Windows.Forms.Button radioButtonOnCal;
        private System.Windows.Forms.Button radioButtonOffCal;
        private System.Windows.Forms.Button radioButtonOnWord;
        private System.Windows.Forms.Button radioButtonOnNotepad;
        private System.Windows.Forms.Button radioButtonOnPaint;
        private System.Windows.Forms.Button radioButtonOnExcel;
        private System.Windows.Forms.Button radioButtonOffWord;
        private System.Windows.Forms.Button radioButtonOffNotepad;
        private System.Windows.Forms.Button radioButtonOffPaint;
        private System.Windows.Forms.Button radioButtonOffExcel;
        private System.Windows.Forms.RadioButton radioButtonIdle;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonRealTime;
    }
}

