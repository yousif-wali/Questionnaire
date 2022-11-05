using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Questions
    {
        public static int id = 0;
        private string Q;
        private string A;
        private string[] WrongAnswers;
        //  Constructor
        public Questions(string Question, string Answer, string[] wrongAnswers)
        {
            this.Q = Question;
            this.A = Answer;
            this.WrongAnswers= wrongAnswers;
            id++;
        }
        public string getAnswer()
        {
            return this.A;
        }
        public string getQuestion()
        {
            return this.Q;
        }
        public string getWrongQuestion1()
        {
            return this.WrongAnswers[0];
        }
        public string getWrongQuestion2()
        {
            return this.WrongAnswers[1];
        }
        public string getWrongQuestion3()
        {
            return this.WrongAnswers[2];
        }
    }
    class Program
    {
        public static void getOtherAnswers(int a, int[] b)
        {
            switch (a)
            {
                case 1:
                    b[0] = 2;
                    b[1] = 3;
                    b[2] = 4;
                    break;
                case 2:
                    b[0] = 1;
                    b[1] = 3;
                    b[2] = 4;
                    break;
                case 3:
                    b[0] = 1;
                    b[1] = 2;
                    b[2] = 4;
                    break;
                case 4:
                    b[0] = 1;
                    b[1] = 2;
                    b[2] = 3;
                    break;
            }
        }
        static void Main(string[] args)
        {
            double playerScore = 0;
            Questions[] q;
            q = new Questions[]{
                new Questions("What is the tallest building in world?", "Burj Khalifa", new string[] { "Shanghai Tower", "Wuhan Center Tower", "Willis Tower" } ),
                new Questions("What is the fastest car in world?",  "Bugatti",  new string[] {"Ferrari", "Hennessey", "Koenigsegg" }),
                new Questions("What is the most common element in world", "Carbon", new string[]{"Nitrogen", "Oxygen", "Hydrogen" }),
                new Questions("The atmosphere is held to the earth by?", "Gravity", new string[]{"Ozon", "Kinetic Energy", "Moon"}),
                new Questions("Which type of fish covers the sea for miles together and is a wonderful sight to see?", "Jelly Fish", new string[]{"Gold Fish", "Blue Whale", "Tuna Fish"}),
                new Questions("HTML stands for?", "HyperText Markup Language", new string[]{"Hot Tasty Macaroni Lamb", "Harmony Tone Most Liable", "Host Tasty My Latte" }),
                new Questions("Where is the Statue of Liberty situated?", "New York City", new string[]{"South Dakota", "Washington", "Washington D.C" }),
                new Questions("Where was the first Asian Games held?", "New Delhi, India", new string[]{"Baghdad, Iraq", "Shanghai, China", "Tahran, Iran" }),
                new Questions("Who were the first to notice that a snowflake has six sides?", "The Chinese", new string[]{"The British", "The Mongols", "The American"}),
                new Questions("What does JS stands for", "Javascript", new string[]{"Jesus", "Job Security", "Joggling Softballs"}),
            };
            Random rand = new Random();
            int[] otherAnswers = {0, 1, 2};
            foreach (var Q in q)
            {
                Console.WriteLine(Q.getQuestion());
                int ans = rand.Next(1, 5);
                getOtherAnswers(ans, otherAnswers);
                string[] answers = { ans.ToString() + ": " + Q.getAnswer(),  otherAnswers[0].ToString() + ": "+ Q.getWrongQuestion1(),
                 otherAnswers[1].ToString() + ": "+ Q.getWrongQuestion2(),
                 otherAnswers[2].ToString() + ": "+ Q.getWrongQuestion3()};
                Array.Sort(answers);
                foreach(var an in answers)
                {
                    Console.WriteLine(an);
                }
                int a = Convert.ToInt32(Console.ReadLine());
                if(a > 4)
                {
                    Console.WriteLine("Please Enter an answer between 1 and 4. or you can choose not to answer.");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                if (a == ans) playerScore++;
                
            }
            Console.Write("Your Score was: " + (playerScore / q.Length) * 100 + "%");
        }
    }
}
