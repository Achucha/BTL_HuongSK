using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class BAOCAO : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLCHTL_connectionString"].ConnectionString;

        public BAOCAO()
        {
            InitializeComponent();
        }

        private void BAOCAO_Load(object sender, EventArgs e)
        {

        }

        public void Showreport(string tenBaoCao, string tenProc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = tenProc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);

                                //Load du lieu len bao cao
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("C:\\Users\\PC\\source\\repos\\BTL\\BTL\\Report\\BAOCAOHANGHOA.rpt", Application.StartupPath, tenBaoCao);
                                report.Load(path);

                                report.Database.Tables[tenProc].SetDataSource(dt);
                                report.SetParameterValue("sNguoilap", "NGUYỄN QUANG DŨNG");
                                crystalReportViewer1.ReportSource = report;
                                crystalReportViewer1.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }


        public void Showreport_theoloai(string tenBaoCao, string tenProc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = tenProc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);

                                //Load du lieu len bao cao
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("C:\\Users\\PC\\source\\repos\\BTL\\BTL\\Report\\BAOCAOLOAI.rpt", Application.StartupPath, tenBaoCao);
                                report.Load(path);

                                report.Database.Tables[tenProc].SetDataSource(dt);
                                report.SetParameterValue("sNguoilapbaocao", "NGUYỄN QUANG DŨNG");
                                crystalReportViewer1.ReportSource = report;
                                crystalReportViewer1.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

    }
}
