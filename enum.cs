
namespace Sparrow
{
	public class SPEvents
	{
		public const string ButtonTriggered = "triggered";
		public const string Touch = "touch";
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
