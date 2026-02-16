using System;
using System.Collections.Generic;
namespace Matrix;

public class NumMatrix : object
{
	public readonly List<double[]> Rows = new();
	public int rows;
	public int columns;
	public NumMatrix(int row, int col)
	{
		rows = row;
		columns = col;

		for (int i = 1; i <= rows; i++)  
		{
			double[] temp1;
			List<double> temp2 = new();
			for (int b = 1; b <= columns; b++)
			{
				temp2.Add(0);
			}
			temp1 = temp2.ToArray();
            Rows.Add(temp1);
        }
    }
	public double this[int row, int col]
	{ 
		get => Rows[row - 1][col - 1];
		set => Rows[row - 1][col - 1] = value;
	}
	public string Value
	{
		get
		{
			string val = "";
			for (int i = 0; i <= Rows.Count - 1; i++)
			{
				double[] row = Rows[i];
				val += "[" + string.Join(", ", row) + "]\n";
			}
			return val;
		}
	}

	public int Items
	{
		get
		{
			return columns * rows;
		}

	}

	public static NumMatrix MAdd(NumMatrix a, NumMatrix b)
	{
		if (a.rows == b.rows)
		{
		}
		else throw new SizeException($"NumMatrix sizes uneven: {a.rows}x{a.columns} and {b.rows}x{b.columns}!");
		if (a.columns == b.columns)
		{
		}
		else throw new SizeException($"NumMatrix sizes uneven: {a.rows}x{a.columns} and {b.rows}x{b.columns}!");
		NumMatrix New = new NumMatrix(a.rows, a.columns);
		for (int i = 1; i <= New.rows; i++)
		{
			for (int i2 = 1; i2 <= New.columns; i2++)
			{
				New[i, i2] = a[i, i2] + b[i, i2];
			}
		}
		return New;

	}
	public static NumMatrix MSub(NumMatrix a, NumMatrix b)
	{
		if (a.rows == b.rows)
		{
		}
		else throw new SizeException($"NumMatrix sizes uneven: {a.rows}x{a.columns} and {b.rows}x{b.columns}!");
		if (a.columns == b.columns)
		{
		}
		else throw new SizeException($"NumMatrix sizes uneven: {a.rows}x{a.columns} and {b.rows}x{b.columns}!");
		NumMatrix New = new NumMatrix(a.rows, a.columns);
		for (int i = 1; i <= New.rows; i++)
		{
			for (int i2 = 1; i2 <= New.columns; i2++)
			{
				New[i, i2] = a[i, i2] - b[i, i2];
			}
		}
		return New;

	}
	public static NumMatrix ScaleA(NumMatrix ob, double scale)
	{
		NumMatrix Scaled = new(ob.rows, ob.columns);
		for (int i = 1; i <= Scaled.rows; i++)
		{
			for (int i2 = 1; i2 <= Scaled.columns; i2++)
			{
				Scaled[i, i2] = ob[i, i2] + scale;
			}
		}
		return Scaled;

	}
	public static NumMatrix ScaleS(NumMatrix ob, double scale)
	{
		NumMatrix Scaled = new(ob.rows, ob.columns);
		for (int i = 1; i <= Scaled.rows; i++)
		{
			for (int i2 = 1; i2 <= Scaled.columns; i2++)
			{
				Scaled[i, i2] = ob[i, i2] - scale;
			}
		}
		return Scaled;

	}
	public static NumMatrix ScaleM(NumMatrix ob, double scale)
	{
		NumMatrix Scaled = new(ob.rows, ob.columns);
		for (int i = 1; i <= Scaled.rows; i++)
		{
			for (int i2 = 1; i2 <= Scaled.columns; i2++)
			{
				Scaled[i, i2] = ob[i, i2] * scale;
			}
		}
		return Scaled;

	}
	public static NumMatrix ScaleD(NumMatrix ob, double scale)
	{
		NumMatrix Scaled = new(ob.rows, ob.columns);
		for (int i = 1; i <= Scaled.rows; i++)
		{
			for (int i2 = 1; i2 <= Scaled.columns; i2++)
			{
				Scaled[i, i2] = ob[i, i2] / scale;
			}
		}
		return Scaled;

	}
	public class SizeException : Exception
	{
		public SizeException(string message) : base(message) { }
	}
}

public class StringMatrix : object
{
    public readonly List<string[]> Rows = new();
    public int rows;
    public int columns;
    public StringMatrix(int row, int col)
    {
        rows = row;
        columns = col;

        for (int i = 1; i <= rows; i++)
        {
            string[] temp1;
            List<string> temp2 = new();
            for (int b = 1; b <= columns; b++)
            {
                temp2.Add(" ");
            }
            temp1 = temp2.ToArray();
            Rows.Add(temp1);
        }
    }
    public string this[int row, int col]
    {
        get => Rows[row - 1][col - 1];
        set => Rows[row - 1][col - 1] = value;
    }
    public string Value
    {
        get
        {
            string val = "";
            for (int i = 0; i <= Rows.Count - 1; i++)
            {
                string[] row = Rows[i];
                val += "[" + string.Join(", ", row) + "]\n";
            }
            return val;
        }
    }

    public int Items
    {
        get
        {
            return columns * rows;
        }

    }
    public class SizeException : Exception
    {
        public SizeException(string message) : base(message) { }
    }
}