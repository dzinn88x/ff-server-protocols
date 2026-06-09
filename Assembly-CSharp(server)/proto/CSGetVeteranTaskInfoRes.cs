using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	[ProtoContract]
	public class CSGetVeteranTaskInfoRes
	{
		// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x21B620C", Offset = "0x21B620C", VA = "0x7BBC9B620C")]
		public CSGetVeteranTaskInfoRes()
		{
		}

		// Token: 0x04002BB4 RID: 11188
		[Token(Token = "0x4002BB4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119050", Offset = "0x1119050")]
		public List<VeteranTaskInfo> tasks;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119064", Offset = "0x1119064")]
		public EAttendance.VeteranTaskBigPrize big_prize_state;
	}
}
