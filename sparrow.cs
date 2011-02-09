using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using System;
using MonoTouch.CoreGraphics;
using MonoTouch.AVFoundation;

namespace Sparrow 
{
	//public delegate void SPTextureDrawingBlock (IntPtr ctx);
	//public delegate void SPDrawingBlock ();

[BaseType (typeof (SPSound))]
interface SPALSound {
	//- (id)initWithData:(const void *)data size:(int)size channels:(int)channels frequency:(int)frequency          duration:(double)duration;
	[Export ("initWithData:size:channels:frequency:")]
	IntPtr Constructor (IntPtr  data, int size, int channels, int frequency, double duration);

	//@property (nonatomic, readonly) uint bufferID;
	[Export ("bufferID")]///, ArgumentSemantic.ReadOnly)]
	uint BufferID { get;  }

}

[BaseType (typeof (SPSoundChannel))]
interface SPALSoundChannel {
	//- (id)initWithSound:(SPALSound *)sound;
	[Export ("initWithSound:")]
	IntPtr Constructor (SPALSound  sound);

}

[BaseType (typeof (SPSound))]
interface SPAVSound {
	//- (id)initWithContentsOfFile:(NSString *)path duration:(double)duration;
	[Export ("initWithContentsOfFile:duration:")]
	IntPtr Constructor (string path, double duration);

	//- (AVAudioPlayer *)createPlayer;
	[Export ("createPlayer")]
	AVAudioPlayer  CreatePlayer ();

}

[BaseType (typeof (SPSoundChannel))]
interface SPAVSoundChannel {
	//- (id)initWithSound:(SPAVSound *)sound;
	[Export ("initWithSound:")]
	IntPtr Constructor (SPAVSound  sound);

}

[BaseType (typeof (NSObject))]
interface SPAudioEngine {
	[Static]
	//+ (void)start:(SPAudioSessionCategory)category;
	[Export ("start:")]
	void StartWithCategory (string category);

	//[Static]
	//+ (void)start;
	//[Export ("start")]
	///void Start ();

	[Static]
	//+ (void)stop;
	[Export ("stop")]
	void Stop ();

	[Static]
	//+ (float)masterVolume;
	[Export ("masterVolume")]
	float MasterVolume ();

	[Static]
	//+ (void)setMasterVolume:(float)volume;
	[Export ("setMasterVolume:")]
	void SetMasterVolume (float volume);

}

[BaseType (typeof (SPImage))]
interface SPBitmapChar {
	//- (id)initWithID:(int)charID texture:(SPTexture *)texture         xOffset:(float)xOffset yOffset:(float)yOffset xAdvance:(float)xAdvance;
	[Export ("initWithID:texture:xOffsetyOffset:xAdvance:")]
	IntPtr Constructor (int charID, SPTexture  texture, float xOffset, float yOffset, float xAdvance);

	//@property (nonatomic, readonly) int charID;
	[Export ("charID")]//, ArgumentSemantic.ReadOnly)]
	int CharID { get;  }

	//@property (nonatomic, readonly) float xOffset;
	[Export ("xOffset")]//, ArgumentSemantic.ReadOnly)]
	float XOffset { get;  }

	//@property (nonatomic, readonly) float yOffset;
	[Export ("yOffset")]//, ArgumentSemantic.ReadOnly)]
	float YOffset { get;  }

	//@property (nonatomic, readonly) float xAdvance;
	[Export ("xAdvance")]//, ArgumentSemantic.ReadOnly)]
	float XAdvance { get;  }

}

[BaseType (typeof (NSObject))]
interface SPBitmapFont {
	//- (id)initWithContentsOfFile:(NSString *)path texture:(SPTexture *)texture;
	[Export ("initWithContentsOfFile:texture:")]
	IntPtr Constructor (string path, SPTexture  texture);

	//- (id)initWithContentsOfFile:(NSString *)path;
	[Export ("initWithContentsOfFile:")]
	IntPtr Constructor (string path);

	//- (SPBitmapChar *)charByID:(int)charID;
	[Export ("charByID:")]
	SPBitmapChar  CharByID (int charID);

	//- (SPDisplayObject *)createDisplayObjectWithWidth:(float)width height:(float)height                                             text:(NSString *)text fontSize:(float)size color:(uint)color                                            hAlign:(SPHAlign)hAlign vAlign:(SPVAlign)vAlign                                           border:(BOOL)border;
	[Export ("createDisplayObjectWithWidth:height:textfontSize:color:hAlignvAlign:")]
	SPDisplayObject  CreateDisplayObjectWithWidth (float width, float height, string text, float size, uint color, SPHAlign hAlign, SPVAlign vAlign, bool border);

	//@property (nonatomic, readonly) NSString *name;
	[Export ("name")]//, ArgumentSemantic.ReadOnly)]
	string Name { get;  }

	//@property (nonatomic, readonly) float size;
	[Export ("size")]//, ArgumentSemantic.ReadOnly)]
	float Size { get;  }

	//@property (nonatomic, assign)   float lineHeight;
	[Export ("lineHeight", ArgumentSemantic.Assign)]
	float LineHeight { get; set;  }

}

[BaseType (typeof (SPDisplayObjectContainer))]
interface SPButton {
	//- (id)initWithUpState:(SPTexture*)upState downState:(SPTexture*)downState;
	[Export ("initWithUpState:downState:")]
	IntPtr Constructor (SPTexture upState, SPTexture downState);

	//- (id)initWithUpState:(SPTexture*)upState text:(NSString*)text;
	[Export ("initWithUpState:text:")]
	IntPtr Constructor (SPTexture upState, string text);

	//- (id)initWithUpState:(SPTexture*)upState;
	[Export ("initWithUpState:")]
	IntPtr Constructor (SPTexture upState);

	[Static]
	//+ (SPButton*)buttonWithUpState:(SPTexture*)upState downState:(SPTexture*)downState;
	[Export ("buttonWithUpState:downState:")]
	SPButton ButtonWithUpState (SPTexture upState, SPTexture downState);

	[Static]
	//+ (SPButton*)buttonWithUpState:(SPTexture*)upState text:(NSString*)text;
	[Export ("buttonWithUpState:text:")]
	SPButton ButtonWithUpState (SPTexture upState, string text);

	[Static]
	//+ (SPButton*)buttonWithUpState:(SPTexture*)upState;
	[Export ("buttonWithUpState:")]
	SPButton ButtonWithUpState (SPTexture upState);

	//@property (nonatomic, assign) float scaleWhenDown;
	[Export ("scaleWhenDown", ArgumentSemantic.Assign)]
	float ScaleWhenDown { get; set;  }

	//@property (nonatomic, assign) float alphaWhenDisabled;
	[Export ("alphaWhenDisabled", ArgumentSemantic.Assign)]
	float AlphaWhenDisabled { get; set;  }

	//@property (nonatomic, assign) BOOL  enabled;
	[Export ("enabled", ArgumentSemantic.Assign)]
	bool Enabled { get; set;  }

	//@property (nonatomic, copy)   NSString *text;
	[Export ("text", ArgumentSemantic.Copy)]
	string Text { get; set;  }

	//@property (nonatomic, copy)   NSString *fontName;
	[Export ("fontName", ArgumentSemantic.Copy)]
	string FontName { get; set;  }

	//@property (nonatomic, assign) float fontSize;
	[Export ("fontSize", ArgumentSemantic.Assign)]
	float FontSize { get; set;  }

	//@property (nonatomic, assign) uint fontColor;
	[Export ("fontColor", ArgumentSemantic.Assign)]
	uint FontColor { get; set;  }

	//@property (nonatomic, retain) SPTexture *upState;
	[Export ("upState", ArgumentSemantic.Retain)]
	SPTexture UpState { get; set;  }

	//@property (nonatomic, retain) SPTexture *downState;
	[Export ("downState", ArgumentSemantic.Retain)]
	SPTexture DownState { get; set;  }

	//@property (nonatomic, copy)   SPRectangle *textBounds;
	[Export ("textBounds", ArgumentSemantic.Copy)]
	SPRectangle TextBounds { get; set;  }

}

[BaseType (typeof (SPSprite))]
interface SPCompiledSprite {
	//- (BOOL)compile;
	[Export ("compile")]
	bool Compile ();

