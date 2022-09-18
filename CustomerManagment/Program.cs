// See https://aka.ms/new-console-template for more information
using GamerManagerDemo.Abstract;
using GamerManagerDemo.Concrete;
using GamerManagerDemo.Entities;

Console.WriteLine("Hello, World!");
Gamer gamerManager = new Gamer { 

    DateofBirth = new DateTime(1999, 1, 1),
    FirstName = "Emre",
    Id = 1,
    LastName = "Koc",
    NationalId = "12432113"
};
IDiscountManagerService discountManagerService=new ProductManager();
Discount discount = new Discount
{
    price = 100,
    DiscountMsg = "We have big Sale",
    Id=1,
};
//discountManagerService.Add(discount);


IOrderService orderService1 = new OrderManager();
orderService1.Sale(discount , gamerManager);




















