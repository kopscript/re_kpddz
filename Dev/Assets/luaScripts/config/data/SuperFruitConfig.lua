--表名: 超级水果中奖倍数, 字段描述：_key:ID, _name:名称, _power2:2连线倍率, _power3:3连线倍率, _power4:4连线倍率, _power5:5连线倍率, _rate:权重, _icon:图标, 
local M = {}
M["1"] = {key = "1", name = "香蕉", power2 = "0", power3 = "3", power4 = "10", power5 = "75", rate = {{"3484", "3484", "3484", "3484", "3484", "3483", "3481", }, }, icon = "S101", }
M["2"] = {key = "2", name = "西瓜", power2 = "0", power3 = "3", power4 = "10", power5 = "85", rate = {{"1060", "1230", "1320", "1380", "1440", "1481", "1503", }, }, icon = "S102", }
M["3"] = {key = "3", name = "柠檬", power2 = "0", power3 = "15", power4 = "40", power5 = "250", rate = {{"1480", "1340", "1280", "1250", "1220", "1200", "1190", }, }, icon = "S103", }
M["4"] = {key = "4", name = "葡萄", power2 = "0", power3 = "25", power4 = "50", power5 = "400", rate = {{"918", "918", "918", "918", "918", "918", "918", }, }, icon = "S104", }
M["5"] = {key = "5", name = "幸运草", power2 = "0", power3 = "30", power4 = "70", power5 = "550", rate = {{"702", "702", "702", "702", "702", "702", "702", }, }, icon = "S105", }
M["6"] = {key = "6", name = "铃铛", power2 = "0", power3 = "35", power4 = "80", power5 = "650", rate = {{"667", "667", "667", "667", "667", "667", "667", }, }, icon = "S106", }
M["7"] = {key = "7", name = "樱桃", power2 = "0", power3 = "45", power4 = "100", power5 = "800", rate = {{"440", "440", "440", "440", "440", "440", "440", }, }, icon = "S107", }
M["8"] = {key = "8", name = "纱票", power2 = "0", power3 = "75", power4 = "175", power5 = "1250", rate = {{"293", "293", "293", "293", "293", "293", "293", }, }, icon = "S108", }
M["9"] = {key = "9", name = "WILD钻石", power2 = "0", power3 = "0", power4 = "0", power5 = "0", rate = {{"166", "166", "166", "166", "166", "166", "166", }, }, icon = "S109", }
M["10"] = {key = "10", name = "BONUS橙子", power2 = "0", power3 = "25", power4 = "50", power5 = "400", rate = {{"390", "390", "390", "390", "390", "390", "390", }, }, icon = "S110", }
M["11"] = {key = "11", name = "7", power2 = "0", power3 = "100", power4 = "200", power5 = "1750", rate = {{"400", "370", "340", "310", "280", "260", "250", }, }, icon = "S111", }
LuaConfigMgr.SuperFruitConfigLen = 16
LuaConfigMgr.SuperFruitConfig = M