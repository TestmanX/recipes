using System;
using CoreGraphics;

using Foundation;
using UIKit;

namespace AddNewView
{
    public partial class AddNewViewViewController : UIViewController
    {
        public AddNewViewViewController () : base ("AddNewViewViewController", null)
        {
        }
        
        public override void LoadView ()
        {
            base.LoadView ();
            
            bool shouldLoadNewView = true;
            
            if (shouldLoadNewView) {
                NSBundle.MainBundle.LoadNib ("MyNewView", this, null);
            }
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
        
        public override void ViewDidUnload ()
        {
            base.ViewDidUnload ();
            
            // Clear any references to subviews of the main view in order to
            // allow the Garbage Collector to collect them sooner.
            //
            // e.g. myOutlet.Dispose (); myOutlet = null;
            
            ReleaseDesignerOutlets ();
        }
        
        public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
    }
    
    [Register("MyNewView")]
    class MyNewView: UIView
    {
        public MyNewView (IntPtr p) : base(p)
        {
        }
    }
   
}

