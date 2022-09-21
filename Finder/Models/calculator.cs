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