using System.Collections;

namespace Iterator
{

	internal class Spisok<T> : IEnumerable<T>, ICollection<T>, IEnumerator<T>
	{
		class Node
		{
			public T info;
			public Node? prev, next;
			public Node(T info, Node? prev, Node? next)
			{
				this.prev = prev;
				this.info = info;
				this.next = next;
			}
		}
		Node? head, tail, iterator;
		public int Count
		{
			get
			{
				int count = 0;
				for (Node current = head; current != null; current = current.next)
				{
					count++;
				}
				return count;
			}
		}

		public Spisok()
		{
			head = tail = null;
			iterator = null;
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (Node current = head; current != null; current = current.next)
			{
				yield return current.info;
			}
			//return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(T item)
		{
			if (head == null)
			{
				head = new Node(item, null, null);
				tail = head;
			}
			else
			{
				Node current = new Node(item, tail, null);
				tail.next = current;
				tail = current;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		public void Clear()
		{
			head = null;
		}

		public bool Contains(T item)
		{
			for (Node current = head; current != null; current = current.next)
			{
				if (current.info.Equals(item)) return true;
			}
			return false;
		}

		Node Search(T item)
		{
			for (Node current = head; current != null; current = current.next)
			{
				if (current.info.Equals(item)) return current;
			}
			return null;
		}

		public bool Remove(T item)
		{
			Node current = Search(item);
			if (current == null)
			{
				Console.WriteLine("Can't be finded");
				return false;
			}
			else if (current == head)
			{
				current.next.prev = null;
				head = current.next;
				current.next = null;
				return true;
			}
			else if (current == tail)
			{
				current.prev.next = null;
				tail = current.prev;
				current.prev = null;
				return true;
			}
			else
			{
				current.prev.next = current.next;
				current.next.prev = current.prev;
				current.prev = null;
				current.next = null;
				return true;
			}
		}

		public void CopyTo(T[] arr, int index)
		{
			throw new NotImplementedException();
		}

		public T Current
		{
			get
			{
				return iterator.info;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				return Current;
			}
		}
		public bool MoveNext()
		{
			if (iterator == null)
			{
				iterator = head;
				return true;
			}
			if (iterator != tail)
			{
				iterator = iterator.next;
				return true;
				Reset();
			}
			return false;

		}

		public void Reset()
		{
			iterator = null;
		}

		public void Dispose() { }
	}
}
