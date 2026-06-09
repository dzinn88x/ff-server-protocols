using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D2D RID: 7469
	[Token(Token = "0x2001D2D")]
	public class UIManualMapEventData : UIManualDataBase
	{
		// Token: 0x0600A2A6 RID: 41638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A6")]
		[Address(RVA = "0x18E1278", Offset = "0x18E1278", VA = "0x7BBC0E1278", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A7")]
		[Address(RVA = "0x18E12B4", Offset = "0x18E12B4", VA = "0x7BBC0E12B4")]
		protected void GetInMapData(EManual.EventType type)
		{
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A8")]
		[Address(RVA = "0x18E14B8", Offset = "0x18E14B8", VA = "0x7BBC0E14B8")]
		public UIManualMapEventData()
		{
		}

		// Token: 0x0400A8DF RID: 43231
		[Token(Token = "0x400A8DF")]
		[FieldOffset(Offset = "0x60")]
		public List<ManualInMapData> m_InMapDataList;

		// Token: 0x0400A8E0 RID: 43232
		[Token(Token = "0x400A8E0")]
		[FieldOffset(Offset = "0x68")]
		public float m_IconScale;

		// Token: 0x02001D2E RID: 7470
		[Token(Token = "0x2001D2E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB84", Offset = "0x10FBB84")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600A2A9 RID: 41641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2A9")]
			[Address(RVA = "0x18E14B0", Offset = "0x18E14B0", VA = "0x7BBC0E14B0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600A2AA RID: 41642 RVA: 0x0002AAB0 File Offset: 0x00028CB0
			[Token(Token = "0x600A2AA")]
			[Address(RVA = "0x18E1614", Offset = "0x18E1614", VA = "0x7BBC0E1614")]
			internal bool <GetInMapData>b__1(ManualInMapData e)
			{
				return default(bool);
			}

			// Token: 0x0400A8E1 RID: 43233
			[Token(Token = "0x400A8E1")]
			[FieldOffset(Offset = "0x10")]
			public EManual.EventType type;
		}

		// Token: 0x02001D2F RID: 7471
		[Token(Token = "0x2001D2F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB94", Offset = "0x10FBB94")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A2AC RID: 41644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2AC")]
			[Address(RVA = "0x18E158C", Offset = "0x18E158C", VA = "0x7BBC0E158C")]
			public <>c()
			{
			}

			// Token: 0x0600A2AD RID: 41645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A2AD")]
			[Address(RVA = "0x18E1594", Offset = "0x18E1594", VA = "0x7BBC0E1594")]
			internal ManualInMapData <GetInMapData>b__3_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0400A8E2 RID: 43234
			[Token(Token = "0x400A8E2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIManualMapEventData.<>c <>9;

			// Token: 0x0400A8E3 RID: 43235
			[Token(Token = "0x400A8E3")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, ManualInMapData> <>9__3_0;
		}
	}
}
