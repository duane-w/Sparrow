using System;
using Sparrow;

namespace SparrowTest
{
	public class AtlasScene : SPSprite
	{
		public AtlasScene () : base ()
		{
			SPTextureAtlas  atlas = new SPTextureAtlas ("atlas.xml");
	        Console.WriteLine("found {0} textures.", atlas.Count);
	        
	        SPImage  image1 = new SPImage (atlas.TextureByName ("walk_00"));
	        image1.X = 30;
	        image1.Y = 30;
			AddChild (image1);
	        
	        SPImage  image2 = new SPImage (atlas.TextureByName ("walk_01"));
	        image2.X = 90;
	        image2.Y = 110;
	        AddChild (image2);
	        
	        SPImage  image3 = new SPImage (atlas.TextureByName ("walk_03"));
	        image3.X = 150;
	        image3.Y = 190;
	        AddChild (image3);        
	        
	        SPImage  image4 = new SPImage (atlas.TextureByName ("walk_05"));
	        image4.X = 210;
	        image4.Y = 270;
	        AddChild (image4);  
		}
	}
}

