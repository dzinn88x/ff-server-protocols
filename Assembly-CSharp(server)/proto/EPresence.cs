using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	[ProtoContract]
	public class EPresence
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x21B9B14", Offset = "0x21B9B14", VA = "0x7BBC9B9B14")]
		public EPresence()
		{
		}

		// Token: 0x02000596 RID: 1430
		[Token(Token = "0x2000596")]
		[ProtoContract]
		public enum AccountPresence
		{
			// Token: 0x04001C67 RID: 7271
			[Token(Token = "0x4001C67")]
			AccountPresence_NONE,
			// Token: 0x04001C68 RID: 7272
			[Token(Token = "0x4001C68")]
			AccountPresence_ONLINE,
			// Token: 0x04001C69 RID: 7273
			[Token(Token = "0x4001C69")]
			AccountPresence_INGROUP,
			// Token: 0x04001C6A RID: 7274
			[Token(Token = "0x4001C6A")]
			AccountPresence_INGAME,
			// Token: 0x04001C6B RID: 7275
			[Token(Token = "0x4001C6B")]
			AccountPresence_INROOM,
			// Token: 0x04001C6C RID: 7276
			[Token(Token = "0x4001C6C")]
			AccountPresence_INTRAINING
		}
	}
}
