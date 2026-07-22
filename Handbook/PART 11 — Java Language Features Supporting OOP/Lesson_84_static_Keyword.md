# Lesson 84 — Static Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **static** keyword in Java is used to create members that belong to the **class itself rather than individual objects**.

Normally, every object gets its own copy of instance variables. A static member is shared among all objects of the class.

The `static` keyword can be applied to:

- Variables
- Methods
- Blocks
- Nested Classes

It **cannot** be applied to local variables or top-level classes.

---

# 2. Why Do We Need Static?

Without `static`, every object stores its own copy of a variable.

Example:

```text
Student 1 → college = MIT
Student 2 → college = MIT
Student 3 → college = MIT
```

This wastes memory.

With `static`:

```text
Student Class
     │
college = MIT
     │
 ┌───┼────┐
 ▼   ▼    ▼
S1   S2   S3
```

Only one copy exists and is shared.

---

# 3. Static Variable

A **static variable** belongs to the class and is shared by all objects.

### Example

```java
class Student {

    int rollNo;
    String name;

    static String college = "MIT";

    Student(int rollNo, String name) {
        this.rollNo = rollNo;
        this.name = name;
    }

    void display() {
        System.out.println(rollNo + " " + name + " " + college);
    }
}
```

Output:

```text
1 Alice MIT
2 Bob MIT
```

---

# 4. Static Method

A **static method** belongs to the class instead of an object.

It can be called using the class name.

### Example

```java
class MathUtil {

    static int square(int x) {
        return x * x;
    }

    public static void main(String[] args) {
        System.out.println(MathUtil.square(5));
    }
}
```

Output:

```text
25
```

### Rules

Static methods:

- Can access only static members directly.
- Cannot access instance variables directly.
- Cannot use `this`.
- Cannot use `super`.

---

# 5. Static Block

A **static block** executes **only once** when the class is loaded into memory.

It is commonly used for static initialization.

### Example

```java
class Demo {

    static {
        System.out.println("Static Block Executed");
    }

    public static void main(String[] args) {
        System.out.println("Main Method");
    }
}
```

Output:

```text
Static Block Executed
Main Method
```

---

# 6. Static Nested Class

A static nested class does not require an object of the outer class.

### Example

```java
class Outer {

    static class Inner {

        void show() {
            System.out.println("Inside Static Nested Class");
        }
    }
}

public class Test {

    public static void main(String[] args) {

        Outer.Inner obj = new Outer.Inner();
        obj.show();
    }
}
```

---

# 7. Static vs Instance Members

| Feature | Static | Instance |
|---------|--------|----------|
| Belongs To | Class | Object |
| Memory | One Copy | One Per Object |
| Access | Class Name | Object |
| Shared | Yes | No |
| Uses `this` | No | Yes |

---

# 8. Advantages

- Saves memory
- Faster access
- Shared data
- Utility methods
- Global constants

---

# 9. Best Practices

- Use static for utility methods.
- Keep constants as `public static final`.
- Avoid excessive use of static variables.
- Do not store object-specific data in static fields.

---

# 10. Common Mistakes

❌ Accessing instance variables directly inside static methods.

❌ Using `this` in static methods.

❌ Misusing static variables as global mutable state.

---

# 11. Interview Questions

1. What is the static keyword?
2. Difference between static and instance variables?
3. Can static methods access instance variables?
4. What is a static block?
5. Why is the `main()` method static?

---

# 12. Quick Revision

```text
static
│
├── Variable
├── Method
├── Block
├── Nested Class
└── Shared Across Objects
```

---

# 13. Interview Cheat Sheet

```text
Static
│
├── Belongs to Class
├── Shared Memory
├── Access using Class Name
├── Cannot use this/super
└── Executes Once (Static Block)
```

---

# 14. Summary

The `static` keyword allows Java developers to create class-level variables, methods, initialization blocks, and nested classes that are shared across all objects. It improves memory efficiency, supports utility functionality, and is widely used for constants, helper methods, and framework initialization. Understanding when to use `static` is essential for writing clean and efficient Java programs.
