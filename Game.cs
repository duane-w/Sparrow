using System;
using Sparrow;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

namespace SparrowTest
{
	public class Game : SPStage
	{
		SPSprite mMainMenu;
		SPSprite mCurrentScene;
		SPButton mBackButton;
		int mNumButtons = 0;
			
		public Game (IntPtr p) : base (p)
		{
		}
		
		public Game (float width, float height) : base (width, height)
		{
			using (NSAutoreleasePool pool = new NSAutoreleasePool ())
			{
				AddChild (SPImage.ImageWithContentsOfFile ("Default.png"));
				
				mMainMenu = new SPSprite();
				AddChild (mMainMenu);
				
				mMainMenu.AddChild (SPImage.ImageWithContentsOfFile ("logo.png"));
				
				SPTexture sceneButtonTexture = SPTexture.TextureWithContentsOfFile ("button_big.png");
				
				SPButton atlasButton = SPButton.ButtonWithUpState (sceneButtonTexture, "Texture Atlas");
				atlasButton.AddEventListener (new Selector ("onAtlasButtonTriggered:"), this, SPEvents.ButtonTriggered);
				addSceneButton (atlasButton);
				
				
				SPTexture backButtonTexture = SPTexture.TextureWithContentsOfFile ("button_back.png");
		        mBackButton = new SPButton (backButtonTexture, "back");
		        mBackButton.Visible = false;
		        mBackButton.X = (int)(Stage.Width - mBackButton.Width) / 2;
		        mBackButton.Y = Stage.Height - mBackButton.Height + 1;
		        mBackButton.AddEventListener (new Selector ("onBackButtonTriggered:"), this, SPEvents.ButtonTriggered); 
		        AddChild (mBackButton);
			}
		}
		
		void showScene (SPSprite scene)
		{
		    mCurrentScene = scene;
			AddChild (scene);
		
		    mMainMenu.Visible = false;
		    mBackButton.Visible = true;
		}
		
		[Export ("onBackButtonTriggered:")]
		void onBackButtonTriggered (SPEvent e)
		{
			mCurrentScene.RemoveFromParent ();
			mCurrentScene = null;
		
			mBackButton.Visible = false;
			mMainMenu.Visible = true;
		}
		
		[Export ("onAtlasButtonTriggered:")]
		void onAtlasButtonTriggered (SPEvent e)
		{
			SPSprite scene = new AtlasScene();
			showScene (scene);
		}
		
		private void addSceneButton (SPButton button)
		{
			button.X = mNumButtons % 2 == 0 ? 28 : 167;
			button.Y = 150 + (mNumButtons / 2) * 52 + (mNumButtons % 2) * 26;
			mMainMenu.AddChild (button);
			mNumButtons++;
		}
	}
}

