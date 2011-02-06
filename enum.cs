
namespace Sparrow
{
	public class SPEvents
	{
		/// <summary>
		/// SP_EVENT_TYPE_TRIGGERED
		/// </summary>
		public const string ButtonTriggered = "triggered";
		/// <summary>
		/// SP_EVENT_TYPE_TOUCH
		/// </summary>
		public const string Touch = "touch";
		/// <summary>
		/// SP_EVENT_TYPE_MOVIE_COMPLETED
		/// </summary>
		public const string MovieCompleted = "movieCompleted";
		/// <summary>
		/// SP_EVENT_TYPE_ENTER_FRAME
		/// </summary>
		public const string EnterFrame = "enterFrame";
		/// <summary>
		/// SP_EVENT_TYPE_ADDED
		/// </summary>
		public const string Added = "added";
		/// <summary>
		/// SP_EVENT_TYPE_ADDED_TO_STAGE
		/// </summary>
		public const string AddedToStage = "addedToStage";
		/// <summary>
		/// SP_EVENT_TYPE_REMOVED
		/// </summary>
		public const string Remove = "removed";
		/// <summary>
		/// SP_EVENT_TYPE_REMOVED_FROM_STAGE
		/// </summary>
		public const string RemoveFromStage = "removedFromStage";
		/// <summary>
		/// SP_EVENT_TYPE_SOUND_COMPLETED
		/// </summary>
		public const string SoundCompleted = "soundCompleted";
		/// <summary>
		/// SP_EVENT_TYPE_TWEEN_STARTED
		/// </summary>
		public const string TweenStarted = "tweenStarted";
		/// <summary>
		/// SP_EVENT_TYPE_TWEEN_UPDATED
		/// </summary>
		public const string TweenUpdated = "tweenUpdated";
		/// <summary>
		/// SP_EVENT_TYPE_TWEEN_COMPLETED
		/// </summary>
		public const string TweenCompleted = "tweenCompleted";
	
		
	}
	
	public class  SPAudioSessionCategory
	{
		public const string AmbientSound     = "ambi";
		public const string SoloAmbientSound = "solo";
		public const string MediaPlayback    = "medi";
		public const string RecordAudio      = "reca";
		public const string PlayAndRecord    = "plar";
		public const string AudioProcessing  = "proc";
	}
	public enum  SPTextureFormat
	{
		FormatRGBA,
		FormatAlpha,
		FormatPvrtcRGB2,
		FormatPvrtcRGBA2,
		FormatPvrtcRGB4,
		FormatPvrtcRGBA4,
		Format565,
		Format5551,
		Format4444
	}
	public struct  SPTextureProperties
	{
		SPTextureFormat format;
		int width;
		int height;
		int numMipmaps;
		bool generateMipmaps;
		bool premultipliedAlpha;
	}
	#if false
	public struct  SPPoolInfo
	{
		Class poolClass;
		SPPoolObject *lastElement;
	}
	#endif
	public enum  SPHAlign
	{
		Left = 0,
		Center,
		Right
	}
	public enum  SPVAlign
	{
		Top = 0,
		Center,
		Bottom
	}
	public enum  SPColorSpace
	{
		RGBA,
		Alpha
	}
	public enum  SPTouchPhase
	{
		Began,
		Moved,
		Stationary,
		Ended,
		Cancelled
	}
	public enum  SPLoopType
	{
		None,
		Repeat,
		Reverse
	}
}
