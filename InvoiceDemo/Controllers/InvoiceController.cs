using InvoiceDemo.Model.Information;
using InvoiceDemo.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InvoiceDemo.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<InvoiceInformation>> Get()
        {
            return new List<InvoiceInformation>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<InvoiceInformation> Get(int id)
        {
            return new InvoiceInformation() { };
        }
    }
}