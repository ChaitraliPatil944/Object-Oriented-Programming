# Lesson 85 — Final Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **final** keyword in Java is used to **restrict modification**. It helps create constants, prevent method overriding, and stop class inheritance.

The `final` keyword can be applied to:

- Variables
- Methods
- Classes
- Parameters

It **cannot** be applied to constructors.

---

# 2. Why Do We Need Final?

Sometimes certain values or behaviors should never change.

Examples:

- Mathematical constants (`PI`)
- Security-related methods
- Immutable classes
- Utility classes

The `final` keyword enforces these restrictions at compile time.

---

# 3. Final Variable

A **final variable** can be assigned only once.

### Example

```java
class Circle {

    final double PI = 3.14159;

    void display() {
        System.out.println(PI);
    }
}
```

Trying to modify it:

```java
PI = 3.14;
```

Produces a compilation error.

---

# 4. Blank Final Variable

A blank final variable is declared without initialization but must be initialized exactly once.

### Example

```java
class Student {

    final int rollNo;

    Student(int rollNo) {
        this.rollNo = rollNo;
    }
}
```

---

# 5. Final Reference Variable

A final reference cannot point to another object, but the object's internal state may still change.

### Example

```java
class Employee {

    String name;
}

public class Demo {

    public static void main(String[] args) {

        final Employee emp = new Employee();

        emp.name = "Alice";     // Allowed

        // emp = new Employee(); // Error
    }
}
```

---

# 6. Final Method

A **final method** cannot be overridden by subclasses.

### Example

```java
class Animal {

    final void sound() {
        System.out.println("Animal Sound");
    }
}

class Dog extends Animal {

    // void sound() { }   // Compilation Error
}
```

Use final methods to preserve important behavior.

---

# 7. Final Class

A **final class** cannot be inherited.

### Example

```java
final class Utility {

    void display() {
        System.out.println("Utility Class");
    }
}

// class Demo extends Utility { } // Error
```

Examples from Java:

- `String`
- `Math`
- `System`

---

# 8. Final Parameter

A final parameter cannot be reassigned inside a method.

### Example

```java
void display(final int number) {

    // number = 20; // Error

    System.out.println(number);
}
```

---

# 9. Final vs Finally vs Finalize

| Keyword | Purpose |
|----------|---------|
| final | Restricts modification |
| finally | Executes after try-catch |
| finalize() | Garbage collection method (deprecated) |

These are unrelated concepts despite similar names.

---

# 10. Advantages

- Creates constants
- Prevents accidental modification
- Improves code safety
- Supports immutable classes
- Protects important methods

---

# 11. Best Practices

- Use `public static final` for constants.
- Mark utility classes as final.
- Use final methods when behavior must remain unchanged.
- Prefer immutable objects when possible.

---

# 12. Common Mistakes

❌ Assuming final objects are completely immutable.

❌ Confusing `final` with `finally`.

❌ Overusing final on every variable without reason.

---

# 13. Interview Questions

1. What is the final keyword?
2. Can a final variable be modified?
3. Can a final method be overridden?
4. Why is String a final class?
5. Difference between final, finally, and finalize()?

---

# 14. Quick Revision

```text
final
│
├── Variable
├── Method
├── Class
└── Parameter
```

---

# 15. Interview Cheat Sheet

```text
final Variable
✔ Assigned Once

final Method
✔ Cannot Override

final Class
✔ Cannot Extend

final Reference
✔ Reference Fixed
✔ Object Can Change
```

---

# 16. Summary

The `final` keyword is used to prevent unwanted modification in Java programs. It can create constants, stop method overriding, and prevent inheritance, making applications safer, more predictable, and easier to maintain. It is a key language feature for designing immutable objects and enforcing stable APIs in enterprise applications.
