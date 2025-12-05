# 🎣 FishingPredictor-MLNET

FishingPredictor-MLNET is a lightweight **ML.NET console application** that uses a small fishing dataset to predict fishing patterns/outcomes based on environmental conditions.

The goal of the project is to demonstrate how to:

- Load data from CSV
- Define an ML.NET data model
- Build and train an ML pipeline
- Evaluate the model
- Make predictions from new input values

It’s a compact, easy-to-read example of using **ML.NET in C#** on a real-world themed problem (fishing).

---

## 🚀 Features

- ✅ **ML.NET regression / prediction model** for fishing-related data  
- ✅ Reads training data from `simple_data.csv`  
- ✅ Strongly-typed input model (`FishingLiteData`)  
- ✅ Builds an ML pipeline, trains, and evaluates the model  
- ✅ Console output showing predictions for sample scenarios  
- ✅ Clean, minimal code suitable for teaching or portfolio use  

*(If you later change the task to classification or a different label, you can easily tweak this section.)*

---

## 📊 Data & Features

The sample dataset `simple_data.csv` is a small synthetic dataset representing fishing trips.

Examples of features you might include:

- Time of day  
- Weather / cloud cover  
- Water temperature  
- Lure / bait type  
- Location or depth category  
- Recent catch activity  

The target value might be:

- A **catch score** (0–10)  
- Number of fish caught  
- Probability of success  

You can expand the CSV to include more features and records over time.

---

## 🧠 ML.NET Pipeline Overview

A typical ML.NET pipeline in this project looks like:

1. **Load data** from `simple_data.csv`
2. **Map CSV columns** to the `FishingLiteData` C# class
3. **Process features** (e.g., handle numeric and categorical data)
4. **Train a model** using an ML.NET trainer (e.g., regression)
5. **Evaluate the model** on a test split
6. **Use the model** to make predictions for new fishing conditions

The core logic for this lives in:

- `Program.cs` – app entry point, training, evaluation, prediction
- `FishingLiteData.cs` – model that defines the input schema

---

## 📂 Project Structure

```text
FishingPredictor/
│
├── FishingPredictor.sln          # Solution file
├── FishingPredictor.csproj       # Project file
├── Program.cs                    # Main console app (training + prediction)
├── FishingLiteData.cs            # ML.NET input model class
└── simple_data.csv               # Sample fishing dataset (training data)
