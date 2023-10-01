using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
     class CustomerIssue
    {
        private string custName;
        private string custId;
        private string custIssue;

        public CustomerIssue() { }

        public CustomerIssue(string custName,string custId,string custIssue)
        {
            this.custName = custName;
            this.custId = custId;
            this.custIssue = custIssue;
        }

        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }

        public string CustId
        {
            get { return custId; }
            set { custId = value; }
        }

        public string CustIssue
        {
            get { return custIssue; }
            set { custIssue = value; }
        }

    }
}
