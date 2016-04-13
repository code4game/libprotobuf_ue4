libprotobuf for [Unreal Engine 4][]
=====

Link the google's `protocol bufffers` library as the third party in [Unreal Engine 4][].


Usage
-----

1. Generate the code file of the protocal by `protoc`. (Ref: [Google's Protocol Buffers][])
1. Regenerate the code file for [Unreal Engine 4][] by `regenerateforue4.py`.
    * `python regenerateforue4.py 'your code file'`
1. You need include two header files when include the `code file`'s header.
    * `#include "AllowWindowsPlatformTypes.h"`  //< before include `code file`'s header
    * `#include "your code header file"`
    * `#include "HideWindowsPlatformTypes.h"`   //< after include `code file`'s header
1. That's all.


License
-----

Use The MIT License.


**Copyright (c) 2016, [Code 4 Game][].**

[Unreal Engine 4]: https://www.unrealengine.com/
[Google's Protocol Buffers]: https://developers.google.com/protocol-buffers/
[Code 4 Game]: https://c4g.io/