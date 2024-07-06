using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCGRecon.Forms
{
    public partial class Debugfrm : Form
    {
        public Debugfrm()
        {
            InitializeComponent();
        }

        public void AddLogEntry(string text) => this.listLog.Items.Add((object)text);
    }
}
