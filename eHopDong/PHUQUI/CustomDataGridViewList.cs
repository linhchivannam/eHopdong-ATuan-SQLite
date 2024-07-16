using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHungPhu.PHUQUI
{
    public class CustomDataGridViewList : DataGridView
    {
        public event EventHandler TabEnterDownKey;

        public event EventHandler EscKeyEvent;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (base.CurrentCell == null)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            if (base.CurrentCell.OwningColumn.Name.CompareTo("ma") == 0 || base.CurrentCell.OwningColumn.Name.CompareTo("soluong") == 0 || base.CurrentCell.OwningColumn.Name.CompareTo("dongia") == 0)
            {
                if ((keyData == Keys.Tab || keyData == Keys.Return || keyData == Keys.Down) && base.CurrentCell.IsInEditMode)
                {
                    if (this.TabEnterDownKey != null)
                    {
                        this.TabEnterDownKey(new object(), new EventArgs());
                    }
                    return true;
                }
                if (keyData == Keys.Escape && this.EscKeyEvent != null)
                {
                    this.EscKeyEvent(new object(), new EventArgs());
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
