using System.Collections.Generic;
using System.Threading.Tasks;
using Phoneword.ViewModel;


	public interface IRestService
	{
		Task<List<Student>> RefreshDataAsync ();

		Task SaveTodoItemAsync (Student item, bool isNewItem);

		Task DeleteTodoItemAsync (int id);
	}

