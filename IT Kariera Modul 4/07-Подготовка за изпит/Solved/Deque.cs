using System.Collections.Generic;

namespace Trains_Exam
{
	public class Deque<T>
	{
		private Stack<T> frontBuff = new Stack<T>();
		private Stack<T> backBuff = new Stack<T>();
		public int BackCount { get; private set; }
		public int FrontCount { get; private set; }
		public int count;
		public int Count
        {
            get { return BackCount + FrontCount; }
			private set { }
        }
        
		public void AddFront(T item)
		{
			frontBuff.Push(item);
			FrontCount++;
		}
		public void AddBack(T item)
		{
			backBuff.Push(item);
			BackCount++;
		}
		public T RemoveFront()
		{
			return frontBuff.Pop();
		}
		public T RemoveBack()
		{
			return backBuff.Pop();
		}
		public T GetFront()
		{
			try
			{
				return frontBuff.Peek();
			}
			catch
			{
				return default;
			}
		}
		public T GetBack()
		{
			try
			{
				return backBuff.Peek();
			}
			catch
			{
				return default;
			}
		}
	}

}