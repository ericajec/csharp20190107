﻿namespace WindowsTest4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLoopCount = new System.Windows.Forms.TextBox();
            this.prb1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "반복횟수";
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(64, 157);
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(447, 45);
            this.trb1.TabIndex = 1;
            this.trb1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(298, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLoopCount
            // 
            this.txtLoopCount.Location = new System.Drawing.Point(140, 94);
            this.txtLoopCount.Name = "txtLoopCount";
            this.txtLoopCount.Size = new System.Drawing.Size(142, 21);
            this.txtLoopCount.TabIndex = 3;
            this.txtLoopCount.Text = "10000";
            // 
            // prb1
            // 
            this.prb1.Location = new System.Drawing.Point(64, 246);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(447, 23);
            this.prb1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prb1);
            this.Controls.Add(this.txtLoopCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TrackBar, ProgressBar 컨트롤 테스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLoopCount;
        private System.Windows.Forms.ProgressBar prb1;
    }
}

