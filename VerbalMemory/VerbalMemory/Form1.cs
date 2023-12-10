using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VerbalMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IWebDriver driver;
        bool Solving = false;
        List<string> Words = new List<string>();

        IWebElement SeenButton;
        IWebElement NewButton;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadWebPage_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://humanbenchmark.com/tests/verbal-memory");
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            int interval = int.Parse(numericUpDown1.Value.ToString());
            if (interval == 0)
                timer1.Interval = 1000;
            else
                timer1.Interval = int.Parse(numericUpDown1.Value.ToString());

            if (driver.FindElement(By.ClassName("e19owgy710")) != null)
            {
                driver.FindElement(By.ClassName("e19owgy710")).Click();
            }
            Thread.Sleep(100);
            SeenButton = driver.FindElement(By.XPath("//button[.='SEEN']"));
            NewButton = driver.FindElement(By.XPath("//button[.='NEW']"));
            Solving = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Solving)
            {
                string CurrentWord = driver.FindElement(By.ClassName("word")).Text;
                bool a = false;
                for (int i = 0; i < Words.Count; i++)
                {
                    if (Words[i] == CurrentWord)
                        a = true;
                }
                if (a)
                    SeenButton.Click();
                else
                {
                    Words.Add(CurrentWord);
                    NewButton.Click();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            driver.Quit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(numericUpDown1.Value.ToString());
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Solving = false;
        }
    }
}