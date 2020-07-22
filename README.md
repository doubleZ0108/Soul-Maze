# <img src="/Users/doublez/Developer/Digital Media/Soul-Maze/logo.png" alt="logo" width="10%;" />译梦机 | Soul Maze

Table of Contents
=================

   * [译梦机 | Soul Maze](#译梦机--soul-maze)
      * [游戏简介](#游戏简介)
      * [游戏背景](#游戏背景)
      * [游戏设定](#游戏设定)
      * [游戏截屏](#游戏截屏)
      * [项目结构](#项目结构)
      * [游戏环境](#游戏环境)
      * [游戏开发时间线](#游戏开发时间线)
      * [关于作者](#关于作者)

------

## 游戏简介

《心灵迷宫——译梦机》带玩家以第一人称视角，扮演一位抑郁症姑娘，了解抑郁症患者的内心世界。

在游戏中，主角的心理世界化为迷宫般的梦境。当你置身其中，面对纷繁复杂的心灵迷宫，你需要躲避时不时袭来的怪物，就像这类人群每日都要面对的低落与忧伤。怪物的追捕、音效的变化、自身血量和san值降低带来的负面影响，都会操控你的情绪。但不必就此沮丧，迷宫中的灯光会指引你寻找爱和希望。通过获取心型物品补充血量，通过获取火焰来保持san值，在这些的支撑和帮助下，你可以努力的在地图中寻找碎片，每一条碎片会给出建议或一件开心的小事，让主角发现，生活中其实充满了细小的美好与感动。

当你搜集齐九个碎片，游戏通关。

梦醒了，太阳照常升起，生命中无数细小而温暖的碎片，支撑着一个又一个脆弱渺小又美丽的灵魂。

<br/>

## 游戏背景

我有一只黑狗，它名为抑郁

它总不期而至的出现我的面前

整个世界好像都在享受生活，我却只能与黑狗相伴

它蚕食掉我的记忆力和集中精神的能力

它让我烦躁不安，难于相处

它让我发现，躺倒永远比重新站起来更容易

黑狗带来的无力与羞愧

我总是担心被人知道

于是我很用力的，很用力的，

把它藏起来

藏进了我幽暗晦涩的迷宫般的心里

我感觉我，和整个世界失去了联系

...

你需要相信，你的人生也如这迷宫一般，尽管四周潜伏着黑狗，尽管行走时处处碰壁，尽管有时会迷失

方向，但总会碰到生活中的“火种”，总会捡拾到抵抗困难的“碎片”，感到脆弱并不丢人，只有错过生活

才是遗憾。

<br/>

## 游戏设定

|            **设定**             |                 **备注**                 |                            **UI**                            |
| :-----------------------------: | :--------------------------------------: | :----------------------------------------------------------: |
|               椿                |        抑郁症患者，渴望与抑郁和解        | <img src="https://upload-images.jianshu.io/upload_images/12014150-c22943895023d042.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="image-20200722194332041" width="50%;" /> |
|    最大值为5  可吃心回复HP+1    | 小怪攻击HP-1  Boss攻击HP-3  HP=0游戏失败 | ![img](https://upload-images.jianshu.io/upload_images/12014150-8fc43fff9cd6c731.jpg?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240) |
| 最大值为100  可吃火焰回复san+10 |      持续掉san-1/s  影响移速和亮度       | ![img](https://upload-images.jianshu.io/upload_images/12014150-7cfda97c83538882.jpg?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240) |
|       总数9个  集齐可通关       |                   暂无                   | ![img](https://upload-images.jianshu.io/upload_images/12014150-77ffeb10cb4925d7.jpg?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240) |

|    设定    |                  象征                  |            作用            |                              UI                              |
| :--------: | :------------------------------------: | :------------------------: | :----------------------------------------------------------: |
| **小怪物** |   代表总会向抑郁患者袭来的难过和悲伤   |    碰触主角导致主角HP-1    | <img src="https://upload-images.jianshu.io/upload_images/12014150-a8ba103d0df9c24d.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" width="30%" /> |
|  **BOSS**  |   代表总会向抑郁患者袭来的难过和悲伤   |    碰触主角导致主角HP-3    | <img src="https://upload-images.jianshu.io/upload_images/12014150-6952753a3e3fb598.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" width="30%" /> |
|  **火种**  |            代表生活中的激励            |   提升主角san值 (san+10)   | <img src="https://upload-images.jianshu.io/upload_images/12014150-9e32785784fa5203.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" width="30%" /> |
|   **心**   |            代表生活中的激励            |    提升主角HP值 (HP+1)     | <img src="https://upload-images.jianshu.io/upload_images/12014150-65c9187375180f5a.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" width="30%" /> |
|  **碎片**  | 代表与抑郁症和解的建议、生活中美好小事 | 目标收集道具，集齐九个通关 | <img src="https://upload-images.jianshu.io/upload_images/12014150-3cf867af03a2db68.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" width="30%" /> |

<br/>

## 游戏截屏

<img src="https://upload-images.jianshu.io/upload_images/12014150-1d6d5ec736410806.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="image-20200722200700079" style="zoom:50%;" align="center" />

<img src="/Users/doublez/Developer/Digital Media/Soul-Maze/README.assets/image-20200722200705894.png" alt="image-20200722200705894" style="zoom:50%;" align="center" />

<img src="https://upload-images.jianshu.io/upload_images/12014150-76d2bc2a5b95d309.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="image-20200722200712083" style="zoom:50%;" align="center" />

<img src="https://upload-images.jianshu.io/upload_images/12014150-7df5d1370cea4b67.PNG?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="图片 1" width="50%;" align="center" />

<br/>

## 项目结构

- `Assets/` `Packages/` `ProjectSettings/`: Unity工程
- `doc/`
  - 《译梦机》游戏设计文档.pdf
  - 游戏程序与设计期末项目开题说明.pdf
  - Game Program and Design Final Project Brief Introduction.pdf
  - background.pdf
  - logic.md
- `pre/`
  - presentation.pdf
- `logo.png`

<br/>

## 游戏环境

- **运行系统**
  - Windows 10
  - macOS Catalina 10.15+
- **开发引擎**：Unity 2019.3.14f1
- **开发语言**：C#

<br/>

## 游戏开发时间线

<img src="https://upload-images.jianshu.io/upload_images/12014150-1c41ec0a903aac56.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="image-20200722195227660" style="zoom:50%;" />

| **姓名**          | **日期**   | **推进**                             | **协作形式**       |
| ----------------- | ---------- | ------------------------------------ | ------------------ |
| **全体**          | 3.21       | 确定游戏选题                         | 线上会议           |
| **张喆**          | 3.25       | 游戏项目开题报告v1.0                 | 个人完成           |
| **李文玥 张靖萌** | 3.31       | 游戏项目开题报告修订v2.0             | 合作完成           |
| **李文玥 张靖萌** | 4.1        | 游戏项目开题报告（英文版）           | 合作完成           |
| **全体**          | 4.8        | 游戏框架制定v1.0                     | 线上会议           |
| **张喆**          | 4.8～5.1   | 游戏人物初稿制作                     | 个人完成           |
| **李文玥 张靖萌** | 4.8～5.1   | 游戏场景初稿制                       | 合作完成           |
| **陈开昕**        | 5.2        | 确定游戏美术风格（lowpoly）          | 个人完成           |
| **全体**          | 5.8        | 第一次合并 修正游戏设计              | 线上会议           |
| **全体**          | 5.18       | Demo通过测试 正式开发 创建github仓库 | 线上会议           |
| **张喆**          | 5.20～5.28 | 人物和AI制作                         | 个人完成           |
| **陈开昕**        | 5.20～5.28 | 地图优化 相机制作                    | 个人完成           |
| **李文玥 张靖萌** | 5.20～5.28 | UI制作                               | 合作完成           |
| **李文玥 张靖萌** | 6.15       | 游戏故事线完善                       | 合作完成           |
| **全体**          | 6.17       | 项目第一次展示 老师答疑              | 线上会议           |
| **全体**          | 6.18～6.20 | 游戏完善                             | 合作完成           |
| **全体**          | 6.20～6.23 | 游戏测试 游戏部署                    | 线上会议  合作完成 |
| **李文玥**        | 6.21       | 确立文档大致框架，制定项目文档v1.0   | 个人完成           |
| **张靖萌**        | 6.22       | 游戏MV剪辑                           | 个人完成           |
| **陈开昕**        | 6.22       | 游戏声音制作 游戏美化                | 个人完成           |
| **张喆**          | 6.22       | 游戏性能优化                         | 个人完成           |
| **张喆**          | 6.24       | 答辩ppt制作                          | 个人完成           |
| **全体**          | 6.24       | 项目文档完善，制定项目文档v2.0       | 合作完成           |

<img src="https://upload-images.jianshu.io/upload_images/12014150-a26108387bb6b7e9.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240" alt="image-20200722195152619" style="zoom:50%;" />

<br/>

## 关于作者

|  姓名  |  团队职责  |                           主要工作                           |         邮箱          |
| :--------: | :--------: | :-------------------------------------------------: | :-------------------: |
|  张喆  | 项目组组长 | 项目确立、人物制作、AI制作、各部分拼接、游戏性能优化、部分算法实现 | dbzdbz@tongji.edu.cn  |
| 陈开昕 |  美术指导  |       相机制作、美术资源收集处理、场景优化、小地图制作       | 1753188@tongji.edu.cn |
| 李文玥 |  文档组长  |           项目背景、UI制作、引导关卡制作、游戏文档           | 1750803@tongji.edu.cn |
| 张靖萌 | 故事线组长 |           项目背景、UI制作、项目故事线、游戏MV剪辑           | 1753498@tongji.edu.cn |