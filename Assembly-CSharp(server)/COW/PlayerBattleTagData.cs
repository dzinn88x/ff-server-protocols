using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B2C RID: 6956
	[Token(Token = "0x2001B2C")]
	public class PlayerBattleTagData : PlayerTagDataBase
	{
		// Token: 0x0600950C RID: 38156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950C")]
		[Address(RVA = "0x1EFE16C", Offset = "0x1EFE16C", VA = "0x7BBC6FE16C")]
		public PlayerBattleTagData(PlayerBattleTagData data, int index)
		{
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600950D")]
		[Address(RVA = "0x1EFE2F0", Offset = "0x1EFE2F0", VA = "0x7BBC6FE2F0")]
		public PlayerBattleTagData()
		{
		}

		// Token: 0x04009E61 RID: 40545
		[Token(Token = "0x4009E61")]
		[FieldOffset(Offset = "0x14")]
		public uint SubID;

		// Token: 0x04009E62 RID: 40546
		[Token(Token = "0x4009E62")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x04009E63 RID: 40547
		[Token(Token = "0x4009E63")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;

		// Token: 0x04009E64 RID: 40548
		[Token(Token = "0x4009E64")]
		[FieldOffset(Offset = "0x28")]
		public List<int> CdtValues;

		// Token: 0x04009E65 RID: 40549
		[Token(Token = "0x4009E65")]
		[FieldOffset(Offset = "0x30")]
		public int Count;

		// Token: 0x04009E66 RID: 40550
		[Token(Token = "0x4009E66")]
		[FieldOffset(Offset = "0x34")]
		public bool IsShow;
	}
}
