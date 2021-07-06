// Created by Three Byte Intermedia, Inc.
// Solution: MLDotNetSentiment || Project: MLModel01.ConsoleApp02
// File: MLModel01.consumption.cs
// Created: 2021 07 06 11:49 AM || Updated: 2021 07 06 1:56 PM
// by Olaaf Rossi

using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MLModel01.ConsoleApp02
{
    public partial class MLModel01
    {
        private static readonly string MLNetModelPath = Path.GetFullPath("MLModel01.zip");

        /// <summary>
        ///     Use this method to predict on <see cref="ModelInput" />.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns>
        ///     <seealso cref=" ModelOutput" />
        /// </returns>
        public static ModelOutput Predict(ModelInput input)
        {
            MLContext mlContext = new();

            // Load model & create prediction engine
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            ModelOutput result = predEngine.Predict(input);
            return result;
        }

        /// <summary>
        ///     model input class for MLModel01.
        /// </summary>

        #region model input class

        public class ModelInput
        {
            [ColumnName(@"col0")] public string Col0 { get; set; }

            [ColumnName(@"col1")] public float Col1 { get; set; }
        }

        #endregion

        /// <summary>
        ///     model output class for MLModel01.
        /// </summary>

        #region model output class

        public class ModelOutput
        {
            internal void Prediction(string consoleText)
            {
                throw new NotImplementedException();
            }

            [ColumnName("PredictedLabel")] public float Prediction { get; set; }

            public float[] Score { get; set; }
        }

        #endregion
    }
}