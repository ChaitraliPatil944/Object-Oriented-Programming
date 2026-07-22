# Lesson 72 — Dependency

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Dependency** is a relationship where one class temporarily uses another class to perform a task.

Unlike association, aggregation, or composition, the dependent object is **not stored as a permanent field**. It is usually passed as a method parameter, created inside a method, or returned by a method.

Dependency represents a **"uses-a"** relationship.

---

# 2. Definition

A class depends on another class if changes in the second class may affect the first class.

Characteristics:

- Temporary relationship
- No ownership
- Short-lived interaction
- Weakest object relationship

---

# 3. Real-World Example

```text
Customer ----> ATM

Customer uses an ATM.

The ATM is not owned by the customer.
```

After the transaction, the relationship ends.

---

# 4. Java Example

```java
class Printer {

    void print(String message) {
        System.out.println(message);
    }
}

class Report {

    void generate(Printer printer) {
        printer.print("Report Generated");
    }
}
```

Usage:

```java
Printer printer = new Printer();
Report report = new Report();

report.generate(printer);
```

Output:

```
Report Generated
```

`Report` depends on `Printer` only while generating the report.

---

# 5. Dependency Through Method Parameters

```java
class PaymentService {

    void process(PaymentGateway gateway) {
        gateway.pay();
    }
}
```

The dependency exists only for the duration of the method call.

---

# 6. UML Representation

Dependency is represented by a **dashed arrow**.

```text
Report - - - - - > Printer
```

---

# 7. Enterprise Examples

- Controller → Service
- Service → Repository
- Report → Printer
- OrderService → PaymentGateway
- EmailService → SMTP Client

Dependencies are common in layered architectures.

---

# 8. Advantages

- Loose coupling
- Better modularity
- Easier testing
- Supports Dependency Injection
- Improved maintainability

---

# 9. Best Practices

- Depend on interfaces, not implementations.
- Keep dependencies minimal.
- Use Dependency Injection frameworks where appropriate.
- Avoid creating unnecessary dependencies.

---

# 10. Common Mistakes

❌ Confusing dependency with composition.

❌ Storing temporary dependencies as permanent fields.

❌ Depending directly on concrete classes.

---

# 11. Interview Questions

1. What is dependency in OOP?
2. How is dependency different from association?
3. What UML symbol represents dependency?
4. Why is dependency considered the weakest relationship?
5. How does dependency support Dependency Injection?

---

# 12. Quick Revision

```text
Dependency
│
├── Uses-A Relationship
├── Temporary
├── Dashed Arrow
├── No Ownership
└── Loose Coupling
```

---

# 13. Summary

Dependency is the weakest relationship between objects, where one class temporarily uses another to complete a task. Since there is no ownership or permanent association, dependency encourages loose coupling and forms the basis of modern enterprise practices such as Dependency Injection and layered application architecture.