	[Static]
	//+ (SPCompiledSprite *)sprite;
	[Export ("sprite")]
	SPCompiledSprite  Sprite ();

}

[BaseType (typeof (NSObject))]
interface SPDelayedInvocation {
	//- (id)initWithTarget:(id)target delay:(double)time;
	[Export ("initWithTarget:delay:")]
	IntPtr Constructor (NSObject target, double time);

	[Static]
	//+ (SPDelayedInvocation*)invocationWithTarget:(id)target delay:(double)time;
	[Export ("invocationWithTarget:delay:")]
	SPDelayedInvocation InvocationWithTarget (NSObject target, double time);

	//@property (nonatomic, readonly) id target;
	[Export ("target")]//, ArgumentSemantic.ReadOnly)]
	SPDelayedInvocation Target { get;  }

	//@property (nonatomic, readonly) double totalTime;
	[Export ("totalTime")]//, ArgumentSemantic.ReadOnly)]
	double TotalTime { get;  }

	//@property (nonatomic, assign)   double currentTime;
	[Export ("currentTime", ArgumentSemantic.Assign)]
	double CurrentTime { get; set;  }

}

[BaseType (typeof (SPEventDispatcher))]
interface SPDisplayObject {
	//- (void)render:(SPRenderSupport*)support;
	[Export ("render:")]
	void Render (SPRenderSupport support);

	//- (void)removeFromParent;
	[Export ("removeFromParent")]
	void RemoveFromParent ();

	//- (SPMatrix*)transformationMatrixToSpace:(SPDisplayObject*)targetCoordinateSpace;
	[Export ("transformationMatrixToSpace:")]
	SPMatrix TransformationMatrixToSpace (SPDisplayObject targetCoordinateSpace);

	//- (SPRectangle*)boundsInSpace:(SPDisplayObject*)targetCoordinateSpace;
	[Export ("boundsInSpace:")]
	SPRectangle BoundsInSpace (SPDisplayObject targetCoordinateSpace);

	//- (SPPoint*)localToGlobal:(SPPoint*)localPoint;
	[Export ("localToGlobal:")]
	SPPoint LocalToGlobal (SPPoint localPoint);

	//- (SPPoint*)globalToLocal:(SPPoint*)globalPoint;
	[Export ("globalToLocal:")]
	SPPoint GlobalToLocal (SPPoint globalPoint);

	//- (SPDisplayObject*)hitTestPoint:(SPPoint*)localPoint forTouch:(BOOL)isTouch;
	[Export ("hitTestPoint:forTouch:")]
	SPDisplayObject HitTestPoint (SPPoint localPoint, bool isTouch);

	//@property (nonatomic, assign) float x;
	[Export ("x", ArgumentSemantic.Assign)]
	float X { get; set;  }

	//@property (nonatomic, assign) float y;
	[Export ("y", ArgumentSemantic.Assign)]
	float Y { get; set;  }

	//@property (nonatomic, assign) float scaleX;
	[Export ("scaleX", ArgumentSemantic.Assign)]
	float ScaleX { get; set;  }

	//@property (nonatomic, assign) float scaleY;
	[Export ("scaleY", ArgumentSemantic.Assign)]
	float ScaleY { get; set;  }

	//@property (nonatomic, assign) float width;
	[Export ("width", ArgumentSemantic.Assign)]
	float Width { get; set;  }

	//@property (nonatomic, assign) float height;
	[Export ("height", ArgumentSemantic.Assign)]
	float Height { get; set;  }

	//@property (nonatomic, assign) float rotation;
	[Export ("rotation", ArgumentSemantic.Assign)]
	float Rotation { get; set;  }

	//@property (nonatomic, assign) float alpha;
	[Export ("alpha", ArgumentSemantic.Assign)]
	float Alpha { get; set;  }

	//@property (nonatomic, assign) BOOL visible;
	[Export ("visible", ArgumentSemantic.Assign)]
	bool Visible { get; set;  }

	//@property (nonatomic, assign) BOOL touchable;
	[Export ("touchable", ArgumentSemantic.Assign)]
	bool Touchable { get; set;  }

	//@property (nonatomic, readonly) SPRectangle *bounds;
	[Export ("bounds")]//, ArgumentSemantic.ReadOnly)]
	SPRectangle Bounds { get;  }

	//@property (nonatomic, readonly) SPDisplayObjectContainer *parent;
	[Export ("parent")]//, ArgumentSemantic.ReadOnly)]
	SPDisplayObjectContainer Parent { get;  }

	//@property (nonatomic, readonly) SPDisplayObject *root;
	[Export ("root")]//, ArgumentSemantic.ReadOnly)]
	SPDisplayObject Root { get;  }

	//@property (nonatomic, readonly) SPStage *stage;
	[Export ("stage")]//, ArgumentSemantic.ReadOnly)]
	SPStage Stage { get;  }

	//@property (nonatomic, readonly) SPMatrix *transformationMatrix;
	[Export ("transformationMatrix")]//, ArgumentSemantic.ReadOnly)]
	SPMatrix TransformationMatrix { get;  }

	//@property (nonatomic, copy) NSString *name;
	[Export ("name", ArgumentSemantic.Copy)]
	string Name { get; set;  }

}

[BaseType (typeof (SPDisplayObject))]
interface SPDisplayObjectContainer {
	//- (void)addChild:(SPDisplayObject *)child;
	[Export ("addChild:")]
	void AddChild (SPDisplayObject  child);

	//- (void)addChild:(SPDisplayObject *)child atIndex:(int)index;
	[Export ("addChild:atIndex:")]
	void AddChild (SPDisplayObject  child, int index);

	//- (BOOL)containsChild:(SPDisplayObject *)child;
	[Export ("containsChild:")]
	bool ContainsChild (SPDisplayObject  child);

	//- (SPDisplayObject *)childAtIndex:(int)index;
	[Export ("childAtIndex:")]
	SPDisplayObject  ChildAtIndex (int index);

	//- (SPDisplayObject *)childByName:(NSString *)name;
	[Export ("childByName:")]
	SPDisplayObject  ChildByName (string name);

	//- (int)childIndex:(SPDisplayObject *)child;
	[Export ("childIndex:")]
	int ChildIndex (SPDisplayObject  child);

	//- (void)removeChild:(SPDisplayObject *)child;
	[Export ("removeChild:")]
	void RemoveChild (SPDisplayObject  child);

	//- (void)removeChildAtIndex:(int)index;
	[Export ("removeChildAtIndex:")]
	void RemoveChildAtIndex (int index);

	//- (void)removeAllChildren;
	[Export ("removeAllChildren")]
	void RemoveAllChildren ();

	//- (void)swapChild:(SPDisplayObject*)child1 withChild:(SPDisplayObject*)child2;
	[Export ("swapChild:withChild:")]
	void SwapChild (SPDisplayObject child1, SPDisplayObject child2);

	//- (void)swapChildAtIndex:(int)index1 withChildAtIndex:(int)index2;
	[Export ("swapChildAtIndex:withChildAtIndex:")]
	void SwapChildAtIndex (int index1, int index2);

	//@property (nonatomic, readonly) int numChildren;
	[Export ("numChildren")]//, ArgumentSemantic.ReadOnly)]
	int NumChildren { get;  }

}

[BaseType (typeof (SPEvent))]
interface SPEnterFrameEvent {
	//- (id)initWithType:(NSString*)type bubbles:(BOOL)bubbles passedTime:(double)seconds;
	[Export ("initWithType:bubbles:passedTime:")]
	IntPtr Constructor (string type, bool bubbles, double seconds);

	//- (id)initWithType:(NSString*)type passedTime:(double)seconds;
	[Export ("initWithType:passedTime:")]
	IntPtr Constructor (string type, double seconds);

	[Static]
	//+ (SPEnterFrameEvent*)eventWithType:(NSString*)type passedTime:(double)seconds;
	[Export ("eventWithType:passedTime:")]
	SPEnterFrameEvent EventWithType (string type, double seconds);

