# Lesson 115 — Thread Creation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **thread** is the smallest unit of execution within a process. Java provides built-in support for multithreading, allowing multiple tasks to execute concurrently.

There are several ways to create threads in Java, with the two most common being:

- Extending the `Thread` class
- Implementing the `Runnable` interface

Modern Java also supports executors and lambda expressions for thread management.

---

# 2. Why Create Threads?

Threads are useful for:

- Background tasks
- File downloading
- Network communication
- Parallel computations
- Responsive GUI applications

Without threads, long-running operations can block the entire application.

---

# 3. Creating a Thread by Extending `Thread`

```java
class MyThread extends Thread {

    @Override
    public void run() {
        System.out.println("Thread is running.");
    }

    public static void main(String[] args) {
        MyThread t = new MyThread();
        t.start();
    }
}
```

`start()` creates a new thread, which internally invokes `run()`.

---

# 4. Creating a Thread Using `Runnable`

```java
class MyTask implements Runnable {

    @Override
    public void run() {
        System.out.println("Runnable task executing.");
    }

    public static void main(String[] args) {
        Thread t = new Thread(new MyTask());
        t.start();
    }
}
```

This approach is preferred because it supports inheritance from another class.

---

# 5. Thread Lifecycle

```text
New
 │
 ▼
Runnable
 │
 ▼
Running
 │
 ▼
Blocked / Waiting
 │
 ▼
Terminated
```

---

# 6. `start()` vs `run()`

| `start()` | `run()` |
|-----------|----------|
| Creates a new thread | Executes like a normal method |
| Runs concurrently | Runs in current thread |
| Calls `run()` internally | No new thread created |

Example:

```java
Thread t = new MyThread();

t.start(); // New thread

t.run();   // Normal method call
```

---

# 7. Lambda Expression with `Runnable`

```java
Thread t = new Thread(() -> {
    System.out.println("Running using lambda.");
});

t.start();
```

This is concise and commonly used in modern Java.

---

# 8. Naming Threads

```java
Thread t = new Thread();

t.setName("Worker-1");

System.out.println(t.getName());
```

Naming threads simplifies debugging.

---

# 9. Advantages

- Responsive applications
- Concurrent execution
- Better CPU utilization
- Background processing
- Improved scalability

---

# 10. Best Practices

- Prefer `Runnable` over extending `Thread`.
- Use thread pools (`ExecutorService`) for multiple tasks.
- Keep thread work focused.
- Avoid creating excessive threads manually.

---

# 11. Common Mistakes

❌ Calling `run()` instead of `start()`.

❌ Sharing mutable data without synchronization.

❌ Creating too many threads.

❌ Performing heavy work on the UI thread.

---

# 12. Interview Questions

1. How can a thread be created in Java?
2. What is the difference between extending `Thread` and implementing `Runnable`?
3. Why is `Runnable` generally preferred?
4. What is the difference between `start()` and `run()`?
5. What are the lifecycle states of a thread?

---

# 13. Quick Revision

```text
Thread Creation
│
├── Thread Class
├── Runnable Interface
├── start()
├── run()
└── Lambda Runnable
```

---

# 14. Interview Cheat Sheet

```text
Ways to Create Threads

✔ extends Thread
✔ implements Runnable

Important

start() → New Thread
run()   → Normal Method

Preferred

Runnable + Thread
ExecutorService
```

---

# 15. Summary

Java supports multithreading through the `Thread` class and the `Runnable` interface. While both approaches create concurrent tasks, implementing `Runnable` is generally preferred because it promotes better object-oriented design and allows class inheritance. Developers should always invoke `start()` to create a new thread and use higher-level concurrency utilities such as thread pools for scalable applications.
