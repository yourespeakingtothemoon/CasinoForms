namespace CasinoForms.Testing
{
    partial class TestView
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
            button1 = new Button();
            depositcheck = new Label();
            withdrawcheck = new Label();
            depositandwithdrawcheck = new Label();
            decktest1 = new Label();
            Decktest2 = new Label();
            Decktest3 = new Label();
            Payout = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(344, 407);
            button1.Name = "button1";
            button1.Size = new Size(118, 31);
            button1.TabIndex = 0;
            button1.Text = "Run All Tests";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // depositcheck
            // 
            depositcheck.AutoSize = true;
            depositcheck.Location = new Point(12, 9);
            depositcheck.Name = "depositcheck";
            depositcheck.Size = new Size(172, 15);
            depositcheck.TabIndex = 2;
            depositcheck.Text = "Deposit 1.0f Bank returns 101.0f";
            // 
            // withdrawcheck
            // 
            withdrawcheck.AutoSize = true;
            withdrawcheck.Location = new Point(12, 33);
            withdrawcheck.Name = "withdrawcheck";
            withdrawcheck.Size = new Size(177, 30);
            withdrawcheck.TabIndex = 3;
            withdrawcheck.Text = "Withdraw 1.0f Bank returns 99.0f\r\nand player total returns 1.0f";
            // 
            // depositandwithdrawcheck
            // 
            depositandwithdrawcheck.AutoSize = true;
            depositandwithdrawcheck.Location = new Point(12, 73);
            depositandwithdrawcheck.Name = "depositandwithdrawcheck";
            depositandwithdrawcheck.Size = new Size(231, 30);
            depositandwithdrawcheck.TabIndex = 4;
            depositandwithdrawcheck.Text = "deposit 50.0f withdraw 25.0f final \r\namounts should reflect this math correctly";
            // 
            // decktest1
            // 
            decktest1.AutoSize = true;
            decktest1.Location = new Point(12, 113);
            decktest1.Name = "decktest1";
            decktest1.Size = new Size(155, 15);
            decktest1.TabIndex = 5;
            decktest1.Text = "Deck should return 52 Cards";
            // 
            // Decktest2
            // 
            Decktest2.AutoSize = true;
            Decktest2.Location = new Point(12, 141);
            Decktest2.Name = "Decktest2";
            Decktest2.Size = new Size(251, 15);
            Decktest2.TabIndex = 6;
            Decktest2.Text = "Deck should be evenly divided between 4 suits";
            // 
            // Decktest3
            // 
            Decktest3.AutoSize = true;
            Decktest3.Location = new Point(12, 168);
            Decktest3.Name = "Decktest3";
            Decktest3.Size = new Size(200, 15);
            Decktest3.TabIndex = 7;
            Decktest3.Text = "Deck should have no duplicate cards";
            //Decktest3.Click += Decktest3_Click;
            // 
            // Payout
            // 
            Payout.AutoSize = true;
            Payout.Location = new Point(12, 195);
            Payout.Name = "Payout";
            Payout.Size = new Size(210, 15);
            Payout.TabIndex = 8;
            Payout.Text = "Payout correctly reflects in User Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(762, 366);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 9;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(734, 390);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Untested";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Green;
            label3.Location = new Point(719, 405);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 11;
            label3.Text = "Passed Test!";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(724, 420);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "Failed Test!";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // TestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Payout);
            Controls.Add(Decktest3);
            Controls.Add(Decktest2);
            Controls.Add(decktest1);
            Controls.Add(depositandwithdrawcheck);
            Controls.Add(withdrawcheck);
            Controls.Add(depositcheck);
            Controls.Add(button1);
            Name = "TestView";
            Text = "TestView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Label depositcheck;
        public Label withdrawcheck;
        public Label depositandwithdrawcheck;
        public Label decktest1;
        public Label Decktest2;
        public Label Decktest3;
        public Label Payout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}