using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public class ReportBuilder : IReportBuilder
    {
        private Report _report;
        private IEnumerable<Worker> _workers;

        public ReportBuilder(IEnumerable<Worker> workers)
        {
            _workers = workers;
            _report = new Report();
        }

        public IReportBuilder BuildHead()
        {
            _report.ChangeAHeadOfReport("Report Head\n" 
                                        + "_________________________________________________________________\n");
            return this;
        }

        public IReportBuilder BuildMiddle()
        {
            _report.ChangeAMiddleOfReport(string.Join(Environment.NewLine,_workers.Select(w=>$"name of workers {w.Name} and him Salary {w.Money}")));
            return this;
        }

        public IReportBuilder BuildBack()
        {
            _report.ChangeABackOfReport("\n___________________________________________________________\n"
                                        +$"Total Workers {_workers.Count()}, and sum of the salary {_workers.Sum(w => w.Money)}\n");
            return this;
        }

        public Report GetReport()
        {
            var finreport = _report;
            _report = new Report();
            return finreport;
        }
    }
}