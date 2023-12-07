
namespace FirstQueue
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelQueue = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(58, 40);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(157, 49);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(58, 158);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(157, 60);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(55, 268);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(159, 72);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.Location = new System.Drawing.Point(286, 286);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(46, 17);
            this.labelQueue.TabIndex = 3;
            this.labelQueue.Text = "label1";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(289, 40);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(145, 48);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelQueue);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label labelQueue;
        private System.Windows.Forms.Button buttonFind;
    }
}

