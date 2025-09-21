# MyModbusRtuDevice
## 简介
- 个人WinForm学习用Modbus项目
- 通过ModbusRTU协议实时获取数据并进行展示
- 支持实时数据浏览、历史数据存储（基于SQLite）、异常告警（支持导出为CSV）、连接配置等功能

## 浏览图
### 系统概况
![系统概况](./img/readme/system_overview.png)
### 数据跟踪
![数据跟踪](./img/readme/data_track.png)
### 状态预警
![1](./img/readme/status_alarm_1.png)
![2](./img/readme/status_alarm_2.png)
### 系统配置
![系统配置](./img/readme/system_config.png)

## 使用
### 配置文件
编辑项目下的config_example.json文件，并改名为config.json，然后放到编译好的程序目录下使用
### 数据库
在编译后的程序目录下创建SQLite3数据库文件，并命名为data.db，启动后会自动创建表