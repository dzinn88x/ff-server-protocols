using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AFE RID: 6910
	[Token(Token = "0x2001AFE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9144", Offset = "0x10F9144")]
	public class UIPopMenuBigController : UIPopMenuSmallControler
	{
		// Token: 0x060092DC RID: 37596 RVA: 0x00027138 File Offset: 0x00025338
		[Token(Token = "0x60092DC")]
		[Address(RVA = "0x20E8C00", Offset = "0x20E8C00", VA = "0x7BBC8E8C00")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DD")]
		[Address(RVA = "0x20E8C50", Offset = "0x20E8C50", VA = "0x7BBC8E8C50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DE")]
		[Address(RVA = "0x20E8DC4", Offset = "0x20E8DC4", VA = "0x7BBC8E8DC4", Slot = "34")]
		protected override void AdjustScrollView()
		{
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092DF")]
		[Address(RVA = "0x20E9158", Offset = "0x20E9158", VA = "0x7BBC8E9158", Slot = "37")]
		protected override void ShowPopUpItem()
		{
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092E0")]
		[Address(RVA = "0x20EA70C", Offset = "0x20EA70C", VA = "0x7BBC8EA70C", Slot = "40")]
		protected override void OnPopMenuClose()
		{
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092E1")]
		[Address(RVA = "0x20EA970", Offset = "0x20EA970", VA = "0x7BBC8EA970")]
		public UIPopMenuBigController()
		{
		}

		// Token: 0x04009D26 RID: 40230
		[Token(Token = "0x4009D26")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIPopMenuItemBigController> m_UIPopMenuItemBigControllerList;

		// Token: 0x04009D27 RID: 40231
		[Token(Token = "0x4009D27")]
		public const int BIGCELLHEIGHT = 46;
	}
}