	//@property (nonatomic, readonly) double passedTime;
	[Export ("passedTime")]//, ArgumentSemantic.ReadOnly)]
	double PassedTime { get;  }

}

[BaseType (typeof (NSObject))]
interface SPEvent {
	//- (id)initWithType:(NSString*)type bubbles:(BOOL)bubbles;
	[Export ("initWithType:bubbles:")]
	IntPtr Constructor (string type, bool bubbles);

	//- (id)initWithType:(NSString*)type;
	[Export ("initWithType:")]
	IntPtr Constructor (string type);

	[Static]
	//+ (SPEvent*)eventWithType:(NSString*)type bubbles:(BOOL)bubbles;
	[Export ("eventWithType:bubbles:")]
	SPEvent EventWithType (string type, bool bubbles);

	[Static]
	//+ (SPEvent*)eventWithType:(NSString*)type;
	[Export ("eventWithType:")]
	SPEvent EventWithType (string type);

	//- (void)stopImmediatePropagation;
	[Export ("stopImmediatePropagation")]
	void StopImmediatePropagation ();

	//- (void)stopPropagation;
	[Export ("stopPropagation")]
	void StopPropagation ();

	//@property (nonatomic, readonly) NSString *type; 
	[Export ("type")]//, ArgumentSemantic.ReadOnly)]
	string Type { get;  }

	//@property (nonatomic, readonly) BOOL bubbles; 
	[Export ("bubbles")]//, ArgumentSemantic.ReadOnly)]
	bool Bubbles { get;  }

	//@property (nonatomic, readonly) SPEventDispatcher *target; 
	[Export ("target")]//, ArgumentSemantic.ReadOnly)]
	SPEventDispatcher Target { get;  }

	//@property (nonatomic, readonly) SPEventDispatcher *currentTarget; 
	[Export ("currentTarget")]//, ArgumentSemantic.ReadOnly)]
	SPEventDispatcher CurrentTarget { get;  }

}

[BaseType (typeof (NSObject))]
interface SPEventDispatcher {
	//- (void)addEventListener:(SEL)listener atObject:(id)object forType:(NSString*)eventType retainObject:(BOOL)retain;
	[Internal, Export ("addEventListener:atObject:forType:")]
	void _AddEventListener (Selector listener, NSObject object1, string eventType, bool retain);

	//- (void)addEventListener:(SEL)listener atObject:(id)object forType:(NSString*)eventType;
	[Internal, Export ("addEventListener:atObject:forType:")]
	void _AddEventListener (Selector listener, NSObject object1, string eventType);

	//- (void)removeEventListener:(SEL)listener atObject:(id)object forType:(NSString*)eventType;
	[Internal, Export ("removeEventListener:atObject:forType:")]
	void _RemoveEventListener (Selector listener, NSObject object1, string eventType);

	//- (void)removeEventListenersAtObject:(id)object forType:(NSString*)eventType;
	[Internal, Export ("removeEventListenersAtObject:forType:")]
	void _RemoveEventListenersAtObject (NSObject object1, string eventType);

	//- (void)dispatchEvent:(SPEvent*)event;
	[Export ("dispatchEvent:")]
	void DispatchEvent (SPEvent event1);

	//- (BOOL)hasEventListenerForType:(NSString*)eventType;
	[Export ("hasEventListenerForType:")]
	bool HasEventListenerForType (string eventType);

}

[BaseType (typeof (SPTexture))]
interface SPGLTexture {
	//- (id)initWithData:(const void *)imgData properties:(SPTextureProperties)properties;
	[Export ("initWithData:properties:")]
	IntPtr Constructor (IntPtr  imgData, SPTextureProperties properties);

	[Static]
	//+ (SPGLTexture*)textureWithData:(const void *)imgData properties:(SPTextureProperties)properties;
	[Export ("textureWithData:properties:")]
	SPGLTexture TextureWithData (IntPtr  imgData, SPTextureProperties properties);

	//@property (nonatomic, assign) BOOL repeat;
	[Export ("repeat", ArgumentSemantic.Assign)]
	bool Repeat { get; set;  }

	//@property (nonatomic, assign) float scale;
	[Export ("scale", ArgumentSemantic.Assign)]
	float Scale { get; set;  }

}

[BaseType (typeof (SPQuad))]
interface SPImage {
	//- (id)initWithTexture:(SPTexture*)texture;
	[Export ("initWithTexture:")]
	IntPtr Constructor (SPTexture texture);

	//- (id)initWithContentsOfFile:(NSString*)path;
	[Export ("initWithContentsOfFile:")]
	IntPtr Constructor (string path);

	[Static]
	//+ (SPImage*)imageWithTexture:(SPTexture*)texture;
	[Export ("imageWithTexture:")]
	SPImage ImageWithTexture (SPTexture texture);

	[Static]
	//+ (SPImage*)imageWithContentsOfFile:(NSString*)path;
	[Export ("imageWithContentsOfFile:")]
	SPImage ImageWithContentsOfFile (string path);

	//- (void)setTexCoords:(SPPoint*)coords ofVertex:(int)vertexID;
	[Export ("setTexCoords:ofVertex:")]
	void SetTexCoords (SPPoint coords, int vertexID);

	//- (SPPoint*)texCoordsOfVertex:(int)vertexID;
	[Export ("texCoordsOfVertex:")]
	SPPoint TexCoordsOfVertex (int vertexID);

	//@property (nonatomic, retain) SPTexture *texture;
	[Export ("texture", ArgumentSemantic.Retain)]
	SPTexture Texture { get; set;  }

}

[BaseType (typeof (NSObject))]
interface SPJuggler {
	[Static]
	//+ (SPJuggler *)juggler;
	[Export ("juggler")]
	SPJuggler  Juggler ();

	//- (void)addObject:(id<SPAnimatable>)object;
	[Export ("addObject:")]
	void AddObject (NSObject object1);

	//- (void)removeObject:(id<SPAnimatable>)object;
	[Export ("removeObject:")]
	void RemoveObject (NSObject object1);

	//- (void)removeAllObjects;
	[Export ("removeAllObjects")]
	void RemoveAllObjects ();

	//- (void)removeTweensWithTarget:(id)object;
	[Export ("removeTweensWithTarget:")]
	void RemoveTweensWithTarget (NSObject object1);

	//- (id)delayInvocationAtTarget:(id)target byTime:(double)time;
	[Export ("delayInvocationAtTarget:byTime:")]
	SPDelayedInvocation DelayInvocationAtTarget (NSObject target, double time);

	//@property (nonatomic, readonly) double elapsedTime;
	[Export ("elapsedTime")]//, ArgumentSemantic.ReadOnly)]
	double ElapsedTime { get;  }

}

[BaseType (typeof (SPPoolObject))]
interface SPMatrix {
	//- (id)initWithA:(float)a b:(float)b c:(float)c d:(float)d tx:(float)tx ty:(float)ty;
	[Export ("initWithA:b:c:d:tx:ty:")]
	IntPtr Constructor (float a, float b, float c, float d, float tx, float ty);

	//- (id)init;
	//[Export ("init")]
	///IntPtr Constructor ();

	[Static]
	//+ (SPMatrix*)matrixWithA:(float)a b:(float)b c:(float)c d:(float)d tx:(float)tx ty:(float)ty;
	[Export ("matrixWithA:b:c:d:tx:ty:")]
	SPMatrix MatrixWithA (float a, float b, float c, float d, float tx, float ty);

	[Static]
	//+ (SPMatrix*)matrixWithIdentity;
	[Export ("matrixWithIdentity")]
	SPMatrix MatrixWithIdentity ();

	//- (BOOL)isEqual:(id)other;
	[Export ("isEqual:")]
	bool IsEqual (NSObject other);

	//- (void)concatMatrix:(SPMatrix*)matrix;
	[Export ("concatMatrix:")]
	void ConcatMatrix (SPMatrix matrix);

	//- (void)translateXBy:(float)dx yBy:(float)dy;
	[Export ("translateXBy:yBy:")]
	void TranslateXBy (float dx, float dy);

	//- (void)scaleXBy:(float)sx yBy:(float)sy;
	[Export ("scaleXBy:yBy:")]
	void ScaleXBy (float sx, float sy);

