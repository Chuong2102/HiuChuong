using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBoDeNgoaiNgu.Infrastructure
{
    public static class Data
    {
        /// <summary>
        /// Load data cho DataGridView 
        /// </summary>
        /// <typeparam name="T">Kiểu bất kì</typeparam>
        /// <param name="dgv">DataGridView cần load</param>
        /// <param name="listData">Danh sách cần load</param>
        public static void LoadData<T>(DataGridView dgv, List<T> listData)
        {
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DataSource = listData;
        }

        public static void AddColumn<T>(DataGridView dgv, string columnName, string headerText, List<T> listData)
        {
            dgv.Columns.Add(columnName, headerText);
        }

        public static void AddThuTu(DataGridView dgv)
        {
            if (dgv.Columns["TT"]  != null)
            {
                dgv.Columns.Remove(dgv.Columns["TT"]);
            }

            dgv.Columns.Add("TT","Thứ tự");

            dgv.Columns["TT"].DisplayIndex = 0;
            int index = dgv.Columns["TT"].Index;

            int i = 1;

            foreach(DataGridViewRow row in dgv.Rows)
            {
                row.Cells[index].Value = i.ToString();
                i++;
            }

        }

        public static void DeleteData() { }
    }
}
