
namespace TVS.Model.Models
{
    /// <summary>
    /// JSONResponseMapper
    /// </summary>
    /// <typeparam name="HdrType"></typeparam>
    /// <typeparam name="DataType"></typeparam>
    public class ApiResponseBodyWithHeader<HdrType, DataType, ResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiResponseBodyWithHeader(HdrType strHeader, DataType strData, ResponseData strPage)
        {
            Header = strHeader;
            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ApiResponseBodyWithHeader()
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
  
    public class ApiResponseBody<DataType, GamingResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ApiResponseBody(DataType strData, GamingResponseData strPage)
        {

            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ApiResponseBody()
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
