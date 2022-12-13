using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISCarwash
{
    public partial class CaptcherForm : Form
    {
         string text;
         private int countTry = 3;

         public CaptcherForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка введённой капчи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Click(object sender, EventArgs e)
        {
            if (text == textCaptcher.Text)
            {
                MessageBox.Show("Вы прошил проверку на бота", "Поздравляю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var form = new AutorizationForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            countTry--;
            counter.Text = "осталось попыток: " + countTry;
            if (countTry <= 0)
            {
                Blocked();
                countTry = 3;
                counter.Text = "осталось попыток: " + countTry;
            }
            textCaptcher.Text = "";
            pictureCaptcher.Image = this.CreateImage(pictureCaptcher.Width, pictureCaptcher.Height);
        }

        private void Blocked()
        {
            login.Enabled = false;
            reset.Enabled = false;
            textCaptcher.Enabled = false;
            Thread.Sleep(5000);
            login.Enabled = true;
            reset.Enabled = true;
            textCaptcher.Enabled = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            pictureCaptcher.Image = this.CreateImage(pictureCaptcher.Width, pictureCaptcher.Height);
            
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = Width / 8; // примерно по центру
            int Ypos = Height / 7;
            
            //Добавим различные цвета ддя текста
            Brush[] colors = {
                                Brushes.Black,
                                Brushes.Red,
                                Brushes.RoyalBlue,
                                Brushes.Green,
                                Brushes.Yellow,
                                Brushes.White,
                                Brushes.Tomato,
                                Brushes.Sienna,
                                Brushes.Pink };

            //Добавим различные цвета линий
            Pen[] colorpens = {
                                Pens.Black,
                                Pens.Red,
                                Pens.RoyalBlue,
                                Pens.Green,
                                Pens.Yellow,
                                Pens.White,
                                Pens.Tomato,
                                Pens.Sienna,
                                Pens.Pink };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = {
                                FontStyle.Bold,
                                FontStyle.Italic,
                                FontStyle.Regular,
                                FontStyle.Strikeout,
                                FontStyle.Underline};

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6, -7, 7};

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.LightBlue);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = String.Empty;
            string ALF = "1234567890qwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 7; ++i)
            {
                text += ALF[rnd.Next(ALF.Length)];
            }                

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
                colors[rnd.Next(colors.Length)],
                new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));

            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            
            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void CaptcherForm_Load(object sender, EventArgs e)
        {
            pictureCaptcher.Image = this.CreateImage(pictureCaptcher.Width, pictureCaptcher.Height);
        }
    }
}
