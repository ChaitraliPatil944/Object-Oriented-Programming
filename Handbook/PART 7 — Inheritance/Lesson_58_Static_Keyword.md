# Lesson 58 — `static` Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **`static`** keyword belongs to the **class**, not to individual objects.

A static member is shared by all instances of the class, making it useful for common data and utility functionality.

`static` can be applied to:

- Variables
- Methods
- Blocks
- Nested classes

---

# 2. Static Variable

A static variable has only **one copy** shared among all objects.

```java
class Employee {

    static String company = "OpenAI";
    String name;
}
```

All `Employee` objects share the same `company`.

---

# 3. Static Method

A static method belongs to the class and can be called without creating an object.

```java
class MathUtil {

    static int square(int x) {
        return x * x;
    }
}

System.out.println(MathUtil.square(5));
```

Static methods cannot directly access non-static instance members.

---

# 4. Static Block

A static block executes **once** when the class is loaded.

```java
class Demo {

    static {
        System.out.println("Class Loaded");
    }
}
```

It is commonly used for static initialization.

---

# 5. Static Nested Class

```java
class Outer {

    static class Inner {

        void display() {
            System.out.println("Inside Static Nested Class");
        }
    }
}
```

A static nested class does not require an instance of the outer class.

---

# 6. Memory Representation

```text
           Class Area
      ┌─────────────────┐
      │ static variables│
      │ static methods  │
      └─────────────────┘

           Heap
      ┌───────────────┐
      │ Object 1      │
      │ Object 2      │
      │ Object 3      │
      └───────────────┘
```

Static members are associated with the class, while instance data belongs to objects.

---

# 7. `static` vs Instance Members

| Static | Instance |
|--------|----------|
| Belongs to class | Belongs to object |
| One shared copy | Separate copy per object |
| Access via class name | Access via object |
| Loaded once | Created with each object |

---

# 8. Enterprise Example

```java
class DatabaseConfig {

    static final String URL = "jdbc:mysql://localhost:3306/app";
}
```

Configuration values are shared across the entire application.

---

# 9. Best Practices

- Use static for utility methods.
- Store constants as `public static final`.
- Avoid unnecessary static variables.
- Prefer class name when calling static methods.

---

# 10. Common Mistakes

❌ Accessing instance variables directly inside static methods.

❌ Treating static data as object-specific.

❌ Calling static methods through objects instead of the class name.

---

# 11. Interview Questions

1. What is the `static` keyword?
2. Why can't static methods access instance variables directly?
3. What is a static block?
4. When is a static block executed?
5. Difference between static and instance members?

---

# 12. Quick Revision

```text
static
│
├── Variable → Shared by all objects
├── Method → Called using class name
├── Block → Runs once at class loading
├── Nested Class → Independent of outer object
└── Belongs to class, not object
```

---

# 13. Summary

The `static` keyword allows Java developers to create members that belong to the class instead of individual objects. It reduces memory usage for shared data, supports utility methods, and simplifies application-wide configuration. Understanding `static` is essential for writing efficient, scalable, and interview-ready Java programs.
