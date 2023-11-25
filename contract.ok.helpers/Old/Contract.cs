using contract.ok.helpers.Old.Interfaces;

namespace contract.ok.helpers.Old;

public class Contract : IContract
{
    private readonly ContractTemplate _template;

    public Contract(ContractTemplate template)
    {
        _template = template;
    }

    public byte[] GenerateContractPDF()
    {
        switch(_template.TemplateType)
        {
            case "complex":
                // something
                break;
            case "simple":
                // other stuff
                break;
            case "other":
                // other
                break;
            default:
                break;
        }

        return new byte[]{};
    }
}
