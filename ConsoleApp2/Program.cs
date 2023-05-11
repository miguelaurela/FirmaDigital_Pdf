using FirmaDigital;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FirmaDigitalPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);

            }
             string _pathCertificate = "Path_archivo .pfx";
            string passwordCerticate = "Contraseña_Certificado";
            var x509 = new X509Certificate2(File.ReadAllBytes(_pathCertificate), passwordCerticate);
            string Source = "Path_Pdf_Orign";
            string Target = "Path_Ubicacion_Archivo_Con_Nombre PdfFirmado.pdf";
            string razon = "Aquí razon de firmado";
            string ubicacion = "BARRANQUILLA";
            bool firmaVisible = true;
            PDF.SignHashed(Source, Target, x509, razon, ubicacion, firmaVisible);
        }
    }
}
