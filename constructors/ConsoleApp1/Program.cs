namespace ConsoleApp1
{
    class Program
    {
        private void Run()
        {
            QuizVraag quizvraag = new QuizVraag("hier komt de vraag", "hier komt hetantwoord");
            Quiz quiz = new Quiz(10);
            quiz.VoegVraagToeOpIndex(0, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(1, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(2, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(3, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(4, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(5, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(6, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(7, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(8, "vraag", "antwoord");
            quiz.VoegVraagToeOpIndex(9, "vraag", "antwoord");

            for (int i = 0; i < quiz.vragen.Length; i++)
            {
                quiz.StelVraag(i);
            }
        }
            static void Main(string[] args)
            {
                Program program = new Program();
                program.Run();
        }

        }
    

}



