class Point2D
{
    double _x;
    public double _y;

    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }

    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
}