# Lesson 123 — Open Closed Principle (OCP)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Open Closed Principle (OCP)** is the second principle of **SOLID**.

**Definition:**

> **Software entities should be open for extension but closed for modification.**

This means existing, tested code should not be changed whenever new functionality is required. Instead, extend the behavior through new classes or implementations.

---

# 2. Why OCP?

Frequently modifying existing classes can:

- Introduce bugs
- Break existing functionality
- Increase maintenance cost

OCP promotes extending software without altering stable code.

---

# 3. Bad Example

```java
class PaymentProcessor {

    void process(String type) {

        if (type.equals("CreditCard")) {
            System.out.println("Credit Card");
        } else if (type.equals("UPI")) {
            System.out.println("UPI");
        }
    }
}
```

Adding a new payment type requires modifying the class.

---

# 4. Applying OCP

```java
interface Payment {

    void process();
}

class CreditCardPayment implements Payment {

    public void process() {
        System.out.println("Credit Card");
    }
}

class UpiPayment implements Payment {

    public void process() {
        System.out.println("UPI");
    }
}

class PaymentProcessor {

    void process(Payment payment) {
        payment.process();
    }
}
```

To support another payment method, simply create another implementation of `Payment`.

---

# 5. How OCP Works

```text
          Payment
             ▲
   ┌─────────┼─────────┐
   │         │         │
CreditCard  UPI     NetBanking
```

The processor remains unchanged while new behavior is added.

---

# 6. Real-World Example

A report generator supports PDF reports.

Later, Excel reports are needed.

Instead of modifying the existing report generator, create a new report implementation that follows the same interface.

---

# 7. Benefits

- Easier maintenance
- Better extensibility
- Lower risk of bugs
- Improved code reuse
- Flexible architecture

---

# 8. Best Practices

- Program to interfaces.
- Prefer composition over conditional logic.
- Use inheritance only when appropriate.
- Keep stable code closed to modification.

---

# 9. Common Mistakes

❌ Using long `if-else` or `switch` statements for every new feature.

❌ Modifying existing business logic for every requirement.

❌ Ignoring abstraction.

---

# 10. Advantages

- Reduced regression bugs
- Cleaner architecture
- Easier feature additions
- Better scalability
- Improved testing

---

# 11. Interview Questions

1. What is the Open Closed Principle?
2. What does "open for extension, closed for modification" mean?
3. How do interfaces help implement OCP?
4. Give a real-world example of OCP.
5. Why are long `if-else` chains considered a design smell?

---

# 12. Quick Revision

```text
OCP
│
├── Open for Extension
├── Closed for Modification
├── Interfaces
└── Polymorphism
```

---

# 13. Interview Cheat Sheet

```text
Open Closed Principle

✔ Extend Behavior
✔ Don't Modify Stable Code
✔ Use Interfaces
✔ Use Polymorphism

Benefits

Maintainable
Extensible
Scalable
```

---

# 14. Summary

The Open Closed Principle encourages designing software so that new functionality can be added without modifying existing, working code. By relying on abstractions such as interfaces and polymorphism, developers can extend behavior safely, producing systems that are easier to maintain, test, and evolve over time.
