# Lesson 119 — Atomic Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Atomic classes** in Java provide thread-safe operations on single variables without using explicit synchronization.

They are part of the `java.util.concurrent.atomic` package and rely on efficient CPU-level **Compare-And-Swap (CAS)** operations instead of locks.

Atomic classes are ideal for counters, flags, and statistics shared between multiple threads.

---

# 2. Why Atomic Classes?

Using ordinary variables in multithreaded programs can cause race conditions.

Example:

```java
count++;
```

The increment operation is **not atomic** because it involves:
1. Read the value
2. Increment it
3. Write it back

Multiple threads can interfere during these steps.

---

# 3. Common Atomic Classes

| Class | Purpose |
|--------|---------|
| `AtomicInteger` | Thread-safe integer |
| `AtomicLong` | Thread-safe long |
| `AtomicBoolean` | Thread-safe boolean |
| `AtomicReference<T>` | Thread-safe object reference |
| `AtomicIntegerArray` | Thread-safe integer array |
| `AtomicLongArray` | Thread-safe long array |

---

# 4. AtomicInteger Example

```java
import java.util.concurrent.atomic.AtomicInteger;

AtomicInteger counter = new AtomicInteger(0);

counter.incrementAndGet();

System.out.println(counter.get());
```

Output:

```text
1
```

---

# 5. Common Methods

```java
AtomicInteger count = new AtomicInteger(10);

count.get();

count.set(20);

count.incrementAndGet();

count.decrementAndGet();

count.addAndGet(5);

count.compareAndSet(25, 30);
```

---

# 6. Compare-And-Swap (CAS)

CAS updates a value only if it matches the expected value.

```text
Current Value = 10

Expected = 10

New Value = 20

Update Successful
```

If another thread changes the value first, the update fails and can be retried.

---

# 7. Atomic vs Synchronized

| Atomic Classes | synchronized |
|----------------|--------------|
| Lock-free | Uses locks |
| Faster for simple variables | Better for complex critical sections |
| Low overhead | Higher overhead |
| Limited to atomic operations | Supports larger synchronized blocks |

---

# 8. Advantages

- High performance
- Thread-safe updates
- Lock-free implementation
- Reduced contention
- Simple API

---

# 9. Limitations

- Suitable only for individual variables
- Cannot replace synchronization for complex operations
- Multiple related updates may still require locks

---

# 10. Best Practices

- Use atomic classes for counters and flags.
- Prefer them over synchronization for simple shared variables.
- Use synchronization or locks for compound operations involving multiple variables.
- Avoid mixing atomic variables with unsynchronized shared state.

---

# 11. Common Mistakes

❌ Assuming atomic classes make entire objects thread-safe.

❌ Using ordinary variables alongside atomic variables without proper coordination.

❌ Replacing all synchronization with atomic classes.

---

# 12. Interview Questions

1. What are atomic classes in Java?
2. What is `AtomicInteger`?
3. What is Compare-And-Swap (CAS)?
4. Atomic classes vs `synchronized`?
5. When should atomic classes be used?

---

# 13. Quick Revision

```text
Atomic Classes
│
├── AtomicInteger
├── AtomicLong
├── AtomicBoolean
├── AtomicReference
└── CAS Operations
```

---

# 14. Interview Cheat Sheet

```text
Atomic Classes

✔ Lock-Free
✔ Thread Safe
✔ CAS Based

Popular Classes

AtomicInteger
AtomicLong
AtomicBoolean
AtomicReference

Best For

Counters
Flags
Statistics
```

---

# 15. Summary

Atomic classes provide efficient, lock-free, thread-safe operations on individual variables using Compare-And-Swap (CAS). They are faster than traditional synchronization for simple shared data such as counters and flags, but they are not a complete replacement for synchronization when multiple related operations or complex critical sections must be protected.
