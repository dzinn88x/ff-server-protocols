using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	[ProtoContract]
	public class EActivity
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x21B97B8", Offset = "0x21B97B8", VA = "0x7BBC9B97B8")]
		public EActivity()
		{
		}

		// Token: 0x02000586 RID: 1414
		[Token(Token = "0x2000586")]
		[ProtoContract]
		public enum Event
		{
			// Token: 0x04001B93 RID: 7059
			[Token(Token = "0x4001B93")]
			Event_NONE,
			// Token: 0x04001B94 RID: 7060
			[Token(Token = "0x4001B94")]
			Event_ENDMATCH,
			// Token: 0x04001B95 RID: 7061
			[Token(Token = "0x4001B95")]
			Event_LOGIN,
			// Token: 0x04001B96 RID: 7062
			[Token(Token = "0x4001B96")]
			Event_RECHARGE,
			// Token: 0x04001B97 RID: 7063
			[Token(Token = "0x4001B97")]
			Event_EXCHANGE,
			// Token: 0x04001B98 RID: 7064
			[Token(Token = "0x4001B98")]
			Event_SHARE,
			// Token: 0x04001B99 RID: 7065
			[Token(Token = "0x4001B99")]
			Event_BIND,
			// Token: 0x04001B9A RID: 7066
			[Token(Token = "0x4001B9A")]
			Event_EP,
			// Token: 0x04001B9B RID: 7067
			[Token(Token = "0x4001B9B")]
			Event_LEVEL_UP,
			// Token: 0x04001B9C RID: 7068
			[Token(Token = "0x4001B9C")]
			Event_GEM_CONSUMPTION,
			// Token: 0x04001B9D RID: 7069
			[Token(Token = "0x4001B9D")]
			Event_SEND_GIFT,
			// Token: 0x04001B9E RID: 7070
			[Token(Token = "0x4001B9E")]
			Event_RETURNER,
			// Token: 0x04001B9F RID: 7071
			[Token(Token = "0x4001B9F")]
			Event_RETURN_INVITER,
			// Token: 0x04001BA0 RID: 7072
			[Token(Token = "0x4001BA0")]
			Event_OPTIONAL_HOTFIX,
			// Token: 0x04001BA1 RID: 7073
			[Token(Token = "0x4001BA1")]
			Event_REBATE_CARD,
			// Token: 0x04001BA2 RID: 7074
			[Token(Token = "0x4001BA2")]
			Event_WATCH_AD,
			// Token: 0x04001BA3 RID: 7075
			[Token(Token = "0x4001BA3")]
			Event_CHECK_CLAN,
			// Token: 0x04001BA4 RID: 7076
			[Token(Token = "0x4001BA4")]
			Event_PRELOGIN,
			// Token: 0x04001BA5 RID: 7077
			[Token(Token = "0x4001BA5")]
			Event_GAIN_BADGE,
			// Token: 0x04001BA6 RID: 7078
			[Token(Token = "0x4001BA6")]
			Event_GOOGLE_ENGAGEMENT_REWARDS,
			// Token: 0x04001BA7 RID: 7079
			[Token(Token = "0x4001BA7")]
			Event_WATCH_AD_AFTER_MATCH,
			// Token: 0x04001BA8 RID: 7080
			[Token(Token = "0x4001BA8")]
			Event_LOTTERY,
			// Token: 0x04001BA9 RID: 7081
			[Token(Token = "0x4001BA9")]
			Event_AVATAR_LEVEL_UP,
			// Token: 0x04001BAA RID: 7082
			[Token(Token = "0x4001BAA")]
			Event_UNLOCKED_SKILL_SLOT,
			// Token: 0x04001BAB RID: 7083
			[Token(Token = "0x4001BAB")]
			Event_EQUIP_CLOTHES,
			// Token: 0x04001BAC RID: 7084
			[Token(Token = "0x4001BAC")]
			Event_EQUIP_COLLECTION,
			// Token: 0x04001BAD RID: 7085
			[Token(Token = "0x4001BAD")]
			Event_OPTIONAL_HOTFIX_VOICE,
			// Token: 0x04001BAE RID: 7086
			[Token(Token = "0x4001BAE")]
			Event_OPTIONAL_MAP,
			// Token: 0x04001BAF RID: 7087
			[Token(Token = "0x4001BAF")]
			Event_LIMITED_EVENT_STORE_PURCHASE,
			// Token: 0x04001BB0 RID: 7088
			[Token(Token = "0x4001BB0")]
			Event_ATTENDANCE_SIGNIN,
			// Token: 0x04001BB1 RID: 7089
			[Token(Token = "0x4001BB1")]
			Event_OPTIONAL_MAP_BERMUDA
		}

		// Token: 0x02000587 RID: 1415
		[Token(Token = "0x2000587")]
		[ProtoContract]
		public enum PreConditionType
		{
			// Token: 0x04001BB3 RID: 7091
			[Token(Token = "0x4001BB3")]
			PreConditionType_NONE,
			// Token: 0x04001BB4 RID: 7092
			[Token(Token = "0x4001BB4")]
			PreConditionType_GROUPMODE,
			// Token: 0x04001BB5 RID: 7093
			[Token(Token = "0x4001BB5")]
			PreConditionType_RANK,
			// Token: 0x04001BB6 RID: 7094
			[Token(Token = "0x4001BB6")]
			PreConditionType_MATCHMODE,
			// Token: 0x04001BB7 RID: 7095
			[Token(Token = "0x4001BB7")]
			PreConditionType_GAMEMODE,
			// Token: 0x04001BB8 RID: 7096
			[Token(Token = "0x4001BB8")]
			PreConditionType_MAPID,
			// Token: 0x04001BB9 RID: 7097
			[Token(Token = "0x4001BB9")]
			PreConditionType_AVATAR,
			// Token: 0x04001BBA RID: 7098
			[Token(Token = "0x4001BBA")]
			PreConditionType_CLOTHESID,
			// Token: 0x04001BBB RID: 7099
			[Token(Token = "0x4001BBB")]
			PreConditionType_REBATECARDID,
			// Token: 0x04001BBC RID: 7100
			[Token(Token = "0x4001BBC")]
			PreConditionType_Client_Version,
			// Token: 0x04001BBD RID: 7101
			[Token(Token = "0x4001BBD")]
			PreConditionType_LOADOUT,
			// Token: 0x04001BBE RID: 7102
			[Token(Token = "0x4001BBE")]
			PreConditionType_LOTTERY_TYPE,
			// Token: 0x04001BBF RID: 7103
			[Token(Token = "0x4001BBF")]
			PreConditionType_WP_TYPE_PICK_UP,
			// Token: 0x04001BC0 RID: 7104
			[Token(Token = "0x4001BC0")]
			PreConditionType_LOCATION_KILL,
			// Token: 0x04001BC1 RID: 7105
			[Token(Token = "0x4001BC1")]
			PreConditionType_CERTAIN_WP_KILL,
			// Token: 0x04001BC2 RID: 7106
			[Token(Token = "0x4001BC2")]
			PreConditionType_LIMITED_EVENT_RAMPAGE,
			// Token: 0x04001BC3 RID: 7107
			[Token(Token = "0x4001BC3")]
			PreConditionType_MATCHSTATS_ITEM_ID,
			// Token: 0x04001BC4 RID: 7108
			[Token(Token = "0x4001BC4")]
			PreConditionType_KILLS,
			// Token: 0x04001BC5 RID: 7109
			[Token(Token = "0x4001BC5")]
			PreConditionType_SINGLE_GAME_SURVIVAL,
			// Token: 0x04001BC6 RID: 7110
			[Token(Token = "0x4001BC6")]
			PreConditionType_BRING_PET,
			// Token: 0x04001BC7 RID: 7111
			[Token(Token = "0x4001BC7")]
			PreConditionType_SINGLE_GAME_RESTORE,
			// Token: 0x04001BC8 RID: 7112
			[Token(Token = "0x4001BC8")]
			PreConditionType_SINGLE_GAME_BE_RESTORED
		}

		// Token: 0x02000588 RID: 1416
		[Token(Token = "0x2000588")]
		[ProtoContract]
		public enum ConditionType
		{
			// Token: 0x04001BCA RID: 7114
			[Token(Token = "0x4001BCA")]
			ConditionType_NONE,
			// Token: 0x04001BCB RID: 7115
			[Token(Token = "0x4001BCB")]
			ConditionType_PLAY,
			// Token: 0x04001BCC RID: 7116
			[Token(Token = "0x4001BCC")]
			ConditionType_KILL,
			// Token: 0x04001BCD RID: 7117
			[Token(Token = "0x4001BCD")]
			ConditionType_ONLINEMINITES,
			// Token: 0x04001BCE RID: 7118
			[Token(Token = "0x4001BCE")]
			ConditionType_GAMEMINITES,
			// Token: 0x04001BCF RID: 7119
			[Token(Token = "0x4001BCF")]
			ConditionType_ANYDAYLOGIN,
			// Token: 0x04001BD0 RID: 7120
			[Token(Token = "0x4001BD0")]
			ConditionType_RECHARGECUMU,
			// Token: 0x04001BD1 RID: 7121
			[Token(Token = "0x4001BD1")]
			ConditionType_EXCHANGE,
			// Token: 0x04001BD2 RID: 7122
			[Token(Token = "0x4001BD2")]
			ConditionType_SHARECUMU,
			// Token: 0x04001BD3 RID: 7123
			[Token(Token = "0x4001BD3")]
			ConditionType_BIND,
			// Token: 0x04001BD4 RID: 7124
			[Token(Token = "0x4001BD4")]
			ConditionType_EP,
			// Token: 0x04001BD5 RID: 7125
			[Token(Token = "0x4001BD5")]
			ConditionType_LEVEL_UP,
			// Token: 0x04001BD6 RID: 7126
			[Token(Token = "0x4001BD6")]
			ConditionType_SEND_GIFT,
			// Token: 0x04001BD7 RID: 7127
			[Token(Token = "0x4001BD7")]
			ConditionType_GROUP_WITH_FRIEND = 14,
			// Token: 0x04001BD8 RID: 7128
			[Token(Token = "0x4001BD8")]
			ConditionType_GEMSCONSUMECUMU,
			// Token: 0x04001BD9 RID: 7129
			[Token(Token = "0x4001BD9")]
			ConditionType_RETURNER,
			// Token: 0x04001BDA RID: 7130
			[Token(Token = "0x4001BDA")]
			ConditionType_RETURN_INVITER,
			// Token: 0x04001BDB RID: 7131
			[Token(Token = "0x4001BDB")]
			ConditionType_OPTIONAL_HOTFIX,
			// Token: 0x04001BDC RID: 7132
			[Token(Token = "0x4001BDC")]
			ConditionType_REBATE_CARD,
			// Token: 0x04001BDD RID: 7133
			[Token(Token = "0x4001BDD")]
			ConditionType_CHECK_CLAN = 21,
			// Token: 0x04001BDE RID: 7134
			[Token(Token = "0x4001BDE")]
			ConditionType_WATCH_AD,
			// Token: 0x04001BDF RID: 7135
			[Token(Token = "0x4001BDF")]
			ConditionType_PRELOGIN,
			// Token: 0x04001BE0 RID: 7136
			[Token(Token = "0x4001BE0")]
			ConditionType_GAIN_BADGE,
			// Token: 0x04001BE1 RID: 7137
			[Token(Token = "0x4001BE1")]
			ConditionType_SIT_ON_THRONE,
			// Token: 0x04001BE2 RID: 7138
			[Token(Token = "0x4001BE2")]
			ConditionType_GOOGLE_ENGAGEMENT_REWARDS,
			// Token: 0x04001BE3 RID: 7139
			[Token(Token = "0x4001BE3")]
			ConditionType_GROUP_WITH_CLAN_MEMBER,
			// Token: 0x04001BE4 RID: 7140
			[Token(Token = "0x4001BE4")]
			ConditionType_WATCH_AD_AFTER_MATCH,
			// Token: 0x04001BE5 RID: 7141
			[Token(Token = "0x4001BE5")]
			ConditionType_LOTTERY_CNT,
			// Token: 0x04001BE6 RID: 7142
			[Token(Token = "0x4001BE6")]
			ConditionType_WIN,
			// Token: 0x04001BE7 RID: 7143
			[Token(Token = "0x4001BE7")]
			ConditionType_REVIVAL,
			// Token: 0x04001BE8 RID: 7144
			[Token(Token = "0x4001BE8")]
			ConditionType_RANKING_LEVEL_UP,
			// Token: 0x04001BE9 RID: 7145
			[Token(Token = "0x4001BE9")]
			ConditionType_LOADOUT,
			// Token: 0x04001BEA RID: 7146
			[Token(Token = "0x4001BEA")]
			ConditionType_AVATAR_LEVEL_UP,
			// Token: 0x04001BEB RID: 7147
			[Token(Token = "0x4001BEB")]
			ConditionType_UNLOCKED_SKILL_SLOT,
			// Token: 0x04001BEC RID: 7148
			[Token(Token = "0x4001BEC")]
			ConditionType_EQUIP_CLOTHES,
			// Token: 0x04001BED RID: 7149
			[Token(Token = "0x4001BED")]
			ConditionType_EQUIP_COLLECTION,
			// Token: 0x04001BEE RID: 7150
			[Token(Token = "0x4001BEE")]
			ConditionType_EP_CHALLENGE,
			// Token: 0x04001BEF RID: 7151
			[Token(Token = "0x4001BEF")]
			ConditionType_OPTIONAL_HOTFIX_VOICE,
			// Token: 0x04001BF0 RID: 7152
			[Token(Token = "0x4001BF0")]
			ConditionType_EMOTE_USE,
			// Token: 0x04001BF1 RID: 7153
			[Token(Token = "0x4001BF1")]
			ConditionType_LOADOUT_USE,
			// Token: 0x04001BF2 RID: 7154
			[Token(Token = "0x4001BF2")]
			ConditionType_TEAMMATE_SAVE,
			// Token: 0x04001BF3 RID: 7155
			[Token(Token = "0x4001BF3")]
			ConditionType_VEHICLE_DESTROY,
			// Token: 0x04001BF4 RID: 7156
			[Token(Token = "0x4001BF4")]
			ConditionType_DAMAGE_IN_MATCH,
			// Token: 0x04001BF5 RID: 7157
			[Token(Token = "0x4001BF5")]
			ConditionType_MOVING_DISTANCE,
			// Token: 0x04001BF6 RID: 7158
			[Token(Token = "0x4001BF6")]
			ConditionType_PAINT_USE,
			// Token: 0x04001BF7 RID: 7159
			[Token(Token = "0x4001BF7")]
			ConditionType_DIFF_WP_USE,
			// Token: 0x04001BF8 RID: 7160
			[Token(Token = "0x4001BF8")]
			ConditionType_MEET_CERTAIN_RANK,
			// Token: 0x04001BF9 RID: 7161
			[Token(Token = "0x4001BF9")]
			ConditionType_OPTIONAL_MAP,
			// Token: 0x04001BFA RID: 7162
			[Token(Token = "0x4001BFA")]
			ConditionType_LIMITED_EVENT_STORE_PURCHASE,
			// Token: 0x04001BFB RID: 7163
			[Token(Token = "0x4001BFB")]
			ConditionType_ATTENDANCE_SIGNIN,
			// Token: 0x04001BFC RID: 7164
			[Token(Token = "0x4001BFC")]
			ConditionType_MATCHSTATS_ITEM_NUM,
			// Token: 0x04001BFD RID: 7165
			[Token(Token = "0x4001BFD")]
			ConditionType_HEADSHOT,
			// Token: 0x04001BFE RID: 7166
			[Token(Token = "0x4001BFE")]
			ConditionType_CERTAIN_WP_KILLS,
			// Token: 0x04001BFF RID: 7167
			[Token(Token = "0x4001BFF")]
			ConditionType_OPTIONAL_MAP_BERMUDA,
			// Token: 0x04001C00 RID: 7168
			[Token(Token = "0x4001C00")]
			ConditionType_RESTORE = 57,
			// Token: 0x04001C01 RID: 7169
			[Token(Token = "0x4001C01")]
			ConditionType_BE_RESTORED
		}

		// Token: 0x02000589 RID: 1417
		[Token(Token = "0x2000589")]
		[ProtoContract]
		public enum CircleType
		{
			// Token: 0x04001C03 RID: 7171
			[Token(Token = "0x4001C03")]
			CircleType_NONE,
			// Token: 0x04001C04 RID: 7172
			[Token(Token = "0x4001C04")]
			CircleType_DAILY,
			// Token: 0x04001C05 RID: 7173
			[Token(Token = "0x4001C05")]
			CircleType_WEEKLY,
			// Token: 0x04001C06 RID: 7174
			[Token(Token = "0x4001C06")]
			CircleType_MONTHLY,
			// Token: 0x04001C07 RID: 7175
			[Token(Token = "0x4001C07")]
			CircleType_REPEAT
		}

		// Token: 0x0200058A RID: 1418
		[Token(Token = "0x200058A")]
		[ProtoContract]
		public enum State
		{
			// Token: 0x04001C09 RID: 7177
			[Token(Token = "0x4001C09")]
			State_RECEIVED,
			// Token: 0x04001C0A RID: 7178
			[Token(Token = "0x4001C0A")]
			State_FINISHED,
			// Token: 0x04001C0B RID: 7179
			[Token(Token = "0x4001C0B")]
			State_AWARDED,
			// Token: 0x04001C0C RID: 7180
			[Token(Token = "0x4001C0C")]
			State_UNRECEIVED
		}

		// Token: 0x0200058B RID: 1419
		[Token(Token = "0x200058B")]
		[ProtoContract]
		public enum ActivityType
		{
			// Token: 0x04001C0E RID: 7182
			[Token(Token = "0x4001C0E")]
			ActivityType_NORMAL,
			// Token: 0x04001C0F RID: 7183
			[Token(Token = "0x4001C0F")]
			ActivityType_FIRSTRECHARGE,
			// Token: 0x04001C10 RID: 7184
			[Token(Token = "0x4001C10")]
			ActivityType_EXCHANGE,
			// Token: 0x04001C11 RID: 7185
			[Token(Token = "0x4001C11")]
			ActivityType_SHARE,
			// Token: 0x04001C12 RID: 7186
			[Token(Token = "0x4001C12")]
			ActivityType_BIND,
			// Token: 0x04001C13 RID: 7187
			[Token(Token = "0x4001C13")]
			ActivityType_FESTIVAL,
			// Token: 0x04001C14 RID: 7188
			[Token(Token = "0x4001C14")]
			ActivityType_RETURNER,
			// Token: 0x04001C15 RID: 7189
			[Token(Token = "0x4001C15")]
			ActivityType_RETURN_INVITER,
			// Token: 0x04001C16 RID: 7190
			[Token(Token = "0x4001C16")]
			ActivityType_WATCH_AD,
			// Token: 0x04001C17 RID: 7191
			[Token(Token = "0x4001C17")]
			ActivityType_OPTIONAL_HOTFIX,
			// Token: 0x04001C18 RID: 7192
			[Token(Token = "0x4001C18")]
			ActivityType_CDN_SHOW,
			// Token: 0x04001C19 RID: 7193
			[Token(Token = "0x4001C19")]
			ActivityType_ANNOUNCE_SHOW,
			// Token: 0x04001C1A RID: 7194
			[Token(Token = "0x4001C1A")]
			ActivityType_PRELOGIN,
			// Token: 0x04001C1B RID: 7195
			[Token(Token = "0x4001C1B")]
			ActivityType_LIMITED_TIME_RECHARGE,
			// Token: 0x04001C1C RID: 7196
			[Token(Token = "0x4001C1C")]
			ActivityType_MONTHLY_RECHARGE,
			// Token: 0x04001C1D RID: 7197
			[Token(Token = "0x4001C1D")]
			ActivityType_MONTHLY_REBATE,
			// Token: 0x04001C1E RID: 7198
			[Token(Token = "0x4001C1E")]
			ActivityType_WEEKLY_REBATE,
			// Token: 0x04001C1F RID: 7199
			[Token(Token = "0x4001C1F")]
			ActivityType_GOOGLE_ENGAGEMENT_REWARDS,
			// Token: 0x04001C20 RID: 7200
			[Token(Token = "0x4001C20")]
			ActivityType_WATCH_AD_AFTER_MATCH,
			// Token: 0x04001C21 RID: 7201
			[Token(Token = "0x4001C21")]
			ActivityType_SECOND_RECHARGE,
			// Token: 0x04001C22 RID: 7202
			[Token(Token = "0x4001C22")]
			ActivityType_OVERVIEW,
			// Token: 0x04001C23 RID: 7203
			[Token(Token = "0x4001C23")]
			ActivityType_NAVIGATION,
			// Token: 0x04001C24 RID: 7204
			[Token(Token = "0x4001C24")]
			ActivityType_ACTIVENESS,
			// Token: 0x04001C25 RID: 7205
			[Token(Token = "0x4001C25")]
			ActivityType_OPTIONAL_HOTFIX_VOICE,
			// Token: 0x04001C26 RID: 7206
			[Token(Token = "0x4001C26")]
			ActivityType_OPTIONAL_MAP,
			// Token: 0x04001C27 RID: 7207
			[Token(Token = "0x4001C27")]
			ActivityType_EASTER,
			// Token: 0x04001C28 RID: 7208
			[Token(Token = "0x4001C28")]
			ActivityType_LIMITED_EVENT1,
			// Token: 0x04001C29 RID: 7209
			[Token(Token = "0x4001C29")]
			ActivityType_LIMITED_EVENT2,
			// Token: 0x04001C2A RID: 7210
			[Token(Token = "0x4001C2A")]
			ActivityType_LIMITED_EVENT3,
			// Token: 0x04001C2B RID: 7211
			[Token(Token = "0x4001C2B")]
			ActivityType_LIMITED_EVENT4,
			// Token: 0x04001C2C RID: 7212
			[Token(Token = "0x4001C2C")]
			ActivityType_LIMITED_EVENT5,
			// Token: 0x04001C2D RID: 7213
			[Token(Token = "0x4001C2D")]
			ActivityType_OPTIONAL_MAP_BERMUDA,
			// Token: 0x04001C2E RID: 7214
			[Token(Token = "0x4001C2E")]
			ActivityType_LIMITED_EVENT_BOOYAH,
			// Token: 0x04001C2F RID: 7215
			[Token(Token = "0x4001C2F")]
			ActivityType_LIMITED_EVENT_BOUNTY,
			// Token: 0x04001C30 RID: 7216
			[Token(Token = "0x4001C30")]
			ActivityType_LIMITED_EVENT_MEGAPUNCH,
			// Token: 0x04001C31 RID: 7217
			[Token(Token = "0x4001C31")]
			ActivityType_CDN_SCROLLVIEW_SHOW,
			// Token: 0x04001C32 RID: 7218
			[Token(Token = "0x4001C32")]
			ActivityType_LIMITED_EVENT_BERMUDA = 1000,
			// Token: 0x04001C33 RID: 7219
			[Token(Token = "0x4001C33")]
			ActivityType_PICKONEFROMN,
			// Token: 0x04001C34 RID: 7220
			[Token(Token = "0x4001C34")]
			ActivityType_LIMITED_EVENT_PEAKDAY,
			// Token: 0x04001C35 RID: 7221
			[Token(Token = "0x4001C35")]
			ActivityType_LIMITED_EVENT_SIGNIN,
			// Token: 0x04001C36 RID: 7222
			[Token(Token = "0x4001C36")]
			ActivityType_LIMITED_EVENT_DAILY,
			// Token: 0x04001C37 RID: 7223
			[Token(Token = "0x4001C37")]
			ActivityType_PASSIVE = 2000
		}

		// Token: 0x0200058C RID: 1420
		[Token(Token = "0x200058C")]
		[ProtoContract]
		public enum SubType
		{
			// Token: 0x04001C39 RID: 7225
			[Token(Token = "0x4001C39")]
			SubType_NONE,
			// Token: 0x04001C3A RID: 7226
			[Token(Token = "0x4001C3A")]
			SubType_LIMITED_EVENT_GOLIATH = 1000,
			// Token: 0x04001C3B RID: 7227
			[Token(Token = "0x4001C3B")]
			SubType_MINIGAME_MONOPOLY,
			// Token: 0x04001C3C RID: 7228
			[Token(Token = "0x4001C3C")]
			SubType_LIMITED_EVENT_MVP,
			// Token: 0x04001C3D RID: 7229
			[Token(Token = "0x4001C3D")]
			SubType_LIMITED_EVENT_FFWS,
			// Token: 0x04001C3E RID: 7230
			[Token(Token = "0x4001C3E")]
			SubType_LIMITED_EVENT_SUPERFIGHTER,
			// Token: 0x04001C3F RID: 7231
			[Token(Token = "0x4001C3F")]
			SubType_LIMITED_EVENT_SUPERCAR
		}

		// Token: 0x0200058D RID: 1421
		[Token(Token = "0x200058D")]
		[ProtoContract]
		public enum TabType
		{
			// Token: 0x04001C41 RID: 7233
			[Token(Token = "0x4001C41")]
			TabType_NONE,
			// Token: 0x04001C42 RID: 7234
			[Token(Token = "0x4001C42")]
			TabType_NORMAL,
			// Token: 0x04001C43 RID: 7235
			[Token(Token = "0x4001C43")]
			TabType_FESTIVAL1,
			// Token: 0x04001C44 RID: 7236
			[Token(Token = "0x4001C44")]
			TabType_FESTIVAL2,
			// Token: 0x04001C45 RID: 7237
			[Token(Token = "0x4001C45")]
			TabType_GW1,
			// Token: 0x04001C46 RID: 7238
			[Token(Token = "0x4001C46")]
			TabType_GW2,
			// Token: 0x04001C47 RID: 7239
			[Token(Token = "0x4001C47")]
			TabType_LARGE_FESTIVAL,
			// Token: 0x04001C48 RID: 7240
			[Token(Token = "0x4001C48")]
			TabType_ACTIVENESS
		}

		// Token: 0x0200058E RID: 1422
		[Token(Token = "0x200058E")]
		[ProtoContract]
		public enum Operation
		{
			// Token: 0x04001C4A RID: 7242
			[Token(Token = "0x4001C4A")]
			Operation_NONE,
			// Token: 0x04001C4B RID: 7243
			[Token(Token = "0x4001C4B")]
			Operation_RECEIVE,
			// Token: 0x04001C4C RID: 7244
			[Token(Token = "0x4001C4C")]
			Operation_CANCEL
		}

		// Token: 0x0200058F RID: 1423
		[Token(Token = "0x200058F")]
		[ProtoContract]
		public enum BingoActivityRewardsState
		{
			// Token: 0x04001C4E RID: 7246
			[Token(Token = "0x4001C4E")]
			BingoActivityRewardsState_INIT,
			// Token: 0x04001C4F RID: 7247
			[Token(Token = "0x4001C4F")]
			BingoActivityRewardsState_AWARDED
		}

		// Token: 0x02000590 RID: 1424
		[Token(Token = "0x2000590")]
		[ProtoContract]
		public enum BingoActivityLevel
		{
			// Token: 0x04001C51 RID: 7249
			[Token(Token = "0x4001C51")]
			BingoActivityLevel_NONE,
			// Token: 0x04001C52 RID: 7250
			[Token(Token = "0x4001C52")]
			BingoActivityLevel_LOW,
			// Token: 0x04001C53 RID: 7251
			[Token(Token = "0x4001C53")]
			BingoActivityState_MEDIUM,
			// Token: 0x04001C54 RID: 7252
			[Token(Token = "0x4001C54")]
			BingoActivityState_HIGH
		}

		// Token: 0x02000591 RID: 1425
		[Token(Token = "0x2000591")]
		[ProtoContract]
		public enum EventMissionType
		{
			// Token: 0x04001C56 RID: 7254
			[Token(Token = "0x4001C56")]
			EventMissionType_NONE,
			// Token: 0x04001C57 RID: 7255
			[Token(Token = "0x4001C57")]
			EventMissionType_ACT_LOTTERY,
			// Token: 0x04001C58 RID: 7256
			[Token(Token = "0x4001C58")]
			EventMissionType_GAME_MODE
		}

		// Token: 0x02000592 RID: 1426
		[Token(Token = "0x2000592")]
		[ProtoContract]
		public enum Platform
		{
			// Token: 0x04001C5A RID: 7258
			[Token(Token = "0x4001C5A")]
			Platform_NONE,
			// Token: 0x04001C5B RID: 7259
			[Token(Token = "0x4001C5B")]
			Platform_GP,
			// Token: 0x04001C5C RID: 7260
			[Token(Token = "0x4001C5C")]
			Platform_IOS,
			// Token: 0x04001C5D RID: 7261
			[Token(Token = "0x4001C5D")]
			Platform_HUAWEI,
			// Token: 0x04001C5E RID: 7262
			[Token(Token = "0x4001C5E")]
			Platform_XIAOMI,
			// Token: 0x04001C5F RID: 7263
			[Token(Token = "0x4001C5F")]
			Platform_MAX
		}
	}
}
