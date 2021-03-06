﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Showroom.Models.DataBusiness;

namespace Showroom.Models.DataAccess
{
    public partial class ShowroomRepository : IShowroomRepository
    {
        /// <summary>
        /// Lấy toàn bộ danh sách thuộc tính sản phẩm
        /// </summary>
        /// <returns>List of Catelogue</returns>
        public List<Product> GetProductsList()
        {
            try
            {
                var list = from p in _dataContext.Products select p;
                return list.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin của 1  sản phẩm
        /// </summary>
        /// <param name="id">Mãsản phẩm</param>
        /// <returns></returns>
        public Product GetProductInfo(int id)
        {
            try
            {
                var item = from p in _dataContext.Products
                           where p.Id == id
                           select p;
                // Trả về 1 giá trị hoặc mặc định (null)
                return item.SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> GetListProductSame(int IdCatalogue)
        {
            try
            {
                var list = from p in _dataContext.Products
                           where p.CatelogueId == IdCatalogue 
                           select p;
                return list.ToList();
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
