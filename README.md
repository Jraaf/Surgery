# GENERATED WITH CHATGPT

---

```markdown
# API Endpoint Schemes

This section outlines the structure and usage of the API endpoints for various entities.

---

## Authentication

### Register a New User
**Endpoint:**
```http
POST /api/Authentication/register
```

**Request Body:**
```json
{
  "username": "string",
  "password": "string",
  "doctorId": 1
}
```

**Response:**
```json
{
  "message": "User registered successfully."
}
```

---

### User Login
**Endpoint:**
```http
POST /api/Authentication/login
```

**Request Body:**
```json
{
  "username": "string",
  "password": "string"
}
```

**Response:**
```json
{
  "token": "string.jwt.token"
}
```

---

## Diagnosis

### Get All Diagnoses
**Endpoint:**
```http
GET /api/Diagnosis/GetAll
```

**Response:**
```json
[
  {
    "diagnosisId": 1,
    "name": "string",
    "description": "string"
  }
]
```

### Add a New Diagnosis
**Endpoint:**
```http
POST /api/Diagnosis/add
```

**Request Body:**
```json
{
  "name": "string",
  "description": "string"
}
```

**Response:**
```json
{
  "diagnosisId": 1,
  "name": "string",
  "description": "string"
}
```

---

## Doctor

### Get All Doctors
**Endpoint:**
```http
GET /api/Doctor/GetAll
```

**Response:**
```json
[
  {
    "doctorId": 1,
    "name": "string",
    "surname": "string",
    "specialization": "string"
  }
]
```

---

## Medical Case

### Get All Medical Cases
**Endpoint:**
```http
GET /api/MedicalCase/GetAll
```

**Response:**
```json
[
  {
    "caseId": 1,
    "caseStartDate": "2023-12-01T00:00:00Z",
    "caseEndDate": null,
    "patientId": 1,
    "insuranceId": 2,
    "diagnoseId": 3,
    "details": "string"
  }
]
```

### Add a New Medical Case
**Endpoint:**
```http
POST /api/MedicalCase/add
```

**Request Body:**
```json
{
  "caseStartDate": "2023-12-01T00:00:00Z",
  "caseEndDate": null,
  "patientId": 1,
  "insuranceId": 2,
  "diagnoseId": 3,
  "details": "string"
}
```

**Response:**
```json
{
  "caseId": 1,
  "caseStartDate": "2023-12-01T00:00:00Z",
  "caseEndDate": null,
  "patientId": 1,
  "insuranceId": 2,
  "diagnoseId": 3,
  "details": "string"
}
```

---

## Notes

- All responses include appropriate HTTP status codes (e.g., 200 for success, 404 for not found).
- Use the `Authorization` header with a Bearer token for secured endpoints:
  ```
  Authorization: Bearer YOUR_JWT_TOKEN
  ```
- For more details, refer to the OpenAPI (Swagger) documentation.
```

Let me know if you need further details for other endpoints or additional response formats!

---

```markdown
# Schemas

This section outlines the key data structures used in the API.

---

## Authentication

### CreateUserDTO
```json
{
  "username": "string",
  "password": "string",
  "doctorId": 1
}
```

---
### Diagnosis
```json
{
  "diagnosisId": 1,
  "name": "string",
  "description": "string"
}
```

### Doctor
```json
{
  "doctorId": 1,
  "name": "string",
  "surname": "string",
  "specialization": "string"
}
```

### Insurance
```json
{
  "insuranceId": 1,
  "company": "string",
  "policyNumber": "string",
  "coverageDetails": "string"
}
```

### Medical Case
```json
{
  "caseId": 1,
  "caseStartDate": "2023-12-01T00:00:00Z",
  "caseEndDate": null,
  "patientId": 1,
  "insuranceId": 2,
  "diagnoseId": 3,
  "details": "string"
}
```

### Operation
```json
{
  "operationId": 1,
  "type": "string",
  "date": "2023-12-01T00:00:00Z",
  "doctorId": 1,
  "medicalCaseId": 1
}
```

### Patient
```json
{
  "patientId": 1,
  "name": "string",
  "surname": "string",
  "dateOfBirth": "2000-01-01T00:00:00Z",
  "gender": "string"
}
```

### Research
```json
{
  "researchId": 1,
  "title": "string",
  "dateConducted": "2023-12-01T00:00:00Z",
  "description": "string",
  "patientId": 1
}
```

---

## Notes
- Refer to the OpenAPI documentation for additional details, validation rules, and relationships.
```

Let me know if you need further modifications or additional schema details!
