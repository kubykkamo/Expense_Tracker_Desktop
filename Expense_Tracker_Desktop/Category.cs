using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Expense_Tracker_Desktop;


public class Category {

    public string Name { get; set; }

  
    public Category() { }

    public override string ToString() => Name;



    public Category(string description) 
    {
        if (string.IsNullOrWhiteSpace(description)) 
        {
            throw new ArgumentException("Nebyl zadán název kategorie!");
        }
        Name = description;
    }
    


    

};
