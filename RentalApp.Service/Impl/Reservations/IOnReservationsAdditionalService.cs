using RentalApp.Core;



namespace RentalApp.Service.Impl.Reservations
{
    public interface IOnReservationsAdditionalService
    {
        OnrezervasyonlarEkhizmet GetOnrezervasyonlarEkhizmetById(int OnrezervasyonekhizmetId);
        IList<OnrezervasyonlarEkhizmet> GetAllOnrezervasyonlarEkhizmet(int OnrezervasyonekhizmetId);
        bool DeleteOnrezervasyonlarEkhizmetById(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet);
        OnrezervasyonlarEkhizmet UpdateOnrezervasyonlarEkhizmet(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet);
        bool InsertOnrezervasyonlarEkhizmet(OnrezervasyonlarEkhizmet onrezervasyonlarEkhizmet);
        IList<OnrezervasyonlarEkhizmet> GetAllOnrezervasyonlarEkhizmets();
    }
}
