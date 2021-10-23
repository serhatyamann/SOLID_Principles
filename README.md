## The SOLID Principles

* [1.Single Responsibility Principle (SRP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/1.SRP_Single_Responsibility)
* [2.Open Closed Principle (OCP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/2.OCP_Open_Closed)
* [3.Liskov Substitution Principle (LSP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/3.LSP_Liskov_Substitution)
* [4.Interface Segregation Principle (ISP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/4.ISP_Interface_Segregation)
* [5.Dependency Inversion Principle (DIP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/5.DIP_Dependency_Inversion)

### [Single Responsibility Principle](https://github.com/serhatyamann/SOLID_Principles/tree/master/1.SRP_Single_Responsibility)

#### The Single-Responsibility Principle states that our design should be as simple as possible. Each class must have one responsibility. If we designed a complex class to do multiple things then it would require more changes if we must accommodate any new requirements. It would also require more testing. So it would be better to design a class with a single responsibility and not overload it with responsibilities.

### [Open Closed Principle](https://github.com/serhatyamann/SOLID_Principles/tree/master/2.OCP_Open_Closed)

#### The Open / Closed Principle (OCP) states that our design should be open for extension but closed for modification. This means that once a module has been developed and tested, the code should only be modified to correct bugs in existing code but not to add any new functionality. We should design our architecture in a way that, when a new functionality is needed, we should not modify our existing code but rather write new code that will be used by existing code. We can observe that SRP and OCP are complementary.

### [Liskov Substitution Principle](https://github.com/serhatyamann/SOLID_Principles/tree/master/3.LSP_Liskov_Substitution)

#### The LISKOV principle says the parent should easily replace the child object without knowing it. According to Barbara Liskov, "If for each object o1 of type S there is an object o2 of type T such that for all programs P defined in terms of T, the behavior of P is unchanged when o1 is substituted for o2 then S is a subtype of T". All subclasses must behave as their base classes. The specific functionality of the subclass may be different but must follow the expected behavior of the parent class. The LISKOV Substitution principle also highlights that inheritors should not throw new exception types.

### [Interface Segregation Principle](https://github.com/serhatyamann/SOLID_Principles/tree/master/4.ISP_Interface_Segregation)

#### The Interface Segregation Principle states that clients should not be forced to implement interfaces they don't use. Each interface should have a specific purpose. Suppose we have defined a huge interface to serve our multiple modules. Then we are forced to implement the full interface and must write some dummy methods in all classes and that is obviously unnecessary. These types of interfaces are known as Fat or Polluted interfaces.

### [Dependency Inversion Principle (DIP)](https://github.com/serhatyamann/SOLID_Principles/tree/master/5.DIP_Dependency_Inversion)

#### The Dependency Inversion Principle states that high-level modules should not depend upon low-level modules. Both should depend upon abstractions. It also states that abstractions should not depend upon details. Details should depend upon abstractions. High-level classes should not work directly with low-level classes. It should be done by interfaces as an abstraction. It will result in complex code, in other words more classes and interfaces, but the code would be more flexible.

