using System.Text.Json;

namespace contract.ok.helpers.Pdf;

public class Contract
{
    private readonly List<CustomizableContractField> _fields;
    private readonly string _templatePath;

    public readonly ContractModel contractModel;

    public Contract(List<CustomizableContractField> fields, string templatePath)
    {
        _fields = fields;
        _templatePath = templatePath;

        var contractTemplateContent = File.ReadAllText(_templatePath);
        contractModel = JsonSerializer.Deserialize<ContractModel>(contractTemplateContent);
        
        foreach (var field in fields)
        {
            contractModel.Body = contractModel.Body.Replace($"{{{field.FieldKey}}}", field.FieldValue);   
        }
    }
}
