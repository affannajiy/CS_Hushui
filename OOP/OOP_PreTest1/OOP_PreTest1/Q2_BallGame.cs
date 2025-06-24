public class Ball
{
    public double positionX { get; set; }
    public double positionY { get; set; }

    //Constructor
    public Ball(double x, double y)
    {
        positionX = x;
        positionY = y;
    }
}

public class Board
{
    private List<Ball> Balls = new List<Ball>();
    
    //Method to Add Ball
    public void AddBall(Ball ball)
    {
        Balls.Add(ball);
    }

    //Method to Save Board (Basic)
    public void SaveBoard()
    {
        Console.WriteLine("Board Saved");
        foreach (var ball in Balls)
        {
            Console.WriteLine("Ball Position");
            Console.WriteLine("$X: {ball.positionX}, Y: {ball.positionY}");
        }
    }

    //Method to Save Board to File
    public void SaveBoardFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var ball in Balls)
            {
                writer.WriteLine("Ball Position");
                writer.WriteLine("$X: {ball.positionX}, Y: {ball.positionY}");
            }
        }
    }
}