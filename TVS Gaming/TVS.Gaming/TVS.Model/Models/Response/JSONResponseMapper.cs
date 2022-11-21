
namespace TVS.Model.Models
{
    /// <summary>
    /// JSONResponseMapper
    /// </summary>
    /// <typeparam name="HdrType"></typeparam>
    /// <typeparam name="DataType"></typeparam>
    public class ResponseWithHeader<HdrType, DataType, ResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ResponseWithHeader(HdrType strHeader, DataType strData, ResponseData strPage)
        {
            Header = strHeader;
            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ResponseWithHeader()
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
  
    public class ResponseWithHeader<HdrType, DataType>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ResponseWithHeader(HdrType strHeader, DataType strData)
        {
            Header = strHeader;
            Data = strData;
        }

        /// <summary>
        /// default cons
        /// </summary>
        public ResponseWithHeader()
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

    public class ResponseWithoutHeader<DataType, GamingResponseData>
    {
        /// <summary>
        /// cons
        /// </summary>
        /// <param name="strHeader"></param>
        /// <param name="strData"></param>
        public ResponseWithoutHeader(DataType strData, GamingResponseData strPage)
        {

            Data = strData;
            Response = strPage;
        }


        /// <summary>
        /// default cons
        /// </summary>
        public ResponseWithoutHeader()
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
