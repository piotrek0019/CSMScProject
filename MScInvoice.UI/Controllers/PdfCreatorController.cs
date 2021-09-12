﻿using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    [Route("[controller]")]
    //[Authorize(Policy = "User")]
    public class PdfCreatorController : Controller
    {
        private IConverter _converter;

        public PdfCreatorController(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet("{id}")]
        public IActionResult CreatePDF(int id)
        {

            new CustomAssemblyLoadContext().LoadUnmanagedLibrary($"E:\\OneDrive\\Programowanie\\Projects\\CSMScProject\\CSMScProject\\MScInvoice.UI\\libwkhtmltox.dll");
            //var variab =  Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll");


            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Invoice"
               // Out = @"D:PDFCreator\Invoice.pdf"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                Page = "http://localhost:44554/pdf/Invoice/" + id,
                WebSettings = {DefaultEncoding = "utf-8"},
                HeaderSettings = { FontName = "Helvetica Neue", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Helvetica Neue", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = {objectSettings}
            };

            var file = _converter.Convert(pdf);

            return File(file, "application/pdf");

            //return Ok();
        }
    }
}
