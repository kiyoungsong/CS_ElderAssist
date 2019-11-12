namespace NoonUI
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
            this.Closebt = new System.Windows.Forms.Button();
            this.AlwaysTop = new System.Windows.Forms.Button();
            this.Keyboard = new System.Windows.Forms.Button();
            this.Narrator = new System.Windows.Forms.Button();
            this.Magnify = new System.Windows.Forms.Button();
            this.Eyetracker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Closebt
            // 
            this.Closebt.BackColor = System.Drawing.Color.Transparent;
            this.Closebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebt.ForeColor = System.Drawing.Color.Transparent;
            this.Closebt.Image = global::NoonUI.Properties.Resources._6f;
            this.Closebt.Location = new System.Drawing.Point(511, 22);
            this.Closebt.Name = "Closebt";
            this.Closebt.Size = new System.Drawing.Size(94, 84);
            this.Closebt.TabIndex = 5;
            this.Closebt.UseVisualStyleBackColor = false;
            this.Closebt.Click += new System.EventHandler(this.Closebt_Click);
            // 
            // AlwaysTop
            // 
            this.AlwaysTop.BackColor = System.Drawing.Color.Transparent;
            this.AlwaysTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlwaysTop.ForeColor = System.Drawing.Color.Transparent;
            this.AlwaysTop.Image = global::NoonUI.Properties.Resources._5f;
            this.AlwaysTop.Location = new System.Drawing.Point(411, 22);
            this.AlwaysTop.Name = "AlwaysTop";
            this.AlwaysTop.Size = new System.Drawing.Size(94, 84);
            this.AlwaysTop.TabIndex = 4;
            this.AlwaysTop.UseVisualStyleBackColor = false;
            this.AlwaysTop.Click += new System.EventHandler(this.AlwaysTop_Click);
            // 
            // Keyboard
            // 
            this.Keyboard.BackColor = System.Drawing.Color.Transparent;
            this.Keyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Keyboard.ForeColor = System.Drawing.Color.Transparent;
            this.Keyboard.Image = global::NoonUI.Properties.Resources._4f;
            this.Keyboard.Location = new System.Drawing.Point(311, 22);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Size = new System.Drawing.Size(94, 84);
            this.Keyboard.TabIndex = 3;
            this.Keyboard.UseVisualStyleBackColor = false;
            this.Keyboard.Click += new System.EventHandler(this.Keyboard_Click);
            // 
            // Narrator
            // 
            this.Narrator.BackColor = System.Drawing.Color.Transparent;
            this.Narrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Narrator.ForeColor = System.Drawing.Color.Transparent;
            this.Narrator.Image = global::NoonUI.Properties.Resources._3f;
            this.Narrator.Location = new System.Drawing.Point(211, 22);
            this.Narrator.Name = "Narrator";
            this.Narrator.Size = new System.Drawing.Size(94, 84);
            this.Narrator.TabIndex = 2;
            this.Narrator.UseVisualStyleBackColor = false;
            this.Narrator.Click += new System.EventHandler(this.Narrator_Click);
            // 
            // Magnify
            // 
            this.Magnify.BackColor = System.Drawing.Color.Transparent;
            this.Magnify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Magnify.ForeColor = System.Drawing.Color.Transparent;
            this.Magnify.Image = global::NoonUI.Properties.Resources._2f;
            this.Magnify.Location = new System.Drawing.Point(111, 22);
            this.Magnify.Name = "Magnify";
            this.Magnify.Size = new System.Drawing.Size(94, 84);
            this.Magnify.TabIndex = 1;
            this.Magnify.UseVisualStyleBackColor = false;
            this.Magnify.Click += new System.EventHandler(this.Magnify_Click);
            // 
            // Eyetracker
            // 
            this.Eyetracker.BackColor = System.Drawing.Color.Transparent;
            this.Eyetracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eyetracker.ForeColor = System.Drawing.Color.Transparent;
            this.Eyetracker.Image = global::NoonUI.Properties.Resources._1f;
            this.Eyetracker.Location = new System.Drawing.Point(11, 22);
            this.Eyetracker.Name = "Eyetracker";
            this.Eyetracker.Size = new System.Drawing.Size(94, 84);
            this.Eyetracker.TabIndex = 0;
            this.Eyetracker.UseVisualStyleBackColor = false;
            this.Eyetracker.Click += new System.EventHandler(this.Eyetracker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(617, 125);
            this.Controls.Add(this.Closebt);
            this.Controls.Add(this.AlwaysTop);
            this.Controls.Add(this.Keyboard);
            this.Controls.Add(this.Narrator);
            this.Controls.Add(this.Magnify);
            this.Controls.Add(this.Eyetracker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1300, 910);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eyetracker;
        private System.Windows.Forms.Button Magnify;
        private System.Windows.Forms.Button Narrator;
        private System.Windows.Forms.Button Keyboard;
        private System.Windows.Forms.Button AlwaysTop;
        private System.Windows.Forms.Button Closebt;
    }
}

