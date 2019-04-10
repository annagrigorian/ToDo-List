using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List_Class_Library
{
    public class ToDoItem
    {
        #region Properties

        public string Category { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

        public bool IsCompleted { get; set; }

        #endregion

        #region Constructors

        public ToDoItem(string category, string name)
        {
            Category = category;
            Name = name;
        }

        public ToDoItem() : this("No Category", "UnNamed")
        { }

        #endregion

        #region Required Overrides

        public override string ToString()
        {
            return $"Catgory is {Category} \n  Name  is {Name} \n\t IsCompleted {((IsCompleted) ? "Yes" : "No")}";
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

        public static bool operator ==(ToDoItem todo1, ToDoItem todo2)
        {
            return ((todo1.Name == todo2.Name)
                && (todo1.Category == todo2.Category)
                && (todo1.ID == todo2.ID)
                && (todo1.IsCompleted == todo2.IsCompleted));
        }

        public static bool operator !=(ToDoItem todo1, ToDoItem todo2)
        {
            return !(todo1 == todo2);
        }

        #endregion

    }
}