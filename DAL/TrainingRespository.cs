using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationnn.DHC
{
    interface TrainingRespository
    {

        IEnumerable<TrainingDTO> GetTraining();
        Training GetTraining(int id);

        void UpdateTraining(Training training);

        void DeleteTraining(int id);

        void CreateTraining(Training training);

        void SaveChanges();
    }
}
