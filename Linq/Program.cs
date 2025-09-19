using LinqExamples;

class Program
{
    static void Main(string[] args)
    {
        MethodVsQuery.Execute();
        LinqInterfacesExample.Execute();
        LinqInterfaceExample2.Execute();
        SelectExample.Execute();
        SelectTypedExample.Execute();
        SelectAdvancedExample.Execute();
        SelectManyExample.Execute();
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
        JoinExample.Execute();
        GroupJoinExample.Execute();
    }
}
