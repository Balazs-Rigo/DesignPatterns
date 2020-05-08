using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class GenerateReportTask
    {
        private AuditTrail AuditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.AuditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditTrail.Record();
            Console.WriteLine("Generate Report!");
        }
    }
}
