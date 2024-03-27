namespace SlavaLab2
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
            label1 = new Label();
            label2 = new Label();
            txtOne = new TextBox();
            txtTwo = new TextBox();
            label3 = new Label();
            lblResult = new Label();
            btnOK = new Button();
            label4 = new Label();
            btnOK2 = new Button();
            btnOK3 = new Button();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // txtOne
            // 
            txtOne.Location = new Point(125, 19);
            txtOne.Name = "txtOne";
            txtOne.Size = new Size(177, 27);
            txtOne.TabIndex = 2;
            txtOne.KeyPress += txtOne_KeyPress;
            // 
            // txtTwo
            // 
            txtTwo.Location = new Point(125, 85);
            txtTwo.Name = "txtTwo";
            txtTwo.Size = new Size(177, 27);
            txtTwo.TabIndex = 3;
            txtTwo.KeyPress += txtTwo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(151, 191);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "label4";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(11, 260);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 38);
            btnOK.TabIndex = 6;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 25);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(215, 260);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(142, 38);
            btnOK2.TabIndex = 9;
            btnOK2.Text = "button1";
            btnOK2.UseVisualStyleBackColor = true;
            btnOK2.Click += btnOK2_Click;
            // 
            // btnOK3
            // 
            btnOK3.Location = new Point(618, 67);
            btnOK3.Name = "btnOK3";
            btnOK3.Size = new Size(142, 38);
            btnOK3.TabIndex = 10;
            btnOK3.Text = "button1";
            btnOK3.UseVisualStyleBackColor = true;
            btnOK3.Click += btnOK3_Click;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(606, 22);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(177, 27);
            txtBox.TabIndex = 11;
            txtBox.KeyPress += txtBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox);
            Controls.Add(btnOK3);
            Controls.Add(btnOK2);
            Controls.Add(label4);
            Controls.Add(btnOK);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(txtTwo);
            Controls.Add(txtOne);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOne;
        private TextBox txtTwo;
        private Label label3;
        private Label lblResult;
        private Button btnOK;
        private Label label4;
        private Button btnOK2;
        private Button btnOK3;
        private TextBox txtBox;
    }
}
