using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockMarketComponent
{
    public class StockMarketDataAnalysis
    {
        public StockMarketDataAnalysis(string data)
        { 
            //Code goes here to set a member variable to the passed in data
        }
    // 计算快速变化平均值
        public string CalculateFastMovingAverage()
        {
            Thread.Sleep(6000);

            return $"{nameof(CalculateFastMovingAverage)} - ThreadId: {Thread.CurrentThread.ManagedThreadId}";

        }
        //方法模拟计算慢速移动平均值的操作
        public string CalculateSlowMovingAverage()
        {
            Thread.Sleep(7000);

            return $"{nameof(CalculateSlowMovingAverage)} - ThreadId: {Thread.CurrentThread.ManagedThreadId}";

        }
        //法模拟计算股票随机指标的操作，同
        public string CalculateStockastics()
        {
                Thread.Sleep(10000);
            //nameof（) 获取成员变量的名字

                return $"{nameof(CalculateStockastics)} - ThreadId: {Thread.CurrentThread.ManagedThreadId}";
 
        }
        //方法模拟计算布林带指标的操作，
        public string CalculateBollingerbands()
        {
            Thread.Sleep(5000);

            return $"{nameof(CalculateBollingerbands)} - ThreadId: {Thread.CurrentThread.ManagedThreadId}";

        }

    }
}
