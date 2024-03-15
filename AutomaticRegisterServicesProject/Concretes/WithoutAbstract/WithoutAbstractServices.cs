using AutomaticRegisterServicesProject.Abstracts;

namespace AutomaticRegisterServicesProject.Concretes.WithoutAbstract
{
    //singleton
    public class ProductWithoutAbstractService : ISingletonConcrete
    {
        public string GetProductById(int id)
        {
            return "Elma";
        }
    }

    //scoped

    //public class ProductWithoutAbstractService : IScopedConcrete
    //{

    //}

    //transient

    //public class ProductWithoutAbstractService : ITransientConcrete
    //{

    //}
}
