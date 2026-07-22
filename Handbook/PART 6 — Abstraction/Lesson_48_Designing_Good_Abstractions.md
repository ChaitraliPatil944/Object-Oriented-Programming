# Lesson 48 — Designing Good Abstractions

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Designing a good abstraction means exposing only the essential behavior of an object while hiding unnecessary implementation details. A good abstraction makes software easier to understand, extend, test, and maintain.

---

# 2. Goals of Good Abstraction

A good abstraction should:

- Hide complexity
- Expose meaningful operations
- Reduce coupling
- Improve reusability
- Support future changes

---

# 3. Think in Terms of Behavior

Instead of exposing data, expose behavior.

Poor Design:

```java
class BankAccount {
    public double balance;
}
```

Better Design:

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) { }

    public void withdraw(double amount) { }

    public double getBalance() {
        return balance;
    }
}
```

---

# 4. Keep Interfaces Simple

Expose only operations that users actually need.

```text
User
 │
 ▼
deposit()
withdraw()
transfer()

Hidden:
Validation
Database Updates
Logging
```

---

# 5. Program to Interfaces

```java
interface Payment {
    void pay(double amount);
}

class CreditCardPayment implements Payment {
    public void pay(double amount) {
        System.out.println("Credit Card");
    }
}
```

Client code depends on `Payment`, not a concrete class.

---

# 6. Single Responsibility

Each abstraction should represent one clear responsibility.

Good:

```text
Printer
 └── print()
```

Poor:

```text
Printer
 ├── print()
 ├── sendEmail()
 ├── calculateSalary()
 └── backupDatabase()
```

---

# 7. Avoid Leaking Implementation

Bad:

```java
ArrayList<String> getEmployees();
```

Better:

```java
List<String> getEmployees();
```

The caller depends on the abstraction (`List`) rather than a specific implementation.

---

# 8. Enterprise Example

```java
interface NotificationService {
    void send(String message);
}

class EmailService implements NotificationService {
    public void send(String message) {
        System.out.println("Email Sent");
    }
}

class SMSService implements NotificationService {
    public void send(String message) {
        System.out.println("SMS Sent");
    }
}
```

New notification types can be added without changing client code.

---

# 9. Characteristics of Good Abstractions

- Simple
- Focused
- Stable
- Reusable
- Flexible
- Easy to understand

---

# 10. Common Mistakes

❌ Exposing internal implementation.

❌ Large interfaces with unrelated methods.

❌ Tight coupling to concrete classes.

❌ Mixing multiple responsibilities.

---

# 11. Best Practices

- Hide unnecessary details.
- Keep APIs small and meaningful.
- Prefer interfaces for contracts.
- Follow the Single Responsibility Principle.
- Design around behavior instead of data.

---

# 12. Interview Questions

1. What makes a good abstraction?
2. Why should implementation details remain hidden?
3. Why program to interfaces instead of implementations?
4. What is abstraction leakage?
5. How does abstraction improve maintainability?

---

# 13. Design Checklist

```text
Good Abstraction
│
├── Hides complexity
├── Exposes behavior
├── Simple API
├── Loose coupling
├── Easy to extend
└── Stable contract
```

---

# 14. Summary

Good abstractions expose only the behavior users need while hiding implementation details. They reduce complexity, encourage loose coupling, improve maintainability, and make software easier to evolve. Designing clean abstractions is a key skill for building scalable enterprise Java applications and robust object-oriented systems.
