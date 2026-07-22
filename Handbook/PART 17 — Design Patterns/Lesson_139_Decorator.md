# Lesson 139 — Decorator Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Decorator Pattern** is a structural design pattern that allows **new functionality to be added to an object dynamically** without modifying its existing code.

It wraps an object inside another object that provides additional behavior.

---

# 2. Problem

Suppose a coffee shop application offers optional add-ons.

Without Decorator:

```text
Coffee
MilkCoffee
SugarCoffee
MilkSugarCoffee
WhippedCreamCoffee
MilkSugarCreamCoffee
...
```

As combinations increase, the number of subclasses grows rapidly.

---

# 3. Solution

Wrap objects with decorators.

```text
Coffee
   │
Milk Decorator
   │
Sugar Decorator
   │
Whipped Cream Decorator
```

Each decorator adds behavior independently.

---

# 4. Participants

- Component
- Concrete Component
- Decorator
- Concrete Decorators
- Client

---

# 5. Example Structure

```text
Coffee
   │
SimpleCoffee
   │
Decorator
 ├── Milk
 ├── Sugar
 └── Cream
```

---

# 6. Example

### Component

```java
interface Coffee {
    String description();
}
```

### Concrete Component

```java
class SimpleCoffee implements Coffee {

    public String description() {
        return "Coffee";
    }
}
```

### Decorator

```java
abstract class CoffeeDecorator
        implements Coffee {

    protected Coffee coffee;

    CoffeeDecorator(Coffee coffee){
        this.coffee = coffee;
    }
}
```

### Concrete Decorator

```java
class MilkDecorator extends CoffeeDecorator {

    MilkDecorator(Coffee coffee){
        super(coffee);
    }

    public String description() {
        return coffee.description() + " + Milk";
    }
}
```

### Client

```java
Coffee coffee =
    new MilkDecorator(
        new SimpleCoffee());

System.out.println(coffee.description());
```

---

# 7. How It Works

```text
Client
   │
Decorator
   │
Wrapped Object
```

Each decorator forwards requests and adds extra behavior.

---

# 8. Advantages

- Adds functionality at runtime
- Avoids subclass explosion
- Promotes composition over inheritance
- Flexible and reusable

---

# 9. Disadvantages

- Many small classes
- Object structure becomes deeper
- Can be harder to debug

Because eventually your coffee object is wrapped inside six decorators and even the debugger needs a coffee.

---

# 10. Real-World Uses

- Java I/O Streams
- GUI component enhancements
- Logging
- Compression
- Encryption

---

# 11. Decorator vs Inheritance

| Decorator | Inheritance |
|-----------|-------------|
| Runtime behavior | Compile-time behavior |
| Uses composition | Uses inheritance |
| Flexible | Rigid hierarchy |

---

# 12. Decorator vs Proxy

| Decorator | Proxy |
|-----------|-------|
| Adds functionality | Controls access |
| Extends behavior | Protects or manages object |

---

# 13. Best Practices

- Keep decorators independent.
- Decorators should follow the same interface as the wrapped object.
- Combine decorators only when behavior remains understandable.
- Prefer decorators for optional features.

---

# 14. Interview Questions

1. What problem does the Decorator pattern solve?
2. Decorator vs Inheritance?
3. Decorator vs Proxy?
4. Why is composition preferred?
5. Give real-world examples of Decorator.

---

# 15. Quick Revision

```text
Decorator Pattern

✔ Add Behavior Dynamically
✔ Runtime Extension
✔ Composition
✔ Flexible Design

Flow

Client
   │
Decorator
   │
Component
```

---

# 16. Summary

The Decorator pattern dynamically adds responsibilities to objects without modifying their underlying classes. By using composition instead of inheritance, it provides a flexible, reusable, and scalable way to extend object behavior while avoiding large inheritance hierarchies.
