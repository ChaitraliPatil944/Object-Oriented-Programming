# Lesson 130 — Singleton Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Singleton Pattern** is a creational design pattern that ensures **only one instance** of a class exists and provides a global access point to it.

Typical use cases:

- Logger
- Configuration Manager
- Cache
- Thread Pool
- Database Connection Manager (carefully)

---

# 2. Problem

Without Singleton:

```text
Application

new Config()
new Config()
new Config()
```

Multiple objects may cause inconsistent state and unnecessary memory usage.

---

# 3. Solution

```text
Private Constructor
        │
Single Static Instance
        │
Public getInstance()
```

Only one object can ever be created.

---

# 4. Basic Implementation

```java
class Singleton {

    private static Singleton instance;

    private Singleton() {}

    public static Singleton getInstance() {
        if (instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}
```

Usage:

```java
Singleton s = Singleton.getInstance();
```

---

# 5. How It Works

```text
Client
   │
getInstance()
   │
Instance Exists?
   │
 ├── Yes → Return Existing Object
 └── No  → Create and Return
```

---

# 6. Eager Initialization

```java
class Singleton {

    private static final Singleton INSTANCE =
            new Singleton();

    private Singleton(){}

    public static Singleton getInstance() {
        return INSTANCE;
    }
}
```

Advantages:

- Simple
- Thread-safe

Disadvantage:

- Instance created even if never used.

---

# 7. Lazy Initialization

Object is created only when first requested.

Pros:

- Saves memory

Cons:

- Not thread-safe without synchronization.

---

# 8. Thread-Safe Singleton

```java
public static synchronized Singleton getInstance() {
    if(instance == null){
        instance = new Singleton();
    }
    return instance;
}
```

Thread-safe but synchronization introduces overhead.

---

# 9. Double-Checked Locking

```java
private static volatile Singleton instance;

public static Singleton getInstance() {
    if (instance == null) {
        synchronized (Singleton.class) {
            if (instance == null) {
                instance = new Singleton();
            }
        }
    }
    return instance;
}
```

Provides lazy initialization with better performance.

---

# 10. Advantages

- One shared instance
- Controlled access
- Reduced memory usage
- Centralized state

---

# 11. Disadvantages

- Global state can make testing harder.
- Can hide dependencies.
- Overuse may reduce flexibility.

Because turning everything into a Singleton is less a design strategy and more a cry for architectural supervision.

---

# 12. Real-World Examples

- Logging service
- Application configuration
- Print spooler
- Cache manager

---

# 13. Interview Questions

1. What is the Singleton pattern?
2. Why is the constructor private?
3. Eager vs lazy initialization?
4. Why use `volatile` in double-checked locking?
5. When should Singleton be avoided?

---

# 14. Quick Revision

```text
Singleton

✔ One Instance
✔ Private Constructor
✔ Static Instance
✔ getInstance()

Variants

Eager
Lazy
Thread-Safe
Double-Checked Locking
```

---

# 15. Summary

The Singleton pattern guarantees that only one instance of a class exists while providing global access to that instance. It is useful for shared resources such as configuration and logging, but it should be applied carefully to avoid hidden dependencies and reduced testability.
