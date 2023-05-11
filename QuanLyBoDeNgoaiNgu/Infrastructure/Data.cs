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
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DataSource = listData;
        }

        public static void DeleteData() { }
    }
}
