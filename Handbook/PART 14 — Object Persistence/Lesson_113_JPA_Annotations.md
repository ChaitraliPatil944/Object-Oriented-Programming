# Lesson 113 — JPA Annotations

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**JPA (Java Persistence API)** provides a standard set of annotations used to map Java classes and fields to relational database tables.

Annotations eliminate most XML configuration and make entity mapping simple, readable, and maintainable.

Popular ORM frameworks such as **Hibernate** implement the JPA specification.

---

# 2. Why JPA Annotations?

JPA annotations tell the ORM framework:

- Which class represents a table
- Which field is the primary key
- How columns should be mapped
- How relationships between entities work
- How keys are generated

---

# 3. Common JPA Annotations

| Annotation | Purpose |
|------------|---------|
| `@Entity` | Marks a class as an entity |
| `@Table` | Maps entity to a table |
| `@Id` | Marks the primary key |
| `@GeneratedValue` | Generates primary key values |
| `@Column` | Maps a field to a column |
| `@Transient` | Excludes a field from persistence |
| `@OneToOne` | One-to-one relationship |
| `@OneToMany` | One-to-many relationship |
| `@ManyToOne` | Many-to-one relationship |
| `@ManyToMany` | Many-to-many relationship |

---

# 4. `@Entity`

Marks a class as a persistent entity.

```java
import jakarta.persistence.*;

@Entity
public class Student {

}
```

Without `@Entity`, Hibernate does not treat the class as a database entity.

---

# 5. `@Table`

Maps an entity to a specific table.

```java
@Entity
@Table(name = "students")
public class Student {

}
```

If omitted, the class name is used as the table name by default.

---

# 6. `@Id` and `@GeneratedValue`

```java
@Id
@GeneratedValue(strategy = GenerationType.IDENTITY)
private int id;
```

`@Id` identifies the primary key.

`@GeneratedValue` lets the database or ORM generate key values automatically.

---

# 7. `@Column`

Maps a field to a database column.

```java
@Column(name = "student_name",
        nullable = false,
        length = 100)
private String name;
```

Common attributes:

- `name`
- `nullable`
- `unique`
- `length`

---

# 8. `@Transient`

Prevents a field from being persisted.

```java
@Transient
private String confirmPassword;
```

Useful for temporary or calculated values.

---

# 9. Relationship Annotations

### One-to-One

```java
@OneToOne
private Passport passport;
```

### One-to-Many

```java
@OneToMany
private List<Course> courses;
```

### Many-to-One

```java
@ManyToOne
private Department department;
```

### Many-to-Many

```java
@ManyToMany
private List<Project> projects;
```

---

# 10. Complete Entity Example

```java
import jakarta.persistence.*;

@Entity
@Table(name = "students")
public class Student {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(nullable = false)
    private String name;

    @Transient
    private String temporaryNote;

    public Student() {
    }
}
```

---

# 11. Advantages

- Reduces configuration
- Improves readability
- Standardized persistence API
- Simplifies object-table mapping
- Portable across JPA providers

---

# 12. Best Practices

- Always define a primary key.
- Use meaningful table and column names.
- Keep entity classes focused on persistence.
- Choose relationship annotations carefully.
- Avoid unnecessary eager loading.

---

# 13. Common Mistakes

❌ Forgetting `@Entity`.

❌ Missing `@Id`.

❌ Using incorrect relationship annotations.

❌ Persisting fields that should be marked `@Transient`.

---

# 14. Interview Questions

1. What is JPA?
2. What is the purpose of `@Entity`?
3. Difference between `@Table` and `@Column`?
4. Why is `@GeneratedValue` used?
5. Explain the four relationship annotations.

---

# 15. Quick Revision

```text
JPA Annotations
│
├── @Entity
├── @Table
├── @Id
├── @GeneratedValue
├── @Column
├── @Transient
└── Relationships
```

---

# 16. Interview Cheat Sheet

```text
@Entity           → Entity Class
@Table            → Database Table
@Id               → Primary Key
@GeneratedValue   → Auto Key
@Column           → Column Mapping
@Transient        → Ignore Field

Relationships

@OneToOne
@OneToMany
@ManyToOne
@ManyToMany
```

---

# 17. Summary

JPA annotations provide a standardized way to map Java objects to relational database tables. Annotations such as `@Entity`, `@Table`, `@Id`, `@GeneratedValue`, and `@Column` define entity structure, while relationship annotations model associations between entities. These annotations form the core of JPA and Hibernate-based persistence, enabling developers to build clean, maintainable, and database-independent enterprise applications.
