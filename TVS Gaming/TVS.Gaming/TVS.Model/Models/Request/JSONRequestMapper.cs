
namespace TVS.Model.Models.Gaming
{
    /// <summary>
    /// JSONRequestMapper
    /// </summary>
    /// <typeparam name="HdrType"></typeparam>
    /// <typeparam name="DataType"></typeparam>
    public class ApiRequestBody<HdrType, DataType>
    {
        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        public ApiRequestBody()
        { }

        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        /// <param name="strHdr"></param>
        /// <param name="strData"></param>
        public ApiRequestBody(HdrType strHdr, DataType strData)
        {
            Header = strHdr;
            Data = strData;
            //page = strPage;
        }


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
        //public PageType page { get; set; }
    }

    public class JSONRequestMapperWithoutHeader<DataType>
    {
        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        public JSONRequestMapperWithoutHeader()
        { }

        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        /// <param name="strHdr"></param>
        /// <param name="strData"></param>
        public JSONRequestMapperWithoutHeader(DataType strData)
        {
            Data = strData;
        }

        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }
    }
}
