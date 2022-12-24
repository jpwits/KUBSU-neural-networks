using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using neural_networks_kubsu.NeuralNetwork.Layer.HiddenLayer;
using neural_networks_kubsu.NeuralNetwork.Layer.InputLayer;
using neural_networks_kubsu.NeuralNetwork.Layer.OutputLayer;
using neural_networks_kubsu.NeuralNetwork.WeightsInitializer;

namespace neural_networks_kubsu.NeuralNetwork
{
    public class NeuralNetwork
    {
        private InputLayer _inputLayer;
        private readonly List<HiddenLayer> _layers = new();
        private OutputLayer OutputLayer => (OutputLayer) _layers.Last();             
        public int Epoch { get; private set; } = 0;
        private readonly Form1 _form1 = new();
        private double[][] _inputData = new double[100][];
        private double[][] _outputData = new double[100][];        
        public NeuralNetwork()
        {      
            _inputLayer = new InputLayer(15); // 15 - на входном
            _layers.Add(new HiddenLayer(70)); // 70 - на первом скрытом
            _layers.Add(new HiddenLayer(36)); // 36 - на втором скрытом
            _layers.Add(new OutputLayer(10)); // 10 - на выходном

            string path = "datasetLearn.txt"; // примеры для обучения
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
            ConnectLayers(); // Соединяем слои
            RunForm(); 

            Thread th = new Thread(RunForm); // Разбиваем на потоки график ошибок
            th.Start();

        }

        public double[] Predict(double[] inputData)
        {
            _inputLayer.Feed(inputData);
            foreach (var layer in _layers)
            {
                layer.ComputeNeurons();
            }
            return OutputLayer.Result;
        }

        private void ConnectLayers()
        {
            _layers[0].PreviousLayer = _inputLayer;
            
            for (var layerIndex = 1; layerIndex <= _layers.Count - 1; layerIndex++)
            {
                _layers[layerIndex].PreviousLayer = _layers[layerIndex - 1];
            }
            
            for (var layerIndex = 0; layerIndex < _layers.Count - 1; layerIndex++)
            {
                _layers[layerIndex].NextLayer = _layers[layerIndex + 1];
            }
        }
        
        public void InitializeWeights(IWeightsInitializer weightsInitializer)
        {
            _layers[0].Weights = weightsInitializer.Initialize(
                _inputLayer.Neurons.Length,
                _layers[0].Neurons.Length,
                1
            );
            
            for (var layerIndex = 1; layerIndex < _layers.Count; layerIndex++)
            {
                _layers[layerIndex].Weights = weightsInitializer.Initialize(
                    _layers[layerIndex - 1].Neurons.Length,
                    _layers[layerIndex].Neurons.Length,
                    layerIndex + 1
                );
            }

            foreach (var layer in _layers)
            {
                layer.InitializeWeights();
            }
            _form1.labelEpoch.Text = "Эпоха: ";
            _form1.labelLoss.Text = "Ошибка: ";
            Epoch = 0;
        }

        private void CorrectWeights(double learningRate)
        {
            foreach (var layer in _layers)
            {
                layer.CorrectWeights(learningRate);
            }
        }

        private void ComputeDelta(double momentum, double[] data)
        {
            OutputLayer.ComputeDelta(data);
            for (var i = _layers.Count - 2; i >= 0; i--)
            {
                _layers[i].ComputeDelta(momentum);
            }
        }
        
        public void Fit(int epochs, double learningRate, double inertia)
        {            
            Series _series = new();            
            _form1.chart1.Series.Add(_series);
            _series.ChartType = SeriesChartType.Line;
            //_series.IsVisibleInLegend = false;
            var endEpoch = Epoch + epochs;
            for (; Epoch < endEpoch; Epoch++)
            {
                for (var i = 0; i < _inputData.Length; i++)
                {
                    Predict(_inputData[i]);
                    ComputeDelta(inertia, _outputData[i]);
                    CorrectWeights(learningRate);
                }

                int _onEachEpoch = 2;
                _form1.labelEpoch.Text = "Эпоха: " +  (Epoch + 1);                
                if (Epoch == 0)
                {
                    _series.Points.Clear();
                }
                if (Epoch % _onEachEpoch == 0)
                {
                    _series.Points.AddXY(Epoch, Evaluate(_inputData, _outputData));                                        
                    _form1.labelLoss.Text = "Ошибка: " + _series.Points.Last().YValues;
                    _form1.labelLoss.Text = "Ошибка: " + Evaluate(_inputData, _outputData).ToString("F6");
                }
            }
        }

        // Тут выходит ошибка из-за неправильного обращения для отображения формы из другого потока,
        // чтобы можно было использовать с отладкой, нужно обращаться через делегат

        // Делегат — класс, который позволяет хранить в себе ссылку
        // на метод с определённой сигнатурой произвольного класса.
        private void RunForm()
        {
             
            //_form1.ShowDialog();
            _form1.Show();
        }        

        public double[][][] ExportWeights()
        {
            var array = new double[_layers.Count][][];
            for (var i = 0; i < _layers.Count; i++)
            {
                array[i] = _layers[i].Weights;
            }
            return array;
        }

        public double Evaluate(double[][] _inputData, double[][] _outputData)
        {
            var loss = 0.0;
            for (var i = 0; i < _inputData.Length; i++)
            {
                loss += Distance(_outputData[i], Predict(_inputData[i]));
            }
            return loss / _inputData.Length;
        }

        public double Distance(double[] expectedOutput, double[] currentOutput)
        {
            var s = 0.0;
            for (var i = 0; i < currentOutput.Length; i++)
            {
                s += Math.Pow(expectedOutput[i] - currentOutput[i], 2.0);
            }
            return Math.Sqrt(s);
        }
    }
}