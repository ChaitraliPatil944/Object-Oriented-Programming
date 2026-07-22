# Lesson 16 — Objects and Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Everything in Object-Oriented Programming revolves around **classes** and **objects**.

A **class** defines what an object should look like, while an **object** is a real instance created from that class.

Think of a class as a **blueprint** and an object as the **actual building** constructed from it.

---

# 2. Why Do We Need Classes?

Imagine developing software for a bank.

There are thousands of customers.

Instead of writing separate code for every customer, we create one class.

```text
Customer Class
      │
      ├── Customer 1
      ├── Customer 2
      ├── Customer 3
      └── Customer n
```

One blueprint creates many objects.

---

# 3. What is a Class?

A class is a user-defined data type that groups:

- Data (Fields)
- Behavior (Methods)

Example:

```java
class Employee {

    int id;
    String name;
    double salary;

    void work() {
        System.out.println(name + " is working.");
    }
}
```

---

# 4. What is an Object?

An object is a runtime instance of a class.

```java
Employee emp1 = new Employee();
Employee emp2 = new Employee();
```

Each object has its own data.

---

# 5. Blueprint Analogy

```text
          Blueprint
             │
             ▼
      +--------------+
      |   Employee   |
      +--------------+
             │
     ┌───────┼────────┐
     ▼       ▼        ▼
   emp1    emp2     emp3
```

---

# 6. Class Structure

```text
+----------------------+
| Employee             |
+----------------------+
| id                   |
| name                 |
| salary               |
+----------------------+
| work()               |
| displayDetails()     |
+----------------------+
```

---

# 7. Creating Objects

```java
Employee emp = new Employee();

emp.id = 101;
emp.name = "Alice";
emp.salary = 65000;

emp.work();
```

---

# 8. Memory Representation

```text
Stack Memory

emp
 │
 ▼

Heap Memory

+-----------------------+
| Employee Object       |
|-----------------------|
| id = 101              |
| name = Alice          |
| salary = 65000        |
+-----------------------+
```

The variable `emp` stores a **reference**, not the object itself.

---

# 9. Multiple Objects

```java
Employee emp1 = new Employee();
Employee emp2 = new Employee();
Employee emp3 = new Employee();
```

Memory

```text
Stack

emp1 ─────► Employee Object #1

emp2 ─────► Employee Object #2

emp3 ─────► Employee Object #3
```

Every object has its own independent state.

---

# 10. Real Business Example

E-Commerce

```text
Product Class

↓

Product 1

Product 2

Product 3

Product 4
```

Each product has different values but follows the same blueprint.

---

# 11. Benefits of Classes

- Code reuse
- Easy maintenance
- Better organization
- Real-world modeling
- Scalability

---

# 12. Common Mistakes

❌ Confusing class with object.

❌ Assuming objects share data automatically.

❌ Creating one huge class that handles everything (God Class).

---

# 13. Best Practices

- One class should represent one business entity.
- Keep data and related behavior together.
- Follow meaningful naming conventions.
- Design classes around responsibilities.

---

# 14. Interview Questions

1. What is a class?
2. What is an object?
3. Can we create multiple objects from one class?
4. Where are objects stored in memory?
5. Does a reference variable contain the object?

---

# 15. Summary

A class is a blueprint that defines the properties and behavior of an entity, while an object is a real instance created from that blueprint. Enterprise applications use thousands or even millions of objects created from a relatively small number of well-designed classes, making software modular, reusable, and easy to maintain.