	//- (void)scaleBy:(float)scale;
	[Export ("scaleBy:")]
	void ScaleBy (float scale);

	//- (void)rotateBy:(float)angle;
	[Export ("rotateBy:")]
	void RotateBy (float angle);

	//- (void)identity;
	[Export ("identity")]
	void Identity ();

	//- (void)invert;
	[Export ("invert")]
	void Invert ();

	//- (SPPoint*)transformPoint:(SPPoint*)point;
	[Export ("transformPoint:")]
	SPPoint TransformPoint (SPPoint point);

	//@property (nonatomic, assign) float a;
	[Export ("a", ArgumentSemantic.Assign)]
	float A { get; set;  }

	//@property (nonatomic, assign) float b;
	[Export ("b", ArgumentSemantic.Assign)]
	float B { get; set;  }

	//@property (nonatomic, assign) float c;
	[Export ("c", ArgumentSemantic.Assign)]
	float C { get; set;  }

	//@property (nonatomic, assign) float d;
	[Export ("d", ArgumentSemantic.Assign)]
	float D { get; set;  }

	//@property (nonatomic, assign) float tx;
	[Export ("tx", ArgumentSemantic.Assign)]
	float Tx { get; set;  }

	//@property (nonatomic, assign) float ty;
	[Export ("ty", ArgumentSemantic.Assign)]
	float Ty { get; set;  }

	//@property (nonatomic, readonly) float determinant;
	[Export ("determinant")]//, ArgumentSemantic.ReadOnly)]
	float Determinant { get;  }

}

[BaseType (typeof (SPImage))]
interface SPMovieClip {
	//- (id)initWithFrame:(SPTexture *)texture fps:(float)fps; 
	[Export ("initWithFrame:fps:")]
	IntPtr Constructor (SPTexture  texture, float fps);

	//- (id)initWithFrames:(NSArray *)textures fps:(float)fps;
	[Export ("initWithFrames:fps:")]
	IntPtr Constructor (SPTexture[] textures, float fps);

	[Static]
	//+ (SPMovieClip *)movieWithFrame:(SPTexture *)texture fps:(float)fps;
	[Export ("movieWithFrame:fps:")]
	SPMovieClip  MovieWithFrame (SPTexture  texture, float fps);

	[Static]
	//+ (SPMovieClip *)movieWithFrames:(NSArray *)textures fps:(float)fps;
	[Export ("movieWithFrames:fps:")]
	SPMovieClip  MovieWithFrames (SPTexture[] textures, float fps);

	//- (int)addFrame:(SPTexture *)texture;
	[Export ("addFrame:")]
	int AddFrame (SPTexture  texture);

	//- (int)addFrame:(SPTexture *)texture withDuration:(double)duration;
	[Export ("addFrame:withDuration:")]
	int AddFrame (SPTexture  texture, double duration);

	//- (void)insertFrame:(SPTexture *)texture atIndex:(int)frameID;
	[Export ("insertFrame:atIndex:")]
	void InsertFrame (SPTexture  texture, int frameID);

	//- (void)removeFrameAtIndex:(int)frameID;
	[Export ("removeFrameAtIndex:")]
	void RemoveFrameAtIndex (int frameID);

	//- (void)setFrame:(SPTexture *)texture atIndex:(int)frameID;
	[Export ("setFrame:atIndex:")]
	void SetFrame (SPTexture  texture, int frameID);

	//- (void)setSound:(SPSoundChannel *)sound atIndex:(int)frameID;
	[Export ("setSound:atIndex:")]
	void SetSound (SPSoundChannel  sound, int frameID);

	//- (void)setDuration:(double)duration atIndex:(int)frameID;
	[Export ("setDuration:atIndex:")]
	void SetDuration (double duration, int frameID);

	//- (SPTexture *)frameAtIndex:(int)frameID;
	[Export ("frameAtIndex:")]
	SPTexture  FrameAtIndex (int frameID);

	//- (SPSoundChannel *)soundAtIndex:(int)frameID;
	[Export ("soundAtIndex:")]
	SPSoundChannel  SoundAtIndex (int frameID);

	//- (double)durationAtIndex:(int)frameID;
	[Export ("durationAtIndex:")]
	double DurationAtIndex (int frameID);

	//- (void)play;
	[Export ("play")]
	void Play ();

	//- (void)pause;
	[Export ("pause")]
	void Pause ();

	//@property (nonatomic, readonly) int numFrames;
	[Export ("numFrames")]//, ArgumentSemantic.ReadOnly)]
	int NumFrames { get;  }

	//@property (nonatomic, readonly) double duration;
	[Export ("duration")]//, ArgumentSemantic.ReadOnly)]
	double Duration { get;  }

	//@property (nonatomic, readonly) BOOL isPlaying;
	[Export ("isPlaying")]//, ArgumentSemantic.ReadOnly)]
	bool IsPlaying { get;  }

	//@property (nonatomic, assign)   BOOL loop;
	[Export ("loop", ArgumentSemantic.Assign)]
	bool Loop { get; set;  }

	//@property (nonatomic, assign)   int currentFrame;
	[Export ("currentFrame", ArgumentSemantic.Assign)]
	int CurrentFrame { get; set;  }

	//@property (nonatomic, assign)   float fps;
	[Export ("fps", ArgumentSemantic.Assign)]
	float Fps { get; set;  }

}
#if false
interface NSInvocation (SPNSExtensions) {
	[Static]
	//+ (NSInvocation *)invocationWithTarget:(id)target selector:(SEL)selector;
	[Export ("invocationWithTarget:selector:")]
	NSInvocation  InvocationWithTarget (NSObject target, Selector selector);

}
interface NSString (SPNSExtensions) {
	//- (NSString *)stringByAppendingSuffixToFilename:(NSString *)suffix;
	[Export ("stringByAppendingSuffixToFilename:")]
	string StringByAppendingSuffixToFilename (string suffix);

}
interface NSBundle (SPNSExtensions) {
	//- (NSString *)pathForResource:(NSString *)name withScaleFactor:(float)factor;
	[Export ("pathForResource:withScaleFactor:")]
	string PathForResource (string name, float factor);

}
#endif

[BaseType (typeof (SPPoolObject))]
interface SPPoint {
	//- (id)initWithX:(float)x y:(float)y;
	[Export ("initWithX:y:")]
	IntPtr Constructor (float x, float y);

	//- (id)initWithPolarLength:(float)length angle:(float)angle;
	//[Export ("initWithPolarLength:angle:")]
	////IntPtr Constructor (float length, float angle);

	[Static]
	//+ (SPPoint *)pointWithPolarLength:(float)length angle:(float)angle;
	[Export ("pointWithPolarLength:angle:")]
	SPPoint  PointWithPolarLength (float length, float angle);

	[Static]
	//+ (SPPoint *)pointWithX:(float)x y:(float)y;
	[Export ("pointWithX:y:")]
	SPPoint  PointWithX (float x, float y);

	[Static]
	//+ (SPPoint *)point;
	[Export ("point")]
	SPPoint  Point ();

	//- (SPPoint *)addPoint:(SPPoint *)point;
	[Export ("addPoint:")]
	SPPoint  AddPoint (SPPoint  point);

	//- (SPPoint *)subtractPoint:(SPPoint *)point;
	[Export ("subtractPoint:")]
	SPPoint  SubtractPoint (SPPoint  point);

	//- (SPPoint *)scaleBy:(float)scalar;
	[Export ("scaleBy:")]
	SPPoint  ScaleBy (float scalar);

	//- (SPPoint *)normalize;
	[Export ("normalize")]
	SPPoint  Normalize ();

	//- (BOOL)isEqual:(id)other;
	[Export ("isEqual:")]
	bool IsEqual (NSObject other);

	[Static]
	//+ (float)distanceFromPoint:(SPPoint *)p1 toPoint:(SPPoint *)p2;
	[Export ("distanceFromPoint:toPoint:")]
	float DistanceFromPoint (SPPoint  p1, SPPoint  p2);

	[Static]
	//+ (SPPoint *)interpolateFromPoint:(SPPoint *)p1 toPoint:(SPPoint *)p2 ratio:(float)ratio;
	[Export ("interpolateFromPoint:toPoint:ratio:")]
	SPPoint  InterpolateFromPoint (SPPoint  p1, SPPoint  p2, float ratio);

