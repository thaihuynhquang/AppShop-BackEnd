﻿using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class ShipperBussinessLogic
    {
        private ShipperDataAccessLayer _shipperDataAccessLayer;

        public ShipperBussinessLogic()
        {
            _shipperDataAccessLayer = new ShipperDataAccessLayer();
        }

        public List<ShipperValueObject> GetAllShippers()
        {
            var dataTable = _shipperDataAccessLayer.GetAllShippers();
            return (from DataRow row in dataTable.Rows select new ShipperValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList();
        }

        public bool CreateShipper(ShipperValueObject shipper)
        {
            return _shipperDataAccessLayer.CreateNewShipper(shipper.Name, shipper.Phone, shipper.Email);
        }

        public bool UpdateSupplier(ShipperValueObject shipper)
        {
            return _shipperDataAccessLayer.UpdateShipper(shipper.Id, shipper.Name, shipper.Email, shipper.Phone);
        }

        public ShipperValueObject GetDetailShipper(int id)
        {
            var dataTable = _shipperDataAccessLayer.GetDetailShipper(id);
            return (from DataRow row in dataTable.Rows
                    select new ShipperValueObject(int.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["phone"].ToString())).ToList().First();
        }
    }
}