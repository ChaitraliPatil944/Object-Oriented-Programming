# Lesson 137 — Bridge Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Bridge Pattern** is a structural design pattern that **separates an abstraction from its implementation** so that both can evolve independently.

Instead of creating many subclasses for every combination, Bridge connects two hierarchies using composition.

---

# 2. Problem

Without Bridge:

```text
RemoteTV
RemoteRadio
AdvancedRemoteTV
AdvancedRemoteRadio
```

As features and device types grow, subclasses multiply.

---

# 3. Solution

Separate the abstraction from the implementation.

```text
Abstraction
   │
Composition
   │
Implementation
```

---

# 4. Structure

```text
Remote
   │
Device
 ├── TV
 └── Radio
```

The remote works with any device implementing the `Device` interface.

---

# 5. Participants

- Abstraction
- Refined Abstraction
- Implementor Interface
- Concrete Implementors
- Client

---

# 6. Example

### Implementor

```java
interface Device {
    void on();
    void off();
}
```

### Concrete Implementors

```java
class TV implements Device {
    public void on(){ System.out.println("TV ON"); }
    public void off(){ System.out.println("TV OFF"); }
}

class Radio implements Device {
    public void on(){ System.out.println("Radio ON"); }
    public void off(){ System.out.println("Radio OFF"); }
}
```

### Abstraction

```java
class Remote {

    protected Device device;

    Remote(Device device){
        this.device = device;
    }

    void power(){
        device.on();
    }
}
```

### Client

```java
Remote remote = new Remote(new TV());
remote.power();
```

---

# 7. How It Works

```text
Client
   │
Remote
   │
Device Interface
   │
TV / Radio
```

The abstraction delegates work to the implementation.

---

# 8. Advantages

- Reduces subclass explosion
- Promotes composition
- Independent evolution
- Better extensibility
- Loose coupling

---

# 9. Disadvantages

- More classes
- Slightly more complex design

---

# 10. Bridge vs Adapter

| Bridge | Adapter |
|--------|---------|
| Designed upfront | Often used later |
| Separates abstraction and implementation | Converts incompatible interfaces |
| Prevents hierarchy explosion | Enables compatibility |

---

# 11. Bridge vs Strategy

| Bridge | Strategy |
|--------|----------|
| Structural pattern | Behavioral pattern |
| Separates implementation | Changes algorithm at runtime |

---

# 12. Real-World Uses

- Remote controls and devices
- GUI toolkits
- Database abstraction layers
- Cross-platform rendering engines
- Messaging systems

Because doubling features and platforms should not require quadrupling subclasses. Mathematics is difficult enough without object hierarchies joining in.

---

# 13. Best Practices

- Prefer composition over inheritance.
- Keep abstraction and implementation independent.
- Use interfaces for implementors.
- Introduce Bridge when two dimensions of change exist.

---

# 14. Interview Questions

1. What problem does the Bridge pattern solve?
2. Bridge vs Adapter?
3. Why use composition?
4. When should Bridge be used?
5. Give a real-world example.

---

# 15. Quick Revision

```text
Bridge Pattern

✔ Separate Abstraction
✔ Separate Implementation
✔ Composition
✔ Loose Coupling

Flow

Client
  │
Abstraction
  │
Implementation
```

---

# 16. Summary

The Bridge pattern separates an abstraction from its implementation so both can change independently. By favoring composition over inheritance, it avoids subclass explosion, improves flexibility, and produces cleaner, more maintainable object-oriented designs.
