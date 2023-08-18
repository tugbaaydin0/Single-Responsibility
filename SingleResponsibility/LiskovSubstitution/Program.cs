namespace LiskovSubstitution
{
    internal class Program
    {
        static void Baglan(DBHelper db)
        {
            db.Connect();
        }
        static void Sorgula(DBHelper db)
        {
            db.Query();
        }
        static void Main(string[] args)
        {
           SQLHelper sql = new SQLHelper();
            Baglan(sql);
            Sorgula(sql);

            OracleHelper ora=new OracleHelper();
            Baglan(ora);
            Sorgula(ora);
        }
    }
}