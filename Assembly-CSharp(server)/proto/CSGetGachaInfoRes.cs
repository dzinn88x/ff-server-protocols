using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	[ProtoContract]
	public class CSGetGachaInfoRes
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x21B3D6C", Offset = "0x21B3D6C", VA = "0x7BBC9B3D6C")]
		public CSGetGachaInfoRes()
		{
		}

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112750", Offset = "0x1112750")]
		public List<GachaInfo> gacha_info_list;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112764", Offset = "0x1112764")]
		public List<CompletionBackpackInfo> completion_backpack_list;
	}
}
