namespace _03022017
{
    partial class TimerWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.buttonTimerPause = new System.Windows.Forms.Button();
            this.buttonTimerReset = new System.Windows.Forms.Button();
            this.fastTimer = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerDif = new System.Windows.Forms.DateTimePicker();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelLeftDays = new System.Windows.Forms.Label();
            this.labelLeftHours = new System.Windows.Forms.Label();
            this.labelLeftMinutes = new System.Windows.Forms.Label();
            this.labelLeftSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(75, 13);
            this.labelCurrentDate.TabIndex = 0;
            this.labelCurrentDate.Text = "DateTimeNow";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(18, 36);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(251, 46);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "0:00:00:0000";
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.Location = new System.Drawing.Point(91, 103);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerStart.TabIndex = 2;
            this.buttonTimerStart.Text = "Start";
            this.buttonTimerStart.UseVisualStyleBackColor = true;
            this.buttonTimerStart.Click += new System.EventHandler(this.OnButtonTimerStartClick);
            // 
            // buttonTimerPause
            // 
            this.buttonTimerPause.Location = new System.Drawing.Point(91, 132);
            this.buttonTimerPause.Name = "buttonTimerPause";
            this.buttonTimerPause.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerPause.TabIndex = 3;
            this.buttonTimerPause.Text = "Pause";
            this.buttonTimerPause.UseVisualStyleBackColor = true;
            this.buttonTimerPause.Click += new System.EventHandler(this.OnButtonTimerPauseClick);
            // 
            // buttonTimerReset
            // 
            this.buttonTimerReset.Location = new System.Drawing.Point(91, 161);
            this.buttonTimerReset.Name = "buttonTimerReset";
            this.buttonTimerReset.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerReset.TabIndex = 4;
            this.buttonTimerReset.Text = "Reset";
            this.buttonTimerReset.UseVisualStyleBackColor = true;
            this.buttonTimerReset.Click += new System.EventHandler(this.OnButtonTimerResetClick);
            // 
            // fastTimer
            // 
            this.fastTimer.Interval = 1;
            this.fastTimer.Tick += new System.EventHandler(this.OnFastTimerTick);
            // 
            // dateTimePickerDif
            // 
            this.dateTimePickerDif.Location = new System.Drawing.Point(37, 207);
            this.dateTimePickerDif.Name = "dateTimePickerDif";
            this.dateTimePickerDif.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDif.TabIndex = 7;
            this.dateTimePickerDif.ValueChanged += new System.EventHandler(this.OnDateTimePickerValueChanged);
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeft.Location = new System.Drawing.Point(96, 243);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(91, 20);
            this.labelLeft.TabIndex = 8;
            this.labelLeft.Text = "Осталось :";
            // 
            // labelLeftDays
            // 
            this.labelLeftDays.AutoSize = true;
            this.labelLeftDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftDays.Location = new System.Drawing.Point(37, 269);
            this.labelLeftDays.Name = "labelLeftDays";
            this.labelLeftDays.Size = new System.Drawing.Size(68, 16);
            this.labelLeftDays.TabIndex = 9;
            this.labelLeftDays.Text = "дней (-я) :";
            // 
            // labelLeftHours
            // 
            this.labelLeftHours.AutoSize = true;
            this.labelLeftHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftHours.Location = new System.Drawing.Point(37, 297);
            this.labelLeftHours.Name = "labelLeftHours";
            this.labelLeftHours.Size = new System.Drawing.Size(76, 16);
            this.labelLeftHours.TabIndex = 10;
            this.labelLeftHours.Text = "часов (-а) :";
            // 
            // labelLeftMinutes
            // 
            this.labelLeftMinutes.AutoSize = true;
            this.labelLeftMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftMinutes.Location = new System.Drawing.Point(37, 328);
            this.labelLeftMinutes.Name = "labelLeftMinutes";
            this.labelLeftMinutes.Size = new System.Drawing.Size(78, 16);
            this.labelLeftMinutes.TabIndex = 11;
            this.labelLeftMinutes.Text = "минут (-ы) :";
            // 
            // labelLeftSeconds
            // 
            this.labelLeftSeconds.AutoSize = true;
            this.labelLeftSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftSeconds.Location = new System.Drawing.Point(37, 358);
            this.labelLeftSeconds.Name = "labelLeftSeconds";
            this.labelLeftSeconds.Size = new System.Drawing.Size(84, 16);
            this.labelLeftSeconds.TabIndex = 12;
            this.labelLeftSeconds.Text = "секунд (-ы) :";
            // 
            // TimerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 397);
            this.Controls.Add(this.labelLeftSeconds);
            this.Controls.Add(this.labelLeftMinutes);
            this.Controls.Add(this.labelLeftHours);
            this.Controls.Add(this.labelLeftDays);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.dateTimePickerDif);
            this.Controls.Add(this.buttonTimerReset);
            this.Controls.Add(this.buttonTimerPause);
            this.Controls.Add(this.buttonTimerStart);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelCurrentDate);
            this.Name = "TimerWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Button buttonTimerPause;
        private System.Windows.Forms.Button buttonTimerReset;
        private System.Windows.Forms.Timer fastTimer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDif;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelLeftDays;
        private System.Windows.Forms.Label labelLeftHours;
        private System.Windows.Forms.Label labelLeftMinutes;
        private System.Windows.Forms.Label labelLeftSeconds;
    }
}

