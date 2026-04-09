📌 Project Title
Employee Management System with Machine Learning

📖 Description
This project is a simple but complete system to manage employees in a company. It also includes a machine learning model to predict employee salary based on experience, department, and attendance.
The goal of this project is to demonstrate practical skills in:
Database design
Backend development
Machine learning integration

🛠️ Technologies Used
MySQL
Python (Flask)
ASP.NET Core (.NET)
Scikit-learn

⚙️ Features
Store and manage employee data
Track attendance and departments
REST API using Python and .NET
Salary prediction using machine learning
🧠 Machine Learning Part
The model uses a simple Linear Regression algorithm.
Input features:
Experience (years)
Department
Attendance rate
Output:
Predicted salary
The model is trained using a small realistic dataset and evaluated using MAE and R² score.

▶️ How to Run
1. Setup Database
Run:
schema.sql
sample_data.sql
2. Train Machine Learning Model
	cd ml-module
python train_model.py
3. Run Python Backend
cd backend-python
pip install -r requirements.txt
python app.py
4. Run .NET Backend
		dotnet run
📡 Example API (Prediction)
POST /predict-salary
Example JSON:
		{
		"experience": 3,
		"attendance_rate": 0.9,
		"department_Finance": 0,
		"department_HR": 1,
		"department_IT": 0
		}


🎯 Skills Demonstrated
Relational database design
SQL queries and optimization
REST API development
Machine learning model training and integration
✍️ Author Note
This project was developed as part of my preparation for graduate studies in AI and Data Science




