using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class RunningNo
    {
        public string RunningNoID { get; set; }

        public string Code { get; set; }

        public Int32 Starting { get; set; }

        public Int32 Length { get; set; }

        public string Prefix { get; set; }

        public string Venue { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }



      //  public RunningNo Nos { get; set; }


        public string GenarateNo(RunningNo _Nos, int Count)
        {

            try
            {

                int CurrentNo = _Nos.Starting + Count + 1;
                _Nos.Code = _Nos.Prefix + CurrentNo.ToString().PadLeft(_Nos.Length, '0');
                return _Nos.Code;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }





    }
   
}
