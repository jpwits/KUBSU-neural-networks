using System;

namespace neural_networks_kubsu.NeuralNetwork.Layer.HiddenLayer
{
    public class HiddenLayer : AbstractLayer
    {       
        public ILayer PreviousLayer { get; set; }
        public ILayer NextLayer { get; set; }
        public double[][] Weights { get; set; }

        public HiddenLayer(int units) : base(units)
        {
        }

        public void ComputeNeurons()
        {
            foreach (var neuron in Neurons)
            {
                neuron.Compute(PreviousLayer);
                neuron.ActivationValue = 1.0 / (1.0 + Math.Exp(-neuron.NeuronValue));
                neuron.DerivativeValue = neuron.ActivationValue * (1 - neuron.ActivationValue);
            }           
        }

        public void CorrectWeights(double learningRate)
        {
            foreach (var neuron in Neurons)
            {
                neuron.Correct(learningRate, PreviousLayer);
            }
        }

        public void InitializeWeights()
        {
            for (var i = 0; i < Weights.Length; i++)
            {
                Neurons[i] = new Neuron.Neuron(Weights[i]);
            }
        }

        public void ComputeDelta(double momentum)
        {
            for (var i = 0; i < Neurons.Length; i++)
            {
                var computedDelta = 0.0;
                foreach (var nextLayerNeurons in NextLayer.Neurons)
                {
                    computedDelta += nextLayerNeurons.Delta * nextLayerNeurons.Weights[i];
                }

                Neurons[i].Delta = momentum * Neurons[i].Delta + (1 - momentum) * computedDelta * Neurons[i].DerivativeValue;
            }
        }
    }
}