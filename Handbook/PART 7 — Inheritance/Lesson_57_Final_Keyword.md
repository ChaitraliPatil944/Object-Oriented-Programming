# Lesson 57 — `final` Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **`final`** keyword in Java is used to restrict modification.

It can be applied to:

- Variables
- Methods
- Classes

Its purpose is to improve safety, prevent unwanted changes, and make program behavior more predictable.

---

# 2. `final` Variable

A `final` variable can be assigned **only once**.

```java
final int MAX_USERS = 100;

// MAX_USERS = 200; // Compile-time error
```

Once initialized, its value cannot be changed.

---

# 3. Blank Final Variable

A blank final variable is declared without initialization but must be initialized exactly once.

```java
class Student {

    final int id;

    Student(int id) {
        this.id = id;
    }
}
```

---

# 4. `final` Method

A `final` method **cannot be overridden** by subclasses.

```java
class Animal {

    final void sleep() {
        System.out.println("Sleeping");
    }
}

class Dog extends Animal {

    // void sleep() {} // Error
}
```

This protects important behavior from modification.

---

# 5. `final` Class

A `final` class cannot be inherited.

```java
final class Utility {

}

// class Helper extends Utility {} // Error
```

Examples from Java:

- `String`
- `Math`
- `Integer`

---

# 6. Why Use `final`?

Benefits include:

- Prevent accidental modification
- Improve code safety
- Protect critical methods
- Design immutable classes
- Encourage predictable behavior

---

# 7. `final` vs `finally` vs `finalize()`

| Keyword | Purpose |
|---------|---------|
| `final` | Restricts modification |
| `finally` | Executes cleanup code in exception handling |
| `finalize()` | Legacy garbage collection callback (deprecated) |

These three are unrelated despite their similar names.

---

# 8. Enterprise Example

```java
final class Configuration {

    public static final String APP_NAME = "InventorySystem";
}
```

Configuration constants remain unchanged throughout the application.

---

# 9. Best Practices

- Use `final` for constants.
- Mark methods `final` when overriding should be prevented.
- Use `final` classes for immutable designs.
- Prefer meaningful constant names in uppercase.

---

# 10. Common Mistakes

❌ Thinking `final` makes an object immutable.

❌ Confusing `final` with `finally`.

❌ Trying to override a final method.

❌ Trying to extend a final class.

---

# 11. Interview Questions

1. What is the `final` keyword?
2. Where can `final` be used?
3. Can a final variable be initialized in a constructor?
4. Can a final method be overridden?
5. Why is `String` a final class?

---

# 12. Quick Revision

```text
final
│
├── Variable → Value cannot change
├── Method → Cannot be overridden
├── Class → Cannot be inherited
└── Improves safety and predictability
```

---

# 13. Summary

The `final` keyword is a fundamental feature in Java used to prevent modification of variables, methods, and classes. It promotes safer, more maintainable code and plays an important role in designing constants, immutable classes, and secure APIs.
