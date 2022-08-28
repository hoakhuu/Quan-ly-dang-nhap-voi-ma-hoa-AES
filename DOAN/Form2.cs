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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace AES_File
{
    public partial class Form2 : Form
    {
        private string mssv, tensv;
      
        public Form2()
        {
            InitializeComponent();
        }

        
        public Form2(string msv, string ten)
        {
            InitializeComponent();
            this.mssv = msv;
            this.tensv = ten;
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            txt2_Hoten.Text = tensv;
            txt2_mssv.Text = mssv;
        }

      



       
        
    }
}
