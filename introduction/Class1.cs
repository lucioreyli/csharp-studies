using static System.Console;

namespace IntroductionVariablesTypes {
  class Class1 {
    public void Init(){
      string name = "Lucin";
      bool enabled = true;
      int age = 19;
      decimal salary = 1232.10m;
      float discount = 0.5f;
      var city = "Manaus";
      city = "Rio do Sul";
      WriteLine($"The user {name} is {age}, is {enabled} at the system and get {salary} per month, have discount of {discount} and lives at {city}.");

      dynamic x = "This variable is a string";
      WriteLine(x);

      x = 10;
      WriteLine(x);

      x = false;
      WriteLine(x);
    }
  }

  class Class2 {
    public void Init() {
      char gender = 'M';
      int age = 19;
      string name = "3";
      WriteLine(gender.GetType().IsPrimitive);
      WriteLine(age.GetType().IsPrimitive);
      WriteLine(name.GetType().IsPrimitive); // string returns false

      int number1 = 10;
      long number2 = number1;
      // short number3 = n1; // returns error -> short cannot storage int value size;
      short number3 = (short) number1; // ✅ cast works
    }
  }

  class Class3 {
    public void Init() {
      int x = 10;
      int y = 5;
      int sum = x + y;
      int sub = x - y;
      int mult = x * y;
      int div = x / y;
      int number = 0;
      number += sum;
      number -= sub;
      number *= mult;
      number /= div;

      int rest = 7 % 3;
      rest++;
      rest--;
      ++rest;
      --rest;
    }
  }
}
