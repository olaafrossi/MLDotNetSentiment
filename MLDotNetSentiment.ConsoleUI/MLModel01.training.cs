﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace MLDotNetSentiment_ConsoleUI
{
    public partial class MLModel01
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Text.FeaturizeText(@"col0", @"col0")      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", @"col0"))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(@"col1", @"col1"))      
                                    .Append(mlContext.MulticlassClassification.Trainers.OneVersusAll(binaryEstimator:mlContext.BinaryClassification.Trainers.FastTree(new FastTreeBinaryTrainer.Options(){NumberOfLeaves=16,MinimumExampleCountPerLeaf=20,NumberOfTrees=4,MaximumBinCountPerFeature=210,LearningRate=0.0100988491833436F,FeatureFraction=1F,LabelColumnName=@"col1",FeatureColumnName=@"Features"}), labelColumnName: @"col1"))      
                                    .Append(mlContext.Transforms.Conversion.MapKeyToValue(@"PredictedLabel", @"PredictedLabel"));

            return pipeline;
        }
    }
}
