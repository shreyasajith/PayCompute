﻿using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IPayComputationService
    {

        Task CreateAsync(PaymentRecord paymentRecord);
        PaymentRecord GetByID(int Id);

        TaxYear GetTaxYearById(int Id);

        IEnumerable<PaymentRecord> GetAll();
        IEnumerable<SelectListItem> GetAllTaxYear();

        decimal OvertimeHours(decimal hoursWorked, decimal contractualHours);

        decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal Overtimerate(decimal hourlyRate);

        decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours);

        decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings);

        decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);

        decimal NetPay(decimal totalEarnings, decimal totalDeduction);

    }
}
