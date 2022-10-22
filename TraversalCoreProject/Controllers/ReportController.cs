using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Dtos;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;

namespace TraversalCoreProject.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        public IActionResult Index()
        {
            return View();
        }


        #region excelReport
        public List<DestinationDto> DestinationList()
        {
            List<DestinationDto> destinationDtos = new List<DestinationDto>();
            using (var c = new Context())
            {
                destinationDtos = c.Destinations.Select(x => new DestinationDto
                {
                    Capacity = x.Capacity,
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                }).ToList();

            }
            return destinationDtos;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_reportService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
        #endregion

        #region pdfReport
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            document.Add(new Paragraph("Traversal Rezervasyon Pdf Raporu"));
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "fileTable.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);//column 
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Emre");
            pdfPTable.AddCell("İpek");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Emrah");
            pdfPTable.AddCell("İpek");
            pdfPTable.AddCell("11111111112");

            pdfPTable.AddCell("Sibel");
            pdfPTable.AddCell("İpek");
            pdfPTable.AddCell("11111111113");

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/fileTable.pdf", "application/pdf", "fileTable.pdf");
        }
        #endregion
    }
}
