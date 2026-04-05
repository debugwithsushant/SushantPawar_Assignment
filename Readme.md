# 📘 Sushant Pawar - .NET Assignment

> This repository showcases my practical understanding of .NET development concepts through hands-on implementation.

This repository contains solutions for the .NET Developer assignment provided by ADVANTO for the recruitment drive of Zest India IT Services.

---

## 🚀 Technologies Used

- C#
- .NET 8
- ASP.NET Core Web API
- LINQ
- SQL Server
- Dependency Injection (DI)

---

## 📂 Project Structure

```
Question1 - Palindrome Checker
Question2 - Largest Number in Array
Question3 - Employee Encapsulation
Question4 - LINQ Filtering
Question5 - Simple API
Question6 - SQL (Duplicate Records)
Question7 - Dependency Injection (SampleDI)
```

---

## 🧩 Questions Overview

### 🔹 Question 1: Palindrome Checker
- Checks whether a given string is a palindrome
- Ignores spaces and case sensitivity

---

### 🔹 Question 2: Largest Number
- Finds the largest number in an array
- Handles user input and validation

---

### 🔹 Question 3: Encapsulation
- Demonstrates encapsulation using private fields and public properties
- Includes validation logic

---

### 🔹 Question 4: LINQ Filter
- Filters employees with salary greater than 50,000 using LINQ
- Uses `Where()` clause

---

### 🔹 Question 5: Simple API
- ASP.NET Core Web API

Endpoints:
- `GET /api/employee` → Get all employees  
- `POST /api/employee` → Add employee  

Includes validation for input data.

---

### 🔹 Question 6: SQL - Duplicate Records

```sql
SELECT Name, Email, COUNT(*) AS DuplicateCount
FROM Employee
GROUP BY Name, Email
HAVING COUNT(*) > 1;
```

---

### 🔹 Question 7: Dependency Injection (SampleDI)

- Implements Dependency Injection using:
  - Controller
  - Service Layer
  - Interface
- Uses Scoped lifetime
- Follows clean architecture pattern

---

## ⚙️ How to Run

### 🔹 Clone Repository

```bash
git clone https://github.com/debugwithsushant/SushantPawar_Assignment.git
```

---

### 🔹 Run Console Applications

```bash
dotnet run
```

---

### 🔹 Run Web API

```bash
cd Question5/SimpleApi
dotnet run
```

OR

```bash
cd Question7/SampleDI
dotnet run
```

---

## 🎯 Key Concepts Covered

- Object-Oriented Programming (OOP)
- Encapsulation
- Exception Handling
- LINQ Queries
- ASP.NET Core Web API
- Dependency Injection (DI)
- SQL Aggregation & Grouping

---

## 👨‍💻 Author

**Sushant Pawar**

GitHub: https://github.com/debugwithsushant

---

## 🏁 Conclusion

This assignment demonstrates strong fundamentals in .NET development, including clean coding practices, proper architecture, and real-world concepts like Dependency Injection and API development.
