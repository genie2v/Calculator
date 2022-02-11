using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        private bool multiFn = false;
        private bool recordFn = false;
        private bool opFlag = false; // 연산자 입력 확인
        private bool conFlag = false; // =결과 후 숫자를 눌렀을 때 새연산이 시작하도록 확인
        private bool bracketFlag = false;
        private bool mathCon = false; // 두 수 연산시 연산자가 2개이상 오지 않도록 확인
        private double savedValue;
        private char op = '\0';

        // DB연결 정보
        private string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
                + "User Id=person1;password=person;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DB연결
            try
            {
                OracleConnection conn = new OracleConnection(strConn);

                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT SWITCH FROM CALCULATOR WHERE FNNAME ='multicalc'";
                OracleDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    multiFn = Convert.ToBoolean(rdr[0].ToString());
                }

                cmd.CommandText = "SELECT SWITCH FROM CALCULATOR WHERE FNNAME ='savecalc'";
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    recordFn = Convert.ToBoolean(rdr[0].ToString()); ;
                }
                conn.Close();
            }
            // DB 연결 실패시 두 수 연산만 가능
            catch (Exception ex)
            {
                MessageBox.Show("DB connection fail: " + ex.Message
                    + "\n 두 수 연산만 가능합니다.");
            }  
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (conFlag)
            {
                textExp.Text = "";

                textExp.Text += ((Button)sender).Text;
                labelResult.Text = ((Button)sender).Text;
                conFlag = false;
                mathCon = false;
                bracketFlag = false;
            }
            else if (labelResult.Text == "0" || opFlag)
            {
                labelResult.Text = ((Button)sender).Text;
                textExp.Text += ((Button)sender).Text;
                opFlag = false;
            }
            else
            {
                labelResult.Text = labelResult.Text + ((Button)sender).Text;
                textExp.Text += ((Button)sender).Text;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (labelResult.Text.Contains(".")) return;
            else
            {
                textExp.Text += ((Button)sender).Text;
                labelResult.Text += ((Button)sender).Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 두 수 연산
            if (!multiFn)
            {
                if (mathCon)
                {
                    MessageBox.Show("두 수 연산만 가능합니다.");
                }
                else
                {
                    savedValue = Double.Parse(labelResult.Text);
                    op = '+';
                    textExp.Text += ((Button)sender).Text;
                    opFlag = true;
                    mathCon = true;
                }
            }
            // 세 수 이상 연산
            else 
            {
                textExp.Text += ((Button)sender).Text;
                opFlag = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!multiFn)
            {
                if (mathCon)
                {
                    MessageBox.Show("두 수 연산만 가능합니다.");
                }
                else
                {
                    savedValue = Double.Parse(labelResult.Text);
                    op = '-';
                    textExp.Text += ((Button)sender).Text;
                    opFlag = true;
                    mathCon = true;
                }
            }
            else
            {
                textExp.Text += ((Button)sender).Text;
                opFlag = true;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (!multiFn)
            {
                if (mathCon)
                {
                    MessageBox.Show("두 수 연산만 가능합니다.");
                }
                else
                {
                    savedValue = Double.Parse(labelResult.Text);
                    op = '*';
                    textExp.Text += ((Button)sender).Text;
                    opFlag = true;
                    mathCon = true;
                }
            }
            else
            {
                textExp.Text += ((Button)sender).Text;
                opFlag = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!multiFn)
            {
                if (mathCon)
                {
                    MessageBox.Show("두 수 연산만 가능합니다.");
                }
                else
                {
                    savedValue = Double.Parse(labelResult.Text);
                    op = '/';
                    textExp.Text += ((Button)sender).Text;
                    opFlag = true;
                    mathCon = true;
                }
            }
            else
            {
                textExp.Text += ((Button)sender).Text;
                opFlag = true;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (mathCon) return;
            if (bracketFlag) 
            { 
                textExp.Text = ""; 
                labelResult.Text = "0"; 
                conFlag = false;
                bracketFlag = false;
            }
            textExp.Text += ((Button)sender).Text;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            textExp.Text += ((Button)sender).Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textExp.Text = "";
            labelResult.Text = "0";
            mathCon = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != "0" && labelResult.Text.Length > 0)
            {
                labelResult.Text = labelResult.Text.Remove(labelResult.Text.Length - 1);
                textExp.Text = textExp.Text.Remove(textExp.Text.Length - 1);
                if (labelResult.Text.Length == 0) labelResult.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!multiFn)
            {
                Double x = Double.Parse(labelResult.Text);
                switch (op)
                { 
                    case '+':
                        labelResult.Text = (savedValue + x).ToString();
                        break;
                    case '-':
                        labelResult.Text = (savedValue - x).ToString();
                        break;
                    case '*':
                        labelResult.Text = (savedValue * x).ToString();
                        break;
                    case '/':
                        labelResult.Text = (savedValue / x).ToString();
                        break;
                }

                mathCon = false;
                conFlag = true;
                bracketFlag = true;

                if (recordFn)
                {
                    OracleConnection conn = new OracleConnection(strConn);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO CALCRECORD(CALCTIME, EXP, RESULT, ID) "
                        + "VALUES (SYSDATE,'" + textExp.Text + "','" + labelResult.Text + "', calc_seq.NEXTVAL)";
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
            else
            {
                Calculator calc = new Calculator(textExp.Text);
                labelResult.Text = calc.getRst().ToString();
                conFlag = true;
                bracketFlag = true;
                
                if (recordFn)
                {
                    OracleConnection conn = new OracleConnection(strConn);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "INSERT INTO CALCRECORD(CALCTIME, EXP, RESULT, ID) "
                        + "VALUES (SYSDATE,'" + textExp.Text + "','" + labelResult.Text + "', calc_seq.NEXTVAL)";
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        private void newForm_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
    }

    // 후위표기법계산(괄호, 연산자 우선순위 계산을 위해, 세 수 이상의 연산)
    public class Calculator
    {
        String mathExp;

        public Calculator(String _mathExp)
        {
            mathExp = _mathExp;
            if (mathExp == "") mathExp = "0";
        }

        public double getRst()
        {
            Stack<double> st = new Stack<double>();
            foreach (string s in infix_to_postfix(ReadSpliter()))
            {
                if (s.Equals("+") || s.Equals("-") || s.Equals("×") || s.Equals("÷"))
                    st.Push(calc(s, st.Pop(), st.Pop()));
                else
                    st.Push(Double.Parse(s));
            }
            return st.Pop();
        }

        // 우선순위
        int prec(string op)
        {
            switch (op)
            {
                case "(":
                case ")": return 0;
                case "+":
                case "-": return 1;
                case "×":
                case "÷": return 2;
            }
            return -1;
        }

        // 후위표기법으로 변환
        List<String> infix_to_postfix(List<String> str)
        {
            List<String> postfix = new List<string>();
            Stack<String> oper = new Stack<string>();

            String ch, top_op;

            foreach (String s in str)
            {
                ch = s;

                switch (ch)
                { 
                    case "+":
                    case "-":
                    case "×":
                    case "÷":
                        while (oper.Count != 0 && (prec(ch) <= prec(oper.Peek())))
                        {
                            postfix.Add(oper.Pop());
                        }
                        oper.Push(ch);
                        break;
                    case "(":
                        oper.Push(ch);
                        break;
                    case ")":
                        top_op = oper.Pop();

                        while (top_op != "(")
                        {
                            postfix.Add(top_op);
                            top_op = oper.Pop();
                        }
                        break;
                    default:
                        postfix.Add(ch);
                        break;
                }
            }

            while (oper.Count != 0)
            {
                postfix.Add(oper.Pop());
            }
            return postfix;
        }

        List<String> ReadSpliter()
        {
            List<String> list_str = new List<string>();

            String temp = ""; 
            bool isNum = false;
            foreach(char c in mathExp.ToCharArray())
            {
                if ((c >= '0' && c <= '9') || c == '.')
                {
                    temp += c;
                    isNum = true;
                }
                else if (temp == "" && c == '-')
                {
                    temp = "-";
                    isNum = true;
                }
                else 
                {
                    if (isNum)
                        list_str.Add(temp);
                    list_str.Add("" + c);
                    isNum = false;
                    temp = "";
                }
            }

            if (temp != "")
                list_str.Add(temp);

            return list_str;
        }

        double calc(string oprtr, double a, double b)
        {
            switch (oprtr)
            { 
                case "+":
                    return b + a;
                case "-":
                    return b - a;
                case "×":
                    return b * a;
                case "÷":
                    return b / a;
            }
            return 0;
        }
    }
}
