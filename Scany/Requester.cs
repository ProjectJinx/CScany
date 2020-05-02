using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scany
{
    public class Requester
    {
        private static RestClient client;
        private static Token tk;
        private static List<Device> devices; 

        public static void Init(string path)
        {
            client = new RestClient(path);
            client.UseJson();
        }

        public static Token GetToken(string data)
        {
            var request = new RestRequest("AuthClient", Method.POST);
            request.AddJsonBody(new Auth(data));

            var response = client.Post(request);
            tk = JsonConvert.DeserializeObject<Token>(response.Content);
            return tk;
        }

        public static List<Device> GetDevices()
        {
            var request = new RestRequest("/Scanner", Method.POST);
            request.AddParameter("text/xml", tk.token, ParameterType.RequestBody);

            var response = client.Post(request);
            try
            {
                devices = JsonConvert.DeserializeObject<List<Device>>(response.Content);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return devices;
        }
    }
}
