using AutomaticRegisterServicesProject.Abstracts;
using AutomaticRegisterServicesProject.Abstracts.Products;

namespace AutomaticRegisterServicesProject.Concretes.WithAbstract
{

    //singleton
    public class ProductWithAbstractService : ISingletonConcrete, IProductService
    {
        private readonly List<string> _products;
        public ProductWithAbstractService()
        {
            _products = ["Telefon", "Bilgisayar"];
        }


        public List<string> GetProducts()
        {
            return _products;
        }
    }

    //scoped
    //public class ProductWithAbstractService : IScopedConcrete, IProductService
    //{

    //}

    //transient
    //public class ProductWithAbstractService : ITransientConcrete, IProductService
    //{

    //}
}
