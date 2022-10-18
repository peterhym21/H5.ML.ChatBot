﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModelFocusArea3;

// Create single instance of sample data from first line of dataset for model input
MLModelFocusArea1.ModelInput sampleData = new MLModelFocusArea1.ModelInput()
{
    Utterances = @"are you 21 years old?",
};

// Make a single prediction on the sample data and print results
var predictionResult = MLModelFocusArea1.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Focusarea with predicted Focusarea from sample data...\n\n");


Console.WriteLine($"Utterances: {@"are you 21 years old?"}");
Console.WriteLine($"Focusarea: {@"you"}");


Console.WriteLine($"\n\nPredicted Focusarea: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

