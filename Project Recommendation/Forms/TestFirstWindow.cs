using DB_993.Resourse;

namespace design
{
    /// <summary>
    /// Класс используется для выбора (город, тип недвижимости и для чего) рекомендаций.
    /// </summary>
    public partial class TestFirstWindow : Form
    {
        string? Email { get; set; }
        public TestFirstWindow()
        {
            InitializeComponent();
            Design();

        }
        public TestFirstWindow(string email)
        {
            InitializeComponent();
            Design();
            Email = email;
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            label1.Parent = Picture7;
            label1.BackColor = Color.Transparent;
            Town.Parent = Picture7;
            Town.BackColor = Color.Transparent;
            TypeOfRealty.Parent = Picture7;
            TypeOfRealty.BackColor = Color.Transparent;
            Purpose.Parent = Picture7;
            Purpose.BackColor = Color.Transparent;
        }

        private void NextButtonButton_Click(object sender, EventArgs e)
        {
            if (TownCombo.Text == String.Empty && RealtyCombo.Text == String.Empty && PurposeCombo.Text == String.Empty)
            {
                MessageBox.Show(TestFirstWindowLocal.TestFirstWindowText);
                return;
            }
            TestSecondWindow testSecondWindow = new TestSecondWindow(TownCombo.Text, RealtyCombo.Text, PurposeCombo.Text, Email!);
            testSecondWindow.Show();

        }

        private void TestFirstWindow_Load(object sender, EventArgs e)
        {
            TownCombo.Items.Add(TestFirstWindowLocal.TownText1);
            TownCombo.Items.Add(TestFirstWindowLocal.TownText2);
            RealtyCombo.Items.Add(TestFirstWindowLocal.RealtyText1);
            RealtyCombo.Items.Add(TestFirstWindowLocal.RealtyText2);
            RealtyCombo.Items.Add(TestFirstWindowLocal.RealtyText3);
            PurposeCombo.Items.Add(TestFirstWindowLocal.PurposeText1);
            PurposeCombo.Items.Add(TestFirstWindowLocal.PurposeText2);
            PurposeCombo.Items.Add(TestFirstWindowLocal.PurposeText3);
        }
    }
}
