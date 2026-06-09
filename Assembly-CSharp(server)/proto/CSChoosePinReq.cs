using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	[ProtoContract]
	public class CSChoosePinReq
	{
		// Token: 0x0600247F RID: 9343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x21B0688", Offset = "0x21B0688", VA = "0x7BBC9B0688")]
		public CSChoosePinReq()
		{
		}

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D908", Offset = "0x110D908")]
		public uint pin_id;
	}
}
