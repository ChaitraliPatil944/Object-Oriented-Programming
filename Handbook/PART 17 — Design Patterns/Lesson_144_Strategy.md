# Lesson 144 — Strategy Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Strategy Pattern** is a behavioral design pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable.

Instead of hardcoding an algorithm, the client selects the required strategy at runtime.

---

# 2. Problem

Suppose an e-commerce application supports multiple payment methods.

Without Strategy:

```text
if(payment == CARD)
if(payment == UPI)
if(payment == WALLET)
if(payment == NETBANKING)
```

As more payment methods are added, the code becomes difficult to maintain.

---

# 3. Solution

Encapsulate each algorithm into its own class.

```text
PaymentStrategy
      │
 ├── CardPayment
 ├── UpiPayment
 └── WalletPayment
```

The client chooses the appropriate strategy dynamically.

---

# 4. Participants

- Strategy Interface
- Concrete Strategies
- Context
- Client

---

# 5. Structure

```text
Client
   │
Context
   │
Strategy
 ├── Strategy A
 ├── Strategy B
 └── Strategy C
```

---

# 6. Example

### Strategy

```java
interface PaymentStrategy {
    void pay(int amount);
}
```

### Concrete Strategies

```java
class CardPayment implements PaymentStrategy {

    public void pay(int amount) {
        System.out.println("Paid using Card: " + amount);
    }
}

class UpiPayment implements PaymentStrategy {

    public void pay(int amount) {
        System.out.println("Paid using UPI: " + amount);
    }
}
```

### Context

```java
class ShoppingCart {

    private PaymentStrategy strategy;

    ShoppingCart(PaymentStrategy strategy){
        this.strategy = strategy;
    }

    void checkout(int amount){
        strategy.pay(amount);
    }
}
```

### Client

```java
ShoppingCart cart =
    new ShoppingCart(new UpiPayment());

cart.checkout(500);
```

---

# 7. How It Works

```text
Client
   │
Select Strategy
   │
Context
   │
Execute Algorithm
```

Changing the strategy changes behavior without modifying the context.

---

# 8. Advantages

- Eliminates long conditional statements
- Easy to add new algorithms
- Promotes composition over inheritance
- Supports runtime behavior changes

---

# 9. Disadvantages

- More classes
- Client must choose the appropriate strategy
- Slight increase in object creation

Because replacing one enormous `if-else` block with several tiny classes somehow counts as progress. It usually does.

---

# 10. Real-World Uses

- Payment gateways
- Sorting algorithms
- Compression algorithms
- Route planning
- Authentication methods

---

# 11. Strategy vs State

| Strategy | State |
|----------|-------|
| Client chooses behavior | Object changes behavior automatically |
| Algorithm selection | State transition |

---

# 12. Strategy vs Command

| Strategy | Command |
|----------|---------|
| Represents an algorithm | Represents a request |
| Focuses on how | Focuses on what |

---

# 13. Best Practices

- Keep strategies independent.
- Avoid storing unnecessary state inside strategies.
- Use interfaces to define common behavior.
- Prefer Strategy when multiple algorithms solve the same problem.

---

# 14. Interview Questions

1. What problem does the Strategy pattern solve?
2. Strategy vs State?
3. Strategy vs Command?
4. Why is composition preferred?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Strategy Pattern

✔ Interchangeable Algorithms
✔ Runtime Selection
✔ Composition
✔ Flexible Design

Flow

Client
   │
Context
   │
Strategy
```

---

# 16. Summary

The Strategy pattern encapsulates different algorithms behind a common interface, allowing them to be selected at runtime. It improves flexibility, reduces conditional logic, and makes applications easier to extend without modifying existing code.
