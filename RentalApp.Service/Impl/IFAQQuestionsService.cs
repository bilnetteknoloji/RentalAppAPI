using RentalApp.Core;


namespace RentalApp.Service.Impl
{
    public interface IFAQQuestionsService
    {
        SssSorular GetSssSorularById(int SoruId);
        IList<SssSorular> GetAllSssSorular(int SoruId);
        bool DeleteSssSorular (SssSorular sssSorular);
        SssSorular UpdateSssSorular (SssSorular sssSorular);
        bool InsertSssSorular (SssSorular sssSorular);
        IList<SssSorular> GetAllSssSorulars();
    }
}
