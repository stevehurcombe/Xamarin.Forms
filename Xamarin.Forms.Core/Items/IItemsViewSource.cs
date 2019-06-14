using System;
using System.ComponentModel;

namespace Xamarin.Forms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IItemsViewSource : IDisposable
	{
		int Count { get; }
		object this[int index] { get; }
	}
}
