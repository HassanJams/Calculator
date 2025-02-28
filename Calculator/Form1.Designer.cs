namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            equalBtn = new Button();
            decimalBtn = new Button();
            num0Btn = new Button();
            signBtn = new Button();
            addBtn = new Button();
            num1Btn = new Button();
            num2Btn = new Button();
            num3Btn = new Button();
            subtractBtn = new Button();
            num6Btn = new Button();
            num5Btn = new Button();
            num4Btn = new Button();
            multiplyBtn = new Button();
            num9Btn = new Button();
            num8Btn = new Button();
            num7Btn = new Button();
            divideBtn = new Button();
            backSpaceBtn = new Button();
            clearBtn = new Button();
            clearEntryBtn = new Button();
            display = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(equalBtn, 3, 5);
            tableLayoutPanel1.Controls.Add(decimalBtn, 2, 5);
            tableLayoutPanel1.Controls.Add(num0Btn, 1, 5);
            tableLayoutPanel1.Controls.Add(signBtn, 0, 5);
            tableLayoutPanel1.Controls.Add(addBtn, 3, 4);
            tableLayoutPanel1.Controls.Add(num1Btn, 2, 4);
            tableLayoutPanel1.Controls.Add(num2Btn, 1, 4);
            tableLayoutPanel1.Controls.Add(num3Btn, 0, 4);
            tableLayoutPanel1.Controls.Add(subtractBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(num6Btn, 2, 3);
            tableLayoutPanel1.Controls.Add(num5Btn, 1, 3);
            tableLayoutPanel1.Controls.Add(num4Btn, 0, 3);
            tableLayoutPanel1.Controls.Add(multiplyBtn, 3, 2);
            tableLayoutPanel1.Controls.Add(num9Btn, 2, 2);
            tableLayoutPanel1.Controls.Add(num8Btn, 1, 2);
            tableLayoutPanel1.Controls.Add(num7Btn, 0, 2);
            tableLayoutPanel1.Controls.Add(divideBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(backSpaceBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(clearBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(clearEntryBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(display, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(494, 489);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // equalBtn
            // 
            equalBtn.Dock = DockStyle.Fill;
            equalBtn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equalBtn.Location = new Point(372, 408);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(119, 78);
            equalBtn.TabIndex = 20;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = true;
            equalBtn.Click += equalBtn_Click;
            // 
            // decimalBtn
            // 
            decimalBtn.Dock = DockStyle.Fill;
            decimalBtn.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decimalBtn.Location = new Point(249, 408);
            decimalBtn.Name = "decimalBtn";
            decimalBtn.Size = new Size(117, 78);
            decimalBtn.TabIndex = 19;
            decimalBtn.Text = ".";
            decimalBtn.UseVisualStyleBackColor = true;
            decimalBtn.Click += decimalBtn_Click;
            // 
            // num0Btn
            // 
            num0Btn.Dock = DockStyle.Fill;
            num0Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num0Btn.Location = new Point(126, 408);
            num0Btn.Name = "num0Btn";
            num0Btn.Size = new Size(117, 78);
            num0Btn.TabIndex = 18;
            num0Btn.Text = "0";
            num0Btn.UseVisualStyleBackColor = true;
            num0Btn.Click += numBtn_Click;
            // 
            // signBtn
            // 
            signBtn.Dock = DockStyle.Fill;
            signBtn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signBtn.Location = new Point(3, 408);
            signBtn.Name = "signBtn";
            signBtn.Size = new Size(117, 78);
            signBtn.TabIndex = 17;
            signBtn.Text = "+/-";
            signBtn.UseVisualStyleBackColor = true;
            signBtn.Click += signBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Fill;
            addBtn.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(372, 327);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(119, 75);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += mathOperationBtn_Click;
            // 
            // num1Btn
            // 
            num1Btn.Dock = DockStyle.Fill;
            num1Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1Btn.Location = new Point(249, 327);
            num1Btn.Name = "num1Btn";
            num1Btn.Size = new Size(117, 75);
            num1Btn.TabIndex = 15;
            num1Btn.Text = "1";
            num1Btn.UseVisualStyleBackColor = true;
            num1Btn.Click += numBtn_Click;
            // 
            // num2Btn
            // 
            num2Btn.Dock = DockStyle.Fill;
            num2Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2Btn.Location = new Point(126, 327);
            num2Btn.Name = "num2Btn";
            num2Btn.Size = new Size(117, 75);
            num2Btn.TabIndex = 14;
            num2Btn.Text = "2";
            num2Btn.UseVisualStyleBackColor = true;
            num2Btn.Click += numBtn_Click;
            // 
            // num3Btn
            // 
            num3Btn.Dock = DockStyle.Fill;
            num3Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num3Btn.Location = new Point(3, 327);
            num3Btn.Name = "num3Btn";
            num3Btn.Size = new Size(117, 75);
            num3Btn.TabIndex = 13;
            num3Btn.Text = "3";
            num3Btn.UseVisualStyleBackColor = true;
            num3Btn.Click += numBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Dock = DockStyle.Fill;
            subtractBtn.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtractBtn.Location = new Point(372, 246);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(119, 75);
            subtractBtn.TabIndex = 12;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += mathOperationBtn_Click;
            // 
            // num6Btn
            // 
            num6Btn.Dock = DockStyle.Fill;
            num6Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num6Btn.Location = new Point(249, 246);
            num6Btn.Name = "num6Btn";
            num6Btn.Size = new Size(117, 75);
            num6Btn.TabIndex = 11;
            num6Btn.Text = "6";
            num6Btn.UseVisualStyleBackColor = true;
            num6Btn.Click += numBtn_Click;
            // 
            // num5Btn
            // 
            num5Btn.Dock = DockStyle.Fill;
            num5Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num5Btn.Location = new Point(126, 246);
            num5Btn.Name = "num5Btn";
            num5Btn.Size = new Size(117, 75);
            num5Btn.TabIndex = 10;
            num5Btn.Text = "5";
            num5Btn.UseVisualStyleBackColor = true;
            num5Btn.Click += numBtn_Click;
            // 
            // num4Btn
            // 
            num4Btn.Dock = DockStyle.Fill;
            num4Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num4Btn.Location = new Point(3, 246);
            num4Btn.Name = "num4Btn";
            num4Btn.Size = new Size(117, 75);
            num4Btn.TabIndex = 9;
            num4Btn.Text = "4";
            num4Btn.UseVisualStyleBackColor = true;
            num4Btn.Click += numBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Dock = DockStyle.Fill;
            multiplyBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplyBtn.Location = new Point(372, 165);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(119, 75);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "X";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += mathOperationBtn_Click;
            // 
            // num9Btn
            // 
            num9Btn.Dock = DockStyle.Fill;
            num9Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num9Btn.Location = new Point(249, 165);
            num9Btn.Name = "num9Btn";
            num9Btn.Size = new Size(117, 75);
            num9Btn.TabIndex = 7;
            num9Btn.Text = "9";
            num9Btn.UseVisualStyleBackColor = true;
            num9Btn.Click += numBtn_Click;
            // 
            // num8Btn
            // 
            num8Btn.Dock = DockStyle.Fill;
            num8Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num8Btn.Location = new Point(126, 165);
            num8Btn.Name = "num8Btn";
            num8Btn.Size = new Size(117, 75);
            num8Btn.TabIndex = 6;
            num8Btn.Text = "8";
            num8Btn.UseVisualStyleBackColor = true;
            num8Btn.Click += numBtn_Click;
            // 
            // num7Btn
            // 
            num7Btn.Dock = DockStyle.Fill;
            num7Btn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num7Btn.Location = new Point(3, 165);
            num7Btn.Name = "num7Btn";
            num7Btn.Size = new Size(117, 75);
            num7Btn.TabIndex = 5;
            num7Btn.Text = "7";
            num7Btn.UseVisualStyleBackColor = true;
            num7Btn.Click += numBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.Dock = DockStyle.Fill;
            divideBtn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divideBtn.Location = new Point(372, 84);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(119, 75);
            divideBtn.TabIndex = 4;
            divideBtn.Text = "÷";
            divideBtn.UseVisualStyleBackColor = true;
            divideBtn.Click += mathOperationBtn_Click;
            // 
            // backSpaceBtn
            // 
            backSpaceBtn.Dock = DockStyle.Fill;
            backSpaceBtn.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backSpaceBtn.Location = new Point(249, 84);
            backSpaceBtn.Name = "backSpaceBtn";
            backSpaceBtn.Size = new Size(117, 75);
            backSpaceBtn.TabIndex = 3;
            backSpaceBtn.Text = "⌫";
            backSpaceBtn.UseVisualStyleBackColor = true;
            backSpaceBtn.Click += backSpaceBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(126, 84);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(117, 75);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.Dock = DockStyle.Fill;
            clearEntryBtn.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearEntryBtn.Location = new Point(3, 84);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(117, 75);
            clearEntryBtn.TabIndex = 0;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = true;
            clearEntryBtn.Click += clearEntryBtn_Click;
            // 
            // display
            // 
            tableLayoutPanel1.SetColumnSpan(display, 4);
            display.Dock = DockStyle.Fill;
            display.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.Location = new Point(5, 8);
            display.Margin = new Padding(5, 8, 5, 3);
            display.Name = "display";
            display.Size = new Size(484, 93);
            display.TabIndex = 1;
            display.Text = "0";
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 489);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(520, 560);
            Name = "Form1";
            ShowIcon = false;
            Text = "TINFO-200 Calculator ";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button clearEntryBtn;
        private TextBox display;
        private Button equalBtn;
        private Button decimalBtn;
        private Button num0Btn;
        private Button signBtn;
        private Button addBtn;
        private Button num1Btn;
        private Button num2Btn;
        private Button num3Btn;
        private Button subtractBtn;
        private Button num6Btn;
        private Button num5Btn;
        private Button num4Btn;
        private Button multiplyBtn;
        private Button num9Btn;
        private Button num8Btn;
        private Button num7Btn;
        private Button divideBtn;
        private Button backSpaceBtn;
        private Button clearBtn;
    }
}
