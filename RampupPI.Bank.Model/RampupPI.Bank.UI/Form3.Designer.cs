namespace RampupPI.Bank.UI
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItokenCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNAccountCustomer = new System.Windows.Forms.TextBox();
            this.txtTypeAccountCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalanceCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.BtnW = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textAnotherAccount = new System.Windows.Forms.TextBox();
            this.btnOkTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Acesso:";
            // 
            // txtItokenCustomer
            // 
            this.txtItokenCustomer.Location = new System.Drawing.Point(114, 15);
            this.txtItokenCustomer.Name = "txtItokenCustomer";
            this.txtItokenCustomer.Size = new System.Drawing.Size(48, 20);
            this.txtItokenCustomer.TabIndex = 1;
            this.txtItokenCustomer.TextChanged += new System.EventHandler(this.txtItokenCustomer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(62, 74);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(113, 20);
            this.txtNameCustomer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº Conta";
            // 
            // txtNAccountCustomer
            // 
            this.txtNAccountCustomer.Location = new System.Drawing.Point(413, 76);
            this.txtNAccountCustomer.Name = "txtNAccountCustomer";
            this.txtNAccountCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtNAccountCustomer.TabIndex = 7;
            // 
            // txtTypeAccountCustomer
            // 
            this.txtTypeAccountCustomer.Location = new System.Drawing.Point(241, 76);
            this.txtTypeAccountCustomer.Name = "txtTypeAccountCustomer";
            this.txtTypeAccountCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtTypeAccountCustomer.TabIndex = 8;
            this.txtTypeAccountCustomer.TextChanged += new System.EventHandler(this.txtTypeAccountCustomer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo";
            // 
            // txtBalanceCustomer
            // 
            this.txtBalanceCustomer.Location = new System.Drawing.Point(62, 130);
            this.txtBalanceCustomer.Name = "txtBalanceCustomer";
            this.txtBalanceCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtBalanceCustomer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(62, 197);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 12;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(16, 246);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(100, 63);
            this.btnD.TabIndex = 13;
            this.btnD.Text = "Deposito";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // BtnW
            // 
            this.BtnW.Location = new System.Drawing.Point(154, 246);
            this.BtnW.Name = "BtnW";
            this.BtnW.Size = new System.Drawing.Size(100, 63);
            this.BtnW.TabIndex = 14;
            this.BtnW.Text = "Saque";
            this.BtnW.UseVisualStyleBackColor = true;
            this.BtnW.Click += new System.EventHandler(this.BtnW_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Encerrar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(298, 246);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 63);
            this.btnTransfer.TabIndex = 16;
            this.btnTransfer.Text = "Transferência";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "NºConta:";
            // 
            // textAnotherAccount
            // 
            this.textAnotherAccount.Location = new System.Drawing.Point(254, 197);
            this.textAnotherAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAnotherAccount.Name = "textAnotherAccount";
            this.textAnotherAccount.Size = new System.Drawing.Size(99, 20);
            this.textAnotherAccount.TabIndex = 18;
            // 
            // btnOkTransfer
            // 
            this.btnOkTransfer.Location = new System.Drawing.Point(376, 195);
            this.btnOkTransfer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOkTransfer.Name = "btnOkTransfer";
            this.btnOkTransfer.Size = new System.Drawing.Size(56, 19);
            this.btnOkTransfer.TabIndex = 19;
            this.btnOkTransfer.Text = "Efetuar";
            this.btnOkTransfer.UseVisualStyleBackColor = true;
            this.btnOkTransfer.Click += new System.EventHandler(this.btnOkTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 195);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 19);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOkTransfer);
            this.Controls.Add(this.textAnotherAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnW);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBalanceCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTypeAccountCustomer);
            this.Controls.Add(this.txtNAccountCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItokenCustomer);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "NºConta:";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItokenCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNAccountCustomer;
        private System.Windows.Forms.TextBox txtTypeAccountCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalanceCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button BtnW;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAnotherAccount;
        private System.Windows.Forms.Button btnOkTransfer;
        private System.Windows.Forms.Button btnCancel;
    }
}