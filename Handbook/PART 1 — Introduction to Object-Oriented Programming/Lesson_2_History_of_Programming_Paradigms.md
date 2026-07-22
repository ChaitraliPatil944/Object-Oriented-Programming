# Lesson 2 — History of Programming Paradigms

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Programming paradigms are different ways of thinking about solving problems using software.
Each new paradigm emerged to solve limitations of the previous one.

---

# 2. What is a Programming Paradigm?

A programming paradigm is a style or philosophy of programming.

Examples:
- Procedural Programming
- Object-Oriented Programming
- Functional Programming
- Logic Programming
- Event-Driven Programming

---

# 3. Evolution Timeline

```text
Machine Language
      ↓
Assembly Language
      ↓
Procedural Programming
      ↓
Object-Oriented Programming
      ↓
Component-Based Development
      ↓
Cloud Native & Microservices
```

---

# 4. Machine Language

- First generation language
- Binary instructions (0 and 1)
- Hardware dependent
- Extremely difficult to write and debug

Example:

```text
10110010 01101001
```

---

# 5. Assembly Language

Introduced mnemonics like:

```asm
MOV AX, 10
ADD AX, 20
```

Advantages:
- Easier than binary

Limitations:
- Hardware dependent
- Complex for large software

---

# 6. Procedural Programming

Programs were divided into functions.

Example:

```java
deposit();
withdraw();
calculateInterest();
```

Advantages:
- Simpler than assembly
- Good for small applications

Problems:
- Global data
- Code duplication
- Difficult maintenance
- Poor scalability

---

# 7. Birth of Object-Oriented Programming

Researchers observed that software should model real-world entities.

Instead of only functions:

```text
Deposit()
Withdraw()
```

They created objects:

```text
BankAccount
 ├── balance
 ├── deposit()
 └── withdraw()
```

---

# 8. Why OOP Became Popular

- Better code organization
- Reusability
- Easier maintenance
- Team collaboration
- Enterprise scalability

---

# 9. Modern Programming

Today many languages support multiple paradigms.

Examples:
- Java
- C++
- Python
- Kotlin
- C#

---

# 10. Business Perspective

Large systems like banking, e-commerce and telecom require software that can evolve for years.

OOP helps organize code into reusable business entities such as Customer, Order, Product, Employee and Payment.

---

# Interview Questions

1. What is a programming paradigm?
2. Why did programming paradigms evolve?
3. Compare machine language, assembly, procedural and OOP.
4. Can Java support paradigms other than OOP?
5. Why isn't procedural programming sufficient for enterprise software?

---

# Summary

Every programming paradigm was created to solve the shortcomings of its predecessor. OOP became dominant because it models real-world systems naturally while improving maintainability, scalability and reusability.
