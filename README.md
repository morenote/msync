# morenote-sync-cli

>   保持本地笔记与云端的双向同步和备份

## 概述  

msync是一个用于同步leanote笔记数据的cli工具，你可以使用命令行下载远端数据到本地或者上传本地数据到远端或者备份你的笔记数据。

## 特性

-   [ ] 同步远端笔记数据到本地
-   [ ] 同步本地笔记数据到远端
-   [ ] 支持图片URL处理，无需担心图片裂开
-   [ ] 支持笔记数据备份和修复

## 快速使用

```shell
#步骤1 克隆远端数据到本地（开发中）
msync clone -remote https://leanote.com -email your-email@qq.com -password your-password
msync clone -remote https://leanote.com -token your-token
#步骤2 更新笔记 拉取远程的笔记同时把本地的笔记更新到远端（开发中）
msync update 
#步骤3 制作归档文件（开发中）
msync archive -out your-backup-folder/xxx.tar.gz
#步骤4 高级命令（开发中）
msync commit 提交笔记数据到本地
msync pull   拉取远端数据
msync push   推送本地数据到远端
msync status 观察同步情况
msync gc     删除缓存文件和临时文件，尽可能的压缩笔记数据、图片、附件
msync watch  持续监听文件变化，自动执行msync update 
msync repair -a  xxx.tar.gz 使用归档文件修复数据
msync login  -email your-email@qq.com -passowrd your-password 重新登录，如果token失效
```

## 开发指引

msync使用C#开发

开发工具：vs2020社区版

## 版本



## 感谢

[taozhang-tt/leanote-sync: Apache-2.0 License](https://github.com/taozhang-tt/leanote-sync)













