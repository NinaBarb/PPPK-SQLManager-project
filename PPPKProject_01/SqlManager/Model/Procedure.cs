using SqlManager.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlManager.Model
{
    class Procedure
    {
        private readonly Lazy<IEnumerable<Params>> parameters;

        public Procedure()
        {
            parameters = new Lazy<IEnumerable<Params>>(() => RepositoryFactory.GetRepository().GetParameters(this));
        }

        public IList<Params> Parameters
        {
            get => new List<Params>(parameters.Value);
        }
        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }
        public override string ToString() => $"{Name}";
    }
}
