# Lesson 159 — Building an E-Commerce Application

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **E-Commerce Application** is one of the most common enterprise software systems and demonstrates how Object-Oriented Programming (OOP), layered architecture, and design patterns work together.

Typical features include:

- User registration
- Product catalog
- Shopping cart
- Order placement
- Payment processing
- Inventory management

These features are implemented using Controllers, Services, Repositories, DTOs, and Domain Entities.

---

# 2. High-Level Architecture

```text
                Customer
                    │
             HTTP Request
                    │
          Controller Layer
                    │
            Service Layer
                    │
          Repository Layer
                    │
                Database
```

Each layer performs a specific responsibility.

---

# 3. Domain Model

```text
Customer
    │
    ├── Shopping Cart
    │
    ├── Orders
    │
    └── Address

Product
    │
    └── Inventory
```

Core entities:

- Customer
- Product
- Cart
- Order
- OrderItem

Value objects:

- Address
- Money
- Email

---

# 4. Main Classes

```java
class Customer {
    Long customerId;
    String name;
}

class Product {
    Long productId;
    String name;
    double price;
}

class Order {
    Long orderId;
    double totalAmount;
}
```

These represent the application's core business objects.

---

# 5. Repository Layer

Repositories handle persistence.

```java
public interface ProductRepository {

    Product findById(Long id);

    Product save(Product product);
}
```

Repositories communicate with the database only.

---

# 6. Service Layer

Business logic belongs in services.

```java
@Service
public class OrderService {

    public void placeOrder(Order order) {

        // Validate stock

        // Calculate total

        // Save order
    }
}
```

Typical responsibilities:

- Add to cart
- Remove from cart
- Place order
- Process payment
- Update inventory

---

# 7. Controller Layer

```java
@RestController
@RequestMapping("/orders")
public class OrderController {

    @PostMapping
    public String placeOrder() {

        return "Order Placed";
    }
}
```

Controllers receive requests and delegate work to services.

---

# 8. DTOs

Example request:

```text
CreateOrderRequestDTO

CustomerId
ProductIds
Address
```

Example response:

```text
OrderResponseDTO

OrderId
Status
TotalAmount
```

DTOs expose only required data to clients.

---

# 9. Order Workflow

```text
Customer
    │
Add to Cart
    │
Controller
    │
Service
    │
Repository
    │
Database
    │
Order Confirmation
```

Every request follows the layered architecture.

---

# 10. Applying OOP Principles

### Encapsulation

```java
private double price;
private int quantity;
```

Keep object state private.

---

### Inheritance

```text
Product
   │
   ├── PhysicalProduct
   └── DigitalProduct
```

Specialized product types reuse common behavior.

---

### Polymorphism

```java
payment.process();
```

Different payment methods implement processing differently.

---

### Abstraction

Expose simple operations:

```java
addToCart()

checkout()

pay()

trackOrder()
```

Users interact with services instead of implementation details.

---

# 11. Additional Features

Enterprise e-commerce systems often include:

- Authentication
- Authorization
- Discount coupons
- Product reviews
- Wishlist
- Search
- Recommendation engine
- Notifications
- Shipment tracking
- Returns and refunds

Because buying a pair of socks now requires roughly the architecture once used for space missions.

---

# 12. Best Practices

- Keep controllers thin.
- Store business rules in services.
- Use repositories only for persistence.
- Use DTOs for APIs.
- Validate user input.
- Apply transactions for order placement.
- Follow SOLID principles.

---

# 13. Interview Questions

1. Design an e-commerce application using OOP.
2. Which classes are entities?
3. How would you implement a shopping cart?
4. Why use DTOs?
5. Which OOP principles are applied?

---

# 14. Quick Revision

```text
E-Commerce

Controller
      │
Service
      │
Repository
      │
Database

Entities

Customer
Product
Cart
Order

OOP

Encapsulation
Inheritance
Polymorphism
Abstraction
```

---

# 15. Interview Cheat Sheet

```text
Architecture

Controller
Service
Repository
Database

Core Entities

Customer
Product
Cart
Order

Features

Shopping Cart
Checkout
Payment
Inventory

Patterns

DTO
Repository
Layered Architecture
SOLID
```

---

# 16. Summary

An e-commerce application is a practical example of enterprise software built with Object-Oriented Programming. By organizing the system into controllers, services, repositories, DTOs, and domain entities while applying encapsulation, inheritance, polymorphism, and abstraction, developers can build scalable, secure, and maintainable applications capable of handling complex business workflows.
