# Lesson 110 — Versioning in Serialization

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

When a serializable Java class changes over time, previously serialized objects may become incompatible with the newer version of the class.

**Serialization Versioning** ensures compatibility between different versions of a class during serialization and deserialization.

Java manages this using the **`serialVersionUID`** field.

---

# 2. Why Versioning is Needed?

Consider a class:

```java
class Student implements Serializable {

    int id;
    String name;
}
```

Objects are serialized and stored.

Later, the class is modified:

```java
class Student implements Serializable {

    int id;
    String name;
    String email;
}
```

Without proper versioning, deserializing older objects may fail.

---

# 3. What is `serialVersionUID`?

`serialVersionUID` is a unique version identifier for a serializable class.

```java
private static final long serialVersionUID = 1L;
```

It tells the JVM whether the serialized object matches the current class definition.

---

# 4. Declaring `serialVersionUID`

```java
import java.io.Serializable;

class Employee implements Serializable {

    private static final long serialVersionUID = 1L;

    int id;
    String name;
}
```

It is recommended to declare it explicitly rather than relying on the compiler-generated value.

---

# 5. How Version Checking Works

```text
Serialized Object
        │
serialVersionUID = 1
        │
        ▼
Current Class
serialVersionUID = 1
        │
Compatible ✔
```

If the values differ:

```text
Serialized Object
UID = 1

Current Class
UID = 2

Result:
InvalidClassException
```

---

# 6. Changing a Class

Minor compatible changes may include:

- Adding methods
- Adding helper logic

Potentially incompatible changes include:

- Removing fields
- Changing field types
- Modifying class hierarchy
- Changing `serialVersionUID`

---

# 7. Example

```java
class Product implements Serializable {

    private static final long serialVersionUID = 1L;

    int id;
}
```

Later:

```java
class Product implements Serializable {

    private static final long serialVersionUID = 2L;

    int id;
}
```

Attempting to deserialize an object created with version `1L` will throw:

```text
java.io.InvalidClassException
```

---

# 8. Benefits of `serialVersionUID`

- Version compatibility
- Predictable serialization behavior
- Easier maintenance
- Prevents accidental incompatibility
- Better long-term persistence support

---

# 9. Best Practices

- Always declare `serialVersionUID` explicitly.
- Change it only for incompatible class changes.
- Keep serialized classes stable.
- Test compatibility after modifying serializable classes.
- Document version changes.

---

# 10. Common Mistakes

❌ Relying on compiler-generated `serialVersionUID`.

❌ Changing the UID unnecessarily.

❌ Ignoring compatibility when modifying serialized classes.

❌ Assuming all class changes are backward compatible.

---

# 11. Interview Questions

1. What is `serialVersionUID`?
2. Why is versioning required in serialization?
3. What happens if `serialVersionUID` values differ?
4. Should developers declare `serialVersionUID` manually?
5. Which exception indicates a version mismatch?

---

# 12. Quick Revision

```text
Serialization Versioning
│
├── serialVersionUID
├── Compatibility Check
├── Same UID → Success
└── Different UID → InvalidClassException
```

---

# 13. Interview Cheat Sheet

```text
serialVersionUID

✔ Unique Class Version
✔ Used During Deserialization
✔ Declared as:

private static final long
serialVersionUID = 1L;

Mismatch
→ InvalidClassException
```

---

# 14. Summary

Versioning in Java serialization ensures that serialized objects remain compatible with their class definitions over time. The `serialVersionUID` field acts as a unique version identifier that the JVM checks during deserialization. Declaring it explicitly provides predictable behavior, prevents unexpected compatibility issues, and supports the long-term maintenance of object-oriented applications that rely on serialized data.
