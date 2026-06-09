using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000961 RID: 2401
	[Token(Token = "0x2000961")]
	[ProtoContract]
	public class CSAccelerateCashPrinterByTokenReq
	{
		// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x21B0090", Offset = "0x21B0090", VA = "0x7BBC9B0090")]
		public CSAccelerateCashPrinterByTokenReq()
		{
		}

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119500", Offset = "0x1119500")]
		public uint cost_token_cnt;
	}
}
