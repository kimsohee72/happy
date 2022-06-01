namespace Teamproject1
{
    partial class mainform1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform1));
            this.maincopywirte = new System.Windows.Forms.Label();
            this.maincopywrite2 = new System.Windows.Forms.Label();
            this.mainpictureboxparent = new System.Windows.Forms.PictureBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.gobutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainpictureboxparent)).BeginInit();
            this.SuspendLayout();
            // 
            // maincopywirte
            // 
            this.maincopywirte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maincopywirte.Cursor = System.Windows.Forms.Cursors.No;
            this.maincopywirte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maincopywirte.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.maincopywirte.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.maincopywirte.Image = ((System.Drawing.Image)(resources.GetObject("maincopywirte.Image")));
            this.maincopywirte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maincopywirte.Location = new System.Drawing.Point(-9, 379);
            this.maincopywirte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maincopywirte.Name = "maincopywirte";
            this.maincopywirte.Size = new System.Drawing.Size(409, 205);
            this.maincopywirte.TabIndex = 0;
            this.maincopywirte.Text = "제멋대로인 날씨, 뭘 입어야 할지 모르겠다면?";
            // 
            // maincopywrite2
            // 
            this.maincopywrite2.AutoSize = true;
            this.maincopywrite2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maincopywrite2.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maincopywrite2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.maincopywrite2.Image = ((System.Drawing.Image)(resources.GetObject("maincopywrite2.Image")));
            this.maincopywrite2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maincopywrite2.Location = new System.Drawing.Point(-2, 610);
            this.maincopywrite2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maincopywrite2.Name = "maincopywrite2";
            this.maincopywrite2.Size = new System.Drawing.Size(231, 24);
            this.maincopywrite2.TabIndex = 1;
            this.maincopywrite2.Text = "스타일 여행을 떠나보세요";
            // 
            // mainpictureboxparent
            // 
            this.mainpictureboxparent.ErrorImage = ((System.Drawing.Image)(resources.GetObject("mainpictureboxparent.ErrorImage")));
            this.mainpictureboxparent.Image = ((System.Drawing.Image)(resources.GetObject("mainpictureboxparent.Image")));
            this.mainpictureboxparent.Location = new System.Drawing.Point(-14, 4);
            this.mainpictureboxparent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainpictureboxparent.Name = "mainpictureboxparent";
            this.mainpictureboxparent.Size = new System.Drawing.Size(670, 976);
            this.mainpictureboxparent.TabIndex = 0;
            this.mainpictureboxparent.TabStop = false;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginbutton.Font = new System.Drawing.Font("카페24 써라운드", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginbutton.Location = new System.Drawing.Point(538, 610);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 60);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // gobutton
            // 
            this.gobutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gobutton.Font = new System.Drawing.Font("카페24 써라운드", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobutton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gobutton.Location = new System.Drawing.Point(538, 413);
            this.gobutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(75, 62);
            this.gobutton.TabIndex = 5;
            this.gobutton.Text = "GO";
            this.gobutton.UseVisualStyleBackColor = false;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("카페24 써라운드", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(538, 701);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "INFO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("카페24 써라운드", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(538, 504);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 9;
            this.button2.Text = "PICK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 879);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gobutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.maincopywrite2);
            this.Controls.Add(this.maincopywirte);
            this.Controls.Add(this.mainpictureboxparent);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainform1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainpictureboxparent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maincopywirte;
        private System.Windows.Forms.Label maincopywrite2;
        private System.Windows.Forms.PictureBox mainpictureboxparent;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

