using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace contract.ok.helpers.Pdf;

public class ContractGenerator
{
    private readonly IDocument _contractDocument;

    public ContractGenerator(IDocument contractDocument)
    {
        _contractDocument = contractDocument;
    }

    public void ExecutePdfGeneration(string path)
    {
        _contractDocument.GeneratePdf(path);
    }
}
