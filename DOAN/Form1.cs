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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Input;
using System.Windows.Markup;
using System.Security.Cryptography;

namespace AES_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------
        //----------------MA HOA RSA----------------------
    
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAPadding);
                }
                return encryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
    //-------------------------------------------------------
    //-------------------GIAI MA RSA----------------------
     

        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        //---------------------------------------------------
        AES AES = new AES();
        // ma hoa dang nhap
        public void btn_encrypt_data(string diachi, string password)
        {
           
            
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);
            AES.FileEncrypt(diachi, password);

            AES.ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
            gch.Free();

            Console.WriteLine("The given password is surely nothing: " + password);
        }


        public void btn_decrypt_data(string diachi, string password)
        {
            
            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            AES.FileDecrypt(diachi + "Mahoathanhcong.txt", diachi, password);


            AES.ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
            gch.Free();
            Console.WriteLine("The given password is surely nothing: " + password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            int flag=0 ;
            for (int i = 1; i <=3; i++)
            {   
                string str = Convert.ToString(i);
                string dc_sv = @"thongtinsv\sv";
                string aa = dc_sv + str + @"\Dulieu_MH_GM" + @"\acc" + str + @".txt";// taikhoansv
                string bb = dc_sv + str + @"\Dulieu_MH_GM" + @"\keyy" + str + @".txt";//matkhausv
                //
                string taikhoan_sv = "";
                List<string> textTK = new List<string>();
                textTK = File.ReadAllLines(aa).ToList();

                //C:\Users\admin\Downloads\DOAN\DOAN\thongtinsv\sv1\Dulieu_MH_GM
                foreach (string line in textTK)
                {
                    taikhoan_sv = line;
                }
                //
                string keyy1sv="";
                List<string> textT = new List<string>();
                textT = File.ReadAllLines(bb).ToList();
                foreach (string line in textT)
                {
                    keyy1sv = line;
                }
                
                if (txt_vb.Text == taikhoan_sv)
                {
                    //ma hoa 1 sinh vien
                    btn_encrypt_data(aa, keyy1sv);
                    btn_decrypt_data(aa, txt_key.Text);

                    string giaima_asv = aa + "giaimathanhcong.txt";
                    //lay noi dung cua giaima_avc
                    string noidung_giaima_asv = "";
                    List<string> textTx = new List<string>();
                    textTx = File.ReadAllLines(giaima_asv).ToList();
                    foreach (string line in textTx)
                    {
                        noidung_giaima_asv = line;
                    }


                    
                    if (noidung_giaima_asv == taikhoan_sv)
                    {
                        //lay ten sv
                        string ten = dc_sv + str + @"\TENSV.txt";
                        string name = "";
                        List<string> textTxzz = new List<string>();
                        textTxzz = File.ReadAllLines(ten).ToList();
                        foreach (string line in textTxzz)
                        {//name sv
                            name = line;
                        }
                    

                        string mh_RSA = "";
                        plaintext = ByteConverter.GetBytes(noidung_giaima_asv);
                        encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
                        mh_RSA = ByteConverter.GetString(encryptedtext);
                        string gm_RSA="";
                        byte[] decryptedtex = Decryption(encryptedtext, RSA.ExportParameters(true), false);
                        gm_RSA= ByteConverter.GetString(decryptedtex);

                       
                        if (gm_RSA == noidung_giaima_asv)
                        {
                           
                           
                            Form2 frm = new Form2(txt_vb.Text, name);
                            frm.Show();
                            flag = 1;
                            break;
                        }
                    }
                }

            }
            if (flag == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
            }

        }

      

    }
}
