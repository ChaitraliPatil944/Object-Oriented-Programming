# Lesson 35 — Data Hiding

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Data Hiding** is the practice of restricting direct access to an object's internal data. It protects the internal state of an object from unauthorized or accidental modification.

Data hiding is achieved in Java using **access modifiers**, especially `private`.

---

# 2. Definition

**Data Hiding** means preventing direct access to an object's data while allowing controlled access through methods.

```text
        User
          │
          ▼
   Public Methods
          │
          ▼
   Private Variables
```

The internal implementation remains hidden.

---

# 3. Why Data Hiding?

Without data hiding:

- Invalid values may be assigned.
- Internal implementation is exposed.
- Debugging becomes difficult.
- Business rules can be bypassed.

Example:

```java
employee.salary = -10000;
```

Such invalid updates should not be allowed.

---

# 4. Data Hiding in Java

```java
class Employee {

    private double salary;

    public void setSalary(double salary) {
        this.salary = salary;
    }

    public double getSalary() {
        return salary;
    }
}
```

The variable `salary` cannot be accessed directly.

---

# 5. How Data Hiding Works

```text
Outside Class
      │
      ▼
Public Methods
      │
      ▼
Private Data
```

Every update goes through class methods.

---

# 6. Data Hiding vs Encapsulation

| Data Hiding | Encapsulation |
|-------------|---------------|
| Hides implementation details | Bundles data and methods |
| Achieved using access modifiers | Achieved using classes and access control |
| Focuses on restricting access | Focuses on designing objects |

Data hiding is a part of encapsulation.

---

# 7. Real-World Analogy

Think of a **car**.

```text
Driver
   │
   ▼
Steering Wheel
   │
   ▼
Engine
```

The driver controls the car through the steering wheel and pedals, not by directly manipulating engine components.

Similarly, objects expose methods instead of internal data.

---

# 8. Enterprise Example

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) {
        if(amount > 0){
            balance += amount;
        }
    }

    public double getBalance(){
        return balance;
    }
}
```

The balance remains protected while business rules are enforced.

---

# 9. Benefits of Data Hiding

- Improves security
- Protects object integrity
- Reduces coupling
- Simplifies maintenance
- Prevents invalid object states
- Supports modular design

---

# 10. Common Mistakes

❌ Declaring all fields as public.

❌ Providing setters without validation.

❌ Exposing mutable internal objects directly.

Correct approach:

- Keep fields private.
- Validate input.
- Expose only required operations.

---

# 11. Best Practices

- Declare fields `private`.
- Provide only necessary getters/setters.
- Apply validation inside setters.
- Avoid exposing internal collections directly.
- Design classes with a clear public interface.

---

# 12. Interview Questions

1. What is data hiding?
2. How is data hiding achieved in Java?
3. What is the difference between data hiding and encapsulation?
4. Why are private variables preferred?
5. How does data hiding improve security?

---

# 13. Summary

Data hiding is the process of protecting an object's internal state by restricting direct access to its data. Java achieves this using access modifiers such as `private`, allowing controlled interaction through public methods. Data hiding improves security, maintainability, and reliability, making it a fundamental principle of object-oriented design.
