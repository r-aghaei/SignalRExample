namespace SignalRChatClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.messagesList = new System.Windows.Forms.ListBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(38, 37);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(261, 58);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(960, 134);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(259, 58);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messagesList
            // 
            this.messagesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesList.FormattingEnabled = true;
            this.messagesList.ItemHeight = 41;
            this.messagesList.Location = new System.Drawing.Point(38, 235);
            this.messagesList.Name = "messagesList";
            this.messagesList.Size = new System.Drawing.Size(1181, 291);
            this.messagesList.TabIndex = 2;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(124, 143);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(250, 47);
            this.userTextBox.TabIndex = 3;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(549, 140);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(371, 47);
            this.messageTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.messagesList);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connectButton;
        private Button sendButton;
        private ListBox messagesList;
        private TextBox userTextBox;
        private TextBox messageTextBox;
        private Label label1;
        private Label label2;
    }
}