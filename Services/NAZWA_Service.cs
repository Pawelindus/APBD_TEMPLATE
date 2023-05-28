using APBD_6.Context;

namespace APBD_6.Services
{
    public interface IAPBDService 
    {
        public Task<string> GetHello();
    }

    public class NAZWA_Service : IAPBDService
    {
        private readonly NAZWA_Context _context;
        public NAZWA_Service(NAZWA_Context nazwaContext) {
            _context = nazwaContext;
        }

        public Task<string> GetHello()
        {
           var value = _context;
            return Task.Run(() => "Hello");
        }


    }
}
