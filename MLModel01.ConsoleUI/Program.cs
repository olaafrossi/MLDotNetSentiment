// Created by Three Byte Intermedia, Inc.
// Solution: MLDotNetSentiment || Project: MLModel01.ConsoleUI
// File: Program.cs
// Created: 2021 07 06 11:18 AM || Updated: 2021 07 06 11:39 AM
// by Olaaf Rossi

using System;

namespace MLModel01.ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            MLModel01.ModelInput sampleData = new()
            {
                
                Col0 = @"Wow... Loved this place."
                Col1 = @"Crust is not good."
                Col2 = @"Not tasty and the texture was just nasty."
                Col3 = @"Stopped by during the late May bank holiday off Rick Steve recommendation and loved it."
                Col4 = @"The selection on the menu was great and so were the prices."
                Col5 = @"Now I am getting angry and I want my damn pho."
                Col6 = @"Honeslty it didn't taste THAT fresh."
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