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

namespace GoodPraDog
{
    public partial class Form3: Form
    {
        private int elapsedTime = 0;
        private int workTime = 1500;
        private int breakTime = 300;
        private bool isWorking = true;
        private string Countdown(int time)
        {
            int minutes = time / 60;
            int seconds = time % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        private void UpdateControls() {
            if (isWorking)
            {
                saveButton.Enabled = true;
                richTextBox1.Enabled = true;
                openFileButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
                richTextBox1.Enabled = false;
                openFileButton.Enabled = false;
            }
            label1.Text = isWorking ? "Intervalo:" : "Trabalho:";
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            currentTimeLabel.Text = now.ToString("HH:mm:ss");
            elapsedTime++;
            if (isWorking) countdownLabel.Text = Countdown(workTime - elapsedTime);
            else countdownLabel.Text = Countdown(breakTime - elapsedTime);
            if (isWorking && elapsedTime >= workTime)
            {
                elapsedTime = 0;
                isWorking = false;
                UpdateControls();
                MessageBox.Show("Hora de descansar");

            }
            else if (!isWorking && elapsedTime >= breakTime)
            {
                elapsedTime = 0;
                isWorking = true;
                UpdateControls();
                MessageBox.Show("Hora de trabalhar");
            }   
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Nome do paciente: \nIdade: \nPeso: \nVacinas: \nDiagnóstico: \nMedicação: \nObservações: ";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt";
            saveFileDialog.Title = "Salvar arquivo";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "paciente.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(richTextBox1.Text);
                }
                MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt";
            openFileDialog.Title = "Abrir arquivo";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
