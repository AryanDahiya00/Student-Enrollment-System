# Student Registration System - Software Requirement Specification (SRS)

## Table of Contents
1. [Problem Definition](#1-problem-definition)
2. [System Requirement Specification](#2-system-requirement-specification)
   - [Introduction](#21-introduction)
   - [Overall Description](#22-overall-description)
   - [Specific Requirements](#23-specific-requirements)
3. [Front-End Description](#3-front-end-description)
4. [Back-End Description](#4-back-end-description)
5. [Data Structures](#5-data-structures)
6. [Data Flow Diagram](#6-data-flow-diagram)
7. [Testing](#7-testing)
8. [Sample Forms](#8-sample-forms)

## 1. Problem Definition

The Student Registration System is a software platform where faculty, students, and administrators can interact to perform their designated tasks within the university environment.

Key features:
- Admin can login and register students and faculties
- Students can login and select up to 30 credits worth of courses
- Faculty can login and select courses they want to teach
- All changes are updated in the university database

## 2. System Requirement Specification

### 2.1 Introduction

#### 2.1.1 Purpose
- Describe requirements for developing a Student Registration System
- Intended audience: students, faculties, and administrators

#### 2.1.2 Scope
- Product title: Student Registration System
- Key tasks:
  - Login based on user type
  - Admin can register new students and faculties
  - Students can enroll in courses (max 31 credits)
  - Faculties can choose courses to teach

#### 2.1.3 Definitions, Acronyms and Abbreviations
- DBMS: Database Management System

### 2.2 Overall Description

#### 2.2.1 Product Perspective

##### Hardware Interfaces
- Hard disk: Fast database system with high rpm
- Standard input/output devices: keyboard and mouse

##### Software Interfaces
- Back End: MySQL
- Front End: Microsoft Visual Studio

##### Memory Constraints
- No specific constraints on memory

##### Operations
1. LOGIN based on user type
2. Admin registration of new students and faculties
3. Student course enrollment
4. Faculty course selection

#### 2.2.2 Product Functions
- Authenticate users
- Allow course selection for students
- Allow course teaching selection for faculty

#### 2.2.3 User Characteristics
- No specific technical knowledge required
- User-friendly interface for naive users

#### 2.2.4 Constraints
- Unique username and password for each user
- Only admin can change passwords

### 2.3 Specific Requirements

#### 2.3.1 Logical Database Requirements
- User details: name, ID, courses, etc.
- Course details: name, code, year, etc.

## 3. Front-End Description

An automated registration system where users can:
- Register on the university database
- Login using unique credentials
- Enroll in or teach courses based on user type

![alt text](https://github.com/AryanDahiya00/Student-Enrollment-System/blob/main/Capture1.JPG)
![alt text](https://github.com/AryanDahiya00/Student-Enrollment-System/blob/main/Capture2.JPG)
![alt text](https://github.com/AryanDahiya00/Student-Enrollment-System/blob/main/Capture3.JPG)

## 4. Back-End Description

Four main tables:
1. Student details
2. Faculty details
3. Subject details
4. Admin details

## 5. Data Structures

### 5.1 Admin Details
| Field Name | Type | Constraints |
|------------|------|-------------|
| ID | NUMBER | NOT NULL |
| USERNAME | VARCHAR (20) | NOT NULL |
| PASSWORD | VARCHAR (20) | NOT NULL |

### 5.2 Student Details
| Field Name | Type | Constraints |
|------------|------|-------------|
| STUDENTNO | INT (11) | NOT NULL |
| NAME | TEXT | NOT NULL |
| EMAIL | VARCHAR (40) | NOT NULL |
| COURSE | TEXT | NOT NULL |
| YEAR | VARCHAR (20) | NOT NULL |

### 5.3 Faculty Details
| Field Name | Type | Constraints |
|------------|------|-------------|
| EMPLOYEENUM | INT (11) | NOT NULL |
| NAME | TEXT | NOT NULL |
| EMAIL | VARCHAR (30) | NOT NULL |

### 5.4 Subject Details
| Field Name | Type | Constraints |
|------------|------|-------------|
| STUDNUM | INT (11) | NOT NULL |
| STUDNAME | TEXT | NOT NULL |
| COURSE | TEXT | NOT NULL |
| YEAR | VARCHAR (20) | NOT NULL |
| SUBJECTCODE | VARCHAR (20) | NOT NULL |


## 6. Testing

| Form Name | Input | Expected Output | Actual Output | Status |
|-----------|-------|-----------------|---------------|--------|
| Login Form | User Type, Username, Password | If password is correct, login | Member authenticated for future options | PASS |
| Student Registration | Name, Student ID, Email, Course, Year | Create new student account | New account was created | PASS |
| Faculty Registration Form | Faculty ID, Name, Email | Create new faculty account | New account was created | PASS |
| Change Admin Password Form | Old Password and New Password | Change the password to the new password | Password was changed | PASS |
| Student Course Registration Form | Menu Option | Student gets enrolled in the chosen courses | Student was enrolled in the chosen courses | PASS |
| Faculty Course Selection Form | Menu Option | If students are enrolled in the course, the faculty gets the student list | Faculty received the number of students along with the student list | PASS |

## 7. Sample Forms

The original document includes sample form images for:
- Login Form
- Student Registration Form
- Faculty Registration Form
- Change Admin Password Form
- Student Course Registration Form
- Faculty Course Selection Form

These forms provide a visual representation of the user interface for various system functions.

