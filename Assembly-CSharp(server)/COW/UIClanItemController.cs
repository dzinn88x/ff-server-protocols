using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001727 RID: 5927
	[Token(Token = "0x2001727")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F194C", Offset = "0x10F194C")]
	internal class UIClanItemController : UIClanBaseItemController
	{
		// Token: 0x06006EC4 RID: 28356 RVA: 0x0001F278 File Offset: 0x0001D478
		[Token(Token = "0x6006EC4")]
		[Address(RVA = "0x1CFB21C", Offset = "0x1CFB21C", VA = "0x7BBC4FB21C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC5")]
		[Address(RVA = "0x1CFB26C", Offset = "0x1CFB26C", VA = "0x7BBC4FB26C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC6")]
		[Address(RVA = "0x1CFB418", Offset = "0x1CFB418", VA = "0x7BBC4FB418")]
		public UIClanItemController()
		{
		}

		// Token: 0x04008932 RID: 35122
		[Token(Token = "0x4008932")]
		[FieldOffset(Offset = "0xE8")]
		private UIClanItemView m_View;
	}
}
