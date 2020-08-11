using System;
using System.Collections.Generic;
using System.Linq;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;
using Xunit;

namespace PizzaStore.Testing
{
  public class UnitTest1
  {
    [Fact]
    public void TestComputePizzaPrice()
    {
      var sut = new PizzaModel();

      sut.Size = new SizeModel() { Name = "L" };
      sut.Size.SetPrice();
      var expected = 9.0M;
      Assert.Equal(expected, sut.Size.Price); // assert pizza price after giving it a size

      sut.Crust = new CrustModel() { Name = "Stuffed" };
      sut.Crust.SetPrice();
      expected = 1.0M; // 9 + 1
      Assert.Equal(expected, sut.Crust.Price);

      var topping1 = new ToppingModel() { Name = "Jalapeno" }; // $0.5
      topping1.SetPrice();
      Assert.Equal(0.5M, topping1.Price);

      var topping2 = new ToppingModel() { Name = "Olives" };   // $0.35 
      topping2.SetPrice();
      Assert.Equal(0.35M, topping2.Price);

      sut.Toppings = new List<ToppingModel>()
          {
            topping1, topping2
          };
      expected = 10.85M;
      sut.ComputePizzaPrice();
      Assert.Equal(expected, sut.Price);
    }
    
    [Fact]
    public void Test_CreatePizza()
    {
      // arrange
      PizzaFactory pizza = new PizzaFactory();
      var sut = pizza.Create("Test", "Stuffed", "L", new List<string>() { "Jalapeno", "Olives" });
      var expectedPrice = 10.85M;

      // act
      sut.ComputePizzaPrice();

      // assert
      Assert.NotNull(sut);
      Assert.Equal(expectedPrice, sut.Price);
      Assert.Equal("Test", sut.Name);
    }

    [Theory]
    [InlineData("Hawaiian","Regular","S","Pineapple","Ham",6.4)]
    [InlineData("Veggie","Flatbread","M","Olives","Spinach",8.65)]
    [InlineData("Cheese","Chicago","XL","Cheese","Cheese",13.15)]
    public void Test_CreatePizza1(string name, string crust, string size, string t1, string t2, decimal expectedPrice)
    {
      // arrange
      PizzaFactory pizza = new PizzaFactory();
      var sut = pizza.Create(name, crust, size, new List<string>() { t1, t2 });
 
      // act
      sut.ComputePizzaPrice();

      // assert
      Assert.NotNull(sut);
      Assert.Equal(expectedPrice, sut.Price);
      Assert.Equal(name, sut.Name);
    }
  }
}
