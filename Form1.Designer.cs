namespace Cheater_Chat_1._3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuthorizeBtn = new System.Windows.Forms.Button();
            this.AuthorizeBox = new System.Windows.Forms.TextBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ConnectionList = new System.Windows.Forms.ListBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.UserMessageBox = new System.Windows.Forms.RichTextBox();
            this.MessageViewBox = new System.Windows.Forms.RichTextBox();
            this.CallbackBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AuthorizeBtn
            // 
            this.AuthorizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AuthorizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeBtn.Location = new System.Drawing.Point(435, 13);
            this.AuthorizeBtn.Name = "AuthorizeBtn";
            this.AuthorizeBtn.Size = new System.Drawing.Size(90, 49);
            this.AuthorizeBtn.TabIndex = 15;
            this.AuthorizeBtn.Text = "Войти";
            this.AuthorizeBtn.UseVisualStyleBackColor = false;
            this.AuthorizeBtn.Click += new System.EventHandler(this.AuthorizeBtn_Click);
            // 
            // AuthorizeBox
            // 
            this.AuthorizeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AuthorizeBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeBox.Location = new System.Drawing.Point(12, 13);
            this.AuthorizeBox.Name = "AuthorizeBox";
            this.AuthorizeBox.Size = new System.Drawing.Size(403, 49);
            this.AuthorizeBox.TabIndex = 0;
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpBtn.Location = new System.Drawing.Point(146, 102);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(185, 42);
            this.HelpBtn.TabIndex = 13;
            this.HelpBtn.Text = "Справка";
            this.HelpBtn.UseVisualStyleBackColor = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(146, 155);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(185, 42);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ConnectionList
            // 
            this.ConnectionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ConnectionList.FormattingEnabled = true;
            this.ConnectionList.Items.AddRange(new object[] {
            "Подключены:"});
            this.ConnectionList.Location = new System.Drawing.Point(13, 102);
            this.ConnectionList.Name = "ConnectionList";
            this.ConnectionList.Size = new System.Drawing.Size(109, 95);
            this.ConnectionList.TabIndex = 11;
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageBtn.Location = new System.Drawing.Point(12, 452);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(319, 62);
            this.SendMessageBtn.TabIndex = 10;
            this.SendMessageBtn.Text = "Отправить";
            this.SendMessageBtn.UseVisualStyleBackColor = false;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // UserMessageBox
            // 
            this.UserMessageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserMessageBox.Location = new System.Drawing.Point(12, 221);
            this.UserMessageBox.Name = "UserMessageBox";
            this.UserMessageBox.Size = new System.Drawing.Size(319, 225);
            this.UserMessageBox.TabIndex = 9;
            this.UserMessageBox.Text = "";
            // 
            // MessageViewBox
            // 
            this.MessageViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageViewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MessageViewBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageViewBox.Location = new System.Drawing.Point(347, 170);
            this.MessageViewBox.Name = "MessageViewBox";
            this.MessageViewBox.ReadOnly = true;
            this.MessageViewBox.Size = new System.Drawing.Size(324, 344);
            this.MessageViewBox.TabIndex = 8;
            this.MessageViewBox.Text = "";
            // 
            // CallbackBox
            // 
            this.CallbackBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CallbackBox.Location = new System.Drawing.Point(347, 102);
            this.CallbackBox.Name = "CallbackBox";
            this.CallbackBox.ReadOnly = true;
            this.CallbackBox.Size = new System.Drawing.Size(324, 62);
            this.CallbackBox.TabIndex = 16;
            this.CallbackBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(683, 526);
            this.Controls.Add(this.CallbackBox);
            this.Controls.Add(this.AuthorizeBtn);
            this.Controls.Add(this.AuthorizeBox);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ConnectionList);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.UserMessageBox);
            this.Controls.Add(this.MessageViewBox);
            this.Name = "MainForm";
            this.Text = "CheaterChat 1.3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button AuthorizeBtn;
        public System.Windows.Forms.TextBox AuthorizeBox;
        public System.Windows.Forms.Button HelpBtn;
        public System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.ListBox ConnectionList;
        public System.Windows.Forms.Button SendMessageBtn;
        public System.Windows.Forms.RichTextBox UserMessageBox;
        public System.Windows.Forms.RichTextBox MessageViewBox;
        public System.Windows.Forms.RichTextBox CallbackBox;
    }
}

