# Lesson 143 — Behavioral Design Patterns

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Behavioral Design Patterns focus on **how objects communicate and collaborate**.

They help distribute responsibilities efficiently while reducing coupling.

---

# 2. Goal

Behavioral patterns improve:

- Communication between objects
- Flexibility
- Extensibility
- Maintainability
- Runtime behavior

---

# 3. Categories

The Gang of Four defines seven behavioral patterns.

```text
Behavioral Patterns
        │
 ├── Strategy
 ├── Observer
 ├── Command
 ├── State
 ├── Template Method
 ├── Visitor
 └── Chain of Responsibility
```

---

# 4. Strategy

Encapsulates interchangeable algorithms.

```text
Payment
 ├── Card
 ├── UPI
 └── Wallet
```

Choose behavior at runtime.

---

# 5. Observer

One object notifies multiple dependent objects.

```text
Subject
   │
Observers
```

Useful for event-driven systems.

---

# 6. Command

Encapsulates a request as an object.

```text
Button
   │
Command
   │
Receiver
```

Supports undo, queues, and scheduling.

---

# 7. State

Allows an object to change behavior when its internal state changes.

```text
Order
 ├── Pending
 ├── Paid
 └── Shipped
```

---

# 8. Template Method

Defines the overall algorithm while allowing subclasses to customize certain steps.

```text
Algorithm
   │
Fixed Steps
Variable Steps
```

---

# 9. Visitor

Separates operations from object structures.

Useful when adding new operations without modifying element classes.

---

# 10. Chain of Responsibility

Passes requests through a chain until one handler processes them.

```text
Request
   │
Handler 1
   │
Handler 2
   │
Handler 3
```

---

# 11. Comparison

| Pattern | Purpose |
|---------|---------|
| Strategy | Select algorithm |
| Observer | Notify subscribers |
| Command | Encapsulate requests |
| State | Change behavior by state |
| Template Method | Define algorithm skeleton |
| Visitor | Add operations |
| Chain of Responsibility | Pass requests through handlers |

---

# 12. When to Use

- Strategy for interchangeable algorithms.
- Observer for event notifications.
- Command for actions and undo.
- State for state-driven behavior.
- Template Method for common workflows.
- Visitor for new operations.
- Chain of Responsibility for request pipelines.

Because software objects spend a surprising amount of time talking to each other. Thankfully they usually interrupt less than humans.

---

# 13. Interview Questions

1. What are behavioral design patterns?
2. Name the seven behavioral patterns.
3. Strategy vs State?
4. Observer vs Chain of Responsibility?
5. Command vs Strategy?

---

# 14. Quick Revision

```text
Behavioral Patterns

Strategy
Observer
Command
State
Template Method
Visitor
Chain of Responsibility

Goal

Object Communication
Flexible Behavior
Low Coupling
```

---

# 15. Summary

Behavioral design patterns define effective ways for objects to interact and share responsibilities. They improve flexibility by separating algorithms, handling events, managing state, encapsulating requests, defining workflows, adding operations, and routing requests through handlers.
