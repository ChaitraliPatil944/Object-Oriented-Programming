# Lesson 149 — Visitor Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Visitor Pattern** is a behavioral design pattern that lets you **add new operations to existing object structures without modifying their classes**.

It separates algorithms from the objects on which they operate.

---

# 2. Problem

Suppose a company has different employee types.

```text
Employee
├── Manager
├── Developer
└── Tester
```

Adding operations like salary calculation, tax calculation, and report generation requires changing every class.

---

# 3. Solution

Move operations into visitor classes.

```text
Elements
   │
accept(visitor)
   │
Visitor
├── SalaryVisitor
├── TaxVisitor
└── ReportVisitor
```

---

# 4. Participants

- Visitor
- Concrete Visitor
- Element
- Concrete Element
- Object Structure

---

# 5. Structure

```text
Client
  │
Visitor
  │
Elements
```

---

# 6. Example

### Visitor

```java
interface Visitor{
    void visit(Book book);
}
```

### Element

```java
interface Item{
    void accept(Visitor visitor);
}
```

### Concrete Element

```java
class Book implements Item{

    public void accept(Visitor visitor){
        visitor.visit(this);
    }
}
```

### Concrete Visitor

```java
class PriceVisitor implements Visitor{

    public void visit(Book book){
        System.out.println("Calculating Price");
    }
}
```

### Client

```java
Item item=new Book();
Visitor visitor=new PriceVisitor();

item.accept(visitor);
```

---

# 7. How It Works

```text
Client
  │
Visitor
  │
accept()
  │
Element
```

The element calls the appropriate visitor method, enabling double dispatch.

---

# 8. Advantages

- Adds new operations easily
- Keeps element classes stable
- Improves separation of concerns
- Groups related operations together

---

# 9. Disadvantages

- Difficult to add new element types
- Requires updating every visitor when elements change
- Can be complex for small systems

Because adding one new object type means every visitor suddenly develops extra homework.

---

# 10. Real-World Uses

- Compiler syntax trees
- File system traversal
- Document processing
- AST manipulation
- Code analysis tools

---

# 11. Visitor vs Strategy

| Visitor | Strategy |
|---------|----------|
| Adds operations | Changes algorithms |
| Operates on object structures | Chooses one behavior |

---

# 12. Visitor vs Command

| Visitor | Command |
|---------|---------|
| Performs operations on elements | Encapsulates requests |
| Traverses structures | Executes actions |

---

# 13. Best Practices

- Use when object structure is stable.
- Keep visitors focused on one responsibility.
- Avoid Visitor if new element classes are added frequently.
- Use interfaces consistently.

---

# 14. Interview Questions

1. What problem does the Visitor pattern solve?
2. What is double dispatch?
3. Visitor vs Strategy?
4. When should Visitor be avoided?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Visitor Pattern

✔ Separate Operations
✔ Stable Object Structure
✔ Double Dispatch
✔ Easy New Operations

Flow

Visitor
  │
accept()
  │
Element
```

---

# 16. Summary

The Visitor pattern separates operations from object structures by moving related algorithms into visitor classes. It is ideal when the object hierarchy remains stable but new operations need to be added frequently, improving extensibility and separation of concerns.
