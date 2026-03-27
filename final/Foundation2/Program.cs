using System;

class Program
{
    static void Main(string[] args)
    {
      Address A1 = new Address("625 South Fourth Avenue","Pocatello","Idaho","USA");
      Address A2 = new Address("1365 South Fourth Avenue","Rexburg","Idaho","USA");
      Address A3 = new Address("7893 East Fourth Avenue","Seattle","Washington","USA");


      Customer C1 = new Customer("Christ KOUAKOU", A1);
      Customer C2 = new Customer("Mael Rayan", A2);
      Customer C3 = new Customer("Rose Bataille", A3);

    
      Order O1 = new Order(C1);
      Order O2 = new Order(C2);
      Order O3 = new Order(C3);

      Product P1 = new Product("Ventilateur","ABC1234", 4, 7);
      Product P2 = new Product("Voiture","KKC1234", 70000, 1);
      Product P3 = new Product("Ordinateur","ORD3456",2350, 2);

      Product P4 = new Product("Télévision","TLV5678", 3221, 1);
      Product P5 = new Product("Chaise","TLV5678", 34, 2);
      Product P6 = new Product("Clavier","CLV7890", 20, 4);

      Product P7 = new Product("Réfrigérateur","RFG5678", 532, 1);
      Product P8 = new Product("Micro-onde","MRO9012", 234, 1);
      Product P9 = new Product("Cafetière","CFT3456", 343, 2);

      O1.AddProduct(P1);
      O1.AddProduct(P2);
      O1.AddProduct(P3);

      O2.AddProduct(P4);
      O2.AddProduct(P5);
      O2.AddProduct(P6);


      O3.AddProduct(P7);
      O3.AddProduct(P8);
      O3.AddProduct(P9);



    List<Order> orders = new List<Order>();
    orders.Add(O1);
    orders.Add(O2);
    orders.Add(O3);

    
    foreach(Order order in orders)
        {
            
         Console.WriteLine(order.GetPackingLabel());
         Console.WriteLine(order.GetShippingLabel());
         Console.WriteLine("Total Price: $" + order.GetTotalPrice());

         Console.WriteLine();
        }
    }


    
}

