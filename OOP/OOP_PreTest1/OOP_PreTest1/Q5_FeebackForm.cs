public class FeedbackForm
{
    public Type feedbackType { get; set; }
    public string feedback { get; set; }
    public Name userName { get; set; }
    public string userEmail { get; set; }

    //Constructor
    public FeedbackForm
        (Type type, string userfeedback, Name username, string useremail)
    {
        feedbackType = type;
        feedback = userfeedback;
        userName = username;
        userEmail = useremail;
    }

    //Method to submit
    public void submitForm()
    {
        Console.WriteLine("Feedback Submitted");
    }
}

public class Type
{
    public string bugs { get; set; }
    public string questions { get; set; }
    public string comments { get; set; }
}

public class Name
{
    public string fName { get; set; }
    public string lName { get; set; }
}