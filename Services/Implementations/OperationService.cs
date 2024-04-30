using TSSDependencyInjection.Services.Interfaces;

namespace TSSDependencyInjection.Services.Implementations
{
    public class OperationService: IScopeService, ITransientService, ISingletonService
    {
        private Guid ID { get; set; }
        public OperationService()
        {
            ID = Guid.NewGuid();
        }
        public Guid GetId() => ID;
    }
}
