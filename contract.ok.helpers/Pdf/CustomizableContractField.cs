namespace contract.ok.helpers.Pdf;

public class CustomizableContractField
{
    public string FieldKey { get; set; }
    public string FieldValue { get; set; }

    public CustomizableContractField(string key, string value)
    {
        FieldKey = key;
        FieldValue = value;
    }
}
