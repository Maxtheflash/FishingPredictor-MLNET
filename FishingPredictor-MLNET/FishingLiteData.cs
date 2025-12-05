using Microsoft.ML.Data;

public class FishingLiteData
{
    [LoadColumn(0)]
    public string? BaitType { get; set; }

    [LoadColumn(1)]
    public string? CatchSuccess { get; set; }
}

public class FishingLitePrediction
{
    [ColumnName("PredictedLabel")]
    public string? CatchSuccess;
}
