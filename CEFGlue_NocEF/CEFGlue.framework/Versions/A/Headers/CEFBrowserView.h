//
//  CEFBrowserView.h
//  CEFSample
//
//  Created by YvonneDu on 4/19/18.
//  Copyright © 2018 YvonneDu. All rights reserved.
//

#ifndef CEFBrowserView_h
#define CEFBrowserView_h

#import <Cocoa/Cocoa.h>

//#include "include/cef_browser.h"

@interface CEFBrowserView : NSView
{
//    CefRefPtr<CefBrowser> _browser;
}
-(bool)isBrowserInitialized;
-(void)navigateTo:(NSString*)location;
-(void)reload;
@end

#endif /* CEFBrowserView_h */
