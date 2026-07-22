# Lesson 30 — Garbage Collection

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of Java's biggest advantages over languages like C and C++ is **automatic memory management**.

In C++, developers manually allocate and free memory.

```cpp
delete object;
```

Forgetting to release memory can cause memory leaks, while deleting memory incorrectly can crash a program.

Java solves this problem through the **Garbage Collector (GC)**.

The Garbage Collector automatically identifies unused objects and reclaims their memory, allowing developers to focus on application logic instead of manual memory management.

---

# 2. What is Garbage Collection?

**Garbage Collection (GC)** is the JVM process of automatically removing objects that are no longer reachable by a running program.

Garbage collection helps:

- Prevent memory leaks
- Reclaim heap memory
- Improve application stability
- Reduce programmer errors

---

# 3. When Does an Object Become Garbage?

An object becomes **eligible for garbage collection** when it is **no longer reachable**.

Example:

```java
Employee emp = new Employee();

emp = null;
```

Memory:

```text
Stack

emp = null

Heap

+----------------------+
| Employee Object      |
+----------------------+

(No references)
```

The object still exists temporarily but is now eligible for collection.

---

# 4. Reachable vs Unreachable Objects

```text
Reachable

Reference
    │
    ▼
 Employee Object

-------------------------

Unreachable

(No Reference)

Employee Object
```

Only unreachable objects are candidates for garbage collection.

---

# 5. Does `null` Destroy an Object?

No.

```java
emp = null;
```

This only removes the reference.

The JVM decides **when** to reclaim the object's memory.

---

# 6. Requesting Garbage Collection

Java provides:

```java
System.gc();
```

or

```java
Runtime.getRuntime().gc();
```

These methods **request** garbage collection.

The JVM is free to ignore the request.

---

# 7. Garbage Collection Process

Conceptually:

```text
Heap

Objects
   │
   ▼
Reachability Analysis
   │
   ▼
Unreachable Objects
   │
   ▼
Garbage Collector
   │
   ▼
Memory Reclaimed
```

The JVM periodically performs this process during program execution.

---

# 8. Generational Garbage Collection

Modern JVMs divide the heap into generations because most objects have short lifetimes.

```text
Heap

+----------------------+
| Young Generation     |
|----------------------|
| Eden                 |
| Survivor 0           |
| Survivor 1           |
+----------------------+

+----------------------+
| Old Generation       |
+----------------------+
```

General idea:

- New objects are created in the **Young Generation**.
- Objects that survive multiple collections are promoted to the **Old Generation**.
- Long-lived objects remain in the Old Generation until they become unreachable.

This strategy improves performance because the JVM spends more time collecting short-lived objects.

---

# 9. Example

```java
public class Main {

    public static void main(String[] args) {

        Employee emp = new Employee();

        emp = null;

        System.gc();
    }
}
```

The object becomes eligible for garbage collection after `emp` is set to `null`.

Whether it is collected immediately depends on the JVM.

---

# 10. finalize() Method

Older versions of Java allowed cleanup using:

```java
protected void finalize() {

}
```

However:

- `finalize()` is deprecated.
- It is unreliable.
- It should not be used for resource management.

Instead, use:

- try-with-resources
- AutoCloseable
- Explicit cleanup methods

---

# 11. Enterprise Example

An e-commerce application may create:

- Customer objects
- Cart objects
- Product objects
- Order objects
- Payment objects

When a shopping session ends:

```text
Customer Session Ends
        │
        ▼
Cart Object Unreachable
        │
        ▼
Garbage Collector
        │
        ▼
Memory Reclaimed
```

Millions of temporary objects may be created and collected every day in enterprise systems.

---

# 12. Common Misconceptions

❌ `System.gc()` guarantees garbage collection.

❌ Setting a reference to `null` immediately frees memory.

❌ Garbage collection removes all objects periodically.

Correct understanding:

- GC is controlled by the JVM.
- Only unreachable objects are eligible.
- Collection timing is nondeterministic.

---

# 13. Best Practices

- Do not rely on `System.gc()`.
- Remove unnecessary object references.
- Prefer local variables over long-lived globals when appropriate.
- Use try-with-resources for files, sockets, and database connections.
- Design objects with reasonable lifetimes.

---

# 14. Interview Questions

1. What is Garbage Collection?
2. When does an object become eligible for GC?
3. Does `obj = null` destroy an object?
4. What does `System.gc()` do?
5. Why was `finalize()` deprecated?
6. What is the Young Generation and Old Generation?

---

# 15. Summary

Garbage Collection is the JVM's automatic memory management mechanism. It identifies unreachable objects, reclaims their heap memory, and helps prevent common memory-related programming errors. Modern JVMs optimize this process using generational garbage collection, allowing Java applications to manage large numbers of objects efficiently while reducing the burden of manual memory management.
