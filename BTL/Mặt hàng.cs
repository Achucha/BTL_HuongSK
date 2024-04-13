using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace BTL
{

    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private string connectionString = ConfigurationManager.ConnectionStrings["QLCHTL_connectionString"].ConnectionString;
        private DataView dvMATHANG = new DataView();
        private string ngayNhap;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDataMaLoaiHang(string filter = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                string query1 = "SELECT MaLoaiHang FROM tblLoaiHang";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        cb_maloaihang.Items.Clear();


                        while (reader.Read())
                        {
                            cb_maloaihang.Items.Add(reader["MaLoaiHang"].ToString());

                        }
                    }
                }

            }
        }
        private void ResetData()
        {
            tb_mahang.Text =
            tb_tenhang.Text =
            tb_soluong.Text =
            tb_loaihang.Text =
            tb_dvt.Text =
            cb_maloaihang.Text = string.Empty;
            mtb_ngaynhap.ResetText();
            tb_mahang.Focus();
        }
        private void Loaddshh(string filter = "")
        {
            string query = "select_DSMH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                dvMATHANG = dataTable.DefaultView;
                                dgv_dshh.AutoGenerateColumns = false;
                                if (!string.IsNullOrEmpty(filter))
                                {
                                    dvMATHANG.RowFilter = filter;
                                }
                                dgv_dshh.DataSource = dvMATHANG;
                            }
                            else
                            {
                                MessageBox.Show("Khong co ban ghi nao");
                            }
                        }
                    }
                }
            }
        }


        public bool IsNumber(string strValue)
        {
            foreach (Char ch in strValue)
            {
                if (!Char.IsDigit(ch))
                    return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddshh();
            LoadDataMaLoaiHang();
           
        }

        private void tb_mahang_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_mahang.Text))
            {
                errorProvider.SetError(tb_mahang, "Mã hàng không được để trống");
            }
            else
            {
                errorProvider.SetError(tb_mahang, null);
            }
        }

        private void tb_tenhang_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_tenhang.Text))
            {
                errorProvider.SetError(tb_tenhang, "Tên hàng không được để trống");
            }
            else
            {
                errorProvider.SetError(tb_tenhang, null);
            }
        }

        private void mtb_ngaynhap_Validating(object sender, CancelEventArgs e)
        {
            if (mtb_ngaynhap.MaskFull)
            {
                try
                {
                    DateTime dateTime = Convert.ToDateTime(mtb_ngaynhap.Text);
                    ngayNhap = dateTime.ToString("yyyy/MM/d");
                }
                catch
                {
                    MessageBox.Show("Ngày không hợp lệ");
                    mtb_ngaynhap.ResetText();
                }
            }
        }

        private void dtp_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            mtb_ngaynhap.Text = dtp_ngaynhap.Value.ToString();
            DateTime dateTime1 = Convert.ToDateTime(mtb_ngaynhap.Text);
            ngayNhap = dateTime1.ToString("yyyy/MM/d");
        }

        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(tb_soluong.Text))
            {
                errorProvider.SetError(tb_soluong, "Số lượng là số nguyên");
            }
            else
            {
                errorProvider.SetError(tb_soluong, null);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string mahang = tb_mahang.Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    using(SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select_tblMatHang";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahang", mahang);
                        conn.Open();
                        var mahang_SQl = cmd.ExecuteScalar();
                        conn.Close();
                        if(mahang_SQl == null)
                        {
                            using(SqlDataAdapter adapter=new SqlDataAdapter())
                            {
                                adapter.SelectCommand = new SqlCommand("SELECT * FROM tblMatHang", conn);
                                DataTable dtMATHANG = new DataTable("tblMatHang");
                                adapter.Fill(dtMATHANG);

                                DataSet ds= new DataSet();
                                ds.Tables.Add(dtMATHANG);
                                DataRow newRow = dtMATHANG.NewRow();
                                newRow["MaHang"] =this.tb_mahang.Text;
                                newRow["TenHang"] =this.tb_tenhang.Text;
                                newRow["NgayNhap"] = ngayNhap;
                                newRow["SoLuong"] = this.tb_soluong.Text;
                                newRow["DVT2"] =this.tb_dvt.Text;
                                newRow["MaLoaiHang"] = this.cb_maloaihang.Text;
                                dtMATHANG.Rows.Add(newRow);

                                cmd.CommandText = "insert_tblMatHang";
                                cmd.CommandType= CommandType.StoredProcedure;
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@mahang", this.tb_mahang.Text);
                                cmd.Parameters.AddWithValue("@tenhang", this.tb_tenhang.Text);
                                cmd.Parameters.AddWithValue("@ngaynhap", ngayNhap);
                                cmd.Parameters.AddWithValue("@soluong", this.tb_soluong.Text);
                                cmd.Parameters.AddWithValue("@dvt2", this.tb_dvt.Text);
                                cmd.Parameters.AddWithValue("@maloaihang", this.cb_maloaihang.Text);

                                adapter.InsertCommand= cmd;
                                adapter.Update(ds, "tblMatHang");
                                MessageBox.Show("Thêm mới thành công");

                                Loaddshh();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã hàng " + mahang + " đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
            }
            ResetData();
        }

        private void dgv_dshh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_dshh.CurrentRow.Index;
            tb_mahang.Text = dgv_dshh.Rows[index].Cells["MaHang"].Value.ToString();
            tb_mahang.ReadOnly = true;
            tb_tenhang.Text = dvMATHANG[index]["TenHang"].ToString();
            mtb_ngaynhap.Text = dvMATHANG[index]["NgayNhap"].ToString();
            DateTime dateTime = Convert.ToDateTime(mtb_ngaynhap.Text);
            ngayNhap = dateTime.ToString("yyyy/MM/d");
            tb_soluong.Text = dvMATHANG[index]["SoLuong"].ToString();
            tb_dvt.Text = dvMATHANG[index]["DVT2"].ToString();
            cb_maloaihang.Text = dvMATHANG[index]["MaLoaiHang"].ToString();
            tb_loaihang.Text = dvMATHANG[index]["TenLoaiHang"].ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_dshh.CurrentRow.Index;
            string mahang = dvMATHANG[index]["MaHang"].ToString();
            try
            {
                //Xóa
                DialogResult h = MessageBox.Show("Có muốn xóa mã hàng " + mahang + " thật không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (h == DialogResult.Yes)
                {
                    string queryDelete = "delete_tblMatHang";
                    using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            //Lấy danh sách sinh viên vào dataTable
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblMatHang", sqlConnetion);
                            DataTable dtMATHANG = new DataTable("tblMatHang");
                            adapter.Fill(dtMATHANG);

                            //add từng dataTable và dataSet
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dtMATHANG);

                            //tìm ma sv cần xóa
                            dtMATHANG.PrimaryKey = new DataColumn[] { dtMATHANG.Columns["MaHang"] };
                            DataRow dataRow = dtMATHANG.Rows.Find(mahang);
                            dataRow.Delete();

                            //xóa mã đã chọn trong CSDL thực hiện DeleteCommand
                            using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                            {
                                sqlCommand.CommandText = queryDelete;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@mahang", mahang);

                                adapter.DeleteCommand = sqlCommand;
                                int i = adapter.Update(ds, "tblMatHang");

                            }
                        }
                    }
                    ResetData();
                    Loaddshh();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update_tblMatHang";
            try
            {
                using (SqlConnection sqlConnetion = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        //Lấy danh sách sinh viên vào dataTable
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblMatHang", sqlConnetion);
                        DataTable dtMATHANG = new DataTable("tblMatHang");
                        adapter.Fill(dtMATHANG);

                        //add từng dataTable và dataSet
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dtMATHANG);

                        //chỉnh sửa dữ liệu trong datatable của dataset
                        dtMATHANG.PrimaryKey = new DataColumn[] { dtMATHANG.Columns["MaHang"] };
                        DataRow dataRow = dtMATHANG.Rows.Find(tb_mahang.Text);
                        dataRow["MaHang"] = this.tb_tenhang.Text;
                        dataRow["NgayNhap"] = ngayNhap;
                        dataRow["SoLuong"] = this.tb_soluong.Text;
                        dataRow["DVT2"] = this.tb_dvt.Text;
                        dataRow["MaLoaiHang"] = this.cb_maloaihang.Text;

                        //thực hiện UpdateCommand
                        using (SqlCommand sqlCommand = sqlConnetion.CreateCommand())
                        {
                            sqlCommand.CommandText = queryUpdate;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@mahang", this.tb_mahang.Text);
                            sqlCommand.Parameters.AddWithValue("@tenhang", this.tb_tenhang.Text);
                            sqlCommand.Parameters.AddWithValue("@ngaynhap", ngayNhap);
                            sqlCommand.Parameters.AddWithValue("@soluong", this.tb_soluong.Text);
                            sqlCommand.Parameters.AddWithValue("@dvt2", this.tb_dvt.Text);
                            sqlCommand.Parameters.AddWithValue("@maloaihang", this.cb_maloaihang.Text);

                            adapter.UpdateCommand = sqlCommand;
                            adapter.Update(ds, "tblMatHang");
                            MessageBox.Show("Chỉnh sửa thành công");

                            Loaddshh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra" + ex);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string filter = "MaHang IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_mahang.Text.Trim()))
            {
                filter += string.Format(" AND MaHang LIKE '%{0}%'", tb_mahang.Text);
            }
            if (!string.IsNullOrEmpty(tb_tenhang.Text.Trim()))
            {
                filter += string.Format(" AND TenHang LIKE '%{0}%'", tb_tenhang.Text);
            }
            Loaddshh(filter);
        }

        private void btn_inds_Click(object sender, EventArgs e)
        {
            BAOCAO form1= new BAOCAO();
            form1.Showreport("BAOCAOHANGHOA", "select_DSMH");
            form1.Show();
        }

        private void btn_innhomhang_Click(object sender, EventArgs e)
        {
            BAOCAO form2 = new BAOCAO();
            form2.Showreport_theoloai("BAOCAOLOAI", "select_DSMH");
            form2.Show();
        }
    }
}