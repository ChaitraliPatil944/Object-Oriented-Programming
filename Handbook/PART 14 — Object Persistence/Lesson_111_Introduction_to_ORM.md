# Lesson 111 — Introduction to ORM

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**ORM (Object-Relational Mapping)** is a programming technique that maps **Java objects** to **database tables**.

Instead of writing SQL queries manually for every database operation, developers work with Java objects. The ORM framework automatically converts object operations into SQL statements.

ORM bridges the gap between:

- **Object-Oriented Programming (Classes & Objects)**
- **Relational Databases (Tables & Rows)**

Popular Java ORM frameworks include:

- Hibernate
- Java Persistence API (JPA)
- EclipseLink

---

# 2. Why Do We Need ORM?

Without ORM, developers write SQL manually.

Example:

```sql
INSERT INTO Student(id, name)
VALUES (1, 'Alice');
```

With ORM:

```java
Student student = new Student(1, "Alice");

entityManager.persist(student);
```

The ORM framework generates the required SQL automatically.

---

# 3. The Object-Relational Mismatch

Object-oriented programming and relational databases represent data differently.

| Object-Oriented | Relational Database |
|-----------------|---------------------|
| Class | Table |
| Object | Row (Record) |
| Field | Column |
| Object Reference | Foreign Key |
| Inheritance | Table Strategies |

ORM resolves these differences automatically.

---

# 4. How ORM Works

```text
Java Class
      │
      ▼
ORM Framework
      │
      ▼
SQL Statements
      │
      ▼
Relational Database
```

Developers interact with Java objects, while the ORM framework communicates with the database.

---

# 5. Basic Example

Java Class:

```java
class Student {

    private int id;
    private String name;
}
```

Database Table:

```text
Student
--------------------
id      name
--------------------
1       Alice
2       Bob
```

ORM maps object fields to table columns.

---

# 6. Common ORM Operations (CRUD)

CRUD stands for:

- **Create** → Insert new records
- **Read** → Retrieve records
- **Update** → Modify existing records
- **Delete** → Remove records

Example using JPA:

```java
entityManager.persist(student);   // Create

entityManager.find(Student.class, 1); // Read

entityManager.merge(student);     // Update

entityManager.remove(student);    // Delete
```

---

# 7. Advantages of ORM

- Reduces SQL boilerplate
- Improves productivity
- Encourages object-oriented design
- Database independence
- Built-in transaction support
- Easier maintenance

---

# 8. Disadvantages of ORM

- Learning curve
- Additional framework overhead
- Complex SQL may still require native queries
- Performance tuning may be necessary for large applications

---

# 9. Popular Java ORM Frameworks

| Framework | Description |
|-----------|-------------|
| Hibernate | Most widely used Java ORM framework |
| JPA | Standard ORM specification for Java |
| EclipseLink | Official JPA reference implementation |
| MyBatis | SQL mapping framework (not a full ORM) |

---

# 10. Best Practices

- Design entities carefully.
- Use ORM for standard CRUD operations.
- Optimize queries for performance.
- Avoid unnecessary object loading.
- Understand both ORM and SQL concepts.

---

# 11. Common Mistakes

❌ Assuming ORM completely replaces SQL knowledge.

❌ Loading unnecessary objects into memory.

❌ Ignoring transaction management.

❌ Creating poorly designed entity relationships.

---

# 12. Interview Questions

1. What is ORM?
2. Why is ORM used?
3. What problem does ORM solve?
4. Name popular Java ORM frameworks.
5. What are the advantages of ORM over JDBC?

---

# 13. Quick Revision

```text
ORM
│
├── Object ↔ Table
├── Field ↔ Column
├── CRUD Operations
└── Automatic SQL Generation
```

---

# 14. Interview Cheat Sheet

```text
ORM

✔ Object-Relational Mapping
✔ Maps Java Objects to Database Tables
✔ Reduces SQL Code
✔ Supports CRUD
✔ Improves Productivity

Popular Frameworks

Hibernate
JPA
EclipseLink
```

---

# 15. Summary

Object-Relational Mapping (ORM) is a technique that connects object-oriented applications with relational databases by automatically mapping Java objects to database tables. ORM frameworks such as Hibernate and JPA simplify database development by generating SQL, managing object persistence, and supporting CRUD operations, allowing developers to focus more on business logic than database interaction.
