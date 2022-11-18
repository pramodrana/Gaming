using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Common.Constant
{
    public class Constants
    {

        #region COMMON

        public const string STATS_FILE_DIRECTORY_PATH = "StatsDirPath";
        public const string RECORD_SUCCESS_MESSAGE = "RecordSucessMessage";
        public const string SUCCESS = "Success";
        public const string FAILURE = "Failure";
        public const string FIELD_LIST = "FieldList";
        public const string SAVE_FILE_ERROR = "SaveFileError";
        public const string PARAM_PARSE_ERROR = "ParamParseError";
        public const string DB_SAVE_ERROR = "DbSaveError";
        public const string DB_ERROR = "DbError";
        public const string INTERNAL_SERVER_ERROR = "InternalServerError";
        public const string FORBIDDEN_ERROR = "ForbiddenError";
        public const string FORBIDDEN_ERROR_RP = "ForbiddenErrorRP";
        public const string ITEM_NOT_FOUND_RP = "ItemNotFoundRP";
        public const string RECORDS_PER_PAGE = "RecordPerpage";
        public const string NO_OF_RECORDS = "NoOfRecords";
        public const string BAD_REQUEST = "BadRequest";
        public const string BAD_REQUEST_FILE_MISSING = "BadRequestFileMissing";
        public const string INVALID_ARGS = "InvalidArgs";
        public const string RECORD_NOT_FOUND = "RecordNotFound";
        #endregion 

        #region GAMING
        public static class GamingConstants
        {
            public const string PAGE_NUMBER_REQUIRED = "PageNumberRequired";
            public const string PAGE_SIZE_REQUIRED = "PageSizeRequired";
            public const string GAME_CATEGORY_ID_REQUIRED = "GameCategoryCodeRequired";
            public const string GAME_MODE_REQUIRED = "GameModeRequired";
            public const string GAME_POINT_REQUIRED = "GamePointsRequired";
            public const string BADGE_REQUIRED = "BadgeIdRequired";
            public const string GAME_ID_REQUIRED = "GameCodeRequired";

            public const string BRONZE = "Bronze";
            public const string SILVER = "Silver";
            public const string GOLD = "Gold";
            public const string PLATINUM = "Platinum";
        }
        #endregion
    }
}
