# Lesson 10 — From Structured to Object-Oriented Programming

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Structured Programming was a major breakthrough in software development. It introduced functions, loops, conditional statements, and modular programming, making programs far easier to write than assembly language.

However, as software systems grew larger and businesses demanded more complex applications, structured programming began to show its limitations. This led to the development of **Object-Oriented Programming (OOP)**.

---

# 2. What is Structured Programming?

Structured Programming organizes a program into **functions (procedures)**.

```text
               Program
                   │
      ┌────────────┼────────────┐
      ▼            ▼            ▼
   Input()     Process()     Output()
```

The primary focus is on **functions** that manipulate data.

Example:

```java
calculateSalary();
generateInvoice();
depositMoney();
withdrawMoney();
```

---

# 3. Characteristics of Structured Programming

- Top-down approach
- Function-oriented design
- Sequential execution
- Shared/global data
- Modular through functions

---

# 4. Advantages

- Easy to understand
- Good for small applications
- Less memory overhead
- Fast execution
- Simpler debugging

Ideal for:

- Utility programs
- Mathematical calculations
- Small automation scripts

---

# 5. Problems with Structured Programming

As applications became larger:

- Thousands of functions
- Global variables
- Duplicate logic
- Tight coupling
- Difficult maintenance

Example:

```text
deposit()

withdraw()

calculateInterest()

transfer()

checkBalance()

printStatement()

closeAccount()

...
```

Finding related functionality became increasingly difficult.

---

# 6. The Need for a New Approach

Businesses wanted software that could model:

- Customers
- Employees
- Products
- Orders
- Payments
- Vehicles

Instead of asking:

> "Which function should perform this task?"

Developers began asking:

> "Which object owns this responsibility?"

---

# 7. Object-Oriented Thinking

Instead of organizing software around functions...

```text
Functions

deposit()

withdraw()

transfer()
```

...OOP organizes software around objects.

```text
BankAccount

├── balance
├── deposit()
├── withdraw()
└── transfer()
```

Data and behavior are kept together.

---

# 8. Comparison

| Structured Programming | Object-Oriented Programming |
|------------------------|-----------------------------|
| Function-oriented | Object-oriented |
| Data is separate | Data + Behavior together |
| Top-down approach | Bottom-up modeling |
| Limited reuse | High reusability |
| Difficult maintenance | Easier maintenance |
| Less scalable | Highly scalable |

---

# 9. Business Example

## Payroll System

### Structured Approach

```text
calculateSalary()
calculateBonus()
calculateTax()
printPayslip()
```

Shared employee data is accessed by many functions.

### OOP Approach

```text
Employee

├── calculateSalary()
├── calculateBonus()
├── calculateTax()
└── printPayslip()
```

Employee data and behavior stay together.

---

# 10. Enterprise Perspective

Large systems contain:

```text
Customer
Order
Payment
Invoice
Inventory
Employee
Supplier
```

Representing each as an object makes software easier to extend and maintain.

---

# 11. Why OOP Replaced Structured Programming

OOP introduced:

- Encapsulation
- Abstraction
- Inheritance
- Polymorphism
- Better modularity
- Better collaboration among development teams

These features solved many of the challenges faced in enterprise software development.

---

# 12. Is Structured Programming Obsolete?

No.

Structured programming is still useful for:

- Competitive programming
- Algorithms
- Embedded systems
- Small utilities
- Scripts

Modern languages like Java combine both structured programming and OOP.

---

# 13. Interview Questions

1. What is structured programming?
2. How is structured programming different from OOP?
3. Why did industries move from structured programming to OOP?
4. Can Java be written in a procedural style?
5. Is OOP always the best choice?

---

# Summary

Structured Programming introduced discipline into software development by organizing code into functions. However, as software systems became larger and more complex, maintaining function-oriented code became difficult. Object-Oriented Programming evolved to solve these problems by organizing software around objects that combine data and behavior, making enterprise applications more modular, reusable, and maintainable.
