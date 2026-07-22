# Lesson 141 — Flyweight Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Flyweight Pattern** is a structural design pattern that minimizes memory usage by **sharing common object state** among many similar objects.

Instead of creating thousands of identical objects, shared data is stored once and reused.

---

# 2. Problem

Suppose a text editor displays one million characters.

Without Flyweight:

```text
Character
Font
Size
Color
Position
```

Every character stores identical font information.

Memory usage becomes very high.

---

# 3. Solution

Separate state into:

- **Intrinsic State** (shared)
- **Extrinsic State** (supplied by client)

```text
Character
   │
Shared Font Data
```

---

# 4. Intrinsic vs Extrinsic State

| Intrinsic State | Extrinsic State |
|-----------------|-----------------|
| Shared | Unique |
| Stored in Flyweight | Passed by client |
| Font | Position |
| Size | Coordinates |
| Color palette | Current location |

---

# 5. Structure

```text
Client
   │
Flyweight Factory
   │
Shared Flyweights
```

The factory returns existing objects whenever possible.

---

# 6. Example

### Flyweight

```java
interface CharacterStyle {
    void draw(int x, int y);
}
```

### Concrete Flyweight

```java
class FontStyle implements CharacterStyle {

    private String font;

    FontStyle(String font){
        this.font = font;
    }

    public void draw(int x,int y){
        System.out.println(font+" at "+x+","+y);
    }
}
```

### Factory

```java
class StyleFactory {

    private Map<String, CharacterStyle> cache =
            new HashMap<>();

    CharacterStyle getStyle(String font){
        return cache.computeIfAbsent(font,
                FontStyle::new);
    }
}
```

---

# 7. How It Works

```text
Client
   │
Request Style
   │
Factory
   │
Existing?
 ├── Yes → Return Shared Object
 └── No  → Create and Cache
```

---

# 8. Advantages

- Reduces memory usage
- Improves performance
- Reuses shared objects
- Ideal for large numbers of similar objects

---

# 9. Disadvantages

- Increased design complexity
- Requires careful separation of shared and unique state

Because creating a million identical objects is an expensive way to prove computers have finite memory.

---

# 10. Real-World Uses

- Text editors
- Game engines
- Icon libraries
- Map markers
- Object pools

---

# 11. Flyweight vs Singleton

| Flyweight | Singleton |
|-----------|-----------|
| Many shared objects | One shared object |
| Saves memory | Restricts instance count |

---

# 12. Flyweight vs Prototype

| Flyweight | Prototype |
|-----------|-----------|
| Shares objects | Clones objects |
| Reuses existing instances | Creates copies |

---

# 13. Best Practices

- Store only immutable intrinsic state.
- Pass extrinsic state from the client.
- Use a factory to manage flyweights.
- Apply only when many similar objects exist.

---

# 14. Interview Questions

1. What problem does the Flyweight pattern solve?
2. Intrinsic vs extrinsic state?
3. Why use a Flyweight Factory?
4. When should Flyweight be avoided?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Flyweight Pattern

✔ Shared Objects
✔ Memory Optimization
✔ Intrinsic State
✔ Extrinsic State

Flow

Client
  │
Factory
  │
Shared Flyweights
```

---

# 16. Summary

The Flyweight pattern reduces memory consumption by sharing common object state across many similar objects. By separating intrinsic and extrinsic state and managing shared instances through a factory, it enables efficient, scalable applications that handle large numbers of objects.
