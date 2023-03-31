using _1_DAL.Entities;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private INhanVienRepository _inhanvienrepository = new NhanVienRepository();
        public bool Add(NhanVien obj)
        {
            _inhanvienrepository.Add(obj);
            return true;    
        }

        public bool Delete(NhanVien obj)
        {
            _inhanvienrepository.Delete(obj);
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _inhanvienrepository.GetAll();
           
        }

        public bool Update(NhanVien obj)
        {
            _inhanvienrepository.Update(obj);
            return true;
        }
    }
}
