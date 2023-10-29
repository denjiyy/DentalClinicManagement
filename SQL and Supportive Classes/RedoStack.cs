using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicManagement.Classes
{
    class UndoRedoStack<T>
    {
        private Stack<Control> undoStack = new Stack<Control>();
        private Stack<Control> redoStack = new Stack<Control>();

        public void Push(Control item)
        {
            redoStack.Push(item);
            redoStack.Clear();
        }

        public void Redo(Control panel)
        {
            if (redoStack.Count > 0)
            {
                Control item = redoStack.Pop();
                undoStack.Push(item);
                panel.Controls.Add((Control)(object)item);
            }
        }
    }
}
