namespace HomeTask7
{
    partial class Doubler
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblInfoNumber = new System.Windows.Forms.Label();
            this.lblInfoTarget = new System.Windows.Forms.Label();
            this.lblInfoStep = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(158, 12);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(158, 50);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(82, 12);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(23, 25);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "1";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(158, 119);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTarget.Location = new System.Drawing.Point(82, 50);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(23, 25);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "0";
            // 
            // lblInfoNumber
            // 
            this.lblInfoNumber.AutoSize = true;
            this.lblInfoNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoNumber.Location = new System.Drawing.Point(12, 12);
            this.lblInfoNumber.Name = "lblInfoNumber";
            this.lblInfoNumber.Size = new System.Drawing.Size(69, 25);
            this.lblInfoNumber.TabIndex = 6;
            this.lblInfoNumber.Text = "Число";
            // 
            // lblInfoTarget
            // 
            this.lblInfoTarget.AutoSize = true;
            this.lblInfoTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoTarget.Location = new System.Drawing.Point(12, 46);
            this.lblInfoTarget.Name = "lblInfoTarget";
            this.lblInfoTarget.Size = new System.Drawing.Size(59, 25);
            this.lblInfoTarget.TabIndex = 7;
            this.lblInfoTarget.Text = "Цель";
            // 
            // lblInfoStep
            // 
            this.lblInfoStep.AutoSize = true;
            this.lblInfoStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoStep.Location = new System.Drawing.Point(12, 82);
            this.lblInfoStep.Name = "lblInfoStep";
            this.lblInfoStep.Size = new System.Drawing.Size(57, 25);
            this.lblInfoStep.TabIndex = 8;
            this.lblInfoStep.Text = "Шаги";
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep.Location = new System.Drawing.Point(82, 82);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(23, 25);
            this.lblStep.TabIndex = 9;
            this.lblStep.Text = "0";
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 154);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblInfoStep);
            this.Controls.Add(this.lblInfoTarget);
            this.Controls.Add(this.lblInfoNumber);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Doubler";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblInfoNumber;
        private System.Windows.Forms.Label lblInfoTarget;
        private System.Windows.Forms.Label lblInfoStep;
        private System.Windows.Forms.Label lblStep;
    }
}

