using System.Text.Json;

namespace aula_8
{
    internal class Program
    {
        static void Main()
        {
            GetWeather().Wait();
           
        }

        static string GetCity()
        {
            Console.Write("Relatório Climático\n\n" +
                "Qual seu país? ");
            string cidade = Console.ReadLine();

            return cidade;
        }

        static string GetUrl()
        {
            return $"http://api.weatherapi.com/v1/astronomy.json?key={GetApiKey()}&q={GetCity()}&lang=pt";
        }

        static string GetApiKey()
        {
            return "1aba4342ed1b4daba44190007252702";
        }

        static async Task GetWeather()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(GetUrl());

                    Console.WriteLine(response.Content.ReadAsStringAsync().Result.Replace(",", "\n").Replace("}", "\n").Replace("{", "\n"));
                    Console.WriteLine("------------------------");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }

            }
        }
    }

}