namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {

            var text = Console.ReadLine();
            var playerDeck = new Dictionary<string, List<int>>();

            while (text != "JOKER")
            {
                var line = text.Split(':');
                var playerName = line[0];
                var playerCars = line[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var deck = new List<int>();
                foreach (var card in playerCars)
                {
                    var type = 0;
                    var power = 0;
                    if (card.Length < 3)
                    {
                        var cardPower = card[0].ToString();
                        var cardType = card[1].ToString();

                        if (cardPower == "J")
                        {
                            power = 11;
                        }
                        else if (cardPower == "Q")
                        {
                            power = 12;
                        }
                        else if (cardPower == "K")
                        {
                            power = 13;
                        }
                        else if (cardPower == "A")
                        {
                            power = 14;
                        }
                        else if (cardPower == "2")
                        {
                            power = 2;
                        }
                        else if (cardPower == "3")
                        {
                            power = 3;
                        }
                        else if (cardPower == "4")
                        {
                            power = 4;
                        }
                        else if (cardPower == "5")
                        {
                            power = 5;
                        }
                        else if (cardPower == "6")
                        {
                            power = 6;
                        }
                        else if (cardPower == "7")
                        {
                            power = 7;
                        }
                        else if (cardPower == "8")
                        {
                            power = 8;
                        }
                        else if (cardPower == "9")
                        {
                            power = 9;
                        }
                        if (cardType == "S")
                        {
                            type = 4;
                        }
                        if (cardType == "H")
                        {
                            type = 3;
                        }
                        if (cardType == "D")
                        {
                            type = 2;
                        }
                        if (cardType == "C")
                        {
                            type = 1;
                        }
                    }
                    else
                    {
                        power = 10;
                        var cardType = card[2].ToString();
                        if (cardType == "S")
                        {
                            type = 4;
                        }
                        if (cardType == "H")
                        {
                            type = 3;
                        }
                        if (cardType == "D")
                        {
                            type = 2;
                        }
                        if (cardType == "C")
                        {
                            type = 1;
                        }
                    }
                    deck.Add(power * type);
                   
                }
                if (!playerDeck.Keys.Contains(playerName))
                {
                    playerDeck[playerName] = new List<int>();
                }
                    playerDeck[playerName].AddRange(deck);
            

                text = Console.ReadLine();
            }
            foreach (var player in playerDeck)
            {
                var sum = player.Value.Distinct().Sum();
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}


