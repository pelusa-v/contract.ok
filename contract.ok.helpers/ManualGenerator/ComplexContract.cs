using contract.ok.helpers.ManualGenerator.Interfaces;

namespace contract.ok.helpers.ManualGenerator;

public class ComplexContract : Contract, IContractGenerator
{
    public ComplexContract(string template, string name, string lastName, string brand, string drink, string food)
    {
        Template = template;
        EditableFields = new List<ContractEditableField>(){
            new ContractEditableField(name, "name"),
            new ContractEditableField(lastName, "lastName"),
            new ContractEditableField(brand, "brand"),
            new ContractEditableField(drink, "drink"),
            new ContractEditableField(food, "food"),
        };
    }

    public void GenerateContractPDF()
    {
        throw new NotImplementedException();
    }
}
