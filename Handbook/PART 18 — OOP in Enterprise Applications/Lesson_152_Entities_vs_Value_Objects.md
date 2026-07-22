# Lesson 152 — Entities vs Value Objects

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

In **Domain-Driven Design (DDD)**, two fundamental building blocks are **Entities** and **Value Objects**.

Although both are objects in the domain model, they differ in how they are identified and how they are compared.

Understanding this distinction leads to cleaner, more maintainable enterprise applications.

---

# 2. What is an Entity?

An **Entity** is an object that has a **unique identity** throughout its lifetime.

Even if its attributes change, its identity remains the same.

Examples:

- Customer
- Bank Account
- Employee
- Order

```java
class Customer {

    private Long customerId;
    private String name;
}
```

The `customerId` uniquely identifies the customer.

---

# 3. Characteristics of an Entity

- Has a unique identity
- State can change over time
- Equality is based on identity
- Usually persisted in a database

---

# 4. What is a Value Object?

A **Value Object** is identified only by the values it contains.

It has **no unique identity**.

Examples:

- Address
- Money
- Email
- Coordinates

```java
class Address {

    private String city;
    private String state;
    private String pinCode;
}
```

Two addresses with identical values are considered equal.

---

# 5. Characteristics of a Value Object

- No unique identity
- Usually immutable
- Equality based on values
- Safe to share between objects

---

# 6. Entity vs Value Object

| Entity | Value Object |
|--------|--------------|
| Has identity | No identity |
| Mutable | Usually immutable |
| Equality by ID | Equality by values |
| Lifecycle tracked | No independent lifecycle |

---

# 7. Example

```text
Order (Entity)
│
├── Order ID = 101
├── Customer
└── Shipping Address (Value Object)
```

If the shipping address changes, a new value object is often created. The order remains the same entity.

---

# 8. Equality

Entity:

```java
customer1.getId() == customer2.getId();
```

Value Object:

```java
address1.equals(address2);
```

Entities compare identity, while value objects compare data.

---

# 9. Benefits

- Clear domain modeling
- Reduced duplication
- Better encapsulation
- Easier maintenance
- Improved thread safety through immutable value objects

---

# 10. Best Practices

- Use entities for objects with long-lived identity.
- Use immutable value objects where possible.
- Avoid giving value objects artificial IDs.
- Keep value objects small and focused.

---

# 11. Common Mistakes

❌ Treating every class as an entity.

❌ Making value objects mutable without reason.

❌ Comparing entities using all fields instead of identity.

❌ Assigning database IDs to value objects.

---

# 12. Interview Questions

1. What is an entity in DDD?
2. What is a value object?
3. How are entities and value objects compared?
4. Why are value objects often immutable?
5. Give real-world examples of both.

---

# 13. Quick Revision

```text
Entity
│
├── Identity
├── Mutable
└── Lifecycle

Value Object
│
├── No Identity
├── Immutable
└── Equality by Values
```

---

# 14. Interview Cheat Sheet

```text
Entity

✔ Unique Identity
✔ Mutable
✔ Equality by ID

Value Object

✔ No Identity
✔ Immutable
✔ Equality by Values
✔ Easy to Share
```

---

# 15. Summary

Entities and Value Objects are core concepts in Domain-Driven Design. Entities represent objects with a unique identity that persists over time, while Value Objects are defined solely by their attributes and are typically immutable. Correctly distinguishing between the two leads to richer domain models, cleaner code, and more maintainable enterprise applications.
