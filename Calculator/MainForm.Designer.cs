namespace Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.changeSingBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.displayWindow = new System.Windows.Forms.TextBox();
            this.outputField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.copyDisplayBtn = new System.Windows.Forms.Button();
            this.copyOutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(134, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(235, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(33, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(134, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(235, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(33, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(134, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(235, 211);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button0.Location = new System.Drawing.Point(134, 373);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 40);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // changeSingBtn
            // 
            this.changeSingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSingBtn.Location = new System.Drawing.Point(33, 373);
            this.changeSingBtn.Name = "changeSingBtn";
            this.changeSingBtn.Size = new System.Drawing.Size(60, 40);
            this.changeSingBtn.TabIndex = 10;
            this.changeSingBtn.Text = " ±";
            this.changeSingBtn.UseVisualStyleBackColor = true;
            this.changeSingBtn.Click += new System.EventHandler(this.changeSingBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotBtn.Location = new System.Drawing.Point(235, 373);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(60, 40);
            this.dotBtn.TabIndex = 11;
            this.dotBtn.Text = ",";
            this.dotBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(235, 149);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 40);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.calculateBtn.Location = new System.Drawing.Point(336, 149);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(60, 40);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "=";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.plusBtn.Location = new System.Drawing.Point(336, 373);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(60, 40);
            this.plusBtn.TabIndex = 14;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.operationBtn_click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.minusBtn.Location = new System.Drawing.Point(336, 319);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(60, 40);
            this.minusBtn.TabIndex = 15;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.operationBtn_click);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.multiplicationBtn.Location = new System.Drawing.Point(336, 265);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(60, 40);
            this.multiplicationBtn.TabIndex = 16;
            this.multiplicationBtn.Text = "*";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.operationBtn_click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.divisionBtn.Location = new System.Drawing.Point(336, 211);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(60, 40);
            this.divisionBtn.TabIndex = 17;
            this.divisionBtn.Text = "÷";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.operationBtn_click);
            // 
            // displayWindow
            // 
            this.displayWindow.BackColor = System.Drawing.Color.White;
            this.displayWindow.Enabled = false;
            this.displayWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.displayWindow.ForeColor = System.Drawing.Color.Black;
            this.displayWindow.Location = new System.Drawing.Point(33, 32);
            this.displayWindow.Name = "displayWindow";
            this.displayWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayWindow.Size = new System.Drawing.Size(363, 29);
            this.displayWindow.TabIndex = 18;
            this.displayWindow.Text = "0";
            this.displayWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outputField
            // 
            this.outputField.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.outputField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputField.Enabled = false;
            this.outputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.outputField.Location = new System.Drawing.Point(14, 15);
            this.outputField.Multiline = true;
            this.outputField.Name = "outputField";
            this.outputField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputField.Size = new System.Drawing.Size(208, 264);
            this.outputField.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.copyOutBtn);
            this.panel1.Controls.Add(this.outputField);
            this.panel1.Location = new System.Drawing.Point(441, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 327);
            this.panel1.TabIndex = 20;
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspaceBtn.Location = new System.Drawing.Point(134, 150);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(60, 40);
            this.backspaceBtn.TabIndex = 12;
            this.backspaceBtn.Text = "⌫";
            this.backspaceBtn.UseVisualStyleBackColor = true;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // copyDisplayBtn
            // 
            this.copyDisplayBtn.BackgroundImage = global::Calculator.Properties.Resources.copy_icon;
            this.copyDisplayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyDisplayBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.copyDisplayBtn.FlatAppearance.BorderSize = 0;
            this.copyDisplayBtn.Location = new System.Drawing.Point(402, 31);
            this.copyDisplayBtn.Name = "copyDisplayBtn";
            this.copyDisplayBtn.Size = new System.Drawing.Size(30, 30);
            this.copyDisplayBtn.TabIndex = 21;
            this.copyDisplayBtn.UseVisualStyleBackColor = true;
            this.copyDisplayBtn.Click += new System.EventHandler(this.copyDisplayBtn_Click);
            // 
            // copyOutBtn
            // 
            this.copyOutBtn.BackgroundImage = global::Calculator.Properties.Resources.copy_icon2;
            this.copyOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyOutBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.copyOutBtn.FlatAppearance.BorderSize = 0;
            this.copyOutBtn.Location = new System.Drawing.Point(205, 294);
            this.copyOutBtn.Name = "copyOutBtn";
            this.copyOutBtn.Size = new System.Drawing.Size(30, 30);
            this.copyOutBtn.TabIndex = 21;
            this.copyOutBtn.UseVisualStyleBackColor = true;
            this.copyOutBtn.Click += new System.EventHandler(this.copyOutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 431);
            this.Controls.Add(this.copyDisplayBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayWindow);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.changeSingBtn);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button changeSingBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.TextBox displayWindow;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button copyOutBtn;
        private System.Windows.Forms.Button copyDisplayBtn;
    }
}

