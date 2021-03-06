效果视频 [https://www.bilibili.com/video/av76787677/](https://www.bilibili.com/video/av76787677/)

**IMGUI 和 UGUI 实现的优缺点**

**IMGUI**

* 优点
  * IMGUI 直接使用 OnGUI 函数就可以实现简单的 UI 效果，开发简单；
* 缺点
  * 因为其始终是一个位于所有对象之上的界面，无法添加 3D 的效果。

**UGUI**

* 优点
  * 一部分 UGUI 的计算放到子线程中完成，可以缓解主线程的压力；
  * UGUI 有锚点，更方便屏幕自适应；
  * UGUI 不需要绑定Colliders，UI可以自动拦截事件
* 缺点
  * 每个对象都需要添加一个 canvas，过多的对象则

**预制的使用方法**

* 已经将全部功能整合到预制中；
* 直接将 Prefabs 中的 IMGUI 或 UGUI 预制拖入场景即可，可以添加一个 Plane 作为参考；
* 按下键盘的 A, S, D, W 分别向左，向后，向右，向前移动对象。
* 按下增/减按钮可实现血条长度的增/减。
