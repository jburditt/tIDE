using Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPlugin
{
    public partial class NPCDialog : Form
    {
        public NPC Selected { get; set; } = new NPC();

        public NPCDialog()
        {
            InitializeComponent();
        }
    }
}
