using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Utilities
{
    class Employee : Entity 
    {
        #region Attributes

        private int _docNum;
        private int _docType;
        private string _firstName;
        private string  _lastName;
        private string  _address;
        private string  _address2;
        private string  _city;
        private string _state;
        private string _zipCode;
        private string _country;
        private string _phone;
        private string _phone2;
        private string _email;
        string  _deptID;
        string  _role;
        string  _admLevel;
        string _comment;
     
        #endregion

        #region Constructors

         public Employee(string _record)
       {
           string[] _items = _record.Split(',');
           EmployeeID = Int32.Parse(_items[0]);
           DocType = Int32.Parse(_items[1]);
           FirstName = _items[2];
           LastName  = _items[3];
           Address = _items[4];
           Address2 = _items[5];
           City = _items[6];
           State = _items[7];
           ZipCode = _items[8];
           Country = _items[9];
           Phone = _items[10];
           Phone2 = _items[11];
           Email = _items[12];
           DeptID = (_items[13]);
           Role = _items[14];
           AdmLevel = (_items[15]);
           Comment = _items[16];
       }

        #endregion

        #region Properties

         public int DocNum
         {
             get
             {
                 return _docNum;
             }
             set
             {
                 _docNum = value;
             }
         }
         public int DocType
         {
             get
             {
                 return _docType;
             }
             set
             {
                 _docType = value;
             }
         }
         public int EmployeeID
         {
             get
             {
                 return _docNum;
             }
             set
             {
                 _docNum = value;
             }
         }

        
        public string  LastName
        {
            get
            {
                return  _lastName;
            }
            set
            {
                 _lastName = value;
            }
        }

        public string  FirstName
        {
            get
            {
                return  _firstName;
            }
            set
            {
                 _firstName = value;
            }
        }

        public string  WholeName
        {
            get
            {
                return  FirstName + " " +  LastName;
            }

        }

        //public string Address
        //{   get  {  return _address; }
        //    set  { _address = value; }
        //}
        //public string Address2
        //{   get  {  return _address2; }
        //    set  { _address2 = value; }
        //}
        //public string City
        //{   get  {  return _city; }
        //    set  { _city = value; }
        //}
        //public string State
        //{   get  {  return _state; }
        //    set  { _state = value; }
        //}
        //public string Country
        //{   get  {  return _country; }
        //    set  { _country = value; }
        //}
     

        public string ZipCode
        {
            get
            {
                return _zipCode;
            }
            set
            {
                _zipCode = value;
            }
        }

        public string DeptID
        {
            get
            {
                return _deptID;
            }
            set
            {
                _deptID = value;
            }
        }


        public string  AdmLevel
        {
            get
            {
                return _admLevel;
            }
            set
            {
                _admLevel = value;
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

        public string  Email
        {
            get
            {
                return  _email;
            }
            set
            {
                 _email = value;
            }
        }

        public string  AddressFull
        {
            get
            {
                return  Address + " " +  Address2;
            }
           
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public string Phone2
        {
            get
            {
                return _phone2;
            }
            set
            {
                _phone2 = value;
            }
        }
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }

 


           #endregion


    }
}
