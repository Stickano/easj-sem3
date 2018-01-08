using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace easj_sem3_soap
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int create(Object obj);

        [OperationContract]
        IList<Object> readAll();

        [OperationContract]
        Object read(string id);

        [OperationContract]
        int update(Object obj, string id);

        [OperationContract]
        int delete(string id);

    }

    //[DataContract]
    //public class SomeName
    //{
    //    [DataMember]
    //    public int id;
    //}
}
