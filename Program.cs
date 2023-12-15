using System;
using Alpaca.Markets;
using System.Threading.Tasks;

namespace AlpacaExample
{
    internal static class Program
    {
        private const String KEY_ID = "PKUPOVPGCHJIVR5B0BEC";

        private const String SECRET_KEY = "kheLqZujdbPtIdv9x6i9pGfG8IveBBewaGJlNksT";

        public static async Task Main()
        {
            var client = Environments.Paper
                .GetAlpacaTradingClient(new SecretKey(KEY_ID, SECRET_KEY));

            var clock = await client.GetClockAsync();

            if (clock != null)
            {
                Console.WriteLine(
                    "Timestamp: {0}, NextOpen: {1}, NextClose: {2}",
                    clock.TimestampUtc, clock.NextOpenUtc, clock.NextCloseUtc);
            }
        }
    }
}