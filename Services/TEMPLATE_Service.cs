/*using APBD5.Context;
using APBD5.Models;
using APBD5.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APBD5.Services;

public interface ITripService
{
    Task<IEnumerable<TripWithAdditionalData>> GetTripsWithAdditionalData2();
    Task<bool> AddClientToTrip(int idTrip, ClientPOST client);
}

public class TripService : ITripService
{
    private readonly MyDbContext _context;

    public TripService(MyDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TripWithAdditionalData>> GetTripsWithAdditionalData2()
    {
        var trips = await _context.Trips
            .Include(e => e.IdCountries)
            .Include(e => e.Client_Trips)
            .ThenInclude(e => e.IdClientNavigation)
            .ToListAsync();

        var clients = await _context.Clients.ToListAsync();

        return trips.Select(e => new TripWithAdditionalData
        {
            Name = e.Name,
            Description = e.Description,
            DateFrom = e.DateFrom,
            DateTo = e.DateTo,
            MaxPeople = e.MaxPeople,
            Countries = e.IdCountries.Select(c => new CountryName { Name = c.Name }),
            Clients = e.Client_Trips.Select(t => new ClientName
                { FirstName = t.IdClientNavigation.FirstName, LastName = t.IdClientNavigation.LastName })
        });
    }

    public async Task<bool> AddClientToTrip(int idTrip, ClientPOST client)
    {
        var clients = await _context.Clients.Include(e => e.Client_Trips).ToListAsync();

        var trips = await _context.Trips.ToListAsync();

        if (trips.Find(e => e.IdTrip.Equals(idTrip)) == null) return false;

        var clientTemp = clients.Find(e => e.Pesel.Equals(client.Pesel));
        
        if (clientTemp == null)
        {
            var idClient = _context.Clients.Max(e => e.IdClient) + 1;

            var client_trip = new Client_Trip
            {
                IdClient = idClient,
                IdTrip = idTrip,
                RegisteredAt = DateTime.Now,
                PaymentDate = client.PaymentDate
            };

            trips.Find(e => e.IdTrip.Equals(idTrip)).Client_Trips.Add(client_trip);

            _context.Add(new Client
            {
                IdClient = idClient,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                Pesel = client.Pesel,
                Telephone = client.Telephone,
                Client_Trips = new[] { client_trip }
            });
            await _context.SaveChangesAsync();

            return true;
        }
        else
        {
            if (clientTemp.Client_Trips.Any(t => t.IdTrip.Equals(idTrip))) return false;

            var client_trip = new Client_Trip
            {
                IdClient = clients.Find(e => e.Pesel.Equals(client.Pesel)).IdClient,
                IdTrip = idTrip,
                RegisteredAt = DateTime.Now,
                PaymentDate = client.PaymentDate
            };

            clients.Find(e => e.Pesel.Equals(client.Pesel)).Client_Trips.Add(client_trip);
            trips.Find(e => e.IdTrip.Equals(idTrip)).Client_Trips.Add(client_trip);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}*/