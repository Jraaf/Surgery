Here is a complete **README.md** based on the provided OpenAPI file:

---

# **JWT Token Authentication API**

This is a `.NET 8 Web API` that provides endpoints for managing users, doctors, diagnoses, medical cases, and more. The API uses JWT tokens for authentication.

---

## **Table of Contents**
- [Authentication](#authentication)
- [Endpoints](#endpoints)
  - [Diagnosis](#diagnosis)
  - [Doctor](#doctor)
  - [Insurance](#insurance)
  - [MedicalCase](#medicalcase)
  - [Operation](#operation)
  - [Patient](#patient)
  - [Research](#research)
- [Schemas](#schemas)
- [Authentication](#authentication-header)
- [License](#license)

---

## **Authentication**
Endpoints for registering and logging in users:
| Method | Endpoint                        | Description              |
|--------|----------------------------------|--------------------------|
| POST   | `/api/Authentication/register`  | Register a new user      |
| POST   | `/api/Authentication/login`     | Authenticate a user and return a JWT token |

---

## **Endpoints**

### **Diagnosis**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/Diagnosis/GetAll`    | Get all diagnoses                 |
| GET    | `/api/Diagnosis/GetById`   | Get a specific diagnosis by ID    |
| POST   | `/api/Diagnosis/add`       | Add a new diagnosis               |
| DELETE | `/api/Diagnosis/Delete`    | Delete a diagnosis by ID          |
| PUT    | `/api/Diagnosis/Update`    | Update a diagnosis by ID          |

### **Doctor**
| Method | Endpoint                    | Description                        |
|--------|------------------------------|------------------------------------|
| GET    | `/api/Doctor/GetAll`         | Get all doctors                   |
| GET    | `/api/Doctor/GetBusyDoctors` | Get doctors with active assignments |
| GET    | `/api/Doctor/GetBestDoctors` | Get top-performing doctors        |
| GET    | `/api/Doctor/GetById`        | Get a specific doctor by ID       |
| POST   | `/api/Doctor/add`            | Add a new doctor                  |
| DELETE | `/api/Doctor/Delete`         | Delete a doctor by ID             |
| PUT    | `/api/Doctor/Update`         | Update a doctor by ID             |
| POST   | `/api/Doctor/AssignOperation` | Assign a doctor to an operation  |
| POST   | `/api/Doctor/AssignMedicalCase` | Assign a doctor to a medical case |

### **Insurance**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/Insurance/GetAll`    | Get all insurance records         |
| GET    | `/api/Insurance/GetById`   | Get a specific insurance record by ID |
| POST   | `/api/Insurance/add`       | Add a new insurance record        |
| DELETE | `/api/Insurance/Delete`    | Delete an insurance record by ID  |
| PUT    | `/api/Insurance/Update`    | Update an insurance record by ID  |

### **MedicalCase**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/MedicalCase/GetAll`  | Get all medical cases             |
| GET    | `/api/MedicalCase/GetById` | Get a specific medical case by ID |
| POST   | `/api/MedicalCase/add`     | Add a new medical case            |
| DELETE | `/api/MedicalCase/Delete`  | Delete a medical case by ID       |
| PUT    | `/api/MedicalCase/Update`  | Update a medical case by ID       |

### **Operation**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/Operation/GetAll`    | Get all operations                |
| GET    | `/api/Operation/GetById`   | Get a specific operation by ID    |
| POST   | `/api/Operation/add`       | Add a new operation               |
| DELETE | `/api/Operation/Delete`    | Delete an operation by ID         |
| PUT    | `/api/Operation/Update`    | Update an operation by ID         |

### **Patient**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/Patient/GetAll`      | Get all patients                  |
| GET    | `/api/Patient/GetById`     | Get a specific patient by ID      |
| POST   | `/api/Patient/add`         | Add a new patient                 |
| DELETE | `/api/Patient/Delete`      | Delete a patient by ID            |
| PUT    | `/api/Patient/Update`      | Update a patient by ID            |

### **Research**
| Method | Endpoint                  | Description                        |
|--------|----------------------------|------------------------------------|
| GET    | `/api/Research/GetAll`     | Get all research records          |
| GET    | `/api/Research/GetById`    | Get a specific research by ID     |
| POST   | `/api/Research/add`        | Add a new research record         |
| DELETE | `/api/Research/Delete`     | Delete a research record by ID    |
| PUT    | `/api/Research/Update`     | Update a research record by ID    |

---

## **Schemas**
### CreateDiagnosisDTO
```json
{
  "diagnoseDescription": "string"
}
```

### CreateDoctorDTO
```json
{
  "doctorName": "string",
  "doctorSurname": "string"
}
```

### CreateUserDTO
```json
{
  "username": "string",
  "password": "string",
  "doctorId": 1
}
```

### CreateMedicalCaseDTO
```json
{
  "caseStartDate": "string",
  "caseEndDate": "string",
  "patientId": 1,
  "insuranceId": 1,
  "diagnoseId": 1
}
```

### UserDTO
```json
{
  "id": 1,
  "username": "string",
  "accessToken": "string",
  "doctorId": 1
}
```

---

## **Authentication Header**
To access protected endpoints, include the following header in your requests:
```
Authorization: Bearer <your_token>
```

Example:
```bash
curl -H "Authorization: Bearer 12345abcdef" -X GET https://api.example.com/secure-endpoint
```

---

## **License**
MIT License. Feel free to use and modify as needed.

---

Let me know if you need any refinements!
