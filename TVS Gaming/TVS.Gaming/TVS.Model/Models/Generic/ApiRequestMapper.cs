
namespace TVS.Model.Models.Generic
{
    /// <summary>
    /// JSONRequestMapper
    /// </summary>
    /// <typeparam name="HdrType"></typeparam>
    /// <typeparam name="DataType"></typeparam>
    public class ApiRequestMapper<HdrType, DataType>
    {
        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        public ApiRequestMapper()
        { }

        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        /// <param name="strHdr"></param>
        /// <param name="strData"></param>
        public ApiRequestMapper(HdrType strHdr, DataType strData)
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

    public class ApiRequestMapperWithoutHeader<DataType>
    {
        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        public ApiRequestMapperWithoutHeader()
        { }

        /// <summary>
        /// JSONRequestMapper
        /// </summary>
        /// <param name="strHdr"></param>
        /// <param name="strData"></param>
        public ApiRequestMapperWithoutHeader(DataType strData)
        {
            Data = strData;
        }

        /// <summary>
        /// data
        /// </summary>
        public DataType Data { get; set; }
    }
}
