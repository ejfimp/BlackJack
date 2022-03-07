namespace BlackJack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hitButton = new System.Windows.Forms.Button();
            this.dealerCard1 = new System.Windows.Forms.Panel();
            this.dealerCardValue1 = new System.Windows.Forms.Label();
            this.dealerCardSuit1 = new System.Windows.Forms.PictureBox();
            this.hiddenCard = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.Panel();
            this.dealerCardValue2 = new System.Windows.Forms.Label();
            this.dealerCardSuit2 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.Panel();
            this.playerCardValue1 = new System.Windows.Forms.Label();
            this.playerCardSuit1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.Panel();
            this.playerCardValue2 = new System.Windows.Forms.Label();
            this.playerCardSuit2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.Panel();
            this.playerCardValue3 = new System.Windows.Forms.Label();
            this.playerCardSuit3 = new System.Windows.Forms.PictureBox();
            this.dealerCard3 = new System.Windows.Forms.Panel();
            this.dealerCardValue3 = new System.Windows.Forms.Label();
            this.dealerCardSuit3 = new System.Windows.Forms.PictureBox();
            this.dealerHandList = new System.Windows.Forms.RichTextBox();
            this.playerHandList = new System.Windows.Forms.RichTextBox();
            this.dealerCard5 = new System.Windows.Forms.Panel();
            this.dealerCardValue5 = new System.Windows.Forms.Label();
            this.dealerCardSuit5 = new System.Windows.Forms.PictureBox();
            this.dealerCard4 = new System.Windows.Forms.Panel();
            this.dealerCardValue4 = new System.Windows.Forms.Label();
            this.dealerCardSuit4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.Panel();
            this.playerCardValue5 = new System.Windows.Forms.Label();
            this.playerCardSuit5 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.Panel();
            this.playerCardValue4 = new System.Windows.Forms.Label();
            this.playerCardSuit4 = new System.Windows.Forms.PictureBox();
            this.stayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newRoundButton = new System.Windows.Forms.Button();
            this.dealerTimer = new System.Windows.Forms.Timer(this.components);
            this.playerTotalLabel = new System.Windows.Forms.Label();
            this.dealerTotalLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.betButtonOne = new System.Windows.Forms.Button();
            this.betButtonTwo = new System.Windows.Forms.Button();
            this.betButtonThree = new System.Windows.Forms.Button();
            this.betButtonFour = new System.Windows.Forms.Button();
            this.betButtonFive = new System.Windows.Forms.Button();
            this.betButtonSix = new System.Windows.Forms.Button();
            this.betButtonSeven = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentBetLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearBetButton = new System.Windows.Forms.Button();
            this.allInButton = new System.Windows.Forms.Button();
            this.playerHandListLabel = new System.Windows.Forms.Label();
            this.dealerHandListLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dealerCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenCard)).BeginInit();
            this.dealerCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit2)).BeginInit();
            this.playerCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit1)).BeginInit();
            this.playerCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit2)).BeginInit();
            this.playerCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit3)).BeginInit();
            this.dealerCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit3)).BeginInit();
            this.dealerCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit5)).BeginInit();
            this.dealerCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit4)).BeginInit();
            this.playerCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit5)).BeginInit();
            this.playerCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit4)).BeginInit();
            this.SuspendLayout();
            // 
            // hitButton
            // 
            this.hitButton.Enabled = false;
            this.hitButton.Location = new System.Drawing.Point(318, 220);
            this.hitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(78, 65);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.HitButtonClick);
            // 
            // dealerCard1
            // 
            this.dealerCard1.BackColor = System.Drawing.Color.White;
            this.dealerCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerCard1.Controls.Add(this.dealerCardValue1);
            this.dealerCard1.Controls.Add(this.dealerCardSuit1);
            this.dealerCard1.Location = new System.Drawing.Point(571, 64);
            this.dealerCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(78, 100);
            this.dealerCard1.TabIndex = 4;
            this.dealerCard1.Visible = false;
            // 
            // dealerCardValue1
            // 
            this.dealerCardValue1.AutoSize = true;
            this.dealerCardValue1.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerCardValue1.Location = new System.Drawing.Point(4, 3);
            this.dealerCardValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCardValue1.Name = "dealerCardValue1";
            this.dealerCardValue1.Size = new System.Drawing.Size(0, 28);
            this.dealerCardValue1.TabIndex = 6;
            this.dealerCardValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCardSuit1
            // 
            this.dealerCardSuit1.AccessibleDescription = "";
            this.dealerCardSuit1.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardSuit1.Location = new System.Drawing.Point(20, 29);
            this.dealerCardSuit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCardSuit1.Name = "dealerCardSuit1";
            this.dealerCardSuit1.Size = new System.Drawing.Size(38, 43);
            this.dealerCardSuit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardSuit1.TabIndex = 5;
            this.dealerCardSuit1.TabStop = false;
            // 
            // hiddenCard
            // 
            this.hiddenCard.AccessibleDescription = "";
            this.hiddenCard.BackColor = System.Drawing.Color.Transparent;
            this.hiddenCard.BackgroundImage = global::BlackJack.Properties.Resources.backCard;
            this.hiddenCard.Image = global::BlackJack.Properties.Resources.backCard;
            this.hiddenCard.Location = new System.Drawing.Point(487, 64);
            this.hiddenCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hiddenCard.Name = "hiddenCard";
            this.hiddenCard.Size = new System.Drawing.Size(78, 100);
            this.hiddenCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hiddenCard.TabIndex = 7;
            this.hiddenCard.TabStop = false;
            this.hiddenCard.Visible = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.BackColor = System.Drawing.Color.White;
            this.dealerCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerCard2.Controls.Add(this.dealerCardValue2);
            this.dealerCard2.Controls.Add(this.dealerCardSuit2);
            this.dealerCard2.Location = new System.Drawing.Point(487, 64);
            this.dealerCard2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(78, 100);
            this.dealerCard2.TabIndex = 7;
            this.dealerCard2.Visible = false;
            // 
            // dealerCardValue2
            // 
            this.dealerCardValue2.AutoSize = true;
            this.dealerCardValue2.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerCardValue2.Location = new System.Drawing.Point(4, 3);
            this.dealerCardValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCardValue2.Name = "dealerCardValue2";
            this.dealerCardValue2.Size = new System.Drawing.Size(0, 28);
            this.dealerCardValue2.TabIndex = 6;
            this.dealerCardValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCardSuit2
            // 
            this.dealerCardSuit2.AccessibleDescription = "";
            this.dealerCardSuit2.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardSuit2.Location = new System.Drawing.Point(20, 29);
            this.dealerCardSuit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCardSuit2.Name = "dealerCardSuit2";
            this.dealerCardSuit2.Size = new System.Drawing.Size(38, 43);
            this.dealerCardSuit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardSuit2.TabIndex = 5;
            this.dealerCardSuit2.TabStop = false;
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.Color.White;
            this.playerCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard1.Controls.Add(this.playerCardValue1);
            this.playerCard1.Controls.Add(this.playerCardSuit1);
            this.playerCard1.Location = new System.Drawing.Point(235, 341);
            this.playerCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(78, 100);
            this.playerCard1.TabIndex = 7;
            this.playerCard1.Visible = false;
            // 
            // playerCardValue1
            // 
            this.playerCardValue1.AutoSize = true;
            this.playerCardValue1.BackColor = System.Drawing.Color.Transparent;
            this.playerCardValue1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCardValue1.Location = new System.Drawing.Point(4, 3);
            this.playerCardValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCardValue1.Name = "playerCardValue1";
            this.playerCardValue1.Size = new System.Drawing.Size(0, 28);
            this.playerCardValue1.TabIndex = 6;
            this.playerCardValue1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCardSuit1
            // 
            this.playerCardSuit1.AccessibleDescription = "cardSuitBox";
            this.playerCardSuit1.BackColor = System.Drawing.Color.Transparent;
            this.playerCardSuit1.Location = new System.Drawing.Point(20, 29);
            this.playerCardSuit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCardSuit1.Name = "playerCardSuit1";
            this.playerCardSuit1.Size = new System.Drawing.Size(38, 43);
            this.playerCardSuit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardSuit1.TabIndex = 5;
            this.playerCardSuit1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.BackColor = System.Drawing.Color.White;
            this.playerCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard2.Controls.Add(this.playerCardValue2);
            this.playerCard2.Controls.Add(this.playerCardSuit2);
            this.playerCard2.Location = new System.Drawing.Point(319, 341);
            this.playerCard2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(78, 100);
            this.playerCard2.TabIndex = 7;
            this.playerCard2.Visible = false;
            // 
            // playerCardValue2
            // 
            this.playerCardValue2.AutoSize = true;
            this.playerCardValue2.BackColor = System.Drawing.Color.Transparent;
            this.playerCardValue2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCardValue2.Location = new System.Drawing.Point(4, 3);
            this.playerCardValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCardValue2.Name = "playerCardValue2";
            this.playerCardValue2.Size = new System.Drawing.Size(0, 28);
            this.playerCardValue2.TabIndex = 6;
            this.playerCardValue2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCardSuit2
            // 
            this.playerCardSuit2.AccessibleDescription = "";
            this.playerCardSuit2.BackColor = System.Drawing.Color.Transparent;
            this.playerCardSuit2.Location = new System.Drawing.Point(20, 29);
            this.playerCardSuit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCardSuit2.Name = "playerCardSuit2";
            this.playerCardSuit2.Size = new System.Drawing.Size(38, 43);
            this.playerCardSuit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardSuit2.TabIndex = 5;
            this.playerCardSuit2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.BackColor = System.Drawing.Color.White;
            this.playerCard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard3.Controls.Add(this.playerCardValue3);
            this.playerCard3.Controls.Add(this.playerCardSuit3);
            this.playerCard3.Location = new System.Drawing.Point(403, 341);
            this.playerCard3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(78, 100);
            this.playerCard3.TabIndex = 7;
            this.playerCard3.Visible = false;
            // 
            // playerCardValue3
            // 
            this.playerCardValue3.AutoSize = true;
            this.playerCardValue3.BackColor = System.Drawing.Color.Transparent;
            this.playerCardValue3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCardValue3.Location = new System.Drawing.Point(4, 3);
            this.playerCardValue3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCardValue3.Name = "playerCardValue3";
            this.playerCardValue3.Size = new System.Drawing.Size(0, 28);
            this.playerCardValue3.TabIndex = 6;
            this.playerCardValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCardSuit3
            // 
            this.playerCardSuit3.AccessibleDescription = "";
            this.playerCardSuit3.BackColor = System.Drawing.Color.Transparent;
            this.playerCardSuit3.Location = new System.Drawing.Point(20, 29);
            this.playerCardSuit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCardSuit3.Name = "playerCardSuit3";
            this.playerCardSuit3.Size = new System.Drawing.Size(38, 43);
            this.playerCardSuit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardSuit3.TabIndex = 5;
            this.playerCardSuit3.TabStop = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.BackColor = System.Drawing.Color.White;
            this.dealerCard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerCard3.Controls.Add(this.dealerCardValue3);
            this.dealerCard3.Controls.Add(this.dealerCardSuit3);
            this.dealerCard3.Location = new System.Drawing.Point(403, 64);
            this.dealerCard3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(78, 100);
            this.dealerCard3.TabIndex = 7;
            this.dealerCard3.Visible = false;
            // 
            // dealerCardValue3
            // 
            this.dealerCardValue3.AutoSize = true;
            this.dealerCardValue3.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerCardValue3.Location = new System.Drawing.Point(4, 3);
            this.dealerCardValue3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCardValue3.Name = "dealerCardValue3";
            this.dealerCardValue3.Size = new System.Drawing.Size(0, 28);
            this.dealerCardValue3.TabIndex = 6;
            this.dealerCardValue3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCardSuit3
            // 
            this.dealerCardSuit3.AccessibleDescription = "";
            this.dealerCardSuit3.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardSuit3.Location = new System.Drawing.Point(20, 29);
            this.dealerCardSuit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCardSuit3.Name = "dealerCardSuit3";
            this.dealerCardSuit3.Size = new System.Drawing.Size(38, 43);
            this.dealerCardSuit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardSuit3.TabIndex = 5;
            this.dealerCardSuit3.TabStop = false;
            // 
            // dealerHandList
            // 
            this.dealerHandList.Location = new System.Drawing.Point(716, 37);
            this.dealerHandList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerHandList.Name = "dealerHandList";
            this.dealerHandList.Size = new System.Drawing.Size(119, 100);
            this.dealerHandList.TabIndex = 8;
            this.dealerHandList.Text = "";
            this.dealerHandList.Visible = false;
            // 
            // playerHandList
            // 
            this.playerHandList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.playerHandList.Location = new System.Drawing.Point(49, 368);
            this.playerHandList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerHandList.Name = "playerHandList";
            this.playerHandList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerHandList.Size = new System.Drawing.Size(119, 100);
            this.playerHandList.TabIndex = 9;
            this.playerHandList.Text = "";
            this.playerHandList.Visible = false;
            // 
            // dealerCard5
            // 
            this.dealerCard5.BackColor = System.Drawing.Color.White;
            this.dealerCard5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerCard5.Controls.Add(this.dealerCardValue5);
            this.dealerCard5.Controls.Add(this.dealerCardSuit5);
            this.dealerCard5.Location = new System.Drawing.Point(235, 64);
            this.dealerCard5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(78, 100);
            this.dealerCard5.TabIndex = 8;
            this.dealerCard5.Visible = false;
            // 
            // dealerCardValue5
            // 
            this.dealerCardValue5.AutoSize = true;
            this.dealerCardValue5.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerCardValue5.Location = new System.Drawing.Point(4, 3);
            this.dealerCardValue5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCardValue5.Name = "dealerCardValue5";
            this.dealerCardValue5.Size = new System.Drawing.Size(0, 28);
            this.dealerCardValue5.TabIndex = 6;
            this.dealerCardValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCardSuit5
            // 
            this.dealerCardSuit5.AccessibleDescription = "";
            this.dealerCardSuit5.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardSuit5.Location = new System.Drawing.Point(20, 29);
            this.dealerCardSuit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCardSuit5.Name = "dealerCardSuit5";
            this.dealerCardSuit5.Size = new System.Drawing.Size(38, 43);
            this.dealerCardSuit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardSuit5.TabIndex = 5;
            this.dealerCardSuit5.TabStop = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.BackColor = System.Drawing.Color.White;
            this.dealerCard4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerCard4.Controls.Add(this.dealerCardValue4);
            this.dealerCard4.Controls.Add(this.dealerCardSuit4);
            this.dealerCard4.Location = new System.Drawing.Point(319, 64);
            this.dealerCard4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(78, 100);
            this.dealerCard4.TabIndex = 9;
            this.dealerCard4.Visible = false;
            // 
            // dealerCardValue4
            // 
            this.dealerCardValue4.AutoSize = true;
            this.dealerCardValue4.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardValue4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerCardValue4.Location = new System.Drawing.Point(4, 3);
            this.dealerCardValue4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerCardValue4.Name = "dealerCardValue4";
            this.dealerCardValue4.Size = new System.Drawing.Size(0, 28);
            this.dealerCardValue4.TabIndex = 6;
            this.dealerCardValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealerCardSuit4
            // 
            this.dealerCardSuit4.AccessibleDescription = "";
            this.dealerCardSuit4.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardSuit4.Location = new System.Drawing.Point(20, 29);
            this.dealerCardSuit4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dealerCardSuit4.Name = "dealerCardSuit4";
            this.dealerCardSuit4.Size = new System.Drawing.Size(38, 43);
            this.dealerCardSuit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCardSuit4.TabIndex = 5;
            this.dealerCardSuit4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackColor = System.Drawing.Color.White;
            this.playerCard5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard5.Controls.Add(this.playerCardValue5);
            this.playerCard5.Controls.Add(this.playerCardSuit5);
            this.playerCard5.Location = new System.Drawing.Point(571, 341);
            this.playerCard5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(78, 100);
            this.playerCard5.TabIndex = 8;
            this.playerCard5.Visible = false;
            // 
            // playerCardValue5
            // 
            this.playerCardValue5.AutoSize = true;
            this.playerCardValue5.BackColor = System.Drawing.Color.Transparent;
            this.playerCardValue5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCardValue5.Location = new System.Drawing.Point(4, 3);
            this.playerCardValue5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCardValue5.Name = "playerCardValue5";
            this.playerCardValue5.Size = new System.Drawing.Size(0, 28);
            this.playerCardValue5.TabIndex = 6;
            this.playerCardValue5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCardSuit5
            // 
            this.playerCardSuit5.AccessibleDescription = "";
            this.playerCardSuit5.BackColor = System.Drawing.Color.Transparent;
            this.playerCardSuit5.Location = new System.Drawing.Point(20, 29);
            this.playerCardSuit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCardSuit5.Name = "playerCardSuit5";
            this.playerCardSuit5.Size = new System.Drawing.Size(38, 43);
            this.playerCardSuit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardSuit5.TabIndex = 5;
            this.playerCardSuit5.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.Color.White;
            this.playerCard4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard4.Controls.Add(this.playerCardValue4);
            this.playerCard4.Controls.Add(this.playerCardSuit4);
            this.playerCard4.Location = new System.Drawing.Point(487, 341);
            this.playerCard4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(78, 100);
            this.playerCard4.TabIndex = 9;
            this.playerCard4.Visible = false;
            // 
            // playerCardValue4
            // 
            this.playerCardValue4.AutoSize = true;
            this.playerCardValue4.BackColor = System.Drawing.Color.Transparent;
            this.playerCardValue4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerCardValue4.Location = new System.Drawing.Point(4, 3);
            this.playerCardValue4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCardValue4.Name = "playerCardValue4";
            this.playerCardValue4.Size = new System.Drawing.Size(0, 28);
            this.playerCardValue4.TabIndex = 6;
            this.playerCardValue4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCardSuit4
            // 
            this.playerCardSuit4.AccessibleDescription = "";
            this.playerCardSuit4.BackColor = System.Drawing.Color.Transparent;
            this.playerCardSuit4.Location = new System.Drawing.Point(20, 29);
            this.playerCardSuit4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerCardSuit4.Name = "playerCardSuit4";
            this.playerCardSuit4.Size = new System.Drawing.Size(38, 43);
            this.playerCardSuit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCardSuit4.TabIndex = 5;
            this.playerCardSuit4.TabStop = false;
            // 
            // stayButton
            // 
            this.stayButton.Enabled = false;
            this.stayButton.Location = new System.Drawing.Point(234, 220);
            this.stayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(78, 65);
            this.stayButton.TabIndex = 11;
            this.stayButton.Text = "STAY";
            this.stayButton.UseVisualStyleBackColor = true;
            this.stayButton.Click += new System.EventHandler(this.StayButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(398, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dealer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(398, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player";
            // 
            // newRoundButton
            // 
            this.newRoundButton.Enabled = false;
            this.newRoundButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newRoundButton.Location = new System.Drawing.Point(704, 222);
            this.newRoundButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(131, 59);
            this.newRoundButton.TabIndex = 15;
            this.newRoundButton.Text = "BET AND\r\nSTART NEW ROUND";
            this.newRoundButton.UseVisualStyleBackColor = true;
            this.newRoundButton.Click += new System.EventHandler(this.NewRoundButtonClick);
            // 
            // dealerTimer
            // 
            this.dealerTimer.Interval = 1000;
            this.dealerTimer.Tick += new System.EventHandler(this.DealerTimer_Tick);
            // 
            // playerTotalLabel
            // 
            this.playerTotalLabel.AutoSize = true;
            this.playerTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerTotalLabel.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerTotalLabel.ForeColor = System.Drawing.Color.Cyan;
            this.playerTotalLabel.Location = new System.Drawing.Point(420, 276);
            this.playerTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerTotalLabel.Name = "playerTotalLabel";
            this.playerTotalLabel.Size = new System.Drawing.Size(52, 62);
            this.playerTotalLabel.TabIndex = 16;
            this.playerTotalLabel.Text = "0";
            // 
            // dealerTotalLabel
            // 
            this.dealerTotalLabel.AutoSize = true;
            this.dealerTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerTotalLabel.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dealerTotalLabel.Location = new System.Drawing.Point(420, 167);
            this.dealerTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerTotalLabel.Name = "dealerTotalLabel";
            this.dealerTotalLabel.Size = new System.Drawing.Size(52, 62);
            this.dealerTotalLabel.TabIndex = 17;
            this.dealerTotalLabel.Text = "0";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.balanceLabel.Location = new System.Drawing.Point(493, 313);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(44, 18);
            this.balanceLabel.TabIndex = 19;
            this.balanceLabel.Text = "$000";
            // 
            // betButtonOne
            // 
            this.betButtonOne.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonOne.Location = new System.Drawing.Point(776, 367);
            this.betButtonOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonOne.Name = "betButtonOne";
            this.betButtonOne.Size = new System.Drawing.Size(75, 23);
            this.betButtonOne.TabIndex = 20;
            this.betButtonOne.Text = "$5";
            this.betButtonOne.UseVisualStyleBackColor = false;
            this.betButtonOne.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonTwo
            // 
            this.betButtonTwo.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonTwo.Location = new System.Drawing.Point(693, 396);
            this.betButtonTwo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonTwo.Name = "betButtonTwo";
            this.betButtonTwo.Size = new System.Drawing.Size(75, 23);
            this.betButtonTwo.TabIndex = 21;
            this.betButtonTwo.Text = "$10";
            this.betButtonTwo.UseVisualStyleBackColor = false;
            this.betButtonTwo.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonThree
            // 
            this.betButtonThree.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonThree.Location = new System.Drawing.Point(776, 396);
            this.betButtonThree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonThree.Name = "betButtonThree";
            this.betButtonThree.Size = new System.Drawing.Size(75, 23);
            this.betButtonThree.TabIndex = 22;
            this.betButtonThree.Text = "$25";
            this.betButtonThree.UseVisualStyleBackColor = false;
            this.betButtonThree.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonFour
            // 
            this.betButtonFour.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonFour.Location = new System.Drawing.Point(693, 425);
            this.betButtonFour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonFour.Name = "betButtonFour";
            this.betButtonFour.Size = new System.Drawing.Size(75, 23);
            this.betButtonFour.TabIndex = 23;
            this.betButtonFour.Text = "$50";
            this.betButtonFour.UseVisualStyleBackColor = false;
            this.betButtonFour.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonFive
            // 
            this.betButtonFive.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonFive.Location = new System.Drawing.Point(776, 425);
            this.betButtonFive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonFive.Name = "betButtonFive";
            this.betButtonFive.Size = new System.Drawing.Size(75, 23);
            this.betButtonFive.TabIndex = 24;
            this.betButtonFive.Text = "$100";
            this.betButtonFive.UseVisualStyleBackColor = false;
            this.betButtonFive.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonSix
            // 
            this.betButtonSix.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonSix.Location = new System.Drawing.Point(693, 454);
            this.betButtonSix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonSix.Name = "betButtonSix";
            this.betButtonSix.Size = new System.Drawing.Size(75, 23);
            this.betButtonSix.TabIndex = 25;
            this.betButtonSix.Text = "$250";
            this.betButtonSix.UseVisualStyleBackColor = false;
            this.betButtonSix.Click += new System.EventHandler(this.BetValueClick);
            // 
            // betButtonSeven
            // 
            this.betButtonSeven.BackColor = System.Drawing.Color.PaleGreen;
            this.betButtonSeven.Location = new System.Drawing.Point(776, 454);
            this.betButtonSeven.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.betButtonSeven.Name = "betButtonSeven";
            this.betButtonSeven.Size = new System.Drawing.Size(75, 23);
            this.betButtonSeven.TabIndex = 26;
            this.betButtonSeven.Text = "$500";
            this.betButtonSeven.UseVisualStyleBackColor = false;
            this.betButtonSeven.Click += new System.EventHandler(this.BetValueClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(493, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bet:";
            // 
            // currentBetLabel
            // 
            this.currentBetLabel.AutoSize = true;
            this.currentBetLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentBetLabel.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentBetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.currentBetLabel.Location = new System.Drawing.Point(493, 202);
            this.currentBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentBetLabel.Name = "currentBetLabel";
            this.currentBetLabel.Size = new System.Drawing.Size(26, 18);
            this.currentBetLabel.TabIndex = 28;
            this.currentBetLabel.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(493, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Balance:";
            // 
            // clearBetButton
            // 
            this.clearBetButton.ForeColor = System.Drawing.Color.Red;
            this.clearBetButton.Location = new System.Drawing.Point(693, 367);
            this.clearBetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearBetButton.Name = "clearBetButton";
            this.clearBetButton.Size = new System.Drawing.Size(75, 23);
            this.clearBetButton.TabIndex = 30;
            this.clearBetButton.Text = "Clear";
            this.clearBetButton.UseVisualStyleBackColor = true;
            this.clearBetButton.Click += new System.EventHandler(this.ClearBetClick);
            // 
            // allInButton
            // 
            this.allInButton.BackColor = System.Drawing.Color.Gold;
            this.allInButton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.allInButton.Location = new System.Drawing.Point(693, 338);
            this.allInButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allInButton.Name = "allInButton";
            this.allInButton.Size = new System.Drawing.Size(158, 23);
            this.allInButton.TabIndex = 31;
            this.allInButton.Text = "All In";
            this.allInButton.UseVisualStyleBackColor = false;
            this.allInButton.Click += new System.EventHandler(this.BetValueClick);
            // 
            // playerHandListLabel
            // 
            this.playerHandListLabel.AutoSize = true;
            this.playerHandListLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHandListLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerHandListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playerHandListLabel.Location = new System.Drawing.Point(53, 345);
            this.playerHandListLabel.Name = "playerHandListLabel";
            this.playerHandListLabel.Size = new System.Drawing.Size(113, 20);
            this.playerHandListLabel.TabIndex = 32;
            this.playerHandListLabel.Text = "Player Overflow";
            this.playerHandListLabel.Visible = false;
            // 
            // dealerHandListLabel
            // 
            this.dealerHandListLabel.AutoSize = true;
            this.dealerHandListLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerHandListLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dealerHandListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dealerHandListLabel.Location = new System.Drawing.Point(717, 140);
            this.dealerHandListLabel.Name = "dealerHandListLabel";
            this.dealerHandListLabel.Size = new System.Drawing.Size(117, 20);
            this.dealerHandListLabel.TabIndex = 33;
            this.dealerHandListLabel.Text = "Dealer Overflow";
            this.dealerHandListLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 255);
            this.label5.TabIndex = 34;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.tableMat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dealerHandListLabel);
            this.Controls.Add(this.playerHandListLabel);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.allInButton);
            this.Controls.Add(this.clearBetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.betButtonOne);
            this.Controls.Add(this.betButtonTwo);
            this.Controls.Add(this.betButtonThree);
            this.Controls.Add(this.currentBetLabel);
            this.Controls.Add(this.betButtonSeven);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betButtonFour);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.betButtonSix);
            this.Controls.Add(this.dealerTotalLabel);
            this.Controls.Add(this.betButtonFive);
            this.Controls.Add(this.playerTotalLabel);
            this.Controls.Add(this.newRoundButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hiddenCard);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.playerHandList);
            this.Controls.Add(this.dealerHandList);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.hitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "4";
            this.dealerCard1.ResumeLayout(false);
            this.dealerCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenCard)).EndInit();
            this.dealerCard2.ResumeLayout(false);
            this.dealerCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit2)).EndInit();
            this.playerCard1.ResumeLayout(false);
            this.playerCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit1)).EndInit();
            this.playerCard2.ResumeLayout(false);
            this.playerCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit2)).EndInit();
            this.playerCard3.ResumeLayout(false);
            this.playerCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit3)).EndInit();
            this.dealerCard3.ResumeLayout(false);
            this.dealerCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit3)).EndInit();
            this.dealerCard5.ResumeLayout(false);
            this.dealerCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit5)).EndInit();
            this.dealerCard4.ResumeLayout(false);
            this.dealerCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCardSuit4)).EndInit();
            this.playerCard5.ResumeLayout(false);
            this.playerCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit5)).EndInit();
            this.playerCard4.ResumeLayout(false);
            this.playerCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardSuit4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button hitButton;
        private Panel dealerCard1;
        private PictureBox dealerCardSuit1;
        private Label dealerCardValue1;
        private Panel dealerCard2;
        private Label dealerCardValue2;
        private PictureBox dealerCardSuit2;
        private Panel playerCard1;
        private Label playerCardValue1;
        private PictureBox playerCardSuit1;
        private Panel playerCard2;
        private Label playerCardValue2;
        private PictureBox playerCardSuit2;
        private Panel playerCard3;
        private Label playerCardValue3;
        private PictureBox playerCardSuit3;
        private Panel dealerCard3;
        private Label dealerCardValue3;
        private PictureBox dealerCardSuit3;
        private PictureBox hiddenCard;
        private RichTextBox dealerHandList;
        private RichTextBox playerHandList;
        private Panel dealerCard5;
        private Label dealerCardValue5;
        private PictureBox dealerCardSuit5;
        private Panel dealerCard4;
        private Label dealerCardValue4;
        private PictureBox dealerCardSuit4;
        private Panel playerCard5;
        private Label playerCardValue5;
        private PictureBox playerCardSuit5;
        private Panel playerCard4;
        private Label playerCardValue4;
        private PictureBox playerCardSuit4;
        private Button stayButton;
        private Label label1;
        private Label label2;
        private Button newRoundButton;
        private System.Windows.Forms.Timer dealerTimer;
        private Label playerTotalLabel;
        private Label dealerTotalLabel;
        private Label balanceLabel;
        private Button betButtonOne;
        private Button betButtonTwo;
        private Button betButtonThree;
        private Button betButtonFour;
        private Button betButtonFive;
        private Button betButtonSix;
        private Button betButtonSeven;
        private Label label3;
        private Label currentBetLabel;
        private Label label4;
        private Button clearBetButton;
        private Button allInButton;
        private Label playerHandListLabel;
        private Label dealerHandListLabel;
        private Label label5;
    }
}