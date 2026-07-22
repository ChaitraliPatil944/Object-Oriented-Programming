# Lesson 142 — Proxy Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Proxy Pattern** is a structural design pattern that provides a **placeholder or surrogate object** to control access to another object.

Instead of interacting with the real object directly, the client communicates with the proxy.

---

# 2. Problem

Suppose creating or accessing an object is expensive, sensitive, or remote.

Examples:

- Loading a large image
- Accessing a secure resource
- Calling a remote server

Direct access may be inefficient or unsafe.

---

# 3. Solution

Insert a proxy between the client and the real object.

```text
Client
   │
Proxy
   │
Real Object
```

The proxy can add extra behavior before or after forwarding requests.

---

# 4. Participants

- Subject Interface
- Real Subject
- Proxy
- Client

---

# 5. Example

### Subject

```java
interface Image {
    void display();
}
```

### Real Subject

```java
class RealImage implements Image {

    public RealImage() {
        System.out.println("Loading image...");
    }

    public void display() {
        System.out.println("Displaying image");
    }
}
```

### Proxy

```java
class ProxyImage implements Image {

    private RealImage image;

    public void display() {

        if (image == null) {
            image = new RealImage();
        }

        image.display();
    }
}
```

### Client

```java
Image img = new ProxyImage();

img.display();
img.display();
```

The image is loaded only once.

---

# 6. How It Works

```text
Client
   │
Proxy
   │
Checks Access / Cache / Load
   │
Real Object
```

The proxy decides when and how to access the real object.

---

# 7. Types of Proxy

### Virtual Proxy

Delays expensive object creation.

### Protection Proxy

Controls user permissions.

### Remote Proxy

Represents objects located on another machine.

### Caching Proxy

Stores previously retrieved results.

### Smart Proxy

Adds logging, monitoring, or reference counting.

---

# 8. Advantages

- Lazy initialization
- Access control
- Improved performance
- Logging and monitoring
- Caching support

---

# 9. Disadvantages

- Additional layer of indirection
- Increased complexity
- Slight runtime overhead

Because software often solves one layer of complexity by adding another layer that promises to manage it responsibly.

---

# 10. Real-World Uses

- Hibernate lazy loading
- Spring AOP proxies
- Java RMI
- Security wrappers
- API caching layers

---

# 11. Proxy vs Decorator

| Proxy | Decorator |
|-------|-----------|
| Controls access | Adds behavior |
| May delay creation | Extends functionality |

---

# 12. Proxy vs Facade

| Proxy | Facade |
|-------|--------|
| Represents one object | Simplifies many objects |
| Controls access | Simplifies usage |

---

# 13. Best Practices

- Keep the proxy interface identical to the real subject.
- Delegate requests whenever possible.
- Add only access-related responsibilities.
- Avoid placing business logic inside proxies.

---

# 14. Interview Questions

1. What problem does the Proxy pattern solve?
2. Name the different types of proxies.
3. Proxy vs Decorator?
4. Proxy vs Facade?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Proxy Pattern

✔ Controls Access
✔ Lazy Loading
✔ Security
✔ Caching
✔ Logging

Flow

Client
   │
Proxy
   │
Real Object
```

---

# 16. Summary

The Proxy pattern provides a substitute for another object to control access, improve performance, or add supporting behavior such as caching, security, or lazy initialization. It is widely used in enterprise Java frameworks and distributed systems where direct access to objects must be managed carefully.
