libprotobuf for [Unreal Engine 4][]
=====

[![Join the chat at https://gitter.im/code4game/libprotobuf](https://badges.gitter.im/code4game/libprotobuf.svg)](https://gitter.im/code4game/libprotobuf?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Link the google's `protocol bufffers` library as the third party in [Unreal Engine 4][].


Usage
-----

1. Import or copy this project into `<your project or plugin>/Source/ThirdParty/libprotobuf`.
1. Add the libprotobuf as a module into `<your project>.Build.cs`
  * `PrivateDependencyModuleNames.AddRange(new string[] { "CoreUObject", "Engine", "libprotobuf" });`
1. Generate two code files (header & source, ex: Message.pb.h & Message.pb.cc) of the protocal by `protoc` for `cpp`. (Ref: [Google's Protocol Buffers][])
1. Put them into the source directory (`Private` or `Public`) of your project.
1. Regenerate the code file for [Unreal Engine 4][] by `regenerateforue4.py`.
    * `python regenerateforue4.py 'the source file'`
    * ex: `python regenerateforue4.py Message.pb.cc`
    * You should get this information: `Success to regenerate the code for UE4`
1. You need include two header files when include the header file(ex: Message.pb.h).
    * `#include "AllowWindowsPlatformTypes.h"`  //< before include the header file
    * `#include "your code header file"`        //< ex: `#include "Message.pb.h"`
    * `#include "HideWindowsPlatformTypes.h"`   //< after include the header file
1. Include and use the header file(ex: Message.pb.h) in your `.cpp` file.
1. That's all.


Roadmap
-----

* Write a tutorial for the usage and create an example
* Support mobile platforms - Android/iOS/Windows Phone


License
-----

Use The MIT License.


**Copyright (c) 2016, [Code 4 Game][].**

[Unreal Engine 4]: https://www.unrealengine.com/
[Google's Protocol Buffers]: https://developers.google.com/protocol-buffers/
[Code 4 Game]: https://c4g.io/
