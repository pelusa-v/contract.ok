namespace contract.ok.helpers;

public class ContractTemplate
{
    private readonly string _source;
    public string TemplateType { get; set; }

    public ContractTemplate(string source, string type)
    {
        _source = source;
        TemplateType = type;
    }
}
