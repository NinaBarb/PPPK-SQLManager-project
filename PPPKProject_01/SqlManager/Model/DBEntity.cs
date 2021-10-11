﻿using SqlManager.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlManager.Model
{
    class DBEntity
    {
        private readonly Lazy<IEnumerable<Column>> columns;

        public DBEntity()
        {
            columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetColumns(this));
        }

        public IList<Column> Columns
        {
            get => new List<Column>(columns.Value);
        }

        public string Name { get; set; }
        public string Schema { get; set; }
        public Database Database { get; set; }
        public override string ToString() => $"{Schema}.{Name}";
    }
}
