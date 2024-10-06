using Server.Modal;

namespace Server.Service
{
    public class ReportService
    {
        public ReportService() { }
        public Report[] GetAllReport() { return new Report[0]; }
        public Report GetReport(int id) { return new Report(); }
        public void Create(Report reportObj) { return; }
    }
}
