# Lesson 32 — Memory Leaks

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

One of the biggest misconceptions about Java is:

> "Java has Garbage Collection, so memory leaks cannot happen."

This is **false**.

Although Java automatically reclaims unreachable objects, **memory leaks can still occur** if objects remain reachable even though the application no longer needs them.

Memory leaks reduce available heap memory, increase garbage collection activity, degrade performance, and may eventually cause an `OutOfMemoryError`.

---

# 2. What is a Memory Leak?

A **memory leak** occurs when an object is no longer useful to the application but is **still referenced**, preventing the Garbage Collector from reclaiming its memory.

```text
Application Doesn't Need Object
            │
            ▼
Reference Still Exists
            │
            ▼
Garbage Collector Cannot Remove It
```

The object remains in memory unnecessarily.

---

# 3. Why Garbage Collection Cannot Fix Every Leak

The Garbage Collector only removes **unreachable** objects.

If an object still has a live reference:

```java
Employee emp = new Employee();
```

it is considered reachable, even if the program never uses it again.

GC cannot determine business logic or developer intent.

---

# 4. Simple Memory Leak Example

```java
List<Employee> employees = new ArrayList<>();

while (true) {
    employees.add(new Employee());
}
```

Here:

- New objects are continuously created.
- The list keeps references to every object.
- None of the objects become unreachable.

Eventually, heap memory is exhausted.

---

# 5. Static Collections

One common source of leaks is static collections.

```java
class Cache {

    static List<Employee> list = new ArrayList<>();
}
```

If objects are continually added and never removed:

```java
Cache.list.add(new Employee());
```

the static list keeps them alive for the lifetime of the application.

---

# 6. Event Listener Leaks

Applications often register listeners.

```java
button.addActionListener(listener);
```

If the listener is never removed:

```java
button.removeActionListener(listener);
```

the listener object may remain reachable and cannot be garbage collected.

---

# 7. Cache-Related Leaks

Caching improves performance but may consume excessive memory if entries are never removed.

```text
Cache
 ├── Object 1
 ├── Object 2
 ├── Object 3
 └── ...
```

Use cache eviction strategies such as:

- LRU (Least Recently Used)
- Time-based expiration
- Size limits

---

# 8. Thread Leaks

Long-running threads can also cause memory leaks.

Example:

```java
new Thread(() -> {

    while(true){

    }

}).start();
```

If threads never terminate, objects referenced by those threads may remain in memory much longer than expected.

---

# 9. Memory Leak Symptoms

Typical signs include:

- Increasing heap usage
- Frequent Garbage Collection
- Slower application performance
- High memory consumption
- `OutOfMemoryError`

These symptoms often appear gradually in long-running applications.

---

# 10. Detecting Memory Leaks

Common JVM tools include:

- VisualVM
- Java Mission Control (JMC)
- Eclipse Memory Analyzer (MAT)
- JConsole

These tools help analyze heap dumps and identify objects that are unexpectedly retained.

---

# 11. Enterprise Example

Consider an e-commerce application.

```text
Customer Logs In
        │
        ▼
Session Object Created
        │
        ▼
Session Never Removed
        │
        ▼
Thousands of Sessions Accumulate
        │
        ▼
Heap Memory Fills
```

Without proper cleanup, inactive session objects consume valuable memory.

---

# 12. Preventing Memory Leaks

Best practices:

- Remove objects from collections when no longer needed.
- Avoid unnecessary static references.
- Close resources using try-with-resources.
- Deregister listeners.
- Design caches with eviction policies.
- Terminate unused threads.

---

# 13. Common Misconceptions

❌ Garbage Collection prevents all memory leaks.

❌ Setting every object to `null` is required.

❌ Memory leaks only occur in C and C++.

Correct understanding:

- Java can experience memory leaks through lingering references.
- Most local variables become unreachable automatically.
- Good object lifecycle management is essential.

---

# 14. Interview Questions

1. What is a memory leak?
2. Can Java have memory leaks?
3. Why can't the Garbage Collector remove every unused object?
4. How can static collections cause memory leaks?
5. Which tools help detect memory leaks?
6. What causes `OutOfMemoryError`?

---

# 15. Summary

Memory leaks occur when objects that are no longer needed remain reachable through active references. Since the Garbage Collector only removes unreachable objects, lingering references in collections, caches, listeners, static variables, or long-running threads can prevent memory reclamation. Proper resource management, cache design, and reference cleanup are essential for building reliable, high-performance Java applications.
