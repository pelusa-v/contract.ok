namespace contract.ok.helpers;

public class SimpleContract : Contract, IContractGenerator
{
    // public Contract Contract { get; set; }

    public SimpleContract(string template, string name, string age)
    {
        Template = template;
        EditableFields = new List<ContractEditableField>(){
            new ContractEditableField(name, "name"),
            new ContractEditableField(age, "age"),
        };
    }

    public void GenerateContractPDF()
    {
        string htmlContent = File.ReadAllText(Template);
        
        foreach (var field in EditableFields)
        {
            htmlContent = htmlContent.Replace($"{{{field.KeyInContract}}}", field.Name);
        }

        // System.IO.File.WriteAllBytes("output.pdf", pdfBytes);

        // var output = "output.html";
        // File.WriteAllText(output, htmlContent);
    }
}
