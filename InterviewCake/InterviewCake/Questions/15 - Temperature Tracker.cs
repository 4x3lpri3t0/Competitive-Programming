using System;

public class TempTracker
{
    // For mode
    private int[] _occurrences = new int[111];  // Array of 0s at indices 0..110 (Fahrenheit)
    private int _maxOccurrences;
    private int? _mode;

    // For mean
    private int _numberOfReadings;
    private int _totalSum;
    private double? _mean;  // Mean should be double

    // For min and max
    private int _minTemp = int.MaxValue;
    private int _maxTemp = int.MinValue;

    public void Insert(int temperature)
    {
        // For mode
        _occurrences[temperature]++;
        if (_occurrences[temperature] > _maxOccurrences)
        {
            _mode = temperature;
            _maxOccurrences = _occurrences[temperature];
        }

        // For mean
        _numberOfReadings++;
        _totalSum += temperature;
        _mean = (double)_totalSum / _numberOfReadings;

        // For min and max
        _maxTemp = Math.Max(_maxTemp, temperature);
        _minTemp = Math.Min(_minTemp, temperature);
    }

    public int? GetMax()
    {
        return _maxTemp;
    }

    public int? GetMin()
    {
        return _minTemp;
    }

    public double? GetMean()
    {
        return _mean;
    }

    public int? GetMode()
    {
        return _mode;
    }
}