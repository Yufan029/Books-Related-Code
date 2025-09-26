1. Simple factory

- encapsulate the creation into another class
- inject the new created factory class into its client (where to use)
- invoke the factory functionality to create the object client wants
- The factory often be static method, so there's no new key word anymore.(can see a lot in the real-world, but actually it's not a factory at all)
  ![alt text](image.png)
  ![alt text](image-1.png)

2. Factory Method Pattern

- delegate the creation functionality to the subclass and having a abstract create method in superclass

3. Offical definition

- Define an interface for creating an object, but lets subclasses decide which class to instantiate.
- Factory Method lets a class defer instantiation to subclasses.
