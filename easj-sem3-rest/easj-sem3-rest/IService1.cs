using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace easj_sem3_rest
{
    [ServiceContract]
    public interface IService1
    {

        //[WebInvoke(UriTemplate = "create",
        //    Method = "POST",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //[OperationContract]
        //int Create(Object obj);


        //[WebInvoke(UriTemplate = "read",
        //    Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //IList<Object> readAll();


        //[WebInvoke(UriTemplate = "read/{id}",
        //    Method = "GET",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //IList<Object> read(string id);


        //[WebInvoke(UriTemplate = "update/{id}",
        //    Method = "PUT",
        //    RequestFormat = WebMessageFormat.Json,
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //[OperationContract]
        //int Update(string id, Object obj);


        //[WebInvoke(UriTemplate = "delete/{id}",
        //    Method = "DELETE",
        //    ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Bare)]
        //[OperationContract]
        //int Delete(string id);
    }
}
