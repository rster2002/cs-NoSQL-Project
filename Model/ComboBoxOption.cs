using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class ComboBoxOption {
        public string Label { get; set; }
        public object Value { get; set; }

        public ComboBoxOption(object value) {
            Value = value.ToString();
            this.Value = value;
        }

        public ComboBoxOption(string label, object value) {
            this.Label = label;
            this.Value = value;
        }

        public override string ToString() {
            return Label;
        }
    }
}
