using contract.ok.helpers.Pdf;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

QuestPDF.Settings.License = LicenseType.Community;

// var contract = new SimpleContract("../contract.ok.helpers/Generator/Templates/contractType1.html", "Raul", "18");
// var generator = new ContractGenerator(contract);
// generator.ExecuteContractGeneration();

// var model = ContractDataSource.GetContractDetails("../contract.ok.helpers/Generator/Templates/contractType1.json", "Charizard", "ENTREGADOS SAC");
// var doc = new ContractDocument(model);
// doc.GeneratePdf("output.pdf");


var fields = new List<CustomizableContractField>()
{
    new CustomizableContractField("name", "Santiago"),
    new CustomizableContractField("society", "BONITOS S.A.C."),
    new CustomizableContractField("default_message", "Este es un mensaje customizado, no leerlo por favor!!!!!")
};
var contract = new Contract(fields, "../contract.ok.helpers/Pdf/Templates/contractType1.json");
var doc = new ContractDocument(contract.contractModel);
var generator = new ContractGenerator(doc);
generator.ExecutePdfGeneration("output.pdf");