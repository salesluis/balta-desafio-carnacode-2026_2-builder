using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Contracts;

public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder SetFormat(string format);
    IReportBuilder SetPeriod(DateTime startDate, DateTime endDate);
    IReportBuilder SetColumns(List<string> columns);
    IReportBuilder SetFilters(List<string> filters);
    IReportBuilder AddHeader(string headerText);
    IReportBuilder AddFooter(string footerText);
    IReportBuilder AddChart(string chartType);
    IReportBuilder IncludeSummary();
    IReportBuilder SortBy(string sortBy);
    IReportBuilder GroupBy(string groupBy);
    IReportBuilder IncludeTotals();
    IReportBuilder SetOrientation(string orientation);
    IReportBuilder PageSize(string pageSize);
    IReportBuilder IncludePageNumbers();
    IReportBuilder CompanyLogo(string companyLogo);
    IReportBuilder WaterMark(string waterMark);
    Report Build();
}