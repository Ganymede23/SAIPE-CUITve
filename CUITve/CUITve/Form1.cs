using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUITve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ANULADO - DESCARGA A REALIZARSE DE MANERA AUTOMATICA CON BAT POR EL SO

            //DESCARGA ZIP
            
            /*
            WebClient wb = new WebClient(); //llama al webclient que descarga el zip
            string downloadsPath = new KnownFolder(KnownFolderType.Downloads).Path; //denomina la ruta de descarga local
            string allPathzip = Path.Combine(downloadsPath, "apellidoNombreDenominacion.zip"); //denomina el path completo con el nombre del archivo
            wb.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.33 Safari/537.36"); //comptibilidad para todos los navegadores
            wb.DownloadFile("http://www.afip.gob.ar/genericos/cInscripcion/archivos/apellidoNombreDenominacion.zip", allPathzip); //descarga el archivo

            Console.WriteLine(allPathzip);

            string allPathtxt = Path.Combine(downloadsPath, "FacturasApocrifas.txt");

            if (File.Exists(allPathtxt)) //si ya existe el txt lo elimino
            {
                File.Delete(allPathtxt);
            }
            ZipFile.ExtractToDirectory(allPathzip, downloadsPath); //descomprimo apoc.zip y creo el txt de afip
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
