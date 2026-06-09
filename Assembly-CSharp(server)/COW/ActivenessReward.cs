using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D3C RID: 7484
	[Token(Token = "0x2001D3C")]
	public class ActivenessReward
	{
		// Token: 0x0600A2B9 RID: 41657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2B9")]
		[Address(RVA = "0x1F9887C", Offset = "0x1F9887C", VA = "0x7BBC79887C")]
		public ActivenessReward(ActivenessRewardDesc desc)
		{
		}

		// Token: 0x0400A94E RID: 43342
		[Token(Token = "0x400A94E")]
		[FieldOffset(Offset = "0x10")]
		public uint group_id;

		// Token: 0x0400A94F RID: 43343
		[Token(Token = "0x400A94F")]
		[FieldOffset(Offset = "0x14")]
		public uint box_id;

		// Token: 0x0400A950 RID: 43344
		[Token(Token = "0x400A950")]
		[FieldOffset(Offset = "0x18")]
		public string box;

		// Token: 0x0400A951 RID: 43345
		[Token(Token = "0x400A951")]
		[FieldOffset(Offset = "0x20")]
		public string box_icon1;

		// Token: 0x0400A952 RID: 43346
		[Token(Token = "0x400A952")]
		[FieldOffset(Offset = "0x28")]
		public string box_icon2;

		// Token: 0x0400A953 RID: 43347
		[Token(Token = "0x400A953")]
		[FieldOffset(Offset = "0x30")]
		public string open_vfx;

		// Token: 0x0400A954 RID: 43348
		[Token(Token = "0x400A954")]
		[FieldOffset(Offset = "0x38")]
		public uint necessary_activeness;

		// Token: 0x0400A955 RID: 43349
		[Token(Token = "0x400A955")]
		[FieldOffset(Offset = "0x40")]
		public List<AwardDesc> awardsList;

		// Token: 0x0400A956 RID: 43350
		[Token(Token = "0x400A956")]
		[FieldOffset(Offset = "0x48")]
		public bool received;
	}
}
