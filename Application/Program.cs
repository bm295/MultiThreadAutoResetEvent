using Application;

var programContext = new ProgramContext();
programContext.ShowAllOptions();

Console.Write("Enter option:");
var option = Convert.ToInt32(Console.ReadLine());
programContext.RunWith(option);