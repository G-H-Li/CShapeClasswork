# CShapeClasswork
C#作业专用库

------
## work1：console，简易控制台计算器（2020年2月21日课堂作业）
## work2：win form，简易windows窗口计算器（2020年2月21日课堂作业）
## work3：console（2020年2月28日课堂作业）
> ArrayOperator:
>* 求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

> PrimeFactor:
>* 输出用户指定数据的所有素数因子。

> PrimeNum:
>* 使用“埃氏筛法”求用户所提供数据以内所有的素数。

## work4：console（2020年3月6日课堂作业）
> TwoDShape:
>* 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
>* 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。

## work5：console（2020年3月13日课堂作业）
> Linklist:
>* 泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

> Clock:
>* 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。

## work6：console（2020年3月20日课堂作业）
> OrderOS:写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
>* 使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
>* 在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
>* 作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
>* 订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
>* OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。

## work6：console（2020年3月27日课堂作业）
> OrderOSTests：在work6中添加序列化和反序列化操作，以及测试模块
>* 在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
>* 对订单程序中OrderService的各个Public方法添加测试用例。

## work7：winform（2020年4月3日课堂作业）
> CayleyTree:将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。

> 附加功能：
>* 控件随着form变化而等比例变化
>* 画图情况输出

> sample img:
> <img src="https://github.com/G-H-Li/CShapeClasswork/blob/master/Work7/start.png">
> <img src="https://github.com/G-H-Li/CShapeClasswork/blob/master/Work7/draw.png">

## work6：winform（2020年4月11日课堂作业）
ClassOrderManger+OrderWinform：为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单、导出订单、导入订单等功能。
> 要求：
>* WinForm的界面部分单独写一个项目，依赖于原来的项目。
>* 可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
>* 注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。
>* 尽量通过数据绑定来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。

> 易错点：
>* 在进行数据绑定时，需要保证引入进winform程序的类也是采用.Net FrameWork，才能顺利完成数据绑定的操作。
>* bindingNavigator在使用加号按钮进行添加数据时，会自动调用绑定类的默认构造函数进行构造数据。要注意好不同控件之间的数据绑定关系。

> sample img:
> <img src="https://github.com/G-H-Li/CShapeClasswork/blob/master/work6/result.png">

## work8：winform（2020年4月17日课堂作业）
Spider+SpiderWinform：博客园用户的相关页面爬取
>* 只爬取起始网站上的网页 
>* 只有当爬取的是html文本时，才解析并爬取下一级URL。
>* 相对地址转成绝对地址进行爬取。
>* 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

## work8：winform（2020年4月24日课堂作业）
Spider+SpiderWinform（并行） + test（串行）：将爬取进程由串行改为并行
>* 针对同一网页做十个网页的时间测试，测试结果如下：

> 并行：00:00:00.7484090、00:00:01.4269162、00:00:01.1132778

> 串行：00:00:02.6038134、00:00:03.1985198、00:00:05.5147827