	//@property (nonatomic, assign) float x;
	[Export ("x", ArgumentSemantic.Assign)]
	float X { get; set;  }

	//@property (nonatomic, assign) float y;
	[Export ("y", ArgumentSemantic.Assign)]
	float Y { get; set;  }

	//@property (readonly) float length;
	[Export ("length")]//, ArgumentSemantic.ReadOnly)]
	float Length { get;  }

	//@property (readonly) float angle;
	[Export ("angle")]//, ArgumentSemantic.ReadOnly)]
	float Angle { get;  }

}

[BaseType (typeof (NSObject))]
interface SPPoolObject {
	//[Static]
	//+ (SPPoolInfo *)poolInfo;
	//[Export ("poolInfo")]
	///SPPoolInfo  PoolInfo ();

	[Static]
	//+ (int)purgePool;
	[Export ("purgePool")]
	int PurgePool ();

}
#if false
interface NSObject (SPPoolObjectExtensions) {
	[Static]
	//+ (SPPoolInfo *)poolInfo;
	[Export ("poolInfo")]
	SPPoolInfo  PoolInfo ();

	[Static]
	//+ (int)purgePool;
	[Export ("purgePool")]
	int PurgePool ();

}
#endif
[BaseType (typeof (SPDisplayObject))]
interface SPQuad {
	//- (id)initWithWidth:(float)width height:(float)height color:(uint)color; 
	[Export ("initWithWidth:height:color:")]
	IntPtr Constructor (float width, float height, uint color);

	//- (id)initWithWidth:(float)width height:(float)height; 
	[Export ("initWithWidth:height:")]
	IntPtr Constructor (float width, float height);

	//- (void)setColor:(uint)color ofVertex:(int)vertexID;
	[Export ("setColor:ofVertex:")]
	void SetColor (uint color, int vertexID);

	//- (uint)colorOfVertex:(int)vertexID;
	[Export ("colorOfVertex:")]
	uint ColorOfVertex (int vertexID);

	[Static]
	//+ (SPQuad*)quadWithWidth:(float)width height:(float)height;
	[Export ("quadWithWidth:height:")]
	SPQuad QuadWithWidth (float width, float height);

	[Static]
	//+ (SPQuad*)quadWithWidth:(float)width height:(float)height color:(uint)color;
	[Export ("quadWithWidth:height:color:")]
	SPQuad QuadWithWidth (float width, float height, uint color);

	//@property (nonatomic, assign) uint color;
	[Export ("color", ArgumentSemantic.Assign)]
	uint Color { get; set;  }

}

[BaseType (typeof (SPPoolObject))]
interface SPRectangle {
	//- (id)initWithX:(float)x y:(float)y width:(float)width height:(float)height;
	[Export ("initWithX:y:width:height:")]
	IntPtr Constructor (float x, float y, float width, float height);

	[Static]
	//+ (SPRectangle*)rectangleWithX:(float)x y:(float)y width:(float)width height:(float)height;
	[Export ("rectangleWithX:y:width:height:")]
	SPRectangle RectangleWithX (float x, float y, float width, float height);

	//- (BOOL)containsX:(float)x y:(float)y;
	[Export ("containsX:y:")]
	bool ContainsX (float x, float y);

	//- (BOOL)containsPoint:(SPPoint*)point;
	[Export ("containsPoint:")]
	bool ContainsPoint (SPPoint point);

	//- (BOOL)containsRectangle:(SPRectangle*)rectangle;
	[Export ("containsRectangle:")]
	bool ContainsRectangle (SPRectangle rectangle);

	//- (BOOL)intersectsRectangle:(SPRectangle*)rectangle;
	[Export ("intersectsRectangle:")]
	bool IntersectsRectangle (SPRectangle rectangle);

	//- (SPRectangle*)intersectionWithRectangle:(SPRectangle*)rectangle;
	[Export ("intersectionWithRectangle:")]
	SPRectangle IntersectionWithRectangle (SPRectangle rectangle);

	//- (SPRectangle*)uniteWithRectangle:(SPRectangle*)rectangle; 
	[Export ("uniteWithRectangle:")]
	SPRectangle UniteWithRectangle (SPRectangle rectangle);

	//- (void)setEmpty;
	[Export ("setEmpty")]
	void SetEmpty ();

	//@property (nonatomic, assign) float x;
	[Export ("x", ArgumentSemantic.Assign)]
	float X { get; set;  }

	//@property (nonatomic, assign) float y;
	[Export ("y", ArgumentSemantic.Assign)]
	float Y { get; set;  }

	//@property (nonatomic, assign) float width;
	[Export ("width", ArgumentSemantic.Assign)]
	float Width { get; set;  }

	//@property (nonatomic, assign) float height;
	[Export ("height", ArgumentSemantic.Assign)]
	float Height { get; set;  }

	//@property (nonatomic, readonly) BOOL isEmpty;
	[Export ("isEmpty")]//, ArgumentSemantic.ReadOnly)]
	bool IsEmpty { get;  }

}

[BaseType (typeof (NSObject))]
interface SPRenderSupport {
	//- (void)bindTexture:(SPTexture *)texture;
	[Export ("bindTexture:")]
	void BindTexture (SPTexture  texture);

	//- (uint)convertColor:(uint)color alpha:(float)alpha;
	[Export ("convertColor:alpha:")]
	uint ConvertColor (uint color, float alpha);

	[Static]
	//+ (uint)convertColor:(uint)color alpha:(float)alpha premultiplyAlpha:(BOOL)pma;
	[Export ("convertColor:alpha:premultiplyAlpha:")]
	uint ConvertColor (uint color, float alpha, bool pma);

	[Static]
	//+ (void)clearWithColor:(uint)color alpha:(float)alpha;
	[Export ("clearWithColor:alpha:")]
	void ClearWithColor (uint color, float alpha);

	[Static]
	//+ (void)transformMatrixForObject:(SPDisplayObject *)object;
	[Export ("transformMatrixForObject:")]
	void TransformMatrixForObject (SPDisplayObject  object1);

	[Static]
	//+ (void)setupOrthographicRenderingWithLeft:(float)left right:(float)right                                     bottom:(float)bottom top:(float)top;
	[Export ("setupOrthographicRenderingWithLeft:right:bottomtop:")]
	void SetupOrthographicRenderingWithLeft (float left, float right, float bottom, float top);

	[Static]
	//+ (uint)checkForOpenGLError;
	[Export ("checkForOpenGLError")]
	uint CheckForOpenGLError ();

	//@property (nonatomic, readonly) BOOL usingPremultipliedAlpha;
	[Export ("usingPremultipliedAlpha")]//, ArgumentSemantic.ReadOnly)]
	bool UsingPremultipliedAlpha { get;  }

}
	
[BaseType (typeof (SPTexture))]
interface SPRenderTexture {
	//- (id)initWithWidth:(float)width height:(float)height;
	[Export ("initWithWidth:height:")]
	IntPtr Constructor (float width, float height);

	//- (id)initWithWidth:(float)width height:(float)height fillColor:(uint)argb;
	[Export ("initWithWidth:height:fillColor:")]
	IntPtr Constructor (float width, float height, uint argb);

	//- (id)initWithWidth:(float)width height:(float)height fillColor:(uint)argb scale:(float)scale;
	[Export ("initWithWidth:height:fillColor:scale:")]
	IntPtr Constructor (float width, float height, uint argb, float scale);

	[Static]
	//+ (SPRenderTexture *)textureWithWidth:(float)width height:(float)height;
	[Export ("textureWithWidth:height:")]
	SPRenderTexture  TextureWithWidth (float width, float height);

	[Static]
	//+ (SPRenderTexture *)textureWithWidth:(float)width height:(float)height fillColor:(uint)argb;
	[Export ("textureWithWidth:height:fillColor:")]
	SPRenderTexture  TextureWithWidth (float width, float height, uint argb);

	//- (void)drawObject:(SPDisplayObject *)object;
	[Export ("drawObject:")]
	void DrawObject (SPDisplayObject  object1);

