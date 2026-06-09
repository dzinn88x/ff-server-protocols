using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	[ProtoContract]
	public class ETreasureBox
	{
		// Token: 0x06002345 RID: 9029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x21B9B6C", Offset = "0x21B9B6C", VA = "0x7BBC9B9B6C")]
		public ETreasureBox()
		{
		}

		// Token: 0x02000594 RID: 1428
		[Token(Token = "0x2000594")]
		[ProtoContract]
		public enum BoxType
		{
			// Token: 0x04001C61 RID: 7265
			[Token(Token = "0x4001C61")]
			BoxType_NONE,
			// Token: 0x04001C62 RID: 7266
			[Token(Token = "0x4001C62")]
			BoxType_STORE,
			// Token: 0x04001C63 RID: 7267
			[Token(Token = "0x4001C63")]
			BoxType_LOADOUT,
			// Token: 0x04001C64 RID: 7268
			[Token(Token = "0x4001C64")]
			BoxType_CRATE,
			// Token: 0x04001C65 RID: 7269
			[Token(Token = "0x4001C65")]
			BoxType_AUTOOPEN
		}
	}
}
