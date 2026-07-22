# Lesson 131 — Factory Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Factory Pattern** is a creational design pattern that **delegates object creation** to a dedicated factory instead of creating objects directly with `new`.

It helps reduce coupling between clients and concrete classes.

---

# 2. Problem

Without a factory:

```text
Client

new CardPayment()
new UPIPayment()
new WalletPayment()
```

Problems:

- Tight coupling
- Hard to extend
- Object creation scattered across the codebase

---

# 3. Solution

```text
Client
   │
PaymentFactory
   │
Creates Objects
   │
Card / UPI / Wallet
```

The client requests an object from the factory without knowing the creation details.

---

# 4. Components

- Product (interface/abstract class)
- Concrete Products
- Factory
- Client

---

# 5. Example

### Product

```java
interface Payment {
    void pay();
}
```

### Concrete Products

```java
class CardPayment implements Payment {
    public void pay() {
        System.out.println("Paid using Card");
    }
}

class UPIPayment implements Payment {
    public void pay() {
        System.out.println("Paid using UPI");
    }
}
```

### Factory

```java
class PaymentFactory {

    public static Payment create(String type) {

        if ("CARD".equalsIgnoreCase(type))
            return new CardPayment();

        if ("UPI".equalsIgnoreCase(type))
            return new UPIPayment();

        throw new IllegalArgumentException("Unknown payment");
    }
}
```

### Client

```java
Payment payment = PaymentFactory.create("UPI");
payment.pay();
```

---

# 6. How It Works

```text
Client
   │
create("UPI")
   │
Factory
   │
Creates UPIPayment
   │
Returns Payment
```

---

# 7. Advantages

- Loose coupling
- Centralized creation logic
- Easier maintenance
- Supports Open/Closed Principle
- Client depends on abstractions

---

# 8. Disadvantages

- Additional factory classes
- Slightly more code
- Large factories can become difficult to maintain

---

# 9. Real-World Examples

- Payment gateways
- Database drivers
- Parser selection
- Notification services
- Shape creation in graphics applications

---

# 10. Factory vs Singleton

| Factory | Singleton |
|---------|-----------|
| Creates objects | Restricts object creation |
| Many objects possible | Exactly one instance |
| Focus on creation logic | Focus on single shared instance |

---

# 11. Factory vs Builder

| Factory | Builder |
|---------|---------|
| Chooses object type | Builds complex objects |
| Usually one step | Multiple construction steps |

---

# 12. Best Practices

- Return interfaces instead of concrete classes.
- Keep creation logic inside factories.
- Avoid putting business logic into the factory.
- Consider separate factories if one becomes too large.

Because a factory that knows how to build absolutely everything eventually resembles a warehouse managed by optimism alone.

---

# 13. Interview Questions

1. What problem does the Factory pattern solve?
2. Why is it better than calling `new` everywhere?
3. Factory vs Abstract Factory?
4. Factory vs Builder?
5. How does the Factory pattern reduce coupling?

---

# 14. Quick Revision

```text
Factory Pattern

✔ Centralized Creation
✔ Loose Coupling
✔ Returns Interface
✔ Easy to Extend

Flow

Client
   │
Factory
   │
Concrete Object
```

---

# 15. Summary

The Factory pattern centralizes object creation and hides construction details from clients. By returning abstractions instead of concrete implementations, it reduces coupling, improves maintainability, and makes applications easier to extend as new object types are introduced.