	//- (void)bundleDrawCalls:(SPDrawingBlock)block;
	//[Export ("bundleDrawCalls:")]
	//void BundleDrawCalls (SPDrawingBlock block);

	//- (void)clearWithColor:(uint)color alpha:(float)alpha;
	[Export ("clearWithColor:alpha:")]
	void ClearWithColor (uint color, float alpha);

}

[BaseType (typeof (NSObject))]
interface SPSound {
	//- (id)initWithContentsOfFile:(NSString *)path;
	[Export ("initWithContentsOfFile:")]
	IntPtr Constructor (string path);

	[Static]
	//+ (SPSound *)soundWithContentsOfFile:(NSString *)path;
	[Export ("soundWithContentsOfFile:")]
	SPSound  SoundWithContentsOfFile (string path);

	//- (void)play;
	[Export ("play")]
	void Play ();

	//- (SPSoundChannel *)createChannel;
	[Export ("createChannel")]
	SPSoundChannel  CreateChannel ();

	//@property (nonatomic, readonly) double duration;
	[Export ("duration")]//, ArgumentSemantic.ReadOnly)]
	double Duration { get;  }

}

[BaseType (typeof (SPEventDispatcher))]
interface SPSoundChannel {
	//- (void)play;
	[Export ("play")]
	void Play ();

	//- (void)stop;
	[Export ("stop")]
	void Stop ();

	//- (void)pause;
	[Export ("pause")]
	void Pause ();

	//@property (nonatomic, readonly) BOOL isPlaying;
	[Export ("isPlaying")]//, ArgumentSemantic.ReadOnly)]
	bool IsPlaying { get;  }

	//@property (nonatomic, readonly) BOOL isPaused;
	[Export ("isPaused")]//, ArgumentSemantic.ReadOnly)]
	bool IsPaused { get;  }

	//@property (nonatomic, readonly) BOOL isStopped;
	[Export ("isStopped")]//, ArgumentSemantic.ReadOnly)]
	bool IsStopped { get;  }

	//@property (nonatomic, readonly) double duration;
	[Export ("duration")]//, ArgumentSemantic.ReadOnly)]
	double Duration { get;  }

	//@property (nonatomic, assign) float volume;
	[Export ("volume", ArgumentSemantic.Assign)]
	float Volume { get; set;  }

	//@property (nonatomic, assign) BOOL loop;
	[Export ("loop", ArgumentSemantic.Assign)]
	bool Loop { get; set;  }

}

[BaseType (typeof (SPDisplayObjectContainer))]
interface SPSprite {
	[Static]
	//+ (SPSprite*)sprite;
	[Export ("sprite")]
	SPSprite Sprite ();

}

[BaseType (typeof (SPDisplayObjectContainer))]
interface SPStage {
	//- (id)initWithWidth:(float)width height:(float)height;
	[Export ("initWithWidth:height:")]
	IntPtr Constructor (float width, float height);

	//- (void)advanceTime:(double)seconds;
	[Export ("advanceTime:")]
	void AdvanceTime (double seconds);

	//- (void)processTouches:(NSSet*)touches;
	[Export ("processTouches:")]
	void ProcessTouches (NSSet touches);

	//@property (nonatomic, assign)   float frameRate;
	[Export ("frameRate", ArgumentSemantic.Assign)]
	float FrameRate { get; set;  }

	//@property (nonatomic, readonly) SPJuggler *juggler;
	[Export ("juggler")]//, ArgumentSemantic.ReadOnly)]
	SPJuggler Juggler { get;  }

	//@property (nonatomic, readonly) id nativeView;
	[Export ("nativeView")]//, ArgumentSemantic.ReadOnly)]
	SPStage NativeView { get;  }
		
	/// Enables support for high resolutions (aka retina displays).
	//+ (void)setSupportHighResolutions:(BOOL)value;
	
	/// Determines if high resolution support is activated.
	//+ (BOOL)supportHighResolutions;
	[Static][Export ("supportHighResolutions")]
	bool SupportHighResolutions { get; set; }
	
	/// Sets the content scale factor, which determines the relationship between points and pixels.
	//+ (void)setContentScaleFactor:(float)value;
	
	/// The current content scale factor.
	//+ (float)contentScaleFactor;
	[Static][Export ("contentScaleFactor")]
	float ContentScaleFactor { get; set; }
			
}

[BaseType (typeof (SPTexture))]
interface SPSubTexture {
	//- (id)initWithRegion:(SPRectangle*)region ofTexture:(SPTexture*)texture;
	[Export ("initWithRegion:ofTexture:")]
	IntPtr Constructor (SPRectangle region, SPTexture texture);

	[Static]
	//+ (SPSubTexture*)textureWithRegion:(SPRectangle*)region ofTexture:(SPTexture*)texture;
	[Export ("textureWithRegion:ofTexture:")]
	SPSubTexture TextureWithRegion (SPRectangle region, SPTexture texture);

	//@property (nonatomic, readonly) SPTexture *baseTexture;
	[Export ("baseTexture")]//, ArgumentSemantic.ReadOnly)]
	SPTexture BaseTexture { get;  }

	//@property (nonatomic, copy) SPRectangle *clipping;
	[Export ("clipping", ArgumentSemantic.Copy)]
	SPRectangle Clipping { get; set;  }

}

[BaseType (typeof (SPDisplayObjectContainer))]
interface SPTextField {
	//- (id)initWithWidth:(float)width height:(float)height text:(NSString*)text fontName:(NSString*)name           fontSize:(float)size color:(uint)color;
	[Export ("initWithWidth:height:text:fontName:sizecolor:")]
	IntPtr Constructor (float width, float height, string text, string name, float size, uint color);

	//- (id)initWithWidth:(float)width height:(float)height text:(NSString*)text;
	[Export ("initWithWidth:height:text:")]
	IntPtr Constructor (float width, float height, string text);

	//- (id)initWithText:(NSString *)text;
	[Export ("initWithText:")]
	IntPtr Constructor (string text);

	[Static]
	//+ (SPTextField *)textFieldWithWidth:(float)width height:(float)height text:(NSString*)text                           fontName:(NSString*)name fontSize:(float)size color:(uint)color;
	[Export ("textFieldWithWidth:height:text:namefontSize:color:")]
	SPTextField  TextFieldWithWidth (float width, float height, string text, string name, float size, uint color);

	[Static]
	//+ (SPTextField *)textFieldWithWidth:(float)width height:(float)height text:(NSString*)text;
	[Export ("textFieldWithWidth:height:text:")]
	SPTextField  TextFieldWithWidth (float width, float height, string text);

	[Static]
	//+ (SPTextField *)textFieldWithText:(NSString *)text;
	[Export ("textFieldWithText:")]
	SPTextField  TextFieldWithText (string text);

	[Static]
	//+ (NSString *)registerBitmapFontFromFile:(NSString*)path texture:(SPTexture *)texture;
	[Export ("registerBitmapFontFromFile:texture:")]
	string RegisterBitmapFontFromFile (string path, SPTexture  texture);

	[Static]
	//+ (NSString *)registerBitmapFontFromFile:(NSString*)path;
	[Export ("registerBitmapFontFromFile:")]
	string RegisterBitmapFontFromFile (string path);

	[Static]
	//+ (void)unregisterBitmapFont:(NSString *)name;
	[Export ("unregisterBitmapFont:")]
	void UnregisterBitmapFont (string name);

	//@property (nonatomic, copy) NSString *text;
	[Export ("text", ArgumentSemantic.Copy)]
	string Text { get; set;  }

	//@property (nonatomic, copy) NSString *fontName;
	[Export ("fontName", ArgumentSemantic.Copy)]
	string FontName { get; set;  }

	//@property (nonatomic, assign) float fontSize;
	[Export ("fontSize", ArgumentSemantic.Assign)]
	float FontSize { get; set;  }

	//@property (nonatomic, assign) SPHAlign hAlign;
	[Export ("hAlign", ArgumentSemantic.Assign)]
	SPHAlign HAlign { get; set;  }

	//@property (nonatomic, assign) SPVAlign vAlign;
	[Export ("vAlign", ArgumentSemantic.Assign)]
	SPVAlign VAlign { get; set;  }

