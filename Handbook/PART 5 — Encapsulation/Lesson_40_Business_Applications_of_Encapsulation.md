# Lesson 40 — Business Applications of Encapsulation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Encapsulation is more than an academic OOP concept. It is one of the most widely used design principles in enterprise software.

By hiding internal data and exposing controlled operations, encapsulation helps developers build secure, reliable, and maintainable applications.

---

# 2. Why Businesses Use Encapsulation

Enterprise applications must ensure that:

- Data remains consistent.
- Business rules are always enforced.
- Unauthorized modifications are prevented.
- Internal implementation can evolve without affecting users.

Encapsulation makes these goals achievable.

---

# 3. Banking System

```java
class BankAccount {

    private double balance;

    public void deposit(double amount){
        if(amount > 0){
            balance += amount;
        }
    }

    public void withdraw(double amount){
        if(amount > 0 && amount <= balance){
            balance -= amount;
        }
    }

    public double getBalance(){
        return balance;
    }
}
```

The balance cannot be changed directly.

Only approved business operations modify it.

---

# 4. E-Commerce System

```java
class Product {

    private int stock;

    public void purchase(int quantity){
        if(quantity > 0 && quantity <= stock){
            stock -= quantity;
        }
    }
}
```

Customers cannot directly change inventory values.

---

# 5. Employee Management

```java
class Employee {

    private double salary;

    public void applyIncrement(double percent){
        if(percent > 0){
            salary += salary * percent / 100;
        }
    }
}
```

Salary changes occur through business rules instead of unrestricted setters.

---

# 6. Healthcare System

```java
class Patient {

    private String medicalRecord;

    public String viewRecord(){
        return medicalRecord;
    }
}
```

Sensitive medical information is protected from unauthorized modification.

---

# 7. Online Payment System

```text
Customer
    │
    ▼
Payment Service
    │
Validation
    │
    ▼
Payment Gateway
```

Users interact with business services rather than internal payment data.

---

# 8. Benefits in Enterprise Software

Encapsulation provides:

- Better security
- Data integrity
- Easier maintenance
- Reduced coupling
- Easier testing
- Improved scalability
- Better API design

---

# 9. Encapsulation in Layered Architecture

```text
Presentation Layer
        │
        ▼
Service Layer
        │
Business Rules
        │
        ▼
Data Access Layer
        │
        ▼
Database
```

Business logic remains centralized instead of being scattered across the application.

---

# 10. Framework Examples

Many Java frameworks encourage encapsulation.

Examples:

- JavaBeans use private fields with getters and setters.
- Spring services expose business methods instead of database details.
- JPA entities protect internal state while mapping object fields to database columns.

---

# 11. Common Mistakes

❌ Public fields in domain classes.

❌ Generic setters that bypass business rules.

❌ Returning mutable internal collections directly.

❌ Mixing business logic with UI code.

---

# 12. Best Practices

- Keep fields private.
- Expose meaningful business methods.
- Validate every state change.
- Hide implementation details.
- Design APIs around behavior, not raw data.

---

# 13. Interview Questions

1. Why is encapsulation important in enterprise software?
2. Give a real-world example of encapsulation.
3. Why are business methods preferred over generic setters?
4. How does encapsulation improve maintainability?
5. How does encapsulation support layered architecture?

---

# 14. Summary

Encapsulation is a cornerstone of enterprise software development. By protecting internal data and exposing carefully designed business operations, it ensures data integrity, improves security, reduces coupling, and keeps applications maintainable. From banking and healthcare to e-commerce and payment systems, encapsulation enables software that is easier to extend, test, and scale while consistently enforcing business rules.
