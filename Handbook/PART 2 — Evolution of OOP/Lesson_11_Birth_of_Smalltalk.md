# Lesson 11 — Birth of Smalltalk

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Object-Oriented Programming (OOP) did not begin with Java or C++. The first language to fully embrace OOP principles was **Smalltalk**, developed in the 1970s at **Xerox PARC**.

Smalltalk introduced the revolutionary idea that **everything is an object**, fundamentally changing the way software was designed.

---

# 2. The World Before Smalltalk

Before Smalltalk, most software was written using procedural programming.

```text
Program
 │
 ├── Function A
 ├── Function B
 └── Function C
```

As applications grew, managing shared data and thousands of functions became difficult.

---

# 3. Xerox PARC

Xerox Palo Alto Research Center (PARC) became one of the most influential research labs in computing.

Innovations from PARC include:

- Graphical User Interface (GUI)
- Computer Mouse
- Ethernet
- Laser Printing
- Smalltalk

---

# 4. Alan Kay's Vision

Computer scientist **Alan Kay** envisioned software built from independent objects communicating through messages, much like people collaborating to solve problems.

Core ideas:

- Everything is an object
- Objects communicate by sending messages
- Each object manages its own data
- Objects can be reused and extended

---

# 5. What Made Smalltalk Different?

Instead of writing functions that manipulate data:

```text
deposit(account)
withdraw(account)
```

Smalltalk encouraged sending messages to objects:

```text
account deposit: 500
account withdraw: 200
```

The object decides how to respond.

---

# 6. Everything is an Object

In Smalltalk:

- Numbers are objects
- Strings are objects
- Windows are objects
- Classes are objects

Example:

```text
5 factorial
```

Even the number `5` is treated as an object receiving the `factorial` message.

---

# 7. Message Passing

Objects communicate using messages.

```text
Customer
    │
    │ placeOrder()
    ▼
Order
    │
    │ processPayment()
    ▼
Payment
```

This concept strongly influenced modern OOP languages.

---

# 8. Impact on Modern Languages

Smalltalk inspired:

- C++
- Objective-C
- Java
- Ruby
- Python
- C#

Although these languages differ in syntax, they adopted many Smalltalk ideas.

---

# 9. Smalltalk vs Java

| Feature | Smalltalk | Java |
|---------|-----------|------|
| Everything is an object | Yes | Almost |
| Static typing | No | Yes |
| Compilation | Dynamic | Bytecode + JVM |
| Message passing | Core concept | Method calls |

---

# 10. Why Smalltalk Was Revolutionary

Smalltalk introduced:

- Classes
- Objects
- Inheritance
- Polymorphism
- Encapsulation
- Dynamic message passing

These concepts became the foundation of modern OOP.

---

# 11. Limitations

Smalltalk was elegant but:

- Slower than compiled languages
- Smaller ecosystem
- Limited commercial adoption

Its ideas, however, influenced nearly every modern OOP language.

---

# 12. Legacy

Today, enterprise developers rarely write Smalltalk, but they use its concepts every day through Java, C++, C#, Kotlin, and many other languages.

---

# Interview Questions

1. Who invented Smalltalk?
2. Why is Smalltalk important in OOP history?
3. What does "everything is an object" mean?
4. What is message passing?
5. How did Smalltalk influence Java?

---

# Summary

Smalltalk was the first language to fully embrace object-oriented programming. It introduced the concepts of objects, classes, inheritance, encapsulation, polymorphism, and message passing. Although it is not widely used today, its ideas form the foundation of modern object-oriented software development.
