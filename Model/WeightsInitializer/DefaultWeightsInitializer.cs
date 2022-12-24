using System;
using System.Linq;

namespace neural_networks_kubsu.NeuralNetwork.WeightsInitializer.DefaultWeightsInitializer
{
    public class DefaultWeightsInitializer : IWeightsInitializer
    {
        /* Инициализирует массив весов. Массив[0] — это смещение. Массив[1..size+1] — значение веса. */
        public double[][] Initialize(int prevLayerUnits, int units, int layerIndex)
        {
            var rnd = new Random(); // для функции рандома весов
            var weights = new double[units][];
            foreach (var i in Enumerable.Range(0, units))
            {
                weights[i] = new double[prevLayerUnits + 1];
            }
            
            foreach (var neuronIndex in Enumerable.Range(0, units))
            {
                double s = 0;
                foreach (var i in Enumerable.Range(0, prevLayerUnits))
                {         
                    weights[neuronIndex][i] = rnd.NextDouble() * 2 - 1;
                    s += weights[neuronIndex][i];
                }

                var mean = s / (prevLayerUnits);

                double ss = 0;

                foreach (var i in Enumerable.Range(0, prevLayerUnits))
                {
                    ss += Math.Pow(weights[neuronIndex][i] - mean, 2);
                }

                ss = Math.Sqrt(ss);

                foreach (var i in Enumerable.Range(0, prevLayerUnits))
                {
                    weights[neuronIndex][i] /= ss;
                }
            }
            return weights;
        }
    }
}