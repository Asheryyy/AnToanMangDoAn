using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayFair
{


    public partial class frmPf : Form
    {
        char[,] keyMatrix = new char[5, 5];
        bool[] used = new bool[26];
        char[,] alphab =
        {
    {'A','B','C','D','E'},
    {'F','G','H','I','K'},
    {'L','M','N','O','P'},
    {'Q','R','S','T','U'},
    {'V','W','X','Y','Z'}
    };
        public frmPf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPf_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPublicKey_TextChanged(object sender, EventArgs e)
        {

        }

        void findPosition(char c, out int row, out int col)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (keyMatrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
            row = -1;
            col = -1;
        }
        void EncryptPair(char a, char b, StringBuilder ciphertext)
        {
            int rowA, colA, rowB, colB;
            findPosition(a, out rowA, out colA);
            findPosition(b, out rowB, out colB);
            if (rowA == rowB)
            {
                ciphertext.Append(keyMatrix[rowA, (colA + 1) % 5]);
                ciphertext.Append(keyMatrix[rowB, (colB + 1) % 5]);
            }
            else if (colA == colB)
            {
                ciphertext.Append(keyMatrix[(rowA + 1) % 5, colA]);
                ciphertext.Append(keyMatrix[(rowB + 1) % 5, colB]);
            }
            else
            {
                ciphertext.Append(keyMatrix[rowA, colB]);
                ciphertext.Append(keyMatrix[rowB, colA]);
            }
        }
        StringBuilder Encrypt(string plaintext)
        {
            StringBuilder ciphertext = new StringBuilder();
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char a = plaintext[i];
                char b = (i + 1 < plaintext.Length) ? plaintext[i + 1] : 'X';
                if (a == b) b = 'X';
                EncryptPair(a, b, ciphertext);
            }
            return ciphertext;
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (!used[0])
            {
                MessageBox.Show("Vui lòng nhập khóa trước khi mã hóa!");
                return;
            }
            else if (txtInput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập văn bản cần mã hóa!");
                return;
            }
            else
            {
                string plaintext = txtInput.Text.ToUpper().Replace(" ", "").Replace("J", "I");
                StringBuilder ciphertext = new StringBuilder();
                ciphertext = Encrypt(plaintext);
                txtOutput.Text = ciphertext.ToString();
            }
        }

        void generateKeyMatrix(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                char c = key[i];
                if (c == 'J') c = 'I';
                if (!used[c - 'A'])
                {
                    keyMatrix[index / 5, index % 5] = c;
                    used[c - 'A'] = true;
                    index++;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (!used[i] && (char)(i + 'A') != 'J')
                {
                    keyMatrix[index / 5, index % 5] = (char)(i + 'A');
                    used[i] = true;
                    index++;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập khóa!");
                return;
            }
            else
            {
                string key = txtKey.Text.ToUpper().Replace(" ", "");
                generateKeyMatrix(key);
            }
        }

        void DecryptPair(char a, char b, StringBuilder plaintext)
        {
            int rowA, colA, rowB, colB;
            findPosition(a, out rowA, out colA);
            findPosition(b, out rowB, out colB);
            if (rowA == rowB)
            {
                plaintext.Append(keyMatrix[rowA, (colA + 4) % 5]);
                plaintext.Append(keyMatrix[rowB, (colB + 4) % 5]);
            }
            else if (colA == colB)
            {
                plaintext.Append(keyMatrix[(rowA + 4) % 5, colA]);
                plaintext.Append(keyMatrix[(rowB + 4) % 5, colB]);
            }
            else
            {
                plaintext.Append(keyMatrix[rowA, colB]);
                plaintext.Append(keyMatrix[rowB, colA]);
            }
        }
        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (!used[0])
            {
                MessageBox.Show("Vui lòng nhập khóa trước khi giải mã!");
                return;
            }
            else if (txtInput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập văn bản cần giải mã!");
                return;
            }
            else
            {
                string ciphertext = txtInput.Text.ToUpper().Replace(" ", "");
                StringBuilder plaintext = new StringBuilder();
                for (int i = 0; i < ciphertext.Length; i += 2)
                {
                    char a = ciphertext[i];
                    char b = (i + 1 < ciphertext.Length) ? ciphertext[i + 1] : 'X';
                    DecryptPair(a, b, plaintext);
                }
                txtOutput.Text = plaintext.ToString();
            }
        }
    }
}
