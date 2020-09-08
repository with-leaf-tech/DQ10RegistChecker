using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10RegistChecker {
    public class RegistSet {

        public string Name { get; set; }
        public RegistGroupEntity[] RegistEntityList { get; set; }

        public RegistSet(string name, RegistGroupEntity[] list) {
            Name = name;
            RegistEntityList = list;
        }
    }
}
