
namespace TVS.ApiService.Api.Models.Gaming
{
    /// <summary>
    /// JSONResponseMapper
    /// </summary>
    /// <typeparam name="HdrType"></typeparam>
    /// <typeparam name="DataType"></typeparam>
    public class ApiResponseMapper<HdrType, DataType, ResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiResponseMapper(HdrType strHeader, DataType strData, ResponseData strPage)
        {
            Header = strHeader;
            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ApiResponseMapper()
        { }

        /// <summary>
        /// header
        /// </summary>
        public HdrType Header { get; set; }

        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }

        /// <summary>
        /// PageType
        /// </summary>
        public ResponseData Response { get; set; }

    }


    public class ApiResponseMapper<DataType>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiResponseMapper(DataType strData)
        {
            Data = strData;
        }

        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }
    }


    public class ApiResponseMapper<HdrType, DataType>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiResponseMapper(HdrType strHeader, DataType strData)
        {
            Header = strHeader;
            Data = strData;
        }

        /// <summary>
        /// default cons
        /// </summary>
        public ApiResponseMapper()
        { }

        /// <summary>
        /// header
        /// </summary>
        public HdrType Header { get; set; }

        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }
    }

    public class ApiDataResponseMapper<DataType, GamingResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiDataResponseMapper(DataType strData, GamingResponseData strPage)
        {

            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ApiDataResponseMapper()
        { }


        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }

        /// <summary>
        /// PageType
        /// </summary>
        public GamingResponseData Response { get; set; }

    }
}
