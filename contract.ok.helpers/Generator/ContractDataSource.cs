using System.Text.Json;

namespace contract.ok.helpers.Generator;

public static class ContractDataSource
{
    public static ContractModel GetContractDetails(string path, string name, string society)
    {
        var jsonContent = File.ReadAllText(path);
        var json = JsonSerializer.Deserialize<ContractTemplate>(jsonContent);
        json.Body = json.Body.Replace("{name}", name);
        json.Body = json.Body.Replace("{society}", society);

        return new ContractModel
        {
            ClientName = "Tomy",
            ContractDescription = json.Body,
            Comments = new List<string>()
            {
                "Soy un comentario",
                "Otro comentario",
                "Comentario raro",
                "Sigo haciendo comentarios"
            }
        };
    }
}
