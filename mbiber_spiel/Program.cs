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
            frage1.AddAnswer(new Answer("A: Riemchensandale"));
            frage1.AddAnswer(new Answer("B: Lederstiefel"));
            frage1.AddAnswer(new Answer("C: Badeschlapfen"));
            frage1.AddAnswer(new Answer("D: Hemmschuh", true));
            spiel.AddQuestion(frage1);

            Question frage2 = new Question("Welche britische Band gilt als Inbegriff des Synthiepop?");
            frage1.AddAnswer(new Answer("A: Bon Jovi"));
            frage1.AddAnswer(new Answer("B: U2"));
            frage1.AddAnswer(new Answer("C: Depeche Mode", true));
            frage1.AddAnswer(new Answer("D: Metallica"));
            spiel.AddQuestion(frage2);

            Question frage3 = new Question("Wem wurde in jener Stadt der Nobelpreis überreicht, die damals noch Kristiania hieß?");
            frage1.AddAnswer(new Answer("A: Max Planck"));
            frage1.AddAnswer(new Answer("B: Albert Schweitzer"));
            frage1.AddAnswer(new Answer("C: Bertha von Suttner", true));
            frage1.AddAnswer(new Answer("D: Marie Curie"));
            spiel.AddQuestion(frage3);



        }
    }
}
