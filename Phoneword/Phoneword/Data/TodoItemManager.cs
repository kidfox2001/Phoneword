using Phoneword.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


	public class TodoItemManager
	{
		IRestService restService;

		public TodoItemManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<Student>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

		public Task SaveTaskAsync (Student item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync (item, isNewItem);
		}

		public Task DeleteTaskAsync (Student item)
		{
			return restService.DeleteTodoItemAsync (item.ID);
		}
	}

