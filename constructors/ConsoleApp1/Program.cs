namespace ConsoleApp1
{
    class Program
    {
        private void Run() 
        {
        QuizVraag quizvraag = new QuizVraag("hier komt de vraag", "hier komt hetantwoord");
        Quiz quiz = new Quiz(10);
            quiz.VoegVraagToeOpIndex(0, quizvraag);
            quiz.VoegVraagToeOpIndex(1, quizvraag);
            quiz.VoegVraagToeOpIndex(2, quizvraag);
            quiz.VoegVraagToeOpIndex(3, quizvraag);
            quiz.VoegVraagToeOpIndex(4, quizvraag);
            quiz.VoegVraagToeOpIndex(5, quizvraag);
            quiz.VoegVraagToeOpIndex(6, quizvraag);
            quiz.VoegVraagToeOpIndex(7, quizvraag);
            quiz.VoegVraagToeOpIndex(8, quizvraag);
            quiz.VoegVraagToeOpIndex(9, quizvraag);

        }
        static void Main(string[] args)
        {
        }

    }
}



