using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001105 RID: 4357
	[Token(Token = "0x2001105")]
	public class GraphicQualityConfigData : SingletonModule<GraphicQualityConfigData>
	{
		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x1D8EB18", Offset = "0x1D8EB18", VA = "0x7BBC58EB18", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x1D8F834", Offset = "0x1D8F834", VA = "0x7BBC58F834", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004415")]
		[Address(RVA = "0x1D8EB1C", Offset = "0x1D8EB1C", VA = "0x7BBC58EB1C")]
		private void LoadDataFromConfig()
		{
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004416")]
		[Address(RVA = "0x1D8F894", Offset = "0x1D8F894", VA = "0x7BBC58F894")]
		public GraphicConfigItem GetCurrentConfig()
		{
			return null;
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004417")]
		[Address(RVA = "0x1D8F9AC", Offset = "0x1D8F9AC", VA = "0x7BBC58F9AC")]
		public GraphicQualityConfigData()
		{
		}

		// Token: 0x0400541C RID: 21532
		[Token(Token = "0x400541C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, Dictionary<int, GraphicConfigItem>> m_QualityConfigDic;
	}
}
