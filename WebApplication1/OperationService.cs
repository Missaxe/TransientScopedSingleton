namespace WebApplication1
{
    public class OperationService : ITransientService, ISingletonService ,IScopedService
    {
        private readonly Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
            
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