	//@property (nonatomic, assign) BOOL border;
	[Export ("border", ArgumentSemantic.Assign)]
	bool Border { get; set;  }

	//@property (nonatomic, assign) uint color;
	[Export ("color", ArgumentSemantic.Assign)]
	uint Color { get; set;  }

	//@property (nonatomic, readonly) SPRectangle *textBounds;
	[Export ("textBounds")]//, ArgumentSemantic.ReadOnly)]
	SPRectangle TextBounds { get;  }

}

[BaseType (typeof (NSObject))]
interface SPTexture {
	//- (id)initWithWidth:(float)width height:(float)height draw:(SPTextureDrawingBlock)drawingBlock;
	//[Export ("initWithWidth:height:draw:")]
	//IntPtr Constructor (float width, float height, SPTextureDrawingBlock drawingBlock);

	//- (id)initWithWidth:(float)width height:(float)height scale:(float)scale          colorSpace:(SPColorSpace)colorSpace draw:(SPTextureDrawingBlock)drawingBlock;
	//[Export ("initWithWidth:height:scale:colorSpacedraw:")]
	//IntPtr Constructor (float width, float height, float scale, SPColorSpace colorSpace, SPTextureDrawingBlock drawingBlock);

	//- (id)initWithContentsOfFile:(NSString *)path;
	[Export ("initWithContentsOfFile:")]
	IntPtr Constructor (string path);

	//- (id)initWithContentsOfImage:(UIImage *)image;
	[Export ("initWithContentsOfImage:")]
	IntPtr Constructor (UIImage  image);

	//- (id)initWithRegion:(SPRectangle*)region ofTexture:(SPTexture*)texture;
	[Export ("initWithRegion:ofTexture:")]
	IntPtr Constructor (SPRectangle region, SPTexture texture);

	[Static]
	//+ (SPTexture *)textureWithContentsOfFile:(NSString*)path;
	[Export ("textureWithContentsOfFile:")]
	SPTexture  TextureWithContentsOfFile (string path);

	[Static]
	//+ (SPTexture *)textureWithRegion:(SPRectangle *)region ofTexture:(SPTexture *)texture;
	[Export ("textureWithRegion:ofTexture:")]
	SPTexture  TextureWithRegion (SPRectangle  region, SPTexture  texture);

	//[Static]
	//+ (SPTexture *)textureWithWidth:(float)width height:(float)height draw:(SPTextureDrawingBlock)drawingBlock;
	//[Export ("textureWithWidth:height:draw:")]
	//SPTexture  TextureWithWidth (float width, float height, SPTextureDrawingBlock drawingBlock);

	[Static]
	//+ (SPTexture *)emptyTexture;
	[Export ("emptyTexture")]
	SPTexture  EmptyTexture ();

	//- (void)adjustTextureCoordinates:(const float *)texCoords saveAtTarget:(float *)targetTexCoords                      numVertices:(int)numVertices;
	[Export ("adjustTextureCoordinates:saveAtTarget:")]
	void AdjustTextureCoordinates (float  texCoords, float  targetTexCoords, int numVertices);

	//@property (nonatomic, readonly) float width;
	[Export ("width")]//, ArgumentSemantic.ReadOnly)]
	float Width { get;  }

	//@property (nonatomic, readonly) float height;
	[Export ("height")]//, ArgumentSemantic.ReadOnly)]
	float Height { get;  }

	//@property (nonatomic, readonly) uint textureID;
	[Export ("textureID")]//, ArgumentSemantic.ReadOnly)]
	uint TextureID { get;  }

	//@property (nonatomic, readonly) BOOL hasPremultipliedAlpha;
	[Export ("hasPremultipliedAlpha")]//, ArgumentSemantic.ReadOnly)]
	bool HasPremultipliedAlpha { get;  }

	//@property (nonatomic, readonly) float scale;
	[Export ("scale")]//, ArgumentSemantic.ReadOnly)]
	float Scale { get;  }

}

[BaseType (typeof (NSObject))]
interface SPTextureAtlas {
	//- (id)initWithContentsOfFile:(NSString *)path texture:(SPTexture *)texture;
	[Export ("initWithContentsOfFile:texture:")]
	IntPtr Constructor (string path, SPTexture  texture);

	//- (id)initWithContentsOfFile:(NSString *)path;
	[Export ("initWithContentsOfFile:")]
	IntPtr Constructor (string path);

	//- (id)initWithTexture:(SPTexture *)texture;
	[Export ("initWithTexture:")]
	IntPtr Constructor (SPTexture  texture);

	[Static]
	//+ (SPTextureAtlas *)atlasWithContentsOfFile:(NSString *)path;
	[Export ("atlasWithContentsOfFile:")]
	SPTextureAtlas  AtlasWithContentsOfFile (string path);

	//- (SPTexture *)textureByName:(NSString *)name;
	[Export ("textureByName:")]
	SPTexture  TextureByName (string name);

	//- (NSArray *)texturesStartingWith:(NSString *)name;
	[Export ("texturesStartingWith:")]
	SPTexture[] TexturesStartingWith (string name);

	//- (void)addRegion:(SPRectangle *)region withName:(NSString *)name;
	[Export ("addRegion:withName:")]
	void AddRegion (SPRectangle  region, string name);

	//- (void)removeRegion:(NSString *)name;
	[Export ("removeRegion:")]
	void RemoveRegion (string name);

	//@property (nonatomic, readonly) int count;
	[Export ("count")]//, ArgumentSemantic.ReadOnly)]
	int Count { get;  }

}

[BaseType (typeof (NSObject))]
interface SPTouch {
	//- (SPPoint*)locationInSpace:(SPDisplayObject*)space;
	[Export ("locationInSpace:")]
	SPPoint LocationInSpace (SPDisplayObject space);

	//- (SPPoint*)previousLocationInSpace:(SPDisplayObject*)space;
	[Export ("previousLocationInSpace:")]
	SPPoint PreviousLocationInSpace (SPDisplayObject space);

	//@property (nonatomic, readonly) double timestamp;
	[Export ("timestamp")]//, ArgumentSemantic.ReadOnly)]
	double Timestamp { get;  }

	//@property (nonatomic, readonly) float globalX;
	[Export ("globalX")]//, ArgumentSemantic.ReadOnly)]
	float GlobalX { get;  }

	//@property (nonatomic, readonly) float globalY;
	[Export ("globalY")]//, ArgumentSemantic.ReadOnly)]
	float GlobalY { get;  }

	//@property (nonatomic, readonly) float previousGlobalX;
	[Export ("previousGlobalX")]//, ArgumentSemantic.ReadOnly)]
	float PreviousGlobalX { get;  }

	//@property (nonatomic, readonly) float previousGlobalY;
	[Export ("previousGlobalY")]//, ArgumentSemantic.ReadOnly)]
	float PreviousGlobalY { get;  }

	//@property (nonatomic, readonly) int tapCount;
	[Export ("tapCount")]//, ArgumentSemantic.ReadOnly)]
	int TapCount { get;  }

	//@property (nonatomic, readonly) SPTouchPhase phase;
	[Export ("phase")]//, ArgumentSemantic.ReadOnly)]
	SPTouchPhase Phase { get;  }

	//@property (nonatomic, readonly) SPDisplayObject *target;
	[Export ("target")]//, ArgumentSemantic.ReadOnly)]
	SPDisplayObject Target { get;  }

}

[BaseType (typeof (SPEvent))]
interface SPTouchEvent {
	//- (id)initWithType:(NSString*)type bubbles:(BOOL)bubbles touches:(NSSet*)touches;
	[Export ("initWithType:bubbles:touches:")]
	IntPtr Constructor (string type, bool bubbles, NSSet touches);

	//- (id)initWithType:(NSString*)type touches:(NSSet*)touches;
	[Export ("initWithType:touches:")]
	IntPtr Constructor (string type, NSSet touches);

	[Static]
	//+ (SPTouchEvent*)eventWithType:(NSString*)type touches:(NSSet*)touches;
	[Export ("eventWithType:touches:")]
	SPTouchEvent EventWithType (string type, NSSet touches);

