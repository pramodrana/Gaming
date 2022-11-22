using TVS.Common.Constant;
using TVS.Common.Logging;
using TVS.Common.Resources;
using TVS.Repository.Repository.GameProperty;

namespace TVS.ApiService.Service.GameProperty
{
    public class GamePropertyService : IGamePropertyService
    {
        #region Private Variable
        private readonly IGamePropertyRepository _gamePropertyRepository;
        #endregion

        #region Constructor
        public GamePropertyService(IGamePropertyRepository gamePropertyRepository)
        {
           this._gamePropertyRepository = gamePropertyRepository;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Method to get property name by id
        /// </summary>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        public string? GetPropertyById(long propertyId)
        {
            try
            {
                if (propertyId > 0)
                {
                    var property =  _gamePropertyRepository.GetById(propertyId);
                    if (property != null)
                    {
                        return property.PropertyName;
                    }
                    else
                    {
                        throw new ArgumentException(Constants.DB_ERROR);
                    }
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        /// <summary>
        /// Getting badges on the base of obtained score
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public async Task<long> GetBadgeByScore(long score)
        {
            try
            {
                long badgeId = 0;
                if (score > 0)
                {
                    var badgeList = (await _gamePropertyRepository.GetAll()).Where(x => x.IsActive).
                        OrderBy(x => Convert.ToInt32(x.PropertyValue)).ToList().ToArray();
                    if (badgeList.Length > 0)
                    {
                        for (int i = 0; i < badgeList.Length - 1; i++)
                        {
                            int minRange = Convert.ToInt32(badgeList[i].PropertyValue);
                            int maxRange = (i <= badgeList.Length - 1) ? Convert.ToInt32(badgeList[i + 1].PropertyValue) : minRange;
                            if (score >= minRange && score <= maxRange)
                            {
                                badgeId = badgeList[i].PropertyId;
                            }
                            else if (score > maxRange)
                            {
                                badgeId = badgeList[badgeList.Length - 1].PropertyId;
                            }
                        }
                        return badgeId;
                    }
                    else
                    {
                        throw new ArgumentException(Constants.DB_ERROR);
                    }
                }
                else
                {
                    throw new ArgumentException(Constants.INVALID_ARGS);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        /// <summary>
        /// Get a list of properties (i.e. badges)
        /// </summary>
        /// <returns></returns>
        public async Task<List<Data.Models.GameProperty>> GetAllProperties()
        {
            try
            {
                return (await _gamePropertyRepository.GetAll()).Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                throw new Common.Exception.CustomException(ResourceManager.GetResource(Constants.DB_ERROR));
            }
        }

        #endregion

    }
}
