// See https://aka.ms/new-console-template for more information
using GamerManagerDemo.Abstract;
using GamerManagerDemo.Concrete;
using GamerManagerDemo.Entities;

Console.WriteLine("Hello, World!");
IBaseGamerManager[] gamerManager = { new GamerManager(), new ProductManager()};
IEntitiesManager[] entitiesManagers = { new Discount { DiscountMsg="Hello",Id=1,price=100}, new Gamer { Id=2,DateofBirth = 1999,FirstName="Emre",LastName="KOC",NationalId="1212323"} };
IOrderService orderService = new OrderManager();
orderService.Sale(new Discount { Id=1}, new Gamer { FirstName="Emre"});
foreach (var game in gamerManager)
{
    
    game.Add(entitiesManagers[0]);
    game.Remove(entitiesManagers[0]);
    game.Updated(entitiesManagers[0]);



}