	//- (NSSet*)touchesWithTarget:(SPDisplayObject*)target;
	[Export ("touchesWithTarget:")]
	NSSet TouchesWithTarget (SPDisplayObject target);

	//- (NSSet*)touchesWithTarget:(SPDisplayObject*)target andPhase:(SPTouchPhase)phase;
	[Export ("touchesWithTarget:andPhase:")]
	NSSet TouchesWithTarget (SPDisplayObject target, SPTouchPhase phase);

	//@property (nonatomic, readonly) NSSet *touches;
	[Export ("touches")]//, ArgumentSemantic.ReadOnly)]
	NSSet Touches { get;  }

	//@property (nonatomic, readonly) double timestamp;
	[Export ("timestamp")]//, ArgumentSemantic.ReadOnly)]
	double Timestamp { get;  }

}

[BaseType (typeof (NSObject))]
interface SPTouchProcessor {
	//- (id)initWithRoot:(SPDisplayObjectContainer*)root;
	[Export ("initWithRoot:")]
	IntPtr Constructor (SPDisplayObjectContainer root);

	//- (void)processTouches:(NSSet*)touches;
	[Export ("processTouches:")]
	void ProcessTouches (NSSet touches);

	//@property (nonatomic, assign) SPDisplayObjectContainer *root;
	[Export ("root", ArgumentSemantic.Assign)]
	SPDisplayObjectContainer Root { get; set;  }

}

[BaseType (typeof (NSObject))]
interface SPTransitions {
	[Static]
	//+ (float)linear:(float)ratio;
	[Export ("linear:")]
	float Linear (float ratio);

	[Static]
	//+ (float)randomize:(float)ratio;
	[Export ("randomize:")]
	float Randomize (float ratio);

	[Static]
	//+ (float)easeIn:(float)ratio;
	[Export ("easeIn:")]
	float EaseIn (float ratio);

	[Static]
	//+ (float)easeOut:(float)ratio;
	[Export ("easeOut:")]
	float EaseOut (float ratio);

	[Static]
	//+ (float)easeInOut:(float)ratio;
	[Export ("easeInOut:")]
	float EaseInOut (float ratio);

	[Static]
	//+ (float)easeOutIn:(float)ratio;
	[Export ("easeOutIn:")]
	float EaseOutIn (float ratio);

	[Static]
	//+ (float)easeInBack:(float)ratio;
	[Export ("easeInBack:")]
	float EaseInBack (float ratio);

	[Static]
	//+ (float)easeOutBack:(float)ratio;
	[Export ("easeOutBack:")]
	float EaseOutBack (float ratio);

	[Static]
	//+ (float)easeInOutBack:(float)ratio;
	[Export ("easeInOutBack:")]
	float EaseInOutBack (float ratio);

	[Static]
	//+ (float)easeOutInBack:(float)ratio;
	[Export ("easeOutInBack:")]
	float EaseOutInBack (float ratio);

	[Static]
	//+ (float)easeInElastic:(float)ratio;
	[Export ("easeInElastic:")]
	float EaseInElastic (float ratio);

	[Static]
	//+ (float)easeOutElastic:(float)ratio;
	[Export ("easeOutElastic:")]
	float EaseOutElastic (float ratio);

	[Static]
	//+ (float)easeInOutElastic:(float)ratio;
	[Export ("easeInOutElastic:")]
	float EaseInOutElastic (float ratio);

	[Static]
	//+ (float)easeOutInElastic:(float)ratio;
	[Export ("easeOutInElastic:")]
	float EaseOutInElastic (float ratio);

	[Static]
	//+ (float)easeInBounce:(float)ratio;
	[Export ("easeInBounce:")]
	float EaseInBounce (float ratio);

	[Static]
	//+ (float)easeOutBounce:(float)ratio;
	[Export ("easeOutBounce:")]
	float EaseOutBounce (float ratio);

	[Static]
	//+ (float)easeInOutBounce:(float)ratio;
	[Export ("easeInOutBounce:")]
	float EaseInOutBounce (float ratio);

	[Static]
	//+ (float)easeOutInBounce:(float)ratio;
	[Export ("easeOutInBounce:")]
	float EaseOutInBounce (float ratio);

}

[BaseType (typeof (SPEventDispatcher))]
interface SPTween {
	//- (id)initWithTarget:(id)target time:(double)time transition:(NSString*)transition;
	[Export ("initWithTarget:time:transition:")]
	IntPtr Constructor (NSObject target, double time, string transition);

	//- (id)initWithTarget:(id)target time:(double)time;
	[Export ("initWithTarget:time:")]
	IntPtr Constructor (NSObject target, double time);

	[Static]
	//+ (SPTween *)tweenWithTarget:(id)target time:(double)time transition:(NSString *)transition;
	[Export ("tweenWithTarget:time:transition:")]
	SPTween  TweenWithTarget (NSObject target, double time, string transition);

	[Static]
	//+ (SPTween *)tweenWithTarget:(id)target time:(double)time;
	[Export ("tweenWithTarget:time:")]
	SPTween  TweenWithTarget (NSObject target, double time);

	//- (void)animateProperty:(NSString*)property targetValue:(float)value;
	[Export ("animateProperty:targetValue:")]
	void AnimateProperty (string property, float value);

	//@property (nonatomic, readonly) id target;
	[Export ("target")]//, ArgumentSemantic.ReadOnly)]
	SPTween Target { get;  }

	//@property (nonatomic, readonly) NSString *transition;
	[Export ("transition")]//, ArgumentSemantic.ReadOnly)]
	string Transition { get;  }

	//@property (nonatomic, readonly) double time;
	[Export ("time")]//, ArgumentSemantic.ReadOnly)]
	double Time { get;  }

	//@property (nonatomic, assign)   double delay;
	[Export ("delay", ArgumentSemantic.Assign)]
	double Delay { get; set;  }

	//@property (nonatomic, assign)   SPLoopType loop;
	[Export ("loop", ArgumentSemantic.Assign)]
	SPLoopType Loop { get; set;  }

}

[BaseType (typeof (NSObject))]
interface SPTweenedProperty {
	//- (id)initWithTarget:(id)target name:(NSString *)name endValue:(float)endValue;
	[Export ("initWithTarget:name:endValue:")]
	IntPtr Constructor (NSObject target, string name, float endValue);

	//@property (nonatomic, assign) float startValue;
	[Export ("startValue", ArgumentSemantic.Assign)]
	float StartValue { get; set;  }

	//@property (nonatomic, assign) float currentValue;
	[Export ("currentValue", ArgumentSemantic.Assign)]
	float CurrentValue { get; set;  }

	//@property (nonatomic, assign) float endValue;
	[Export ("endValue", ArgumentSemantic.Assign)]
	float EndValue { get; set;  }

	//@property (nonatomic, readonly) float delta;
	[Export ("delta")]//, ArgumentSemantic.ReadOnly)]
	float Delta { get;  }

}

[BaseType (typeof (NSObject))]
interface SPUtils {
	[Static]
	//+ (int)nextPowerOfTwo:(int)number;
	[Export ("nextPowerOfTwo:")]
	int NextPowerOfTwo (int number);

	[Static]
	//+ (int)randomIntBetween:(int)minValue and:(int)maxValue;
	[Export ("randomIntBetween:and:")]
	int RandomIntBetween (int minValue, int maxValue);

	[Static]
	//+ (float)randomFloat;
	[Export ("randomFloat")]
	float RandomFloat ();

}

[BaseType (typeof (UIView))]
interface SPView {
	//@property (nonatomic, readonly) BOOL isStarted;
	[Export ("isStarted")]//, ArgumentSemantic.ReadOnly)]
	bool IsStarted { get;  }

	//@property (nonatomic, assign) float frameRate;
	[Export ("frameRate", ArgumentSemantic.Assign)]
	float FrameRate { get; set;  }

	//@property (nonatomic, retain) SPStage *stage;
	[Export ("stage", ArgumentSemantic.Retain)]
	SPStage Stage { get; set;  }

	//- (void)start;
	[Export ("start")]
	void Start ();

	//- (void)stop;
	[Export ("stop")]
	void Stop ();

}
}
