using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketComponent
{
    public class StockMarketData
    {
        //构造器
        public StockMarketData()
        { 
        }
        //GetDataAsync  异步得到的数据()
        public async Task<string> GetDataAsync() //返回个Task对象的string类型
        {
            await Task.Delay(5000);

            return "Stockmarket Data";
            //在等待5秒后，方法返回字符串 "Stockmarket Data"。这个字符串表示获取到的股市数据，这里只是一个示例，实际情况下可能是从远程服务器获取的真实股市数据。
        }

    }
}
