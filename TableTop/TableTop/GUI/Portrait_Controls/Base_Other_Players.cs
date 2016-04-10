﻿namespace TableTop.GUI.Portrait_Controls
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    abstract public class Base_Other_Players
    {
        public int client_id
        {
            get;
            private set;
        }

        public Base_Other_Players(int client_id)
        {
            this.client_id = client_id;
        }

        abstract public Panel getPortrait();

        abstract public void updatePortrait(Image new_portrait);

    }
}
