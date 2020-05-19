using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDb;
        
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        // GET: api/order
        // GET: api/order/pageQuery?buyer=XX&&seller=XX
        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string buyer, string? seller)
        {
            var query = BuildQuery(buyer, seller);
            return query.ToList();
        }

        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> QueryOrder(string buyer, string? seller, int skip, int take)
        {
            var query = BuildQuery(buyer, seller).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Order> BuildQuery(string buyer, string? seller)
        {
            IQueryable<Order> query = orderDb.Orders;
            if(buyer != null)
            {
                query = query.Where(t => t.Buyer.Contains(buyer));
            }
            if(seller != null)
            {
                query = query.Where(t => t.Seller.Contains(seller));
            }
            return query;
        }

        [HttpGet("{orderId}")]
        public ActionResult<Order> GetOrder(int orderId)
        {
            var order = orderDb.Orders.FirstOrDefault(t => t.OrderId == orderId);
            if(order == null)
            {
                return NotFound();
            }
            return order;
        }

        // GET: api/order/{orderId}/item
        [HttpGet("{orderId}/item")]
        public ActionResult<List<Item>> GetOrderItems(int orderId, int skip, int take)
        {
            var query = BuildQuery(orderId).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Item> BuildQuery(int orderId)
        {
            IQueryable<Item> query = orderDb.Items;
            query = query.Where(t => t.OrderId == orderId);
            return query;
        }

        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // POST: api/order/{orderId}
        [HttpPost("{orderId}")]
        public ActionResult<Item> PostOrderItem(int orderId, Item item)
        {
            try
            {
                orderDb.Items.Add(item);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return item;
        }

        // PUT: api/order/{orderId}
        [HttpPut("{orderId}")]
        public ActionResult<Order> PutOrder(int orderId, Order order)
        {
            if(orderId != order.OrderId)
            {
                return BadRequest("Order cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // PUT: api/order/{orderId}/{itemName}
        [HttpPut("{orderId}/{itemName}")]
        public ActionResult<Item> PutOrderItem(int orderId, string itemName, Item item)
        {
            if(orderId != item.OrderId)
            {
                return BadRequest("OrderItem cannot be modified!");
            }
            try
            {
                orderDb.Entry(item).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/order/{orderId}
        [HttpDelete("{orderId}")]
        public ActionResult DeleteOrder(int orderId)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(t => t.OrderId == orderId);
                if(order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        // DELETE: api/order/{orderId}/{itemName}
        [HttpDelete("{orderId}/{itemName}")]
        public ActionResult DeleteOrderItem(int orderId, string itemName)
        {
            try
            {
                var item = orderDb.Items.FirstOrDefault(t => t.OrderId==orderId && t.Name==itemName);
                if(item != null)
                {
                    orderDb.Remove(item);
                    orderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}