using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gate_system.Models;
using Gate_system.Repos;

namespace Gate_system
{
    public class WorkerSimulationService
    {
        public void SimulationOfFebruary()
        {
            DateTime simulationDate = new DateTime(2023, 02, 1, 08, 0, 0);
            var RandomizerService = new RandomizerService();
            var GateService = new GateService();
            int reportId = 0;
            var reports = new List<ReportItem>();

            for(int februaryDay = 1; februaryDay <= 28 ; februaryDay++) 
            {

                DateTime resetedDateForNextDay = new DateTime(2023, 02, februaryDay, 08, 0, 0); //This seems very wrong to do. But for now could not find a better solution.
                simulationDate = resetedDateForNextDay;

                foreach (Worker worker in WorkerRepository.workers)
                {
                    while (simulationDate.Hour < 17)      
                    {
                       reports.Add(new ReportItem(reportId++, worker.FirstName, worker.LastName, simulationDate, RandomizerService.RandomizeGate().GateName, GateService.TryGate(worker, RandomizerService.RandomizeGate()), RandomizerService.RandomizeGate().GateFunction));
                       simulationDate = simulationDate.AddMinutes(RandomizerService.RandomizeHour());
                    }
                    DateTime resetedDateForNextWorker = new DateTime(2023, 02, februaryDay, 08, 0, 0); //This seems very wrong to do. But for now could not find a better solution.
                    simulationDate = resetedDateForNextWorker;
                }
            }
        }
    }
}
