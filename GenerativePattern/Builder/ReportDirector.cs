namespace Builder
{
    public class ReportDirector
    {
        private IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public void BuildFullReport()
        {
            _builder
                .BuildHead()
                .BuildMiddle()
                .BuildBack();
        }

        public void BuildReportWithoutAHead()
        {
            _builder
                .BuildMiddle()
                .BuildBack();
        }

        public void BuildReportWithoutABack()
        {
            _builder
                .BuildHead()
                .BuildMiddle();
        }
    }
}