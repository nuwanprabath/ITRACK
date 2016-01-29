using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
  public  class TextFileReadingHelper
    {
      public string[] getAllLines(string _FilePath) {
          try {

              string[] Lines;
                 
                 Lines  = System.IO.File.ReadAllLines(_FilePath).ToArray();
                 return Lines;
          }
          catch(Exception ex){
              return null;
          }
      
      }
    }
}
