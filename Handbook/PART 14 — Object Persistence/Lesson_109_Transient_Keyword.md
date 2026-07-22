# Lesson 109 — Transient Keyword

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **`transient`** keyword in Java is used to **exclude specific instance variables from serialization**.

When an object is serialized, all non-static, non-transient instance variables are converted into a byte stream. Variables marked as `transient` are skipped and are not stored.

This is commonly used for:

- Passwords
- OTPs
- Session tokens
- Temporary calculations
- Sensitive information

---

# 2. Why Use `transient`?

Not every field should be saved permanently.

Example:

```java
class User {

    String username;

    transient String password;
}
```

When serialized:

```text
username  ✔ Serialized
password  ✘ Not Serialized
```

This improves security and avoids storing unnecessary data.

---

# 3. Syntax

```java
transient dataType variableName;
```

Example:

```java
transient int tempValue;

transient String password;
```

---

# 4. Example

```java
import java.io.Serializable;

class Employee implements Serializable {

    String name;

    transient String password;

    Employee(String name, String password) {
        this.name = name;
        this.password = password;
    }
}
```

After serialization and deserialization:

```text
name = Alice
password = null
```

The `password` field is not restored because it was never serialized.

---

# 5. How `transient` Works

```text
Java Object
│
├── name        ✔ Saved
├── salary      ✔ Saved
└── password    ✘ Ignored
```

Only non-transient instance variables become part of the serialized byte stream.

---

# 6. Default Values After Deserialization

Since transient fields are skipped, they receive Java's default values after deserialization.

| Data Type | Default Value |
|-----------|---------------|
| int | 0 |
| long | 0L |
| double | 0.0 |
| boolean | false |
| char | '\u0000' |
| Object | null |

---

# 7. `transient` vs `static`

Both are excluded from serialization, but for different reasons.

| `transient` | `static` |
|-------------|----------|
| Instance variable | Class variable |
| Belongs to object | Belongs to class |
| Explicitly skipped | Not serialized because it is not part of object state |

---

# 8. Advantages

- Protects sensitive data
- Reduces serialized object size
- Avoids storing temporary values
- Improves security
- Faster serialization in some cases

---

# 9. Best Practices

- Mark passwords, tokens, and secrets as `transient`.
- Use `transient` only for fields that do not need persistence.
- Reinitialize transient fields after deserialization if required.
- Combine with `serialVersionUID` for version compatibility.

---

# 10. Common Mistakes

❌ Assuming `transient` encrypts data.

❌ Marking essential business data as `transient`.

❌ Forgetting transient fields will have default values after deserialization.

❌ Confusing `transient` with `static`.

---

# 11. Interview Questions

1. What is the purpose of the `transient` keyword?
2. Which variables are skipped during serialization?
3. What value does a transient field have after deserialization?
4. How is `transient` different from `static`?
5. Why are passwords commonly declared as `transient`?

---

# 12. Quick Revision

```text
transient
│
├── Not Serialized
├── Sensitive Data
├── Temporary Data
└── Default Value After Deserialization
```

---

# 13. Interview Cheat Sheet

```text
transient

✔ Skips Serialization
✔ Instance Variables Only
✔ Default Values After Deserialization

Common Uses

Password
OTP
Session Token
Cache
Temporary Data
```

---

# 14. Summary

The `transient` keyword prevents selected instance variables from being serialized. It is primarily used to exclude sensitive or temporary information from an object's persistent state. After deserialization, transient fields are assigned their default Java values. Proper use of `transient` improves security, reduces storage requirements, and keeps serialized objects focused on meaningful business data.
