using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

public class IdentityObject
{

   #region Attributes
   
       private string  _userID;
       private string _userName;
       private string _role;
       private int _dept;
       private int _actionLevel;

      
   #endregion
      
   #region Constructors
       public IdentityObject()
       {
           UserID = "000";
           _userName = "guest";
           Role = "guest";
           _actionLevel = 0;
       }
       protected void SetIdentityObject(IdentityObject _ident)
       {
           UserID = _ident.UserID ;
           UserName = _ident.UserName;
           Role = _ident.Role;
           ActionLevel = _ident.ActionLevel;
           Dept = _ident.Dept;
       }

   public IdentityObject(string  userID, string userName, string role, int actionLevel, int dept)
       {
           UserID = userID;
           UserName = userName ;
           Role = role ;
           ActionLevel = actionLevel;
           Dept = dept;
       }

       #endregion
       
   #region Properties


       public string UserID
       {
           get
           {
               return _userID ;
           }
           set
           {
               _userID  = value;
           }
       }

       public string UserName
       {
           get
           {
               return _userName;
           }
           set
           {
               _userName = value;
           }
       }

       public string Role
       {
           get
           {
               return _role;
           }
           set
           {
               _role = value;
           }
       }

       public int ActionLevel
       {
           get
           {
               return _actionLevel;
           }
           set
           {
               _actionLevel = value;
           }
       }

       public int Dept
       {
           get
           {
               return _dept;
           }
           set
           {
               _dept = value;
           }
       }
   #endregion   
           
   #region Methods

   #endregion

   
}
