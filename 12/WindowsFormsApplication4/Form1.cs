using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            InitFormAndModel();
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            switch (button.Text)
            {
                case "Запустить":
                    Run();
                    break;
                case "Продолжить":
                    Continue();
                    break;
                case "Пауза":
                    Pause();
                    break;
            }     
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            model.NextTick();
            UpdateForm();
        }

        private void InitFormAndModel()
        {
            model.Init();

            UpdateForm();
        }

        private void UpdateForm()
        {
            WeatherLabel.Text = $"Погода сейчас: {GetLabel(model.states[model.states.Count - 2])}";

            var time = (int)Math.Ceiling(model.t * 10);
            TimeLabel.Text = $"Время: {time / 100}.{time % 100} дней";

            var str = new StringBuilder("История:");
            for (int i = model.states.Count - 3; i >= Math.Max(0, model.states.Count - 8); --i)
            {
                time = (int)Math.Ceiling(model.times[i] * 10);
                str.Append($" {{ {GetLabel(model.states[i])}, {time / 100}.{time % 100} }}");
            }
            HistoryLabel.Text = str.ToString();

            FineLabel.Text = $"% ясных дней = {(100 * model.stateTimes[0] / model.times[model.times.Count - 1]).ToString("f1")} (теоретически 38%)";
            CloudyLabel.Text = $"% облачных дней = {(100 * model.stateTimes[1] / model.times[model.times.Count - 1]).ToString("f1")} (теоретически 30%)";
            RainyLabel.Text = $"% пасмурных дней = {(100 * model.stateTimes[2] / model.times[model.times.Count - 1]).ToString("f1")} (теоретически 32%)";
        }

        private string GetLabel(WeatherState state)
        {
            switch (state)
            {
                case WeatherState.Fine: return "ясно";
                case WeatherState.Cloudy: return "облачно";
                case WeatherState.Rainy: return "пасмурно";
            }

            return "";
        }

        private void Run()
        {
            InitFormAndModel();
            LaunchBtn.Text = "Пауза";
            StopBtn.Enabled = true;
            Timer.Enabled = true;
        }

        private void Pause()
        {
            LaunchBtn.Text = "Продолжить";
            Timer.Enabled = false;
        }

        private void Continue()
        {
            LaunchBtn.Text = "Пауза";
            Timer.Enabled = true;
        }

        private void Stop()
        {
            LaunchBtn.Text = "Запустить";
            StopBtn.Enabled = false;
            Timer.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;

            switch (trackBar.Value)
            {
                case 0:
                    model.dt = 0.25;
                    break;
                case 1:
                    model.dt = 0.5;
                    break;
                case 2:
                    model.dt = 1;
                    break;
                case 3:
                    model.dt = 4;
                    break;
                case 4:
                    model.dt = 16;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
