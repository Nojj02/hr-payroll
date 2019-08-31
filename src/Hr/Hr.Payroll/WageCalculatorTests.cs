using System;
using FluentAssertions;
using Xunit;

namespace Hr.Payroll
{
    public class WageCalculatorTests
    {
        [Fact]
        public void NetPayIsBasicPay()
        {
            var worker = new Worker(basicSalary: 10_000);

            var netPay = WageCalculator.ComputeFor(worker);

            netPay.Should().Be(10_000);
        }
    }

    public class Worker
    {
        public Worker(decimal basicSalary)
        {
            BasicSalary = basicSalary;
        }

        public decimal BasicSalary { get; }
    }

    public class WageCalculator
    {
        public static decimal ComputeFor(Worker worker)
        {
            return worker.BasicSalary;
        }
    }
}
