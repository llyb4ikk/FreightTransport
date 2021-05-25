using System.Collections.Generic;
using System.Threading.Tasks;
using FreightTransport_Client.Data.Models;

namespace FreightTransport_Client.Data.Interfaces
{
    public interface ITransportationService
    {
        Task<TransportationModel> GetTransportationById(int id);
        Task<TransportationInfoModel> GetTransportationInfoById(int id);
        Task<IEnumerable<TransportationTableModel>> GetAllTransportationsTable();
        Task<TransportationModel> AddTransportation(TransportationModel transportationModel);
        Task<bool> UpdateTransportation(TransportationModel transportationModel);
        Task<bool> DeleteTransportation(int id);

        Task<TransportationInfoModel> GetTransportationDetailsById(int id);
        Task<bool> NextStage(int transportationId);
    }
}