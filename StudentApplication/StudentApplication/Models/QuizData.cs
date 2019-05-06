using System;
namespace StudentApplication.Models
{
    public class QuizData
    {
        public int Id { set; get; }
        public string category { set; get; }
        public string questionNumber { get; set; }
        public string question { get; set; }
        public string[] options { get; set; }
    }
}
