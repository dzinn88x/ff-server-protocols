using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FBA RID: 8122
	[Token(Token = "0x2001FBA")]
	public class PersonalLiveTvData
	{
		// Token: 0x0600B43B RID: 46139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B43B")]
		[Address(RVA = "0x204E20C", Offset = "0x204E20C", VA = "0x7BBC84E20C")]
		public PersonalLiveTvData()
		{
		}

		// Token: 0x0400B6A0 RID: 46752
		[Token(Token = "0x400B6A0")]
		[FieldOffset(Offset = "0x10")]
		public string nickname;

		// Token: 0x0400B6A1 RID: 46753
		[Token(Token = "0x400B6A1")]
		[FieldOffset(Offset = "0x18")]
		public uint fancnt;

		// Token: 0x0400B6A2 RID: 46754
		[Token(Token = "0x400B6A2")]
		[FieldOffset(Offset = "0x1C")]
		public bool isstreamer;

		// Token: 0x0400B6A3 RID: 46755
		[Token(Token = "0x400B6A3")]
		[FieldOffset(Offset = "0x20")]
		public ELive.FollowerType followtype;

		// Token: 0x0400B6A4 RID: 46756
		[Token(Token = "0x400B6A4")]
		[FieldOffset(Offset = "0x24")]
		public uint headpicid;

		// Token: 0x0400B6A5 RID: 46757
		[Token(Token = "0x400B6A5")]
		[FieldOffset(Offset = "0x28")]
		public EInventory.GenderType sex;
	}
}
