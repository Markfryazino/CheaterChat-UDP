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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MessageViewBox = new System.Windows.Forms.RichTextBox();
            this.CallbackBox = new System.Windows.Forms.RichTextBox();
            this.UserMessageBox = new System.Windows.Forms.RichTextBox();
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.ConnectionList = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.AuthorizeBtn = new System.Windows.Forms.Button();
            this.AuthorizeBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageViewBox
            // 
            this.MessageViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageViewBox.BackColor = System.Drawing.Color.White;
            this.MessageViewBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageViewBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageViewBox.Location = new System.Drawing.Point(28, 95);
            this.MessageViewBox.MaximumSize = new System.Drawing.Size(700, 500);
            this.MessageViewBox.Name = "MessageViewBox";
            this.MessageViewBox.ReadOnly = true;
            this.MessageViewBox.Size = new System.Drawing.Size(395, 230);
            this.MessageViewBox.TabIndex = 8;
            this.MessageViewBox.Text = "";
            // 
            // CallbackBox
            // 
            this.CallbackBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CallbackBox.BackColor = System.Drawing.Color.White;
            this.CallbackBox.Location = new System.Drawing.Point(28, 453);
            this.CallbackBox.Name = "CallbackBox";
            this.CallbackBox.ReadOnly = true;
            this.CallbackBox.Size = new System.Drawing.Size(262, 112);
            this.CallbackBox.TabIndex = 16;
            this.CallbackBox.Text = "";
            // 
            // UserMessageBox
            // 
            this.UserMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserMessageBox.BackColor = System.Drawing.Color.White;
            this.UserMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserMessageBox.Location = new System.Drawing.Point(566, 453);
            this.UserMessageBox.Name = "UserMessageBox";
            this.UserMessageBox.Size = new System.Drawing.Size(432, 112);
            this.UserMessageBox.TabIndex = 9;
            this.UserMessageBox.Text = "";
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendMessageBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.SendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageBtn.Location = new System.Drawing.Point(379, 453);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(166, 112);
            this.SendMessageBtn.TabIndex = 10;
            this.SendMessageBtn.Text = "Отправить";
            this.SendMessageBtn.UseVisualStyleBackColor = false;
            this.SendMessageBtn.Click += new System.EventHandler(this.SendMessageBtn_Click);
            // 
            // ConnectionList
            // 
            this.ConnectionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionList.BackColor = System.Drawing.Color.White;
            this.ConnectionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConnectionList.FormattingEnabled = true;
            this.ConnectionList.Items.AddRange(new object[] {
            "Подключены:"});
            this.ConnectionList.Location = new System.Drawing.Point(600, 164);
            this.ConnectionList.Name = "ConnectionList";
            this.ConnectionList.Size = new System.Drawing.Size(185, 156);
            this.ConnectionList.TabIndex = 11;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(812, 237);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(196, 52);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBtn.BackColor = System.Drawing.Color.White;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpBtn.Location = new System.Drawing.Point(812, 164);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(196, 55);
            this.HelpBtn.TabIndex = 13;
            this.HelpBtn.Text = "Справка";
            this.HelpBtn.UseVisualStyleBackColor = false;
            // 
            // AuthorizeBtn
            // 
            this.AuthorizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorizeBtn.BackColor = System.Drawing.Color.White;
            this.AuthorizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeBtn.Location = new System.Drawing.Point(902, 93);
            this.AuthorizeBtn.Name = "AuthorizeBtn";
            this.AuthorizeBtn.Size = new System.Drawing.Size(106, 49);
            this.AuthorizeBtn.TabIndex = 15;
            this.AuthorizeBtn.Text = "Войти";
            this.AuthorizeBtn.UseVisualStyleBackColor = false;
            this.AuthorizeBtn.Click += new System.EventHandler(this.AuthorizeBtn_Click);
            // 
            // AuthorizeBox
            // 
            this.AuthorizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorizeBox.BackColor = System.Drawing.Color.White;
            this.AuthorizeBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeBox.Location = new System.Drawing.Point(600, 93);
            this.AuthorizeBox.Name = "AuthorizeBox";
            this.AuthorizeBox.Size = new System.Drawing.Size(282, 49);
            this.AuthorizeBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Cheater_Chat_1._3.Properties.Resources.ЛоготипBraveNewSoft;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(296, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 69);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 605);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthorizeBox);
            this.Controls.Add(this.CallbackBox);
            this.Controls.Add(this.AuthorizeBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ConnectionList);
            this.Controls.Add(this.SendMessageBtn);
            this.Controls.Add(this.UserMessageBox);
            this.Controls.Add(this.MessageViewBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CheaterChat v1.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox MessageViewBox;
        public System.Windows.Forms.RichTextBox CallbackBox;
        public System.Windows.Forms.RichTextBox UserMessageBox;
        public System.Windows.Forms.Button SendMessageBtn;
        public System.Windows.Forms.ListBox ConnectionList;
        public System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.Button HelpBtn;
        public System.Windows.Forms.Button AuthorizeBtn;
        public System.Windows.Forms.TextBox AuthorizeBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

