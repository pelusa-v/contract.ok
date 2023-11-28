using contract.ok.helpers.ManualGenerator.Interfaces;

namespace contract.ok.helpers.ManualGenerator;

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
