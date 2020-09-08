using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10RegistChecker {
    public class RegistGroupEntity {
        public string Name { get; set; }
        public string[] Parts { get; set; }
        public int Count { get; set; }

        public RegistGroupEntity((string name, string[] parts, int count) value) {
            Name = value.name;
            Parts = value.parts;
            Count = value.count;
        }
        public (string, string[], int) getRegistData() {
            return (Name, Parts, Count);
        }
    }
}
