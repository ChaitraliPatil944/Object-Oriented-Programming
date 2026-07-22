# Lesson 5 — Real World Modeling

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the biggest reasons Object-Oriented Programming (OOP) became successful is that it closely models the real world. Businesses deal with customers, employees, products, orders, payments, and vehicles. OOP allows software developers to represent these real-world entities as software objects.

Instead of thinking in terms of only functions, developers think in terms of **objects that have state and behavior**.

---

# 2. What is Real World Modeling?

Real World Modeling is the process of representing real-life entities, their properties, and their interactions as software objects.

Example:

```text
Real World
-------------------
Customer
Order
Product
Invoice
Payment
```

↓

```text
Software

Customer Class
Order Class
Product Class
Invoice Class
Payment Class
```

---

# 3. From Reality to Software

Consider a **Car**.

### Real World

State:
- Brand
- Color
- Speed
- Fuel Level

Behavior:
- Start()
- Stop()
- Accelerate()
- Brake()

↓

### Software

```java
class Car {

    String brand;
    String color;
    int speed;

    void start() {}

    void stop() {}

    void accelerate() {}

    void brake() {}
}
```

---

# 4. Object = State + Behavior + Identity

Every object consists of:

```text
               Object
          ┌──────────────┐
          │   Identity   │
          ├──────────────┤
          │    State     │
          ├──────────────┤
          │   Behavior   │
          └──────────────┘
```

### Identity

Uniquely identifies an object.

Example:

```text
Customer ID
Employee ID
Vehicle Number
```

---

### State

Represents the current data.

```text
Customer

Name
Email
Age
Balance
```

---

### Behavior

Represents actions.

```text
deposit()

withdraw()

login()

logout()
```

---

# 5. Business Example

## Banking System

Real World

```text
Customer

Account

Transaction

Loan

ATM
```

Software

```text
Customer

Account

SavingsAccount

CurrentAccount

Transaction

Loan

ATM
```

Each business entity becomes an object.

---

# 6. E-Commerce Example

```text
Customer

↓

Cart

↓

Order

↓

Payment

↓

Invoice

↓

Delivery
```

Software classes:

```java
Customer
Cart
Order
Payment
Invoice
Delivery
```

Each class is responsible for its own data and behavior.

---

# 7. Why This Matters

Imagine an online shopping application.

Instead of writing:

```java
createOrder();

addProduct();

calculatePrice();

generateInvoice();
```

OOP organizes responsibilities.

```text
Order
 ├── addProduct()
 ├── removeProduct()
 ├── calculateTotal()

Invoice
 └── generate()

Payment
 └── process()
```

This makes software easier to understand and maintain.

---

# 8. Object Collaboration

Objects rarely work alone.

Example:

```text
Customer
     │
     ▼
Order
     │
     ▼
Payment
     │
     ▼
Invoice
```

Objects communicate by calling each other's methods.

---

# 9. Benefits of Real World Modeling

- Easier to understand
- Better maintainability
- Reusable components
- Natural mapping of business requirements
- Simplifies large enterprise systems

---

# 10. Best Practices

- Model real business entities.
- Give each class a single responsibility.
- Avoid creating "God Classes" that do everything.
- Keep data and behavior together.

---

# Interview Questions

1. What is real world modeling?
2. Why is OOP called a real-world programming paradigm?
3. What are state, behavior and identity?
4. How do objects collaborate?
5. Explain real world modeling using a banking or e-commerce example.

---

# Summary

Real World Modeling is the foundation of Object-Oriented Programming. It helps developers transform business entities into software objects by combining **state**, **behavior**, and **identity**. This approach makes enterprise applications easier to design, understand, extend, and maintain.
