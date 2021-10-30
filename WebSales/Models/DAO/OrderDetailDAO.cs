using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebSales.Models.EF;

namespace WebSales.Models.DAO
{
    public class OrderDetailDAO : BaseDAO, IOrderDetailDAO
    {
        public async Task<bool> Add(OrderDetail entity)
        {
            try
            {
                _context.OrderDetails.Add(entity);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                OrderDetail entity = await GetSingleByID(id);

                _context.OrderDetails.Remove(entity);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }

        public async Task<bool> DeleteByOrderID(int orderID)
        {
            try
            {
                List<OrderDetail> orderDetails = await GetByOrderID(orderID);

                _context.OrderDetails.RemoveRange(orderDetails);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public async Task<List<OrderDetail>> GetAll()
        {
            List<OrderDetail> orderDetails = await _context.OrderDetails.ToListAsync();

            return orderDetails;
        }

        public async Task<List<OrderDetail>> GetByKeyword(string keyword)
        {
            List<OrderDetail> orderDetails = await _context.OrderDetails
                 .Where(t => t.Product.Name.Contains(keyword))
                 .ToListAsync();

            return orderDetails;
        }

        public async Task<List<OrderDetail>> GetByOrderID(int orderID)
        {
            List<OrderDetail> orderDetails = await _context.OrderDetails
                .Where(t => t.OrderID == orderID)
                .ToListAsync();

            return orderDetails;
        }

        public async Task<IPagedList<OrderDetail>> GetByPaged(int page, int pageSize, string keyword)
        {
            List<OrderDetail> orderDetails = await GetByKeyword(keyword);

            IPagedList<OrderDetail> pagedListOrderDetails = orderDetails.ToPagedList(page, pageSize);

            return pagedListOrderDetails;
        }

        public async Task<OrderDetail> GetSingleByID(int id)
        {
            OrderDetail orderDetail = await _context.OrderDetails.FindAsync(id);

            return orderDetail;
        }

        public async Task<bool> Update(OrderDetail entity)
        {
            try
            {
                OrderDetail cEntity = await GetSingleByID(entity.ID);

                if (cEntity != null)
                {
                    cEntity.UnitPrice = entity.UnitPrice;
                    cEntity.Quantily = entity.Quantily;

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return false;
        }
    }
}