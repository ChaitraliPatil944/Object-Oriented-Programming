# Lesson 118 — Immutable Objects

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **immutable object** is an object whose state cannot be changed after it is created.

Once initialized, its fields remain constant for the object's entire lifetime.

Immutability is a fundamental concept in Java because immutable objects are naturally thread-safe, easier to reason about, and less prone to bugs.

---

# 2. Why Use Immutable Objects?

Benefits include:

- Thread safety without synchronization
- Predictable behavior
- Easier debugging
- Safe sharing between threads
- Improved reliability

Example: `String` in Java is immutable.

```java
String s = "Hello";
s.concat(" World");

System.out.println(s);
```

Output:

```text
Hello
```

A new object is created instead of modifying the original.

---

# 3. Characteristics of an Immutable Class

An immutable class should:

- Be declared `final` (recommended)
- Have `private final` fields
- Initialize fields through a constructor
- Provide no setter methods
- Defensively copy mutable objects when necessary

---

# 4. Creating an Immutable Class

```java
public final class Employee {

    private final int id;
    private final String name;

    public Employee(int id, String name) {
        this.id = id;
        this.name = name;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }
}
```

The object's state cannot be modified after construction.

---

# 5. Defensive Copying

If an immutable class contains mutable objects, return copies instead of references.

```java
private final Date joiningDate;

public Date getJoiningDate() {
    return new Date(joiningDate.getTime());
}
```

This prevents external code from modifying internal state.

---

# 6. Immutable vs Mutable Objects

| Immutable | Mutable |
|-----------|---------|
| State cannot change | State can change |
| Thread-safe | Requires synchronization |
| No setters | Usually has setters |
| Easier to share | Careful sharing required |

---

# 7. Common Immutable Classes

Examples in Java:

- `String`
- `Integer`
- `Long`
- `Double`
- `LocalDate`
- `LocalDateTime`
- `BigInteger`
- `BigDecimal`

---

# 8. Advantages

- Naturally thread-safe
- No race conditions
- Easier caching
- Reliable hashing
- Simpler program design

---

# 9. Disadvantages

- More object creation
- Higher memory usage in some cases
- Less suitable when frequent updates are required

---

# 10. Best Practices

- Prefer immutability for value objects.
- Mark fields as `private final`.
- Avoid setter methods.
- Perform defensive copying for mutable fields.
- Use immutable collections where appropriate.

---

# 11. Common Mistakes

❌ Returning mutable internal objects directly.

❌ Providing setter methods.

❌ Forgetting to declare fields `final`.

❌ Allowing subclassing that can modify state.

---

# 12. Interview Questions

1. What is an immutable object?
2. Why is `String` immutable?
3. How do you create an immutable class?
4. Why are immutable objects thread-safe?
5. What is defensive copying?

---

# 13. Quick Revision

```text
Immutable Object
│
├── State Never Changes
├── No Setters
├── final Fields
├── Constructor Initialization
└── Thread Safe
```

---

# 14. Interview Cheat Sheet

```text
Immutable Class

✔ final Class
✔ private final Fields
✔ Constructor Initialization
✔ Getters Only
✔ Defensive Copying

Benefits

Thread Safe
Reliable
Easy to Share
```

---

# 15. Summary

Immutable objects cannot be modified after they are created, making them inherently thread-safe and highly reliable in concurrent applications. By using `final` fields, constructor initialization, no setters, and defensive copying for mutable members, developers can create robust classes that simplify program design and reduce concurrency-related bugs.
