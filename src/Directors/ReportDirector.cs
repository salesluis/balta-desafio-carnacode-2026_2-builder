using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Directors;

public class ReportDirector
{
    public Report GenerateSalesMensal(IReportBuilder builder)
    {
        builder
            .SetTitle("Vendas Mensais")
            .SetFormat("PDF")
            .SetPeriod(
                new DateTime(2024, 1, 1),
                new DateTime(2024, 1, 31))
            .AddHeader("Relatório de vendas Mensal")
            .AddFooter("Confidencial")
            .AddChart("Bar")
            .IncludeSummary()
            .SetColumns(new List<string>{"Produto", "Quantidade",  "Valor"})
            .SetFilters(new List<string>{"Status=ativo"})
            .SortBy("valor")
            .GroupBy("Categoria")
            .IncludeTotals()
            .SetOrientation("portrait")
            .PageSize("A4") 
            .IncludePageNumbers()
            .CompanyLogo("logo.png")
            .WaterMark("confidencial");
        
        return builder.Build();
    }
    
    public Report GenerateSalesTrimestral(IReportBuilder builder)
    {
        builder
            .SetTitle("Relatório Trimestral")
            .SetFormat("Excel")
            .SetPeriod(
                new DateTime(2024, 1, 1),
                new DateTime(2024, 3, 31))
            .AddHeader("Relatório Trimestral")
            .AddChart("Line")
            .SetColumns(new List<string> { "Vendedor", "Região", "Total" })
            .SetFilters(new List<string> { "Status=ativo" })
            .GroupBy("Região")
            .IncludeTotals();
        
        return builder.Build();
    }
    
    public Report GenerateSalesAnual(IReportBuilder builder)
    {
        builder
            .SetTitle("Vendas Anuais teste")
            .SetFormat("PDF")
            .SetPeriod(
                new DateTime(2024, 1, 1),
                new DateTime(2024, 12, 31))
            .AddHeader("Relatório de Vendas Anual")
            .AddFooter("Confidencial")
            .AddChart("Pie")
            // .IncludeSummary()
            .SetColumns(new List<string> { "Produto", "Quantidade", "Valor" })
            .SetFilters(new List<string> { "Statu=ativo" })
            .GroupBy("Região")
            .IncludeTotals()
            .SetOrientation("Landscape")
            .PageSize("A4");
        
        return builder.Build();
    }
}