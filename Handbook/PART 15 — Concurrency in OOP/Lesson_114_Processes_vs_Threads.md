# Lesson 114 — Processes vs Threads

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Modern operating systems execute multiple programs simultaneously using **processes** and **threads**.

Understanding the difference between them is essential for building efficient, responsive, and scalable Java applications.

Java supports multithreading through its built-in concurrency APIs, allowing multiple threads to execute within a single process.

---

# 2. What is a Process?

A **Process** is an independent program in execution.

Each process has:

- Its own memory space
- Program counter
- Stack
- Heap
- System resources

Examples:

- Google Chrome
- Microsoft Word
- IntelliJ IDEA
- Spotify

Each runs as a separate process.

---

# 3. What is a Thread?

A **Thread** is the smallest unit of execution inside a process.

Multiple threads can exist within the same process.

Threads share:

- Heap memory
- Open files
- Process resources

Each thread has its own:

- Program counter
- Stack
- Registers

---

# 4. Process vs Thread

| Feature | Process | Thread |
|---------|---------|---------|
| Unit | Independent program | Lightweight execution unit |
| Memory | Separate | Shared within process |
| Communication | IPC required | Shared memory |
| Creation Cost | High | Low |
| Context Switch | Slower | Faster |
| Failure | Usually isolated | Can affect entire process |

---

# 5. Relationship

```text
Process
│
├── Thread 1
├── Thread 2
├── Thread 3
└── Thread 4
```

A process may contain one or many threads.

---

# 6. Example

Imagine a web browser.

```text
Browser Process
│
├── UI Thread
├── Rendering Thread
├── Network Thread
└── Download Thread
```

Each thread performs a different task while sharing the browser's memory.

---

# 7. Advantages of Multithreading

- Better CPU utilization
- Faster execution
- Improved responsiveness
- Concurrent task execution
- Resource sharing

---

# 8. Disadvantages

- Synchronization complexity
- Race conditions
- Deadlocks
- Difficult debugging
- Shared resource conflicts

---

# 9. Process Communication vs Thread Communication

Processes communicate using:

- Pipes
- Sockets
- Shared memory
- Message queues

Threads communicate directly through shared objects and variables.

---

# 10. Best Practices

- Use threads for related tasks within the same application.
- Avoid unnecessary thread creation.
- Protect shared resources using synchronization.
- Prefer thread pools for large applications.

---

# 11. Common Mistakes

❌ Assuming threads have separate memory.

❌ Ignoring synchronization for shared data.

❌ Creating excessive threads.

❌ Confusing processes with threads.

---

# 12. Interview Questions

1. What is a process?
2. What is a thread?
3. Difference between a process and a thread?
4. Why are threads faster than processes?
5. What memory do threads share?

---

# 13. Quick Revision

```text
Process
│
├── Own Memory
├── Heavyweight
└── Multiple Threads

Thread
│
├── Shared Memory
├── Lightweight
└── Faster Context Switch
```

---

# 14. Interview Cheat Sheet

```text
Process

✔ Independent Program
✔ Separate Memory
✔ High Creation Cost

Thread

✔ Inside Process
✔ Shared Heap
✔ Own Stack
✔ Lightweight
✔ Faster
```

---

# 15. Summary

A process is an independent program with its own memory and system resources, while a thread is a lightweight unit of execution within a process. Threads share the process's memory and resources, making communication faster and execution more efficient than separate processes. Understanding the distinction is fundamental for Java concurrency, multithreading, and high-performance object-oriented application development.
