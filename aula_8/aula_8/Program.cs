using System.Text.Json;

namespace aula_8
{
    internal class Program
    {
        static async Task Main()
        {
            string apiKey = "1aba4342ed1b4daba44190007252702";
            string cidade = "Sobral";
            string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={cidade}&lang=pt";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result.Replace(",", "\n"));
                    Console.WriteLine("------------------------");

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();

                        // Parseando o JSON
                        using (JsonDocument jsonDoc = JsonDocument.Parse(data))
                        {
                            JsonElement root = jsonDoc.RootElement;
                            JsonElement location = root.GetProperty("location");
                            JsonElement current = root.GetProperty("current");

                            string nomeCidade = location.GetProperty("name").GetString();
                            string regiao = location.GetProperty("region").GetString();
                            string pais = location.GetProperty("country").GetString();
                            double temperatura = current.GetProperty("temp_c").GetDouble();
                            string condicao = current.GetProperty("condition").GetProperty("text").GetString();

                            Console.WriteLine($"Clima em {nomeCidade}, {regiao}, {pais}:");
                            Console.WriteLine($"Temperatura: {temperatura}°C");
                            Console.WriteLine($"Condição: {condicao}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro ao buscar dados: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }
    }
}


//     1aba4342ed1b4daba44190007252702