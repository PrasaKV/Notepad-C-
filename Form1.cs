using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        private string text;
        private string name;
        private string extention;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            KeyDown += new KeyEventHandler(shortCut);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            text = richTextBox1.Text;
        }
        
        private void shortCut(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.Equals(Keys.S))
            {
                File.WriteAllText("note.txt", text);
                MessageBox.Show("File Saved Successfully");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
