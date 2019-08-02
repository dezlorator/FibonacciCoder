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

namespace FibonacciCoder
{
    public partial class Form1 : Form
    {
        string path;
        string coded_string;
        DecodeString decode;
        string fileinfo;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files(*.txt)|*.txt";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                StreamReader reader = new StreamReader(path);
                fileinfo = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void CodeFilebtn_Click(object sender, EventArgs e)
        {
            CodeString code_obj = new CodeString(fileinfo);
            coded_string = code_obj.GetCodedString();
            decode = new DecodeString(coded_string, code_obj.Unique_symbol_list);
            string extension = Path.GetExtension(path);
            string codedpath = path.Insert(path.Length - extension.Length, "coded");
            using (FileStream fs = new FileStream(codedpath, FileMode.OpenOrCreate))
            {
                StreamWriter write = new StreamWriter(fs);
                write.Write(coded_string);
                write.Close();
            }
            DecodeFilebtn.Enabled = true;
        }

        private void DecodeFilebtn_Click(object sender, EventArgs e)
        {
            string decoded_string = decode.Decode_String();
            string extension = Path.GetExtension(path);
            string decodedpath = path.Insert(path.Length - extension.Length, "decoded");
            using (FileStream fs = new FileStream(decodedpath, FileMode.OpenOrCreate))
            {
                StreamWriter write = new StreamWriter(fs);
                write.Write(decoded_string);
                write.Close();
            }
        }
    }
}
