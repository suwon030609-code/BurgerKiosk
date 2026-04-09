namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoHamBurger.TabStop = true; // 아무것도 선택 안 되었을 때 탭 포커스 진입 허용
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;

            // 1. 탭 이동 시 자동 선택 방지
            rdoHamBurger.AutoCheck = false;
            rdoBulgogiBurger.AutoCheck = false;
            rdoChickenBurger.AutoCheck = false;

            // 2. 스페이스바 또는 클릭 시 동작할 이벤트 연결
            rdoHamBurger.Click += RdoMenu_Click;
            rdoBulgogiBurger.Click += RdoMenu_Click;
            rdoChickenBurger.Click += RdoMenu_Click;

            // 스페이스바 전용 키보드 이벤트
            rdoHamBurger.KeyDown += RdoMenu_KeyDown;
            rdoBulgogiBurger.KeyDown += RdoMenu_KeyDown;
            rdoChickenBurger.KeyDown += RdoMenu_KeyDown;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // 폼이 화면에 표시된 직후 자동으로 첫 번째 라디오 버튼이 선택되는 윈도우 기본 동작 무효화
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
        }

        private void RdoMenu_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && sender is RadioButton rdo)
            {
                rdoHamBurger.Checked = false;
                rdoBulgogiBurger.Checked = false;
                rdoChickenBurger.Checked = false;
                rdo.Checked = true;
            }
        }

        private void RdoMenu_Click(object? sender, EventArgs e)
        {
            // 다른 라디오 버튼의 선택을 모두 해제하고
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 현재 이벤트가 발생한(선택한) 라디오 버튼만 체크합니다.
            if (sender is RadioButton rdo)
            {
                rdo.Checked = true;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {


            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lstOrder.Items.Clear();
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메뉴를 선택하세요.";
                return;
            }

            int totalCost = 0;

            lstOrder.Items.Clear();

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            lblTotalCost.Text = $"총 금액: {totalCost:N0}원";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            rdoHamBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();

            lblTotalCost.Visible = true;
            lblTotalCost.ForeColor = Color.DarkBlue;
            lblTotalCost.Text = "총 금액: 0원";
        }

        private void btnOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button btn = (Button)sender;
                btn.PerformClick();
            }
        }

        private void btnInit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button btn = (Button)sender;
                btn.PerformClick();
            }
        }
    }
}
