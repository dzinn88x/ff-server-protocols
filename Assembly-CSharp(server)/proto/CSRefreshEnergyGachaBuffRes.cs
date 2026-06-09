using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AA RID: 2474
	[Token(Token = "0x20009AA")]
	[ProtoContract]
	public class CSRefreshEnergyGachaBuffRes
	{
		// Token: 0x060026B8 RID: 9912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x21B72F0", Offset = "0x21B72F0", VA = "0x7BBC9B72F0")]
		public CSRefreshEnergyGachaBuffRes()
		{
		}

		// Token: 0x04002C97 RID: 11415
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A518", Offset = "0x111A518")]
		public uint buff_display_one;

		// Token: 0x04002C98 RID: 11416
		[Token(Token = "0x4002C98")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A52C", Offset = "0x111A52C")]
		public uint buff_display_ten;
	}
}
