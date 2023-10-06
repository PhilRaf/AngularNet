using angularnet.Interface;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace angularnet.Implement
{
    public class ImPricing : IPricing
    {
        public async Task<decimal?> FetchPriceAsync(int id)
        {

            UriBuilder builder = new UriBuilder("https://localhost:7080/api/FetchPrice");
            string Baseurl = "https://localhost:7080/api/FetchPrice";
            // Aggiungi i parametri come coppie chiave-valore
            var query = System.Web.HttpUtility.ParseQueryString(builder.Query);
            query["parametro1"] = id.ToString();
          
            // Aggiorna la query nell'UriBuilder
            builder.Query = query.ToString();

            // Ottieni l'URL completo con i parametri
            string urlWithParameters = builder.ToString();

            
            try
            {
                using (var client = new HttpClient())
                {

                    List<Object> EmpInfo = new List<Object>();

                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    //Define request data format
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Sending request 
                    HttpResponseMessage Res = await client.GetAsync(urlWithParameters);
                    //Checking the response is successful or not which is sent using HttpClient
                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                        //Deserializing the response recieved from web api and storing into the Employee list
                        EmpInfo = JsonConvert.DeserializeObject<List<Object>>(EmpResponse);


                        foreach (var item in EmpInfo)
                        {


                        }
                    }

                }
            }
            catch (Exception ex) 
            {

                throw new Exception();
            
            }


        





            throw new NotImplementedException();
        }
    }

}




