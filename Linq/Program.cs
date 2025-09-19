using LinqExamples;

class Program
{
    static void Main(string[] args)
    {
        SelectExample.Execute();
        SelectTypedExample.Execute();
        SelectAdvancedExample.Execute();
        SelectManyExample.Execute();

        MethodVsQuery.Execute();
        LinqInterfacesExample.Execute();
        LinqInterfaceExample2.Execute();
        WhereGreaterThanExample.Execute();
        WhereObjectsExample.Execute();
        FirstLastElementAtSingleExample.Execute();
        AllAnyContainsExample.Execute();
        OrderByExample.Execute();
        CustomComparerOrderByExample.Execute();
        CountSumExample.Execute();
        MaxMinAverageExample.Execute();
        GroupByParityExample.Execute();
        GroupByCategoryExample.Execute();
    }
}
