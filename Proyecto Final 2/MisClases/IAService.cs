using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AsistenteTramitesJutiapa
{
    public class IAService
    {
        private readonly string apiKey = "";

        public async Task<string> ObtenerRespuestaIA(string pregunta)
        {
            var url = "https://api.openai.com/v1/chat/completions";

            var requestData = new
            {
                model = "gpt-3.5-turbo",
                messages = new[] {
                   new { role = "system", content = "Eres un asistente virtual especializado en responder preguntas únicamente relacionadas con trámites realizados en el departamento de Jutiapa, Guatemala. " +
    "Si la pregunta no se relaciona con trámites o servicios en Jutiapa, responde estrictamente con: 'Solo puedo responder preguntas sobre trámites en Jutiapa, Guatemala.' " +
    "Pero si la pregunta es sobre algún trámite, responde de forma clara y útil." },
                    new { role = "user", content = pregunta }
                }
            };

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var response = await httpClient.PostAsync(url,
                new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json"));

            var result = await response.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(result);
            return json.choices[0].message.content.ToString();
        }
    }
}
