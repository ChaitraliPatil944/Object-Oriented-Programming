# Lesson 138 — Composite Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Composite Pattern** is a structural design pattern that lets you treat **individual objects and groups of objects uniformly**.

It is ideal for representing **tree-like hierarchies** such as file systems, organization charts, and UI components.

---

# 2. Problem

Without Composite, client code must distinguish between single objects and collections.

```text
File
Folder
File
Folder
```

Different handling increases complexity.

---

# 3. Solution

Represent both leaf objects and containers through a common interface.

```text
Component
   │
 ├── Leaf
 └── Composite
```

The client interacts only with `Component`.

---

# 4. Participants

- Component
- Leaf
- Composite
- Client

---

# 5. Example Structure

```text
FileSystemItem
      │
 ├── File
 └── Folder
        ├── File
        └── Folder
```

---

# 6. Example

### Component

```java
interface FileSystemItem {
    void display();
}
```

### Leaf

```java
class File implements FileSystemItem {

    public void display() {
        System.out.println("File");
    }
}
```

### Composite

```java
class Folder implements FileSystemItem {

    private List<FileSystemItem> items =
            new ArrayList<>();

    public void add(FileSystemItem item) {
        items.add(item);
    }

    public void display() {
        System.out.println("Folder");
        for (FileSystemItem item : items) {
            item.display();
        }
    }
}
```

---

# 7. How It Works

```text
Client
   │
Component
   │
 ├── File
 └── Folder
        ├── File
        └── Folder
```

Recursive composition enables nested structures.

---

# 8. Advantages

- Uniform treatment of objects
- Simplifies client code
- Easy to add new component types
- Supports recursive hierarchies

---

# 9. Disadvantages

- Can make overly generic interfaces
- Harder to restrict valid child types

---

# 10. Real-World Uses

- File systems
- GUI component trees
- Organization charts
- XML/HTML DOM
- Menu systems

Because humans insist that folders contain folders, which contain folders, until nobody remembers where the document actually lives.

---

# 11. Composite vs Decorator

| Composite | Decorator |
|-----------|-----------|
| Represents part-whole hierarchies | Adds responsibilities |
| Tree structure | Wrapper structure |

---

# 12. Composite vs Bridge

| Composite | Bridge |
|-----------|--------|
| Builds hierarchies | Separates abstraction and implementation |

---

# 13. Best Practices

- Keep the component interface simple.
- Use recursion for tree traversal.
- Prefer composition for hierarchical data.
- Avoid exposing unnecessary child operations to leaf nodes.

---

# 14. Interview Questions

1. What problem does the Composite pattern solve?
2. When should Composite be used?
3. Composite vs Decorator?
4. Give real-world examples.
5. Why is recursion common in Composite?

---

# 15. Quick Revision

```text
Composite Pattern

✔ Tree Structures
✔ Uniform Interface
✔ Leaf + Composite
✔ Recursive Design

Flow

Client
  │
Component
  │
Leaf / Composite
```

---

# 16. Summary

The Composite pattern allows clients to work with individual objects and object hierarchies through a common interface. It is particularly useful for tree-like structures, providing a clean, recursive design that improves flexibility, code reuse, and maintainability.
