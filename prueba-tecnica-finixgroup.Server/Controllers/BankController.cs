using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using prueba_tecnica_finixgroup.Server.Models;
using System.Collections.Generic;
using System;
using prueba_tecnica_finixgroup.Helpers;

namespace prueba_tecnica_finixgroup.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : ControllerBase {
        private readonly ILogger<BankController> _logger;
        private readonly DataContext _dataContext;

        public BankController(ILogger<BankController> logger, DataContext context) {
            _logger = logger;
            _dataContext = context;
        }
        // HTTP Methods

        [HttpGet]
        public IActionResult GetAllBanks() {
            var banks = _dataContext.Banks.Where(b => b.DeletedAt == null);
            return Ok(banks);
        }

        [HttpGet("{id}")]
        public IActionResult GetBankById(int id) {
            var bank = _dataContext.Banks.FirstOrDefault(b => b.id == id);
            if(bank == null) {
                return NotFound();
            }
            return Ok(bank);
        }

        [HttpPost]
        public IActionResult AddBank(Bank bank) {
            if(ModelState.IsValid) {
                if(bank != null) {
                    bank.CreatedAt = DateTime.Now;
                    _dataContext.Banks.Add(bank);
                    _dataContext.SaveChanges();
                    return CreatedAtAction(nameof(GetBankById), new { id = bank.id }, bank);
                } else {
                    return BadRequest();
                }
            } else {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBank(int id, Bank updatedBank) {
            var existingBank = _dataContext.Banks.FirstOrDefault(b => b.id == id);
            if(existingBank == null) {
                return NotFound();
            }

            existingBank.bank_name = updatedBank.bank_name;
            existingBank.account_number = updatedBank.account_number;
            existingBank.routing_number = updatedBank.routing_number;
            existingBank.UpdatedAt = DateTime.UtcNow;
            _dataContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBank(int id) {
            var bankToDelete = _dataContext.Banks.FirstOrDefault(b => b.id == id);
            if(bankToDelete == null) {
                return NotFound();
            }

            bankToDelete.DeletedAt = DateTime.UtcNow;
            _dataContext.SaveChanges();

            return NoContent();
        }
    }
}
