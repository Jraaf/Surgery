---

# **JWT Token Authentication API**

This is a `.NET 8 Web API` for managing various entities such as users, doctors, diagnoses, medical cases, operations, and more, with JWT-based authentication.

---

## **API Endpoints**

### **Authentication**
| Method | Endpoint                        | Description                   |
|--------|----------------------------------|-------------------------------|
| POST   | `/api/Authentication/register`  | Register a new user           |
| POST   | `/api/Authentication/login`     | Log in with existing credentials |

### **Diagnosis**
| Method | Endpoint                  | Description               |
|--------|----------------------------|---------------------------|
| GET    | `/api/Diagnosis/GetAll`    | Get all diagnoses         |
| GET    | `/api/Diagnosis/GetById`   | Get a specific diagnosis by ID |
| POST   | `/api/Diagnosis/add`       | Add a new diagnosis       |
| DELETE | `/api/Diagnosis/Delete`    | Delete a diagnosis by ID  |
| PUT    | `/api/Diagnosis/Update`    | Update a diagnosis by ID  |

### **Doctor**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/Doctor/GetAll`       | Get all doctors               |
| GET    | `/api/Doctor/GetById`      | Get a specific doctor by ID   |
| POST   | `/api/Doctor/add`          | Add a new doctor              |
| DELETE | `/api/Doctor/Delete`       | Delete a doctor by ID         |
| PUT    | `/api/Doctor/Update`       | Update a doctor by ID         |
| POST   | `/api/Doctor/AssignOperation` | Assign a doctor to an operation |
| POST   | `/api/Doctor/AssignMedicalCase` | Assign a doctor to a medical case |

### **Insurance**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/Insurance/GetAll`    | Get all insurances            |
| GET    | `/api/Insurance/GetById`   | Get a specific insurance by ID|
| POST   | `/api/Insurance/add`       | Add a new insurance           |
| DELETE | `/api/Insurance/Delete`    | Delete an insurance by ID     |
| PUT    | `/api/Insurance/Update`    | Update an insurance by ID     |

### **Medical Case**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/MedicalCase/GetAll`  | Get all medical cases         |
| GET    | `/api/MedicalCase/GetById` | Get a specific medical case by ID |
| POST   | `/api/MedicalCase/add`     | Add a new medical case        |
| DELETE | `/api/MedicalCase/Delete`  | Delete a medical case by ID   |
| PUT    | `/api/MedicalCase/Update`  | Update a medical case by ID   |

### **Operation**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/Operation/GetAll`    | Get all operations            |
| GET    | `/api/Operation/GetById`   | Get a specific operation by ID|
| POST   | `/api/Operation/add`       | Add a new operation           |
| DELETE | `/api/Operation/Delete`    | Delete an operation by ID     |
| PUT    | `/api/Operation/Update`    | Update an operation by ID     |

### **Patient**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/Patient/GetAll`      | Get all patients              |
| GET    | `/api/Patient/GetById`     | Get a specific patient by ID  |
| POST   | `/api/Patient/add`         | Add a new patient             |
| DELETE | `/api/Patient/Delete`      | Delete a patient by ID        |
| PUT    | `/api/Patient/Update`      | Update a patient by ID        |

### **Research**
| Method | Endpoint                  | Description                   |
|--------|----------------------------|-------------------------------|
| GET    | `/api/Research/GetAll`     | Get all research records      |
| GET    | `/api/Research/GetById`    | Get a specific research by ID |
| POST   | `/api/Research/add`        | Add a new research record     |
| DELETE | `/api/Research/Delete`     | Delete a research record by ID|
| PUT    | `/api/Research/Update`     | Update a research record by ID|

---

## **Schemas**

### **CreateUserDTO**
```json
{
  "username": "string",
  "password": "string",
  "doctorId": 1
}
```

### **CreateDiagnosisDTO**
```json
{
  "diagnoseDescription": "string"
}
```

### **CreateDoctorDTO**
```json
{
  "doctorName": "string",
  "doctorSurname": "string"
}
```

### **CreateInsuranceDTO**
```json
{
  "insuranceName": "string",
  "insuranceCoverageAmount": 0.0
}
```

### **CreateMedicalCaseDTO**
```json
{
  "caseStartDate": "2024-12-03T00:00:00",
  "caseEndDate": "2024-12-04T00:00:00",
  "patientId": 1,
  "insuranceId": 2,
  "diagnoseId": 3
}
```

### **CreateOperationDTO**
```json
{
  "operationName": "string",
  "operationCost": 100.0
}
```

### **CreatePatientDTO**
```json
{
  "patientName": "string",
  "patientSurname": "string",
  "patientPatronymic": "string",
  "patientDateOfBirth": {
    "year": 2024,
    "month": 12,
    "day": 3
  }
}
```

### **CreateResearchDTO**
```json
{
  "researchName": "string",
  "researchNormalValues": "string",
  "researchCost": 50.0
}
```

### **UserDTO**
```json
{
  "id": 1,
  "username": "string",
  "accessToken": "string",
  "doctorId": 2
}
```

---

## **Authentication**
This API uses JWT tokens for authentication. Add the following header to all requests that require authentication:
```
Authorization: Bearer <your_token>
```

---

Let me know if you need further customization!
