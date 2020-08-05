using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritance
{
    class Game
    {
        public int noOfplayers;
        public string country;
        public int noOfPlayers
        {
            get { return noOfPlayers; }
            set { value = noOfPlayers; }
        }

        public string Country
        {
            get { return country; }
            set { value = country; }
        }

        public Game()
        {

        }

        public Game(int _noOfplayers, string _country)
        {
            noOfplayers = _noOfplayers;
            country = _country;
        }

         public void ShowWorldCup(string country,string game)
        {
           
            Console.WriteLine("{0} have won the {1} World cup {2}", country, game, DateTime.Now.ToString("yyyy"));

        }

    }

    class Cricket : Game
    {
        public string coachname;

        public string CoachName
        {
            get { return coachname; }
            set { value = coachname; }
        }

        public Cricket()
        {

        }

        public Cricket(int _noOfplayers, string _country, string _coachname):base(_noOfplayers,_country)
        {
            noOfplayers = _noOfplayers;
            country = _country;
            coachname = _coachname;
        }
    }

    class Football : Game
    {
        public string leaugename;

        public string Leaugename
        {
            get { return leaugename; }
            set { value = leaugename; }
        }

        public Football()
        {

        }

        public Football(int _noOfplayers, string _country, string _leaugename): base(_noOfplayers,_country)
        {
            noOfplayers = _noOfplayers;
            country = _country;
            leaugename = _leaugename;
        }
    }

    class ShowGameDetails
    {

            public void ShowCricketDetails(int noOfplayers, string country, string coachname)
        {
              Console.WriteLine("Country: {0} No of Players: {1} Coach Name: {2}", country, noOfplayers, coachname);

        }

        public void ShowFootBallDetails(int noOfplayers, string country, string leaugename)
        {
            
            Console.WriteLine("Country: {0} No of Players: {1} League Name: {2}", country, noOfplayers, leaugename);
            }

    }

    class ClassGame
    {
        static void Main()
        {
       
            Cricket India = new Cricket();
            Cricket Australia = new Cricket();

            Football Spain = new Football();
            Football England = new Football();

            ShowGameDetails show = new ShowGameDetails();
            Console.WriteLine("------------Cricket Information----------");
            show.ShowCricketDetails(11, "India", "John Wright");
            show.ShowCricketDetails(11, "Australia", "John Buchanan");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------FootBall Information----------");
            show.ShowFootBallDetails(11, "Spain", "Spanish League");
            show.ShowFootBallDetails(11, "England", "English Premiur League");
            Console.WriteLine();
            Console.WriteLine();
            Game obj = new Game();
            obj.ShowWorldCup("India", "Cricket");
            obj.ShowWorldCup("Spain", "Football");














        }
    }
}
