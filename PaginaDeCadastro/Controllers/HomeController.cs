using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PaginaDeCadastro.Models;
using PaginaDeCadastro.Models.ViewModels;
using PaginaDeCadastro.Services;

namespace PaginaDeCadastro.Controllers
{
    public class HomeController : Controller
    {
        private readonly PaginaDeCadastroContext _context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        /*public async Task ExportToExcel()
        {
            var lista = await _context.Pessoa.ToListAsync();

            ExcelPackage pck = new ExcelPackage();
            ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Report");

            ws.Cells["A1"].Value = "Id";
            ws.Cells["B1"].Value = "Nome";
            ws.Cells["C1"].Value = "Sobrenome";
            ws.Cells["D1"].Value = "Data de Nascimento";
            ws.Cells["E1"].Value = "Nacionalidade";
            ws.Cells["F1"].Value = "Naturalidade";
            ws.Cells["G1"].Value = "Estado";
            ws.Cells["H1"].Value = "Nome do Pai";
            ws.Cells["I1"].Value = "Nome da Mae";
            ws.Cells["J1"].Value = "Idade";

            int rowStart = 1;
            foreach (var item in lista)
            {

                ws.Cells[string.Format("A{0}", rowStart)].Value = item.Id;
                ws.Cells[string.Format("B{0}", rowStart)].Value = item.Nome;
                ws.Cells[string.Format("C{0}", rowStart)].Value = item.Sobrenome;
                ws.Cells[string.Format("D{0}", rowStart)].Value = item.DataNascimento;
                ws.Cells[string.Format("E{0}", rowStart)].Value = item.Nacionalidade;
                ws.Cells[string.Format("F{0}", rowStart)].Value = item.CidadeNat;
                ws.Cells[string.Format("G{0}", rowStart)].Value = item.EstadoNat;
                ws.Cells[string.Format("H{0}", rowStart)].Value = item.NomePai;
                ws.Cells[string.Format("I{0}", rowStart)].Value = item.NomeMae;
                ws.Cells[string.Format("J{0}", rowStart)].Value = item.Idade;
                rowStart++;
            }

            ws.Cells["A:AZ"].AutoFitColumns(); 
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //Response.AddHeader("content-disposition", "attachment: filename=" + "Logs.xlsx");
            //Response.BinaryWrite(pck.GetAsByteArray());
            //Response.End();

        }*/

    }
}
