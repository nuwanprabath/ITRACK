using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
   public class clsRuningNoEngine
    {
        public RunningNo Nos { get; set; }


        public string GenarateNo(RunningNo _Nos,int  Count)
        {

            try {

                int CurrentNo = _Nos.Starting + Count+1;
                _Nos.Code = _Nos.Prefix + CurrentNo.ToString().PadLeft(_Nos.Length,'0');
                return _Nos.Code;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
