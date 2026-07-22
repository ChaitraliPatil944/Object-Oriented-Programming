# Lesson 89 — Record Classes

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Record Classes** are a special type of class introduced in **Java 16** (preview in Java 14) to simplify the creation of immutable data objects.

A record automatically provides:

- Private final fields
- Constructor
- Getter methods (called accessors)
- `equals()`
- `hashCode()`
- `toString()`

Records are ideal for classes whose primary purpose is to store data.

---

# 2. Why Do We Need Records?

Before records, creating a simple data class required a lot of boilerplate code.

Example (Traditional Class):

```java
class Student {

    private final int id;
    private final String name;

    Student(int id, String name) {
        this.id = id;
        this.name = name;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    // equals()
    // hashCode()
    // toString()
}
```

With records:

```java
record Student(int id, String name) { }
```

Same functionality with one line.

---

# 3. Declaring a Record

```java
record Employee(int id, String name, double salary) { }
```

Usage:

```java
Employee emp = new Employee(101, "Alice", 50000);

System.out.println(emp.id());
System.out.println(emp.name());
System.out.println(emp.salary());
```

Output:

```text
101
Alice
50000.0
```

Notice that records use **accessor methods** like `id()` instead of `getId()`.

---

# 4. Generated Members

For every record, Java automatically generates:

```text
Fields
Constructor
Accessor Methods
equals()
hashCode()
toString()
```

Example output of `toString()`:

```text
Employee[id=101, name=Alice, salary=50000.0]
```

---

# 5. Custom Methods in Records

Records can contain additional methods.

```java
record Rectangle(double length, double width) {

    double area() {
        return length * width;
    }
}
```

Usage:

```java
Rectangle r = new Rectangle(10, 5);
System.out.println(r.area());
```

Output:

```text
50.0
```

---

# 6. Compact Constructor

A record can define a compact constructor for validation.

```java
record Student(int id, String name) {

    Student {
        if (id <= 0) {
            throw new IllegalArgumentException("Invalid ID");
        }
    }
}
```

Java automatically assigns the fields after validation.

---

# 7. Restrictions of Records

Records:

- Cannot extend another class.
- Are implicitly `final`.
- Cannot declare mutable instance fields.
- Can implement interfaces.
- Can have static fields and methods.

---

# 8. Record vs Traditional Class

| Feature | Record | Class |
|---------|--------|-------|
| Boilerplate | Minimal | More |
| Immutable | Yes | Optional |
| Inheritance | Cannot extend classes | Can extend |
| Accessors | Generated | Manual |
| equals()/hashCode() | Generated | Manual |

---

# 9. Advantages

- Less boilerplate code
- Immutable by default
- Better readability
- Safer data objects
- Easier maintenance

---

# 10. Best Practices

- Use records for DTOs and value objects.
- Keep records immutable.
- Add behavior only when it logically belongs to the data.
- Use compact constructors for validation.

---

# 11. Common Mistakes

❌ Expecting records to support inheritance.

❌ Trying to modify record fields.

❌ Using records for classes with complex mutable state.

---

# 12. Interview Questions

1. What is a record in Java?
2. Why were records introduced?
3. Are records immutable?
4. Can records extend other classes?
5. What methods are automatically generated?

---

# 13. Quick Revision

```text
Record
│
├── Immutable
├── Constructor
├── Accessors
├── equals()
├── hashCode()
└── toString()
```

---

# 14. Interview Cheat Sheet

```text
record Employee(int id, String name)

✔ Immutable
✔ Less Boilerplate
✔ Auto Constructor
✔ Auto Accessors
✔ Auto equals/hashCode/toString
```

---

# 15. Summary

Record classes provide a concise way to define immutable data carriers in Java. By automatically generating constructors, accessors, and common utility methods, records eliminate repetitive boilerplate code while improving readability and maintainability. They are widely used in modern Java applications for DTOs, API responses, configuration objects, and other value-based data structures.
