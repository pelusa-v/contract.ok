using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace contract.ok.helpers.Pdf;

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
                page.Content().Element(ComposeContent);

                page.Footer().AlignCenter().Text(x =>
                {
                    x.CurrentPageNumber();
                    x.Span(" / ");
                    x.TotalPages();
                });
            });
    }

    void ComposeContent(IContainer container)
    {
        container.PaddingVertical(40).Column(column =>
        {
            column.Spacing(5);
            column.Item().Element(ComposeBody);
        });
    }

    void ComposeBody(IContainer container)
    {
        container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
        {
            column.Spacing(5);
            column.Item().Text("Contenido:").FontSize(14);
            column.Item().Text(Model.Body);
        });
    }
}
