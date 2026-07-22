# Lesson 17 — Anatomy of an Object

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

When programmers create an object, they often think only about its variables and methods. However, an object inside the Java Virtual Machine (JVM) contains much more than just data.

Every object occupies memory and consists of several internal parts managed by the JVM.

Understanding an object's anatomy is essential for writing efficient Java programs and for answering advanced interview questions.

---

# 2. What is an Object?

An object is a **runtime instance** of a class that contains:

- State (data)
- Behavior (methods)
- Identity (unique existence in memory)

Example:

```java
class Student {
    int rollNo;
    String name;

    void study() {
        System.out.println(name + " is studying.");
    }
}
```

Creating an object:

```java
Student s1 = new Student();
```

---

# 3. Internal Structure of an Object

Conceptually, a Java object looks like this:

```text
+--------------------------------------+
| Object Header                        |
|--------------------------------------|
| Class Metadata Pointer               |
| Synchronization Information          |
| Hash Code (when needed)              |
+--------------------------------------+
| Instance Variables                   |
| rollNo                               |
| name                                 |
+--------------------------------------+
| Padding (if required)                |
+--------------------------------------+
```

The JVM automatically manages these internal details.

---

# 4. Object Header

Every Java object contains an **object header**.

The header stores information such as:

- Runtime type information
- Locking (used for synchronization)
- Identity hash code
- Garbage collection metadata

Programmers normally cannot access the header directly.

---

# 5. Instance Variables

These store the object's actual data.

Example:

```java
Student s = new Student();

s.rollNo = 101;
s.name = "Alice";
```

Memory:

```text
Student Object

rollNo = 101
name = Alice
```

Each object has its own copy of instance variables.

---

# 6. Methods Are Not Stored Per Object

Methods belong to the **class**, not to individual objects.

```java
Student s1 = new Student();
Student s2 = new Student();
```

Both objects share the same compiled method definitions.

```text
Student Class
    |
    +--> study()

Objects
  s1
  s2
```

This design saves memory.

---

# 7. Identity

Even if two objects contain identical data, they are different objects.

```java
Student s1 = new Student();
Student s2 = new Student();
```

```text
Heap

+-----------+      +-----------+
| Student A |      | Student B |
+-----------+      +-----------+
```

They have different memory identities.

---

# 8. State

The **state** of an object is determined by the values stored in its instance variables.

Example:

```java
Student s = new Student();

s.rollNo = 101;
s.name = "Alice";
```

State:

```text
rollNo = 101
name = Alice
```

Changing variables changes the object's state.

---

# 9. Behavior

Behavior is defined by methods.

```java
class Student {

    void study() {
        System.out.println("Studying...");
    }

    void sleep() {
        System.out.println("Sleeping...");
    }
}
```

Objects use these methods to perform actions.

---

# 10. Object Memory Diagram

```text
Stack

s
 |
 v

Heap

+---------------------------+
| Student Object            |
|---------------------------|
| Header                    |
| rollNo = 101              |
| name = Alice              |
+---------------------------+
```

The reference variable on the stack points to the object on the heap.

---

# 11. Multiple Objects

```java
Student s1 = new Student();
Student s2 = new Student();
```

```text
Stack

s1 ----------+
             |
             v
        +-----------+
        | Object #1 |
        +-----------+

s2 ----------+
             |
             v
        +-----------+
        | Object #2 |
        +-----------+
```

Each object maintains its own state independently.

---

# 12. Real-World Example

Banking System:

```text
Customer Class

↓

Customer Object #1
Balance = 5000

Customer Object #2
Balance = 12000

Customer Object #3
Balance = 3500
```

The class is shared, but each customer object stores different data.

---

# 13. Common Misconceptions

❌ Methods are copied into every object.

❌ Objects store executable code.

❌ Two objects with the same values are the same object.

In reality:

- Methods belong to the class.
- Objects mainly store data and runtime metadata.
- Each object has its own identity.

---

# 14. Interview Questions

1. What are the three characteristics of an object?
2. What is stored inside a Java object?
3. Are methods stored separately for every object?
4. What is an object header?
5. Why do two objects with identical values still have different identities?

---

# 15. Summary

A Java object is more than a collection of variables. Internally, it contains an object header, instance data, and runtime metadata managed by the JVM. Every object has its own **state**, **behavior**, and **identity**, while method definitions are shared through the class, making object-oriented programs both memory-efficient and scalable.
