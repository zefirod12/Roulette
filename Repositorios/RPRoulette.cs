using System;
using System.Collections.Generic;
using System.Linq;

namespace Roulette.Controllers
{
    internal class RPRoulette
    {
        public static List<Properties> ListRoulette = new List<Properties>()
        {
        };
        public static List<Bet> ListBet = new List<Bet>()
        {
        };
        public void Add(Properties NewRoulette)
        {
            var ID = GetInformation();
            if (ID == null)
            {
                NewRoulette.Id = 1;
            }
            else
            {
                NewRoulette.Id = ID.Id + 1;
            }
            ListRoulette.Add(NewRoulette);
        }

        public IEnumerable<Properties> GetInformations()
        {
            return ListRoulette;
        }

        public Properties GetInformation()
        {
            var prueba = from num in ListRoulette
                         select num;
            //var Roulette = ListRoulette.Where(e => ListRoulette.Contains(id));
            try
            {
                return prueba.Last();
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public Properties GetInfo(int id)
        {
            var prueba = from num in ListRoulette
                         where num.Id == id
                         select num;
            //var Roulette = ListRoulette.Where(e => ListRoulette.Contains(id));
            try
            {
                return prueba.FirstOrDefault();
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public int BetOn(Bet newPropieties)
        {
            int Return = 0;
            if (newPropieties.Money >= 10000)
            {
                Return = 2;
                return Return;
            }
            Random random = new Random();
            int randomNumber = random.Next(0, 36);
            int randomColor = random.Next(0, 1);
            if (newPropieties.Selection == 1)
            {
                if (newPropieties.Number == randomNumber)
                {
                    Return = 1;
                }
            }
            else
            {
                int Color = 0;
                if (newPropieties.Color == "white")
                {
                    Color = 1;
                }
                if (Color == randomColor)
                {
                    Return = 1;
                }
                if (Color == randomColor)
                {
                    Return = 1;
                }
            }
            return Return;
        }

    }
}