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

            readonly Dictionary <char, string> codeMorseSymbol = new Dictionary<char, string>()
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
                ['&'] = "*−***",
                ['$'] = "***−**−",
                ['@'] = "*−−*−*",
                ['/'] = "−**−*",
                ['_'] = "**−−*−",
                ['='] = "−***−",
                ['+'] = "*−*−*",
                ['—'] = "−****−",
                [':'] = "−−−***",
                [';'] = "−*−*−*",
                ['"'] = "*−**−*",
                ['?'] = "**−−**",
                ['!'] = "−−**−−",
                [','] = "*−*−*−",
                ['.'] = "******",

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
        private void EncryptButton (object sender, EventArgs e)
        {
            
                try
                {
                    string input = textBox1.Text;
                    input = input.ToUpper();
                    char[] tempWord = input.ToCharArray();
                    string output = "";
                    foreach (var c in tempWord)
                    {
                        foreach (var item in codeMorseSymbol)
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

                catch (Exception)
                {
                   MessageBox.Show("Азбука Морзе не поддерживает английский алфавит (пока что)");
                }
        }

        private void DecryptButton (object sender, EventArgs e)
        {

                try
                {
                   var input1 = textBox3.Text;
                   string[] tempWord1 = input1.Split();
                   string output1 = "";

                    foreach (var s in tempWord1)
                    {
                        foreach (var item1 in codeMorseSymbol)
                        {
                            if (s == item1.Value)
                            {
                                output1 += item1.Key + " ";
                            }
                        }
                    }
                   output1 = output1.Remove(output1.Length - 1);
                   textBox4.Text = output1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите символы полученные после шифрования слова");
                }

        }

        private void ResetAllButton(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void ResetEncryptButton(object sender, System.EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void ResetDecryptButton(object sender, System.EventArgs e)
        {
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void CopyToDecrypt(object sender, System.EventArgs e)
        {
            var temp = textBox2.Text;
            textBox3.Text = temp;
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
