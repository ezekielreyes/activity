def calculate_grade(score):
    """Returns the letter grade based on the score."""
    if 90 <= score <= 100:
        return 'A'
    elif 80 <= score < 90:
        return 'B'
    elif 70 <= score < 80:
        return 'C'
    elif 60 <= score < 70:
        return 'D'
    else:
        return 'F'

def main():
    print("Welcome to the Grade Calculator!")
    
    # Input number of subjects
    num_subjects = int(input("Enter the number of subjects: "))
    
    # Initialize total score
    total_score = 0
    
    # Collect scores for each subject
    for i in range(num_subjects):
        score = float(input(f"Enter score for subject {i + 1}: "))
        total_score += score
    
    # Calculate average score
    average_score = total_score / num_subjects
    
    # Determine the grade
    grade = calculate_grade(average_score)
    
    # Display results
    print("\nGrade Calculation Summary")
    print(f"Total Score: {total_score}")
    print(f"Average Score: {average_score:.2f}")
    print(f"Grade: {grade}")

if __name__ == "__main__":
    main()
