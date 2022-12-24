using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using neural_networks_kubsu.NeuralNetwork.WeightsInitializer.DefaultWeightsInitializer;
using neural_networks_kubsu.NeuralNetwork.WeightsInitializer.SavedWeightsInitializer;

namespace neural_networks_kubsu
{
    public partial class FormMain : Form
    {
        private readonly double[] _inputArray = new double[15];

        private NeuralNetwork.NeuralNetwork _nn;
        
        public FormMain()
        {
            InitializeComponent();
            _nn = new NeuralNetwork.NeuralNetwork();     
            Randomize();
        }

        private void Fit()
        {
            var epochs = decimal.ToInt32(epochsUpDown.Value);
            var learningRate = decimal.ToDouble(learningRateUpDown.Value);
            var inertia = decimal.ToDouble(inertiaUpDown.Value);
            _nn.Fit(epochs, learningRate, inertia);            
            //Predict();
        }              

        private void Predict()
        {
            var prediction = _nn.Predict(_inputArray);
            var s1 = "";
            var s2 = "";
            double max = 0;
            double imax = 0;
            for (var i = 0; i < 10; i++)
            {
                if (prediction[i] > max)
                {
                    max = prediction[i];
                    imax = i;
                }
                if (i % 2 == 0)
                    s1 += i + ": " + Math.Round(prediction[i], 4) + "\n";
                else
                    s2 += i + ": " + Math.Round(prediction[i], 4) + "\n";
            }
            labelDigit.Text = imax.ToString();
            labelPrediction1.Text = s1;
            labelPrediction2.Text = s2;
        }

        private void Export()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = saveFileDialog1.FileName;
            var serializer = new XmlSerializer(typeof(double[][][]));
            using var fs = new FileStream(filename, FileMode.Create);
            serializer.Serialize(fs, _nn.ExportWeights());
            fs.Close();
        }

        private void Import()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            var filename = openFileDialog1.FileName;
            var serializer = new XmlSerializer(typeof(double[][][]));
            using var fs = new FileStream(filename, FileMode.OpenOrCreate);
            var weights = (double[][][]) serializer.Deserialize(fs);
            fs.Close();
            _nn.InitializeWeights(new SavedWeightsInitializer(weights));
            //Predict();            
        }

        private void Randomize()
        {
            _nn.InitializeWeights(new DefaultWeightsInitializer());
            //Predict();
        }

        private void btn_click(Button btn)
        {
            var buttonId = btn.TabIndex;
            btn.BackColor = _inputArray[buttonId] == 0.0 ? Color.RoyalBlue : Color.Silver;
            _inputArray[buttonId] = Math.Abs(1.0 - _inputArray[buttonId]);
            //Predict();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            btn_click(sender as Button);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void randomizeBtn_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void fitBtn_Click(object sender, EventArgs e)
        {
            var thread2 = new Thread(Fit);
            thread2.Start();
        }

        private void recognizeBtn_Click(object sender, EventArgs e)
        {
            Predict();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            double[][] _inputData = new double[10][];
            double[][] _outputData = new double[10][];
            string path = "datasetTest.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                int k = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    int j = 0;
                    double[] inputMas = new double[15];
                    for (int i = 0; i < line.Length - 1; i++)
                        if (line[i] != ' ')
                        {
                            inputMas.SetValue(double.Parse(line[i].ToString()), j);
                            j++;
                        }
                    _inputData.SetValue(inputMas, k);
                    double[] outMas = new[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
                    outMas.SetValue(1.0, int.Parse(line[line.Length - 1].ToString()));
                    _outputData.SetValue(outMas, k);
                    line = sr.ReadLine();
                    k++;
                }
            }
            labelLoss.Text = "Ошибка: " + _nn.Evaluate(_inputData, _outputData).ToString("F6");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}