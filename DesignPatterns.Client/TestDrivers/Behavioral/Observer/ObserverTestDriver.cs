using DesignPatterns.Library.Patterns.Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Observer
{
    public static class ObserverTestDriver
    {
        public static void RunTest()
        {
            var changeManager = new SimpleChangeManager();
            var subject = new Subject(changeManager);
            var pieChart = new PieChart();
            var barGraph = new BarGraph();

            System.Console.WriteLine($"PieChart default value is {pieChart.ObserverValue}");
            System.Console.WriteLine($"BarGraph default value is {barGraph.ObserverValue}");

            subject.Attach(pieChart);
            subject.Attach(barGraph);

            subject.ChangeValue();

            System.Console.WriteLine($"PieChart value after subject change is {pieChart.ObserverValue}");
            System.Console.WriteLine($"BarGraph value after subject change is {barGraph.ObserverValue}");
        }
    }
}
