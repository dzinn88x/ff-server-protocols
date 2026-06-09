using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	[ProtoContract]
	public class CSModifyNicknameRes
	{
		// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x21B6A70", Offset = "0x21B6A70", VA = "0x7BBC9B6A70")]
		public CSModifyNicknameRes()
		{
		}

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11098D0", Offset = "0x11098D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11098D0", Offset = "0x11098D0")]
		public string nickname;
	}
}
