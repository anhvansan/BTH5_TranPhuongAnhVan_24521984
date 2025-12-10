namespace Bai07
{
    public partial class Form1 : Form
    {
        private bool[,] segments = new bool[,]
        {
        {true, true, true, true, true, true, false}, // 0
        {false, true, true, false, false, false, false}, // 1
        {true, true, false, true, true, false, true}, // 2
        {true, true, true, true, false, false, true}, // 3
        {false, true, true, false, false, true, true}, // 4
        {true, false, true, true, false, true, true}, // 5
        {true, false, true, true, true, true, true}, // 6
        {true, true, true, false, false, false, false}, // 7
        {true, true, true, true, true, true, true}, // 8
        {true, true, true, true, false, true, true}  // 9
        };
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDateTime()
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
    }
}
