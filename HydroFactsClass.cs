using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroHomie
{
    class HydroFactsClass
    {
        public Random number = new Random();
        public string pretext = "Did you know?\n";
        public bool showFacts = true;

        public string GenerateEitherFact()
        {
            switch (number.Next(0, 1))
            {
                case 0:
                    return GenerateEducationalFact();
                case 1:
                    return GenerateHealthFact();
                default:
                    return GenerateEducationalFact();
            }
        }

        public string GenerateHealthFact()
        {
            switch (number.Next(0, 13))
            {
                case 0:
                    return pretext + "Water helps with Joint Pain!";
                case 1:
                    return pretext + "Water helps you digest your food!";
                case 2:
                    return pretext + "Water is needed to carry Oxygen throughout your body!";
                case 3:
                    return pretext + "It increases Skin Health!";
                case 4:
                    return pretext + "Drinking water cushions your sensitive tissues such as your Brain or Spinal Cord!";
                case 5:
                    return pretext + "Water helps you regulate your body heat! (Super important if you do a lot of sports!)";
                case 6:
                    return pretext + "Your digestive system doesn't work without it!";
                case 7:
                    return pretext + "Your body can't remove waste without water!";
                case 8:
                    return pretext + "Airways become restricted when you're dehydrated!";
                case 9:
                    return pretext + "It makes minerals and nutrients reach all your body!";
                case 10:
                    return pretext + "Drinking water can prevent Kidney Stones! (ouch)";
                case 11:
                    return pretext + "Water can increase performance during exorcise! 👀";
                case 12:
                    return pretext + "Water can help with weightloss! (Ditch the Fizzy Drinks, bro)";
                case 13:
                    return pretext + "Water can reduce the chance of a Hang-over!";
                default:
                    return "Fact not found :x";
            }
        }

        public string GenerateEducationalFact()
        {
            switch (number.Next(0, 20))
            {
                case 0:
                    return pretext + "70% of the human brain is water!";
                case 1:
                    return pretext + "30% of fresh water is in the ground!";
                case 2:
                    return pretext + "Water weighs about 8 pounds a gallon!";
                case 3:
                    return pretext + "A jellyfish and a cucumber are each 95% water!";
                case 4:
                    return pretext + "Refilling a half-liter water bottle 1,740 times with tap water is the equivalent cost of a 99 cent water bottle at a convenience store!";
                case 5:
                    return pretext + "Over 90% of the world’s supply of fresh water is located in Antarctica!";
                case 6:
                    return pretext + "NASA has discovered water in the form of ice on the moon!";
                case 7:
                    return pretext + "1 slice of bread requires 11 gallons of water to make!";
                case 8:
                    return pretext + "500 sheets of paper requires 1,321 gallons of water!";
                case 9:
                    return pretext + "There is about the same amount of water on Earth now as there was millions of years ago!";
                case 10:
                    return pretext + "Americans drink more than one billion glasses of tap water per day!";
                case 11:
                    return pretext + "A bath uses up to 70 gallons of water; a five-minute shower uses 10 to 25 gallons!";
                case 12:
                    return pretext + "Water covers 70.9 percent of the planet’s surface!";
                case 13:
                    return pretext + "A running toilet can waste up to 200 gallons of water each day!";
                case 14:
                    return pretext + "It takes 39,090 gallons of water to manufacture a new car!";
                case 15:
                    return pretext + "It takes 2,641 gallons of water to make a pair of jeans!";
                case 16:
                    return pretext + "It takes 924 gallons of water to produce 2.2 pounds of rice!";
                case 17:
                    return pretext + "It takes 3,962 gallons of water to produce 2.2 pounds of beef!";
                case 18:
                    return pretext + "Leaks in the New York City water supply system account for 36 million gallons of wasted water per day!";
                case 19:
                    return pretext + "At one drip per second, a faucet can leak 3,000 gallons in a year!";
                case 20:
                    return pretext + "There is more water in the atmosphere than in all of our rivers combined!";
                default:
                    return "Fact not found :x";
            }
        }
    }
}
