using contract.ok.helpers;

var contract = new SimpleContract("../contract.ok.helpers/Generator/Templates/contractType1.html", "Raul", "18");
var generator = new ContractGenerator(contract);
generator.ExecuteContractGeneration();

//