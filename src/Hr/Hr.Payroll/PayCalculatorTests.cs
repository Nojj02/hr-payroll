using System;
using FluentAssertions;
using Xunit;

namespace Hr.Payroll
{
    public class PayCalculatorTests
    {
        [Fact]
        public void NetPayIsBasicPay_EndOfMonthPeriod_MonthlyPaid()
        {
            var worker = new Worker(basicSalary: 100_000);

            var netPay = PayCalculator.ComputeFor(worker);

            netPay.Should().Be(100_000);
        }

        // Monthly period
        // Gross Pay
        // Semi-monthly period
        // Daily Rate
        // Hourly Rate
        // Tax Deductions
        // Benefit Deductions
        // Leaves
        // Overtimes
        // Allowances
        // Adjustments
        // Daily Paid
        // Monthly Paid

    }

    public class Worker
    {
        public Worker(decimal basicSalary)
        {
            BasicSalary = basicSalary;
        }

        public decimal BasicSalary { get; }
    }

    public class PayCalculator
    {
        public static decimal ComputeFor(Worker worker)
        {
            return worker.BasicSalary;
        }
    }
}
