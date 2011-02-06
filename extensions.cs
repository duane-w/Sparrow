using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using System;
using System.Collections.Generic;

namespace Sparrow
{
	public partial class SPButton
	{
		public const string EventTriggered = "triggered";
	}
	
	public delegate void EventDispatch (SPTouchEvent e);
	
	public partial class SPEventDispatcher 
	{
		Dictionary<EventDispatch,Dispatcher> dispatchObjects = new Dictionary<EventDispatch,Dispatcher>();
		
		public void AddEventListener (EventDispatch action, string eventType)
		{
			AddEventListener (action, eventType, false);
		}
		
		public void AddEventListener (EventDispatch action, string eventType, bool retain)
		{
			var dispatcher = new Dispatcher (action);
			_AddEventListener (Dispatcher.InvokeSelector, dispatcher, eventType, retain);
			dispatchObjects.Add(action, dispatcher);
		}
		
		public void RemoveEventListner (EventDispatch action, string eventType)
		{
			Dispatcher dispatcher = null;
			if (dispatchObjects.TryGetValue (action, out dispatcher))
			{
				dispatchObjects.Remove (action);
				_RemoveEventListener (Dispatcher.InvokeSelector, dispatcher, eventType);
			}
		}
	}
	
	[Register ("__SparrowClassDispatcher")]
	class Dispatcher : SPEvent 
	{
		public static Selector InvokeSelector = new Selector ("invoke:");
		EventDispatch Action;
		public Dispatcher (EventDispatch action) { this.Action = action; }
		
		[Export ("invoke:")]
		[Preserve (Conditional = true)]
		public void Apply (SPTouchEvent e) 
		{
			Action (e); 
		}
	}
}
