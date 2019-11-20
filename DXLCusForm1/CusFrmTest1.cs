using System;
using System.Drawing;
using DXLog.net;

namespace DXLog.net
{
    public partial class CusFrmTest1 : KForm
    {
        public static string CusWinName
        {
            get { return "Scenario panel"; }
        }

        public static int CusFormID
        {
            get { return 1011; }
        }

        private ContestData _cdata = null;
        private Font _windowFont = new Font("Courier New", 10, FontStyle.Regular);

        private FrmMain mainForm = null;

        private delegate void ScenarioSelectionChange(int newScenario);

        public CusFrmTest1()
        {
            InitializeComponent();
        }

        public CusFrmTest1(ContestData cdata)
        {
            InitializeComponent();
            ColorSetTypes = new string[] { "Background", "Color", "Header back color", "Header color", "Footer back color", "Footer color", "Final score color", "Selection back color", "Selection color" };
            DefaultColors = new Color[] { Color.Turquoise, Color.Black, Color.Gray, Color.Black, Color.Silver, Color.Black, Color.Blue, Color.SteelBlue, Color.White };
            _cdata = cdata;
            FormLayoutChangeEvent += new FormLayoutChange(handle_FormLayoutChangeEvent);
        }

        private void handle_FormLayoutChangeEvent()
        {
            InitializeLayout();
            update_display(mainForm.activeSO2RScenario);
        }

        public override void InitializeLayout()
        {
            InitializeLayout(_windowFont);
            if (FormLayout.FontName.Contains("Courier"))
                _windowFont = new Font(FormLayout.FontName, FormLayout.FontSize, FontStyle.Regular);
            else
                _windowFont = Helper.GetSpecialFont(FontStyle.Regular, FormLayout.FontSize);

            if (mainForm == null)
            {
                mainForm = (FrmMain)(ParentForm == null ? Owner : ParentForm);
                if (mainForm != null)
                {
                    _cdata.ScenarioSelectionChanged += new ContestData.ScenarioSelectionChange(update_display);
                    update_display(mainForm.activeSO2RScenario);
                }
            }
        }

        private void update_display(int scenario)
        {
            if (InvokeRequired)
            {
                ContestData.ScenarioSelectionChange d = new ContestData.ScenarioSelectionChange(update_display);
                Invoke(d, new object[] { scenario });
                return;
            }

            label1.Text = mainForm.so2rScenarios[0].ScenarioName.Trim();
            label2.Text = mainForm.so2rScenarios[1].ScenarioName.Trim();
            label3.Text = mainForm.so2rScenarios[2].ScenarioName.Trim();
            label4.Text = mainForm.so2rScenarios[3].ScenarioName.Trim();
            label5.Text = mainForm.so2rScenarios[4].ScenarioName.Trim();
            label6.Text = mainForm.so2rScenarios[5].ScenarioName.Trim();
            label7.Text = mainForm.so2rScenarios[6].ScenarioName.Trim();
            label8.Text = mainForm.so2rScenarios[7].ScenarioName.Trim();

            label1.BackColor = Color.Turquoise;
            label2.BackColor = Color.Turquoise;
            label3.BackColor = Color.Turquoise;
            label4.BackColor = Color.Turquoise;
            label5.BackColor = Color.Turquoise;
            label6.BackColor = Color.Turquoise;
            label7.BackColor = Color.Turquoise;
            label8.BackColor = Color.Turquoise;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;

            label1.Font = _windowFont;
            label2.Font = _windowFont;
            label3.Font = _windowFont;
            label4.Font = _windowFont;
            label5.Font = _windowFont;
            label6.Font = _windowFont;
            label7.Font = _windowFont;
            label8.Font = _windowFont;

            if (_cdata.OPTechnique == ContestData.Technique.SO2R_ADV)
            {
                switch (scenario + 1)
                {
                    case 1:
                        label1.BackColor = Color.Red;
                        label1.ForeColor = Color.Yellow;
                        break;
                    case 2:
                        label2.BackColor = Color.Red;
                        label2.ForeColor = Color.Yellow;
                        break;
                    case 3:
                        label3.BackColor = Color.Red;
                        label3.ForeColor = Color.Yellow;
                        break;
                    case 4:
                        label4.BackColor = Color.Red;
                        label4.ForeColor = Color.Yellow;
                        break;
                    case 5:
                        label5.BackColor = Color.Red;
                        label5.ForeColor = Color.Yellow;
                        break;
                    case 6:
                        label6.BackColor = Color.Red;
                        label6.ForeColor = Color.Yellow;
                        break;
                    case 7:
                        label7.BackColor = Color.Red;
                        label7.ForeColor = Color.Yellow;
                        break;
                    case 8:
                        label8.BackColor = Color.Red;
                        label8.ForeColor = Color.Yellow;
                        break;

                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(4);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(5);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(6);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(7);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(8);
        }
    }
}
