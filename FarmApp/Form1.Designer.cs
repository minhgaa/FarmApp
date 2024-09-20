namespace FarmApp
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
            this.txtBo = new System.Windows.Forms.TextBox();
            this.txtCuu = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.listBoxTiengKeu = new System.Windows.Forms.ListBox();
            this.lblTongSua = new System.Windows.Forms.Label();
            this.lblTongGiaSuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBo
            // 
            this.txtBo.Location = new System.Drawing.Point(59, 87);
            this.txtBo.Name = "txtBo";
            this.txtBo.Size = new System.Drawing.Size(281, 22);
            this.txtBo.TabIndex = 0;
            // 
            // txtCuu
            // 
            this.txtCuu.Location = new System.Drawing.Point(59, 163);
            this.txtCuu.Name = "txtCuu";
            this.txtCuu.Size = new System.Drawing.Size(281, 22);
            this.txtCuu.TabIndex = 1;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(59, 243);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(281, 22);
            this.txtDe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập số lượng bò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập số lượng cừu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập số lượng dê";
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTinhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTinhToan.Location = new System.Drawing.Point(60, 306);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(280, 66);
            this.btnTinhToan.TabIndex = 6;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = false;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // listBoxTiengKeu
            // 
            this.listBoxTiengKeu.FormattingEnabled = true;
            this.listBoxTiengKeu.ItemHeight = 16;
            this.listBoxTiengKeu.Location = new System.Drawing.Point(450, 37);
            this.listBoxTiengKeu.Name = "listBoxTiengKeu";
            this.listBoxTiengKeu.Size = new System.Drawing.Size(267, 148);
            this.listBoxTiengKeu.TabIndex = 7;
            // 
            // lblTongSua
            // 
            this.lblTongSua.AutoSize = true;
            this.lblTongSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSua.Location = new System.Drawing.Point(447, 220);
            this.lblTongSua.Name = "lblTongSua";
            this.lblTongSua.Size = new System.Drawing.Size(191, 25);
            this.lblTongSua.TabIndex = 8;
            this.lblTongSua.Text = "Tổng số lượng sữa";
            // 
            // lblTongGiaSuc
            // 
            this.lblTongGiaSuc.AutoSize = true;
            this.lblTongGiaSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGiaSuc.Location = new System.Drawing.Point(447, 287);
            this.lblTongGiaSuc.Name = "lblTongGiaSuc";
            this.lblTongGiaSuc.Size = new System.Drawing.Size(166, 25);
            this.lblTongGiaSuc.TabIndex = 9;
            this.lblTongGiaSuc.Text = "Tổng số gia súc";
            this.lblTongGiaSuc.Click += new System.EventHandler(this.lblTongGiaSuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongGiaSuc);
            this.Controls.Add(this.lblTongSua);
            this.Controls.Add(this.listBoxTiengKeu);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.txtCuu);
            this.Controls.Add(this.txtBo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBo;
        private System.Windows.Forms.TextBox txtCuu;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.ListBox listBoxTiengKeu;
        private System.Windows.Forms.Label lblTongSua;
        private System.Windows.Forms.Label lblTongGiaSuc;
    }
}

