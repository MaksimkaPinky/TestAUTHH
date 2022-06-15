using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAUTHH
{
    public partial class Form1 : Form
    {
        Users usersrrole = new Users();
        
        public Form1()
        {
            InitializeComponent();
        }
        private string text = String.Empty;

        private void LogINButton_Click(object sender, EventArgs e)
        {
            if ((LoginTB.Text == "") || (PasswordTB.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            Users userauth =DataBaseContext.db.Users.Find(LoginTB.Text);
            if ((userauth != null) && (userauth.Password == PasswordTB.Text)&&(capctchTB.Text==text))
            {
                    usersrrole = userauth;
                    if (usersrrole.Role.Title == "Администратор")
                    {
                        MessageBox.Show("Зашел как администратор");
                    }
                    else if (usersrrole.Role.Title == "Менеджер")
                    {
                        MessageBox.Show("Зашел как менеджер");
                    }
                    else if (usersrrole.Role.Title == "Сотрудник")
                    {
                        MessageBox.Show("Зашел как сотрудник");
                    }
                    else
                    {
                        MessageBox.Show("Такой роли нет!");
                    }
            }
            else
            {
                
                capthPB.Visible = true;     
                capctchTB.Visible = true;
                capthPB.Image = this.CAPTCHA(capthPB.Width, capthPB.Height);
                timer1.Enabled = true;
                LogINButton.Enabled = false;
                LoginTB.Controls.Clear();
                PasswordTB.Controls.Clear();
            }
        }
        private Bitmap CAPTCHA(int Width,int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos=10;
            int Ypos =10;
            Brush[] colors = { Brushes.Black,Brushes.DarkGray, Brushes.AliceBlue };
            FontStyle[] fontStyles = { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular};
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
            Int16[] rotate = { 1,-1,2,-2,3,-3,4,-4,5,-5,6,-6};
            Graphics g = Graphics.FromImage((Image)result);
            g.RotateTransform(rnd.Next(rotate.Length));
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i=0; i < 4; i++)
                text+=ALF[rnd.Next(ALF.Length)];
            g.DrawString(text, new Font("Arial", 25, fontStyles[rnd.Next(fontStyles.Length)]), colors[rnd.Next(colors.Length)], new Point(Xpos, Ypos));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)], new Point(0, 0), new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)], new Point(0, Height - 1), new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LogINButton.Enabled = true;
            timer1.Enabled = false;

        }
    }
}