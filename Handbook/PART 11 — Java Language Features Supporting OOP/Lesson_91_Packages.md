# Lesson 91 — Packages

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **package** in Java is a namespace that groups related classes, interfaces, enums, records, and sub-packages together.

Packages help organize code, avoid naming conflicts, improve security, and make large applications easier to maintain.

Examples from the Java Standard Library:

- `java.lang`
- `java.util`
- `java.io`
- `java.time`
- `java.sql`

---

# 2. Why Do We Need Packages?

Without packages:

```text
Student
Employee
Manager
Utility
```

Large projects become difficult to organize.

With packages:

```text
com.company.app
│
├── controller
├── service
├── repository
├── model
└── util
```

Each package contains related components.

---

# 3. Types of Packages

## Built-in Packages

Provided by Java.

Examples:

- `java.lang`
- `java.util`
- `java.io`
- `java.net`

## User-Defined Packages

Created by developers.

Example:

```java
package com.company.student;
```

---

# 4. Creating a Package

```java
package com.company.student;

public class Student {

    public void display() {
        System.out.println("Student Package");
    }
}
```

The package declaration must be the first non-comment statement.

---

# 5. Importing Packages

Import a specific class:

```java
import java.util.ArrayList;
```

Import all classes:

```java
import java.util.*;
```

Use the class:

```java
ArrayList<String> list = new ArrayList<>();
```

---

# 6. Fully Qualified Class Name

Instead of importing:

```java
java.util.ArrayList<String> list =
        new java.util.ArrayList<>();
```

This is called the **Fully Qualified Name (FQN)**.

---

# 7. Package Naming Conventions

Reverse domain names are commonly used.

Examples:

```text
com.google.maps
org.apache.commons
in.college.project
```

Benefits:

- Globally unique names
- Better organization
- Enterprise standard

---

# 8. Access Across Packages

Access depends on Java access modifiers.

| Modifier | Same Package | Different Package |
|----------|--------------|-------------------|
| public | ✔ | ✔ |
| protected | ✔ | ✔ (through inheritance) |
| default | ✔ | ✘ |
| private | ✘ | ✘ |

---

# 9. Advantages

- Better organization
- Avoids class name conflicts
- Improves code reuse
- Easier maintenance
- Supports access control

---

# 10. Best Practices

- Follow reverse domain naming.
- Keep related classes together.
- Avoid very large packages.
- Use meaningful package names.

---

# 11. Common Mistakes

❌ Using the default package for large projects.

❌ Creating unrelated classes in one package.

❌ Using wildcard imports unnecessarily.

---

# 12. Interview Questions

1. What is a package in Java?
2. Why are packages used?
3. Difference between built-in and user-defined packages?
4. What is a fully qualified class name?
5. Explain package naming conventions.

---

# 13. Quick Revision

```text
Packages
│
├── Built-in
├── User-defined
├── Import
├── Namespace
└── Access Control
```

---

# 14. Interview Cheat Sheet

```text
Package
│
├── Organizes Classes
├── Prevents Naming Conflicts
├── import Keyword
├── Reverse Domain Naming
└── Supports Access Modifiers
```

---

# 15. Summary

Packages provide a structured way to organize Java applications by grouping related classes and interfaces into namespaces. They improve maintainability, reduce naming conflicts, enforce access control, and make enterprise applications easier to develop and scale. Proper package design is a fundamental practice in professional Java development.
