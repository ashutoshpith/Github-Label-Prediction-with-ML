//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace GitLabelML.Model.DataModels
{
    public class ModelInput
    {
        [ColumnName("ID"), LoadColumn(0)]
        public float ID { get; set; }


        [ColumnName("Area"), LoadColumn(1)]
        public string Area { get; set; }


        [ColumnName("Title"), LoadColumn(2)]
        public string Title { get; set; }


        [ColumnName("Description"), LoadColumn(3)]
        public string Description { get; set; }


    }
}
