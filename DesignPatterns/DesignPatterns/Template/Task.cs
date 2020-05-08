using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public abstract class Task
    {
        private AuditTrail AuditTrail;

        public Task()
        {
            AuditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            this.AuditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditTrail.Record();

            DoExecute();
        }
        protected abstract void DoExecute();
    }
}
