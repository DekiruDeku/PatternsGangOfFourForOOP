using System.Text;

namespace Builder
{
    public class Report
    {
        private string _headOfReport;
        private string _middleOfReport;
        private string _backOfReport;

        public string HeadOfReport 
        {
            get
            {
                return _headOfReport;
            }
            private set
            {
                _headOfReport = value;
            }
        }
        public string MiddleOfReport 
        {
            get
            {
                return _middleOfReport;
            }
            private set
            {
                _middleOfReport = value;
            }
        }
        public string BackOfReport
        {
            get
            {
                return _backOfReport;
            }
            private set
            {
                _backOfReport = value;
            }
        }

        public void ChangeAHeadOfReport(string change)
        {
            _headOfReport = change;
        }
        
        public void ChangeAMiddleOfReport(string change)
        {
            _middleOfReport = change;
        }
        
        public void ChangeABackOfReport(string change)
        {
            _backOfReport = change;
        }

        public override string ToString() => new StringBuilder()
            .Append(HeadOfReport)
            .Append(MiddleOfReport)
            .Append(BackOfReport)
            .ToString();
    }
}