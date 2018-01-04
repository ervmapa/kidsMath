using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Collections.Generic;

namespace WindowsFormsApp4
{
    public partial class MainForm : Form
    {
        Expression exp;
        Color color = Color.LightYellow;
        Color colorSelected = Color.White;
        Random random = new Random();
        int questionNumber;
        int correct = 0;
        int numberOfQuestions;
        int level;
        List<Operator> operatorList;
        SoundPlayer soundPlayerOk;
        SoundPlayer soundPlayerFail;
        ExpressionFactory expressionFactory;
        Stream okSound;
        Stream failSound;
        Assembly assembly = Assembly.GetExecutingAssembly();



        public MainForm(int numberOfQuestions, int level, List<Operator> operatorList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.operatorList = operatorList;

            this.numberOfQuestions = numberOfQuestions;
            this.level = level;
            progressBar1.Maximum = numberOfQuestions;
            expressionFactory = new ExpressionFactory();

            txtX.KeyDown += new KeyEventHandler(tb_KeyDown);
            txtY.KeyDown += new KeyEventHandler(tb_KeyDown);
            txtZ.KeyDown += new KeyEventHandler(tb_KeyDown);

            okSound = assembly.GetManifestResourceStream("WindowsFormsApp4.ok.wav");
            failSound = assembly.GetManifestResourceStream("WindowsFormsApp4.fail.wav");
            soundPlayerOk = new SoundPlayer(okSound);

            soundPlayerFail = new SoundPlayer(failSound);


            NewExpression();

        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (CheckResult())
                {
                    progressBar1.Increment(1);
                    NewExpression();
                }

                if (correct == numberOfQuestions)
                {
                    ScoreForm scoreform = new ScoreForm();
                    this.Hide();
                    scoreform.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }

            }
        }


        public void setDefaultColors(Color color)
        {
            this.BackColor = color;

            txtX.Enabled = false;
            txtY.Enabled = false;
            txtZ.Enabled = false;

            txtX.BackColor = color;
            txtY.BackColor = color;
            txtZ.BackColor = color;

            txtX.BorderStyle = BorderStyle.None;
            txtY.BorderStyle = BorderStyle.None;
            txtZ.BorderStyle = BorderStyle.None;
        }




        Boolean CheckResult()
        {
            if (txtX.Text.ToString().Trim() == exp.Xval.ToString().Trim() 
                && txtY.Text == exp.Yval.ToString().Trim() 
                && txtZ.Text.ToString().Trim() == exp.Zval.ToString())
            {
                soundPlayerOk.Play();
                correct++;
                return true;
            }
            else
            {
                soundPlayerFail.Play();
                return false;
            }


        }

        public void NewExpression()
        {
            questionNumber++;
            groupBox.Text = "Fråga " + questionNumber + "/" + numberOfQuestions;

            // Create a random operator
            Operator randop = operatorList[random.Next(operatorList.Count)];
            exp = expressionFactory.GetExpression(randop);
            exp.Set_level(this.level);
            setDefaultColors(exp.Color);
          


            // Randomize mode (if user should find X Y or Z)
            exp.SetMode((GameMode)random.Next(0, 3), Granularity.ONE);

            lblOperator.Text = exp.OperatorSymbol;

            if (exp.Mode == GameMode.FIND_Z_TERM)
            {

                txtX.Text = exp.Xval.ToString();
                txtY.Text = exp.Yval.ToString();

                txtZ.Enabled = true;
                txtZ.BackColor = colorSelected;
                txtZ.BorderStyle = BorderStyle.Fixed3D;
                txtZ.Text = String.Empty;
              
                txtZ.Focus();
            }
            else if (exp.Mode == GameMode.FIND_X_TERM)
            {
                txtZ.Text = exp.Zval.ToString();
                txtY.Text = exp.Yval.ToString();
                txtX.Enabled = true;
                txtX.BackColor = colorSelected;
                txtX.BorderStyle = BorderStyle.Fixed3D;
                txtX.Text = String.Empty;
               
                txtX.Focus();

            }
            else if (exp.Mode == GameMode.FIND_Y_TERM)
            {
                txtZ.Text = exp.Zval.ToString();
                txtX.Text = exp.Xval.ToString();

                txtY.Enabled = true;
                txtY.BackColor = colorSelected;
                txtY.BorderStyle = BorderStyle.Fixed3D;
                txtY.Text = String.Empty;
             
                txtY.Focus();
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            NewExpression();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}
