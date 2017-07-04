﻿using DAO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class ImportBusinessLogic
    {
        private readonly ImportDataAccessLayer _importDataAccessLayer;

        public ImportBusinessLogic()
        {
            _importDataAccessLayer = new ImportDataAccessLayer();
        }

        public List<ImportValueObject> GetAllImportProducts()
        {
            var data = _importDataAccessLayer.GetAllImportProducts();
            return (from DataRow row in data.Rows
                    select new ImportValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()), row[2].ToString(),
                    int.Parse(row[3].ToString()), row[4].ToString(), int.Parse(row[5].ToString()), int.Parse(row[6].ToString()),
                    int.Parse(row[7].ToString()), int.Parse(row[8].ToString()))).ToList();
        }

        public bool ImportProduct(ImportValueObject import)
        {
            return _importDataAccessLayer.CreateImportProduct(import.IdNCC, import.NhaCungCap, import.IdSP, import.SanPham, import.SoLuongTrongKho, import.Dongia);
        }
    }
}