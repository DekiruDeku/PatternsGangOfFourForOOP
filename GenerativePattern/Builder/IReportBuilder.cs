namespace Builder
{
    public interface IReportBuilder
    {
        IReportBuilder BuildHead();

        IReportBuilder BuildMiddle();

        IReportBuilder BuildBack();

        Report GetReport();
    }
}