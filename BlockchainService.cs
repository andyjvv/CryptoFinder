using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class BlockchainService
{
    private string baseUrl = "https://api.blockcypher.com/v1/btc/main/";

    public async Task<BlockInfo> GetBlockAsync(string blockHash)
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetStringAsync($"{baseUrl}blocks/{blockHash}");
            return JsonConvert.DeserializeObject<BlockInfo>(response);
        }
    }

    // Métodos similares para transacciones, direcciones, etc.
}
