using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESDUSPLC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/documenti/conversioni.xlsx";
            

            // 1. CREAZIONE E SCRITTURA DEL FILE EXCEL
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Utenti");

                // Ciclo per la generazione automatica di un blocco di righe sul file excel 
                for (int i = 1; i <= 8; i++)
                { 
                    

                    //worksheet.Cell(i, 1).Value = i;
                    //worksheet.Cell(i, 2).Value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inserisci il bit n." + i);
                    worksheet.Cell(2, i).Value = Console.ReadLine();
                    //for (int j = 8; j > 1; j--)
                    //{
                        //worksheet.Cell(3, j).SetFormulaA1 ((j, 2) * 2^i);
                        worksheet.Cell(3, i).FormulaA1 = "=" + worksheet.Cell(2, i).Value + "*2^" + i ;

                    //}
                    //worksheet.Cell(i, 3).Value = 20 + (i - 5) * 2;
                    //worksheet.Cell(i, 4).Value = (i - 5) * 10;
                    //worksheet.Cell(i, 5).FormulaA1 = "=C" + i + "*D" + i; //Cella con Formula Calcolata
                }

                // Inserimento della funzione SOMMA (SUM)
                //worksheet.Cell(11, 2).Value = "Spesa Totale";
                //worksheet.Cell(11, 5).FormulaA1 = "SUM(E2:E10)"; //Metto il Range dei Valori che vanno sommati
                //worksheet.Row(11).Style.Font.Bold = true; //Grassetto
                //worksheet.Row(11).Style.Border.TopBorder = XLBorderStyleValues.Thin; //Bordo con Riga Singola
                //worksheet.Row(11).Style.Border.BottomBorder = XLBorderStyleValues.Double; //Bordo con Riga Doppia

                // Adatta la larghezza delle colonne al contenuto
                //worksheet.Columns().AdjustToContents();

                // Salva il file
                workbook.SaveAs(filePath);
                Console.WriteLine($"\nIl File '{filePath}' e' stato creato con successo!\n");
            }


        }
    }
}
