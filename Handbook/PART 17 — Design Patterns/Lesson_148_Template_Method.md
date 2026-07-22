# Lesson 148 — Template Method Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Template Method Pattern** is a behavioral design pattern that **defines the skeleton of an algorithm in a base class while allowing subclasses to override specific steps** without changing the overall algorithm.

It promotes code reuse by keeping common logic in one place.

---

# 2. Problem

Suppose an application generates different reports.

Each report follows the same process:

```text
Read Data
Process Data
Generate Output
```

Only the processing step differs.

Without the Template Method pattern, duplicate code appears across multiple classes.

---

# 3. Solution

Move the common algorithm into an abstract class and allow subclasses to customize selected steps.

```text
Abstract Class
      │
  Template Method
      │
 ├── Step 1
 ├── Step 2 (Overridable)
 └── Step 3
```

---

# 4. Participants

- Abstract Class
- Template Method
- Primitive Operations
- Concrete Subclasses

---

# 5. Structure

```text
Client
   │
Abstract Class
   │
Template Method
   │
Concrete Class
```

---

# 6. Example

### Abstract Class

```java
abstract class DataProcessor {

    final void process() {
        readData();
        analyzeData();
        saveResult();
    }

    void readData() {
        System.out.println("Reading Data");
    }

    abstract void analyzeData();

    void saveResult() {
        System.out.println("Saving Result");
    }
}
```

### Concrete Class

```java
class SalesProcessor extends DataProcessor {

    void analyzeData() {
        System.out.println("Analyzing Sales Data");
    }
}
```

### Client

```java
DataProcessor processor =
        new SalesProcessor();

processor.process();
```

---

# 7. How It Works

```text
Template Method
      │
Read
      │
Analyze (Subclass)
      │
Save
```

The algorithm order remains fixed while selected steps vary.

---

# 8. Advantages

- Eliminates duplicate code
- Encourages code reuse
- Enforces algorithm structure
- Easy to extend

---

# 9. Disadvantages

- Relies on inheritance
- Changes to the template affect all subclasses
- Deep hierarchies can become difficult to manage

Because sometimes the only thing every subclass agrees on is the order of operations.

---

# 10. Real-World Uses

- Java Collections Framework
- Servlet lifecycle methods
- Spring framework
- File processing systems
- Data import/export workflows

---

# 11. Template Method vs Strategy

| Template Method | Strategy |
|-----------------|----------|
| Uses inheritance | Uses composition |
| Algorithm skeleton fixed | Algorithm selected dynamically |

---

# 12. Template Method vs Factory Method

| Template Method | Factory Method |
|-----------------|----------------|
| Defines an algorithm | Creates objects |
| Focuses on workflow | Focuses on instantiation |

---

# 13. Best Practices

- Keep the template method `final` when appropriate.
- Override only the required steps.
- Avoid placing too much logic in subclasses.
- Use hooks for optional behavior.

---

# 14. Interview Questions

1. What problem does the Template Method pattern solve?
2. Template Method vs Strategy?
3. Why is the template method often declared `final`?
4. What are hook methods?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Template Method Pattern

✔ Algorithm Skeleton
✔ Code Reuse
✔ Inheritance
✔ Customizable Steps

Flow

Template Method
      │
Common Steps
      │
Overridden Step
```

---

# 16. Summary

The Template Method pattern defines the overall structure of an algorithm in a base class while allowing subclasses to customize specific steps. It promotes consistency, reduces duplicate code, and is ideal when multiple classes share the same workflow with small variations.
