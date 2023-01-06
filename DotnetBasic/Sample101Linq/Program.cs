using Sample101Linq.DataSource;

public class Program
{
    public static void Main()
    {
        AggregateOperator aggregateOperator = new AggregateOperator();
        Console.WriteLine("Count Syntax");
        aggregateOperator.CountSyntax();
        Console.WriteLine("\nCount Conditional");
        aggregateOperator.CountConditional();
        Console.WriteLine("\nNested Count");
        aggregateOperator.CountNested();
        Console.WriteLine("\nGrouped Count");
        aggregateOperator.GroupedCount();
        Console.WriteLine();

        Console.WriteLine("Sum Syntax");
        aggregateOperator.SumSyntax();
        Console.WriteLine("\nSum Projection");
        aggregateOperator.SumProjection();
        Console.WriteLine("\nSum Grouped");
        aggregateOperator.SumGrouped();
        Console.WriteLine();

        Console.WriteLine("Min Syntax");
        aggregateOperator.MinSyntax();
        Console.WriteLine("\nMin Projection");
        aggregateOperator.MinProjection();
        Console.WriteLine("\nMin Grouped");
        aggregateOperator.MinGrouped();
        Console.WriteLine("\nMin Each Grouped");
        aggregateOperator.MinEachGroup();
        Console.WriteLine();

        Console.WriteLine("Max Syntax");
        aggregateOperator.MaxSyntax();
        Console.WriteLine("\nMax Projection");
        aggregateOperator.MaxProjection();
        Console.WriteLine("\nMax Grouped");
        aggregateOperator.MaxGrouped();
        Console.WriteLine("\nMax Each Grouped");
        aggregateOperator.MaxEachGroup();
        Console.WriteLine();

        Console.WriteLine("Average Syntax");
        aggregateOperator.AverageSyntax();
        Console.WriteLine("\nAverage Projection");
        aggregateOperator.AverageProjection();
        Console.WriteLine("\nAverage Grouped");
        aggregateOperator.AverageGrouped();
        Console.WriteLine();

        Console.WriteLine("Aggregate Syntax");
        aggregateOperator.AggregateSyntax();
        Console.WriteLine("\nSeeded Aggregate");
        aggregateOperator.SeededAggregate();


    }
}