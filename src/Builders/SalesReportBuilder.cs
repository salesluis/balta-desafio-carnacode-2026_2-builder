using DesignPatternChallenge.Contracts;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Builders;

public class SalesReportBuilder : IReportBuilder
{
    private Report _report = new();

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder SetFormat(string format)
    {
        _report.Format = format;
        return this;
    }

    public IReportBuilder SetPeriod(DateTime startDate, DateTime endDate)
    {
        _report.StartDate = startDate;
        _report.EndDate = endDate;
        return this;
    }

    public IReportBuilder SetColumns(List<string> columns)
    {
        _report.Columns = columns;
        return this;
    }

    public IReportBuilder SetFilters(List<string> filters)
    {
        _report.Filters = filters;
        return this;
    }

    public IReportBuilder AddHeader(string headerText)
    {
        _report.IncludeHeader = true;
        _report.HeaderText = headerText;
        return this;
    }

    public IReportBuilder AddFooter(string footerText)
    {
        _report.IncludeFooter = true;
        _report.FooterText = footerText;
        return  this;
    }

    public IReportBuilder AddChart(string chartType)
    {
        _report.IncludeCharts = true;
        _report.ChartType = chartType;
        return  this;
    }

    public IReportBuilder IncludeSummary()
    {
        _report.IncludeSummary = true;
        return this;
    }

    public IReportBuilder SortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public IReportBuilder GroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public IReportBuilder IncludeTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }

    public IReportBuilder SetOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public IReportBuilder PageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public IReportBuilder IncludePageNumbers()
    {
        _report.IncludePageNumbers = true;
        return this;
    }

    public IReportBuilder CompanyLogo(string companyLogo)
    {
        _report.CompanyLogo = companyLogo;
        return this;
    }

    public IReportBuilder WaterMark(string waterMark)
    {
        _report.WaterMark = waterMark;
        return this;
    }

    public Report Build() 
        =>  _report;
}