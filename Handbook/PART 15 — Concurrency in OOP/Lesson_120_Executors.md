# Lesson 120 — Executors

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Executor Framework** is a high-level concurrency API introduced in Java to simplify thread management.

Instead of manually creating and managing threads using `new Thread()`, developers submit tasks to an **Executor**, which manages thread creation, scheduling, reuse, and termination.

The framework is part of the `java.util.concurrent` package.

---

# 2. Why Executors?

Creating threads manually for every task is inefficient because:

- Thread creation is expensive.
- Too many threads consume memory.
- Managing thread lifecycles becomes difficult.

Executors solve these problems using **thread pools**.

```text
Tasks
  │
  ▼
Executor
  │
  ▼
Thread Pool
  │
  ▼
Execution
```

---

# 3. Executor Hierarchy

```text
Executor
    │
    ▼
ExecutorService
    │
    ▼
ScheduledExecutorService
```

- `Executor` executes tasks.
- `ExecutorService` adds lifecycle management.
- `ScheduledExecutorService` supports delayed and periodic tasks.

---

# 4. Creating an Executor

```java
import java.util.concurrent.*;

ExecutorService executor =
    Executors.newFixedThreadPool(3);
```

This creates a pool containing three reusable worker threads.

---

# 5. Submitting Tasks

Using `Runnable`:

```java
executor.execute(() ->
    System.out.println("Task running"));
```

Using `submit()`:

```java
Future<?> future = executor.submit(() ->
    System.out.println("Another task"));
```

`submit()` returns a `Future`, allowing the result or completion status to be tracked.

---

# 6. Callable and Future

Unlike `Runnable`, a `Callable` returns a value.

```java
Callable<Integer> task = () -> 10 + 20;

Future<Integer> future = executor.submit(task);

System.out.println(future.get());
```

Output:

```text
30
```

---

# 7. Shutting Down

Always shut down an executor after use.

```java
executor.shutdown();
```

To stop immediately:

```java
executor.shutdownNow();
```

---

# 8. Types of Thread Pools

| Method | Description |
|--------|-------------|
| `newFixedThreadPool()` | Fixed number of threads |
| `newCachedThreadPool()` | Creates threads as needed |
| `newSingleThreadExecutor()` | One worker thread |
| `newScheduledThreadPool()` | Scheduled and periodic tasks |

---

# 9. Advantages

- Thread reuse
- Better performance
- Simplified thread management
- Improved scalability
- Built-in scheduling support

---

# 10. Best Practices

- Prefer executors over manual thread creation.
- Choose an appropriate pool size.
- Shut down executors after use.
- Use `Callable` when a result is required.
- Avoid creating unnecessary thread pools.

---

# 11. Common Mistakes

❌ Forgetting `shutdown()`.

❌ Creating a new executor for every task.

❌ Using an excessively large thread pool.

❌ Blocking worker threads unnecessarily.

---

# 12. Interview Questions

1. What is the Executor Framework?
2. Why is it preferred over `new Thread()`?
3. Difference between `execute()` and `submit()`?
4. What is a `Future`?
5. What are the different thread pool types?

---

# 13. Quick Revision

```text
Executor Framework
│
├── Executor
├── ExecutorService
├── Thread Pools
├── Callable
└── Future
```

---

# 14. Interview Cheat Sheet

```text
Executor Framework

✔ Thread Pool
✔ Task Scheduling
✔ Thread Reuse

Methods

execute()
submit()
shutdown()

Thread Pools

Fixed
Cached
Single
Scheduled
```

---

# 15. Summary

The Executor Framework provides a powerful and efficient way to manage concurrent tasks in Java. By using thread pools, `ExecutorService`, `Callable`, and `Future`, developers can build scalable applications without manually handling thread creation and lifecycle management. Executors improve performance through thread reuse and are the preferred approach for modern Java concurrency.
