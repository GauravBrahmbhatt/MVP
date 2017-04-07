using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

  public class TransactionItem
  {
        int _transactionID;
        int _transactionItemID;
        string _trans_Index;
        string _trans_SubIndex;
        double _amount;	
        double _rate;	
        double _total;
        int _recordType;
        string _description;

     public TransactionItem() { }
     public TransactionItem(string[] fields)
     {
         try
         {
        //    protected int _docNum;
        //protected int _docType;
        //protected int _externalRef;
        //protected int _internalRef;
        //protected int _status;
        //protected int _docRef;
        //protected string _textValue1;
             _transactionID = Int32.Parse(fields[0]);
             _transactionItemID = Int32.Parse(fields[1]);
             _trans_Index = (fields[2]);
             _trans_SubIndex = (fields[3]);
             _recordType = Int32.Parse(fields[4]);
             _amount = double.Parse(fields[6]);
             _rate = double.Parse(fields[5]);
            // _total = double.Parse(fields[7]); 
             _total = _amount * _rate;
             //_recordType = Int32.Parse(fields[7]);   // fields[3].Trim();
             _description = fields[7].Trim();
         }
         catch (Exception )
         {
            // MessageBox.Show("  error creating transaction item : " + ex.Message);
             return;
         }
   }
   public int TransactionID
   {
      get { return _transactionID; }
      set { _transactionID = value; }
   }
   public int TransactionItemID
   {
       get { return _transactionItemID; }
      set { _transactionItemID = value; }
   }
   public string Trans_Index
   {
       get { return _trans_Index; }
       set { _trans_Index = value; }
   }
   public string Trans_SubIndex
   {
       get { return _trans_SubIndex; }
       set { _trans_SubIndex = value; }
   }

   public int RecordType
   {
       get { return _recordType; }
       set { _recordType = value;
             if (value > 0) _recordType = 1;  // debit
             if (value < 0) _recordType = 2;  // credit
            }
   }
   public double Amount
   {
      get { return _amount; }
      set { _amount = value; }
   }
    public double Rate
   {
      get { return _rate; }
      set { _rate = value; }
   }
    public double Total
   {
      get { return _total; }
      set { _total = value; }
   }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

   public string ToString(int recordType)
    {
        string descStr = Description.PadRight(33);
           if ( descStr.Length > 33)  descStr = descStr.Substring(0, 33);
        switch (recordType)
       {   
           case 1:
               return String.Format("{0,6} {1,8} {2,1}{3,4}{4,-33}   {5,14:C}  ",
                     Trans_SubIndex, Trans_Index/*.Substring(0,3)*/, " ", "  ",descStr, Total);
               //         0                   1                   2         3   4                 5             6      7
              
           case -1:
           case 2:
               return String.Format("{0,6} {1,8} {2,1}{3,8}{4,-33}   {5,18}{6,14:C}  ",
                     Trans_SubIndex, Trans_Index/*.Substring(0,3)*/, " ", "      ", descStr, "         ", Total);   //    Description.Trim().PadRight(30), "         ", Total);
               //         0                   1                      2      3        4          5         6
              
           case 8:
               return String.Format("{0,135}  {1,10}  {2,30}  {3,10}", " ", "-------- ", "  ", "-------- ");
               
           case 9:
               return String.Format("{0,135}  {1,10}  {2,30}  {3,10}", " ", " ", "  ", " ");
              
       }
       return String.Format("{0,6} {1,-8} {2,1}{3,1}{4,32}{5,14:C}  ",
                     _transactionItemID, Trans_Index, RecordType, "  ", descStr, "         ", Total);    //Description, Total);
                  //      0                   1             2       3     4        5         6
   } 
 }  //  end of class
  
