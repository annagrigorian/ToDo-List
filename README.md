## ToDo List Class Library

Here's represented a class library which can be used while creating a ToDo List Application.
There are methods in this library, that ease creating, 
using and extending Todo List and manipulating with it's objects.

First you have to attach the reference to your project then create ToDo items by using ToDoItem
class and noting the Category and Name of the object. Here's an example
~~~csharp
ToDoItem todo1 = new ToDoItem("Sport", "Squats");           
ToDoItem todo2 = new ToDoItem("Coding", "Create Class Library");
ToDoItem todo3 = new ToDoItem("Break", "Have some rest buddy!!");
ToDoItem todo4 = new ToDoItem("Sport", "Abs Workout");
ToDoItem todo5 = new ToDoItem("Sport", "Burpees");
~~~

Then by creating ToDoList object and using it's Add method you fill the list with your ToDos.
~~~csharp
ToDoList myToDos = new ToDoList();
myToDos.Add(todo1);
myToDos.Add(todo2);
myToDos.Add(todo3);
myToDos.Add(todo4);
myToDos.Add(todo5);
~~~

There are also other methods that allow you to make actions with your ToDo List
* ```Remove()```           Removes all the completed ToDo items
* ```ShowAll()```          Returns the ToDo List
* ```ShowCompleted()```    Returns all the completed ToDo items
* ```ShowNotCompleted()``` Returns all ToDo items that are not completed
* ```GroupBy()```          Groups ToDo list by the Categories of the items.

Example : 
~~~csharp
var groups = myToDos.GroupBy();

foreach (var item in groups)
{
    Console.WriteLine(item.Key);
    foreach (var o in item)
    {
        Console.WriteLine(o);
    }
}
~~~
Output is:
~~~csharp
Sport
Catgory is Sport
  Name  is Squats
         IsCompleted No
Catgory is Sport
  Name  is Abs Workout
         IsCompleted No
Catgory is Sport
  Name  is Burpees
         IsCompleted No
Coding
Catgory is Coding
  Name  is Create Class Library
         IsCompleted No
Break
Catgory is Break
  Name  is Have some rest buddy!!
         IsCompleted No
~~~
