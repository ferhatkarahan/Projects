namespace Interfaces;

public interface ICustomerDal
{
    void Add();
    void Update();
    void Delete();

}
class SqlCustomerDal : ICustomerDal
{
    public void Add()
    {
        System.Console.WriteLine("Sql Added ! ");
    }

    public void Delete()
    {
        System.Console.WriteLine("Sql Deleted ! ");
    }

    public void Update()
    {
        System.Console.WriteLine("Sql Updated ! ");
    }

}
class OracleCustomerDal : ICustomerDal
{
    public void Add()
    {
        System.Console.WriteLine("Oracle Added ! ");
    }

    public void Delete()
    {
        System.Console.WriteLine("Oracle Deleted ! ");
    }

    public void Update()
    {
        System.Console.WriteLine("Oracle Updated ! ");
    }
    

}
class MysqlCustomerDal : ICustomerDal
{
    public void Add()
    {
        System.Console.WriteLine("Mysql Added ! ");
    }

    public void Delete()
    {
        System.Console.WriteLine("Mysql Deleted ! ");
    }

    public void Update()
    {
        System.Console.WriteLine("Mysql Updated ! ");
    }
    

}
class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();

    }
    
}

