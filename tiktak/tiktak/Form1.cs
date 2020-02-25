using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktak
{
    public partial class Form1 : Form
    {

        int win = 0;
        public int i = 0;
        public string[] player = new string[10] { "X", "O", "X", "O", "X", "O", "X", "O","X","O" };
        public string[,] board = new string[3,3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Press(b1,0,0);
        }


        public void Press(Button btnName, int y, int x)
        {

            

            btnName.Text = player[i];
            
            btnName.Enabled = false;


            board[y, x] = player[i];


            //-------------------Cheking Row--------------------//
            for (int j = 0; j<3; j++)
            {
                if (board[y,j ]== player[i])
                {
                    win++;
                }
            }



            if (win == 3)
            {
                MessageBox.Show(player[i] + " has won");
                Application.Exit();
            } else { win = 0; }
            //-------------------------------------------------//




            //-------------------Cheking Columb--------------------//
            for (int k=0; k<3; k++)
            {
                if (board[k, x] == player[i])
                {
                    win++;
                }
            }



            if (win == 3)
            {
                MessageBox.Show(player[i] + " has won");
                Application.Exit();
            }
            else { win = 0; }
            //-----------------------------------------------------//





            //--------------------Checking Diag--------------------//

            if (board[0,0]==player[i] && board[1, 1] == player[i] && board[2, 2] == player[i])
            {
                MessageBox.Show(player[i] + " has won");
                Application.Exit();
            }

            if (board[0, 2] == player[i] && board[1, 1] == player[i] && board[2, 0] == player[i])
            {
                MessageBox.Show(player[i] + " has won");
                Application.Exit();
            }


            //-----------------------------------------------------//

            i++;
        }

      

        

        private void button3_Click(object sender, EventArgs e)
        {
            Press(b2,0,1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Press(b3, 0, 2) ;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Press(b4,1,0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Press(b5,1,1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Press(b6,1,2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Press(b7,2,0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Press(b8,2,1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Press(b9,2,2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;

                if (item.Name == "btnReset")
                {
                    MessageBox.Show("done");
                    i = 0;
                    win = 0;
                    Array.Clear(board, 0, 3 * 3);

                } else { item.Text = ""; }

                
            }
        }
    }
}
