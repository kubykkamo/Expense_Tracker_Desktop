using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker_Desktop;

public class SortOption 
{ 
    public string DisplayName { get; set; }
    public SortType Type { get; set; }


}

public enum SortType
{
    ByDateAsc,
    ByDateDesc,
    ByAmountAsc,
    ByAmountDesc,
    ByNameAsc,
    ByNameDesc
}
