# Lesson 41 — Common Interview Questions: Encapsulation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Encapsulation is one of the most frequently asked Object-Oriented Programming topics in Java interviews.

Interviewers usually test whether a candidate understands:

- The concept of encapsulation
- Data hiding
- Access modifiers
- Getters and setters
- Validation
- Real-world applications

This lesson provides concise, interview-ready answers to the most common questions.

---

# 2. What is Encapsulation?

**Answer:**

Encapsulation is the process of **bundling data (variables) and behavior (methods) into a single unit (class)** while restricting direct access to the object's internal state through controlled methods.

Example:

```java
class Employee {

    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
```

---

# 3. Why is Encapsulation Important?

**Answer:**

Encapsulation:

- Protects data
- Prevents invalid object states
- Enforces business rules
- Improves maintainability
- Reduces coupling
- Supports abstraction

---

# 4. What is the Difference Between Encapsulation and Data Hiding?

| Encapsulation | Data Hiding |
|---------------|-------------|
| Bundles data and methods | Restricts access to data |
| Achieved using classes | Achieved using access modifiers |
| Broad OOP principle | Part of encapsulation |

Interview Tip:

> Data hiding is a mechanism used to achieve encapsulation.

---

# 5. Why Are Fields Usually Private?

**Answer:**

Private fields:

- Prevent direct modification
- Protect internal state
- Allow validation
- Improve security
- Preserve object integrity

---

# 6. What Are Getters and Setters?

**Getter**

Returns a private field.

```java
public String getName() {
    return name;
}
```

**Setter**

Updates a private field.

```java
public void setName(String name) {
    this.name = name;
}
```

Setters should validate input whenever appropriate.

---

# 7. Should Every Field Have a Setter?

**Answer:**

No.

Many fields should be read-only.

Instead of:

```java
setBalance()
```

prefer:

```java
deposit()
withdraw()
transfer()
```

Business methods better enforce domain rules.

---

# 8. Can Encapsulation Exist Without Getters and Setters?

**Answer:**

Yes.

Encapsulation is about **controlled access**, not about automatically generating getters and setters.

A class may expose only business methods.

---

# 9. How Does Encapsulation Improve Security?

**Answer:**

Encapsulation hides implementation details and ensures that all updates pass through validation.

Sensitive information such as:

- Bank balances
- Passwords
- Medical records

cannot be modified directly.

---

# 10. What Are Common Mistakes?

❌ Making fields public.

❌ Providing setters for every field.

❌ Setters without validation.

❌ Exposing mutable internal collections.

❌ Confusing encapsulation with data hiding.

---

# 11. Enterprise Scenario

Question:

Why doesn't a banking system provide:

```java
setBalance()
```

Answer:

Because anyone could bypass business rules.

Instead:

```java
deposit()
withdraw()
```

validate:

- Positive amounts
- Available balance
- Transaction rules

before changing the object's state.

---

# 12. Rapid-Fire Interview Questions

1. What is encapsulation?
2. How is encapsulation implemented in Java?
3. What is data hiding?
4. Why are fields private?
5. What are access modifiers?
6. What is the role of getters and setters?
7. Should every field have a setter?
8. How does encapsulation improve maintainability?
9. How does encapsulation improve security?
10. Give a real-world example of encapsulation.

---

# 13. Cheat Sheet

```text
Encapsulation
│
├── Bundle data + methods
├── Keep fields private
├── Expose controlled methods
├── Validate input
├── Enforce business rules
└── Protect object integrity

Prefer:
deposit()
withdraw()
transfer()

Avoid:
setBalance()
```

---

# 14. Summary

Encapsulation is the foundation of secure and maintainable object-oriented design. It combines data and behavior into a class while controlling access to internal state. In enterprise software, encapsulation is used to enforce business rules, protect data integrity, and expose meaningful operations instead of unrestricted data manipulation. Mastering these concepts and their interview applications is essential for Java developers.
