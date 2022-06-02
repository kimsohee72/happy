namespace Teamproject1
{
    partial class loginform2
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
            this.loginformbutton = new System.Windows.Forms.Button();
            this.idinput = new System.Windows.Forms.TextBox();
            this.pwdinput = new System.Windows.Forms.TextBox();
            this.loginformcopywrite = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("카페24 써라운드", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(95, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginformbutton
            // 
            this.loginformbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginformbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginformbutton.Location = new System.Drawing.Point(15, 14);
            this.loginformbutton.Margin = new System.Windows.Forms.Padding(4);
            this.loginformbutton.Name = "loginformbutton";
            this.loginformbutton.Size = new System.Drawing.Size(72, 66);
            this.loginformbutton.TabIndex = 1;
            this.loginformbutton.Text = "<";
            this.loginformbutton.UseVisualStyleBackColor = false;
            this.loginformbutton.Click += new System.EventHandler(this.loginformbutton_Click);
            // 
            // idinput
            // 
            this.idinput.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idinput.Location = new System.Drawing.Point(15, 364);
            this.idinput.Margin = new System.Windows.Forms.Padding(4);
            this.idinput.Name = "idinput";
            this.idinput.Size = new System.Drawing.Size(686, 29);
            this.idinput.TabIndex = 3;
            this.idinput.Text = "아이디 또는 이메일을 입력하세요.";
            this.idinput.Click += new System.EventHandler(this.idinput_Click);
            // 
            // pwdinput
            // 
            this.pwdinput.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdinput.Location = new System.Drawing.Point(15, 426);
            this.pwdinput.Margin = new System.Windows.Forms.Padding(4);
            this.pwdinput.Name = "pwdinput";
            this.pwdinput.Size = new System.Drawing.Size(686, 29);
            this.pwdinput.TabIndex = 4;
            this.pwdinput.Text = "비밀번호를 입력하세요.";
            this.pwdinput.Click += new System.EventHandler(this.pwdinput_Click);
            // 
            // loginformcopywrite
            // 
            this.loginformcopywrite.Enabled = false;
            this.loginformcopywrite.Font = new System.Drawing.Font("카페24 써라운드", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginformcopywrite.Location = new System.Drawing.Point(15, 125);
            this.loginformcopywrite.Margin = new System.Windows.Forms.Padding(4);
            this.loginformcopywrite.Name = "loginformcopywrite";
            this.loginformcopywrite.Size = new System.Drawing.Size(311, 203);
            this.loginformcopywrite.TabIndex = 10;
            this.loginformcopywrite.Text = "나만의 데일리착장을          완성하다";
            this.loginformcopywrite.UseVisualStyleBackColor = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("카페24 써라운드", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginbutton.Location = new System.Drawing.Point(291, 508);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(155, 76);
            this.loginbutton.TabIndex = 12;
            this.loginbutton.Text = "로그인";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(738, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 781);
            this.vScrollBar1.TabIndex = 13;
            // 
            // loginform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 799);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.loginformcopywrite);
            this.Controls.Add(this.pwdinput);
            this.Controls.Add(this.idinput);
            this.Controls.Add(this.loginformbutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginform2";
            this.Text = "loginform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginformbutton;
        private System.Windows.Forms.TextBox idinput;
        private System.Windows.Forms.TextBox pwdinput;
        private System.Windows.Forms.Button loginformcopywrite;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}