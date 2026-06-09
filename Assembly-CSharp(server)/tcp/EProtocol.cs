using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	[ProtoContract]
	public class EProtocol
	{
		// Token: 0x06002188 RID: 8584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x24A2DA0", Offset = "0x24A2DA0", VA = "0x7BBCCA2DA0")]
		public EProtocol()
		{
		}

		// Token: 0x0200052F RID: 1327
		[Token(Token = "0x200052F")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040018D4 RID: 6356
			[Token(Token = "0x40018D4")]
			Proto_NONE,
			// Token: 0x040018D5 RID: 6357
			[Token(Token = "0x40018D5")]
			INIT,
			// Token: 0x040018D6 RID: 6358
			[Token(Token = "0x40018D6")]
			HEARTBEAT,
			// Token: 0x040018D7 RID: 6359
			[Token(Token = "0x40018D7")]
			MATCHMAKING,
			// Token: 0x040018D8 RID: 6360
			[Token(Token = "0x40018D8")]
			STATS,
			// Token: 0x040018D9 RID: 6361
			[Token(Token = "0x40018D9")]
			GROUP,
			// Token: 0x040018DA RID: 6362
			[Token(Token = "0x40018DA")]
			FRIEND,
			// Token: 0x040018DB RID: 6363
			[Token(Token = "0x40018DB")]
			MAIL,
			// Token: 0x040018DC RID: 6364
			[Token(Token = "0x40018DC")]
			INVENTORY,
			// Token: 0x040018DD RID: 6365
			[Token(Token = "0x40018DD")]
			BACKPACK,
			// Token: 0x040018DE RID: 6366
			[Token(Token = "0x40018DE")]
			ACTIVITY,
			// Token: 0x040018DF RID: 6367
			[Token(Token = "0x40018DF")]
			ACCOUNT,
			// Token: 0x040018E0 RID: 6368
			[Token(Token = "0x40018E0")]
			CLAN,
			// Token: 0x040018E1 RID: 6369
			[Token(Token = "0x40018E1")]
			PROFILE,
			// Token: 0x040018E2 RID: 6370
			[Token(Token = "0x40018E2")]
			ROOM,
			// Token: 0x040018E3 RID: 6371
			[Token(Token = "0x40018E3")]
			PRESENCE,
			// Token: 0x040018E4 RID: 6372
			[Token(Token = "0x40018E4")]
			ELITEPASS,
			// Token: 0x040018E5 RID: 6373
			[Token(Token = "0x40018E5")]
			RECONNECTION,
			// Token: 0x040018E6 RID: 6374
			[Token(Token = "0x40018E6")]
			CHANNEL,
			// Token: 0x040018E7 RID: 6375
			[Token(Token = "0x40018E7")]
			STORE,
			// Token: 0x040018E8 RID: 6376
			[Token(Token = "0x40018E8")]
			PET = 21,
			// Token: 0x040018E9 RID: 6377
			[Token(Token = "0x40018E9")]
			MANUAL,
			// Token: 0x040018EA RID: 6378
			[Token(Token = "0x40018EA")]
			CHAMPIONSHIP,
			// Token: 0x040018EB RID: 6379
			[Token(Token = "0x40018EB")]
			ANTIADDICTION,
			// Token: 0x040018EC RID: 6380
			[Token(Token = "0x40018EC")]
			FRESH,
			// Token: 0x040018ED RID: 6381
			[Token(Token = "0x40018ED")]
			LINKAGE,
			// Token: 0x040018EE RID: 6382
			[Token(Token = "0x40018EE")]
			ATTENDANCE,
			// Token: 0x040018EF RID: 6383
			[Token(Token = "0x40018EF")]
			LIMITEDEVENT,
			// Token: 0x040018F0 RID: 6384
			[Token(Token = "0x40018F0")]
			MTP,
			// Token: 0x040018F1 RID: 6385
			[Token(Token = "0x40018F1")]
			CHAT
		}

		// Token: 0x02000530 RID: 1328
		[Token(Token = "0x2000530")]
		[ProtoContract]
		public enum ProtoSize
		{
			// Token: 0x040018F3 RID: 6387
			[Token(Token = "0x40018F3")]
			ProtoSize_NONE,
			// Token: 0x040018F4 RID: 6388
			[Token(Token = "0x40018F4")]
			MAXPACKETSIZE = 20480,
			// Token: 0x040018F5 RID: 6389
			[Token(Token = "0x40018F5")]
			MAXMTPPACKETSIZE = 10240
		}
	}
}
