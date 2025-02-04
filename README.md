title GPA Calculator Class Diagram
classDiagram
    class GPACalculator {
        - double gpa_sum
        - int n
        - double maxGPA
        - double minGPA
        + void setGPA(double gpa)
        + double getGPAX()
        + double getMaxGPA()
        + double getMinGPA()
        + int getStudentCount()
        + string getGPAInfo()
    }
    
    class Form1 {
        - GPACalculator gPACalculator
        + Form1()
        + void button1_Click(object sender, EventArgs e)
        + void btn_clear_Click(object sender, EventArgs e)
        + void showGradeInfo()
    }
    
    Form1 --> GPACalculator : Uses
