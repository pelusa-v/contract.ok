using contract.ok.helpers.Generator;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace contract.ok.helpers;

public class ContractDocument : IDocument
{
    public ContractModel Model { get; }

    public ContractDocument(ContractModel model)
    {
        Model = model;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public DocumentSettings GetSettings() => DocumentSettings.Default;

    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                page.Margin(50);
                // page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
            });
    }

    void ComposeContent(IContainer container)
    {
        container.PaddingVertical(40).Column(column =>
        {
            column.Spacing(5);
            column.Item().Element(ComposeContractDetails);
        });
    }

    void ComposeContractDetails(IContainer container)
    {
        // container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
        container.Padding(10).Column(column =>
        {
            column.Spacing(5);
            column.Item().Text("Description:").FontSize(14);
            column.Item().Text(Model.ContractDescription);
        });
    }
}
