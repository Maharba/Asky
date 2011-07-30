using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Asky
{
    internal enum TypeAnswer
    {
        Single,
        Multiple
    }

    internal enum TypeQuiz
    {
        Questionnaire,
        Exam
    }

    public class Answer
    {
        public string Content { get; set; }
        public TypeAnswer Type { get; set; }
    }

    public class Quiz
    {
        /// <summary>
        /// The number of the actual chapter of the quiz. If it's a questionnaire, it returns 0.
        /// </summary>
        public byte Unit { get; set; }

        /// <summary>
        /// The date of application. If it's a questionnaire, it returns an empty DateTime object.
        /// </summary>
        public DateTime DateApplication { get; set; }

        /// <summary>
        /// The respective subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The information about the applicator.
        /// </summary>
        public Professor Professor { get; set; }

        /// <summary>
        /// the information about the applicant.
        /// </summary>
        public Student Student { get; set; }

        /// <summary>
        /// The question itself.
        /// </summary>
        public StringCollection Questions { get; set; }
        
        /// <summary>
        /// The correct answer.
        /// </summary>
        public int Answer { get; set; }

        /// <summary>
        /// The available options.
        /// </summary>
        public List<Answer> Options { get; set; }

        /// <summary>
        /// It parses a .qst file (Questionnaire) or a .exm file (Exam) into a valid Quiz.
        /// </summary>
        /// <param name="filePath">The path of the .qst file or .exm file.</param>
        /// <returns>A Quiz object; if the file is not valid, null.</returns>
        public static Quiz ParseFromFile(string filePath)
        {
            if (filePath.EndsWith(".qst") || filePath.EndsWith(".exm"))
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Quiz qz = (Quiz) bf.Deserialize(fs);
                fs.Close();
                return qz;
            }
            return null;
        }
    }
}
