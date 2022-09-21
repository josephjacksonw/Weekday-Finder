using System;
using System.Collections.Generic;

namespace Calculator.Models
{
  public class Voodoo
  {
    public string findDay(int Month, int Day, int Year)
    {
      int d = Day;
      int Y = Year;
      List<int> monthOffsetCommonYrs = new List<int> {0,3,3,6,1,4,6,2,5,0,3,5};
      List<int> monthOffsetLeapYrs = new List<int> {0,3,4,0,2,5,0,3,6,1,4,6};
      int m = 0;
			if (Y%4 == 0) 
      { 
				m = monthOffsetLeapYrs[Month-1]; 
			} 
      else 
      { 
			  m = monthOffsetCommonYrs[Month-1]; 
			}
      int w = ((d%7) + (m%7) + ((5*((Y-1)%4))%7)  +  ((4*((Y-1)%100))%7)  +  ((6*((Y-1)%400))%7))%7;
    
      List<string> days = new List<string> {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
      string result = days[w];
      return result;
    }
  }
}

//devil code goes here
//export const gaussAlg = function(M, d, Y){  //'d': day of month (1 to 31).  'M': month (1=Jan, 2=Feb, ..., 12=Dec).  'Y': 4-digit year #. 

	// ; //Stores month-offset value based on given 'M' and 'Y' values. 
	// List<int> monthOffsetCommonYrs = new List {  };  //monthOffsetCommonYrs[0] = Jan, [1]=Feb, ...
	//   //Indices follow the same scheme as above. 

	//   //0=Sunday, 1=Monday, ..., 6=Saturday.
	// console.log("w = " + w); 

	// let resultArray = [m, w];
	// let wkdayInd = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]; 
	// resultArray[1] = wkdayInd[w]; 
	
	
	// return resultArray; 
