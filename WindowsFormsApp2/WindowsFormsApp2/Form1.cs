using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btn5 : Form
    {


        string Num1;
        string Num2;
        string Operator;
        bool OperatorPressed = false;
        public bool reset = false;
        string text1;
        public bool isFloat = false;
        public bool num1pressed = false;
        public bool numpressed = false;




        public btn5()
        {
            InitializeComponent();
        }
        private void btn5_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {

                Num1 += "1";

            }
            else
            {
                Num2 += "1";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "2";

            }
            else
            {
                Num2 += "2";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "3";

            }
            else
            {
                Num2 += "3";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "4";

            }
            else
            {
                Num2 += "4";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "5";

            }
            else
            {
                Num2 += "5";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "6";

            }
            else
            {
                Num2 += "6";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "7";

            }
            else
            {
                Num2 += "7";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "8";

            }
            else
            {
                Num2 += "8";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "9";

            }
            else
            {
                Num2 += "9";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                Num1 += "0";

            }
            else
            {
                Num2 += "0";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            if (OperatorPressed == false)
            {
                isFloat = true;
                Num1 += ".";

            }
            else
            {
                Num2 += ".";
            }
            Display.Text = Num1 + Operator + Num2;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            Operator = "-";
            Display.Text = Num1 + Operator + Num2;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            Operator = "÷";
            Display.Text = Num1 + Operator + Num2;
        }

        private void AdditonBtn_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            Operator = "+";
            Display.Text = Num1 + Operator + Num2;
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            OperatorPressed = true;
            Operator = "x";
            Display.Text = Num1 + Operator + Num2;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Num1 = ' '.ToString();
            Num2 = ' '.ToString();
            OperatorPressed = false;
            Operator = ' '.ToString();
            Display.Text = Num1 + Operator + Num2;
            isFloat = false;
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            switch(Operator)
            {
                            case "+":
                                if (isFloat == true)
                                {
                                    double Float1 = float.Parse(Num1);
                                    double Float2 = float.Parse(Num2);
                                    double Ans = Float1 + Float2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
                                else
                                {
                                    double Int1 = double.Parse(Num1);
                                    double Int2 = double.Parse(Num2);
                                    double Ans = Int1 + Int2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
                        case "-":
                                if (isFloat == true)
                                {
                                    double Float1 = float.Parse(Num1);
                                    double Float2 = float.Parse(Num2);
                                    double Ans = Float1 - Float2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
                                else
                                {
                                    int Int1 = int.Parse(Num1);
                                    int Int2 = int.Parse(Num2);
                                    int Ans = Int1 - Int2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
            
                        case "x":
                                if (isFloat == true)
                                {
                                    double Float1 = float.Parse(Num1);
                                    double Float2 = float.Parse(Num2);
                                    double Ans = Float1 * Float2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
                                else
                                {
                                    double Int1 = double.Parse(Num1);
                                    double Int2 = double.Parse(Num2);
                                    double Ans = Int1 * Int2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;
                                }
                        case "÷": 
                                    double Float1 = float.Parse(Num1);
                                    double Float2 = float.Parse(Num2);
                                    double Ans = Float1 / Float2;
                                    Display.Text = Ans.ToString();
                                    Num1 = Ans.ToString();
                                    Num2 = ' '.ToString();
                                    OperatorPressed = false;
                                    Operator = ' '.ToString();
                                    Display.Text = Num1 + Operator + Num2;
                                    isFloat = false;



            }
        }
    }
}
