﻿namespace VotingApp
{
    partial class defaultForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.onConfirmBtn = new System.Windows.Forms.Button();
            this.onExitBtn = new System.Windows.Forms.Button();
            this.onHelpBtn = new System.Windows.Forms.Button();
            this.usedCNPLabel = new System.Windows.Forms.Label();
            this.onCreateBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(261, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(261, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNP:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(261, 178);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(173, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenume";
            // 
            // onConfirmBtn
            // 
            this.onConfirmBtn.Location = new System.Drawing.Point(303, 259);
            this.onConfirmBtn.Name = "onConfirmBtn";
            this.onConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.onConfirmBtn.TabIndex = 6;
            this.onConfirmBtn.Text = "Confirm";
            this.onConfirmBtn.UseVisualStyleBackColor = true;
            this.onConfirmBtn.Click += new System.EventHandler(this.onConfirmBtn_Click);
            // 
            // onExitBtn
            // 
            this.onExitBtn.Location = new System.Drawing.Point(611, 415);
            this.onExitBtn.Name = "onExitBtn";
            this.onExitBtn.Size = new System.Drawing.Size(75, 23);
            this.onExitBtn.TabIndex = 7;
            this.onExitBtn.Text = "Exit";
            this.onExitBtn.UseVisualStyleBackColor = true;
            this.onExitBtn.Click += new System.EventHandler(this.onExitBtn_Click);
            // 
            // onHelpBtn
            // 
            this.onHelpBtn.Location = new System.Drawing.Point(530, 415);
            this.onHelpBtn.Name = "onHelpBtn";
            this.onHelpBtn.Size = new System.Drawing.Size(75, 23);
            this.onHelpBtn.TabIndex = 8;
            this.onHelpBtn.Text = "Help";
            this.onHelpBtn.UseVisualStyleBackColor = true;
            this.onHelpBtn.Click += new System.EventHandler(this.onHelpBtn_Click);
            // 
            // usedCNPLabel
            // 
            this.usedCNPLabel.AutoSize = true;
            this.usedCNPLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedCNPLabel.ForeColor = System.Drawing.Color.Red;
            this.usedCNPLabel.Location = new System.Drawing.Point(238, 240);
            this.usedCNPLabel.Name = "usedCNPLabel";
            this.usedCNPLabel.Size = new System.Drawing.Size(230, 16);
            this.usedCNPLabel.TabIndex = 9;
            this.usedCNPLabel.Text = "CNP-ul este folosit pentru a vota!";
            this.usedCNPLabel.Click += new System.EventHandler(this.usedCNPLabel_Click);
            // 
            // onCreateBtn
            // 
            this.onCreateBtn.Location = new System.Drawing.Point(449, 415);
            this.onCreateBtn.Name = "onCreateBtn";
            this.onCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.onCreateBtn.TabIndex = 10;
            this.onCreateBtn.Text = "Create";
            this.onCreateBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PoolID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // defaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.onCreateBtn);
            this.Controls.Add(this.usedCNPLabel);
            this.Controls.Add(this.onHelpBtn);
            this.Controls.Add(this.onExitBtn);
            this.Controls.Add(this.onConfirmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nameTextBox);
            this.Name = "defaultForm";
            this.Text = "VotingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button onConfirmBtn;
        private System.Windows.Forms.Button onExitBtn;
        private System.Windows.Forms.Button onHelpBtn;
        private System.Windows.Forms.Label usedCNPLabel;
        private System.Windows.Forms.Button onCreateBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

