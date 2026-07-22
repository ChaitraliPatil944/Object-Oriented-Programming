# Lesson 135 — Structural Design Patterns

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Structural Design Patterns focus on **how classes and objects are composed** to build larger, flexible systems.

They simplify relationships between objects while promoting reuse and low coupling.

---

# 2. Goal

Structural patterns help developers:

- Organize object relationships
- Reuse existing code
- Reduce coupling
- Improve maintainability
- Hide implementation complexity

---

# 3. Categories

The Gang of Four defines seven structural patterns:

```text
Structural Patterns
        │
 ├── Adapter
 ├── Bridge
 ├── Composite
 ├── Decorator
 ├── Facade
 ├── Flyweight
 └── Proxy
```

---

# 4. Adapter

**Purpose:** Convert one interface into another expected by the client.

Example:

```text
Old API
   │
Adapter
   │
New Client
```

---

# 5. Bridge

**Purpose:** Separate abstraction from implementation so both can evolve independently.

```text
Remote
   │
Device
 ├── TV
 └── Radio
```

---

# 6. Composite

**Purpose:** Treat individual objects and groups uniformly.

```text
Folder
 ├── File
 ├── File
 └── Folder
```

Useful for tree structures.

---

# 7. Decorator

**Purpose:** Add behavior dynamically without modifying the original class.

```text
Coffee
   │
Milk Decorator
   │
Sugar Decorator
```

---

# 8. Facade

**Purpose:** Provide a simplified interface to a complex subsystem.

```text
Client
   │
Facade
   │
Subsystem A
Subsystem B
Subsystem C
```

---

# 9. Flyweight

**Purpose:** Share common object state to reduce memory usage.

Useful when many similar objects exist.

Example:

```text
Character Objects
Shared Font Data
```

---

# 10. Proxy

**Purpose:** Control access to another object.

Types:

- Virtual Proxy
- Protection Proxy
- Remote Proxy
- Caching Proxy

---

# 11. Comparison

| Pattern | Purpose |
|---------|---------|
| Adapter | Convert interfaces |
| Bridge | Separate abstraction and implementation |
| Composite | Tree structures |
| Decorator | Add responsibilities dynamically |
| Facade | Simplify subsystem |
| Flyweight | Save memory through sharing |
| Proxy | Control object access |

---

# 12. When to Use

Choose:

- **Adapter** for incompatible interfaces.
- **Bridge** when abstraction and implementation change independently.
- **Composite** for hierarchical data.
- **Decorator** for optional features.
- **Facade** to simplify complex APIs.
- **Flyweight** for many similar objects.
- **Proxy** for controlled access.

Because creating another wrapper class somehow became one of software engineering's favorite hobbies. At least these wrappers have a purpose.

---

# 13. Interview Questions

1. What are structural design patterns?
2. Name the seven structural patterns.
3. Adapter vs Bridge?
4. Decorator vs Inheritance?
5. Facade vs Proxy?

---

# 14. Quick Revision

```text
Structural Patterns

Adapter
Bridge
Composite
Decorator
Facade
Flyweight
Proxy

Goal

Flexible Structure
Low Coupling
Code Reuse
```

---

# 15. Summary

Structural design patterns improve the organization and composition of classes and objects. They enable flexible architectures by adapting interfaces, separating abstractions, composing hierarchies, extending behavior dynamically, simplifying complex systems, reducing memory usage, and controlling object access.
