﻿
using System;

using Foundation;
using UIKit;

namespace HELPiOS
{
	public partial class cancelBookingVC : UIViewController
	{
		public cancelBookingVC () : base ("cancelBookingVC", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}
