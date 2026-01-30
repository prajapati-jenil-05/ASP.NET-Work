using System.Globalization;

namespace CMS2026.Models
{
    public class LoanModel
    {
        public int LoanNo { get; set; }
        public int AccountNo { get; set; }
        public string LoanCategory { get; set; }
        public string LoanType { get; set; }
        public string LoanDate { get; set; }
        public int Amount { get; set; }
        public string CurrentAddress { get; set; }
        public string LoanRemarks { get; set; }
    }
}
