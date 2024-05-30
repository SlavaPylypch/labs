# Warehouse Management System

## Principles Demonstrated

### 1. DRY (Don't Repeat Yourself)
The DRY principle is adhered to by ensuring that no code is unnecessarily duplicated. For example, the `SetValue` method in the `Money` class prevents the need to write the same validation logic in multiple places.

**Code Reference:**
- [Money.cs: 15-24](Money.cs#L15-L24)

### 2. KISS (Keep It Simple, Stupid)
The KISS principle is followed by keeping the code simple and straightforward. Each class and method has a clear responsibility. For example, the `ReducePrice` method in the `Product` class directly handles price reduction without any unnecessary complexity.

**Code Reference:**
- [Product.cs: 13-25](Product.cs#L13-L25)

### 3. SOLID Principles

#### Single Responsibility Principle (SRP)
Each class in the system has a single responsibility. For instance, the `Product` class is only responsible for managing product details, while the `Warehouse` class handles inventory management.

**Code References:**
- [Product.cs: 5-28](Product.cs#L5-L28)
- [Warehouse.cs: 5-27](Warehouse.cs#L5-L27)

#### Open/Closed Principle (OCP)
Classes are designed to be open for extension but closed for modification. The `ProductWithCategory` class extends the `Product` class without modifying it.

**Code Reference:**
- [Product.cs: 30-40](Product.cs#L30-L40)

#### Liskov Substitution Principle (LSP)
The `ProductWithCategory` class can be used in place of the `Product` class without altering the correctness of the program, demonstrating LSP.

**Code Reference:**
- [Product.cs: 30-40](Product.cs#L30-L40)

#### Interface Segregation Principle (ISP)
Although not explicitly demonstrated with interfaces, the segregation of responsibilities across classes indicates adherence to ISP principles. Each class handles a specific part of the functionality without overlapping.

#### Dependency Inversion Principle (DIP)
Dependencies are injected rather than hardcoded. For example, the `Reporting` class depends on a collection of `Warehouse` objects, demonstrating DIP by relying on abstractions rather than concrete implementations.

**Code Reference:**
- [Reporting.cs: 7-49](Reporting.cs#L7-L49)

### 4. YAGNI (You Aren't Gonna Need It)
The code does not contain any unnecessary functionality that is not currently required. Each method and class serves a specific, needed purpose.

### 5. Composition Over Inheritance
The `ShoppingCart` class uses composition to manage a list of `Product` objects instead of inheriting from a base class, demonstrating the preference for composition over inheritance.

**Code Reference:**
- [ShoppingCart.cs: 7-44](ShoppingCart.cs#L7-L44)

### 6. Program to Interfaces, not Implementations
While explicit interfaces are not used, the principle is demonstrated by programming against abstractions. For example, the `Reporting` class interacts with `Warehouse` objects through their public interface.

**Code Reference:**
- [Reporting.cs: 7-49](Reporting.cs#L7-L49)

### 7. Fail Fast
The code is designed to fail fast by throwing exceptions immediately when invalid data is encountered. For example, the `Money` class constructor and `SetValue` method validate inputs and throw exceptions for invalid values.

**Code References:**
- [Money.cs: 7-12](Money.cs#L7-L12)
- [Money.cs: 15-24](Money.cs#L15-L24)
