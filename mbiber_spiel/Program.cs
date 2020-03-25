using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbiber_spiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Game spiel = new Game();

            //Frage 1
            Question frage1 = new Question("Womit werden Eisenbahnwaggons professionell abgebremst ?");
            frage1.AddAnswer(new Answer("0: Riemchensandale"));
            frage1.AddAnswer(new Answer("1: Lederstiefel"));
            frage1.AddAnswer(new Answer("2: Badeschlapfen"));
            frage1.AddAnswer(new Answer("3: Hemmschuh", true));
            spiel.AddQuestion(frage1);

            //Frage 2
            Question frage2 = new Question("Welche britische Band gilt als Inbegriff des Synthiepop?");
            frage2.AddAnswer(new Answer("0: Bon Jovi"));
            frage2.AddAnswer(new Answer("1: U2"));
            frage2.AddAnswer(new Answer("2: Depeche Mode", true));
            frage2.AddAnswer(new Answer("3: Metallica"));
            spiel.AddQuestion(frage2);

            //Frage 3
            Question frage3 = new Question("Wem wurde in jener Stadt der Nobelpreis überreicht, die damals noch Kristiania hieß?");
            frage3.AddAnswer(new Answer("0: Max Planck"));
            frage3.AddAnswer(new Answer("1: Albert Schweitzer"));
            frage3.AddAnswer(new Answer("2: Bertha von Suttner", true));
            frage3.AddAnswer(new Answer("3: Marie Curie"));
            spiel.AddQuestion(frage3);

            while (spiel.Status == GameStatus.Active)
            {
                var question = spiel.NextQuestion;
                var answers = question.Answers;

                Console.WriteLine(question.Text);

                foreach (var answer in answers)
                {
                    Console.WriteLine(answer.Text);
                }


                Console.Write("Antwort: ");
                int eingabe = Convert.ToInt32(Console.ReadLine());

                answers[eingabe].IsChecked = true;

                spiel.ValidateCurrentQuestion();

            }

            if (spiel.Status == GameStatus.HasFinished)
            {
                Console.WriteLine("Herzlichen Glückwunsch, du hast gewonnen!");
            }

            else if (spiel.Status == GameStatus.HasLost)
            {
                Console.WriteLine("Das war leider falsch!");
            }

        }
    }
}
