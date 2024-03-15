namespace AutomaticRegisterServicesProject.Abstracts.Products
{
    public interface IProductService : IAbstract
    {
        List<string> GetProducts();
    }
}
