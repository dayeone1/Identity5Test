using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identity5Test
{
    public partial class Form1 : Form
    {
        List<string> results;

        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "identityResults.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다.\n{ex.Message}", "파일 없음");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근권한이 없습니다.\n{ex.Message}", "권한 문제");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류");
            }

        }

        private void 상담하기ToolStripMenuItem_Click(object sender, EventArgs e)
        { // = 정보보기. 뭔가 꼬여서 수정할 수 없음...
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 운세테스트내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string birthday = tbTier.Text;
            string birthyear = tbMode.Text;
            string result = GetFortune();
            string saju = result.Split('|')[0];
            string message = result.Split('|')[1];
            tbResult.Text = birthday + " " + birthyear + Environment.NewLine
                + saju + Environment.NewLine
                + message;
            SaveHistory($"{birthday} {birthyear}|{result}");
        }

        private string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(0, results.Count);
            return results[index];
        }

    }
}
