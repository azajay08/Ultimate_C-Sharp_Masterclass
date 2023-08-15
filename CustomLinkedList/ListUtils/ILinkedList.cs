namespace CustomLinkedList.ListUtils;

public interface ILinkedList<T> : ICollection<T>
{
	void AddToFront(T item);
	void AddToBack(T item);
}
