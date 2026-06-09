using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000944 RID: 2372
	[Token(Token = "0x2000944")]
	[ProtoContract]
	public class CSGetVeteranTaskDescRes
	{
		// Token: 0x06002652 RID: 9810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x21B6198", Offset = "0x21B6198", VA = "0x7BBC9B6198")]
		public CSGetVeteranTaskDescRes()
		{
		}

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118FD8", Offset = "0x1118FD8")]
		public List<ClientVeteranTaskDesc> task_descs;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118FEC", Offset = "0x1118FEC")]
		public VeteranBigPrizeDesc big_prize;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119000", Offset = "0x1119000")]
		public ulong veteran_expire_time;
	}
}
