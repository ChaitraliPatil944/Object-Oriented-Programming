# Lesson 170 — Scenario Based Questions

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Many interviewers test OOP knowledge through **real-world scenarios** instead of direct definitions. These questions evaluate your ability to apply concepts such as encapsulation, inheritance, polymorphism, SOLID principles, and design patterns to practical problems.

---

# 2. Scenario 1: Payment System

**Question:** Design a payment module that supports Credit Card, UPI, and Wallet payments.

**Expected Approach**

- Create a `Payment` interface.
- Implement `CreditCardPayment`, `UPIPayment`, and `WalletPayment`.
- Use polymorphism to invoke `pay()`.

**Concepts Tested**

- Interface
- Runtime polymorphism
- Open/Closed Principle
- Strategy Pattern

---

# 3. Scenario 2: Library Management

**Question:** Design a library system.

**Possible Classes**

```text
Library
Book
Member
Librarian
Loan
```

**Concepts Tested**

- Association
- Aggregation
- Encapsulation

---

# 4. Scenario 3: Banking Application

**Question:** How would you implement fund transfer?

**Expected Flow**

```text
Controller
    │
Service
    │
Repository
    │
Database
```

Business rules belong in the service layer.

**Concepts Tested**

- Layered architecture
- Transactions
- DTOs
- Repository Pattern

---

# 5. Scenario 4: Shopping Cart

**Question:** Design an e-commerce shopping cart.

**Possible Classes**

```text
Customer
Cart
CartItem
Product
Order
```

**Concepts Tested**

- Composition
- Collections
- Encapsulation

---

# 6. Scenario 5: Notification Service

Support Email, SMS, and Push notifications.

```text
Notification
      │
 ├── Email
 ├── SMS
 └── Push
```

Use an interface with different implementations.

**Concepts Tested**

- Interface
- Dependency Injection
- Strategy Pattern

---

# 7. Scenario 6: Employee Hierarchy

```text
Employee
   │
 ├── Manager
 ├── Developer
 └── Tester
```

Each class overrides:

```java
calculateSalary()
```

**Concepts Tested**

- Inheritance
- Method overriding
- Dynamic dispatch

---

# 8. Scenario 7: Logging Framework

Support:

- File logging
- Database logging
- Cloud logging

Use a `Logger` interface and inject implementations.

**Concepts Tested**

- Dependency Injection
- Interface-based design
- Open/Closed Principle

---

# 9. Scenario 8: Ride Booking App

Possible classes:

```text
User
Driver
Vehicle
Trip
Payment
Location
```

Concepts:

- Association
- Composition
- Encapsulation
- DTOs

---

# 10. Scenario 9: Online Exam System

Possible entities:

```text
Student
Question
Exam
Answer
Result
```

Business logic:

- Calculate score
- Generate result
- Store responses

---

# 11. Scenario 10: Hospital Management

Classes:

```text
Doctor
Patient
Appointment
Prescription
Billing
```

Concepts:

- Layered architecture
- Repository
- Service layer
- Entity relationships

---

# 12. Common Follow-up Questions

- Why did you choose inheritance instead of composition?
- Which SOLID principles apply?
- Where would validation be implemented?
- Which design pattern fits best?
- How would you make it extensible?

---

# 13. Interview Tips

- Identify entities first.
- Define relationships.
- Separate responsibilities.
- Explain trade-offs.
- Draw simple UML diagrams when possible.

Because interviewers often care more about your reasoning than whether every class name is perfect. Humans do enjoy watching each other think under fluorescent lighting.

---

# 14. Quick Revision

```text
Scenarios

✔ Banking
✔ E-Commerce
✔ Library
✔ Hospital
✔ Payment
✔ Notifications
✔ Ride Booking
✔ Employee
✔ Logging
✔ Online Exam
```

---

# 15. Summary

Scenario-based OOP questions assess your ability to design maintainable software rather than simply recall definitions. Focus on identifying entities, assigning clear responsibilities, applying SOLID principles, using appropriate design patterns, and explaining the reasoning behind your design decisions.
