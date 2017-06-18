namespace ValueObject
{
    public class SupplierValueObject
    {
        public int? _id { get; set; }
        public string _name { get; set; }
        public string _address { get; set; }
        public string _email { get; set; }
        public string _phone { get; set; }

        public SupplierValueObject(int? id,string name, string add, string mail, string phone)
        {
            this._id = id;
            this._name = name;
            this._address = add;
            this._email = mail;
            this._phone = phone;
        }
    }
}
