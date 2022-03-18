using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace Nuotrauku_skirstytuvas
{
    public partial class Form1 : Form
    {
       FolderBrowserDialog folderBrowserDialog2 = new FolderBrowserDialog();
        static string fName;
        string pirmasPasirinkimas;
        string antrasPasirinkimas;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pasirinktiIsKur_Click(object sender, EventArgs e)
        {
           
            folderBrowserDialog1.ShowDialog();
            isKurLangas.Text = folderBrowserDialog1.SelectedPath;
            int kiekYra = Directory.GetFiles(folderBrowserDialog1.SelectedPath).Count();
            failuKiekisLangas.Text = $"isviso lange yra {kiekYra} failu";

            // folderBrowserDialog2.RootFolder = Environment.SpecialFolder;
            pirmasPasirinkimas = folderBrowserDialog1.SelectedPath;

        }

        private void pasirinktiIKur_Click(object sender, EventArgs e)
        {

           

            folderBrowserDialog2.ShowDialog();
            iKur.Text = folderBrowserDialog2.SelectedPath;
           string[] fileEntries = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");

            foreach (string fileName in fileEntries)
            {    fName = fileName.Substring(pirmasPasirinkimas.Length +1 );
                ProcessFile(fName);
               
            }

            antrasPasirinkimas = folderBrowserDialog2.SelectedPath;

            // System.IO.File.Copy(files[0], kurPath, true);
            /*
            foreach (string f in files)
            {
                if (File.Exists(f))
                {
                   
                    System.IO.File.Copy(f, kurPath, true);
                }
            }
            */
        }

        private void kopijuoti_Click(object sender, EventArgs e)
        {
            string isKurPath = folderBrowserDialog1.SelectedPath;
            string kurPath = folderBrowserDialog2.SelectedPath;
            
            string[] files = Directory.GetFiles(isKurPath);
         
         
            foreach (string f in files)
            {
                string naujasFolderis = Path.Combine(kurPath, "testas");
                Directory.CreateDirectory(naujasFolderis);
                fName = f.Substring(pirmasPasirinkimas.Length + 1);
                
                File.Copy(Path.Combine(isKurPath, fName),Path.Combine(kurPath, fName), true);
                ProcessFile(fName);
                
            }

        }
        public void ProcessFile(string path)
        {
            failuKiekisLangas.Text += $" failo pavadinimas {path} ";
        }

    }
}
