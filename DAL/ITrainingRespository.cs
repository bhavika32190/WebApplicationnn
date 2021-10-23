using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationnn.DHC
{
    interface ITrainingRespository : IDisposable
    {
        IEnumerable<TrainingDTO> GetTrainings();
        Training GetTrainer(int id);

        void UpdateTrainer(Trainer trainer);

        void DeleteTrainer(int id);

    }
}
