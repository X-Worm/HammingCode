namespace Laba2_TheoryOfInformation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadMessage = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.BinaryRepresantation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoBits = new System.Windows.Forms.TextBox();
            this.ControlBits = new System.Windows.Forms.TextBox();
            this.AllBits = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HammingCodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WrongBitBox = new System.Windows.Forms.TextBox();
            this.WrongCalculateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HammingCodeWrongBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.WrongBitPosition = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DecodingMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMessage
            // 
            this.LoadMessage.Location = new System.Drawing.Point(13, 13);
            this.LoadMessage.Name = "LoadMessage";
            this.LoadMessage.Size = new System.Drawing.Size(231, 42);
            this.LoadMessage.TabIndex = 0;
            this.LoadMessage.Text = "Завантажити повідомлення";
            this.LoadMessage.UseVisualStyleBackColor = true;
            this.LoadMessage.Click += new System.EventHandler(this.LoadMessage_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Enabled = false;
            this.TextMessage.Location = new System.Drawing.Point(250, 35);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(501, 20);
            this.TextMessage.TabIndex = 1;
            // 
            // BinaryRepresantation
            // 
            this.BinaryRepresantation.Enabled = false;
            this.BinaryRepresantation.Location = new System.Drawing.Point(12, 88);
            this.BinaryRepresantation.Name = "BinaryRepresantation";
            this.BinaryRepresantation.Size = new System.Drawing.Size(739, 20);
            this.BinaryRepresantation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Двійкові дані";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Інйормаційні біти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Контрольні біти";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Загалом";
            // 
            // InfoBits
            // 
            this.InfoBits.Enabled = false;
            this.InfoBits.Location = new System.Drawing.Point(12, 39);
            this.InfoBits.Name = "InfoBits";
            this.InfoBits.Size = new System.Drawing.Size(238, 20);
            this.InfoBits.TabIndex = 8;
            // 
            // ControlBits
            // 
            this.ControlBits.Enabled = false;
            this.ControlBits.Location = new System.Drawing.Point(256, 39);
            this.ControlBits.Name = "ControlBits";
            this.ControlBits.Size = new System.Drawing.Size(236, 20);
            this.ControlBits.TabIndex = 9;
            // 
            // AllBits
            // 
            this.AllBits.Enabled = false;
            this.AllBits.Location = new System.Drawing.Point(498, 39);
            this.AllBits.Name = "AllBits";
            this.AllBits.Size = new System.Drawing.Size(221, 20);
            this.AllBits.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AllBits);
            this.panel1.Controls.Add(this.InfoBits);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ControlBits);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 74);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(264, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Розрахунок контрольних бітів";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // HammingCodeBox
            // 
            this.HammingCodeBox.Enabled = false;
            this.HammingCodeBox.Location = new System.Drawing.Point(69, 426);
            this.HammingCodeBox.Name = "HammingCodeBox";
            this.HammingCodeBox.Size = new System.Drawing.Size(620, 20);
            this.HammingCodeBox.TabIndex = 14;
            this.HammingCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(326, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Код Хемінга";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(69, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Позиція неправильного біту";
            // 
            // WrongBitBox
            // 
            this.WrongBitBox.Enabled = false;
            this.WrongBitBox.Location = new System.Drawing.Point(330, 467);
            this.WrongBitBox.Name = "WrongBitBox";
            this.WrongBitBox.Size = new System.Drawing.Size(359, 20);
            this.WrongBitBox.TabIndex = 17;
            // 
            // WrongCalculateButton
            // 
            this.WrongCalculateButton.Location = new System.Drawing.Point(69, 503);
            this.WrongCalculateButton.Name = "WrongCalculateButton";
            this.WrongCalculateButton.Size = new System.Drawing.Size(245, 35);
            this.WrongCalculateButton.TabIndex = 18;
            this.WrongCalculateButton.Text = "Внести помилку";
            this.WrongCalculateButton.UseVisualStyleBackColor = true;
            this.WrongCalculateButton.Click += new System.EventHandler(this.WrongCalculateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(409, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Виправлення помилки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(234, 551);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(303, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Код Хемінга з внесеною помилкою";
            // 
            // HammingCodeWrongBox
            // 
            this.HammingCodeWrongBox.Enabled = false;
            this.HammingCodeWrongBox.Location = new System.Drawing.Point(69, 577);
            this.HammingCodeWrongBox.Name = "HammingCodeWrongBox";
            this.HammingCodeWrongBox.Size = new System.Drawing.Size(620, 20);
            this.HammingCodeWrongBox.TabIndex = 21;
            this.HammingCodeWrongBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Позиція помилкового біту , розрахованого за кодом Хемінга";
            // 
            // WrongBitPosition
            // 
            this.WrongBitPosition.Enabled = false;
            this.WrongBitPosition.Location = new System.Drawing.Point(388, 608);
            this.WrongBitPosition.Name = "WrongBitPosition";
            this.WrongBitPosition.Size = new System.Drawing.Size(301, 20);
            this.WrongBitPosition.TabIndex = 23;
            this.WrongBitPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 643);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Декодування повідомлення";
            // 
            // DecodingMessage
            // 
            this.DecodingMessage.Enabled = false;
            this.DecodingMessage.Location = new System.Drawing.Point(220, 640);
            this.DecodingMessage.Name = "DecodingMessage";
            this.DecodingMessage.Size = new System.Drawing.Size(469, 20);
            this.DecodingMessage.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(764, 677);
            this.Controls.Add(this.DecodingMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.WrongBitPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HammingCodeWrongBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WrongCalculateButton);
            this.Controls.Add(this.WrongBitBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HammingCodeBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BinaryRepresantation);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.LoadMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadMessage;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.TextBox BinaryRepresantation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InfoBits;
        private System.Windows.Forms.TextBox ControlBits;
        private System.Windows.Forms.TextBox AllBits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox HammingCodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox WrongBitBox;
        private System.Windows.Forms.Button WrongCalculateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HammingCodeWrongBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox WrongBitPosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DecodingMessage;
    }
}

