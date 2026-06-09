using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D2B RID: 7467
	[Token(Token = "0x2001D2B")]
	public class UIManualMapSupplyData : UIManualDataBase
	{
		// Token: 0x0600A29F RID: 41631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A29F")]
		[Address(RVA = "0x18E659C", Offset = "0x18E659C", VA = "0x7BBC0E659C", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A0")]
		[Address(RVA = "0x18E65CC", Offset = "0x18E65CC", VA = "0x7BBC0E65CC")]
		private void GetInMapData()
		{
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2A1")]
		[Address(RVA = "0x18E6808", Offset = "0x18E6808", VA = "0x7BBC0E6808")]
		public UIManualMapSupplyData()
		{
		}

		// Token: 0x0400A8DB RID: 43227
		[Token(Token = "0x400A8DB")]
		[FieldOffset(Offset = "0x60")]
		public List<ManualInMapData> m_InMapDataList;

		// Token: 0x02001D2C RID: 7468
		[Token(Token = "0x2001D2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB74", Offset = "0x10FBB74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A2A3 RID: 41635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A2A3")]
			[Address(RVA = "0x18E68DC", Offset = "0x18E68DC", VA = "0x7BBC0E68DC")]
			public <>c()
			{
			}

			// Token: 0x0600A2A4 RID: 41636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A2A4")]
			[Address(RVA = "0x18E68E4", Offset = "0x18E68E4", VA = "0x7BBC0E68E4")]
			internal ManualInMapData <GetInMapData>b__2_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0600A2A5 RID: 41637 RVA: 0x0002AA98 File Offset: 0x00028C98
			[Token(Token = "0x600A2A5")]
			[Address(RVA = "0x18E6964", Offset = "0x18E6964", VA = "0x7BBC0E6964")]
			internal bool <GetInMapData>b__2_1(ManualInMapData e)
			{
				return default(bool);
			}

			// Token: 0x0400A8DC RID: 43228
			[Token(Token = "0x400A8DC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIManualMapSupplyData.<>c <>9;

			// Token: 0x0400A8DD RID: 43229
			[Token(Token = "0x400A8DD")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, ManualInMapData> <>9__2_0;

			// Token: 0x0400A8DE RID: 43230
			[Token(Token = "0x400A8DE")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<ManualInMapData> <>9__2_1;
		}
	}
}
