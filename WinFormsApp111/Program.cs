using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            readonly Dictionary <char, string> codeMorse = new Dictionary<char, string>()
            {
                ['А'] = "*-",
                ['Б'] = "-***",
                ['В'] = "*--",
                ['Г'] = "--*",
                ['Д'] = "-**",
                ['Е'] = "*",
                ['Ж'] = "***-",
                ['З'] = "--**",
                ['И'] = "**",
                ['Й'] = "*---",
                ['К'] = "-*-",
                ['Л'] = "*-**",
                ['М'] = "--",
                ['Н'] = "-*",
                ['О'] = "---",
                ['П'] = "*--*",
                ['Р'] = "*-*",
                ['С'] = "***",
                ['Т'] = "-",
                ['У'] = "**-",
                ['Ф'] = "**-*",
                ['Х'] = "****",
                ['Ц'] = "-*-*",
                ['Ч'] = "---*",
                ['Ш'] = "----",
                ['Щ'] = "--*-",
                ['Ы'] = "-*--",
                ['Ь'] = "-**-",
                ['Э'] = "**-**",
                ['Ю'] = "**--",
                ['Я'] = "*-*-",
                ['1'] = "*----",
                ['2'] = "**---",
                ['3'] = "***--",
                ['4'] = "****-",
                ['5'] = "*****",
                ['6'] = "-****",
                ['7'] = "--***",
                ['8'] = "---**",
                ['9'] = "----*",
                ['0'] = "-----",

            };
           
            /*
            void convertToDictionary ()
            {
                char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

                string[] codeMorsesy = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−-−−*", "−−−−−" };

                for (int i = 0; i < codeMorsesy.Length; i++)
                {
                    Console.WriteLine("['" + characters[i] + "'] =" + '"' + codeMorsesy[i] + '"' + ",");
                }

            }
		чтобы не вписывать вручную, используем два массива для переноса в словарь
            */
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToUpper();
            char[] tempWord = input.ToCharArray();
            string output = "";
            foreach (var c in tempWord)
            {
                foreach (var item in codeMorse)
                {
                    if (c == item.Key)
                    {
                        output += item.Value + " ";
                    }
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }
           

        private void button2_Click(object sender, EventArgs e)
        {
            var input1 = textBox3.Text;
            string[] tempWord1 = input1.Split();
            string output1 = "";
            foreach (var s in tempWord1)
            {
                foreach (var item1 in codeMorse)
                {
                    if (s == item1.Value)
                    {
                        output1 += item1.Key + " ";
                    }
                }
            }
            output1 = output1.Remove(output1.Length -1);
            textBox4.Text = output1;
        }
            

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    }
}
