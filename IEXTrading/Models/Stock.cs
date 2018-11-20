using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models
{
    public class ChartRoot2
    {
        public Stock[] chart { get; set; }
    }

    public class Stock
    {
        public string companyName { get; set; }
        public long marketcap { get; set; }
        //public float beta { get; set; }
        //public float week52high { get; set; }
        //public float week52low { get; set; }
        //public float week52change { get; set; }
        //public int shortInterest { get; set; }
        //public string shortDate { get; set; }
        //public float dividendRate { get; set; }
        //public float dividendYield { get; set; }
        //public string exDividendDate { get; set; }
        //public string latestEPS { get; set; }
        //public string latestEPSDate { get; set; }
        //public long sharesOutstanding { get; set; }
        //public long _float { get; set; }
        //public float returnOnEquity { get; set; }
        //public float consensusEPS { get; set; }
        //public int numberOfEstimates { get; set; }
        //public object EPSSurpriseDollar { get; set; }
        //public float EPSSurprisePercent { get; set; }
        [Key]
        public string symbol { get; set; }
        public long EBITDA { get; set; }
        //public long revenue { get; set; }
        //public long grossProfit { get; set; }
        //public long cash { get; set; }
        //public long debt { get; set; }
        //public float ttmEPS { get; set; }
        //public int revenuePerShare { get; set; }
        //public int revenuePerEmployee { get; set; }
        //public float peRatioHigh { get; set; }
        //public int peRatioLow { get; set; }
        //public float returnOnAssets { get; set; }
        //public object returnOnCapital { get; set; }
        //public float profitMargin { get; set; }
        //public float priceToSales { get; set; }
        //public float priceToBook { get; set; }
        //public float day200MovingAvg { get; set; }
        //public float day50MovingAvg { get; set; }
        //public float institutionPercent { get; set; }
        //public object insiderPercent { get; set; }
        //public object shortRatio { get; set; }
        public float year5ChangePercent { get; set; }
        public float year2ChangePercent { get; set; }
        public float year1ChangePercent { get; set; }
        public float ytdChangePercent { get; set; }
        public float month6ChangePercent { get; set; }
        public float month3ChangePercent { get; set; }
        public float month1ChangePercent { get; set; }
        public float day5ChangePercent { get; set; }
        public float day30ChangePercent { get; set; }


    }
}
