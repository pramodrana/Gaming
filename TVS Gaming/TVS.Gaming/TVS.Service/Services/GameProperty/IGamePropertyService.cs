using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.ApiService.Service.GameProperty
{
    public interface IGamePropertyService
    {
        Task<long> GetBadgeByScore(long score);
        string? GetPropertyById(long propertyId);
        Task<List<Data.Models.GameProperty>> GetAllProperties();
    }
}
