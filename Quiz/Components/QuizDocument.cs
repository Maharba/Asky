using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Quiz.Base;
using Quiz.Base.Collections;
using Quiz.Base.Enums;
using Quiz.Base.Models;

namespace Quiz.Components
{
    public partial class QuizDocument : Component
    {
        public QuizDocument()
        {
            InitializeComponent();
        }

        public event EventHandler BeginQuiz;
        public event EventHandler EndQuiz;

        public QuestionCollection Questions { get; set; }
        public string ApplicantName { get; set; }
        public string ApplierName { get; set; }
        public byte Unit { get; set; }
        public TypeQuiz Type { get; set; }

        /// <summary>
        /// It parses a .qst file (Questionnaire) or a .exm file (Exam) into a valid Quiz.
        /// </summary>
        /// <param name="filePath">The path of the .qst file or .exm file.</param>
        /// <returns>A Quiz object; if the file is not valid, null.</returns>
        public static QuizDocument ParseFromFile(string filePath)
        {
            
            if (filePath.EndsWith(".qst") || filePath.EndsWith(".exm"))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                QuizDocument qz = (QuizDocument)bf.Deserialize(fs);
                fs.Close();
                return qz;
            }
            return null;
        }
        
    }
}
