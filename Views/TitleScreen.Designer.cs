
using CasinoForms.Models;

namespace CasinoForms.Views
{
    partial class TitleScreen 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public UserModel user = new UserModel();

        private Image blackjackDefault = Properties.Resources.BlackJack;
        private Image blackjackHover = Properties.Resources.BlackJack_Pressed;
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

        public TitleScreen(UserModel user)
        {
            this.user = user;
            InitializeComponent();
            label2.Text = user.balanceToString();
            label3.Text = user.name;
        
        }

     
        void blackjack_MouseClick(object sender, MouseEventArgs e)
        {
            

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            blackjackbutton = new PictureBox();
            pokerbutton = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            bankbutton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)blackjackbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pokerbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // blackjackbutton
            // 
            blackjackbutton.BackColor = Color.Transparent;
            blackjackbutton.Image = Properties.Resources.BlackJack;
            blackjackbutton.Location = new Point(367, 184);
            blackjackbutton.Margin = new Padding(3, 4, 3, 4);
            blackjackbutton.Name = "blackjackbutton";
            blackjackbutton.Size = new Size(121, 105);
            blackjackbutton.SizeMode = PictureBoxSizeMode.Zoom;
            blackjackbutton.TabIndex = 0;
            blackjackbutton.TabStop = false;
            blackjackbutton.Click += blackjackbutton_Click;
            blackjackbutton.MouseClick += blackjack_MouseClick;
            blackjackbutton.MouseLeave += blackjack_MouseLeave;
            blackjackbutton.MouseHover += blackjack_MouseHover;
            // 
            // pokerbutton
            // 
            pokerbutton.BackColor = Color.Transparent;
            pokerbutton.Image = Properties.Resources.Poker;
            pokerbutton.Location = new Point(210, 184);
            pokerbutton.Margin = new Padding(3, 4, 3, 4);
            pokerbutton.Name = "pokerbutton";
            pokerbutton.Size = new Size(121, 105);
            pokerbutton.SizeMode = PictureBoxSizeMode.Zoom;
            pokerbutton.TabIndex = 1;
            pokerbutton.TabStop = false;
            pokerbutton.Click += pokerbutton_Click;
            pokerbutton.MouseClick += poker_MouseClick;
            pokerbutton.MouseLeave += poker_MouseLeave;
            pokerbutton.MouseHover += poker_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Roulette;
            pictureBox3.Location = new Point(129, 321);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.SlotMachine;
            pictureBox4.Location = new Point(287, 321);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(121, 105);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Craps;
            pictureBox5.Location = new Point(53, 184);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(121, 105);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.CasinoForms;
            pictureBox6.Location = new Point(-14, -52);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(593, 341);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // bankbutton
            // 
            bankbutton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bankbutton.Location = new Point(433, 500);
            bankbutton.Margin = new Padding(3, 4, 3, 4);
            bankbutton.Name = "bankbutton";
            bankbutton.Size = new Size(106, 76);
            bankbutton.TabIndex = 6;
            bankbutton.Text = "Bank";
            bankbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(14, 500);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(106, 76);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(129, 551);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 8;
            label1.Text = "Chips Value:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(347, 551);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 9;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(271, 500);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 10;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TitleScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(553, 615);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(bankbutton);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pokerbutton);
            Controls.Add(blackjackbutton);
            Controls.Add(pictureBox6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TitleScreen";
            Text = "CasinoForms";
            Load += TitleScreen_Load;
            ((System.ComponentModel.ISupportInitialize)blackjackbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pokerbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void poker_MouseHover(object sender, EventArgs e)
        {
            pokerbutton.Image = Properties.Resources.Poker_Pressed;
        }

        private void poker_MouseLeave(object sender, EventArgs e)
        {
            pokerbutton.Image = Properties.Resources.Poker;
          
        }

        private void poker_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void blackjack_MouseLeave(object sender, EventArgs e)
        {
          blackjackbutton.Image = blackjackDefault;
        }

        private void blackjack_MouseHover(object sender, EventArgs e)
        {
            blackjackbutton.Image = blackjackHover;
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button bankbutton;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox blackjackbutton;
        private PictureBox pokerbutton;
        private Label label3;
    }
}