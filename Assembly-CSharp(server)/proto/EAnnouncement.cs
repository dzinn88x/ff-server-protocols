using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	[ProtoContract]
	public class EAnnouncement
	{
		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x21B97C0", Offset = "0x21B97C0", VA = "0x7BBC9B97C0")]
		public EAnnouncement()
		{
		}

		// Token: 0x02000851 RID: 2129
		[Token(Token = "0x2000851")]
		[ProtoContract]
		public enum NavigationType
		{
			// Token: 0x040027CA RID: 10186
			[Token(Token = "0x40027CA")]
			NavigationType_NONE,
			// Token: 0x040027CB RID: 10187
			[Token(Token = "0x40027CB")]
			NavigationType_PROFILE,
			// Token: 0x040027CC RID: 10188
			[Token(Token = "0x40027CC")]
			NavigationType_GROUP,
			// Token: 0x040027CD RID: 10189
			[Token(Token = "0x40027CD")]
			NavigationType_MALL,
			// Token: 0x040027CE RID: 10190
			[Token(Token = "0x40027CE")]
			NavigationType_VAULT,
			// Token: 0x040027CF RID: 10191
			[Token(Token = "0x40027CF")]
			NavigationType_CLAN,
			// Token: 0x040027D0 RID: 10192
			[Token(Token = "0x40027D0")]
			NavigationType_RECHARGE,
			// Token: 0x040027D1 RID: 10193
			[Token(Token = "0x40027D1")]
			NavigationType_ACTIVITY,
			// Token: 0x040027D2 RID: 10194
			[Token(Token = "0x40027D2")]
			NavigationType_FRIENDS,
			// Token: 0x040027D3 RID: 10195
			[Token(Token = "0x40027D3")]
			NavigationType_LOADOUTS,
			// Token: 0x040027D4 RID: 10196
			[Token(Token = "0x40027D4")]
			NavigationType_SETTING,
			// Token: 0x040027D5 RID: 10197
			[Token(Token = "0x40027D5")]
			NavigationType_TUTORIAL,
			// Token: 0x040027D6 RID: 10198
			[Token(Token = "0x40027D6")]
			NavigationType_MONTHCARD,
			// Token: 0x040027D7 RID: 10199
			[Token(Token = "0x40027D7")]
			NavigationType_AVATARPROFILE,
			// Token: 0x040027D8 RID: 10200
			[Token(Token = "0x40027D8")]
			NavigationType_ELITEPASS_MAIN = 114,
			// Token: 0x040027D9 RID: 10201
			[Token(Token = "0x40027D9")]
			NavigationType_ELITEPASS_CHALLENGE = 214,
			// Token: 0x040027DA RID: 10202
			[Token(Token = "0x40027DA")]
			NavigationType_GACHA = 15,
			// Token: 0x040027DB RID: 10203
			[Token(Token = "0x40027DB")]
			NavigationType_INGAME_DROP = 23
		}

		// Token: 0x02000852 RID: 2130
		[Token(Token = "0x2000852")]
		[ProtoContract]
		public enum BroadcastSwitchType
		{
			// Token: 0x040027DD RID: 10205
			[Token(Token = "0x40027DD")]
			BroadcastSwitchType_NONE,
			// Token: 0x040027DE RID: 10206
			[Token(Token = "0x40027DE")]
			BroadcastSwitchType_MAIN,
			// Token: 0x040027DF RID: 10207
			[Token(Token = "0x40027DF")]
			BroadcastSwitchType_SILENCE
		}

		// Token: 0x02000853 RID: 2131
		[Token(Token = "0x2000853")]
		[ProtoContract]
		public enum Platform
		{
			// Token: 0x040027E1 RID: 10209
			[Token(Token = "0x40027E1")]
			Platform_GENERAL,
			// Token: 0x040027E2 RID: 10210
			[Token(Token = "0x40027E2")]
			Platform_IOS,
			// Token: 0x040027E3 RID: 10211
			[Token(Token = "0x40027E3")]
			Platform_GOOGLEPLAY,
			// Token: 0x040027E4 RID: 10212
			[Token(Token = "0x40027E4")]
			Platform_HUAWEI,
			// Token: 0x040027E5 RID: 10213
			[Token(Token = "0x40027E5")]
			Platform_XIAOMI,
			// Token: 0x040027E6 RID: 10214
			[Token(Token = "0x40027E6")]
			Platform_TRIAL
		}

		// Token: 0x02000854 RID: 2132
		[Token(Token = "0x2000854")]
		[ProtoContract]
		public enum Os
		{
			// Token: 0x040027E8 RID: 10216
			[Token(Token = "0x40027E8")]
			Os_DEFAULT,
			// Token: 0x040027E9 RID: 10217
			[Token(Token = "0x40027E9")]
			Os_IOS,
			// Token: 0x040027EA RID: 10218
			[Token(Token = "0x40027EA")]
			Os_ANDROID
		}

		// Token: 0x02000855 RID: 2133
		[Token(Token = "0x2000855")]
		[ProtoContract]
		public enum AndroidChannel
		{
			// Token: 0x040027EC RID: 10220
			[Token(Token = "0x40027EC")]
			AndroidChannel_DEFAULT,
			// Token: 0x040027ED RID: 10221
			[Token(Token = "0x40027ED")]
			AndroidChannel_GOOGLEPLAY,
			// Token: 0x040027EE RID: 10222
			[Token(Token = "0x40027EE")]
			AndroidChannel_HUAWEI,
			// Token: 0x040027EF RID: 10223
			[Token(Token = "0x40027EF")]
			AndroidChannel_XIAOMI,
			// Token: 0x040027F0 RID: 10224
			[Token(Token = "0x40027F0")]
			AndroidChannel_TRIAL
		}

		// Token: 0x02000856 RID: 2134
		[Token(Token = "0x2000856")]
		[ProtoContract]
		public enum PhoneQuality
		{
			// Token: 0x040027F2 RID: 10226
			[Token(Token = "0x40027F2")]
			PhoneQuality_DEFAULT,
			// Token: 0x040027F3 RID: 10227
			[Token(Token = "0x40027F3")]
			PhoneQuality_WHITELIST,
			// Token: 0x040027F4 RID: 10228
			[Token(Token = "0x40027F4")]
			PhoneQuality_HIGH,
			// Token: 0x040027F5 RID: 10229
			[Token(Token = "0x40027F5")]
			PhoneQuality_MID,
			// Token: 0x040027F6 RID: 10230
			[Token(Token = "0x40027F6")]
			PhoneQuality_LOW
		}

		// Token: 0x02000857 RID: 2135
		[Token(Token = "0x2000857")]
		[ProtoContract]
		public enum AboutMax
		{
			// Token: 0x040027F8 RID: 10232
			[Token(Token = "0x40027F8")]
			AboutMax_ALL,
			// Token: 0x040027F9 RID: 10233
			[Token(Token = "0x40027F9")]
			AboutMax_NOTMAX,
			// Token: 0x040027FA RID: 10234
			[Token(Token = "0x40027FA")]
			AboutMax_MAX
		}
	}
}
