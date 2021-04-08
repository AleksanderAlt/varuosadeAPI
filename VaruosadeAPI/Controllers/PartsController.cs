using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using VaruosadeAPI.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VaruosadeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        // GET: api/<PartsController>
        // /api/parts?page=3&pageSize=3&name=piip&sort=name
        [HttpGet]
        public IEnumerable<PartsDTO> Get([FromQuery] SearchParams parameters) // Võta aadressi tagant muutuja
        {
            List<PartsDTO> rows = new List<PartsDTO>();

            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Laptop\Documents\Aleksander\IT\Hajusrakendused\VaruosadeAPI\LE.txt"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters("\t");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] columns = parser.ReadFields();
                    var part = new PartsDTO();
                    part.Serial = columns[0];
                    part.Name = columns[1];
                    part.Price = double.Parse(columns[8]);
                    part.PriceVAT = double.Parse(columns[10]);
                    part.CarModel = columns[9];

                    int stockCount = 0;
                    int.TryParse(columns[2], out stockCount);
                    part.Stock.Add("Tallinn", stockCount);
                    int.TryParse(columns[3], out stockCount);
                    part.Stock.Add("Tartu", stockCount);
                    int.TryParse(columns[4], out stockCount);
                    part.Stock.Add("Pärnu", stockCount);
                    int.TryParse(columns[5], out stockCount);
                    part.Stock.Add("Kohtla-Järve", stockCount);
                    int.TryParse(columns[6], out stockCount);

                    rows.Add(part);
                }
            }

            var query = rows
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize);
            if (parameters.Name != null) {
                query = rows
                    .Where(part => part.Name.Contains(parameters.Name))
                    .OrderBy(part => part.Price);
            }
            if (parameters.Name != null && parameters.Sort.ToLower() == "price") {
                query = rows
                    .Where(part => part.Name.Contains(parameters.Name))
                    .OrderBy(part => part.Price);
            }
            return query.ToList();
        }

        // GET api/<PartsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PartsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PartsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PartsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
