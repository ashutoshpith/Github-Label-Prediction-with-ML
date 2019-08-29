using GithubLabelMlML.Model.DataModels;
using Microsoft.ML;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubLabelMl.Models
{
    public class Gitpred
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Area { get; set; }

        public string TestIt()
        {

            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load(@"H:\c-sharp\GithubLabelMl\GithubLabelMlML.Model\MLModel.zip", out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
            // Use the code below to add input data
            var input = new ModelInput();
            Console.WriteLine("Enter The Title :");
            input.Title = Title;
            input.Description = Description;
            //Console.WriteLine("Enter The Description :");
            //input.Description = Console.ReadLine();
            // Try model on sample data
            ModelOutput result = predEngine.Predict(input);
            Console.WriteLine("Result Rating=" + result.Prediction);
            //Console.WriteLine("Result=" + result.Score);

            // Console.ReadKey();
            return result.Prediction.ToString();
        }
    }
}
