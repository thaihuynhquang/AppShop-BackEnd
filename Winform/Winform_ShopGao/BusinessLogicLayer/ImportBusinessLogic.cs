using DAO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using Winform_ShopGao;

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
                    int.Parse(row[3].ToString()), row[4].ToString(), uint.Parse(row[5].ToString()), int.Parse(row[6].ToString()),
                    uint.Parse(row[7].ToString()), int.Parse(row[8].ToString()))).ToList();
        }

        public bool ImportProduct(ImportValueObject import)
        {
            try
            {
                var listImport = GetAllImportProducts();
                if (listImport.Any(x => x.IdNCC == import.IdNCC && x.IdSP == import.IdSP))
                {
                    return false;
                }
                return _importDataAccessLayer.CreateImportProduct(import.IdNCC, import.NhaCungCap, import.IdSP, import.SanPham, import.SoLuongTrongKho, import.Dongia);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool UpdateImportProduct(ImportValueObject import)
        {
            return _importDataAccessLayer.UpdateImportProduct(import.Id, import.IdNCC, import.NhaCungCap, import.IdSP, import.SanPham, import.SoLuongTrongKho, import.Dongia);
        }

        public List<ImportValueObject> Search(List<string> column, string value)
        {
            var data = Utility.Search("import", column, value);
            return (from DataRow row in data.Rows
                    select new ImportValueObject(int.Parse(row[0].ToString()), int.Parse(row[1].ToString()), row[2].ToString(),
                    int.Parse(row[3].ToString()), row[4].ToString(), uint.Parse(row[5].ToString()), int.Parse(row[6].ToString()),
                    uint.Parse(row[7].ToString()), int.Parse(row[8].ToString()))).ToList();
        }
    }
}