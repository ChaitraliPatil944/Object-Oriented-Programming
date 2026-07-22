# Lesson 34 — What is Encapsulation?

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Encapsulation** is one of the four fundamental principles of Object-Oriented Programming (OOP).

The word encapsulation means **wrapping data and the methods that operate on that data into a single unit**, called a **class**.

Instead of allowing every part of a program to directly modify an object's data, encapsulation provides controlled access through well-defined methods.

---

# 2. Definition

**Encapsulation** is the process of:

- Bundling data (variables) and behavior (methods) together in a class.
- Restricting direct access to internal data.
- Providing controlled access through public methods.

```text
+-------------------------+
|        Employee         |
|-------------------------|
| - id                    |
| - name                  |
| - salary                |
|-------------------------|
| + getSalary()           |
| + setSalary()           |
| + work()                |
+-------------------------+
```

---

# 3. Why is Encapsulation Needed?

Without encapsulation:

- Any code can modify object data.
- Invalid values may be assigned.
- Business rules become difficult to enforce.

Example:

```java
employee.salary = -5000;
```

Negative salary makes no business sense.

Encapsulation prevents such situations by validating data before accepting changes.

---

# 4. Basic Example

```java
class Employee {

    private String name;

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
}
```

Usage:

```java
Employee emp = new Employee();

emp.setName("Alice");

System.out.println(emp.getName());
```

---

# 5. Components of Encapsulation

Encapsulation consists of:

- **Private data members**
- **Public methods**
- **Controlled access**
- **Validation logic**

```text
User
  │
  ▼
Public Methods
  │
  ▼
Private Data
```

---

# 6. Real-World Analogy

Think of an **ATM**.

```text
Customer
    │
    ▼
ATM Interface
    │
    ▼
Bank Database
```

Customers cannot directly modify the bank database.

They interact through the ATM's controlled interface.

Similarly, objects expose methods instead of exposing internal data.

---

# 7. Advantages of Encapsulation

- Protects object data
- Improves security
- Prevents invalid states
- Simplifies maintenance
- Reduces coupling
- Improves code readability
- Supports abstraction

---

# 8. Enterprise Example

Consider a banking application.

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) {
        if (amount > 0) {
            balance += amount;
        }
    }

    public double getBalance() {
        return balance;
    }
}
```

The balance cannot be modified directly.

All updates pass through business rules.

---

# 9. Encapsulation vs Public Fields

Poor design:

```java
class Student {

    public int marks;
}
```

Better design:

```java
class Student {

    private int marks;

    public int getMarks() {
        return marks;
    }

    public void setMarks(int marks) {
        this.marks = marks;
    }
}
```

---

# 10. UML Representation

```text
+----------------------+
|      Student         |
+----------------------+
| - marks : int        |
+----------------------+
| + getMarks() : int   |
| + setMarks(int)      |
+----------------------+
```

`-` represents private members.

`+` represents public members.

---

# 11. Common Misconceptions

❌ Encapsulation only means using getters and setters.

❌ Every variable should always have a setter.

❌ Public variables are acceptable in enterprise applications.

Correct understanding:

- Encapsulation is about controlled access.
- Methods should enforce business rules.
- Some fields may intentionally be read-only.

---

# 12. Best Practices

- Keep fields private.
- Expose only necessary methods.
- Validate input before updating state.
- Avoid unnecessary setters.
- Design classes with clear responsibilities.

---

# 13. Interview Questions

1. What is encapsulation?
2. Why is encapsulation important?
3. How does encapsulation improve security?
4. What is the difference between encapsulation and data hiding?
5. Why are fields usually declared private?

---

# 14. Summary

Encapsulation is the OOP principle of combining data and behavior within a class while restricting direct access to internal data. By exposing carefully designed methods instead of public fields, encapsulation protects object integrity, enforces business rules, improves maintainability, and makes software easier to understand and extend.
