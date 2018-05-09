//
//  CEFApplication.h
//  CEFSample
//
//  Created by YvonneDu on 4/20/18.
//  Copyright © 2018 YvonneDu. All rights reserved.
//

#ifndef CEFApplication_h
#define CEFApplication_h

#import <Cocoa/Cocoa.h>

// Provide the CefAppProtocol implementation required by CEF.
@interface CEFApplication : NSApplication
{
@private
    BOOL handlingSendEvent_;
}
@end

#endif /* CEFApplication_h */
