/*using APBD_6.Context;
using APBD5.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;

namespace APBD5.Services;

public interface IClientService

{
    Task<bool> RemoveClient(int idClient);
}

public class TEMPLATE2_Service : IClientService
{
    private readonly NAZWA_Context _context;

    public TEMPLATE2_Service(NAZWA_Context context)
    {
        _context = context;
    }

    public async Task<bool> RemoveClient(int idClient)
    {
        var clients = await _context.Clients.ToListAsync();

        var clients_trips = await _context.Client_Trips.ToListAsync();

        var result = clients_trips.Where(e => e.IdClient.Equals(idClient)).Select(e => e.IdClient);

        if (IntegerType.FromObject(result.FirstOrDefault()) == 0)
            if (clients.Find(e => e.IdClient == idClient) != null)
            {
                REMOVE Z BAZY DANYCH
                _context.Remove(_context.Clients.Single(a => a.IdClient == idClient));
                ZATWIERDZANIE ZMIAN W BAZIE PRZY UPDATE CZY DELETE
                await _context.SaveChangesAsync();
                return true;
            }

        return false;
    }
}*/