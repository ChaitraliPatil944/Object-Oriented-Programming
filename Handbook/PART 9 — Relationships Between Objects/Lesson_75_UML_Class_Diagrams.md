# Lesson 75 — UML Class Diagrams

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**UML (Unified Modeling Language)** is a standard visual language used to model, design, and document software systems.

Among all UML diagrams, the **Class Diagram** is the most widely used because it represents the static structure of an Object-Oriented system.

---

# 2. What is a UML Class Diagram?

A UML Class Diagram shows:

- Classes
- Attributes (Data Members)
- Methods (Member Functions)
- Relationships between classes

It provides a blueprint of the application's design before coding.

---

# 3. Structure of a Class

```text
+----------------------+
|       Student        |
+----------------------+
| - id : int           |
| - name : String      |
+----------------------+
| + display() : void   |
| + study() : void     |
+----------------------+
```

Sections:

1. Class Name
2. Attributes
3. Methods

---

# 4. Visibility Symbols

| Symbol | Visibility |
|--------|------------|
| + | Public |
| - | Private |
| # | Protected |
| ~ | Package (Default) |

Example:

```text
- name : String
+ getName() : String
```

---

# 5. Relationships in UML

### Association

```text
Student -------- Teacher
```

### Aggregation

```text
Department ◇------ Employee
```

### Composition

```text
House ◆------ Room
```

### Inheritance

```text
      Animal
         ▲
         │
        Dog
```

### Dependency

```text
Report - - - - > Printer
```

---

# 6. Enterprise Example

```text
+----------------+
| OrderService   |
+----------------+
| - payment      |
+----------------+
| + placeOrder() |
+----------------+
        |
        | uses
        v
+----------------+
| PaymentService |
+----------------+
| + process()    |
+----------------+
```

This diagram shows collaboration between service classes.

---

# 7. Advantages

- Better software visualization
- Easier communication
- Simplifies system design
- Helps documentation
- Improves maintainability

---

# 8. Best Practices

- Keep diagrams simple.
- Use meaningful class names.
- Show only important relationships.
- Avoid clutter.

---

# 9. Common Mistakes

❌ Mixing implementation details with design.

❌ Overcrowding one diagram.

❌ Incorrect relationship symbols.

---

# 10. Interview Questions

1. What is UML?
2. What is a Class Diagram?
3. What are the three sections of a class?
4. Explain UML visibility symbols.
5. Differentiate association, aggregation, composition, inheritance, and dependency in UML.

---

# 11. Quick Revision

```text
UML Class Diagram
│
├── Class Name
├── Attributes
├── Methods
└── Relationships
    ├── Association
    ├── Aggregation
    ├── Composition
    ├── Inheritance
    └── Dependency
```

---

# 12. Summary

UML Class Diagrams provide a visual representation of the static structure of object-oriented systems. They describe classes, attributes, methods, and relationships, making them invaluable for software design, communication, documentation, and enterprise application development.
