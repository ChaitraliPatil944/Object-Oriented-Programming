# Lesson 3 — Procedural Programming and Its Limitations

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Before Object-Oriented Programming (OOP), most software was written using the **procedural programming paradigm**. In procedural programming, the primary focus is on **functions (procedures)** that operate on data.

For small programs this approach works well. As software grows, however, maintaining and extending procedural code becomes increasingly difficult.

---

# 2. What is Procedural Programming?

Procedural programming organizes a program into a sequence of procedures or functions.

```text
Input
  ↓
Function 1
  ↓
Function 2
  ↓
Function 3
  ↓
Output
```

The program is built around **functions**, while data is often shared globally.

---

# 3. Characteristics

- Top-down design
- Function-oriented
- Sequential execution
- Shared/global data
- Code reuse through functions

---

# 4. Java Example

```java
public class Bank {

    static double balance = 10000;

    static void deposit(double amount) {
        balance += amount;
    }

    static void withdraw(double amount) {
        balance -= amount;
    }

    public static void main(String[] args) {
        deposit(500);
        withdraw(200);
        System.out.println(balance);
    }
}
```

---

# 5. Advantages

- Easy to learn
- Fast for small applications
- Less memory overhead
- Simple execution flow

Suitable for:
- Calculator
- File conversion
- Mathematical programs
- Utility scripts

---

# 6. Limitations

## 6.1 Global Data

```text
Function A
      ↓
Global Variable
      ↑
Function B
```

Any function can modify shared data, making bugs difficult to trace.

---

## 6.2 Poor Scalability

Imagine an e-commerce application with:

- Customers
- Products
- Orders
- Payments
- Delivery

Managing everything with only functions becomes messy.

---

## 6.3 Code Duplication

Similar logic is often repeated across multiple functions, increasing maintenance effort.

---

## 6.4 Difficult Maintenance

Changing one function may unintentionally affect many others because of shared data and tight coupling.

---

# 7. Real-World Comparison

### Procedural Thinking

```text
CreateCustomer()
DeleteCustomer()
UpdateCustomer()
CreateOrder()
CancelOrder()
```

### Object-Oriented Thinking

```text
Customer
 ├── create()
 ├── update()
 └── delete()

Order
 ├── create()
 ├── cancel()
 └── ship()
```

OOP groups data and behavior together.

---

# 8. Why Industry Moved to OOP

Large enterprise systems need:

- Maintainability
- Reusability
- Security
- Team collaboration
- Scalability

Procedural programming struggles with these requirements as projects grow.

---

# 9. When Procedural Programming is Still Useful

Procedural programming is still a good choice for:

- Small utilities
- Embedded scripts
- Data processing
- Automation scripts
- Competitive programming

Not every problem needs OOP.

---

# 10. Procedural vs Object-Oriented

| Feature | Procedural | OOP |
|----------|------------|-----|
| Focus | Functions | Objects |
| Data | Shared | Encapsulated |
| Reusability | Limited | High |
| Scalability | Moderate | Excellent |
| Enterprise Applications | Difficult | Preferred |

---

# Interview Questions

1. What is procedural programming?
2. What are its advantages?
3. What are its limitations?
4. Why did procedural programming lead to the development of OOP?
5. Can Java be used procedurally?

---

# Summary

Procedural programming organizes software around functions and works well for small applications. However, as software grows in size and complexity, issues such as global data, code duplication, poor maintainability, and limited scalability become significant. These challenges led to the evolution of Object-Oriented Programming, which models software around objects that combine data and behavior.
