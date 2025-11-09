using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Firebase
{
    public class FirebaseContext
    {
        private readonly FirebaseClient _client;
        private const string FirebaseUrl = "https://sayacmatikapp-default-rtdb.firebaseio.com/";//örnek amaçlı gerçek urlyi atacağız sonra

        public FirebaseContext()
        {
            _client = new FirebaseClient(FirebaseUrl);
        }

        public FirebaseClient Client => _client;
    }
}
