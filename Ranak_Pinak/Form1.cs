using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Media;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Management;
using System.Text;

namespace Ranak_Pinak
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        private string GetFileName(string path)
        {
            string name = path;
            int poz = path.LastIndexOf('.');
            if (poz > 0) name = path.Substring(0, poz);
            return name;
        }

        private string GetFileExt(string path)
        {
            string ext = "";
            int poz = path.LastIndexOf('.');
            if (poz > 0) ext = path.Substring(poz + 1);
            return ext;
        }

        private byte ByteEncrypt(byte b)
        {
            return (byte)(b ^ 128);
        }

        private byte[] StrToByteArray(string st, Encoding enc)
        {
            return enc.GetBytes(st);
        }

        private string ByteArrayToStr(byte[] bstr, Encoding enc)
        {
            return enc.GetString(bstr);
        }

        public bool EncryptFile(string inputFile)
        {
            string name = GetFileName(inputFile);
            string ext = GetFileExt(inputFile);
            byte[] bext = StrToByteArray(ext, new UnicodeEncoding());
            int k = bext.Length;
            try
            {
                FileStream fsRead = new FileStream(inputFile, FileMode.Open);
                FileStream fsWrite = new FileStream(name + ".ranakpinak", FileMode.Create);
                fsWrite.Write(BitConverter.GetBytes(k), 0, 4);
                fsWrite.Write(bext, 0, k);
                int data;
                while ((data = fsRead.ReadByte()) != -1) fsWrite.WriteByte(ByteEncrypt((byte)data));
                fsRead.Close();
                fsWrite.Close();
                File.Delete(inputFile);
                return true;
            }
            catch { }
            return false;
        }

        public bool DecryptFile(string inputFile)
        {
            try
            {
                FileStream fsRead = new FileStream(inputFile, FileMode.Open);
                string name = GetFileName(inputFile);
                byte[] bint32 = new byte[4];
                int i = fsRead.Read(bint32, 0, 4);
                int k = BitConverter.ToInt32(bint32, 0);
                byte[] bext = new byte[k];
                i = fsRead.Read(bext, 0, k);
                string ext = "." + ByteArrayToStr(bext, new UnicodeEncoding());
                FileStream fsWrite = new FileStream(name + ext, FileMode.Create);
                int data;
                while ((data = fsRead.ReadByte()) != -1) fsWrite.WriteByte(ByteEncrypt((byte)data));
                fsRead.Close();
                fsWrite.Close();
                return true;
            }
            catch { }
            return false;
        }
        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|(*.ico)|*.ico|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames)
                {
                    if (EncryptFile(s)) textBox1.AppendText(s + " has been successfully encrypted" + Environment.NewLine);
                    else textBox1.AppendText(s + " could not be encrypted" + Environment.NewLine);
                }
            }

        }
        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            openFileDialog1.Filter = "Encrypted Files| (*.ranakpinak)|*.ranakpinak ";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames)
                {
                    if (DecryptFile(s)) textBox1.AppendText(s + " File has been successfully decrypted" + Environment.NewLine);
                    else textBox1.AppendText(s + " could not be decrypted" + Environment.NewLine);
                }
            }

        }
        private void aboutAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutapp = new AboutApp();
            aboutapp.Show();
        }
        private void EncBut_Click(object sender, EventArgs e)
		{
            textBox1.Text = "";
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp|(*.png)|*.png|(*.ico)|*.ico|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames)
                {
                    if (EncryptFile(s)) textBox1.AppendText(s + " Ibu file sedang mengandung bayi terkena virus :(, file has been successfully encyrpted" + Environment.NewLine);
                    else textBox1.AppendText(s + " Ibu file tidak terkena virus :(,file has not been successfully encrypted " + Environment.NewLine);
                }
            }
        }

		private void DecrBut_Click(object sender, EventArgs e)
		{
            textBox1.Text = "";
            openFileDialog1.Filter = "(*.ranakpinak)|*.ranakpinak | All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string s in openFileDialog1.FileNames)
                {
                    if (DecryptFile(s)) textBox1.AppendText(s + " Kandungan ibu file sudah pulih dari virus :D, file has been successfully decrypted" + Environment.NewLine);
                    else textBox1.AppendText(s + " Ibu file belum pulih dari virus :D, file has not been successfully decrypted" + Environment.NewLine);
                }
            }

        }

		
	}
}
