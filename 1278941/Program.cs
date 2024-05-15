using _1278941.DIExperiments;
using _1278941.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositoryFactory factory = new RepositoryFactory();
            ExperimentClass experiment = new ExperimentClass(factory);
            experiment.Run();
            Console.WriteLine();
            ExperimentClass_02 experiment_02 = new ExperimentClass_02();
            experiment_02.Run(factory);
            Console.ReadLine();
        }
    }
}
