namespace HandsOfCards2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HandsOfCards2
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var playerDeck = new Dictionary<string, List<string>>();
            var playerPoints = new Dictionary<string, List<int>>();
            while (entry != "JOKER")
            {
                var entryInformation = entry.Split(':').ToArray();
                var name = entryInformation[0];
                var deck = entryInformation[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!playerDeck.ContainsKey(name))
                {
                    playerDeck[name] = deck;
                }
                else
                {
                    playerDeck[name].AddRange(deck);                    
                }
                //var result = playerDeck.Select(x => x.Value.Distinct()).ToDictionary();
                entry = Console.ReadLine();
            }

            foreach (var d in playerDeck)
            {
                playerPoints[d.Key] = new List<int>();
                foreach (var card in d.Value)
                {
                    var cardPower = 0;
                    var cardType = string.Empty;
                    if (card.Length > 2)
                    {
                        cardPower = int.Parse((card[0] + card[1]).ToString());
                        cardType = card[2].ToString();
                    }
                    else
                    {
                        try
                        {
                            cardPower = int.Parse(card[0].ToString());
                        }
                        catch (Exception)
                        {

                            if (card == "A")
                            {
                                cardPower = 14;
                            }
                            else if (card == "K")
                            {
                                cardPower = 13;
                            }
                            else if (card == "Q")
                            {
                                cardPower = 12;
                            }
                            else if (card == "J")
                            {
                                cardPower = 11;
                            }
                        }

                        cardType = card[1].ToString();
                    }
                    var cardTypePoints = 0;
                    switch (cardType)
                    {
                        case "S":
                            cardTypePoints = 4;
                            break;
                        case "H":
                            cardTypePoints = 3;
                            break;
                        case "D":
                            cardTypePoints = 2;
                            break;
                        case "C":
                            cardTypePoints = 1;
                            break;
                    }
                    var points = cardPower * cardTypePoints;
                    playerPoints[d.Key].Add(points);
                }
            }
            foreach (var kpv in playerPoints)
            {
                Console.WriteLine(kpv.Key + ": " + kpv.Value.Sum());
            }
        }
    }
}
