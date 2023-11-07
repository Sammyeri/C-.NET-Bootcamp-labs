import { Component } from '@angular/core';
import { Todo } from './toDo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'todoapp';

  newTask: string = "";

  todos: Todo[] = [
    {task: "Clean my room", completed: false},
    {task: "Bring in patio furniture", completed: true},
    {task: "Clean the garage", completed: false},
    {task: "Shop at H-Mart", completed: false},
    {task: "Ride a zebra", completed: true}
  ];

  completeTask(index : number) : void{
    this.todos[index].completed = true;
    alert(this.todos[index].task + " is complete!");
  };

  addTask() : void{
    let todo= {task: this.newTask, completed: false};
    this.todos.push(todo);
    this.newTask = "";
  };
}
