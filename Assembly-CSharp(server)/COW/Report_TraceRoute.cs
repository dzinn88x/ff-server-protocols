using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001E27 RID: 7719
	[Token(Token = "0x2001E27")]
	public class Report_TraceRoute
	{
		// Token: 0x0600A8CD RID: 43213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CD")]
		[Address(RVA = "0x175C9E0", Offset = "0x175C9E0", VA = "0x7BBBF5C9E0")]
		public Report_TraceRoute()
		{
		}

		// Token: 0x0400AE1A RID: 44570
		[Token(Token = "0x400AE1A")]
		[FieldOffset(Offset = "0x10")]
		public byte build_variant_type;

		// Token: 0x0400AE1B RID: 44571
		[Token(Token = "0x400AE1B")]
		[FieldOffset(Offset = "0x18")]
		public string region;

		// Token: 0x0400AE1C RID: 44572
		[Token(Token = "0x400AE1C")]
		[FieldOffset(Offset = "0x20")]
		public string country;

		// Token: 0x0400AE1D RID: 44573
		[Token(Token = "0x400AE1D")]
		[FieldOffset(Offset = "0x28")]
		public string phone_carrier;

		// Token: 0x0400AE1E RID: 44574
		[Token(Token = "0x400AE1E")]
		[FieldOffset(Offset = "0x30")]
		public string client_ip;

		// Token: 0x0400AE1F RID: 44575
		[Token(Token = "0x400AE1F")]
		[FieldOffset(Offset = "0x38")]
		public List<PingResult> ping_results;

		// Token: 0x0400AE20 RID: 44576
		[Token(Token = "0x400AE20")]
		[FieldOffset(Offset = "0x40")]
		public List<TracerouteResult> trace_results;
	}
}
