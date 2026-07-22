# Lesson 20 — Object Lifecycle

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Every object in Java follows a lifecycle, from the moment it is created until the JVM eventually removes it from memory.

Understanding the object lifecycle helps developers write efficient programs, avoid memory leaks, and understand how the Java Virtual Machine (JVM) manages memory automatically.

---

# 2. Stages of an Object Lifecycle

```text
        Class Definition
               │
               ▼
       Object Creation (new)
               │
               ▼
     Object Initialization
               │
               ▼
        Object in Use
               │
               ▼
     Object Becomes Unreachable
               │
               ▼
      Garbage Collection
               │
               ▼
      Memory Reclaimed
```

---

# 3. Stage 1: Class Loading

Before an object can be created, the JVM loads the corresponding class into memory.

Example:

```java
class Employee {

}
```

The class definition is loaded once by the JVM.

---

# 4. Stage 2: Object Creation

An object is created using the `new` keyword.

```java
Employee emp = new Employee();
```

During this step:

- Memory is allocated on the heap.
- Default values are assigned.
- The constructor is invoked.
- A reference to the object is returned.

---

# 5. Stage 3: Object Initialization

The constructor initializes the object.

```java
class Employee {

    String name;

    Employee() {
        name = "Unknown";
    }
}
```

After initialization, the object is ready for use.

---

# 6. Stage 4: Object Usage

The application interacts with the object by calling its methods.

```java
emp.work();
emp.displayDetails();
```

During this phase, the object's state may change repeatedly.

---

# 7. Stage 5: Object Becomes Unreachable

An object becomes eligible for garbage collection when no active references point to it.

Example:

```java
Employee emp = new Employee();

emp = null;
```

The original object still exists on the heap but is no longer reachable through the program.

---

# 8. Stage 6: Garbage Collection

The JVM periodically checks for unreachable objects.

```text
Reachable Object
      │
      ▼
 Kept in Memory

Unreachable Object
      │
      ▼
 Garbage Collector Removes It
```

The exact time of garbage collection is determined by the JVM and cannot be predicted by the programmer.

---

# 9. Memory Representation

Before:

```text
Stack              Heap

emp ───────────► Employee Object
```

After:

```java
emp = null;
```

```text
Stack              Heap

emp = null         Employee Object
                   (Unreachable)
```

Eventually, the garbage collector reclaims the heap memory.

---

# 10. Example

```java
class Student {

    Student() {
        System.out.println("Object Created");
    }
}

public class Main {

    public static void main(String[] args) {

        Student s = new Student();

        s = null;
    }
}
```

The object is created, used briefly, then becomes eligible for garbage collection.

---

# 11. Object Lifecycle in Enterprise Applications

Consider an online shopping system.

1. Customer requests a product.
2. A `Cart` object is created.
3. Products are added.
4. Payment is completed.
5. Cart is discarded.
6. Garbage collector eventually removes the unused object.

Thousands of objects may be created and destroyed every second in enterprise systems.

---

# 12. Common Misconceptions

❌ Setting a reference to `null` immediately destroys the object.

❌ Programmers can force garbage collection at an exact time.

❌ Every unused object is removed instantly.

Correct understanding:

- `null` only removes the reference.
- Garbage collection is automatic.
- The JVM decides when memory is reclaimed.

---

# 13. Best Practices

- Remove unnecessary references.
- Avoid holding objects longer than required.
- Reuse expensive objects where appropriate.
- Trust the JVM's garbage collector instead of trying to manage memory manually.

---

# 14. Interview Questions

1. What are the stages of an object's lifecycle?
2. What happens when `new` is executed?
3. When does an object become eligible for garbage collection?
4. Does `obj = null` immediately destroy the object?
5. Who controls garbage collection in Java?

---

# 15. Summary

A Java object's lifecycle begins when the JVM loads its class and an instance is created with the `new` keyword. After initialization, the object is used by the application until it becomes unreachable. At that point, it becomes eligible for garbage collection, and the JVM eventually reclaims its memory automatically. This lifecycle enables Java to manage memory efficiently without requiring manual deallocation from developers.
