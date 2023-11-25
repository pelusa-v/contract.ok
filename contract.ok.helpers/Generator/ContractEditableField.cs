namespace contract.ok.helpers;

public class ContractEditableField
{
    public string Name { get; set; }
    public string KeyInContract { get; set; }

    public ContractEditableField(string name, string keyInContract)
    {
        Name = name;
        KeyInContract = keyInContract;
    }
}
