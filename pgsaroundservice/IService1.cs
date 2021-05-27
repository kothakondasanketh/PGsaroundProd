using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace BookPG_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        //[WebInvoke(ResponseFormat = WebMessageFormat.Xml, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Login")]
        string Login(string Username, string Password, int UserTypeID);

        [OperationContract]
        List<Country> Country();

        [OperationContract]
        List<State> State(int CountryID);

        [OperationContract]
        List<Cities> City(int StateID);

        [OperationContract]
        List<Area> Area(int CityID);

        [OperationContract]
        List<PGDetails> PgDetailsList(string Area, int UserTyperID,int Gender);

        [OperationContract]
        List<UserBookingDetails> UserBookingDetailsList(string Username,int UserID);

        [OperationContract]
        List<PGDetails> ParticularPgDetailsList(string ClientID);

        [OperationContract]
        string UserRegister(UserRegister Userdetails, int update);

        [OperationContract]
        string PGRegister(PGDetails pgdetails,int update);

        [OperationContract]
        ObservableCollection<BookingEntryDetails> bookingdetails(string OrderNo);

        [OperationContract]
        string BookPG(BookingEntryDetails BEntry);

        [OperationContract]
        List<UserRegister> GetUserDetails(string Username);

        [OperationContract]
        int GenerateOrderno();
        
    }



}
