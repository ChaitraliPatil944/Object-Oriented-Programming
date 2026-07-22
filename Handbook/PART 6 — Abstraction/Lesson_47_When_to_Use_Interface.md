# Lesson 47 — When to Use Interface

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **interface** should be used when you want to define a **contract** that multiple classes must follow, regardless of whether they belong to the same inheritance hierarchy.

Interfaces focus on **capabilities (what an object can do)** rather than **shared implementation (how it does it)**.

---

# 2. When Should You Use an Interface?

Use an interface when:

- Classes are unrelated but share common behavior.
- Only a contract is required.
- Multiple inheritance of type is needed.
- Different implementations should be interchangeable.
- Loose coupling is desired.

---

# 3. Decision Flow

```text
Need only a contract?
        │
       Yes
        │
Need multiple implementations?
        │
       Yes
        │
        ▼
   Use Interface
```

---

# 4. Example: Payment System

```java
interface Payment {
    void pay(double amount);
}

class CreditCardPayment implements Payment {

    @Override
    public void pay(double amount) {
        System.out.println("Paid using Credit Card");
    }
}

class UPIPayment implements Payment {

    @Override
    public void pay(double amount) {
        System.out.println("Paid using UPI");
    }
}
```

Client code:

```java
Payment payment = new CreditCardPayment();
payment.pay(1000);
```

The client depends on the interface, not the implementation.

---

# 5. Example: Printable Objects

```java
interface Printable {
    void print();
}

class Invoice implements Printable {

    public void print() {
        System.out.println("Printing Invoice");
    }
}

class Report implements Printable {

    public void print() {
        System.out.println("Printing Report");
    }
}
```

Different classes provide the same capability.

---

# 6. Multiple Interface Implementation

```java
interface Flyable {
    void fly();
}

interface Swimmable {
    void swim();
}

class Duck implements Flyable, Swimmable {

    public void fly() {
        System.out.println("Flying");
    }

    public void swim() {
        System.out.println("Swimming");
    }
}
```

A class can implement multiple interfaces simultaneously.

---

# 7. Enterprise Example

```java
interface NotificationService {
    void send(String message);
}

class EmailService implements NotificationService {

    public void send(String message) {
        System.out.println("Sending Email");
    }
}

class SMSService implements NotificationService {

    public void send(String message) {
        System.out.println("Sending SMS");
    }
}
```

New notification methods can be added without changing client code.

---

# 8. Advantages

- Loose coupling
- Easy testing and mocking
- Flexible architecture
- Supports dependency injection
- Multiple inheritance of type
- Easier extensibility

---

# 9. When NOT to Use an Interface

Avoid an interface when:

- Common state must be shared.
- Common constructors are required.
- Significant shared implementation exists.

In these situations, an abstract class is usually more appropriate.

---

# 10. Interface vs Abstract Class

| Situation | Use Interface | Use Abstract Class |
|------------|---------------|--------------------|
| Only contract | ✅ | ❌ |
| Shared implementation | ❌ | ✅ |
| Shared fields | ❌ | ✅ |
| Multiple inheritance | ✅ | ❌ |
| Common constructor | ❌ | ✅ |

---

# 11. Best Practices

- Keep interfaces focused on a single responsibility.
- Program to interfaces, not implementations.
- Use meaningful method names.
- Avoid "fat" interfaces with unrelated methods.

---

# 12. Common Mistakes

❌ Using interfaces just because they exist.

❌ Placing unrelated methods in one interface.

❌ Using interfaces when shared implementation is clearly needed.

---

# 13. Interview Questions

1. When should you use an interface?
2. Why are interfaces preferred in enterprise applications?
3. Can a class implement multiple interfaces?
4. Why do frameworks like Spring encourage interfaces?
5. When would you choose an abstract class instead?

---

# 14. Quick Rule

```text
Need only behavior?
        +
Need loose coupling?
        +
Need multiple implementations?
        =
Use Interface
```

---

# 15. Summary

Use an interface when you need to define a common contract that different classes can implement independently. Interfaces promote loose coupling, flexibility, and extensibility, making them ideal for enterprise applications, APIs, dependency injection, and design patterns. They are the preferred choice when behavior matters more than shared implementation.
