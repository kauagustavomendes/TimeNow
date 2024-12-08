using System;

public class MyDateTime {
    private DateTime agora = DateTime.Now;
    public int hh {get; set;}
    public int mm {get; set;}
    public int ss {get; set;}

    public int DD {get; set;}
    public string MM {get; set;}
    public int YYYY {get; set;}

    public MyDateTime(){
        hh = agora.Hour;
        mm = agora.Minute;
        ss = agora.Second;
        
        DD = agora.Day;
        MM = agora.ToString("MMMM");
        YYYY = agora.Year;
    }

    public override string ToString(){
        return $"{DD}/{MM}/{YYYY}  {hh}:{mm}:{ss}";
    }
}
class App {
    static void Main(string[] args){
        MyDateTime Now = new MyDateTime();
        Console.WriteLine(Now);
    }
}