using DesignPatternChallenge.Directors;
using DesignPatternChallenge.Builders;
Console.WriteLine("################################################");

// Reutiliza o mesmo director para todos os relatórios
var director = new ReportDirector();

// Mensal
var builderMensal = new SalesReportBuilder();
var salesReportMensal = director.GenerateSalesMensal(builderMensal);

Console.WriteLine("###################  MENSAL  ######################");
salesReportMensal.Generate();

// Trimestral
var builderTrimestral = new SalesReportBuilder();
var salesReportTrimestral = director.GenerateSalesTrimestral(builderTrimestral);

Console.WriteLine("###################  TRIMESTRAL  ######################");
salesReportTrimestral.Generate();

// Anual
var builderAnual = new SalesReportBuilder();
var salesReportAnual = director.GenerateSalesAnual(builderAnual);

Console.WriteLine("###################  ANUAL  ######################");
salesReportAnual.Generate();