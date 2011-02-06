using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Sparrow
{
	public partial class SPButton
	{
		public const string EventTriggered = "triggered";
	}


	public partial class SPEventDispatcher 
	{
		object AddEventListener (NSAction action, string evenType, bool retain)
		{
		   var dispatcher = new Dispatcher (action);
		   //RealAddEventListener (Dispatcher.InvokeSelector, dispatcher, eventType, retain);
		   return dispatcher;
		}
	}

	[Register ("__SparrowClassDispatcher")]
	class Dispatcher : NSObject {
	   public static Selector InvokeSelector = new Selector ("invoke");
	   NSAction action;
	   [Export ("invoke")]
	   public Dispatcher (NSAction action) { this.action = action; }
	
	   [Export ("apply")]
	   [Preserve (Conditional = true)]
	   public void Apply () { action (); }
	}
}
