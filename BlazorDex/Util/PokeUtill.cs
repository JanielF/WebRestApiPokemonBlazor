namespace BlazorDex.Util
{
    public static class PokeUtill
    {
        public const string Pokeball = "icons8-pokeball-50.png";

        public const string Pokeazul = "PokeAzul.png";

        public const string UltraBall = "gaming.png";

        public const string PokePoke = "gaming (2).png";

        public static string GetRandomBall()
        {
            var pokeballArray = new string[] { Pokeball, Pokeazul, UltraBall, PokePoke };

            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];

            return randomBall;
        }

        public static double GetPokemonHeightInMeters (int height)
        {
            return Convert.ToDouble(height) / 10;
        }

        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
