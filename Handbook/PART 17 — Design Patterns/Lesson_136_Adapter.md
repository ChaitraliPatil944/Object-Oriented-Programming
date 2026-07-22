# Lesson 136 — Adapter Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Adapter Pattern** is a structural design pattern that allows **incompatible interfaces to work together**.

It acts as a bridge between an existing class and a client expecting a different interface.

```text
Client
   │
Expected Interface
   │
Adapter
   │
Existing Class
```

---

# 2. Problem

Suppose your application expects a `PaymentProcessor`, but a third-party library provides `LegacyPaymentGateway`.

```text
Client
   │
PaymentProcessor
        ✘
LegacyPaymentGateway
```

The interfaces don't match.

---

# 3. Solution

Create an Adapter that translates requests.

```text
Client
   │
PaymentProcessor
   │
Adapter
   │
LegacyPaymentGateway
```

The client remains unchanged.

---

# 4. Participants

- Client
- Target Interface
- Adapter
- Adaptee (existing class)

---

# 5. Example

### Target Interface

```java
interface PaymentProcessor {
    void pay(double amount);
}
```

### Existing Class

```java
class LegacyPaymentGateway {
    void makePayment(double amount){
        System.out.println("Payment Successful");
    }
}
```

### Adapter

```java
class PaymentAdapter implements PaymentProcessor {

    private LegacyPaymentGateway gateway =
            new LegacyPaymentGateway();

    public void pay(double amount){
        gateway.makePayment(amount);
    }
}
```

### Client

```java
PaymentProcessor processor =
        new PaymentAdapter();

processor.pay(5000);
```

---

# 6. How It Works

```text
Client
   │
pay()
   │
Adapter
   │
makePayment()
   │
Legacy System
```

The adapter translates one interface into another.

---

# 7. Advantages

- Reuses existing code
- Reduces modification of legacy systems
- Promotes loose coupling
- Improves interoperability

---

# 8. Disadvantages

- Introduces an additional class
- Can increase complexity if overused

---

# 9. Object vs Class Adapter

**Object Adapter**

- Uses composition
- Preferred in Java

**Class Adapter**

- Uses inheritance
- Limited because Java does not support multiple class inheritance

---

# 10. Real-World Examples

- Legacy API integration
- Database driver wrappers
- Payment gateway integration
- File format converters
- USB-C to HDMI adapters

Because humans keep inventing new interfaces while insisting the old ones continue working forever.

---

# 11. Adapter vs Facade

| Adapter | Facade |
|---------|--------|
| Converts interfaces | Simplifies interfaces |
| Solves incompatibility | Hides subsystem complexity |
| Focuses on compatibility | Focuses on usability |

---

# 12. Adapter vs Decorator

| Adapter | Decorator |
|---------|-----------|
| Changes interface | Adds behavior |
| Translation | Extension |

---

# 13. Interview Questions

1. What problem does the Adapter pattern solve?
2. Adapter vs Facade?
3. Adapter vs Decorator?
4. Why is composition preferred?
5. Give real-world examples of Adapter.

---

# 14. Quick Revision

```text
Adapter Pattern

✔ Converts Interfaces
✔ Reuses Legacy Code
✔ Composition
✔ Loose Coupling

Flow

Client
  │
Adapter
  │
Existing Class
```

---

# 15. Summary

The Adapter pattern enables incompatible interfaces to collaborate without modifying existing code. By translating one interface into another, it promotes code reuse, simplifies legacy integration, and allows new systems to work seamlessly with older components.
