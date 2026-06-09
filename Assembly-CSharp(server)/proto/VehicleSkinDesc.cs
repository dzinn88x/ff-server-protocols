using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D7 RID: 2519
	[Token(Token = "0x20009D7")]
	[ProtoContract]
	public class VehicleSkinDesc
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x24A1448", Offset = "0x24A1448", VA = "0x7BBCCA1448")]
		public VehicleSkinDesc()
		{
		}

		// Token: 0x04002D88 RID: 11656
		[Token(Token = "0x4002D88")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B6FC", Offset = "0x111B6FC")]
		public uint item_id;

		// Token: 0x04002D89 RID: 11657
		[Token(Token = "0x4002D89")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B710", Offset = "0x111B710")]
		public uint vehicle_id;
	}
}
