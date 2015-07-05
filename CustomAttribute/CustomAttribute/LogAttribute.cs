using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.All) ]
public class LogAttribute : Attribute
{
    public static string datePatt = @"M/d/yyyy hh:mm:ss tt";
    public LogAttribute(String Description_in)
    {
        this.description = Description_in;
        DateTime saveUtcNow = DateTime.Now;
        this.accessTime=""+saveUtcNow.ToString(datePatt);
        this.currentUser=""+System.Security.Principal.WindowsIdentity.GetCurrent().Name;  
        
    }
    protected String description;
    protected String currentUser;
    protected String accessTime;
    public String Description
    {
        get 
        {
            return this.description;
        }            
    }
    public String AccessTime
    {
        get
        {
            return this.accessTime;
        }
    }
    public String CurrentUser
    {
        get
        {
            return this.currentUser;
        }
    }    
}