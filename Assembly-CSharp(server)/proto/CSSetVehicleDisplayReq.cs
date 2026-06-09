using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	[ProtoContract]
	public class CSSetVehicleDisplayReq
	{
		// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A5")]
		[Address(RVA = "0x21B7684", Offset = "0x21B7684", VA = "0x7BBC9B7684")]
		public CSSetVehicleDisplayReq()
		{
		}

		// Token: 0x040025A6 RID: 9638
		[Token(Token = "0x40025A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E470", Offset = "0x110E470")]
		public uint vehicle_display_id;
	}
}
