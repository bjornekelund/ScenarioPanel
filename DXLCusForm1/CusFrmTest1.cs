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
        
        //private ContestData _cdata = null;
        private Font _windowFont = new Font("Courier New", 10, FontStyle.Regular);

        private FrmMain mainForm = null;

        private delegate void newQsoSaved(DXQSO qso);

        public CusFrmTest1()
        {
            InitializeComponent();
        }

        public CusFrmTest1(ContestData cdata)
        {
            InitializeComponent();
            ColorSetTypes = new string[] { "Background", "Color", "Header back color", "Header color", "Footer back color", "Footer color", "Final score color", "Selection back color", "Selection color" };
            DefaultColors = new Color[] { Color.Turquoise, Color.Black, Color.Gray, Color.Black, Color.Silver, Color.Black, Color.Blue, Color.SteelBlue, Color.White };
            //_cdata = cdata;
            FormLayoutChangeEvent += new FormLayoutChange(handle_FormLayoutChangeEvent);
        }

        private void handle_FormLayoutChangeEvent()
        {
            InitializeLayout();
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
                    label1.Text = mainForm.so2rScenarios[0].ScenarioName.Trim();
                    label2.Text = mainForm.so2rScenarios[1].ScenarioName.Trim();
                    label3.Text = mainForm.so2rScenarios[2].ScenarioName.Trim();
                    label4.Text = mainForm.so2rScenarios[3].ScenarioName.Trim();
                    label5.Text = mainForm.so2rScenarios[4].ScenarioName.Trim();
                    label6.Text = mainForm.so2rScenarios[5].ScenarioName.Trim();
                    label7.Text = mainForm.so2rScenarios[6].ScenarioName.Trim();
                    label8.Text = mainForm.so2rScenarios[7].ScenarioName.Trim();
                }
            }
        }

        //private void mainForm_NewQSOSaved(DXQSO newQso)
        //{
        //    if (InvokeRequired)
        //    {
        //        newQsoSaved d = new newQsoSaved(mainForm_NewQSOSaved);
        //        Invoke(d, new object[] { newQso });
        //        return;
        //    }

        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("New QSO is saved."); 
        //    sb.AppendLine(string.Format("QSO time: {0}", newQso.QSOTime.ToString("dd.MM.yyyy HH:mm:ss")));
        //    sb.AppendLine(string.Format("Call worked: {0}", newQso.Callsign));
        //    sb.AppendLine();
        //    sb.AppendLine(string.Format("Your current score is: {0} points!", _cdata.GetFinalScore().ToString("### ### ##0")));
        //    lbInfo.Text = sb.ToString();
        //}

        private void label1_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(2);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(4);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(5);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(6);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mainForm.SelectSO2RScenario(7);
        }
    }
}
