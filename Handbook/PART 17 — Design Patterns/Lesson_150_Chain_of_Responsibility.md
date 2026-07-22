# Lesson 150 — Chain of Responsibility Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Chain of Responsibility Pattern** is a behavioral design pattern that passes a request through a chain of handlers until one of them processes it.

Each handler decides either to handle the request or forward it to the next handler.

---

# 2. Problem

Suppose a company's leave approval system has multiple approval levels.

```text
Employee
Manager
Director
CEO
```

Without this pattern, the client must know exactly who should process each request.

---

# 3. Solution

Create a chain of handlers.

```text
Request
   │
Manager
   │
Director
   │
CEO
```

Each handler checks the request and either handles it or forwards it.

---

# 4. Participants

- Handler
- Concrete Handler
- Client
- Request

---

# 5. Structure

```text
Client
   │
Handler
   │
Next Handler
```

---

# 6. Example

### Handler

```java
abstract class Approver {

    protected Approver next;

    void setNext(Approver next) {
        this.next = next;
    }

    abstract void approve(int amount);
}
```

### Concrete Handlers

```java
class Manager extends Approver {

    void approve(int amount) {
        if (amount <= 5000)
            System.out.println("Approved by Manager");
        else if (next != null)
            next.approve(amount);
    }
}

class Director extends Approver {

    void approve(int amount) {
        if (amount <= 20000)
            System.out.println("Approved by Director");
        else if (next != null)
            next.approve(amount);
    }
}
```

### Client

```java
Manager manager = new Manager();
Director director = new Director();

manager.setNext(director);

manager.approve(15000);
```

---

# 7. How It Works

```text
Client
   │
Handler 1
   │
Handler 2
   │
Handler 3
```

The request travels until a suitable handler processes it.

---

# 8. Advantages

- Reduces coupling
- Easy to add new handlers
- Flexible request processing
- Supports dynamic chains

---

# 9. Disadvantages

- Request may go unhandled
- Debugging long chains can be difficult
- Performance may decrease with many handlers

Because sometimes the fastest way to solve a problem is apparently to hand it to someone else until somebody finally gives in.

---

# 10. Real-World Uses

- Technical support escalation
- Exception handling
- Servlet filters
- Authentication pipelines
- Approval workflows

---

# 11. Chain of Responsibility vs Observer

| Chain of Responsibility | Observer |
|-------------------------|----------|
| One handler processes request | All observers receive notification |
| Sequential flow | Broadcast updates |

---

# 12. Chain of Responsibility vs Command

| Chain of Responsibility | Command |
|-------------------------|---------|
| Passes requests through handlers | Encapsulates a request |
| Chooses handler dynamically | Executes a specific action |

---

# 13. Best Practices

- Keep handlers independent.
- Avoid excessively long chains.
- Ensure requests have a termination condition.
- Configure chains dynamically when possible.

---

# 14. Interview Questions

1. What problem does the Chain of Responsibility pattern solve?
2. What are its participants?
3. Chain of Responsibility vs Observer?
4. What happens if no handler processes the request?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Chain of Responsibility

✔ Request Pipeline
✔ Loose Coupling
✔ Dynamic Handlers
✔ Flexible Processing

Flow

Client
   │
Handler
   │
Next Handler
```

---

# 16. Summary

The Chain of Responsibility pattern passes requests through a sequence of handlers until one of them handles the request. It promotes loose coupling between senders and receivers, simplifies request processing, and is widely used in approval systems, middleware pipelines, and event processing frameworks.
