using EasyAutomationFramework;
using System;

namespace ReadPDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Base.ExtractTextPdf("file:///C:/Users/Lucas Rocha Dantas/Documents/Lucas Rocha Dantas/Vida profissional/Certificados/Fundamentos do C%23 - Balta.pdf");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}