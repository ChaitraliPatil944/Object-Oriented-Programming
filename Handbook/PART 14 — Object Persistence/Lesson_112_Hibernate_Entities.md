# Lesson 112 — Hibernate Entities

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Hibernate Entity** is a plain Java class (POJO) that represents a table in a relational database.

Each object of the entity represents one row in the table, while each field represents a column.

Hibernate automatically maps entity objects to database records using annotations.

---

# 2. What is an Entity?

An entity is a Java class that:

- Represents a database table
- Has a unique primary key
- Can be stored, updated, retrieved, and deleted
- Is managed by the Hibernate framework

Example mapping:

```text
Student Object  ⇄  Student Table
```

---

# 3. Characteristics of an Entity

A Hibernate entity should:

- Be annotated with `@Entity`
- Have a public or protected no-argument constructor
- Contain a primary key annotated with `@Id`
- Usually provide getters and setters
- Be a top-level class

---

# 4. Basic Entity Example

```java
import jakarta.persistence.*;

@Entity
public class Student {

    @Id
    private int id;

    private String name;

    public Student() {
    }

    public Student(int id, String name) {
        this.id = id;
        this.name = name;
    }

    // Getters and Setters
}
```

Hibernate maps this class to a table named `Student` by default.

---

# 5. Mapping an Entity to a Table

Use the `@Table` annotation to specify a table name.

```java
@Entity
@Table(name = "students")
public class Student {

    @Id
    private int id;

    private String name;
}
```

---

# 6. Primary Key

Every entity must have a primary key.

```java
@Id
private int id;
```

For automatic key generation:

```java
@Id
@GeneratedValue(strategy = GenerationType.IDENTITY)
private int id;
```

---

# 7. Entity Lifecycle

```text
New
 │
 ▼
Managed
 │
 ▼
Detached
 │
 ▼
Removed
```

- **New**: Object created but not stored.
- **Managed**: Hibernate tracks changes.
- **Detached**: No longer associated with the persistence context.
- **Removed**: Scheduled for deletion.

---

# 8. CRUD Operations

```java
entityManager.persist(student);   // Create

entityManager.find(Student.class, 1); // Read

entityManager.merge(student);     // Update

entityManager.remove(student);    // Delete
```

Hibernate translates these operations into SQL.

---

# 9. Advantages

- Eliminates repetitive SQL
- Automatic object-table mapping
- Simplifies persistence
- Supports transactions
- Integrates with JPA

---

# 10. Best Practices

- Keep entities focused on persistent data.
- Always define a primary key.
- Provide a no-argument constructor.
- Avoid placing heavy business logic inside entities.
- Use meaningful table and column names.

---

# 11. Common Mistakes

❌ Forgetting the `@Entity` annotation.

❌ Missing a no-argument constructor.

❌ Omitting the primary key.

❌ Using entities as DTOs for every layer.

---

# 12. Interview Questions

1. What is a Hibernate entity?
2. What annotations are required for an entity?
3. Why must an entity have a primary key?
4. What is the purpose of `@GeneratedValue`?
5. What are the lifecycle states of an entity?

---

# 13. Quick Revision

```text
Hibernate Entity
│
├── @Entity
├── @Id
├── @Table
├── POJO
└── Database Table Mapping
```

---

# 14. Interview Cheat Sheet

```text
Hibernate Entity

✔ Java POJO
✔ Represents Database Table
✔ @Entity
✔ @Id
✔ No-Argument Constructor

CRUD

persist()
find()
merge()
remove()
```

---

# 15. Summary

A Hibernate entity is a Java class that represents a database table and is managed by the Hibernate ORM framework. By using annotations such as `@Entity`, `@Id`, `@Table`, and `@GeneratedValue`, developers can map objects to relational tables without writing repetitive SQL. Entities form the foundation of Hibernate and JPA-based persistence in enterprise Java applications.
