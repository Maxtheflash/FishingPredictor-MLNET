using System;
using Microsoft.ML;
using Microsoft.ML.Data;

class Program
{
    static void Main(string[] args)
    {
        var mlContext = new MLContext();

        // Load data
        var data = mlContext.Data.LoadFromTextFile<FishingLiteData>("simple_data.csv", separatorChar: ',', hasHeader: true);

        // Build pipeline
        var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", nameof(FishingLiteData.CatchSuccess))
            .Append(mlContext.Transforms.Categorical.OneHotEncoding("BaitType"))
            .Append(mlContext.Transforms.Concatenate("Features", "BaitType"))
            .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy("Label", "Features"))
            .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

        // Train
        var model = pipeline.Fit(data);

        // Predict
        var predictor = mlContext.Model.CreatePredictionEngine<FishingLiteData, FishingLitePrediction>(model);

        var test = new FishingLiteData { BaitType = "Worm" };
        var result = predictor.Predict(test);

        Console.WriteLine($" your prediction today for bait '{test.BaitType}': {result.CatchSuccess}");
        Console.ReadKey();
    }
}
