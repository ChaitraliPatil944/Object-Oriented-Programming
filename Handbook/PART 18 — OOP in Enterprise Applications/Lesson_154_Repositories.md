# Lesson 154 — Repositories

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **Repository** is a design pattern used in Domain-Driven Design (DDD) to abstract data access logic.

Instead of allowing business classes to communicate directly with the database, repositories provide a clean interface for storing and retrieving domain objects.

In Java enterprise applications, repositories are commonly implemented using **Spring Data JPA**.

---

# 2. Why Use Repositories?

Without repositories:

- Business logic becomes tightly coupled to database code.
- Testing becomes difficult.
- Database technology changes affect many classes.

Repositories separate persistence concerns from business logic.

---

# 3. Repository Pattern

```text
Controller
     │
     ▼
Service
     │
     ▼
Repository
     │
     ▼
Database
```

The service layer communicates only with the repository.

---

# 4. Repository Responsibilities

A repository typically performs:

- Save
- Update
- Delete
- Find by ID
- Find all
- Custom queries

It should not contain business rules.

---

# 5. Basic Repository Interface

```java
public interface UserRepository {

    User save(User user);

    User findById(Long id);

    List<User> findAll();

    void delete(User user);
}
```

The interface defines data access operations.

---

# 6. Spring Data JPA Example

```java
import org.springframework.data.jpa.repository.JpaRepository;

public interface UserRepository
        extends JpaRepository<User, Long> {

    User findByEmail(String email);
}
```

Spring automatically generates the implementation.

---

# 7. Repository Flow

```text
Client
   │
Controller
   │
Service
   │
Repository
   │
Database
```

Repositories isolate persistence details from higher layers.

---

# 8. Benefits

- Loose coupling
- Easier testing using mock repositories
- Cleaner architecture
- Reusable data access logic
- Database independence

---

# 9. Best Practices

- Keep repositories focused on persistence.
- Place business logic in services.
- Return domain entities or appropriate projections.
- Use meaningful query method names.
- Avoid putting presentation logic in repositories.

---

# 10. Common Mistakes

❌ Writing business rules inside repositories.

❌ Accessing repositories directly from controllers.

❌ Creating duplicate query methods.

❌ Mixing persistence and validation logic.

---

# 11. Repository vs DAO

| Repository | DAO |
|------------|-----|
| Domain-focused | Database-focused |
| Works with aggregates/entities | Works with tables/queries |
| Common in DDD | Traditional persistence layer |

---

# 12. Interview Questions

1. What is a repository?
2. Why is the Repository pattern used?
3. Repository vs DAO?
4. What is `JpaRepository`?
5. Where should business logic reside?

---

# 13. Quick Revision

```text
Repository
│
├── Save
├── Find
├── Update
├── Delete
└── Database Abstraction
```

---

# 14. Interview Cheat Sheet

```text
Repository

✔ Data Access Layer
✔ Database Abstraction
✔ Used by Services

Spring Data

JpaRepository
CrudRepository

Benefits

Loose Coupling
Easy Testing
Clean Architecture
```

---

# 15. Summary

The Repository pattern abstracts database operations behind a clean interface, allowing business logic to remain independent of persistence details. In enterprise Java applications, repositories are typically implemented using Spring Data JPA, providing built-in CRUD functionality and simplifying data access while supporting clean architecture and Domain-Driven Design.
