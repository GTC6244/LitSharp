namespace Services.ChainData.Models;


public class SimpleTx
{
    public string blockHash { get; set; }
    public string blockNumber { get; set; }
    public string from { get; set; }
    public string to { get; set; }
    public string gas { get; set; }
    public string gasPrice { get; set; }
    public string hash { get; set; }
    public string input { get; set; }
    public string isError { get; set; }
    public string nonce { get; set; }
    public string timeStamp { get; set; }
    public string transactionIndex { get; set; }

    public DateTime chainTimeStamp { get { DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                            dateTime = dateTime.AddSeconds( Double.Parse(timeStamp) ).ToLocalTime();
                            return dateTime; }
                            }
    
}

