namespace GUITask
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }

        private void SolveButton1_Click(object sender, EventArgs e)
        {
            string timeStart = this.timeStartInput.Text;
            string timeEnd = this.timeEndInput.Text;
            string time = this.timeInput.Text;

            try
            {
                bool result = TrainLogic.CheckTime(timeStart, timeEnd, time);
                timeResult.Text = TrainLogic.ResultToText(result);
            }
            catch (Exception ex)
            {
                timeResult.Text = ex.Message;
            }
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            this.timeStartInput.Clear();
            this.timeEndInput.Clear();
            this.timeInput.Clear();
            OnTrainInputDataChanged(sender, e);
        }

        private void OnTrainInputDataChanged(object sender, EventArgs e)
        {
            timeResult.Text = "";
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поезд прибывает на станцию в a часов b минут и отправляется в c часов d минут. Пассажир пришел на платформу в n часов m минут. Будет ли поезд стоять на платформе?\nЧисла a, b, c, d, n, m — целые, 0 < a 23, 0 < b 59, 0 < c 23, 0 < d 59, 0 < n 23, 0 < m 59", "Задача");
        }

        private void SolveButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(aInput.Text);
                int b = Convert.ToInt32(bInput.Text);
                Squares answer = SquaresLogic.GetSquares(a, b);

                squaresListLabel.Text = answer.squaresStr;
                squaresAnswer.Text = $"Итого: {answer.count} квадратов";
            }
            catch(Exception ex)
            {
                squaresAnswer.Text = ex.Message;
            }
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            aInput.Clear();
            bInput.Clear();
            OnSquaresInputDataChanged(sender, e);   
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дан прямоугольник с размерами a x b. От него отрезают квадраты максимального размера, пока это возможно. Затем от оставшегося прямоугольника вновь отрезают квадраты максимально возможного размера и т. д. \nНа какие квадраты и в каком их количестве будет разрезан исходный прямоугольник?", "Задача");
        }

        private void OnSquaresInputDataChanged(object sender, EventArgs e)
        {
            squaresListLabel.Text = "";
            squaresAnswer.Text = "";
        }

        public class TrainLogic
        {
            public static bool CheckTime(string timeStart, string timeEnd, string time)
            {
                int hoursStart, minutesStart, hoursEnd, minutesEnd, hours, minutes;
                hoursStart = int.Parse(timeStart.Split(':')[0]);
                minutesStart = int.Parse(timeStart.Split(':')[1]);
                hoursEnd = int.Parse(timeEnd.Split(':')[0]);
                minutesEnd = int.Parse(timeEnd.Split(':')[1]);
                hours = int.Parse(time.Split(':')[0]);
                minutes = int.Parse(time.Split(':')[1]);

                bool isTrainStopped;

                if (hoursStart == hoursEnd)
                {
                    isTrainStopped = (hours == hoursStart && minutes >= minutesStart && minutes < minutesEnd);
                }
                else
                {
                    if (hours == hoursStart)
                        isTrainStopped = (minutes >= minutesStart);
                    else if (hours == hoursEnd)
                        isTrainStopped = (minutes < minutesEnd);
                    else
                        isTrainStopped = (hours > hoursStart && hours < hoursEnd);
                }

                return isTrainStopped;
            }

            public static string ResultToText(bool isTrainStopped)
            {
                if (isTrainStopped)
                    return "Поезд ещё стоит на платформе";
                else
                    return "Поезда нет на платформе";
            }
        }

        public struct Squares
        {
            public int count;
            public string squaresStr;
        }

        public class SquaresLogic
        {
            public static Squares GetSquares(int a, int b)
            {
                Squares answ = new Squares();

                while (a != 0 && b != 0)
                {
                    if (a >= b)
                    {
                        a -= b;
                        answ.squaresStr += $"{b} x {b}\n";
                    }
                    else
                    {
                        b -= a;
                        answ.squaresStr += $"{a} x {a}\n";
                    }
                    answ.count++;
                }

                return answ;
            }
        }

        private void Train_Load(object sender, EventArgs e)
        {

        }
    }
}
