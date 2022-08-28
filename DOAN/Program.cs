/*
 Đại học Công nghiệp Thực Phẩm TP. Hồ Chí Minh
 Khoa: Công Nghệ Thông Tin
-----------------------------------------------
Sinh viên thực hiện: Khưu Văn Hòa
Lớp: 11DHTH5
MSSV: 2001200606
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AES_File
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form4());
            
        }
    }
}
