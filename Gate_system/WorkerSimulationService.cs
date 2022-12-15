using System;
using System.Collections.Generic;
using System.Linq;
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

            for(int februaryDay = 1; februaryDay <= 28 ; februaryDay++) 
            {
                foreach (Worker worker in WorkerRepository.workers)
                {
                    while (simulationDate.Hour < 17)
                    {

                    }
                    DateTime resetedDateForNextWorker = new DateTime(2023, 02, februaryDay, 08, 0, 0); //This seems very wrong to do. But for now could not find a better solution.
                    simulationDate = resetedDateForNextWorker;
                }
                DateTime resetedDateForNextDay = new DateTime(2023, 02, februaryDay+1, 08, 0, 0); //This seems very wrong to do. But for now could not find a better solution.
                simulationDate = resetedDateForNextDay;
            }
        }
    }
}
