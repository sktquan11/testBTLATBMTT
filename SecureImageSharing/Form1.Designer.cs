using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms; // Dòng này sẽ giúp hết lỗi SuspendLayout

namespace SecureImageSharing
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picProcessed = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnGanWatermark = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuuAnh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(12, 150);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(288, 288);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picProcessed
            // 
            this.picProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProcessed.Location = new System.Drawing.Point(492, 150);
            this.picProcessed.Name = "picProcessed";
            this.picProcessed.Size = new System.Drawing.Size(276, 288);
            this.picProcessed.TabIndex = 1;
            this.picProcessed.TabStop = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(331, 150);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(139, 23);
            this.btnChonAnh.TabIndex = 2;
            this.btnChonAnh.Text = "Chọn ảnh gốc";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnGanWatermark
            // 
            this.btnGanWatermark.Location = new System.Drawing.Point(331, 190);
            this.btnGanWatermark.Name = "btnGanWatermark";
            this.btnGanWatermark.Size = new System.Drawing.Size(139, 23);
            this.btnGanWatermark.TabIndex = 3;
            this.btnGanWatermark.Text = "Gắn Thủy Vân";
            this.btnGanWatermark.UseVisualStyleBackColor = true;
            this.btnGanWatermark.Click += new System.EventHandler(this.btnGanWatermark_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(331, 231);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(139, 23);
            this.btnGiaiMa.TabIndex = 4;
            this.btnGiaiMa.Text = "Giải mã / Kiểm tra";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(346, 307);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 96);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ảnh trước khi xử lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ảnh sau khi xử lý";
            // 
            // btnLuuAnh
            // 
            this.btnLuuAnh.Location = new System.Drawing.Point(331, 260);
            this.btnLuuAnh.Name = "btnLuuAnh";
            this.btnLuuAnh.Size = new System.Drawing.Size(139, 23);
            this.btnLuuAnh.TabIndex = 8;
            this.btnLuuAnh.Text = "Lưu ảnh đã gắn";
            this.btnLuuAnh.UseVisualStyleBackColor = true;
            this.btnLuuAnh.Click += new System.EventHandler(this.btnLuuAnh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuuAnh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnGanWatermark);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.picProcessed);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picProcessed;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnGanWatermark;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button btnLuuAnh;
    }
}

