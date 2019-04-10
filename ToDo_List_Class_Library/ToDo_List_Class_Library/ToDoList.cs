using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List_Class_Library
{
    public class ToDoList : IEnumerable<ToDoItem>
    {
        private List<ToDoItem> toDos = new List<ToDoItem>();

        #region Constructors

        public ToDoList() { }

        #endregion

        #region Properties

        public int Count => toDos.Count();

        #endregion

        #region IEnumerable Interface Implementation

        public IEnumerator<ToDoItem> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return toDos[i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

        #region Helper Methods     

        public void Add(ToDoItem todo)
        {
            toDos.Add(todo);
        }

        public void Completed(ToDoItem todo)
        {
            todo.IsCompleted = true;
        }

        public void NotCompleted(ToDoItem todo)
        {
            todo.IsCompleted = false;
        }

        public IEnumerable<ToDoItem> Remove()
        {
            for (int i = 0; i < Count; i++)
            {
                if (toDos[i].IsCompleted)
                {
                    toDos.RemoveAt(i);
                }
            }
            return toDos;
        }

        public IEnumerable<ToDoItem> ShowAll()
        {
            return this.Select(t => t);
        }

        public IEnumerable<ToDoItem> ShowCompleted()
        {
            return this.Where(t => t.IsCompleted == true);
        }

        public IEnumerable<ToDoItem> ShowNotCompleted()
        {
            return this.Where(t => t.IsCompleted == false);
        }

        public IEnumerable<IGrouping<string,ToDoItem>> GroupBy()
        {
            var grouped = this.GroupBy(i => i.Category);
            return grouped;
        }

        #endregion

        #region Required Overrides

        public override string ToString()
        {
            return GetEnumerator().ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;
            else if (this.GetType() != obj.GetType()) return false;
            else return false;
        }

        public static bool operator ==(ToDoList todos1, ToDoList todos2)
        {
            return todos1 == todos2;
        }

        public static bool operator !=(ToDoList todos1, ToDoList todos2)
        {
            return !(todos1 == todos2);
        }


        #endregion

    }
}