# Lesson 151 — Domain-Driven Design (DDD) Basics

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Domain-Driven Design (DDD)** is a software design approach introduced by **Eric Evans** that focuses on building software around the **business domain**.

Instead of designing applications around databases or frameworks, DDD models real-world business concepts using object-oriented principles.

DDD is widely used in enterprise applications such as banking, healthcare, e-commerce, insurance, and ERP systems.

---

# 2. What is a Domain?

A **domain** is the area of business or knowledge that the software solves.

Examples:

- Banking
- Online Shopping
- Hospital Management
- Airline Reservation
- Education

The software should reflect the language and rules of its domain.

---

# 3. Core Idea of DDD

```text
Business Problem
       │
       ▼
Domain Model
       │
       ▼
Software Design
       │
       ▼
Implementation
```

The domain model becomes the heart of the application.

---

# 4. Building Blocks of DDD

- **Entity**: Object with a unique identity.
- **Value Object**: Defined by its values, not identity.
- **Aggregate**: Cluster of related objects treated as one unit.
- **Repository**: Handles persistence of aggregates.
- **Service**: Contains business logic not belonging to a single entity.
- **Domain Event**: Represents something important that happened in the domain.

---

# 5. Ubiquitous Language

DDD encourages developers and business experts to use the **same vocabulary**.

Example:

Instead of:

```text
CustomerRecord
```

Use:

```text
Customer
```

Consistent terminology reduces misunderstandings.

---

# 6. Bounded Context

Large systems are divided into independent business areas.

```text
E-Commerce

├── Customer
├── Inventory
├── Payment
└── Shipping
```

Each bounded context has its own models and rules.

---

# 7. Example

```java
class BankAccount {

    private double balance;

    public void deposit(double amount) {
        balance += amount;
    }

    public void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
        }
    }
}
```

The class models business behavior rather than merely storing data.

---

# 8. Benefits

- Better alignment with business requirements
- Rich object models
- Easier maintenance
- Improved scalability
- Clear separation of responsibilities

---

# 9. Best Practices

- Understand the business domain before coding.
- Use meaningful names.
- Keep business logic inside domain models.
- Separate infrastructure from domain logic.
- Collaborate with domain experts.

---

# 10. Common Mistakes

❌ Treating entities as simple database records.

❌ Placing all business logic in service classes.

❌ Ignoring business terminology.

❌ Designing around the database instead of the domain.

---

# 11. Interview Questions

1. What is Domain-Driven Design?
2. What is a domain model?
3. What is ubiquitous language?
4. What is a bounded context?
5. Why is DDD useful in enterprise software?

---

# 12. Quick Revision

```text
DDD
│
├── Domain Model
├── Entities
├── Value Objects
├── Services
├── Repositories
└── Bounded Context
```

---

# 13. Interview Cheat Sheet

```text
Domain-Driven Design

✔ Business-Centric Design
✔ Rich Domain Models
✔ Ubiquitous Language
✔ Bounded Contexts
✔ Enterprise Architecture
```

---

# 14. Summary

Domain-Driven Design is an object-oriented approach that places the business domain at the center of software development. By modeling real-world concepts through entities, value objects, services, repositories, and bounded contexts, DDD produces enterprise applications that are easier to understand, maintain, and evolve as business requirements change.
