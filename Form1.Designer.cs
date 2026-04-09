namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rdoHamBurger = new RadioButton();
            lblAppName = new Label();
            chkPotato = new CheckBox();
            grpMenu = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            btnOrder = new Button();
            btnInit = new Button();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            grpOrder = new GroupBox();
            lstOrder = new ListBox();
            lblTotalCost = new Label();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            rdoHamBurger.ForeColor = Color.Indigo;
            rdoHamBurger.Location = new Point(21, 106);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(156, 51);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 31.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.RoyalBlue;
            lblAppName.Location = new Point(59, 48);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(788, 113);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            chkPotato.ForeColor = Color.Indigo;
            chkPotato.Location = new Point(29, 87);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(192, 51);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(59, 225);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(490, 620);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(242, 430);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(230, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(242, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            rdoChickenBurger.ForeColor = Color.Indigo;
            rdoChickenBurger.Location = new Point(21, 488);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(203, 51);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨 버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            rdoBulgogiBurger.ForeColor = Color.Indigo;
            rdoBulgogiBurger.Location = new Point(21, 297);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(226, 51);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Green;
            btnOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnOrder.ForeColor = Color.WhiteSmoke;
            btnOrder.Location = new Point(1015, 765);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 80);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            btnOrder.KeyDown += btnOrder_KeyDown;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnInit.ForeColor = Color.WhiteSmoke;
            btnInit.Location = new Point(1324, 765);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(200, 80);
            btnInit.TabIndex = 4;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            btnInit.KeyDown += btnInit_KeyDown;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(599, 225);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(352, 468);
            grpOption.TabIndex = 1;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            chkSauce.ForeColor = Color.Indigo;
            chkSauce.Location = new Point(29, 378);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(204, 51);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            chkCheese.ForeColor = Color.Indigo;
            chkCheese.Location = new Point(29, 281);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(204, 51);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold);
            chkCola.ForeColor = Color.Indigo;
            chkCola.Location = new Point(29, 184);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(122, 51);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(1015, 225);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(509, 518);
            grpOrder.TabIndex = 2;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 13.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.ForeColor = Color.DarkBlue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(35, 87);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(442, 333);
            lstOrder.TabIndex = 1;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.DarkBlue;
            lblTotalCost.Location = new Point(35, 439);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(263, 59);
            lblTotalCost.TabIndex = 0;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 929);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdoHamBurger;
        private Label lblAppName;
        private CheckBox chkPotato;
        private GroupBox grpMenu;
        private ListBox listBox1;
        private Button btnOrder;
        private Button btnInit;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private GroupBox grpOption;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox grpOrder;
        private ListBox lstOrder;
        private Label lblTotalCost;
    }
}
