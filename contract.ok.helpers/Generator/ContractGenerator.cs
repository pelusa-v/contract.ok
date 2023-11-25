namespace contract.ok.helpers;

public class ContractGenerator
{
    private readonly IContractGenerator _contract;

    public ContractGenerator(IContractGenerator contract)
    {
        _contract = contract;
    }

    public void ExecuteContractGeneration()
    {
        _contract.GenerateContractPDF();
    }
}
