# Lesson 74 — Object Collaboration

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Object-Oriented systems are built from **objects that work together** to accomplish a task.

This interaction between objects is called **Object Collaboration**.

Instead of one object doing everything, responsibilities are distributed among multiple objects.

---

# 2. Definition

Object Collaboration is the process in which two or more objects communicate by calling each other's methods to complete a business operation.

Characteristics:

- Objects cooperate
- Each object has a specific responsibility
- Promotes modular design
- Encourages loose coupling

---

# 3. Real-World Example

```text
Customer
    │
    ▼
Shopping Cart
    │
    ▼
Payment Gateway
    │
    ▼
Bank
```

Each participant performs a specific role.

---

# 4. Java Example

```java
class Engine {
    void start() {
        System.out.println("Engine Started");
    }
}

class Car {
    private Engine engine = new Engine();

    void drive() {
        engine.start();
        System.out.println("Car Moving");
    }
}
```

Here, `Car` collaborates with `Engine` instead of implementing engine functionality itself.

---

# 5. Collaboration Flow

```text
User
 │
 ▼
Controller
 │
 ▼
Service
 │
 ▼
Repository
 │
 ▼
Database
```

Each object communicates only with the layer it needs.

---

# 6. Enterprise Example

```java
class OrderService {

    private PaymentService paymentService = new PaymentService();

    void placeOrder() {
        paymentService.processPayment();
        System.out.println("Order Placed");
    }
}
```

The `OrderService` delegates payment work to `PaymentService`.

---

# 7. Advantages

- Separation of responsibilities
- Better maintainability
- High reusability
- Loose coupling
- Easier testing

---

# 8. Best Practices

- Follow the Single Responsibility Principle.
- Delegate work to collaborating objects.
- Program to interfaces.
- Keep communication simple.

---

# 9. Common Mistakes

❌ One class doing all the work (God Object).

❌ Excessive object dependencies.

❌ Tight coupling between collaborators.

---

# 10. Interview Questions

1. What is object collaboration?
2. Why is collaboration important in OOP?
3. How is collaboration different from inheritance?
4. Give enterprise examples of collaboration.
5. How does collaboration improve maintainability?

---

# 11. Quick Revision

```text
Object Collaboration
│
├── Objects communicate
├── Delegate responsibilities
├── Loose coupling
├── Better modularity
└── Enterprise architecture
```

---

# 12. Summary

Object collaboration is the foundation of object-oriented software design. Instead of concentrating all logic in one class, multiple objects cooperate by exchanging messages and delegating responsibilities. Enterprise applications such as Spring-based systems, e-commerce platforms, and banking software rely heavily on object collaboration to create scalable, maintainable, and testable solutions.
