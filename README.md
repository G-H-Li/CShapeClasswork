# CShapeClasswork
C#作业专用库

------
## work1：console，简易控制台计算器
## work2：win form，简易windows窗口计算器
## work3：console，课堂作业
> ArrayOperator:
>* 求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

> PrimeFactor:
>* 输出用户指定数据的所有素数因子。

> PrimeNum:
>* 使用“埃氏筛法”求用户所提供数据以内所有的素数。

## work4：console，课堂作业
> TwoDShape:
>* 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
>* 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。

## work5：console，课堂作业
> Linklist:
>* 泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

> Clock:
>* 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。

## work6：console，课堂作业
> OrderOS:写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
>* 使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
>* 在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
>* 作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
>* 订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
>* OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。

## work6：console，课堂作业
> OrderOS：在work6中添加序列化和反序列化操作，以及测试模块
>* 在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
>* 对订单程序中OrderService的各个Public方法添加测试用例。