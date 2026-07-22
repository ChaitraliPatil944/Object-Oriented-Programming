# Lesson 116 — Synchronization

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Synchronization** is the mechanism that controls access to shared resources when multiple threads execute concurrently.

Without synchronization, two or more threads may modify the same data simultaneously, leading to **race conditions**, inconsistent results, and data corruption.

Java provides the `synchronized` keyword and other concurrency utilities to ensure thread-safe access.

---

# 2. Why Synchronization is Needed?

Consider a shared bank account.

```text
Balance = 1000

Thread A withdraws 500
Thread B withdraws 500
```

If both threads read the balance at the same time, the final balance may become incorrect because updates overlap.

---

# 3. Race Condition

A **race condition** occurs when the program's outcome depends on the order in which threads execute.

Example:

```java
class Counter {

    int count = 0;

    void increment() {
        count++;
    }
}
```

If multiple threads call `increment()`, the final value may be incorrect.

---

# 4. The `synchronized` Keyword

A synchronized method allows only one thread at a time to execute it for a given object.

```java
class Counter {

    private int count = 0;

    public synchronized void increment() {
        count++;
    }
}
```

---

# 5. Synchronized Block

Instead of locking an entire method, only the critical section can be synchronized.

```java
class Counter {

    private int count = 0;

    void increment() {
        synchronized (this) {
            count++;
        }
    }
}
```

This improves performance by reducing the locked region.

---

# 6. Object-Level vs Class-Level Lock

### Object-Level Lock

```java
public synchronized void display() {
}
```

Each object has its own lock.

### Class-Level Lock

```java
public static synchronized void show() {
}
```

Locks the `Class` object, affecting all instances.

---

# 7. How Synchronization Works

```text
Thread A
   │
   ▼
Lock Acquired
   │
Critical Section
   │
Lock Released
   │
Thread B Enters
```

Only one thread can own the lock at a time.

---

# 8. Advantages

- Prevents race conditions
- Maintains data consistency
- Protects shared resources
- Ensures mutual exclusion
- Simplifies thread-safe programming

---

# 9. Disadvantages

- Performance overhead
- Reduced parallelism
- Risk of deadlocks
- Increased waiting time
- More complex debugging

---

# 10. Best Practices

- Synchronize only critical sections.
- Keep synchronized blocks small.
- Avoid unnecessary locking.
- Prefer higher-level concurrency utilities when appropriate.
- Be consistent when locking shared resources.

---

# 11. Common Mistakes

❌ Synchronizing the entire application unnecessarily.

❌ Forgetting to synchronize shared mutable data.

❌ Holding locks for a long time.

❌ Acquiring locks in inconsistent order, increasing deadlock risk.

---

# 12. Interview Questions

1. What is synchronization?
2. Why is synchronization required?
3. Difference between synchronized method and synchronized block?
4. What is a race condition?
5. Difference between object-level and class-level synchronization?

---

# 13. Quick Revision

```text
Synchronization
│
├── synchronized Method
├── synchronized Block
├── Object Lock
├── Class Lock
└── Prevents Race Conditions
```

---

# 14. Interview Cheat Sheet

```text
Synchronization

✔ Protects Shared Data
✔ One Thread at a Time
✔ synchronized Keyword

Locks

Object Lock
Class Lock

Problems Prevented

Race Condition
Data Corruption
```

---

# 15. Summary

Synchronization is Java's mechanism for ensuring that shared resources are accessed safely by multiple threads. Using the `synchronized` keyword on methods or blocks guarantees mutual exclusion, preventing race conditions and maintaining data consistency. Effective synchronization requires locking only critical sections to balance thread safety with application performance.
