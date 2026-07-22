# Lesson 92 — Modules (Java Platform Module System - JPMS)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Java Platform Module System (JPMS)**, commonly called **Modules**, was introduced in **Java 9** through **Project Jigsaw**.

A **module** is a higher-level unit of organization than a package. It groups related packages together and explicitly defines:

- What it exports
- What it requires
- What remains hidden

Modules improve encapsulation, security, maintainability, and application performance.

---

# 2. Why Do We Need Modules?

Before Java 9:

```text
Application
│
├── Package A
├── Package B
├── Package C
└── Everything Visible
```

Problems:

- Weak encapsulation
- Difficult dependency management
- Large runtime size

With Modules:

```text
Application
│
├── Module A
├── Module B
└── Module C
```

Each module explicitly controls its dependencies and exposed packages.

---

# 3. Package vs Module

| Package | Module |
|---------|--------|
| Groups related classes | Groups related packages |
| Organizes code | Organizes applications |
| No dependency declaration | Explicit dependency declaration |
| Limited encapsulation | Strong encapsulation |

---

# 4. Module Structure

Example project:

```text
student.app
│
├── module-info.java
└── com
    └── company
        └── student
            └── Student.java
```

The `module-info.java` file defines the module.

---

# 5. module-info.java

Basic module declaration:

```java
module student.app {
}
```

This creates a module named `student.app`.

---

# 6. Exporting Packages

Packages are hidden by default.

To make a package accessible:

```java
module student.app {

    exports com.company.student;
}
```

Now other modules can access classes in this package.

---

# 7. Requiring Other Modules

To use another module:

```java
module student.app {

    requires java.sql;
}
```

Common modules:

- `java.base` (automatic)
- `java.sql`
- `java.xml`
- `java.desktop`

---

# 8. Example

### Student Module

```java
module student.app {

    exports com.company.student;
}
```

### Client Module

```java
module client.app {

    requires student.app;
}
```

The client module can now use exported classes from `student.app`.

---

# 9. Advantages

- Strong encapsulation
- Explicit dependencies
- Better security
- Smaller runtime images (using `jlink`)
- Faster startup
- Easier maintenance

---

# 10. Best Practices

- Export only necessary packages.
- Keep implementation packages internal.
- Use meaningful module names.
- Minimize dependencies between modules.

---

# 11. Common Mistakes

❌ Confusing packages with modules.

❌ Exporting every package unnecessarily.

❌ Creating circular module dependencies.

---

# 12. Interview Questions

1. What is JPMS?
2. Why were modules introduced in Java 9?
3. Difference between packages and modules?
4. What is `module-info.java`?
5. Explain `exports` and `requires`.

---

# 13. Quick Revision

```text
Modules
│
├── module-info.java
├── exports
├── requires
├── Strong Encapsulation
└── Dependency Management
```

---

# 14. Interview Cheat Sheet

```text
Java Module
│
├── Groups Packages
├── module-info.java
├── exports → Makes package public
├── requires → Uses another module
└── Java 9 (Project Jigsaw)
```

---

# 15. Summary

The Java Platform Module System (JPMS) introduces modules as a way to organize applications above the package level. Modules provide strong encapsulation, explicit dependency management, and improved maintainability by controlling which packages are visible to other modules. Introduced in Java 9, JPMS is a significant enhancement for building secure, scalable, and modular enterprise Java applications.
