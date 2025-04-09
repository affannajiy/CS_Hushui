using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;


namespace TransactionPackage
{
    public class Business
    {
        public TransactionList TransList { get; set; }


        private const string FIREBASE_PROJID = "cashtransaction-4ec3e"; // must be ID of your Firestore db
        private FirestoreDb db;

        public Business()
        {
            TransList = new TransactionList();
        }

        //initFirestore: Connect to Cloud Firestore
        public void initFirestore()
        {
            FirebaseApp.Create(); //Static Method: Belongs to the class, not an instance
            db = FirestoreDb.Create(FIREBASE_PROJID); //db: Database, Create: method to create db
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", FIREBASE_PROJID);
        }

        //SaveEmployee Method
        public async Task SaveEmployee(Employee employee)
        {
            CollectionReference collectionRef = db.Collection("employees");
            DocumentReference docRef = collectionRef.Document(employee.ID);
            Dictionary<string, object> values = new Dictionary<string, object>
                  {   // key        // value
                    { "Name", employee.Name },
                    { "ID",   employee.ID }
                  };
            Console.WriteLine("Adding doc with ID " + docRef.Id);
            await docRef.SetAsync(values);
        }
        
        //Save Transaction Method
        public async Task SaveTransaction(Transaction transaction)
        {
            //Collection Reference = Predefined Class
            CollectionReference collectionRef = db.Collection("transactions");
            //DocReference = Row, Date in DateTime -> convert to String
            DocumentReference docRef = collectionRef.Document(transaction.Id);
            //Dictionary: Word (key) and Definition (value)
            Dictionary<string, object> values = new Dictionary<string, object>
                  {   // key        // value
                    { "Id",            transaction.Id},
                    { "Value",         transaction.Val.ToString()},
                    { "Date",          transaction.Date.ToString() },
                    { "Employee.Name", transaction.Employee.Name },
                    { "Employee.Id",   transaction.Employee.ID }
                  };
            //docRef: DocumentReference
            //SetAsync: Running and allowing other tasks to continue
            //await: Waiting for the task to finish
            Console.WriteLine("Adding doc with ID " + docRef.Id);
            await docRef.SetAsync(values);
        }

       //RestoreTransaction Method
        public async Task RestoreTransactions()
        {
            Query collectionQuery = db.Collection("transactions"); //Related throught Inheritance
            //Snapshot: To get the current values from the database
            QuerySnapshot allQuerySnapshot = await collectionQuery.GetSnapshotAsync();

            //Clear the list
            TransList.Clear();
            //Add to the list
            //DocumentSnapshot: To get the current values from the database (const)
            foreach (DocumentSnapshot documentSnapshot in allQuerySnapshot.Documents)
            {
                //Assigning new values to the local objects, keep in TransList
                Dictionary<string, object> data = documentSnapshot.ToDictionary();
                float val = float.Parse(data["Value"].ToString());
                DateTime date = DateTime.Parse(data["Date"].ToString());
                
                //Create transaction object and employee object
                Transaction trans = new Transaction(val, date, data["Id"].ToString());
                trans.Employee = new Employee(data["Employee.Name"].ToString(),
                                              data["Employee.Id"].ToString());

                TransList.Add(trans);
            }

        }

        public async Task DelTransaction(string data)
        {
            Console.WriteLine("Deleting  " + data);
            CollectionReference collectionRef = db.Collection("transactions");
            DocumentReference docRef = collectionRef.Document(data);
            await docRef.DeleteAsync();
        }

    }
}