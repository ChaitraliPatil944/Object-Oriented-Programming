# Lesson 117 — Thread Safety

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Thread safety** is the property of a program or class that guarantees correct behavior when multiple threads access it simultaneously.

A thread-safe class prevents data corruption, race conditions, and inconsistent results by properly coordinating access to shared resources.

---

# 2. Why Thread Safety Matters

Suppose multiple threads update the same bank account balance.

Without thread safety:

```text
Balance = 1000

Thread A: Withdraw 300
Thread B: Withdraw 500

Expected Balance = 200
Actual Balance = Undefined (Race Condition)
```

Proper synchronization ensures the correct result.

---

# 3. Thread-Safe vs Non-Thread-Safe

| Thread-Safe | Non-Thread-Safe |
|-------------|-----------------|
| Safe for concurrent access | Unsafe for concurrent access |
| Predictable behavior | May produce inconsistent results |
| Uses synchronization or immutability | Shared mutable state without protection |

---

# 4. Achieving Thread Safety

Common techniques include:

- `synchronized` methods/blocks
- Locks (`ReentrantLock`)
- Atomic classes
- Immutable objects
- Thread-local storage
- Concurrent collections

---

# 5. Example: Non-Thread-Safe Counter

```java
class Counter {

    private int count = 0;

    void increment() {
        count++;
    }
}
```

Multiple threads may lose updates because `count++` is not atomic.

---

# 6. Example: Thread-Safe Counter

```java
class Counter {

    private int count = 0;

    public synchronized void increment() {
        count++;
    }

    public synchronized int getCount() {
        return count;
    }
}
```

Only one thread can execute the synchronized methods at a time.

---

# 7. Immutable Objects

Immutable objects are naturally thread-safe because their state cannot change after creation.

Example:

```java
String name = "Alice";
```

Since `String` is immutable, it can be safely shared across threads.

---

# 8. Thread Confinement

Instead of sharing objects, each thread maintains its own copy.

```text
Thread A → Local Object

Thread B → Local Object

No Shared Data
```

This eliminates synchronization needs.

---

# 9. Best Practices

- Minimize shared mutable state.
- Prefer immutable objects whenever possible.
- Synchronize only critical sections.
- Use concurrent collections instead of ordinary collections when sharing data.
- Favor high-level concurrency utilities over manual locking.

---

# 10. Common Mistakes

❌ Assuming `count++` is atomic.

❌ Sharing mutable objects without synchronization.

❌ Locking too much, reducing performance.

❌ Forgetting visibility issues between threads.

---

# 11. Advantages

- Reliable concurrent execution
- Data consistency
- Predictable application behavior
- Reduced race conditions
- Better scalability

---

# 12. Interview Questions

1. What is thread safety?
2. How can thread safety be achieved in Java?
3. Why are immutable objects thread-safe?
4. What is thread confinement?
5. Difference between synchronization and immutability?

---

# 13. Quick Revision

```text
Thread Safety
│
├── Synchronization
├── Atomic Classes
├── Immutable Objects
├── Thread Confinement
└── Concurrent Collections
```

---

# 14. Interview Cheat Sheet

```text
Thread Safety

✔ Safe Concurrent Access
✔ Prevents Race Conditions
✔ Maintains Data Consistency

Techniques

synchronized
Locks
Atomic Classes
Immutable Objects
Concurrent Collections
```

---

# 15. Summary

Thread safety ensures that shared data remains consistent and correct when accessed by multiple threads simultaneously. Java provides several approaches to achieve thread safety, including synchronization, immutable objects, atomic classes, thread confinement, and concurrent collections. Choosing the appropriate technique depends on the application's performance and concurrency requirements.
