using Mapster;
using RentalApp.Core.Dto;

namespace RentalApp
{

    public class MapsterProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.CreateMap<Urunler, UrunlerDTO>()
                .Map(dest => dest.Puan, src => src.UrunlerYorumlar.Puan)
                .Map(dest => dest.Fiyat, src => src.UrunlerFiyat.Fiyat)
                .Map(dest => dest.Il, src => src.Iller.Il)
                .Map(dest => dest.Ilce, src => src.Ilceler.Ilce)
                .Map(dest => dest.Link, src => src.UrunlerDil.Link)
                .Ignore(dest => dest.UrunId);
        }
    }
}