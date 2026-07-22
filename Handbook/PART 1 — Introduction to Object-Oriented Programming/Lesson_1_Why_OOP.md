# Lesson 1 — Why OOP?

> **Object-Oriented Programming (OOP) Handbook**
>
> This is Lesson 1 of the handbook.

---

# 1. Introduction

Object-Oriented Programming (OOP) is a programming paradigm that models software around **objects**, just as we model the real world around people, vehicles, bank accounts, employees, customers, products, and orders.

OOP was introduced to solve problems that became difficult to manage using procedural programming as software systems grew larger and more complex.

---

# 2. Why Was OOP Invented?

As software projects became larger, developers struggled with:

- Duplicate code
- Poor maintainability
- Difficult debugging
- Tight coupling
- Low reusability

OOP introduced a better way to organize software by grouping **data** and **behavior** together.

---

# 3. A Simple Example

Instead of writing many unrelated functions:

```java
deposit();
withdraw();
checkBalance();
```

OOP groups them inside an object.

```java
class BankAccount {

    private double balance;

    public void deposit(double amount){
        balance += amount;
    }

    public void withdraw(double amount){
        balance -= amount;
    }

    public double getBalance(){
        return balance;
    }
}
```

---

# 4. Real World Analogy

A **Car** has:

State
- Brand
- Speed
- Fuel

Behavior
- Start
- Stop
- Accelerate

Software models this naturally as a class.

---

# 5. Why Businesses Love OOP

Enterprise applications such as:

- Banking Systems
- E-Commerce
- Hospital Management
- HRMS
- Telecom Systems

all deal with real-world entities that map naturally to objects.

---

# 6. Key Benefits

- Better maintainability
- Code reuse
- Scalability
- Easier testing
- Better team collaboration

---

# 7. Interview Questions

1. Why was OOP introduced?
2. What problems does OOP solve?
3. Why do enterprises prefer OOP?
4. Is Java 100% object-oriented?
5. When should OOP not be used?

---

# Summary

OOP is not just about the four pillars. It is a way of designing software that mirrors the real world, making applications easier to understand, maintain, extend, and scale.
