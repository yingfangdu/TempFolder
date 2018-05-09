//
//  CEFBootstrapper.h
//  CEFSample
//
//  Created by YvonneDu on 4/20/18.
//  Copyright © 2018 YvonneDu. All rights reserved.
//

#ifndef CEFBootstrapper_h
#define CEFBootstrapper_h
#import <Cocoa/Cocoa.h>

@interface CEFBootstrapper : NSObject
+ (void)initializeCEF;
+ (void)shutDownCEF;
@end

#endif /* CEFBootstrapper_h */
