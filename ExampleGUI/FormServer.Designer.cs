namespace ExampleGUI
{
    partial class FormServer
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxMessage = new System.Windows.Forms.TextBox();
            buttonSend = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            listBoxClients = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Client Messages:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 678);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 25);
            label2.TabIndex = 2;
            label2.Text = "Publish to clients:";
            // 
            // textBoxMessage
            // 
            textBoxMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxMessage.Location = new System.Drawing.Point(179, 673);
            textBoxMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new System.Drawing.Size(534, 31);
            textBoxMessage.TabIndex = 3;
            // 
            // buttonSend
            // 
            buttonSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonSend.Location = new System.Drawing.Point(724, 670);
            buttonSend.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new System.Drawing.Size(126, 45);
            buttonSend.TabIndex = 4;
            buttonSend.Text = "&Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(20, 23);
            splitContainer1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBoxMessages);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBoxClients);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new System.Drawing.Size(830, 635);
            splitContainer1.SplitterDistance = 544;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 5;
            // 
            // richTextBoxMessages
            // 
            richTextBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxMessages.Location = new System.Drawing.Point(0, 25);
            richTextBoxMessages.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            richTextBoxMessages.Name = "richTextBoxMessages";
            richTextBoxMessages.ReadOnly = true;
            richTextBoxMessages.Size = new System.Drawing.Size(544, 610);
            richTextBoxMessages.TabIndex = 0;
            richTextBoxMessages.Text = "";
            // 
            // listBoxClients
            // 
            listBoxClients.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 25;
            listBoxClients.Location = new System.Drawing.Point(0, 25);
            listBoxClients.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new System.Drawing.Size(279, 610);
            listBoxClients.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 25);
            label3.TabIndex = 0;
            label3.Text = "Clients:";
            // 
            // FormServer
            // 
            AcceptButton = buttonSend;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 737);
            Controls.Add(splitContainer1);
            Controls.Add(buttonSend);
            Controls.Add(textBoxMessage);
            Controls.Add(label2);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "FormServer";
            Text = "Server";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label label3;
    }
}