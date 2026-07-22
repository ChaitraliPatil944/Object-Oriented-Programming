# Lesson 171 — System Design Using OOP

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

System Design using Object-Oriented Programming focuses on modeling real-world problems as interacting objects with clear responsibilities.

Interviewers assess whether you can:

- Identify entities
- Define relationships
- Apply OOP principles
- Use design patterns
- Design scalable, maintainable software

---

# 2. OOP Design Process

```text
Requirements
      │
Identify Entities
      │
Define Relationships
      │
Assign Responsibilities
      │
Apply OOP Principles
      │
Implement Layers
```

---

# 3. Step 1: Understand Requirements

Before writing classes:

- What does the system do?
- Who are the users?
- What operations are required?
- What constraints exist?

Example:

Design a Food Delivery App.

Features:

- Browse restaurants
- Place orders
- Make payments
- Track delivery

---

# 4. Step 2: Identify Entities

Example:

```text
Customer
Restaurant
Menu
Order
DeliveryPartner
Payment
Address
```

Entities usually become classes.

---

# 5. Step 3: Identify Relationships

```text
Customer
    │
Places
    │
Order
    │
Contains
    │
OrderItem
    │
References
    │
Product
```

Common relationships:

- Association
- Aggregation
- Composition
- Inheritance

---

# 6. Step 4: Assign Responsibilities

Example:

```text
Customer
 ├── Place Order
 └── View Orders

Restaurant
 ├── Manage Menu
 └── Accept Orders

Payment
 └── Process Payment
```

Each class should have one primary responsibility.

---

# 7. Step 5: Apply OOP Principles

Encapsulation

```java
private double price;
```

Inheritance

```text
Vehicle
   │
Bike
Car
```

Polymorphism

```java
payment.process();
```

Abstraction

Expose operations instead of implementation details.

---

# 8. Step 6: Layered Architecture

```text
Client
   │
Controller
   │
Service
   │
Repository
   │
Database
```

Each layer has a dedicated responsibility.

---

# 9. Step 7: Choose Design Patterns

Common interview patterns:

| Problem | Pattern |
|---------|---------|
| One instance | Singleton |
| Object creation | Factory |
| Algorithm selection | Strategy |
| Event notification | Observer |
| Complex object creation | Builder |
| Simplified interface | Facade |
| Adapting incompatible APIs | Adapter |

---

# 10. Example: Online Shopping System

```text
Customer
   │
ShoppingCart
   │
Order
   │
Payment
   │
Inventory
```

Flow:

```text
Customer
    │
Controller
    │
Service
    │
Repository
    │
Database
```

---

# 11. Example: Ride Booking System

Classes:

```text
User
Driver
Vehicle
Ride
Location
Payment
```

Possible responsibilities:

- Find nearby driver
- Calculate fare
- Assign ride
- Process payment

---

# 12. Design Checklist

✔ Clear entities

✔ Proper relationships

✔ SOLID principles

✔ DTOs

✔ Service layer

✔ Repository pattern

✔ Dependency Injection

✔ Clean APIs

Because the best system design usually looks boring on paper. The excitement arrives later if responsibilities are mixed together.

---

# 13. Interview Strategy

When asked to design a system:

1. Clarify requirements.
2. Identify entities.
3. Draw relationships.
4. Define responsibilities.
5. Explain architecture.
6. Discuss scalability.
7. Mention trade-offs.

---

# 14. Interview Questions

1. How do you approach OOP system design?
2. How do you identify entities?
3. Why use layered architecture?
4. Which design patterns would you choose?
5. How do SOLID principles improve your design?

---

# 15. Quick Revision

```text
System Design

Requirements
      │
Entities
      │
Relationships
      │
Responsibilities
      │
Layers
      │
Patterns
```

---

# 16. Interview Cheat Sheet

```text
Process

Understand Requirements
Identify Entities
Define Relationships
Assign Responsibilities
Apply SOLID
Use Layers
Choose Patterns

Architecture

Controller
Service
Repository
Database
```

---

# 17. Summary

System design using OOP involves translating business requirements into well-structured classes, relationships, and layers. By identifying entities, assigning single responsibilities, applying SOLID principles, and using appropriate design patterns, developers can build scalable, maintainable, and extensible enterprise applications that are easy to understand and evolve.
