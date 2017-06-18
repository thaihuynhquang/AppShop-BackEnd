namespace ValueObject
{
    public class SupplierValueObject
    {
        private int _id;
        private string _name;
        private string _address;
        private string _email;
        private string _phone;

        public SupplierValueObject(int id,string name, string add, string mail, string phone)
        {
            this._id = id;
            this._name = name;
            this._address = add;
            this._email = mail;
            this._phone = phone;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address;
        }

        public int GetId()
        {
            return _id;
        }


    }
}
