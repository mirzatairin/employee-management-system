@app.route('/predict-salary', methods=['POST'])
def predict_salary():
    data = request.json

    input_data = [[
        data['experience'],
        data['attendance_rate'],
        data['department_Finance'],
        data['department_HR'],
        data['department_IT']
    ]]

    prediction = model.predict(input_data)
    return jsonify({"predicted_salary": float(prediction[0])})
