# Lesson 125 — Interface Segregation Principle (ISP)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Interface Segregation Principle (ISP)** is the fourth principle of **SOLID**.

**Definition:**

> **Clients should not be forced to depend on interfaces they do not use.**

Instead of creating one large interface containing unrelated methods, divide it into smaller, focused interfaces.

---

# 2. Why ISP?

Large interfaces cause implementing classes to define methods they don't actually need.

Problems include:

- Unnecessary code
- Empty method implementations
- Difficult maintenance
- Tight coupling

ISP encourages **small, specific interfaces**.

---

# 3. Bad Example

```java
interface Machine {

    void print();

    void scan();

    void fax();
}

class Printer implements Machine {

    public void print() {
        System.out.println("Printing");
    }

    public void scan() {
        throw new UnsupportedOperationException();
    }

    public void fax() {
        throw new UnsupportedOperationException();
    }
}
```

The `Printer` is forced to implement methods it does not support.

---

# 4. Applying ISP

Split the interface into smaller ones.

```java
interface Printable {
    void print();
}

interface Scannable {
    void scan();
}

interface Faxable {
    void fax();
}

class Printer implements Printable {

    public void print() {
        System.out.println("Printing");
    }
}

class MultiFunctionPrinter
        implements Printable, Scannable, Faxable {

    public void print() { }

    public void scan() { }

    public void fax() { }
}
```

Each class implements only the interfaces it actually needs.

---

# 5. Benefits

- Reduced coupling
- Better maintainability
- Easier testing
- Improved flexibility
- Cleaner architecture

---

# 6. Real-World Example

```text
Employee Portal

Authentication
│
├── Login
├── Logout

Payroll
│
├── Salary

Attendance
│
└── Check In/Out
```

Different modules expose only relevant operations.

---

# 7. ISP vs SRP

| SRP | ISP |
|-----|-----|
| Focuses on class responsibilities | Focuses on interface design |
| One reason to change | Small, client-specific interfaces |

---

# 8. Best Practices

- Keep interfaces small and cohesive.
- Design interfaces around client needs.
- Avoid "God Interfaces."
- Combine interfaces only when necessary.

---

# 9. Common Mistakes

❌ Creating interfaces with dozens of methods.

❌ Throwing `UnsupportedOperationException` because methods are irrelevant.

❌ Mixing unrelated responsibilities in one interface.

---

# 10. Advantages

- Cleaner APIs
- Better code reuse
- Reduced implementation burden
- Easier extension
- Improved modularity

---

# 11. Interview Questions

1. What is the Interface Segregation Principle?
2. Why are large interfaces a problem?
3. How does ISP differ from SRP?
4. What is a "God Interface"?
5. Give a real-world example of ISP.

---

# 12. Quick Revision

```text
ISP
│
├── Small Interfaces
├── Client Specific
├── No Unused Methods
└── Loose Coupling
```

---

# 13. Interview Cheat Sheet

```text
Interface Segregation Principle

✔ Small Interfaces
✔ Client-Oriented Design
✔ No Forced Implementations

Benefits

Maintainable
Flexible
Reusable
```

---

# 14. Summary

The Interface Segregation Principle states that clients should depend only on the methods they actually use. By dividing large interfaces into smaller, focused ones, ISP reduces coupling, improves maintainability, and enables cleaner, more flexible object-oriented designs.
