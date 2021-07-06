// Created by Three Byte Intermedia, Inc.
// Solution: MLDotNetSentiment || Project: MLModel01.ConsoleUI
// File: Program.cs
// Created: 2021 07 06 11:18 AM ||Updated: 2021 07 06 11:19 AM
// by Olaaf Rossi

using System;

namespace MLModel01_ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel01.ModelInput sampleData = new()
            {


              
                Col0 = @"Wow... Loved this place."
            };

            // Make a single prediction on the sample data and print results
            MLModel01.ModelOutput predictionResult = MLModel01.Predict(sampleData);

            Console.WriteLine(
                "Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");


            Console.WriteLine($"Col0: {sampleData.Col0}");


            Console.WriteLine($"\n\nPredicted Col1: {predictionResult.Prediction}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}