using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionRandomizer_SeanMedina
{
    public enum DominionSet
    {
        Base,
        BasicSupply,
        Intrigue,
        Seaside,
        Alchemy,
        Prosperity,
        Cornucopia,
        Hinterlands,
        DarkAges,
        Guilds,
        Adventures,
        Empires,
        Nocturne,
        Promo,
        BaseSecondEdition,
        IntrigueSecondEdition
    }

    public enum DominionCardType
    {
        Action = 0,
        Attack,
        Treasure,
        Curse,
        Victory,
        Reaction,
        Duration,
        Prize,
        Shelter,
        Ruins,
        Looter,
        Knight,
        Reserve,
        Traveller,
        Gathering,
        Castle
    }

    public static class Dominion
    {

    }

    [Serializable]
    public class DominionCard
    {
        // Card name
        public string Name
        {
            get;
            private set;
        }

        // Expansion / collection to which the card belongs.
        public DominionSet Set
        {
            get;
            private set;
        }

        // Defines the behavior / interactions of the card.
        public List<DominionCardType> Types
        {
            get;
            private set;
        } 

        public string TypesString
        {
            get
            {
                string types = String.Empty;

                // Create the formatted type string used on the actual cards.
                // First type? No hyphen.
                for (int i = 0; i < Types.Count; ++i)
                    types += ((i == 0) ? "" : "-") + Types[i].ToString();

                return types;
            }
        }

        // Number of coins required to buy the card.
        public int CoinCost
        {
            get;
            private set;
        }

        // True if the card requires a potion to buy.
        public bool CostsAPotion
        {
            get;
            private set;
        }

        // Card description
        public string Text
        {
            get;
            private set;
        }

        // Instance CTOR
        public Dominion(string name, string text, DominionSet set, List<DominionCardType> types, int coinCost, bool costsAPotion = false)
        {
            Name = name;
            Text = text;
            Set = set;
            Types = types;
            CoinCost = coinCost;
            CostsAPotion = costsAPotion;
        }

        public override int GetHashCode()
        {
            // Using anon. type.
            return new { Name, Set }.GetHashCode();
        }
    }
}
