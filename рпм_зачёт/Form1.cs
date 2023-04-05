using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace рпм_зачёт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Событие определяет, является ли слово палиндромомом

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string thing = "";
            string d1 = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnmЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю";
            
            List<char> l = new List<char>();

            // Проверка - слово или нет
            string answer1 = Slovo(word, d1);

                    // Если строка является словом

                    if(answer1 == "да")
                    {
                        // Запись букв

                        for (int m = 0; m < word.Length; m++)
                        {
                            l.Add(word[m]);
                        }
                        l.Reverse();
                        for (int n = 0; n < word.Length; n++)
                        {
                            thing += l[n];
                        }

                // Если первое слово равно второму, слово является палиндромомом. Если нет - слово не является палиндромомом

                string w_l = word.ToLower();
                string t_l = thing.ToLower();

                if (w_l==t_l)
                        {
                            textBox1.Text = "Слово является палиндромомом";
                        }
                        else
                        {
                            textBox1.Text = "Слово не является палиндромомом";
                        }
                    }

                    // Строка не вляется словом

                    else
                     {
                        textBox1.Text = "Строка не является словом";
                     }
        }

        public string Slovo(string word, string d)
        {
            
            for (int i = 0; i < d.Length; i++)
            {
                for (int a = 0; a <word.Length; a++)
                {

                    if (d.Contains(word[a]) == false)
                    {
                        return "нет";
                    }
                }
            }
            return "да";
        }
    }
}
