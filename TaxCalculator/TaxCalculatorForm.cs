using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class TaxCalculatorForm : Form
    {
        public TaxCalculatorForm()
        {
            InitializeComponent();
        }

        private TaxRate[] _defaultTaxTiers =
        {
            new TaxRate{ Band = 10000, Rate = .31 },
            new TaxRate{ Band = 32000, Rate = .38 },
            new TaxRate{ Band = 55000, Rate = .52 },
            new TaxRate{ Band = 121000, Rate = .6 }
        };

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            var salary = CalaculateSalary(Convert.ToInt32(txtBox_Salary.Text), _defaultTaxTiers);

            lbl_CalculatedSalary.Text = salary.Net.ToString("N");
            lbl_Tax.Text = salary.TaxRate.RateText;

        }

        private Salary CalaculateSalary(int salary, TaxRate[] taxTiers )
        {
            var taxRate = FindTaxRate(salary, taxTiers);

            return new Salary
            {
                Gross = salary,
                TaxRate = taxRate,

            };
        }

        private TaxRate FindTaxRate(decimal grossSalary, TaxRate[] taxTiers)
        {
            foreach(var tier in taxTiers.OrderByDescending(x => x.Band))
            {
                if (grossSalary >= tier.Band)
                    return tier;
            }

            return TaxRate.NoTax;
        }
    }

    public class Salary
    {
        public decimal Gross { get; set; }
        public TaxRate TaxRate { get; set; }
        public decimal TaxAmount => Gross * TaxRate.Rate;
        public decimal Net => Gross - TaxAmount;
    }

    public class TaxRate
    {
        public decimal Band { get; set; }
        public decimal Rate { get; set; }

        public string RateText => $"{Rate * 100:N0} %";

        public static TaxRate NoTax => new() { Rate = 0 };
    }
}
