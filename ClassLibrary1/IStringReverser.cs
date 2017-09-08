using System.Runtime.Serialization;
using System.ServiceModel;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface IStringReverser
    {
        [OperationContract]
        ReverseResponse Reverse(ReverseRequest request);
    }

    [DataContract]
    public class ReverseRequest
    {
        [DataMember]
        public string Text { get; set; }
    }

    [DataContract]
    public class ReverseResponse
    {
        [DataMember]
        public string Text { get; set; }
    }
}