# Lesson 39 — Immutable Objects

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

An **immutable object** is an object whose state **cannot be changed after it is created**.

Once an immutable object is initialized, its data remains constant throughout its lifetime.

The `String` class is the most common example of an immutable class in Java.

---

# 2. Why Immutability?

Immutable objects provide several advantages:

- Thread safety
- Better security
- Easier debugging
- Predictable behavior
- Safe object sharing
- Reliable hash codes

Because their state never changes, multiple references can safely use the same object.

---

# 3. Characteristics of an Immutable Class

A well-designed immutable class typically:

- Is declared `final`
- Has all fields `private` and `final`
- Initializes fields through a constructor
- Does not provide setters
- Returns defensive copies for mutable fields

---

# 4. Basic Example

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

# 5. Why No Setters?

Adding a setter breaks immutability.

```java
public void setName(String name){
    this.name = name;
}
```

The above method allows state changes and therefore makes the object mutable.

---

# 6. Mutable vs Immutable

| Mutable Object | Immutable Object |
|----------------|------------------|
| State can change | State never changes |
| Has setters | No setters |
| Harder to share safely | Safe to share |
| Requires synchronization | Naturally thread-safe |

---

# 7. Defensive Copying

If an immutable class contains mutable objects, return copies instead of the original.

```java
public Date getJoiningDate() {
    return new Date(joiningDate.getTime());
}
```

This prevents callers from modifying the internal state indirectly.

---

# 8. String Immutability

```java
String s = "Java";
s = s + " Programming";
```

The original String remains unchanged.

A new String object is created.

```text
"Java"
   │
   └── remains unchanged

"Java Programming"
   │
   └── new object
```

---

# 9. Enterprise Example

```java
public final class Money {

    private final double amount;

    public Money(double amount) {
        this.amount = amount;
    }

    public double getAmount() {
        return amount;
    }
}
```

Financial values are often represented as immutable objects to avoid accidental modification.

---

# 10. Benefits

- Thread-safe without synchronization
- Easier caching
- Safe sharing
- Improved reliability
- Simpler testing
- Reduced side effects

---

# 11. Common Mistakes

❌ Forgetting to declare fields `final`.

❌ Returning mutable internal objects directly.

❌ Providing setters.

❌ Allowing subclasses to modify state.

---

# 12. Best Practices

- Prefer immutability whenever possible.
- Keep fields `private final`.
- Initialize all fields in constructors.
- Avoid setters.
- Use defensive copies for mutable members.

---

# 13. Interview Questions

1. What is an immutable object?
2. Why is `String` immutable?
3. How do you create an immutable class?
4. Why are immutable objects thread-safe?
5. What is defensive copying?
6. Why should immutable classes often be `final`?

---

# 14. Summary

Immutable objects cannot be modified after creation. By keeping fields private and final, initializing them through constructors, avoiding setters, and using defensive copies where necessary, developers create objects that are safe, predictable, and easy to use. Immutability is widely adopted in enterprise Java applications because it improves reliability, simplifies concurrency, and reduces bugs caused by unintended state changes.
