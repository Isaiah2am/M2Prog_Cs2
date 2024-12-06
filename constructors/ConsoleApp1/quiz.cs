﻿namespace ConsoleApp1
{
    class Quiz
    
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] ingevuldeantwoorden;
        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];

        }
        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, quizVraag); 
            
        }

    }
}

  
 