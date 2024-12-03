JWT Token Authentication API
Overview
This project is a .NET 8 Web API that provides endpoints for managing various healthcare-related entities (e.g., doctors, patients, medical cases) and supports JWT Token Authentication for secure access.
________________


Table of Contents
1. API Endpoints
2. Authentication
3. Entity Management
   * Diagnosis
   * Doctors
   * Insurance
   * Medical Cases
   * Operations
   * Patients
   * Research
4. Schemas
5. Security
6. Getting Started
________________


API Endpoints
Authentication
* Register

   * POST /api/Authentication/register
   * Request Body: CreateUserDTO
   * Response: UserDTO
   * Login

      * POST /api/Authentication/login
      * Request Body: LoginUserDTO
      * Response: UserDTO
Diagnosis
      * Get All Diagnoses: GET /api/Diagnosis/GetAll
      * Get Diagnosis by ID: GET /api/Diagnosis/GetById?id={id}
      * Add Diagnosis: POST /api/Diagnosis/add
      * Request Body: CreateDiagnosisDTO
      * Update Diagnosis: PUT /api/Diagnosis/Update?id={id}
      * Request Body: CreateDiagnosisDTO
      * Delete Diagnosis: DELETE /api/Diagnosis/Delete?id={id}
Doctors
      * Get All Doctors: GET /api/Doctor/GetAll
      * Get Doctor by ID: GET /api/Doctor/GetById?id={id}
      * Add Doctor: POST /api/Doctor/add
      * Request Body: CreateDoctorDTO
      * Update Doctor: PUT /api/Doctor/Update?id={id}
      * Request Body: CreateDoctorDTO
      * Delete Doctor: DELETE /api/Doctor/Delete?id={id}
Insurance
      * Get All Insurance: GET /api/Insurance/GetAll
      * Get Insurance by ID: GET /api/Insurance/GetById?id={id}
      * Add Insurance: POST /api/Insurance/add
      * Request Body: CreateInsuranceDTO
      * Update Insurance: PUT /api/Insurance/Update?id={id}
      * Request Body: CreateInsuranceDTO
      * Delete Insurance: DELETE /api/Insurance/Delete?id={id}
Medical Cases
      * Get All Medical Cases: GET /api/MedicalCase/GetAll
      * Get Medical Case by ID: GET /api/MedicalCase/GetById?id={id}
      * Add Medical Case: POST /api/MedicalCase/add
      * Request Body: CreateMedicalCaseDTO
      * Update Medical Case: PUT /api/MedicalCase/Update?id={id}
      * Request Body: CreateMedicalCaseDTO
      * Delete Medical Case: DELETE /api/MedicalCase/Delete?id={id}
Operations
      * Get All Operations: GET /api/Operation/GetAll
      * Get Operation by ID: GET /api/Operation/GetById?id={id}
      * Add Operation: POST /api/Operation/add
      * Request Body: CreateOperationDTO
      * Update Operation: PUT /api/Operation/Update?id={id}
      * Request Body: CreateOperationDTO
      * Delete Operation: DELETE /api/Operation/Delete?id={id}
Patients
      * Get All Patients: GET /api/Patient/GetAll
      * Get Patient by ID: GET /api/Patient/GetById?id={id}
      * Add Patient: POST /api/Patient/add
      * Request Body: CreatePatientDTO
      * Update Patient: PUT /api/Patient/Update?id={id}
      * Request Body: CreatePatientDTO
      * Delete Patient: DELETE /api/Patient/Delete?id={id}
Research
      * Get All Research: GET /api/Research/GetAll
      * Get Research by ID: GET /api/Research/GetById?id={id}
      * Add Research: POST /api/Research/add
      * Request Body: CreateResearchDTO
      * Update Research: PUT /api/Research/Update?id={id}
      * Request Body: CreateResearchDTO
      * Delete Research: DELETE /api/Research/Delete?id={id}
________________


Schemas
Authentication
      * CreateUserDTO

         * username (string)
         * password (string)
         * doctorId (integer)
         * LoginUserDTO

            * username (string)
            * password (string)
            * UserDTO

               * id (integer)
               * username (string)
               * accessToken (string)
               * doctorId (integer)
Diagnosis
               * CreateDiagnosisDTO
               * diagnoseDescription (string, nullable)
Doctor
               * CreateDoctorDTO
               * doctorName (string, nullable)
               * doctorSurname (string, nullable)
Insurance
               * CreateInsuranceDTO
               * insuranceName (string, nullable)
               * insuranceCoverageAmount (double)
Medical Case
               * CreateMedicalCaseDTO
               * caseStartDate (date-time)
               * caseEndDate (date-time, nullable)
               * patientId (integer, nullable)
               * insuranceId (integer, nullable)
Operations
               * CreateOperationDTO
               * operationName (string, nullable)
               * operationCost (double)
Patient
               * CreatePatientDTO
               * patientName (string, nullable)
               * patientSurname (string, nullable)
               * patientPatronymic (string, nullable)
               * patientDateOfBirth (DateOnly)
Research
               * CreateResearchDTO
               * researchName (string, nullable)
               * researchNormalValues (string, nullable)
               * researchCost (double)
________________


Security
This API uses JWT Token Authentication with the Bearer scheme.
               * Authorization Header:
Authorization: Bearer <your-token>
________________


Getting Started
Prerequisites
                  * .NET 8 SDK
                  * Postman or similar API testing tools
Setup
                  1. Clone the repository.
                  2. Build the project using .NET 8 SDK.
                  3. Configure the appsettings.json for database connection and JWT settings.
                  4. Run the API.
Usage
                  1. Register a user using /api/Authentication/register.
                  2. Login using /api/Authentication/login to obtain a JWT token.
                  3. Use the token in the Authorization header for secure endpoints.
________________


Feel free to contribute or raise issues in the repository.
