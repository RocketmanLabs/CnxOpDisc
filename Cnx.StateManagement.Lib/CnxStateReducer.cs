using Cnx.Core.Lib;
using Cnx.Core.Lib.Interfaces;
using Cnx.StateManagement.Lib.Exceptions;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public class CnxStateReducer : ReducerBase
    {
        // base: void ToLog(action, reducerName);

        public static Dto Execute(int state, Dto action)
        {
            //switch (action.Request.Name) {
            //    case "CreateInquiryAction":     // FacUserXId, Title, InqType => List<InqDto> x 3
            //        break;
            //    case "ViewInquiryAction":
            //        break;
            //    case "DeleteInquiryAction":
            //        break;
            //    case "UpdateInquiryAction":
            //        break;
            //    case "ListInquiriesAction":
            //        break;
            //    default:
            //throw new UnknownReduxActionException("CnxStateReducer", action.Request);
            //}
            return null;
        }
    }
}
