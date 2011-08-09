using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Quiz.Base.Interfaces;

namespace Quiz.Base.Parsers
{
    public class QuizParser
    {
        public static IQuestionnaire ParseFromFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentException("Must be a valid path.", "filePath");
            
            FileInfo file = new FileInfo(filePath);

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                switch (file.Extension)
                {
                    case "qst":
                        return (Questionnaire)bf.Deserialize(fs);
                    case "exm":
                        return (Exam)bf.Deserialize(fs);
                    default:
                        throw new FileFormatException("Unkown format file.");
                }
            }
        }
    }
}