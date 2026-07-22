# Lesson 121 — Concurrent Collections

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Concurrent Collections** are thread-safe collection classes provided by Java in the `java.util.concurrent` package.

Unlike ordinary collections (such as `ArrayList` or `HashMap`), concurrent collections are designed to support safe access by multiple threads with minimal locking and high performance.

---

# 2. Why Concurrent Collections?

Standard collections are **not thread-safe**.

```java
List<Integer> list = new ArrayList<>();
```

If multiple threads modify this list simultaneously, it may lead to:

- Race conditions
- Data corruption
- `ConcurrentModificationException`
- Inconsistent results

Concurrent collections solve these problems efficiently.

---

# 3. Common Concurrent Collections

| Collection | Purpose |
|------------|---------|
| `ConcurrentHashMap` | Thread-safe hash map |
| `CopyOnWriteArrayList` | Thread-safe list for read-heavy workloads |
| `CopyOnWriteArraySet` | Thread-safe set |
| `ConcurrentLinkedQueue` | Non-blocking queue |
| `ConcurrentLinkedDeque` | Non-blocking double-ended queue |
| `BlockingQueue` | Producer-consumer communication |

---

# 4. ConcurrentHashMap

```java
import java.util.concurrent.*;

ConcurrentHashMap<Integer, String> map =
        new ConcurrentHashMap<>();

map.put(1, "Alice");
map.put(2, "Bob");

System.out.println(map.get(1));
```

Unlike `HashMap`, it allows multiple threads to access different portions of the map concurrently.

---

# 5. CopyOnWriteArrayList

```java
CopyOnWriteArrayList<String> list =
        new CopyOnWriteArrayList<>();

list.add("Java");
list.add("Python");

for (String s : list) {
    System.out.println(s);
}
```

Every modification creates a new internal copy, making iteration safe without synchronization.

Best suited for **many reads and few writes**.

---

# 6. BlockingQueue

A `BlockingQueue` automatically blocks producers or consumers when necessary.

```java
BlockingQueue<Integer> queue =
        new LinkedBlockingQueue<>();

queue.put(10);

System.out.println(queue.take());
```

Used extensively in producer-consumer systems.

---

# 7. Concurrent vs Synchronized Collections

| Concurrent Collections | Synchronized Collections |
|-------------------------|--------------------------|
| Better scalability | Coarse-grained locking |
| Higher concurrency | Lower concurrency |
| Fine-grained or lock-free | Entire collection locked |
| Better performance | More contention |

Example synchronized wrapper:

```java
List<Integer> list =
    Collections.synchronizedList(new ArrayList<>());
```

---

# 8. Advantages

- Thread-safe operations
- High performance
- Reduced contention
- Better scalability
- Built for concurrent applications

---

# 9. Best Practices

- Prefer concurrent collections over synchronized wrappers for highly concurrent programs.
- Choose a collection based on the access pattern.
- Use `CopyOnWriteArrayList` only when reads greatly outnumber writes.
- Use `BlockingQueue` for producer-consumer designs.
- Avoid unnecessary external synchronization.

---

# 10. Common Mistakes

❌ Using `HashMap` in multithreaded code without protection.

❌ Choosing `CopyOnWriteArrayList` for write-heavy workloads.

❌ Synchronizing concurrent collections unnecessarily.

❌ Ignoring the characteristics of different concurrent data structures.

---

# 11. Interview Questions

1. What are concurrent collections?
2. Why is `ConcurrentHashMap` preferred over `HashMap` in multithreaded applications?
3. What is `CopyOnWriteArrayList`?
4. What is the purpose of `BlockingQueue`?
5. Difference between concurrent collections and synchronized collections?

---

# 12. Quick Revision

```text
Concurrent Collections
│
├── ConcurrentHashMap
├── CopyOnWriteArrayList
├── BlockingQueue
├── ConcurrentLinkedQueue
└── Thread Safe
```

---

# 13. Interview Cheat Sheet

```text
Concurrent Collections

✔ Thread Safe
✔ High Performance
✔ Fine-Grained Locking

Popular Classes

ConcurrentHashMap
CopyOnWriteArrayList
BlockingQueue
ConcurrentLinkedQueue

Best For

Multithreaded Applications
Producer-Consumer Systems
```

---

# 14. Summary

Concurrent collections provide efficient, thread-safe alternatives to standard Java collections for use in multithreaded applications. Classes such as `ConcurrentHashMap`, `CopyOnWriteArrayList`, and `BlockingQueue` enable safe concurrent access while minimizing locking and maximizing scalability. Choosing the appropriate concurrent collection depends on the application's access patterns and concurrency requirements.
