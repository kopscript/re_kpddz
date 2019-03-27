--钻石排序
--表名: 新手留存红包任务, 字段描述：_key:ID, _icon:图标, _pre_id:开启等级, _post_id:前置任务, _title:后置任务, _achieve_conditicon:任务标题, _achieve_type:数组, _parameter1:活动类型, _parameter2:参数, _parameter3:参数, _item1_id:条件参数, _item1_num:奖励物品1ID, _item2_id:奖励物品1数量, _item2_num:奖励物品2ID, _desc:奖励物品2数量, _skip_id:描述, _diamond_mark:跳转界面ID, _order_mark:钻石任务标识, 
local M = {}
M["560001"] = {key = "560001", icon = "gold1", pre_id = "0", post_id = "560002", title = "[fdf7db]千人红包场累计游戏[cdff47]10[-]局[-]", achieve_conditicon = "4,2,10,10", achieve_type = {{"4", }, }, parameter1 = "2", parameter2 = "10", parameter3 = "10", item1_id = {{"109", }, }, item1_num = "10", item2_id = "0", item2_num = "0", desc = "[fdf7db]千人红包场累计游戏[cdff47]10[-]局[-]", skip_id = "122", diamond_mark = "0", order_mark = "0", }
M["560002"] = {key = "560002", icon = "gold1", pre_id = "560001", post_id = "560003", title = "[fdf7db]任意场对局宝箱累计领取[cdff47]10[-]钻石[-]", achieve_conditicon = "22,0,0,10", achieve_type = {{"22", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "10", item1_id = {{"102", }, }, item1_num = "5", item2_id = "0", item2_num = "0", desc = "[fdf7db]任意场对局宝箱累计领取[cdff47]10[-]钻石[-]", skip_id = "101", diamond_mark = "0", order_mark = "0", }
M["560003"] = {key = "560003", icon = "gold1", pre_id = "560002", post_id = "560004", title = "[fdf7db]任意场游戏赚金[cdff47]50[-]万[-]", achieve_conditicon = "3,0,0,500000", achieve_type = {{"3", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "500000", item1_id = {{"109", }, }, item1_num = "20", item2_id = "0", item2_num = "0", desc = "[fdf7db]任意场游戏赚金[cdff47]50[-]万[-]", skip_id = "101", diamond_mark = "0", order_mark = "0", }
M["560004"] = {key = "560004", icon = "gold1", pre_id = "560003", post_id = "560005", title = "[fdf7db]成功邀请一名好友（好友需在微信成功领取红包）[-]", achieve_conditicon = "21,0,0,1", achieve_type = {{"21", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "1", item1_id = {{"101", }, }, item1_num = "10000", item2_id = "0", item2_num = "0", desc = "[fdf7db]成功邀请一名好友（好友需在微信成功领取红包）[-]", skip_id = "108", diamond_mark = "0", order_mark = "0", }
M["560005"] = {key = "560005", icon = "gold1", pre_id = "560004", post_id = "560006", title = "[fdf7db]分享一次朋友圈[-]", achieve_conditicon = "24,0,0,1", achieve_type = {{"24", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "1", item1_id = {{"101", }, }, item1_num = "10000", item2_id = "0", item2_num = "0", desc = "[fdf7db]分享一次朋友圈[-]", skip_id = "108", diamond_mark = "0", order_mark = "0", }
M["560006"] = {key = "560006", icon = "gold2", pre_id = "560005", post_id = "560007", title = "[fdf7db]成功邀请两名好友（好友需在微信成功领取红包）[-]", achieve_conditicon = "21,0,0,2", achieve_type = {{"21", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "2", item1_id = {{"101", }, }, item1_num = "30000", item2_id = "0", item2_num = "0", desc = "[fdf7db]成功邀请两名好友（好友需在微信成功领取红包）[-]", skip_id = "108", diamond_mark = "0", order_mark = "0", }
M["560007"] = {key = "560007", icon = "gold3", pre_id = "560006", post_id = "0", title = "[fdf7db]任意场游戏赚金[cdff47]300[-]万[-]", achieve_conditicon = "3,0,0,3000000", achieve_type = {{"3", }, }, parameter1 = "0", parameter2 = "0", parameter3 = "3000000", item1_id = {{"109", }, }, item1_num = "100", item2_id = "0", item2_num = "0", desc = "[fdf7db]任意场游戏赚金[cdff47]300[-]万[-]", skip_id = "101", diamond_mark = "0", order_mark = "0", }
LuaConfigMgr.LoginDaytaskConfigLen = 58
LuaConfigMgr.LoginDaytaskConfig = M