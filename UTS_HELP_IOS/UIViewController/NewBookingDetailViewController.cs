﻿
using System;

using Foundation;
using UIKit;
using CoreGraphics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HELPiOS
{
	public partial class NewBookingDetailViewController : UIViewController
	{
		public WorkshopBooking workshopBooking { get; set;}
		
		public NewBookingDetailViewController (IntPtr handle) : base (handle)
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
			//disable edit for text field
			descriptionTextView.Editable = false;

			//handle back button action
			backButton.Clicked += (o, e) => {
				this.DismissViewControllerAsync(true);
			};
			//book button
			bookButton.TouchUpInside += (o, e) => {
				this.bookWorkshop();
			};

//			Console.WriteLine ("Load My Bookings Detail View");
			this.showBookingDetail ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		private void showBookingDetail ()
		{			
			descriptionTextView.Text = workshopBooking.description==null?"No description":workshopBooking.description;
			myBookingDetailTable.Source = new MyBookingDetailTableSource (workshopBooking);
			myBookingDetailTable.ReloadData ();
		}

		private async void bookWorkshop(){
			LoadingOverlay.Instance.showLoading(this);
			WorkshopBookingList workshopBookingList = new WorkshopBookingList();
			try{
//			workshopBookingList.createBooking(WebKit,student);
			}
			catch(Exception ex){
				AppParam.Instance.showAlertMessage ("Workshop Booking", "Booking Fail!");
			}

		}
	}
}
